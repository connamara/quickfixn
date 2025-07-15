using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

const string CaCertificatePath = "..\\..\\..\\..\\QuickFixn-TestCA.cer";
const string ServerCertificatePath = "..\\..\\..\\..\\QuickFixn-TestServer.cer";
const string ServerPfxCertificatePath = "..\\..\\..\\..\\QuickFixn-TestServer.pfx";
const string ClientCertificatePath = "..\\..\\..\\..\\QuickFixn-TestClient.cer";
const string ClientPfxCertificatePath = "..\\..\\..\\..\\QuickFixn-TestClient.pfx";

const string PfxPassword = @"qfnpass123";

static X509Certificate2 CreateCACertificate()
{
    using var rsa = RSA.Create();
    var request = new CertificateRequest("CN=QuickFixn-TestCA", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    request.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, true));
    request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.CrlSign, true));
    request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

    X509Certificate2 certificate = request.CreateSelfSigned(DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(5));
    return certificate;
}

static X509Certificate2 CreateServerCertificate(X509Certificate2 caCertificate)
{
    using var rsa = RSA.Create();
    using (RSA caPrivateKey = caCertificate.GetRSAPrivateKey())
    {
        var request = new CertificateRequest($"CN=QuickFixn-TestServer", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
        request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DataEncipherment, true));
        request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

        var sanBuilder = new SubjectAlternativeNameBuilder();
        sanBuilder.AddIpAddress(new System.Net.IPAddress([127, 0, 0, 1]));
        request.CertificateExtensions.Add(sanBuilder.Build());

        var enhancedKeyUsages = new OidCollection
        {
            new Oid("1.3.6.1.5.5.7.3.1"), // OID for Server Authentication
        };
        request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(enhancedKeyUsages, true));

        X509Certificate2 certificate = request.Create(caCertificate, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(1), [0, 0, 0, 0, 0, 0, 0, 1]);
        return certificate.CopyWithPrivateKey(rsa);
    }
}

static X509Certificate2 CreateClientCertificate(X509Certificate2 caCertificate)
{
    using var rsa = RSA.Create();
    using (RSA caPrivateKey = caCertificate.GetRSAPrivateKey())
    {
        var request = new CertificateRequest($"CN=QuickFixn-TestClient", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
        request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DataEncipherment, true));
        request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

        var sanBuilder = new SubjectAlternativeNameBuilder();
        sanBuilder.AddIpAddress(new System.Net.IPAddress([127, 0, 0, 1]));
        request.CertificateExtensions.Add(sanBuilder.Build());

        var enhancedKeyUsages = new OidCollection
        {
            new Oid("1.3.6.1.5.5.7.3.2")  // OID for Client Authentication
        };
        request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension(enhancedKeyUsages, true));

        X509Certificate2 certificate = request.Create(caCertificate, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow.AddDays(1), [0, 0, 0, 0, 0, 0, 0, 2]);
        return certificate.CopyWithPrivateKey(rsa);
    }
}

var caCertificate = CreateCACertificate();
File.WriteAllBytes(CaCertificatePath, caCertificate.Export(X509ContentType.Cert));

var serverCertificate = CreateServerCertificate(caCertificate);
File.WriteAllBytes(ServerCertificatePath, serverCertificate.Export(X509ContentType.Cert));
File.WriteAllBytes(ServerPfxCertificatePath, serverCertificate.Export(X509ContentType.Pfx, PfxPassword));

var clientCertificate = CreateClientCertificate(caCertificate);
File.WriteAllBytes(ClientCertificatePath, clientCertificate.Export(X509ContentType.Cert));
File.WriteAllBytes(ClientPfxCertificatePath, clientCertificate.Export(X509ContentType.Pfx, PfxPassword));