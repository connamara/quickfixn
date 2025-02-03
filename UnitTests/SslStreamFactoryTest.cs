using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using QuickFix.Logger;
using QuickFix.Transport;
using System;
using System.IO;

namespace UnitTests
{
    [TestFixture]
    public class SslStreamFactoryTest
    {
        static X509Certificate2 CreateServerCertificate()
        {
            var rsa = RSA.Create();
            var request = new CertificateRequest($"CN=127.0.0.1", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            var enhancedKeyUsages = new OidCollection
            {
                new Oid("1.3.6.1.5.5.7.3.1"), // OID for Server Authentication
            };
            request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(enhancedKeyUsages, false));

            X509Certificate2 certificate = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(1));
            byte[] cerBytes = certificate.Export(X509ContentType.Cert);
            File.WriteAllBytes("serverCertificate.cer", cerBytes);
            return certificate;
        }

        [Test]
        public void VerifyServerCertificateEnhancedUsage()
        {
            SettingsDictionary dict = new();
            dict.SetString(SessionSettings.SSL_SERVERNAME, "127.0.0.1");
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, "serverCertificate.cer");
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, true);
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_REQUIRE_CLIENT_CERTIFICATE, true);

            var settings = new SocketSettings();
            settings.Configure(dict);
            var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
            var factory = new SslStreamFactory(settings, logger);

            var certificate = CreateServerCertificate();

            var resultServer = factory.VerifyRemoteCertificate(certificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
            var resultClient = factory.VerifyRemoteCertificate(certificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

            Assert.That(resultServer, Is.True);
            Assert.That(resultClient, Is.False);
        }

        static X509Certificate2 CreateClientCertificate()
        {
            var rsa = RSA.Create();
            var request = new CertificateRequest($"CN=127.0.0.1", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            var enhancedKeyUsages = new OidCollection
            {
                new Oid("1.3.6.1.5.5.7.3.2")  // OID for Client Authentication
            };
            request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(enhancedKeyUsages, false));

            X509Certificate2 certificate = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(1));
            byte[] cerBytes = certificate.Export(X509ContentType.Cert);
            File.WriteAllBytes("clientCertificate.cer", cerBytes);
            return certificate;
        }

        [Test]
        public void VerifyClientCertificateEnhancedUsage()
        {
            SettingsDictionary dict = new();
            dict.SetString(SessionSettings.SSL_SERVERNAME, "127.0.0.1");
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, "clientCertificate.cer");
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, true);
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_REQUIRE_CLIENT_CERTIFICATE, true);

            var settings = new SocketSettings();
            settings.Configure(dict);
            var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
            var factory = new SslStreamFactory(settings, logger);

            var certificate = CreateClientCertificate();

            var resultServer = factory.VerifyRemoteCertificate(certificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
            var resultClient = factory.VerifyRemoteCertificate(certificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

            Assert.That(resultServer, Is.False);
            Assert.That(resultClient, Is.True);
        }
    }
}
