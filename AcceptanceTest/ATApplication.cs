using System.Collections.Generic;
using QuickFix;

namespace AcceptanceTest
{
    public class ATApplication : Application
    {
        private HashSet<KeyValuePair<string,SessionID>> clOrdIDs_ = new HashSet<KeyValuePair<string,SessionID>>();
        private FileLog log_;

        public ATApplication(FileLog debugLog)
        {
            log_ = debugLog;
        }

        protected void Process(string msgType, Message message, SessionID sessionID)
        {
            Message echo = new Message(message);
            
            if (QuickFix.FixValues.MsgType.NEW_ORDER_SINGLE.Equals(msgType))
            {
                bool possResend = false;
                if (message.Header.isSetField(QuickFix.Fields.Tags.PossResend))
                    possResend = QuickFix.Fields.Converters.BoolConverter.Convert(message.Header.GetField(QuickFix.Fields.Tags.PossResend));

                KeyValuePair<string, SessionID> pair = new KeyValuePair<string, SessionID>(message.GetField(QuickFix.Fields.Tags.ClOrdID), sessionID);
                if (possResend && clOrdIDs_.Contains(pair))
                    return;
                clOrdIDs_.Add(pair);
            }

            Session.SendToTarget(echo, sessionID);
        }

        #region Application Methods

        public override void OnCreate(SessionID sessionID)
        {
            Session session = Session.LookupSession(sessionID);
            if (null != session)
                session.Reset();
        }
        
        public override void OnLogout(SessionID sessionID)
        {
            clOrdIDs_.Clear();
        }

        public override void OnLogon(SessionID sessionID)
        { }

        public override void FromApp(Message message, SessionID sessionID)
        {
            try
            {
                string msgType = message.Header.GetField(QuickFix.Fields.Tags.MsgType);
                if(QuickFix.FixValues.MsgType.NEW_ORDER_SINGLE.Equals(msgType) || QuickFix.FixValues.MsgType.SECURITY_DEFINITION.Equals(msgType))
                    Process(msgType, message, sessionID);
            }
            catch (System.Exception e)
            {
                log_.OnEvent("FromApp: " + e.ToString() + " while processing msg (" + message.ToString() + ")");
            }
        }

        public override void FromAdmin(Message message, SessionID sessionID)
        { }

        #endregion
    }
}
