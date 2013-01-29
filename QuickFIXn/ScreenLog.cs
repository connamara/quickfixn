using System;

namespace QuickFix
{
    /// <summary>
    /// FIXME - needs to log sessionIDs, timestamps, etc.
    /// </summary>
    public class ScreenLog : ILog
    {
        private object sync_ = new object();
        private SessionID sessionID_;
        private bool logIncoming_;
        private bool logOutgoing_;
        private bool logEvent_;
        private bool logDebug_;

        [Obsolete]
        public ScreenLog(SessionID sessionID, bool logIncoming, bool logOutgoing, bool logEvent)
            : this(sessionID, logIncoming, logOutgoing, logEvent, false)
        {
        }
        
        public ScreenLog(SessionID sessionID, bool logIncoming, bool logOutgoing, bool logEvent, bool logDebug)
        {
            sessionID_   = sessionID;
            logIncoming_ = logIncoming;
            logOutgoing_ = logOutgoing;
            logEvent_    = logEvent;
            logDebug_    = logDebug;
        }

        #region Log Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        {
            if (!logIncoming_)
                return;
            
            lock (sync_)
            {
                System.Console.WriteLine("<incoming> " + msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            if (!logOutgoing_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<outgoing> " + msg);
            }
        }

        public void OnEvent(string s)
        {
            if (!logEvent_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<event> " + s);
            }
        }

        public void OnDebug(string s)
        {
            if (!logEvent_)
                return;

            lock (sync_)
            {
                System.Console.WriteLine("<debug> " + s);
            }
        }
        #endregion


    }
}
