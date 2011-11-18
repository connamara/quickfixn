
namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores all data in memory
    /// </summary>
    public class MemoryStoreFactory : MessageStoreFactory
    {
        #region MessageStoreFactory Members

        public MessageStore Create(SessionID sessionID)
        {
            return new MemoryStore();
        }

        #endregion
    }
}
