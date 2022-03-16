using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
        private readonly X509Certificate2 certificate;
        private readonly DeviceClient iotClient;

        public Device()
        {
            _parameters = new DeviceParameters();
            certificate = LoadProvisioningPfxCertificate();

            InitializeComponent();

            lbStatus.Text += "\r\nCreating X509 authentication for IoT Hub...";
            IAuthenticationMethod auth = new DeviceAuthenticationWithX509Certificate(
                tbDeviceId.Text,
                certificate);

            lbStatus.Text += "\r\nTesting the provisioned device with IoT Hub...";

            var clientCollection = new List<DeviceClient>();
            iotClient = DeviceClient.Create(tbAssignedHub.Text, auth, _parameters.TransportType);
            clientCollection.Add(iotClient);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            lbStatus.Text += "\r\nLoading the certificate...";
            var security = new SecurityProviderX509Certificate(certificate);
            lbStatus.Text += "\r\nInitializing the device provisioning client...";
            ProvisioningTransportHandler transport = new ProvisioningTransportHandlerAmqp();
            var provClient = ProvisioningDeviceClient.Create(
                _parameters.GlobalDeviceEndpoint,
                _parameters.IdScope,
                security,
                transport);

            lbStatus.Text += $"\r\nInitialized for registration Id {security.GetRegistrationID()}.";

            lbStatus.Text += "\r\nRegistering with the device provisioning service... ";
            var result = await provClient.RegisterAsync();
            tbDeviceId.Text = result.DeviceId;
            tbAssignedHub.Text = result.AssignedHub;

            lbStatus.Text += $"\r\nRegistration status: {result.Status}.";
            if (result.Status != ProvisioningRegistrationStatusType.Assigned)
                throw new Exception("Registration status did not assign a hub, so exiting this sample.");

            lbStatus.Text += $"\r\nDevice {tbDeviceId.Text} registered to {tbAssignedHub.Text}.";
        }

        private X509Certificate2 LoadProvisioningPfxCertificate()
        {
            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(workingDirectory, _parameters.CertificatePfxName);

            var cert = new X509Certificate2(path, _parameters.CertificatePassword);

            return cert;
        }

        private async void btnSendMsg_Click(object sender, EventArgs e)
        {
            lbStatus.Text += "\r\nSending a telemetry message...";
            var message = new Message(Encoding.UTF8.GetBytes(tbMsg.Text));
            await iotClient.SendEventAsync(message);

            await iotClient.CloseAsync();
            lbStatus.Text += "\r\nFinished.";
        }

        private async void btnStartReceiving_Click(object sender, EventArgs e)
        {
            lbStatus.Text += "\r\nReceiving cloud to device messages from service";

            IRetryPolicy retryPolicy = new ExponentialBackoff(int.MaxValue, TimeSpan.FromMilliseconds(100), TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(100));
            iotClient.SetRetryPolicy(retryPolicy);

            await iotClient.SetReceiveMessageHandlerAsync(ReceiveAsync, lbStatus).ConfigureAwait(false);
        }

        private async Task ReceiveAsync(Message message, object lbStatus)
        {
            ((TextBox)lbStatus).Text += $"\r\nReceived message: {Encoding.ASCII.GetString(message.GetBytes())}";

            await iotClient.CompleteAsync(message);
        }

        internal class DeviceParameters
        {
            /// <summary>
            ///     The CER certificate to load for device provisioning authentication.
            /// </summary>
            public string CertificateCerName = "certificate.cer";

            /// <summary>
            ///     "The password of the PFX certificate file. If not specified, the program will prompt at run time."
            /// </summary>
            public string CertificatePassword = ConfigurationSettings.AppSettings["CertificatePassword"];

            /// <summary>
            ///     "The PFX certificate to load for device provisioning authentication."
            /// </summary>
            public string CertificatePfxName = "certificate.pfx";

            /// <summary>
            ///     The global endpoint for devices to connect to.
            /// </summary>
            public string GlobalDeviceEndpoint = "global.azure-devices-provisioning.net";

            /// <summary>
            ///     The Id Scope of the DPS instance
            /// </summary>
            public string IdScope = ConfigurationSettings.AppSettings["IdScope"];

            /// <summary>
            ///     The transport to use to communicate with the device provisioning instance. Possible values include Mqtt,
            ///     Mqtt_WebSocket_Only, Mqtt_Tcp_Only, Amqp, Amqp_WebSocket_Only, Amqp_Tcp_only, and Http1.
            /// </summary>
            public TransportType TransportType = TransportType.Amqp;
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
            await iotClient.SetDesiredPropertyUpdateCallbackAsync(OnDesiredPropertyChanged, null);
        }

        private static async Task OnDesiredPropertyChanged(TwinCollection desiredProperties,
            object userContext)
        {
            MessageBox.Show(JsonConvert.SerializeObject(desiredProperties));
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

        private void Device_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}