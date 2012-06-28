﻿
namespace QuickFix
{
    /// <summary>
    /// Used by a Session to send raw FIX message data and to disconnect a
    /// connection. This interface is used by Acceptor or Initiator implementations.
    /// </summary>
    public interface Responder
    {
        /// <summary>
        /// Sends a raw FIX message
        /// </summary>
        /// <param name="s">the raw FIX message data</param>
        /// <returns>true if successful, false if send operation failed</returns>
        bool Send(string s);

        /// <summary>
        /// Disconnect the underlying connection
        /// </summary>
        void Disconnect();
    }
}
