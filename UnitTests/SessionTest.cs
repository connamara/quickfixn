using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Threading;

namespace UnitTests
{
    class MockResponder : QuickFix.IResponder
    {

        #region Responder Members
        QuickFix.DefaultMessageFactory messageFactory = new QuickFix.DefaultMessageFactory();
        
        public Dictionary<string, Queue<QuickFix.Message>> msgLookup = new Dictionary<string, Queue<QuickFix.Message>>();
        public Queue<QuickFix.Message> dups = new Queue<QuickFix.Message>();

        private QuickFix.IMessageFactory _defaultMsgFactory = new QuickFix.DefaultMessageFactory();

        public bool disconnected = false;

        public bool Send(string msgStr)
        {
            QuickFix.Fields.MsgType msgType = QuickFix.Message.IdentifyType(msgStr);
            string beginString = QuickFix.Message.ExtractBeginString(msgStr);

            QuickFix.Message message = messageFactory.Create(beginString, msgType.Obj);
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            message.FromString(msgStr, false, dd, dd, _defaultMsgFactory);

            if (!msgLookup.ContainsKey(msgType.getValue()))
                msgLookup.Add(msgType.getValue(), new Queue<QuickFix.Message>());

            msgLookup[msgType.getValue()].Enqueue(message);

            QuickFix.Fields.PossDupFlag possDup = new QuickFix.Fields.PossDupFlag(false);
            if (message.Header.IsSetField(possDup))
                message.Header.GetField(possDup);

            if (possDup.getValue() && msgType.getValue()!= QuickFix.Fields.MsgType.SEQUENCE_RESET)
            {
                dups.Enqueue(message);
            }

            return true;
        }

        public void Disconnect()
        {
            disconnected = true;
        }

        #endregion
    }

    class MockApplication : QuickFix.IApplication
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
        QuickFix.Session session2 = null;
        int seqNum = 1;
        Regex msRegex = new Regex(@"\.[\d]{1,3}$");

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
            config.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            config.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
            settings.Set(sessionID, config);

            session = new QuickFix.Session(application, new QuickFix.MemoryStoreFactory(), sessionID, 
                new QuickFix.DataDictionaryProvider(),new QuickFix.SessionSchedule(config), 0, new QuickFix.ScreenLogFactory(settings), new QuickFix.DefaultMessageFactory(), "blah");
            session.SetResponder(responder);
            session.MaxLatency=120;

            // must be set for an initiator
            int heartBeatInterval = 10;

            session2 = new QuickFix.Session(application, new QuickFix.MemoryStoreFactory(), new QuickFix.SessionID("FIX.4.2", "OTHER_SENDER", "OTHER_TARGET"),
                new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(config), heartBeatInterval, new QuickFix.ScreenLogFactory(settings), new QuickFix.DefaultMessageFactory(), "blah");
            session2.SetResponder(responder);
            session2.MaxLatency = 120;

