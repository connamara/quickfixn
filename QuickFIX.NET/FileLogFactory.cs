
namespace QuickFix
{
    public class FileLogFactory : LogFactory
    {
        SessionSettings settings_;

        #region LogFactory Members

        public FileLogFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        public Log Create(SessionID sessionID)
        {
            return new FileLog(settings_.Get(sessionID).GetString(SessionSettings.FILE_LOG_PATH), sessionID);
        }

        #endregion
    }
}
