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
        const string ValidCaCertificatePath = "ValidCaCertificate.cer";
        const string InvalidCaCertificatePath = "InvalidCaCertificate.cer";
        const string ServerCertificatePath = "serverCertificate.cer";
        const string ClientCertificatePath = "clientCertificate.cer";

        X509Certificate2 ClientCertificate { get; set; }
        X509Certificate2 ServerCertificate { get; set; }

        [OneTimeSetUp]
        public void BuildCerts()
        {
            var caCertificate = CreateCACertificate();
            File.WriteAllBytes(ValidCaCertificatePath, caCertificate.Export(X509ContentType.Cert));

            var serverCertificate = CreateServerCertificate(caCertificate);
            File.WriteAllBytes(ServerCertificatePath, serverCertificate.Export(X509ContentType.Cert));
            ServerCertificate = serverCertificate;

            var clientCertificate = CreateClientCertificate(caCertificate);
            File.WriteAllBytes(ClientCertificatePath, clientCertificate.Export(X509ContentType.Cert));
            ClientCertificate = clientCertificate;

            var invalidCaCertificate = CreateCACertificate();
            File.WriteAllBytes(InvalidCaCertificatePath, invalidCaCertificate.Export(X509ContentType.Cert));
        }

        [OneTimeTearDown]
        public void ClearCerts()
        {
            File.Delete(ValidCaCertificatePath);
            File.Delete(InvalidCaCertificatePath);
            File.Delete(ServerCertificatePath);
            File.Delete(ClientCertificatePath);
        }

        static X509Certificate2 CreateCACertificate()
        {
            var rsa = RSA.Create();
            var request = new CertificateRequest("CN=127.0.0.1 Test CA", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, true));
            request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.CrlSign, true));
            request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

            X509Certificate2 certificate = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(5));
            return certificate;
        }

        static X509Certificate2 CreateServerCertificate(X509Certificate2 caCertificate)
        {
            var rsa = RSA.Create();
            var request = new CertificateRequest($"CN=127.0.0.1 Server Test", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            var enhancedKeyUsages = new OidCollection
            {
                new Oid("1.3.6.1.5.5.7.3.1"), // OID for Server Authentication
            };
            request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(enhancedKeyUsages, false));

            X509Certificate2 certificate = request.Create(caCertificate, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(1), [0, 0, 0, 0, 0, 0, 0, 1]);
            byte[] cerBytes = certificate.Export(X509ContentType.Cert);
            File.WriteAllBytes("serverCertificate.cer", cerBytes);
            return certificate;
        }

        static X509Certificate2 CreateClientCertificate(X509Certificate2 caCertificate)
        {
            var rsa = RSA.Create();
            var request = new CertificateRequest($"CN=127.0.0.1 Client Test", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            var enhancedKeyUsages = new OidCollection
            {
                new Oid("1.3.6.1.5.5.7.3.2")  // OID for Client Authentication
            };
            request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(enhancedKeyUsages, false));

            X509Certificate2 certificate = request.Create(caCertificate, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(1), [0, 0, 0, 0, 0, 0, 0, 2]);
            byte[] cerBytes = certificate.Export(X509ContentType.Cert);
            File.WriteAllBytes(ClientCertificatePath, cerBytes);
            return certificate;
        }

        [Test]
        public void VerifyServerCertificateEnhancedUsage()
        {
            SettingsDictionary dict = new();
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
            dict.SetString(SessionSettings.SSL_CERTIFICATE, ServerCertificatePath);
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, ValidCaCertificatePath);
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, true);

            var settings = new SocketSettings();
            settings.Configure(dict);

            var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
            var factory = new SslStreamFactory(settings, logger);

            var resultServer = factory.VerifyRemoteCertificate(ServerCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
            var resultClient = factory.VerifyRemoteCertificate(ServerCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

            Assert.That(resultServer, Is.True);
            Assert.That(resultClient, Is.False);
        }

        [Test]
        public void VerifyServerCertificateFailsWithWrongCA()
        {
            SettingsDictionary dict = new();
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
            dict.SetString(SessionSettings.SSL_CERTIFICATE, ServerCertificatePath);
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, InvalidCaCertificatePath);
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, true);

            var settings = new SocketSettings();
            settings.Configure(dict);

            var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
            var factory = new SslStreamFactory(settings, logger);

            var resultServer = factory.VerifyRemoteCertificate(ServerCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
            var resultClient = factory.VerifyRemoteCertificate(ServerCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

            Assert.That(resultServer, Is.False);
            Assert.That(resultClient, Is.False);
        }

        [Test]
        public void VerifyClientCertificateEnhancedUsage()
        {
            SettingsDictionary dict = new();
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
            dict.SetString(SessionSettings.SSL_CERTIFICATE, ClientCertificatePath);
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, ValidCaCertificatePath);
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, true);

            var settings = new SocketSettings();
            settings.Configure(dict);

            var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
            var factory = new SslStreamFactory(settings, logger);

            var resultServer = factory.VerifyRemoteCertificate(ClientCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
            var resultClient = factory.VerifyRemoteCertificate(ClientCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

            Assert.That(resultServer, Is.False);
            Assert.That(resultClient, Is.True);
        }

        [Test]
        public void VerifyClientCertificateFailsWithWrongCA()
        {
            SettingsDictionary dict = new();
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
            dict.SetString(SessionSettings.SSL_CERTIFICATE, ClientCertificatePath);
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, InvalidCaCertificatePath);
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, true);

            var settings = new SocketSettings();
            settings.Configure(dict);

            var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
            var factory = new SslStreamFactory(settings, logger);

            var resultServer = factory.VerifyRemoteCertificate(ClientCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
            var resultClient = factory.VerifyRemoteCertificate(ClientCertificate, System.Net.Security.SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

            Assert.That(resultServer, Is.False);
            Assert.That(resultClient, Is.False);
        }
    }
}
