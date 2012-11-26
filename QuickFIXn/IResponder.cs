
namespace QuickFix
{
    /// <summary>
    /// (Renamed per naming convention.)
    /// </summary>
    [System.Obsolete("Use IResponder instead.")]
    public interface Responder : IResponder { }

    /// <summary>
    /// Used by a Session to send raw FIX message data and to disconnect a
    /// connection. This interface is used by Acceptor or Initiator implementations.
    /// </summary>
    public interface IResponder
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