            seqNum = 1;
        }

        public void Logon()
        {
            SendLogon(new QuickFix.FIX42.Logon());
        }

        public void Logon40()
        {
            SendLogon(new QuickFix.FIX40.Logon());
        }

        private void SendLogon(QuickFix.Message msg)
        {
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(seqNum++));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.HeartBtInt(1));
            session.Next(msg);
        }

        public bool SENT_RESEND()
        {
            if (!responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.SEQUENCE_RESET) &&
                responder.msgLookup[QuickFix.Fields.MsgType.SEQUENCE_RESET].Count > 0)
                return false;

            responder.msgLookup[QuickFix.Fields.MsgType.SEQUENCE_RESET].Dequeue();

            return true;
        }

        public bool RESENT()
        {
            if (responder.dups.Count == 0)
                return false;

            responder.dups.Dequeue();
            return true;
        }

        public bool SENT_REJECT()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT) && 
                responder.msgLookup[QuickFix.Fields.MsgType.REJECT].Count>0;
        }

	public bool SENT_HEART_BEAT()
	{
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.HEARTBEAT) &&
                responder.msgLookup[QuickFix.Fields.MsgType.HEARTBEAT].Count > 0;
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

        public void SendNOSMessage()
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

        public void SendResendRequest(int begin, int end)
        {
            SendTheMessage(new QuickFix.FIX42.ResendRequest(
                new QuickFix.Fields.BeginSeqNo(begin),
                new QuickFix.Fields.EndSeqNo(end)));
        }

        public void SendResendRequest40(int begin, int end)
        {
            SendTheMessage(new QuickFix.FIX40.ResendRequest(
                new QuickFix.Fields.BeginSeqNo(begin),
                new QuickFix.Fields.EndSeqNo(end)));
        }

        private void SendTheMessage(QuickFix.Message msg)
        {
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(seqNum++));

            session.Next(msg);
        }

        [Test]
        public void ConditionalTagMissingReject()
        {   
            application.fromAppException = new QuickFix.FieldNotFoundException(61);

            Logon();
            SendNOSMessage();

            Assert.That(SENT_REJECT(QuickFix.Fields.SessionRejectReason.REQUIRED_TAG_MISSING,61));
        }



        [Test]
        public void IncorrectTagValueReject()
        {
            application.fromAppException = new QuickFix.IncorrectTagValue(54);
            
            Logon();
            SendNOSMessage();
            Assert.That(SENT_REJECT(QuickFix.Fields.SessionRejectReason.VALUE_IS_INCORRECT,54));

        }

        [Test]
        public void UnsupportedMessageReject()
        {
            application.fromAppException = new QuickFix.UnsupportedMessageType();

            Logon();
            SendNOSMessage();
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

	[Test]
	public void HeartBeatCheckAfterMessageProcess()
	{
	    Logon();
	    Thread.Sleep(2000);

            SendNOSMessage();
            Assert.That(SENT_HEART_BEAT());
	}

        [Test]
        public void NextResendRequestNoMessagePersist()
        {
            session.PersistMessages = false;

            Logon(); //seq 1

            for (int i = 0; i < 3; ++i)
            {
                SendNOSMessage();
            } //seq 4, next is 5

            SendResendRequest(1, 4);
            Assert.That(SENT_RESEND());
            Assert.IsFalse(RESENT());
        }

        public void AssertMsInTag(string msgType, int tag, bool shouldHaveMs)
        {
            QuickFix.Message msg = responder.msgLookup[msgType].Last();
            string sendingTime = msg.Header.GetField(tag);
            Match m = msRegex.Match(sendingTime);
            Assert.That(m.Success == shouldHaveMs);
        }

        [Test]
        public void TestMillisecondsInSendingTimeStamp()
        {
            // MS in timestamp should default to Y
            Assert.That(session.MillisecondsInTimeStamp);

            // Ms should show up
            Logon();
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);
            
            // No ms
            session.MillisecondsInTimeStamp = false;
            Logon();
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Count == 2);
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);

            // Less than FIX42 - no ms in timestamp, even if you tell it to
            sessionID = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
            session.SessionID = sessionID;
            session.MillisecondsInTimeStamp = true;
            Logon40();
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Count == 3);
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);
        }

        [Test]
        public void TestMillisecondsInOrigSendingTimeStamp()
        {
            // MS in timestamp should default to Y
            Assert.That(session.MillisecondsInTimeStamp);
            
            // Logon first
            Logon();
            
            // Do a resend request
            SendResendRequest(0, 2);
            AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, true);
            
            // NO MS
            session.MillisecondsInTimeStamp = false;
            SendResendRequest(0, 2);
            AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);

            // Less than FIX42 - no ms in timestamp, even if you tell it to
            sessionID = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
            session.SessionID = sessionID;
            session.MillisecondsInTimeStamp = true;
            SendResendRequest40(0, 2);
            AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);
        }

        [Test]
        public void TestLastMsgSeqNumProcessed()
        {
            // Disabled by default
            Assert.That(!session.EnableLastMsgSeqNumProcessed);

            session.EnableLastMsgSeqNumProcessed = true;

            // Logon 
            Logon();
            QuickFix.Message msg = responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Last();
            int lastSeqNumProcessed = msg.Header.GetInt(QuickFix.Fields.Tags.LastMsgSeqNumProcessed);
            Assert.That(lastSeqNumProcessed == 1);

            // NOS
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
            session.Send(order);

            msg = responder.msgLookup[QuickFix.Fields.MsgType.NEW_ORDER_D].Last();
            lastSeqNumProcessed = msg.Header.GetInt(QuickFix.Fields.Tags.LastMsgSeqNumProcessed);
            Assert.That(lastSeqNumProcessed == 1);
        }

        [Test]
        public void TestMaxMessagesInResendRequest()
        {
            // Default
            Assert.That(session.MaxMessagesInResendRequest, Is.EqualTo(0));

            session.MaxMessagesInResendRequest = 2500;
            // Logon 
            Logon();

            // NOS
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                new QuickFix.Fields.ClOrdID("1"),
                new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                new QuickFix.Fields.Symbol("IBM"),
                new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                new QuickFix.Fields.TransactTime(),
                new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

            order.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            order.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(5005));
            // This will generate resend requests
            session.Verify(order, true, false);

            // 3 resend requests
            //  2->2501
            //  2502->5001
            //  5002->5005
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 3);
            QuickFix.Message msg = responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(2));
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(2501));

            msg = responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(2502));
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(5001));

            msg = responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(5002));
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(5004));
        }

        [Test]
        public void TestIgnorePossDupInResendRequest()
        {
            // Default is false
            Assert.That(session.IgnorePossDupResendRequests, Is.EqualTo(false));

            session.IgnorePossDupResendRequests = true;
            // Logon 
            Logon();

            // NOS
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
            // This will generate resend requests
            session.Send(order);

            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.NEWORDERSINGLE].Count == 1);

            QuickFix.Message msg = new QuickFix.FIX42.ResendRequest(
                new QuickFix.Fields.BeginSeqNo(1),
                new QuickFix.Fields.EndSeqNo(0));
            msg.Header.SetField(new QuickFix.Fields.PossDupFlag(true));
            SendTheMessage(msg);

            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.NEWORDERSINGLE].Count == 1);
        }

        [Test]
        public void TestDoesSessionExist()
        {
            QuickFix.SessionID invalidSessionID = new QuickFix.SessionID("FIX.4.2", "NOT_SENDER", "NOT_TARGET");
            QuickFix.SessionID validSessionID = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");

            Assert.That(QuickFix.Session.DoesSessionExist(invalidSessionID), Is.EqualTo(false));
            Assert.That(QuickFix.Session.DoesSessionExist(validSessionID), Is.EqualTo(true));            
        }

        [Test]
        public void TestSettingNextTargetMsgSeqNum()
        {
            session.NextTargetMsgSeqNum = 100;
            Assert.That(session.NextTargetMsgSeqNum, Is.EqualTo(100));
        }

        [Test]
        public void TestSettingNextSenderMsgSeqNum()
        {
            session.NextSenderMsgSeqNum = 200;
            Assert.That(session.NextSenderMsgSeqNum, Is.EqualTo(200));
        }

        [Test]
        public void TestGettingIsInitiator()
        {
            Assert.That(session2.IsInitiator, Is.EqualTo(true));
        }

        [Test]
        public void TestGettingIsAcceptor()
        {
            Assert.That(session2.IsAcceptor, Is.EqualTo(false));
        }

        [Test]
        public void TestMessageStoreAccessor()
        {
            List<string> messages = new List<string>();

            messages.Clear();
            session.MessageStore.Get(0, 100, messages);
            Assert.That(messages.Count, Is.EqualTo(0));

            Logon();

            messages.Clear();
            session.MessageStore.Get(0, 100, messages);
            Assert.That(messages.Count, Is.EqualTo(1)); // logon response
        }
    }
}
