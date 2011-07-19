
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

        /// <summary>
        /// FIXME
        /// </summary>
        /// <param name="sessionID"></param>
        /// <returns></returns>
        public MessageStore Create(SessionID sessionID)
        {
            return new MemoryStore();
        }

        #endregion
    }
}
