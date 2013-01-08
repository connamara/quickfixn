using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QuickFix.Transport
{
	class SslSocketInitiatorThread : SocketInitiatorThread
	{
		public SslSocketInitiatorThread(Transport.SocketInitiator initiator, Session session, IPEndPoint socketEndPoint, SocketSettings socketSettings)
			: base(initiator, session, socketEndPoint, socketSettings)
		{
			
		}

		protected override System.IO.Stream SetupStream()
		{
			var networkStream = base.SetupStream();
			var sslStream = new SslStream(networkStream, 
													leaveInnerStreamOpen:false,													
													userCertificateValidationCallback: ValidateServerCertificate,
													userCertificateSelectionCallback: SelectLocalCertificate,
													encryptionPolicy: EncryptionPolicy.RequireEncryption);

			try
			{
				// Setup secure SSL Communication
				var clientCertificates = GetClientCertificates();
				sslStream.AuthenticateAsClient(socketSettings_.HostName,
					clientCertificates,
					socketSettings_.SslProtocol,
					socketSettings_.CheckCertificateRevocation);
			}
			catch (System.Security.Authentication.AuthenticationException ex)			
			{
				Session.Log.OnEvent("Unable to perform authentication against server: " + ex.Message);
				throw;
			}
			
			return sslStream;
		}

		X509CertificateCollection GetClientCertificates()
		{
			X509CertificateCollection certificates = new X509Certificate2Collection();

			if (!string.IsNullOrEmpty(socketSettings_.CertificatePath))
			{
				certificates.Add(new X509Certificate2(socketSettings_.CertificatePath, socketSettings_.CertificatePassword));
			}

			return certificates;
		}

		public bool ValidateServerCertificate(object sender,
				  X509Certificate certificate,
				  X509Chain chain,
				  SslPolicyErrors sslPolicyErrors)
		{
			if (sslPolicyErrors == SslPolicyErrors.None)
				return true;

			Session.Log.OnEvent("Server certificate was not recognized as a valid certificate: " + sslPolicyErrors);

			// Unknown server certificate, only accept if we should not validate it
			return socketSettings_.ValidateServerCertificate == false;
		}


		public X509Certificate SelectLocalCertificate(object sender, string targetHost,
										X509CertificateCollection localCertificates,
										X509Certificate remoteCertificate,
										string[] acceptableIssuers)
		{
			// No certificate can be selected if we have no local certificates at all
			if (localCertificates == null || localCertificates.Count <= 0)
				return null;

			Debug.Assert(localCertificates != null && localCertificates.Count > 0);

			//Otherwise we select the first availible certificate as per msdn documentation
			// http://msdn.microsoft.com/en-us/library/system.net.security.localcertificateselectioncallback.aspx
			if (acceptableIssuers != null)
			{
				// Use the first certificate that is from an acceptable issuer. 
				foreach (X509Certificate certificate in localCertificates)
				{
					string issuer = certificate.Issuer;
					if (Array.IndexOf(acceptableIssuers, issuer) != -1)
						return certificate;
				}
			}

			// Just use any certificate
			return localCertificates[0];
		}
	}
}
