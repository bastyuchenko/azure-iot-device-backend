using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Provisioning.Client;
using Microsoft.Azure.Devices.Provisioning.Client.Transport;
using Microsoft.Azure.Devices.Shared;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TestIssueForGit
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            X509Certificate2 x509Certificate = Helper.LoadProvisioningCertificate();
            var security = new SecurityProviderX509Certificate(x509Certificate);
            var provClient = ProvisioningDeviceClient.Create(
                "global.azure-devices-provisioning.net",
                Helper.IdScope,
                security,
                new ProvisioningTransportHandlerAmqp());

            var result = await provClient.RegisterAsync();

            IAuthenticationMethod auth = new DeviceAuthenticationWithX509Certificate(
                security.GetRegistrationID(),
                x509Certificate);

            var deviceClient = DeviceClient.Create(result.AssignedHub, auth, TransportType.Mqtt);

            await deviceClient.SetReceiveMessageHandlerAsync(
                async (Message messageC2D, object lbStatus) =>
                {
                    try
                    {

                        var messageC2DText = Encoding.UTF8.GetString(messageC2D.GetBytes());
                        var messageD2C = new Message(Encoding.UTF8.GetBytes(messageC2DText + "_ToCloud"));
                        await deviceClient.SendEventAsync(messageD2C);

                        await deviceClient.CompleteAsync(messageC2D);
                    }
                    catch (Exception ex)
                    {
                        await deviceClient.AbandonAsync(messageC2D);
                        throw;
                    }
                }, null);

            await Task.Delay(-1);
        }
    }
}