
namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores all data in memory
    /// </summary>
    public class MemoryStoreFactory : IMessageStoreFactory
    {
        #region MessageStoreFactory Members

        public IMessageStore Create(SessionID sessionID)
        {
            return new MemoryStore();
        }

        #endregion
    }
}
