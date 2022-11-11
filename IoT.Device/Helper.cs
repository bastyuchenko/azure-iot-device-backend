using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IoT.Device
{
    internal static class Helper
    {
        public static X509Certificate2 LoadProvisioningPfxCertificate(string certName, string certPassword)
        {
            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.Combine(workingDirectory, certName);

            var cert = new X509Certificate2(path, certPassword);

            return cert;
        }
    }
}
