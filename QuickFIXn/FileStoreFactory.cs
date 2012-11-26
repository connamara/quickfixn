
namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    public class FileStoreFactory : IMessageStoreFactory
    {
        private SessionSettings settings_;

        /// <summary>
        /// Create the factory with configuration in session settings
        /// </summary>
        /// <param name="settings"></param>
        public FileStoreFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        #region MessageStoreFactory Members

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public IMessageStore Create(SessionID sessionID)
        {
            return new FileStore(settings_.Get(sessionID).GetString(SessionSettings.FILE_STORE_PATH), sessionID);
        }

        #endregion
    }
}
