
namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    public class FileLogFactory : LogFactory
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
        public Log Create(SessionID sessionID)
        {
            Dictionary sessionSettings = settings_.Get(sessionID);
            bool RotateLog = false; //default if undefined
            int RotateLogNumToKeep = 1; //default if undefined

            if (sessionSettings.Has(SessionSettings.FILE_LOG_ROTATE_ON_NEW_SESSION))
                RotateLog = sessionSettings.GetBool(SessionSettings.FILE_LOG_ROTATE_ON_NEW_SESSION);

            if (sessionSettings.Has(SessionSettings.FILE_LOG_ROTATE_NUM_TO_KEEP))
                RotateLogNumToKeep = sessionSettings.GetInt(SessionSettings.FILE_LOG_ROTATE_NUM_TO_KEEP);



            return new FileLog(sessionSettings.GetString(SessionSettings.FILE_LOG_PATH), sessionID, RotateLog, RotateLogNumToKeep);
        }

        #endregion
    }
}
