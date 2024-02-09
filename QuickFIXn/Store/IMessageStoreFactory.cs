namespace QuickFix.Store;

/// <summary>
/// Used by a Session to create a message store implementation
/// </summary>
public interface IMessageStoreFactory
{
    /// <summary>
    /// Creates a message store implementation
    /// </summary>
    /// <param name="sessionId">the session ID, often used to access session configurations</param>
    /// <returns>the message store implementation</returns>
    IMessageStore Create(SessionID sessionId);
}
