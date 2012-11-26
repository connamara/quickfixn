using System.Collections.Generic;
using QuickFix;

namespace AcceptanceTest
{
    public class ATApplication : MessageCracker, IApplication
    {
        public event System.Action StopMeEvent;

        private HashSet<KeyValuePair<string, SessionID>> clOrdIDs_ = new HashSet<KeyValuePair<string, SessionID>>();
        private FileLog log_;

        public ATApplication(FileLog debugLog)
        {
            log_ = debugLog;
        }

        public void OnMessage(QuickFix.FIX40.NewOrderSingle nos, SessionID sessionID)
        {
            ProcessNOS(nos, sessionID);
        }

        public void OnMessage(QuickFix.FIX41.NewOrderSingle nos, SessionID sessionID)
        {
            ProcessNOS(nos, sessionID);
        }

        public void OnMessage(QuickFix.FIX42.NewOrderSingle nos, SessionID sessionID)
        {
            ProcessNOS(nos, sessionID);
        }

        public void OnMessage(QuickFix.FIX42.SecurityDefinition message, SessionID sessionID)
        {
            Echo(message, sessionID);
        }

        public void OnMessage(QuickFix.FIX43.NewOrderSingle nos, SessionID sessionID)
        {
            ProcessNOS(nos, sessionID);
        }

        public void OnMessage(QuickFix.FIX43.SecurityDefinition message, SessionID sessionID)
        {
            Echo(message, sessionID);
        }

        public void OnMessage(QuickFix.FIX44.NewOrderSingle nos, SessionID sessionID)
        {
            ProcessNOS(nos, sessionID);
        }

        public void OnMessage(QuickFix.FIX44.SecurityDefinition message, SessionID sessionID)
        {
            Echo(message, sessionID);
        }

        public void OnMessage(QuickFix.FIX50.NewOrderSingle nos, SessionID sessionID)
        {
            ProcessNOS(nos, sessionID);
        }

        public void OnMessage(QuickFix.FIX50.SecurityDefinition message, SessionID sessionID)
        {
            Echo(message, sessionID);
        }

        protected void Echo(Message message, SessionID sessionID)
        {
            Message echo = new Message(message);
            Session.SendToTarget(echo, sessionID);
        }

        protected void ProcessNOS(Message message, SessionID sessionID)
        {
            Message echo = new Message(message);

            bool possResend = false;
            if (message.Header.IsSetField(QuickFix.Fields.Tags.PossResend))
                possResend = message.Header.GetBoolean(QuickFix.Fields.Tags.PossResend);

            KeyValuePair<string, SessionID> pair = new KeyValuePair<string, SessionID>(message.GetField(QuickFix.Fields.Tags.ClOrdID), sessionID);
            if (possResend && clOrdIDs_.Contains(pair))
                return;
            clOrdIDs_.Add(pair);

            Session.SendToTarget(echo, sessionID);
        }


        public void OnMessage(QuickFix.FIX41.News news, SessionID sessionID) { ProcessNews(news, sessionID); }
        public void OnMessage(QuickFix.FIX42.News news, SessionID sessionID) { ProcessNews(news, sessionID); }
        public void OnMessage(QuickFix.FIX43.News news, SessionID sessionID) { ProcessNews(news, sessionID); }
        public void OnMessage(QuickFix.FIX44.News news, SessionID sessionID) { ProcessNews(news, sessionID); }
        public void OnMessage(QuickFix.FIX50.News news, SessionID sessionID) { ProcessNews(news, sessionID); }

        public void ProcessNews(QuickFix.Message msg, SessionID sessionID)
        {
            if (msg.IsSetField(QuickFix.Fields.Tags.Headline) && (msg.GetString(QuickFix.Fields.Tags.Headline) == "STOPME"))
            {
                if (this.StopMeEvent != null)
                    StopMeEvent();
            }
            else
                Echo(msg, sessionID);
        }

        public void OnMessage(QuickFix.FIX44.TradeCaptureReportRequest msg, SessionID sessionID)
        {
            // do nothing, just swallow it.
        }

        #region Application Methods

        public void OnCreate(SessionID sessionID)
        {
            Session session = Session.LookupSession(sessionID);

            // Hey QF/J users, don't do this in a real app.
            if (null != session)
                session.Reset("AT Session Reset");
        }

        public void OnLogout(SessionID sessionID)
        {
            clOrdIDs_.Clear();
        }

        public void OnLogon(SessionID sessionID)
        { }

        public void FromApp(Message message, SessionID sessionID)
        {
            try
            {
                string msgType = message.Header.GetField(QuickFix.Fields.Tags.MsgType);
                log_.OnEvent("Got message " + msgType);
                Crack(message, sessionID);
            }
            catch (QuickFix.UnsupportedMessageType)
            {
                throw;
            }
            catch (System.Exception e)
            {
                log_.OnEvent("FromApp: " + e.ToString() + " while processing msg (" + message.ToString() + ")");
            }
        }

        public void FromAdmin(Message message, SessionID sessionID)
        { }

        public void ToAdmin(Message message, SessionID sessionID) { }
        public void ToApp(Message message, SessionID sessionID) { }

        #endregion
    }
}
