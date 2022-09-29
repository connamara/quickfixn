
using Microsoft.Extensions.Logging;
using System;

namespace QuickFix
{
    [Obsolete("Please use ConsoleLoggerFactory instead")]
    public class ScreenLogFactory : ILoggerProvider, ILogFactory
    {
        public const string SCREEN_LOG_SHOW_INCOMING = "ScreenLogShowIncoming";
        public const string SCREEN_LOG_SHOW_OUTGOING = "ScreenLogShowOutgoing";
        public const string SCREEN_LOG_SHOW_EVENTS   = "ScreenLogShowEvents";

        private SessionSettings _settings = null;
        private bool _logIncoming = true;
        private bool _logOutgoing = true;
        private bool _logEvent    = true;

        public ScreenLogFactory(SessionSettings settings)
        {
            _settings = settings;
        }

        public ScreenLogFactory(bool logIncoming, bool logOutgoing, bool logEvent)
        {
            _logIncoming = logIncoming;
            _logOutgoing = logOutgoing;
            _logEvent    = logEvent;
        }

        #region LogFactory Members

        public ILog Create(SessionID sessionID)
        {
            return CreateScreenLog(sessionID);
        }

        public ILogger CreateLogger(string categoryName)
        {
            var sessionId = SessionID.FromString(categoryName);
            return CreateScreenLog(sessionId);
        }

        public void Dispose()
        {
            return;
        }

        private ScreenLog CreateScreenLog(SessionID sessionID)
        {
            bool logIncoming = _logIncoming;
            bool logOutgoing = _logOutgoing;
            bool logEvent = _logEvent;

            if (_settings != null && _settings.Has(sessionID))
            {
                Dictionary dict = _settings.Get(sessionID);
                if (dict.Has(SCREEN_LOG_SHOW_INCOMING))
                    logIncoming = dict.GetBool(SCREEN_LOG_SHOW_INCOMING);
                if (dict.Has(SCREEN_LOG_SHOW_OUTGOING))
                    logOutgoing = dict.GetBool(SCREEN_LOG_SHOW_OUTGOING);
                if (dict.Has(SCREEN_LOG_SHOW_EVENTS))
                    logEvent = dict.GetBool(SCREEN_LOG_SHOW_EVENTS);
            }

            return new ScreenLog(sessionID, logIncoming, logOutgoing, logEvent);
        }

        #endregion
    }
}
