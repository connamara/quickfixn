using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.Extensions.Logging;
using QuickFix.Util;

namespace QuickFix.Transport;

internal static class SslCertCache {

    /// <summary>
    /// Cache loaded certificates since loading a certificate can be a costly operation
    /// </summary>
    private static readonly Dictionary<string, X509Certificate2> CertificateCache = new();
    private static readonly Lock CertificateCacheLock = new();

    /// <summary>
    /// Loads the specified certificate given a path, DistinguishedName or subject name
    /// </summary>
    /// <param name="name">The certificate path or DistinguishedName/subjectname
    /// if it should be loaded from the personal certificate store.</param>
    /// <param name="password">The certificate password.</param>
    /// <param name="log">Logger used to report a certificate that could not be loaded.</param>
    /// <returns>The specified certificate, or null if it could not be loaded (the reason is logged)</returns>
    internal static X509Certificate2? LoadCertificate(string name, string? password, ILogger log)
    {
        lock (CertificateCacheLock)
        {
            if (CertificateCache.TryGetValue(name, out X509Certificate2? certificate))
                return certificate;

            try {
                certificate = LoadCertificateInner(name, password);
                CertificateCache.Add(name, certificate);

                return certificate;
            } catch (ApplicationException ex) {
                log.Log(LogLevel.Error, ex, "Unable to load certificate: {Message}", ex.Message);
                return null;
            }
        }
    }

    /// <summary>
    /// Perform the actual loading of a certificate
    /// </summary>
    /// <param name="name">The certificate path or DistinguishedName/subjectname if it should be loaded from the personal certificate store.</param>
    /// <param name="password">The certificate password.</param>
    /// <exception cref="ApplicationException">Certificate could not be loaded from file or store</exception>
    /// <returns>The specified certificate</returns>
    private static X509Certificate2 LoadCertificateInner(string name, string? password)
    {
        var certPath = StringUtil.FixSlashes(name);

        // If cert file not found, then try to get from certificate store
        if (!File.Exists(certPath))
        {
            var certFromStore = GetCertificateFromStore(StringUtil.FixSlashes(name));
            if (certFromStore is not null)
                return certFromStore;

            string msg =
                $"Certificate '{name}' could not be loaded from store or path '{Directory.GetCurrentDirectory()}'";
            throw new ApplicationException(msg);
        }

        // Public certificate files (DER/PEM, e.g. CA .cer) are not PKCS#12,
        //   so try those first and fall back to PKCS#12 (PFX) if the file is not a plain certificate.
        // The PKCS#12 call goes last so its exceptions (e.g. wrong password) surface.
        try
        {
            return X509CertificateLoader.LoadCertificateFromFile(certPath);
        }
        catch (CryptographicException)
        {
            return X509CertificateLoader.LoadPkcs12FromFile(certPath, password);
        }
    }

    /// <summary>
    /// Gets the certificate from store.
    /// </summary>
    /// <remarks>See http://msdn.microsoft.com/en-us/library/system.security.cryptography.x509certificates.x509certificate2.aspx for complete example</remarks>
    /// <param name="certName">Name of the cert.</param>
    /// <returns>The cert, or null if not found</returns>
    private static X509Certificate2? GetCertificateFromStore(string certName)
    {
        // On Unix-like systems, LocalMachine does not behave like the Windows "My" store.
        // Opening it can throw e.g. "Unix localMachine x509Store is limited to the root and certificateauthority stores."
        // For the certificate lookup used here, the CurrentUser store is the portable fallback.

        List<StoreLocation> storeLocs = [];
        if (OperatingSystem.IsWindows())
            storeLocs.Add(StoreLocation.LocalMachine);
        storeLocs.Add(StoreLocation.CurrentUser);

        foreach (StoreLocation loc in storeLocs)
        {
            X509Certificate2? cert = GetCertificateFromStoreHelper(certName, new X509Store(loc));
            if (cert is not null)
                return cert;
        }

        return null;
    }

    private static X509Certificate2? GetCertificateFromStoreHelper(string certName, X509Store store)
    {
        try
        {
            store.Open(OpenFlags.ReadOnly);

            // Place all certificates in an X509Certificate2Collection object.
            X509Certificate2Collection certCollection = store.Certificates;
            // If using a certificate with a trusted root you do not need to FindByTimeValid, instead:
            // currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, true);
            X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);

            currentCerts = currentCerts.Find(certName.Contains("CN=")
                ? X509FindType.FindBySubjectDistinguishedName
                : X509FindType.FindBySubjectName, certName, false);

            if (currentCerts.Count == 0)
                return null;

            return currentCerts[0];
        }
        catch (CryptographicException)
        {
            // Some stores are not available on non-Windows platforms or are restricted by OS policy.
            return null;
        }
        catch (PlatformNotSupportedException)
        {
            return null;
        }
        finally
        {
            store.Close();
        }
    }
}
