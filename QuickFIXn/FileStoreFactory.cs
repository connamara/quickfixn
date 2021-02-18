namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    public class FileStoreFactory : IMessageStoreFactory
    {
        protected SessionSettings Settings { get; private set; }

        /// <summary>
        /// Create the factory with configuration in session settings
        /// </summary>
        /// <param name="settings"></param>
        public FileStoreFactory(SessionSettings settings)
        {
            Settings = settings;
        }

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public virtual IMessageStore Create(SessionID sessionID)
        {
            return new FileStore(Settings.Get(sessionID).GetString(SessionSettings.FILE_STORE_PATH), sessionID);
        }
    }
}
