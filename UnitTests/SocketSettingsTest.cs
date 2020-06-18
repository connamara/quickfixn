﻿using System.Security.Authentication;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class SocketSettingsTest
    {
        [Test]
        public void DefaultValues()
        {
            SocketSettings socketSettings = new SocketSettings();

            Assert.IsTrue(socketSettings.SocketNodelay);
            Assert.IsNull(socketSettings.SocketReceiveBufferSize);
            Assert.IsNull(socketSettings.SocketSendBufferSize);
            Assert.IsNull(socketSettings.SocketReceiveTimeout);
            Assert.IsNull(socketSettings.SocketSendTimeout);
            Assert.IsNull(socketSettings.ServerCommonName);
            Assert.IsTrue(socketSettings.ValidateCertificates);
            Assert.IsNull(socketSettings.CertificatePath);
            Assert.IsNull(socketSettings.CertificatePassword);
            Assert.AreEqual(SslProtocols.None, socketSettings.SslProtocol);
            Assert.IsTrue(socketSettings.CheckCertificateRevocation);
            Assert.IsFalse(socketSettings.UseSSL);
            Assert.IsNull(socketSettings.CACertificatePath);
            Assert.IsTrue(socketSettings.RequireClientCertificate);
        }

        private Dictionary BaseTestDict()
        {
            Dictionary dict = new Dictionary();
            dict.SetBool(SessionSettings.SOCKET_NODELAY, false);
            dict.SetLong(SessionSettings.SOCKET_RECEIVE_BUFFER_SIZE, 1);
            dict.SetLong(SessionSettings.SOCKET_SEND_BUFFER_SIZE, 2);
            dict.SetLong(SessionSettings.SOCKET_RECEIVE_TIMEOUT, 3);
            dict.SetLong(SessionSettings.SOCKET_SEND_TIMEOUT, 4);
            dict.SetString(SessionSettings.SSL_SERVERNAME, "SSL_SERVERNAME");
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, false);
            dict.SetString(SessionSettings.SSL_CERTIFICATE, "SSL_CERTIFICATE");
            dict.SetString(SessionSettings.SSL_CA_CERTIFICATE, "SSL_CA_CERTIFICATE");
            dict.SetString(SessionSettings.SSL_CERTIFICATE_PASSWORD, "SSL_CERTIFICATE_PASSWORD");
            dict.SetString(SessionSettings.SSL_PROTOCOLS, "Tls12");
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, false);
            dict.SetBool(SessionSettings.SSL_ENABLE, true);
            dict.SetBool(SessionSettings.SSL_REQUIRE_CLIENT_CERTIFICATE, false);
            return dict;
        }

        [Test]
        public void Configure()
        {
            SocketSettings socketSettings = new SocketSettings();
            socketSettings.Configure(BaseTestDict());

            Assert.IsFalse(socketSettings.SocketNodelay);
            Assert.AreEqual(1, socketSettings.SocketReceiveBufferSize);
            Assert.AreEqual(2, socketSettings.SocketSendBufferSize);
            Assert.AreEqual(3, socketSettings.SocketReceiveTimeout);
            Assert.AreEqual(4, socketSettings.SocketSendTimeout);
            Assert.AreEqual("SSL_SERVERNAME", socketSettings.ServerCommonName);
            Assert.IsFalse(socketSettings.ValidateCertificates);
            Assert.AreEqual("SSL_CERTIFICATE", socketSettings.CertificatePath);
            Assert.AreEqual("SSL_CA_CERTIFICATE", socketSettings.CACertificatePath);
            Assert.AreEqual("SSL_CERTIFICATE_PASSWORD", socketSettings.CertificatePassword);
            Assert.AreEqual(SslProtocols.Tls12, socketSettings.SslProtocol);
            Assert.IsFalse(socketSettings.CheckCertificateRevocation);
            Assert.IsTrue(socketSettings.UseSSL);
            Assert.IsFalse(socketSettings.RequireClientCertificate);
        }

        private SocketSettings CreateWithSslConfig(bool sslValidateCertificates, bool sslCheckCertificateRevocation)
        {
            var dict = BaseTestDict();
            dict.SetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES, sslValidateCertificates);
            dict.SetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION, sslCheckCertificateRevocation);
            SocketSettings socketSettings = new SocketSettings();
            socketSettings.Configure(dict);
            return socketSettings;
        }

        [Test]
        public void Configure_SslOverride()
        {
            // SSLValidateCertificates=true does not affect SSLCheckCertificateRevocation
            var socketSettings = CreateWithSslConfig(true, false);
            Assert.IsTrue(socketSettings.ValidateCertificates);
            Assert.IsFalse(socketSettings.CheckCertificateRevocation);

            socketSettings = CreateWithSslConfig(true, true);
            Assert.IsTrue(socketSettings.ValidateCertificates);
            Assert.IsTrue(socketSettings.CheckCertificateRevocation);

            // SSLValidateCertificates=false means SSLCheckCertificateRevocation must be false
            socketSettings = CreateWithSslConfig(false, true);
            Assert.IsFalse(socketSettings.ValidateCertificates);
            Assert.IsFalse(socketSettings.CheckCertificateRevocation);

            socketSettings = CreateWithSslConfig(false, false);
            Assert.IsFalse(socketSettings.ValidateCertificates);
            Assert.IsFalse(socketSettings.CheckCertificateRevocation);
        }
    }
}