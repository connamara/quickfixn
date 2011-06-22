
namespace QuickFix
{
    public class FileStoreFactory : MessageStoreFactory
    {
        private SessionSettings settings_;

        public FileStoreFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        #region MessageStoreFactory Members

        public MessageStore Create(SessionID sessionID)
        {
            throw new System.NotImplementedException("FIXME - FileStoreFactory.Create not implemented!");
        }

        #endregion
    }
}
