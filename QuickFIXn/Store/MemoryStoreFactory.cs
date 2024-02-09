namespace QuickFix.Store;

/// <summary>
/// Creates a message store that stores all data in memory
/// </summary>
public class MemoryStoreFactory : IMessageStoreFactory
{
    #region MessageStoreFactory Members

    public IMessageStore Create(SessionID sessionId)
    {
        return new MemoryStore();
    }

    #endregion
}
