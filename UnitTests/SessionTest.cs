using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    class MockResponder : QuickFix.Responder
    {

        #region Responder Members
        QuickFix.DefaultMessageFactory messageFactory = new QuickFix.DefaultMessageFactory();
        
        public Dictionary<string, Queue<QuickFix.Message>> msgLookup = new Dictionary<string, Queue<QuickFix.Message>>();
        public bool disconnected = false;

        public bool Send(string msgStr)
        {
            QuickFix.Fields.MsgType msgType = QuickFix.Message.IdentifyType(msgStr);
            string beginString = QuickFix.Message.ExtractBeginString(msgStr);

            QuickFix.Message message = messageFactory.Create(beginString, msgType.Obj);
            message.FromString(msgStr, false, new QuickFix.DataDictionary.DataDictionary(), new QuickFix.DataDictionary.DataDictionary());

            if (!msgLookup.ContainsKey(msgType.getValue()))
                msgLookup.Add(msgType.getValue(), new Queue<QuickFix.Message>());

            msgLookup[msgType.getValue()].Enqueue(message);

            return true;
        }

        public void Disconnect()
        {
            disconnected = true;
        }

        #endregion
    }

    class MockApplication : QuickFix.Application
    {
        public System.Exception fromAppException = null;
        public System.Exception fromAdminException = null;

        #region Application Members

        public void ToAdmin(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
        }

        public void FromAdmin(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
            if (fromAdminException != null)
                throw fromAdminException;
        }

        public void ToApp(QuickFix.Message message, QuickFix.SessionID sessionId)
        {
            
        }

        public void FromApp(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
            if (fromAppException != null)
                throw fromAppException;
        }

        public void OnCreate(QuickFix.SessionID sessionID)
        {

        }

        public void OnLogout(QuickFix.SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void OnLogon(QuickFix.SessionID sessionID)
        {
        }

        #endregion
    }

    [TestFixture]
    public class SessionTest
    {
        MockResponder responder = null;

        QuickFix.SessionID sessionID = null;
        QuickFix.SessionSettings settings = null;
        MockApplication application = null;
        QuickFix.Session session = null;
        int seqNum = 1;

        [SetUp]
        public void setup()
        {
            responder = new MockResponder();
            sessionID = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");
            application = new MockApplication();
            settings = new QuickFix.SessionSettings();

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetBool(QuickFix.SessionSettings.PERSIST_MESSAGES, false);
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            settings.Set(sessionID, config);

            session = new QuickFix.Session(application, new QuickFix.MemoryStoreFactory(), sessionID, 
                new QuickFix.DataDictionaryProvider(), null, 0, new QuickFix.ScreenLogFactory(settings), new QuickFix.DefaultMessageFactory(), "blah");
            session.SetResponder(responder);
            session.MaxLatency=120;

            seqNum = 1;
        }

        public void Logon()
        {
            QuickFix.FIX42.Logon login = new QuickFix.FIX42.Logon();
            login.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            login.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            login.Header.SetField(new QuickFix.Fields.MsgSeqNum(seqNum++));
            login.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            login.SetField(new QuickFix.Fields.HeartBtInt(30));
            session.Next(login);
        }

        public bool SENT_REJECT()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT) && 
                responder.msgLookup[QuickFix.Fields.MsgType.REJECT].Count>0;
        }

        public bool SENT_BUSINESS_REJECT()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.BUSINESS_MESSAGE_REJECT) &&
                responder.msgLookup[QuickFix.Fields.MsgType.BUSINESS_MESSAGE_REJECT].Count > 0;
        }

        public bool SENT_LOGOUT()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.LOGOUT) &&
                responder.msgLookup[QuickFix.Fields.MsgType.LOGOUT].Count > 0;
        }

        public bool DISCONNECTED()
        {
            return responder.disconnected;
        }

        public bool SENT_REJECT(int reason, int refTag)
        {
            if (!SENT_REJECT())
                return false;

            QuickFix.Message msg = responder.msgLookup[QuickFix.Fields.MsgType.REJECT].First();

            if (!msg.IsSetField(QuickFix.Fields.Tags.SessionRejectReason))
                return false;

            QuickFix.Fields.SessionRejectReason reasonField = new QuickFix.Fields.SessionRejectReason();
            msg.GetField(reasonField);
            if(reasonField.getValue() != reason)
                return false;

            if (!msg.IsSetField(QuickFix.Fields.Tags.RefTagID))
                return false;

            QuickFix.Fields.RefTagID refTagField = new QuickFix.Fields.RefTagID();
            msg.GetField(refTagField);
            if (refTagField.getValue() != refTag)
                return false;

            return true;
        }

        public void SendMessage()
        {
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                new QuickFix.Fields.ClOrdID("1"),
                new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                new QuickFix.Fields.Symbol("IBM"),
                new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                new QuickFix.Fields.TransactTime(),
                new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

            order.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            order.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(seqNum++));

            session.Next(order);
        }

        [Test]
        public void ConditionalTagMissingReject()
        {   
            application.fromAppException = new QuickFix.FieldNotFoundException(61);

            Logon();
            SendMessage();

            Assert.That(SENT_REJECT(QuickFix.Fields.SessionRejectReason.REQUIRED_TAG_MISSING,61));
        }



        [Test]
        public void IncorrectTagValueReject()
        {
            application.fromAppException = new QuickFix.IncorrectTagValue(54);
            
            Logon();
            SendMessage();
            Assert.That(SENT_REJECT(QuickFix.Fields.SessionRejectReason.VALUE_IS_INCORRECT,54));

        }

        [Test]
        public void UnsupportedMessageReject()
        {
            application.fromAppException = new QuickFix.UnsupportedMessageType();

            Logon();
            SendMessage();
            Assert.That(SENT_BUSINESS_REJECT());
        }

        [Test]
        public void LogonReject()
        {
            application.fromAdminException  = new QuickFix.RejectLogon("Failed Logon");
            Logon();

            Assert.That(SENT_LOGOUT());
            Assert.That(DISCONNECTED());
        }
    }
}
