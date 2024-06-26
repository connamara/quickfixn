#nullable enable
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using QuickFix.Logger;
using QuickFix.Util;

namespace QuickFix.Transport;

/// <summary>
/// The SSLClientStreamFactory is responsible for setting up a SSLStream in either client or server mode
/// </summary>
internal sealed class SslStreamFactory
{
    private readonly SocketSettings _socketSettings;
    private readonly NonSessionLog _nonSessionLog;
    private const string CLIENT_AUTHENTICATION_OID = "1.3.6.1.5.5.7.3.2";
    private const string SERVER_AUTHENTICATION_OID = "1.3.6.1.5.5.7.3.1";

    public SslStreamFactory(SocketSettings settings, NonSessionLog nonSessionLog)
    {
        _socketSettings = settings;
        _nonSessionLog = nonSessionLog;
    }

    /// <summary>
    /// Creates a SslStream in client mode and authenticate.
    /// </summary>
    /// <param name="innerStream">The stream to use for the actual (ssl encrypted) communication.</param>
    /// <returns>a ssl enabled stream</returns>
    public Stream CreateClientStreamAndAuthenticate(Stream innerStream)
    {
        SslStream sslStream = new SslStream(
            innerStream,
            false,
            ValidateServerCertificate,
#pragma warning disable CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).
            // Per MS docs, this delegate /should/ have a nullable return type
            SelectLocalCertificate);
#pragma warning restore CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).

        try
        {
            // Setup secure SSL Communication
            X509CertificateCollection clientCertificates = GetClientCertificates();
            sslStream.AuthenticateAsClient(_socketSettings.ServerCommonName,
                clientCertificates,
                _socketSettings.SslProtocol,
                _socketSettings.CheckCertificateRevocation);
        }
        catch (AuthenticationException ex)
        {
            _nonSessionLog.OnEvent($"Unable to perform authentication against server: {ex.GetFullMessage()}");
            throw;
        }

        return sslStream;
    }

    /// <summary>
    /// Creates a SslStream in server mode and authenticate.
    /// </summary>
    /// <param name="innerStream">The stream to use for the actual (ssl encrypted) communication.</param>
    /// <returns>a ssl enabled stream</returns>
    public Stream CreateServerStreamAndAuthenticate(Stream innerStream)
    {
        SslStream sslStream = new SslStream(
            innerStream,
            false,
            ValidateClientCertificate,
#pragma warning disable CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).
            // Per MS docs, this delegate /should/ have a nullable return type
            SelectLocalCertificate);
#pragma warning restore CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).

        try
        {
            if (string.IsNullOrEmpty(_socketSettings.CertificatePath))
                throw new Exception($"No server certificate specified, the {SessionSettings.SSL_CERTIFICATE} setting must be configured");

            // Setup secure SSL Communication
            X509Certificate2? serverCertificate = SslCertCache.LoadCertificate(_socketSettings.CertificatePath, _socketSettings.CertificatePassword);
            if (serverCertificate is null) {
                throw new AuthenticationException("Failed to load ServerCertificate");
            }

            sslStream.AuthenticateAsServer(new SslServerAuthenticationOptions
            {
                ServerCertificate = serverCertificate,
                ClientCertificateRequired = _socketSettings.RequireClientCertificate,
                EnabledSslProtocols = _socketSettings.SslProtocol,
                CertificateRevocationCheckMode = _socketSettings.CheckCertificateRevocation ? X509RevocationMode.Online : X509RevocationMode.NoCheck,
                EncryptionPolicy = EncryptionPolicy.RequireEncryption
            });
        }
        catch (AuthenticationException ex)
        {
            _nonSessionLog.OnEvent($"Unable to perform authentication against server: {ex.GetFullMessage()}");
            throw;
        }

        return sslStream;
    }

    private X509CertificateCollection GetClientCertificates()
    {
        var rv = new X509Certificate2Collection();
        if (!string.IsNullOrEmpty(_socketSettings.CertificatePath))
        {
            X509Certificate2? clientCert = SslCertCache.LoadCertificate(_socketSettings.CertificatePath, _socketSettings.CertificatePassword);
            if (clientCert is not null)
                rv.Add(clientCert);
        }

        return rv;
    }

