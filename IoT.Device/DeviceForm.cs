using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Provisioning.Client;
using Microsoft.Azure.Devices.Provisioning.Client.Transport;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Message = Microsoft.Azure.Devices.Client.Message;

namespace IoT.Device
{
    public partial class Device : Form
    {
        private readonly DeviceParameters _parameters;
        private readonly X509Certificate2 x509Certificate;
        private DeviceClient deviceClient;
        private CancellationTokenSource streamGenerationToken;
        private static ModuleClient moduleClient;

        public Device()
        {
            InitializeComponent();

            streamGenerationToken = new CancellationTokenSource();

            _parameters = new DeviceParameters();
            x509Certificate = Helper.LoadProvisioningPfxCertificate(_parameters.CertificatePfxName, _parameters.CertificatePassword);
            Log($"[DONE] PFX Certificate was loaded...");
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var security = new SecurityProviderX509Certificate(x509Certificate);
            Log("Initializing the device provisioning client...");
            var provClient = ProvisioningDeviceClient.Create(
                _parameters.GlobalDeviceEndpoint,
                _parameters.IdScope,
                security,
                new ProvisioningTransportHandlerAmqp());

            Log($"Initialized for registration Id {security.GetRegistrationID()}.");

            Log("Registering with the device provisioning service... ");
            var result = await provClient.RegisterAsync();
            tbDeviceId.Text = result.DeviceId;
            tbAssignedHub.Text = result.AssignedHub;

            Log($"Registration status: {result.Status}.");
            if (result.Status != ProvisioningRegistrationStatusType.Assigned)
                throw new Exception("Registration status did not assign a hub, so exiting this sample.");

            Log($"[DONE] Device {tbDeviceId.Text} registered to {result.AssignedHub}.");
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            Log("Creating X509 authentication for IoT Hub...");
            IAuthenticationMethod auth = new DeviceAuthenticationWithX509Certificate(
                tbDeviceId.Text,
                x509Certificate);

            deviceClient = DeviceClient.Create(tbAssignedHub.Text, auth, _parameters.TransportType);
            Log($"[DONE] Created DeviceClient instance to communicate through assigned IoT Hub...");



            moduleClient = ModuleClient.CreateFromConnectionString(_parameters.ModuleConnectionString, _parameters.TransportType);
            moduleClient.SetConnectionStatusChangesHandler(
                (ConnectionStatus status, ConnectionStatusChangeReason reason) =>
                {
                    MessageBox.Show($"Status {status} changed: {reason}");
                });
        }

        private async void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (deviceClient == null) { Log("Assigned IoT Hub name was not stored. Please register one more time to get IoT Hub name."); return; }

            Log("Sending a telemetry message...");
            var message = new Message(Encoding.UTF8.GetBytes(tbMsg.Text));
            await deviceClient.SendEventAsync(message);
            Log("Finished.");
        }

        private async void btnStartReceiving_Click(object sender, EventArgs e)
        {
            if (deviceClient == null) { Log("Assigned IoT Hub name was not stored. Please register one more time to get IoT Hub name."); return; }

            Log("Receiving cloud to device messages from service");

            IRetryPolicy retryPolicy = new ExponentialBackoff(int.MaxValue, TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(100));
            deviceClient.SetRetryPolicy(retryPolicy);

            await deviceClient.SetReceiveMessageHandlerAsync(
                async (Message message, object lbStatus) =>
                {
                    ((TextBox)tbReceivedMsg).AppendText(JsonConvert.SerializeObject(
                        new
                        {
                            Body = Encoding.UTF8.GetString(message.GetBytes()),
                            message.Properties,
                            message.MessageId,
                            message.To,
                            message.CorrelationId
                        }, Formatting.Indented));

                    await deviceClient.CompleteAsync(message);
                },
                lbStatus).ConfigureAwait(false);
        }

        private async void btnWReported_Click(object sender, EventArgs e)
        {
            TwinCollection reportedProperties, connectivity;
            reportedProperties = new TwinCollection();

            connectivity = new TwinCollection();
            connectivity["type"] = "cellular";
            reportedProperties["connectivity"] = connectivity;


            reportedProperties["body"] = tbDTReport.Text;

            await deviceClient.UpdateReportedPropertiesAsync(reportedProperties);
        }

        private async void btnRDesired_Click(object sender, EventArgs e)
        {
            await deviceClient.SetDesiredPropertyUpdateCallbackAsync(
                async (TwinCollection desiredProperties, object userContext) =>
            {
                tbDTRead.Text = JsonConvert.SerializeObject(desiredProperties);
            },
            null);
        }

        private async void btnGenStream_Click(object sender, EventArgs e)
        {
            streamGenerationToken = new CancellationTokenSource();

            // Initial telemetry values.
            double minTemperature = 20;
            double minHumidity = 60;
            var rand = new Random();

            try
            {
                while (!streamGenerationToken.Token.IsCancellationRequested)
                {
                    double currentTemperature = minTemperature + rand.NextDouble() * 15;
                    double currentHumidity = minHumidity + rand.NextDouble() * 20;

                    // Create JSON message.
                    string messageBody = JsonConvert.SerializeObject(
                        new
                        {
                            temperature = currentTemperature,
                            humidity = currentHumidity,
                        }, Formatting.Indented);

                    using var message = new Message(Encoding.ASCII.GetBytes(messageBody))
                    {
                        ContentType = "application/json",
                        ContentEncoding = "utf-8",
                    };

                    // Add a custom application property to the message.
                    // An IoT hub can filter on these properties without access to the message body.
                    message.Properties.Add("temperatureAlert", (currentTemperature > 30) ? "true" : "false");

                    // Send the telemetry message.
                    await deviceClient.SendEventAsync(message, streamGenerationToken.Token);
                    tbMsgsExample.AppendText(JsonConvert.SerializeObject(new
                    {
                        Body = messageBody,
                        message.ContentType,
                        message.ContentEncoding,
                        message.Properties
                    }, Formatting.Indented) + "\r\n");

                    await Task.Delay(TimeSpan.FromMilliseconds(500), streamGenerationToken.Token);
                }
            }
            catch (TaskCanceledException) { } // User canceled
        }

        private void btnGenerateStreamStop_Click(object sender, EventArgs e)
        {
            streamGenerationToken.Cancel();
        }

        private void Log(string text)
        {
            lbStatus.AppendText("\r\n" + text);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "";
        }

        private void Device_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void btnReadDT_Click(object sender, EventArgs e)
        {
            var twin = await deviceClient.GetTwinAsync();
            tbDTRead.Text = twin.ToJson(Formatting.Indented);
            Log("Device Twin content was read");
        }

        private async void btnModuleTwinDesiredPropsSubsr_Click(object sender, EventArgs e)
        {
            await moduleClient.SetDesiredPropertyUpdateCallbackAsync((TwinCollection desiredProperties, object userContext) => 
            {
                tbModuletwinDesProps.Text = JsonConvert.SerializeObject(desiredProperties);
                return Task.CompletedTask;
            }, null);
        }

        private async void btnModuleTwinRepProps_Click(object sender, EventArgs e)
        {
            TwinCollection reportedProperties = new TwinCollection
            {
                ["MyDateTimeLastDesiredPropertyChangeReceived"] = tbModuleTwinRepProps.Text
            };
            await moduleClient.UpdateReportedPropertiesAsync(reportedProperties);
        }
    }
}