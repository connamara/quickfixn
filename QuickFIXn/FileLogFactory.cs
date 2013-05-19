
namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    public class FileLogFactory : ILogFactory
    {
        SessionSettings settings_;

        #region LogFactory Members

        public FileLogFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public ILog Create(SessionID sessionID)
        {
            Dictionary dict = settings_.Get(sessionID);
            
            return new FileLog(
                dict.GetString(SessionSettings.FILE_LOG_PATH),
                sessionID,
                dict.Has(SessionSettings.EXTRA_DEBUG_LOGGING) ? dict.GetBool(SessionSettings.EXTRA_DEBUG_LOGGING) : false
            );
        }

        #endregion
    }
}
