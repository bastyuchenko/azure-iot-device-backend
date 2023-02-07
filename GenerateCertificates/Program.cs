using GenerateCertificates.Certificates;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace GenerateCertificates
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var provisioningCertificate = Certificate.GenerateRsaCertificate("iothubx509device1");
            var signatureVerifyCertificate = Certificate.GenerateEcdsaCertificate("iothubx509device1Ecdsa");

            await File.WriteAllTextAsync(
                    "deviceName-provisioning-cert.pem",
                provisioningCertificate.GetCertificate());

            await File.WriteAllTextAsync(
                    "deviceName-provisioning-key.pem",
                provisioningCertificate.GetPrivateKey());

            var provisioningCert = await File.ReadAllTextAsync("deviceName-provisioning-cert.pem");
            var provisioningKey = await File.ReadAllTextAsync("deviceName-provisioning-key.pem");

            var sslCert = X509Certificate2.CreateFromEncryptedPem(provisioningCert, provisioningKey, "Qwer!234");
            // https://github.com/dotnet/runtime/issues/23749#issuecomment-747407051
            var _provisioningCertificate = new X509Certificate2(sslCert.Export(X509ContentType.Pkcs12));
        }
    }
}

// https://learn.microsoft.com/en-us/azure/iot-dps/quick-enroll-device-x509?pivots=programming-language-csharp