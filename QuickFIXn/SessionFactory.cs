using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Creates a Session based on specified settings
    /// </summary>
    public class SessionFactory
    {
        protected IApplication application_;
        protected IMessageStoreFactory messageStoreFactory_;
        protected ILogFactory logFactory_;
        protected IMessageFactory messageFactory_;
        protected Dictionary<string,DataDictionary.DataDictionary> dictionariesByPath_ = new Dictionary<string,DataDictionary.DataDictionary>();

        public SessionFactory(IApplication app, IMessageStoreFactory storeFactory)
            : this(app, storeFactory, null, null)
        { }

        public SessionFactory(IApplication app, IMessageStoreFactory storeFactory, ILogFactory logFactory)
            : this(app, storeFactory, logFactory, null)
        { }

        public SessionFactory(IApplication app, IMessageStoreFactory storeFactory, ILogFactory logFactory, IMessageFactory messageFactory)
        {
            application_ = app;
            messageStoreFactory_ = storeFactory;
            logFactory_ = logFactory;
            messageFactory_ = messageFactory ?? new DefaultMessageFactory();
        }

        public Session Create(SessionID sessionID, QuickFix.Dictionary settings)
        {
            string connectionType = settings.GetString(SessionSettings.CONNECTION_TYPE);
            if (!"acceptor".Equals(connectionType) && !"initiator".Equals(connectionType))
                throw new ConfigError("Invalid ConnectionType");

            if ("acceptor".Equals(connectionType) && settings.Has(SessionSettings.SESSION_QUALIFIER))
                throw new ConfigError("SessionQualifier cannot be used with acceptor.");

            bool useDataDictionary = true;
            if (settings.Has(SessionSettings.USE_DATA_DICTIONARY))
                useDataDictionary = settings.GetBool(SessionSettings.USE_DATA_DICTIONARY);

            QuickFix.Fields.ApplVerID defaultApplVerID = null;
            if (sessionID.IsFIXT)
            {
                if (!settings.Has(SessionSettings.DEFAULT_APPLVERID))
                {
                    throw new ConfigError("ApplVerID is required for FIXT transport");
                }
                defaultApplVerID = Message.GetApplVerID(settings.GetString(SessionSettings.DEFAULT_APPLVERID));
                
            }

            DataDictionaryProvider dd = new DataDictionaryProvider();
            if (useDataDictionary)
            {
                if (sessionID.IsFIXT)
                    ProcessFixTDataDictionaries(sessionID, settings, dd);
                else
                    ProcessFixDataDictionary(sessionID, settings, dd);
            }

            int heartBtInt = 0;
            if ( connectionType == "initiator" )
            {
                heartBtInt = System.Convert.ToInt32(settings.GetLong( SessionSettings.HEARTBTINT ));
                if ( heartBtInt <= 0 )
                    throw new ConfigError( "Heartbeat must be greater than zero" );
            }
            string senderDefaultApplVerId = "";
            if(defaultApplVerID != null)
                senderDefaultApplVerId = defaultApplVerID.Obj;

            Session session = new Session(
                application_,
                messageStoreFactory_,
                sessionID,
                dd,
                new SessionSchedule(settings),
                heartBtInt,
                logFactory_,
                messageFactory_,
                senderDefaultApplVerId);

            if (settings.Has(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS))
                session.SendRedundantResendRequests = settings.GetBool(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS);
            if (settings.Has(SessionSettings.RESEND_SESSION_LEVEL_REJECTS))
                session.ResendSessionLevelRejects = settings.GetBool(SessionSettings.RESEND_SESSION_LEVEL_REJECTS);
            /** FIXME - implement optional settings
            if (settings.Has(SessionSettings.CHECK_COMPID))
                session.SetCheckCompId(settings.GetBool(SessionSettings.CHECK_COMPID));
             */
            if (settings.Has(SessionSettings.CHECK_LATENCY))
                session.CheckLatency = settings.GetBool(SessionSettings.CHECK_LATENCY);
            if (settings.Has(SessionSettings.MAX_LATENCY))
                session.MaxLatency = settings.GetInt(SessionSettings.MAX_LATENCY);
            if (settings.Has(SessionSettings.LOGON_TIMEOUT))
                session.LogonTimeout = settings.GetInt(SessionSettings.LOGON_TIMEOUT);
            if (settings.Has(SessionSettings.LOGOUT_TIMEOUT))
                session.LogoutTimeout = settings.GetInt(SessionSettings.LOGOUT_TIMEOUT);
            if (settings.Has(SessionSettings.RESET_ON_LOGON))
                session.ResetOnLogon = settings.GetBool(SessionSettings.RESET_ON_LOGON);
            if (settings.Has(SessionSettings.RESET_ON_LOGOUT))
                session.ResetOnLogout = settings.GetBool(SessionSettings.RESET_ON_LOGOUT);
            if (settings.Has(SessionSettings.RESET_ON_DISCONNECT))
                session.ResetOnDisconnect = settings.GetBool(SessionSettings.RESET_ON_DISCONNECT);
            if (settings.Has(SessionSettings.REFRESH_ON_LOGON))
                session.RefreshOnLogon = settings.GetBool(SessionSettings.REFRESH_ON_LOGON);
            if (settings.Has(SessionSettings.PERSIST_MESSAGES))
                session.PersistMessages = settings.GetBool(SessionSettings.PERSIST_MESSAGES);
            if (settings.Has(SessionSettings.MILLISECONDS_IN_TIMESTAMP))
                session.MillisecondsInTimeStamp = settings.GetBool(SessionSettings.MILLISECONDS_IN_TIMESTAMP);
            if (settings.Has(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED))
                session.EnableLastMsgSeqNumProcessed = settings.GetBool(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED);
            if (settings.Has(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST))
                session.MaxMessagesInResendRequest = settings.GetInt(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST);
            if (settings.Has(SessionSettings.SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT))
                session.SendLogoutBeforeTimeoutDisconnect = settings.GetBool(SessionSettings.SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT);
            if (settings.Has(SessionSettings.IGNORE_POSSDUP_RESEND_REQUESTS))
                session.IgnorePossDupResendRequests = settings.GetBool(SessionSettings.IGNORE_POSSDUP_RESEND_REQUESTS);
            if (settings.Has(SessionSettings.VALIDATE_LENGTH_AND_CHECKSUM))
                session.ValidateLengthAndChecksum = settings.GetBool(SessionSettings.VALIDATE_LENGTH_AND_CHECKSUM);
            if (settings.Has(SessionSettings.RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME))
                session.RequiresOrigSendingTime = settings.GetBool(SessionSettings.RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME);

            return session;
        }

        protected DataDictionary.DataDictionary createDataDictionary(SessionID sessionID, QuickFix.Dictionary settings, string settingsKey, string beginString)
        {
            DataDictionary.DataDictionary dd;
            string path;
            if (settings.Has(settingsKey))
                path = settings.GetString(settingsKey);
            else
                path = beginString.Replace(".", "") + ".xml";

            if (!dictionariesByPath_.TryGetValue(path, out dd))
            {
                dd = new DataDictionary.DataDictionary(path);
                dictionariesByPath_[path] = dd;
            }

            DataDictionary.DataDictionary ddCopy = new DataDictionary.DataDictionary(dd);

            if (settings.Has(SessionSettings.VALIDATE_FIELDS_OUT_OF_ORDER))
                ddCopy.CheckFieldsOutOfOrder = settings.GetBool(SessionSettings.VALIDATE_FIELDS_OUT_OF_ORDER);
            if (settings.Has(SessionSettings.VALIDATE_FIELDS_HAVE_VALUES))
                ddCopy.CheckFieldsHaveValues = settings.GetBool(SessionSettings.VALIDATE_FIELDS_HAVE_VALUES);
            if (settings.Has(SessionSettings.VALIDATE_USER_DEFINED_FIELDS))
                ddCopy.CheckUserDefinedFields = settings.GetBool(SessionSettings.VALIDATE_USER_DEFINED_FIELDS);

            return ddCopy;
        }

        protected void ProcessFixTDataDictionaries(SessionID sessionID, Dictionary settings, DataDictionaryProvider provider)
        {
            provider.AddTransportDataDictionary(sessionID.BeginString, createDataDictionary(sessionID, settings, SessionSettings.TRANSPORT_DATA_DICTIONARY, sessionID.BeginString));
    
            foreach (KeyValuePair<string, string> setting in settings)
            {
                if (setting.Key.StartsWith(SessionSettings.APP_DATA_DICTIONARY, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    if (setting.Key.Equals(SessionSettings.APP_DATA_DICTIONARY, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        Fields.ApplVerID applVerId = Message.GetApplVerID(settings.GetString(SessionSettings.DEFAULT_APPLVERID));
                        DataDictionary.DataDictionary dd = createDataDictionary(sessionID, settings, SessionSettings.APP_DATA_DICTIONARY, sessionID.BeginString);
                        provider.AddApplicationDataDictionary(applVerId.Obj, dd);
                    }
                    else
                    {
                        int offset = setting.Key.IndexOf(".");
                        if (offset == -1)
                            throw new System.ArgumentException(string.Format("Malformed {0} : {1}", SessionSettings.APP_DATA_DICTIONARY, setting.Key));

                        string beginStringQualifier = setting.Key.Substring(offset);
                        DataDictionary.DataDictionary dd = createDataDictionary(sessionID, settings, setting.Key, beginStringQualifier);
                        provider.AddApplicationDataDictionary(Message.GetApplVerID(beginStringQualifier).Obj, dd);
                    }
                }
            }
        }

        protected void ProcessFixDataDictionary(SessionID sessionID, Dictionary settings, DataDictionaryProvider provider)
        {
            DataDictionary.DataDictionary dataDictionary = createDataDictionary(sessionID, settings, SessionSettings.DATA_DICTIONARY, sessionID.BeginString);
            provider.AddTransportDataDictionary(sessionID.BeginString, dataDictionary);
            provider.AddApplicationDataDictionary(FixValues.ApplVerID.FromBeginString(sessionID.BeginString), dataDictionary);
        }

    }
}
