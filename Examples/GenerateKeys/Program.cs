using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

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

const string CaCertificatePath = "..\\..\\..\\..\\QuickFixn-TestCA.cer";
const string ServerPfxCertificatePath = "..\\..\\..\\..\\QuickFixn-TestServer.pfx";
const string ClientPfxCertificatePath = "..\\..\\..\\..\\QuickFixn-TestClient.pfx";

const string PfxPassword = @"qfnpass123";

var caCertificate = CreateCACertificate();
File.WriteAllBytes(CaCertificatePath, caCertificate.Export(X509ContentType.Cert));

var serverCertificate = CreateServerCertificate(caCertificate);
File.WriteAllBytes(ServerPfxCertificatePath, serverCertificate.Export(X509ContentType.Pfx, PfxPassword));

var clientCertificate = CreateClientCertificate(caCertificate);
File.WriteAllBytes(ClientPfxCertificatePath, clientCertificate.Export(X509ContentType.Pfx, PfxPassword));