
namespace QuickFix
{
    public class DbStoreFactory : MessageStoreFactory
    {
        SessionSettings settings_;

        public DbStoreFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        public MessageStore Create(SessionID sessionID)
        {
            var settingsDict = settings_.Get(sessionID);
            return new DbStore(
                sessionID,
                settingsDict.GetString(SessionSettings.DB_STORE_CONNECTION),
                settingsDict.Has(SessionSettings.DB_STORE_GETMESSAGE_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_STORE_GETMESSAGE_COMMANDTEXT) : null,
                settingsDict.Has(SessionSettings.DB_STORE_SETMESSAGE_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_STORE_SETMESSAGE_COMMANDTEXT) : null,
                settingsDict.Has(SessionSettings.DB_STORE_CLEARMESSAGES_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_STORE_CLEARMESSAGES_COMMANDTEXT) : null,
                settingsDict.Has(SessionSettings.DB_STORE_CREATESESSION_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_STORE_CREATESESSION_COMMANDTEXT) : null,
                settingsDict.Has(SessionSettings.DB_STORE_GETSESSION_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_STORE_GETSESSION_COMMANDTEXT) : null,
                settingsDict.Has(SessionSettings.DB_STORE_UPDATESESSION_COMMANDTEXT) ? settingsDict.GetString(SessionSettings.DB_STORE_UPDATESESSION_COMMANDTEXT) : null
                );
        }
    }
}
