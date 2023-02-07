using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace GenerateCertificates.Certificates
{
    public class Certificate : IDisposable
    {
        private Certificate(X509Certificate2 exportableCertificate)
        {
            ExportableCertificate = exportableCertificate;
        }

        /// <summary>
        ///     Generates a self-signed RSA certificate.
        /// </summary>
        /// <remarks>
        ///     This method mimics working example from Microsoft
        ///     https://github.com/Azure/azure-iot-sdk-csharp/blob/main/provisioning/device/samples/getting%20started/X509Sample/GenerateTestCertificate.ps1
        /// </remarks>
        public static Certificate GenerateRsaCertificate(string certificateCommonName)
        {
            using var clientPrivateKey = RSA.Create(2048);
            var request = new CertificateRequest(
                new X500DistinguishedName($"CN={certificateCommonName}, O=TEST, C=US"),
                clientPrivateKey,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1);

            request.CertificateExtensions.Add(
                new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature, true));

            //request.CertificateExtensions.Add(
            //    new X509EnhancedKeyUsageExtension(
            //        new OidCollection
            //        { new("1.3.6.1.5.5.7.3.2") // clientAuth http://oid-info.com/get/1.3.6.1.5.5.7.3
            //                                    },
            //        false));

            return new Certificate(
                request.CreateSelfSigned(
                    DateTimeOffset.UtcNow.AddDays(-1),
                    DateTimeOffset.UtcNow.AddYears(10)));
        }


        /// <summary>
        ///     Generates a self-signed elliptic curve certificate.
        /// </summary>
        public static Certificate GenerateEcdsaCertificate(string certificateCommonName)
        {
            using var clientPrivateKey = ECDsa.Create(ECCurve.NamedCurves.nistP256);

            var request = new CertificateRequest(
                $"CN={certificateCommonName}",
                clientPrivateKey,
                HashAlgorithmName.SHA256);

            request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));

            return new Certificate(
                request.CreateSelfSigned(
                    new DateTimeOffset(DateTime.UtcNow.AddDays(-1)),
                    new DateTimeOffset(DateTime.UtcNow.AddYears(10))));
        }

        public string GetCertificate(bool withPrivateKey = false) =>
            withPrivateKey
                ? ExportableCertificate.ExportCertificatePem() + "\n" + GetPrivateKey()
                : ExportableCertificate.ExportCertificatePem();

        public static implicit operator X509Certificate2(Certificate cert) => cert.ExportableCertificate;

        public virtual void Dispose()
        {
            ExportableCertificate.Dispose();
        }

        private X509Certificate2 ExportableCertificate { get; }

        public string GetPrivateKey()
        {
            string keyPem;
            if (ExportableCertificate.GetRSAPrivateKey() is { } rsaKey)
            {
                //https://github.com/dotnet/runtime/issues/51597#issuecomment-823675868

                //keyPem = rsaKey.ExportRSAPrivateKeyPem();

                PbeParameters pbe = new PbeParameters(PbeEncryptionAlgorithm.Aes256Cbc, HashAlgorithmName.SHA256, 600_000);
                keyPem = rsaKey.ExportEncryptedPkcs8PrivateKeyPem("Qwer!234", pbe);

                //keyPem = rsaKey.ExportPkcs8PrivateKeyPem();
            }
            else if (ExportableCertificate.GetECDsaPrivateKey() is { } ecdsaKey)
            {
                keyPem = ecdsaKey.ExportECPrivateKeyPem();
            }
            else
            {
                throw new CryptographicException("Unknown certificate algorithm");
            }

            return keyPem;
        }
    }
}


