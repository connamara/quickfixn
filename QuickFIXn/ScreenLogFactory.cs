#nullable enable

namespace QuickFix
{
    public class ScreenLogFactory : ILogFactory
    {
        private const string SCREEN_LOG_SHOW_INCOMING = "ScreenLogShowIncoming";
        private const string SCREEN_LOG_SHOW_OUTGOING = "ScreenLogShowOutgoing";
        private const string SCREEN_LOG_SHOW_EVENTS   = "ScreenLogShowEvents";

        private readonly SessionSettings _settings;

        public ScreenLogFactory(SessionSettings settings)
        {
            _settings = settings;
        }

        #region LogFactory Members

        public ILog Create(SessionID sessionId) {
            bool logIncoming = false;
            bool logOutgoing = false;
            bool logEvent = false;

            if(_settings.Has(sessionId))
            {
                Dictionary dict = _settings.Get(sessionId);
                if (dict.Has(SCREEN_LOG_SHOW_INCOMING))
                    logIncoming = dict.GetBool(SCREEN_LOG_SHOW_INCOMING);
                if (dict.Has(SCREEN_LOG_SHOW_OUTGOING))
                    logOutgoing = dict.GetBool(SCREEN_LOG_SHOW_OUTGOING);
                if (dict.Has(SCREEN_LOG_SHOW_EVENTS))
                    logEvent = dict.GetBool(SCREEN_LOG_SHOW_EVENTS);
            }

            return new ScreenLog(logIncoming, logOutgoing, logEvent);
        }

        #endregion
    }
}
