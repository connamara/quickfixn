using System;
using System.Collections.Generic;
using QuickFix.Logger;
using QuickFix.Store;
using QuickFix.Util;

namespace QuickFix
{
    /// <summary>
    /// Creates a Session based on specified settings
    /// </summary>
    public class SessionFactory
    {
        protected IApplication _application;
        protected IMessageStoreFactory _messageStoreFactory;
        protected ILogFactory _logFactory;
        protected IMessageFactory _messageFactory;
        protected Dictionary<string, DataDictionary.DataDictionary> _dictionariesByPath = new();

        public SessionFactory(
            IApplication app,
            IMessageStoreFactory storeFactory,
            ILogFactory? logFactory = null,
            IMessageFactory? messageFactory = null)
        {
            // TODO: for V2, consider ONLY instantiating MessageFactory in the Create() method,
            //   and removing instance var _messageFactory altogether.
            //   This makes sense because we can't distinguish FIX50 versions here in this constructor,
            //   and thus can't create the right FIX-Version factory because we don't know what
            //   session to use to look up the BeginString and DefaultApplVerID.

            _application = app;
            _messageStoreFactory = storeFactory;
            _logFactory = logFactory ?? new NullLogFactory();
            _messageFactory = messageFactory ?? new DefaultMessageFactory();
        }

        private static bool DetectIfInitiator(SettingsDictionary settings)
        {
            switch (settings.GetString(SessionSettings.CONNECTION_TYPE))
            {
                case "acceptor": return false;
                case "initiator": return true;
            }
            throw new ConfigError("Invalid ConnectionType");
        }

