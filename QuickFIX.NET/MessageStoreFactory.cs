
namespace QuickFix
{
    /// <summary>
    /// Used by a Session to create a message store implementation
    /// </summary>
    public interface MessageStoreFactory
    {
        /// <summary>
        /// Creates a message store implementation
        /// </summary>
        /// <param name="sessionID">the session ID, often used to access session configurations</param>
        /// <returns>the message store implementation</returns>
        MessageStore Create(SessionID sessionID);
    }
}
