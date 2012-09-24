
namespace QuickFix
{
    public class DbLogFactory : LogFactory
    {
        SessionSettings settings_;

        public DbLogFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        public Log Create(SessionID sessionID)
        {
            var settingsDict = settings_.Get(sessionID);
            return new DbLog(
                sessionID,
                settingsDict.GetString(SessionSettings.DB_LOG_CONNECTION),
                settingsDict.Has(SessionSettings.DB_LOG_MESSAGE_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_LOG_MESSAGE_COMMANDTEXT) : null,
                settingsDict.Has(SessionSettings.DB_LOG_EVENT_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_LOG_EVENT_COMMANDTEXT) : null
                );
        }
    }
}
