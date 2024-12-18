using System.Collections.Generic;
using System.IO;

namespace QuickFix
{
    /// <summary>
    /// Settings for sessions. Settings are grouped by FIX version and target ID
    /// There is also a default settings that is inherited by the session-specific sections.
    /// </summary>
    public class SessionSettings
    {
        #region Public Constants

        public const string BEGINSTRING = "BeginString";
        public const string SENDERCOMPID = "SenderCompID";
        public const string SENDERSUBID = "SenderSubID";
        public const string SENDERLOCID = "SenderLocationID";
        public const string TARGETCOMPID = "TargetCompID";
        public const string TARGETSUBID = "TargetSubID";
        public const string TARGETLOCID = "TargetLocationID";
        public const string SESSION_QUALIFIER = "SessionQualifier";
        public const string DEFAULT_APPLVERID = "DefaultApplVerID";
        public const string CONNECTION_TYPE = "ConnectionType";
        public const string USE_DATA_DICTIONARY = "UseDataDictionary";
        public const string NON_STOP_SESSION = "NonStopSession";
        public const string USE_LOCAL_TIME = "UseLocalTime";
        public const string TIME_ZONE = "TimeZone";
        public const string START_DAY = "StartDay";
        public const string END_DAY = "EndDay";
        public const string WEEKDAYS = "Weekdays";
        public const string START_TIME = "StartTime";
        public const string END_TIME = "EndTime";
        public const string HEARTBTINT = "HeartBtInt";
        public const string SOCKET_ACCEPT_HOST = "SocketAcceptHost";
        public const string SOCKET_ACCEPT_PORT = "SocketAcceptPort";
        public const string SOCKET_CONNECT_HOST = "SocketConnectHost";
        public const string SOCKET_CONNECT_PORT = "SocketConnectPort";
        public const string RECONNECT_INTERVAL = "ReconnectInterval";
        public const string FILE_LOG_PATH = "FileLogPath";
        public const string FILE_STORE_PATH = "FileStorePath";
        public const string REFRESH_ON_LOGON = "RefreshOnLogon";
        public const string RESET_ON_LOGON = "ResetOnLogon";
        public const string RESET_ON_LOGOUT = "ResetOnLogout";
        public const string RESET_ON_DISCONNECT = "ResetOnDisconnect";
        public const string VALIDATE_FIELDS_OUT_OF_ORDER = "ValidateFieldsOutOfOrder";
        public const string VALIDATE_FIELDS_HAVE_VALUES = "ValidateFieldsHaveValues";
        public const string VALIDATE_USER_DEFINED_FIELDS = "ValidateUserDefinedFields";
        public const string VALIDATE_LENGTH_AND_CHECKSUM = "ValidateLengthAndChecksum";
        public const string ALLOW_UNKNOWN_FIELD_VALUES = "AllowUnknownFieldValues";
        public const string ALLOW_UNKNOWN_MSG_FIELDS = "AllowUnknownMsgFields";
        public const string DATA_DICTIONARY = "DataDictionary";
        public const string TRANSPORT_DATA_DICTIONARY = "TransportDataDictionary";
        public const string APP_DATA_DICTIONARY = "AppDataDictionary";
        public const string PERSIST_MESSAGES = "PersistMessages";
        public const string LOGON_TIMEOUT = "LogonTimeout";
        public const string LOGOUT_TIMEOUT = "LogoutTimeout";
        public const string SEND_REDUNDANT_RESENDREQUESTS = "SendRedundantResendRequests";
        public const string RESEND_SESSION_LEVEL_REJECTS = "ResendSessionLevelRejects";
        public const string TIMESTAMP_PRECISION = "TimestampPrecision";
        public const string ENABLE_LAST_MSG_SEQ_NUM_PROCESSED = "EnableLastMsgSeqNumProcessed";
        public const string MAX_MESSAGES_IN_RESEND_REQUEST = "MaxMessagesInResendRequest";
        public const string SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT = "SendLogoutBeforeDisconnectFromTimeout";
        public const string SOCKET_NODELAY = "SocketNodelay";
        public const string SOCKET_SEND_BUFFER_SIZE = "SocketSendBufferSize";
        public const string SOCKET_RECEIVE_BUFFER_SIZE = "SocketReceiveBufferSize";
        public const string SOCKET_SEND_TIMEOUT = "SocketSendTimeout";
        public const string SOCKET_RECEIVE_TIMEOUT = "SocketReceiveTimeout";
        public const string IGNORE_POSSDUP_RESEND_REQUESTS = "IgnorePossDupResendRequests";
        public const string RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME = "RequiresOrigSendingTime";
        public const string CHECK_LATENCY = "CheckLatency";
        public const string MAX_LATENCY = "MaxLatency";
        public const string SOCKET_IGNORE_PROXY = "SocketIgnoreProxy";

