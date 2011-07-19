
namespace QuickFix
{
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
