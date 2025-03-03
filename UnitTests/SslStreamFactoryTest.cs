using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using NUnit.Framework;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Transport;
using System;
using System.IO;
using System.Net.Security;

namespace UnitTests;

[TestFixture]
public class SslStreamFactoryTest
{
    const string CaCertificatePath = "CaCertificate.cer";
    const string DifferentCaCertificatePath = "OtherCaCertificate.cer";
    const string ServerCertificatePath = "serverCertificate.cer";
    const string ClientCertificatePath = "clientCertificate.cer";

    X509Certificate2 CaCertificate { get; set; } = null!;
    X509Certificate2 ClientCertificate { get; set; } = null!;
    X509Certificate2 ServerCertificate { get; set; } = null!;

    [OneTimeSetUp]
    public void BuildCerts()
    {
        var caCertificate = CreateCACertificate();
        File.WriteAllBytes(CaCertificatePath, caCertificate.Export(X509ContentType.Cert));
        CaCertificate = caCertificate;

        var serverCertificate = CreateServerCertificate(caCertificate);
        File.WriteAllBytes(ServerCertificatePath, serverCertificate.Export(X509ContentType.Cert));
        ServerCertificate = serverCertificate;

        var clientCertificate = CreateClientCertificate(caCertificate);
        File.WriteAllBytes(ClientCertificatePath, clientCertificate.Export(X509ContentType.Cert));
        ClientCertificate = clientCertificate;

        var differentCaCertificate = CreateCACertificate();
        File.WriteAllBytes(DifferentCaCertificatePath, differentCaCertificate.Export(X509ContentType.Cert));
    }

    [OneTimeTearDown]
    public void ClearCerts()
    {
        File.Delete(CaCertificatePath);
        File.Delete(DifferentCaCertificatePath);
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
        return certificate;
    }

    [Test]
    public void VerifyServerLocalCertificateChainEnhancedUsage()
    {
        SettingsDictionary dict = new();
        dict.SetBool(SessionSettings.SSL_ENABLE, true);
        dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
        dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
        dict.SetString(SessionSettings.SSL_CERTIFICATE, ServerCertificatePath);
        dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, CaCertificatePath);

        var settings = new SocketSettings();
        settings.Configure(dict);

        var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
        var factory = new SslStreamFactory(settings, logger);

        var resultServer = factory.VerifyRemoteCertificate(ServerCertificate, SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
        var resultClient = factory.VerifyRemoteCertificate(ServerCertificate, SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

        Assert.That(resultServer, Is.True);
        Assert.That(resultClient, Is.False);
    }

    [Test]
    public void ServerLocalCertificateChainFailsWithoutCA()
    {
        SettingsDictionary dict = new();
        dict.SetBool(SessionSettings.SSL_ENABLE, true);
        dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
        dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
        dict.SetString(SessionSettings.SSL_CERTIFICATE, ServerCertificatePath);

        var settings = new SocketSettings();
        settings.Configure(dict);

        var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
        var factory = new SslStreamFactory(settings, logger);

        var resultServer = factory.VerifyRemoteCertificate(ServerCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.SERVER_AUTHENTICATION_OID);
        var resultClient = factory.VerifyRemoteCertificate(ServerCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

        Assert.That(resultServer, Is.False);
        Assert.That(resultClient, Is.False);
    }

    [Test]
    public void ServerLocalCertificateChainFailsWithWrongCA()
    {
        SettingsDictionary dict = new();
        dict.SetBool(SessionSettings.SSL_ENABLE, true);
        dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
        dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
        dict.SetString(SessionSettings.SSL_CERTIFICATE, ServerCertificatePath);
        dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, DifferentCaCertificatePath);

        var settings = new SocketSettings();
        settings.Configure(dict);

        var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
        var factory = new SslStreamFactory(settings, logger);

        var resultServer = factory.VerifyRemoteCertificate(ServerCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.SERVER_AUTHENTICATION_OID);
        var resultClient = factory.VerifyRemoteCertificate(ServerCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

        Assert.That(resultServer, Is.False);
        Assert.That(resultClient, Is.False);
    }

    [Test]
    public void VerifyClientLocalCertificateChainEnhancedUsage()
    {
        SettingsDictionary dict = new();
        dict.SetBool(SessionSettings.SSL_ENABLE, true);
        dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
        dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
        dict.SetString(SessionSettings.SSL_CERTIFICATE, ClientCertificatePath);
        dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, CaCertificatePath);

        var settings = new SocketSettings();
        settings.Configure(dict);

        var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
        var factory = new SslStreamFactory(settings, logger);

        var resultServer = factory.VerifyRemoteCertificate(ClientCertificate, SslPolicyErrors.None, SslStreamFactory.SERVER_AUTHENTICATION_OID);
        var resultClient = factory.VerifyRemoteCertificate(ClientCertificate, SslPolicyErrors.None, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

        Assert.That(resultServer, Is.False);
        Assert.That(resultClient, Is.True);
    }

    [Test]
    public void ClientLocalCertificateChainFailsWithoutCA()
    {
        SettingsDictionary dict = new();
        dict.SetBool(SessionSettings.SSL_ENABLE, true);
        dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
        dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
        dict.SetString(SessionSettings.SSL_CERTIFICATE, ClientCertificatePath);

        var settings = new SocketSettings();
        settings.Configure(dict);

        var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
        var factory = new SslStreamFactory(settings, logger);

        var resultServer = factory.VerifyRemoteCertificate(ClientCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.SERVER_AUTHENTICATION_OID);
        var resultClient = factory.VerifyRemoteCertificate(ClientCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

        Assert.That(resultServer, Is.False);
        Assert.That(resultClient, Is.False);
    }

    [Test]
    public void ClientLocalCertificateChainFailsWithWrongCA()
    {
        SettingsDictionary dict = new();
        dict.SetBool(SessionSettings.SSL_ENABLE, true);
        dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, true);
        dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
        dict.SetString(SessionSettings.SSL_CERTIFICATE, ClientCertificatePath);
        dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, DifferentCaCertificatePath);

        var settings = new SocketSettings();
        settings.Configure(dict);

        var logger = new NonSessionLog(new ScreenLogFactory(true, true, true));
        var factory = new SslStreamFactory(settings, logger);

        var resultServer = factory.VerifyRemoteCertificate(ClientCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.SERVER_AUTHENTICATION_OID);
        var resultClient = factory.VerifyRemoteCertificate(ClientCertificate, SslPolicyErrors.RemoteCertificateChainErrors, SslStreamFactory.CLIENT_AUTHENTICATION_OID);

        Assert.That(resultServer, Is.False);
        Assert.That(resultClient, Is.False);
    }
}
