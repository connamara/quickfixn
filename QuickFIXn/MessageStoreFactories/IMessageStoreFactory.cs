
namespace QuickFix
{
    /// <summary>
    /// (Renamed per naming convention.)
    /// </summary>
    [System.Obsolete("Use IMessageStoreFactory instead.")]
    public interface MessageStoreFactory : IMessageStoreFactory { }

    /// <summary>
    /// Used by a Session to create a message store implementation
    /// </summary>
    public interface IMessageStoreFactory
    {
        /// <summary>
        /// Creates a message store implementation
        /// </summary>
        /// <param name="sessionID">the session ID, often used to access session configurations</param>
        /// <returns>the message store implementation</returns>
        IMessageStore Create(SessionID sessionID);
    }
}