        public const string SSL_ENABLE = "SSLEnable";
        public const string SSL_SERVERNAME = "SSLServerName";
        public const string SSL_PROTOCOLS = "SSLProtocols";
        public const string SSL_VALIDATE_CERTIFICATES = "SSLValidateCertificates";
        public const string SSL_CHECK_CERTIFICATE_REVOCATION = "SSLCheckCertificateRevocation";
        public const string SSL_CERTIFICATE = "SSLCertificate";
        public const string SSL_CERTIFICATE_PASSWORD = "SSLCertificatePassword";
        public const string SSL_REQUIRE_CLIENT_CERTIFICATE = "SSLRequireClientCertificate";
        public const string SSL_CA_CERTIFICATE = "SSLCACertificate";

        #endregion

        #region Private Members

        private SettingsDictionary _defaults = new();
        private readonly Dictionary<SessionID, SettingsDictionary> _settings = new();

        #endregion

        #region Constructors

        public SessionSettings(string file)
        {
            try
            {
                FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read);
                Load(new StreamReader(fs));
                fs.Close();
            }
            catch (System.Exception e)
            {
                throw new ConfigError($"File {file} not found ({e.Message})");
            }
        }

        public SessionSettings(TextReader conf)
        {
            Load(conf);
        }

        public SessionSettings()
        { }

        #endregion

        protected void Load(TextReader conf)
        {
            Settings settings = new Settings(conf);

            //---- load the DEFAULT section
            LinkedList<SettingsDictionary> section = settings.Get("DEFAULT");
            SettingsDictionary def = section.Count > 0
                ? section.First!.Value
                : new SettingsDictionary(name: "DEFAULT");
            Set(def);

            //---- load each SESSION section
            section = settings.Get("SESSION");
            foreach (SettingsDictionary dict in section)
            {
                dict.Merge(def);

                string sessionQualifier = SessionID.NOT_SET;
                string senderSubId = SessionID.NOT_SET;
                string senderLocId = SessionID.NOT_SET;
                string targetSubId = SessionID.NOT_SET;
                string targetLocId = SessionID.NOT_SET;

                if (dict.Has(SESSION_QUALIFIER))
                    sessionQualifier = dict.GetString(SESSION_QUALIFIER);
                if (dict.Has(SENDERSUBID))
                    senderSubId = dict.GetString(SENDERSUBID);
                if (dict.Has(SENDERLOCID))
                    senderLocId = dict.GetString(SENDERLOCID);
                if (dict.Has(TARGETSUBID))
                    targetSubId = dict.GetString(TARGETSUBID);
                if (dict.Has(TARGETLOCID))
                    targetLocId = dict.GetString(TARGETLOCID);
                SessionID sessionId = new SessionID(dict.GetString(BEGINSTRING), dict.GetString(SENDERCOMPID), senderSubId, senderLocId, dict.GetString(TARGETCOMPID), targetSubId, targetLocId, sessionQualifier);
                Set(sessionId, dict);
            }
        }

        public bool Has(SessionID sessionId)
        {
            return _settings.ContainsKey(sessionId);
        }

        /// <summary>
        /// Get global default settings
        /// </summary>
        /// <returns>Dictionary of settings from the [DEFAULT] section</returns>
        public SettingsDictionary Get()
        {
            return _defaults;
        }

