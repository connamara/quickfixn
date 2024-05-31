#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace QuickFix;

internal static class SslCertCache {

    /// <summary>
    /// Cache loaded certificates since loading a certificate can be a costly operation
    /// </summary>
    private static readonly Dictionary<string, X509Certificate2> CertificateCache = new ();

    /// <summary>
    /// Loads the specified certificate given a path, DistinguishedName or subject name
    /// </summary>
    /// <param name="name">The certificate path or DistinguishedName/subjectname if it should be loaded from the personal certificate store.</param>
    /// <param name="password">The certificate password.</param>
    /// <returns>The specified certificate, or null if no certificate is found</returns>
    internal static X509Certificate2? LoadCertificate(string name, string? password)
    {
        // TODO: Change _certificateCache's type to ConcurrentDictionary once we start targeting .NET 4,
        //   then remove this lock and use GetOrAdd function of concurrent dictionary
        //   e.g.: certificate = _certificateCache.GetOrAdd(name, (key) => LoadCertificateInner(name, password));
        lock (CertificateCache)
        {
            if (CertificateCache.TryGetValue(name, out X509Certificate2? certificate))
                return certificate;

            certificate = LoadCertificateInner(name, password);

            if (certificate is not null)
                CertificateCache.Add(name, certificate);

            return certificate;
        }
    }

    /// <summary>
    /// Perform the actual loading of a certificate
    /// </summary>
    /// <param name="name">The certificate path or DistinguishedName/subjectname if it should be loaded from the personal certificate store.</param>
    /// <param name="password">The certificate password.</param>
    /// <returns>The specified certificate, or null if no certificate is found</returns>
    private static X509Certificate2? LoadCertificateInner(string name, string? password)
    {
        X509Certificate2? certificate;

        // If no extension is found try to get from certificate store
        if (!File.Exists(name))
        {
            certificate = GetCertificateFromStore(name);
        }
        else {
            certificate = password is not null
                ? new X509Certificate2(name, password)
                : new X509Certificate2(name);
        }
        return certificate;
    }

    /// <summary>
    /// Gets the certificate from store.
    /// </summary>
    /// <remarks>See http://msdn.microsoft.com/en-us/library/system.security.cryptography.x509certificates.x509certificate2.aspx for complete example</remarks>
    /// <param name="certName">Name of the cert.</param>
    /// <returns>The cert, or null if not found</returns>
    private static X509Certificate2? GetCertificateFromStore(string certName)
    {
        return GetCertificateFromStoreHelper(certName, new X509Store(StoreLocation.LocalMachine))
            ?? GetCertificateFromStoreHelper(certName, new X509Store(StoreLocation.CurrentUser));
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
        finally
        {
            store.Close();
        }
    }
}