        public Session Create(SessionID sessionId, SettingsDictionary settings)
        {
            bool isInitiator = SessionFactory.DetectIfInitiator(settings);

            if (!isInitiator && settings.Has(SessionSettings.SESSION_QUALIFIER))
                throw new ConfigError("SessionQualifier cannot be used with acceptor.");

            bool useDataDictionary = true;
            if (settings.Has(SessionSettings.USE_DATA_DICTIONARY))
                useDataDictionary = settings.GetBool(SessionSettings.USE_DATA_DICTIONARY);

            QuickFix.Fields.ApplVerID? defaultApplVerId = null;
            IMessageFactory sessionMsgFactory = _messageFactory;
            if (sessionId.IsFIXT)
            {
                if (!settings.Has(SessionSettings.DEFAULT_APPLVERID))
                {
                    throw new ConfigError("ApplVerID is required for FIXT transport");
                }
                string rawDefaultApplVerIdSetting = settings.GetString(SessionSettings.DEFAULT_APPLVERID);

                defaultApplVerId = Message.GetApplVerID(rawDefaultApplVerIdSetting);

                // DefaultMessageFactory as created in the SessionFactory ctor cannot
                // tell the difference between FIX50 versions (same BeginString, unknown defaultApplVerId).
                // But we have the real session settings here, so we can fix that.
                // This is, of course, kind of a hack, and it should be reworked (TODO!).
                if (_messageFactory is DefaultMessageFactory)
                {
                    sessionMsgFactory = new DefaultMessageFactory(
                        FixValues.ApplVerID.FromBeginString(rawDefaultApplVerIdSetting));
                }
            }

            DataDictionaryProvider dd = new DataDictionaryProvider();
            if (useDataDictionary)
            {
                if (sessionId.IsFIXT)
                    ProcessFixTDataDictionaries(sessionId, settings, dd);
                else
                    ProcessFixDataDictionary(sessionId, settings, dd);
            }

            int heartBtInt = 0;
            if (isInitiator)
            {
                heartBtInt = System.Convert.ToInt32(settings.GetLong(SessionSettings.HEARTBTINT));
                if (heartBtInt < 0)
                    throw new ConfigError($"{SessionSettings.HEARTBTINT} must be greater or equal to zero");
            }
            string senderDefaultApplVerId = "";
            if(defaultApplVerId is not null)
                senderDefaultApplVerId = defaultApplVerId.Value;

            Session session = new Session(
                isInitiator,
                _application,
                _messageStoreFactory,
                sessionId,
                dd,
                new SessionSchedule(settings),
                heartBtInt,
                _logFactory,
                sessionMsgFactory,
                senderDefaultApplVerId);

            if (settings.Has("MillisecondsInTimeStamp")) {
                throw new ApplicationException(
                    "Setting 'MillisecondsInTimeStamp' was removed.  Use 'TimestampPrecision=Milliseconds' instead.");
            }

            if (settings.Has(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS))
                session.SendRedundantResendRequests = settings.GetBool(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS);
            if (settings.Has(SessionSettings.RESEND_SESSION_LEVEL_REJECTS))
                session.ResendSessionLevelRejects = settings.GetBool(SessionSettings.RESEND_SESSION_LEVEL_REJECTS);
            /* FIXME - implement optional settings
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
            if( settings.Has( SessionSettings.TIMESTAMP_PRECISION ) )
                session.TimeStampPrecision = settings.GetTimeStampPrecision( SessionSettings.TIMESTAMP_PRECISION );
            if (settings.Has(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED))
                session.EnableLastMsgSeqNumProcessed = settings.GetBool(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED);
            if (settings.Has(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST))
                session.MaxMessagesInResendRequest = settings.GetULong(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST);
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

        protected DataDictionary.DataDictionary CreateDataDictionary(SessionID sessionId, SettingsDictionary settings, string settingsKey, string beginString)
        {
            string path;
            if (settings.Has(settingsKey))
                path = settings.GetString(settingsKey);
            else
                path = beginString.Replace(".", "") + ".xml";

            path = StringUtil.FixSlashes(path);

            DataDictionary.DataDictionary? dd;
            if (!_dictionariesByPath.TryGetValue(path, out dd))
            {
                dd = new DataDictionary.DataDictionary(path);
                _dictionariesByPath[path] = dd;
            }

            DataDictionary.DataDictionary ddCopy = new DataDictionary.DataDictionary(dd);

            if (settings.Has(SessionSettings.VALIDATE_FIELDS_OUT_OF_ORDER))
                ddCopy.CheckFieldsOutOfOrder = settings.GetBool(SessionSettings.VALIDATE_FIELDS_OUT_OF_ORDER);
            if (settings.Has(SessionSettings.VALIDATE_FIELDS_HAVE_VALUES))
                ddCopy.CheckFieldsHaveValues = settings.GetBool(SessionSettings.VALIDATE_FIELDS_HAVE_VALUES);
            if (settings.Has(SessionSettings.VALIDATE_USER_DEFINED_FIELDS))
                ddCopy.CheckUserDefinedFields = settings.GetBool(SessionSettings.VALIDATE_USER_DEFINED_FIELDS);
            if (settings.Has(SessionSettings.ALLOW_UNKNOWN_FIELD_VALUES))
	            ddCopy.AllowUnknownFieldValues = settings.GetBool(SessionSettings.ALLOW_UNKNOWN_FIELD_VALUES);
            if (settings.Has(SessionSettings.ALLOW_UNKNOWN_MSG_FIELDS))
                ddCopy.AllowUnknownMessageFields = settings.GetBool(SessionSettings.ALLOW_UNKNOWN_MSG_FIELDS);

            return ddCopy;
        }

        protected void ProcessFixTDataDictionaries(SessionID sessionId, SettingsDictionary settings, DataDictionaryProvider provider)
        {
            provider.AddTransportDataDictionary(sessionId.BeginString, CreateDataDictionary(sessionId, settings, SessionSettings.TRANSPORT_DATA_DICTIONARY, sessionId.BeginString));
    
            foreach (KeyValuePair<string, string> setting in settings)
            {
                if (setting.Key.StartsWith(SessionSettings.APP_DATA_DICTIONARY, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    if (setting.Key.Equals(SessionSettings.APP_DATA_DICTIONARY, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        Fields.ApplVerID applVerId = Message.GetApplVerID(settings.GetString(SessionSettings.DEFAULT_APPLVERID));
                        DataDictionary.DataDictionary dd = CreateDataDictionary(sessionId, settings, SessionSettings.APP_DATA_DICTIONARY, sessionId.BeginString);
                        provider.AddApplicationDataDictionary(applVerId.Value, dd);
                    }
                    else
                    {
                        int offset = setting.Key.IndexOf('.');
                        if (offset == -1)
                            throw new ArgumentException(
                                $"Malformed {SessionSettings.APP_DATA_DICTIONARY} : {setting.Key}");

                        string beginStringQualifier = setting.Key.Substring(offset);
                        DataDictionary.DataDictionary dd = CreateDataDictionary(sessionId, settings, setting.Key, beginStringQualifier);
                        provider.AddApplicationDataDictionary(Message.GetApplVerID(beginStringQualifier).Value, dd);
                    }
                }
            }
        }

        protected void ProcessFixDataDictionary(SessionID sessionId, SettingsDictionary settings, DataDictionaryProvider provider)
        {
            DataDictionary.DataDictionary dataDictionary = CreateDataDictionary(sessionId, settings, SessionSettings.DATA_DICTIONARY, sessionId.BeginString);
            provider.AddTransportDataDictionary(sessionId.BeginString, dataDictionary);
            provider.AddApplicationDataDictionary(FixValues.ApplVerID.FromBeginString(sessionId.BeginString), dataDictionary);
        }
    }
}
