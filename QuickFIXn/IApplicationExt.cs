using System;

namespace QuickFix
{
    /// <summary>
    /// This is the optional extension interface for processing session messages, and facilitates early interception of inbound messages.
	/// 'Early', in this context, means after structure, length and checksum have been validated, but before any further validation has been performed.
    /// </summary>
	public interface IApplicationExt : IApplication
	{
		/// <summary>
		/// This callback provides early notification of when an administrative or application  message is sent from a counterparty to your FIX engine.
		/// This can be useful for doing pre-processing of an inbound message after its structure, checksum and length have been validated, but before
		/// any further validation has been performed on it.
		/// </summary>
		/// <param name="message">received message</param>
		/// <param name="sessionID">session on which message received</param>
		void FromEarlyIntercept(Message message, SessionID sessionID);
	}
}
