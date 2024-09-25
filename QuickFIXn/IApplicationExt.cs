using System;

namespace QuickFix
{
    /// <summary>
    /// This is the optional extension interface for processing inbound messages,
    /// and facilitates early interception of such messages. 'Early', in this context,
    /// means after structure, length and checksum have been validated, but before any
    /// further validation has been performed.
    ///
    /// This interface will not normally be required, and it should be used only with caution:
    /// it allows modifications to be made to irregular inbound messages that would otherwise
    /// fail validation against the Fix dictionary, an provides an alternative to dictionary
    /// customisation as a means of dealing with such messages.
    /// </summary>
    public interface IApplicationExt : IApplication
    {
        /// <summary>
        /// This callback provides early notification of when an administrative or application
        ///   message is sent from a counterparty to your FIX engine.
        /// This can be useful for doing pre-processing of an inbound message after its structure,
        ///   checksum and length have been validated, but before
        ///   any further validation has been performed on it.
        /// </summary>
        /// <param name="message">received message</param>
        /// <param name="sessionId">session on which message received</param>
        void FromEarlyIntercept(Message message, SessionID sessionId);
    }
}