        /// <summary>
        /// Get a dictionary for a session
        /// </summary>
        /// <param name="sessionId">the ID of the session</param>
        /// <returns>Dictionary of settings from the [SESSION] section for the given SessionID</returns>
        public SettingsDictionary Get(SessionID sessionId)
        {
            if (!_settings.TryGetValue(sessionId, out var dict))
                throw new ConfigError($"Session '{sessionId}' not found");
            return dict;
        }

        public void Set(SettingsDictionary defaults)
        {
            _defaults = defaults;
            foreach (KeyValuePair<SessionID, SettingsDictionary> entry in _settings)
                entry.Value.Merge(_defaults);
        }

        /// <summary>
        /// Remove existing session config from the settings
        /// </summary>
        /// <param name="sessionId">ID of session for which config is to be removed</param>
        /// <returns>true if removed, false if config for the session does not exist</returns>
        public bool Remove(SessionID sessionId)
        {
            return _settings.Remove(sessionId);
        }

        /// <summary>
        /// Add new session config
        /// </summary>
        /// <param name="sessionId">ID of session for which to add config</param>
        /// <param name="settings">session config</param>
        public void Set(SessionID sessionId, SettingsDictionary settings)
        {
            if (Has(sessionId))
                throw new ConfigError($"Duplicate Session {sessionId}");
            settings.SetString(BEGINSTRING, sessionId.BeginString);
            settings.SetString(SENDERCOMPID, sessionId.SenderCompID);
            if (SessionID.IsSet(sessionId.SenderSubID))
                settings.SetString(SENDERSUBID, sessionId.SenderSubID);
            if (SessionID.IsSet(sessionId.SenderLocationID))
                settings.SetString(SENDERLOCID, sessionId.SenderLocationID);
            settings.SetString(TARGETCOMPID, sessionId.TargetCompID);
            if (SessionID.IsSet(sessionId.TargetSubID))
                settings.SetString(TARGETSUBID, sessionId.TargetSubID);
            if (SessionID.IsSet(sessionId.TargetLocationID))
                settings.SetString(TARGETLOCID, sessionId.TargetLocationID);
            settings.Merge(_defaults);
            Validate(settings);
            _settings[sessionId] = settings;
        }

        public HashSet<SessionID> GetSessions()
        {
            HashSet<SessionID> result = new HashSet<SessionID>();
            foreach (KeyValuePair<SessionID, SettingsDictionary> entry in _settings)
                result.Add(entry.Key);
            return result;
        }

        public override string ToString()
        {
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            s.AppendLine("[DEFAULT]");

            foreach (System.Collections.Generic.KeyValuePair<string, string> entry in _defaults)
                s.Append(entry.Key).Append('=').AppendLine(entry.Value);

            foreach (KeyValuePair<SessionID, SettingsDictionary> entry in _settings)
            {
                s.AppendLine().AppendLine("[SESSION]");
                foreach (System.Collections.Generic.KeyValuePair<string, string> kvp in entry.Value)
                {
                    if (_defaults.Has(kvp.Key) && _defaults.GetString(kvp.Key).Equals(kvp.Value))
                        continue;
                    s.Append(kvp.Key).Append('=').AppendLine(kvp.Value);
                }
            }

            return s.ToString();
        }

        protected void Validate(SettingsDictionary settingsDictionary)
        {
            string beginString = settingsDictionary.GetString(BEGINSTRING);
            if (beginString != Values.BeginString_FIX40 &&
                beginString != Values.BeginString_FIX41 &&
                beginString != Values.BeginString_FIX42 &&
                beginString != Values.BeginString_FIX43 &&
                beginString != Values.BeginString_FIX44 &&
                beginString != Values.BeginString_FIXT11)
            {
                throw new ConfigError($"{BEGINSTRING} ({beginString}) must be FIX.4.0 to FIX.4.4 or FIXT.1.1");
            }

            string connectionType = settingsDictionary.GetString(CONNECTION_TYPE);
            if (!"initiator".Equals(connectionType) && !"acceptor".Equals(connectionType))
            {
                throw new ConfigError($"{CONNECTION_TYPE} must be 'initiator' or 'acceptor'");
            }
        }
    }
}
