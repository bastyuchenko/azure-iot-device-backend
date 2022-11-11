using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        private DeviceClient iotClient;

        public Device()
        {
            InitializeComponent();

            _parameters = new DeviceParameters();
            x509Certificate = Helper.LoadProvisioningPfxCertificate(_parameters.CertificatePfxName, _parameters.CertificatePassword);
            Log("PFX Certificate was loaded...");
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var security = new SecurityProviderX509Certificate(x509Certificate);
            Log("Initializing the device provisioning client...");
            ProvisioningTransportHandler transport = new ProvisioningTransportHandlerAmqp();
            var provClient = ProvisioningDeviceClient.Create(
                _parameters.GlobalDeviceEndpoint,
                _parameters.IdScope,
                security,
                transport);

            Log($"Initialized for registration Id {security.GetRegistrationID()}.");

            Log("Registering with the device provisioning service... ");
            var result = await provClient.RegisterAsync();
            tbDeviceId.Text = result.DeviceId;
            tbAssignedHub.Text = result.AssignedHub;

            Log($"Registration status: {result.Status}.");
            if (result.Status != ProvisioningRegistrationStatusType.Assigned)
                throw new Exception("Registration status did not assign a hub, so exiting this sample.");

            Log($"Device {tbDeviceId.Text} registered to {result.AssignedHub}.");

            Log("Creating X509 authentication for IoT Hub...");
            IAuthenticationMethod auth = new DeviceAuthenticationWithX509Certificate(
                tbDeviceId.Text,
                x509Certificate);

            iotClient = DeviceClient.Create(result.AssignedHub, auth, _parameters.TransportType);
            Log("Created DeviceClient instance to communicate through assigned IoT Hub...");
        }

        private async void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (iotClient == null) { Log("Assigned IoT Hub name was not stored. Please register one more time to get IoT Hub name."); return; }

            Log("Sending a telemetry message...");
            var message = new Message(Encoding.UTF8.GetBytes(tbMsg.Text));
            await iotClient.SendEventAsync(message);
            Log("Finished.");
        }

        private async void btnStartReceiving_Click(object sender, EventArgs e)
        {
            if (iotClient == null) { Log("Assigned IoT Hub name was not stored. Please register one more time to get IoT Hub name."); return; }

            Log("Receiving cloud to device messages from service");

            IRetryPolicy retryPolicy = new ExponentialBackoff(int.MaxValue, TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(100));
            iotClient.SetRetryPolicy(retryPolicy);

            await iotClient.SetReceiveMessageHandlerAsync(
                async (Message message, object lbStatus) =>
                {
                    ((TextBox)lbStatus).Text += $"\r\nReceived message:";
                    ((TextBox)lbStatus).Text += $"\r\n\t Body: {Encoding.UTF8.GetString(message.GetBytes())}";
                    ((TextBox)lbStatus).Text += "\r\n\t Properties: {" + string.Join(",", message.Properties.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}";

                    await iotClient.CompleteAsync(message);
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
            await iotClient.UpdateReportedPropertiesAsync(reportedProperties);
        }

        private async void btnRDesired_Click(object sender, EventArgs e)
        {
            await iotClient.SetDesiredPropertyUpdateCallbackAsync(
                async (TwinCollection desiredProperties, object userContext) =>
            {
                MessageBox.Show(JsonConvert.SerializeObject(desiredProperties));
            },
            null);
        }

        private async void btnGenStream_Click(object sender, EventArgs e)
        {
            JArray array = JArray.Parse(tbMsgsExample.Text);
            while (true)
            {
                foreach (JToken token in array)
                {
                    var message = new Message(Encoding.UTF8.GetBytes(token.ToString()));
                    await iotClient.SendEventAsync(message);
                    await Task.Delay(TimeSpan.FromMilliseconds(500));
                }
            }
        }

        private void Log(string text)
        {
            lbStatus.Text += "\r\n" + text;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "";
        }

        private void Device_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}