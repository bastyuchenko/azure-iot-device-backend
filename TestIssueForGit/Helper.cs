using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace TestIssueForGit
{
    internal static class Helper
    {
        internal const string IdScope = "0ne0050D9A6";

        internal static X509Certificate2 LoadProvisioningCertificate(
            string certificateName= "deviceName-provisioning-cert.pem", 
            string certificatePrivateKeyName = "deviceName-provisioning-key.pem", 
            string certPassword="Qwer!234")
        {
            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var certificate = Path.Combine(workingDirectory, certificateName);
            var certificatePrivateKey = Path.Combine(workingDirectory, certificatePrivateKeyName);

            var provisioningCert = File.ReadAllText(certificate);
            var provisioningKey = File.ReadAllText(certificatePrivateKey);

            var sslCert = X509Certificate2.CreateFromEncryptedPem(provisioningCert, provisioningKey, certPassword);
            var _provisioningCertificate = new X509Certificate2(sslCert.Export(X509ContentType.Pkcs12));

            return _provisioningCertificate;
        }
    }
}