    /// <summary>
    /// Perform validation of the servers certificate. (the initiator validates the server/acceptors certificate)
    /// (Satisfies interface to delegate System.Net.Security.RemoteCertificateValidationCallback)
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="certificate">The certificate.</param>
    /// <param name="chain">The chain.</param>
    /// <param name="sslPolicyErrors">The SSL policy errors.</param>
    /// <returns> <c>true</c> if the certificate should be treated as trusted; otherwise <c>false</c> </returns>
    private bool ValidateServerCertificate(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
    {
        return VerifyRemoteCertificate(certificate, sslPolicyErrors, SERVER_AUTHENTICATION_OID);
    }

    /// <summary>
    /// Perform validation of a a client certificate.(the acceptor validates the client/initiators certificate)
    /// (Satisfies interface to delegate System.Net.Security.RemoteCertificateValidationCallback)
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="certificate">The certificate.</param>
    /// <param name="chain">The chain.</param>
    /// <param name="sslPolicyErrors">The SSL policy errors.</param>
    /// <returns> <c>true</c> if the certificate should be treated as trusted; otherwise <c>false</c> </returns>
    private bool ValidateClientCertificate(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
    {
        return VerifyRemoteCertificate(certificate, sslPolicyErrors, CLIENT_AUTHENTICATION_OID);
    }

    /// <summary>
    /// Perform certificate validation common for both server and client.
    /// </summary>
    /// <param name="certificate">The remote certificate to validate.</param>
    /// <param name="sslPolicyErrors">The SSL policy errors supplied by .Net.</param>
    /// <param name="enhancedKeyUsage">Enhanced key usage, which the remote computers certificate should contain.</param>
    /// <returns> <c>true</c> if the certificate should be treated as trusted; otherwise <c>false</c> </returns>
    private bool VerifyRemoteCertificate(
        X509Certificate? certificate,
        SslPolicyErrors sslPolicyErrors,
        string enhancedKeyUsage)
    {
        // Accept without looking at if the certificate is valid if validation is disabled
        if (_socketSettings.ValidateCertificates == false)
            return true;

        if (certificate is null)
            return false;

        // Validate enhanced key usage
        if (!ContainsEnhancedKeyUsage(certificate, enhancedKeyUsage)) {
            var role = enhancedKeyUsage == CLIENT_AUTHENTICATION_OID ? "client" : "server";
            _nonSessionLog.OnEvent(
                $"Remote certificate is not intended for {role} authentication: It is missing enhanced key usage {enhancedKeyUsage}");
            return false;
        }

        if (string.IsNullOrEmpty(_socketSettings.CACertificatePath)) {
            _nonSessionLog.OnEvent("CACertificatePath is not specified");
            return false;
        }

        string caCertPath = StringUtil.FixSlashes(_socketSettings.CACertificatePath);

        // If CA Certificate is specified then validate against the CA certificate, otherwise it is validated against the installed certificates
        X509Certificate2? cert = SslCertCache.LoadCertificate(caCertPath, null);
        if (cert is null) {
            _nonSessionLog.OnEvent(
                $"Certificate '{caCertPath}' could not be loaded from store or path '{Directory.GetCurrentDirectory()}'");
            return false;
        }

        X509Chain chain0 = new X509Chain();
        chain0.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
        // add all your extra certificate chain

        chain0.ChainPolicy.ExtraStore.Add(cert);
        chain0.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
        bool isValid = chain0.Build((X509Certificate2)certificate);

        if (isValid)
        {
            // resets the sslPolicyErrors.RemoteCertificateChainErrors status
            sslPolicyErrors &= ~SslPolicyErrors.RemoteCertificateChainErrors;
        }
        else
        {
            sslPolicyErrors |= SslPolicyErrors.RemoteCertificateChainErrors;
        }

        // Any basic authentication check failed, do after checking CA
        if (sslPolicyErrors != SslPolicyErrors.None)
        {
            _nonSessionLog.OnEvent($"Remote certificate was not recognized as a valid certificate: {sslPolicyErrors}");
            return false;
        }

        // No errors found accept the certificate
        return true;
    }

    /// <summary>
    /// Check if the given certificate contains the given enhanced key usage Oid
    /// </summary>
    /// <param name="certificate">X509 certificate</param>
    /// <param name="enhancedKeyOid">the oid to check if it is specified</param>
    /// <returns><c>true</c> if the oid is specified as an enhanced key usage; otherwise <c>false</c></returns>
    private static bool ContainsEnhancedKeyUsage(X509Certificate certificate, string enhancedKeyOid)
    {
        X509Certificate2 cert2 = certificate as X509Certificate2 ?? new X509Certificate2(certificate);

        foreach (X509Extension extension in cert2.Extensions)
        {
            if (extension is X509EnhancedKeyUsageExtension keyUsage)
            {
                foreach (System.Security.Cryptography.Oid oid in keyUsage.EnhancedKeyUsages)
                {
                    if (oid.Value == enhancedKeyOid)
                        return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    /// (Satisfies interface to delegate System.Net.Security.LocalCertificateSelectionCallback)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="targetHost"></param>
    /// <param name="localCertificates"></param>
    /// <param name="remoteCertificate"></param>
    /// <param name="acceptableIssuers"></param>
    /// <returns></returns>
    private static X509Certificate? SelectLocalCertificate(
        object sender,
        string targetHost,
        X509CertificateCollection localCertificates,
        X509Certificate? remoteCertificate,
        string[] acceptableIssuers)
    {
        // No certificate can be selected if we have no local certificates at all
        if (localCertificates.Count <= 0)
            return null;

        Debug.Assert(localCertificates is not null && localCertificates.Count > 0);

        //Otherwise we select the first availible certificate as per msdn documentation
        // http://msdn.microsoft.com/en-us/library/system.net.security.localcertificateselectioncallback.aspx
        if (acceptableIssuers.Length > 0)
        {
            // Use the first certificate that is from an acceptable issuer.
            foreach (X509Certificate certificate in localCertificates)
            {
                string issuer = certificate.Issuer;
                if (Array.IndexOf(acceptableIssuers, issuer) != -1)
                    return certificate;
            }
        }

        // Just use any certificate (if there is one)
        if (localCertificates.Count > 0)
            return localCertificates[0];

        return null;
    }
}
