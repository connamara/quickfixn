
namespace QuickFix
{
    public class ScreenLogFactory : ILogFactory
    {
        public const string SCREEN_LOG_SHOW_INCOMING = "ScreenLogShowIncoming";
        public const string SCREEN_LOG_SHOW_OUTGOING = "ScreenLogShowOutgoing";
        public const string SCREEN_LOG_SHOW_EVENTS   = "ScreenLogShowEvents";

        private SessionSettings settings_ = null;
        private bool logIncoming_ = true;
        private bool logOutgoing_ = true;
        private bool logEvent_    = true;

        public ScreenLogFactory(SessionSettings settings)
        {
            settings_ = settings;
        }

        public ScreenLogFactory(bool logIncoming, bool logOutgoing, bool logEvent)
        {
            logIncoming_ = logIncoming;
            logOutgoing_ = logOutgoing;
            logEvent_    = logEvent;
        }

        #region LogFactory Members

        public ILog Create(SessionID sessionID)
        {
            bool logIncoming = logIncoming_;
            bool logOutgoing = logOutgoing_;
            bool logEvent    = logEvent_;

            if(settings_ != null && settings_.Has(sessionID))
            {
                Dictionary dict = settings_.Get(sessionID);
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
