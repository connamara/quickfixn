
namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    public class FileLogFactory : ILogFactory
    {
        protected SessionSettings Settings { get; private set; }

        #region LogFactory Members

        public FileLogFactory(SessionSettings settings)
        {
            Settings = settings;
        }

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public virtual ILog Create(SessionID sessionID)
        {
            return new FileLog(Settings.Get(sessionID).GetString(SessionSettings.FILE_LOG_PATH), sessionID);
        }

        #endregion
    }
}
