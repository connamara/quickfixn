using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// For debug use if needed
        /// </summary>
        public void DumpMsgLookup()
        {
            Console.WriteLine("Responder dump:");
            foreach (string key in msgLookup.Keys)
            {
                Console.WriteLine(String.Format("  {0}: count {1}", key, msgLookup[key].Count));
                foreach (QuickFix.Message m in msgLookup[key])
                {
                    Console.WriteLine("  - " + m.ToString());
                }
            }
        }

        public int GetCount(string msgType)
        {
            return msgLookup.ContainsKey(msgType) ? msgLookup[msgType].Count : 0;
        }

        #endregion
    }

    class MockApplication : QuickFix.IApplication
    {
        public System.Exception fromAppException = null;
        public System.Exception fromAdminException = null;
        public QuickFix.DoNotSend doNotSendException = null;

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
            if (doNotSendException != null)
                throw doNotSendException;
            
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

    class MockApplicationExt : QuickFix.IApplicationExt
    {
        public HashSet<string> InterceptedMessageTypes = new HashSet<string>();

        #region Application Members

        public void ToAdmin(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
        }

        public void FromAdmin(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
        }

        public void ToApp(QuickFix.Message message, QuickFix.SessionID sessionId)
        {
        }

        public void FromApp(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
        }

        public void OnCreate(QuickFix.SessionID sessionID)
        {
        }

        public void OnLogout(QuickFix.SessionID sessionID)
        {
        }

        public void OnLogon(QuickFix.SessionID sessionID)
        {
        }

        public void FromEarlyIntercept(QuickFix.Message message, QuickFix.SessionID sessionID)
        {
            InterceptedMessageTypes.Add(message.Header.GetString(QuickFix.Fields.Tags.MsgType));
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
        QuickFix.Dictionary config = null;
        int seqNum = 1;
        Regex msRegex = new Regex(@"\.[\d]{1,3}$");
        Regex microsecondRegex = new Regex(@"\.[\d]{1,6}$");

        [SetUp]
        public void Setup()
        {
            responder = new MockResponder();
            sessionID = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");
            application = new MockApplication();
            settings = new QuickFix.SessionSettings();

            config = new QuickFix.Dictionary();
            config.SetBool(QuickFix.SessionSettings.PERSIST_MESSAGES, false);
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            config.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
            settings.Set(sessionID, config);

            var logFactory = new QuickFix.NullLogFactory(); // use QuickFix.ScreenLogFactory(settings) if you need to see output

            // acceptor
            session = new QuickFix.Session(false, application, new QuickFix.MemoryStoreFactory(), sessionID,
                new QuickFix.DataDictionaryProvider(),new QuickFix.SessionSchedule(config), 0, logFactory, new QuickFix.DefaultMessageFactory(), "blah");
            session.SetResponder(responder);
            session.CheckLatency = false;

            // initiator
            session2 = new QuickFix.Session(true, application, new QuickFix.MemoryStoreFactory(), new QuickFix.SessionID("FIX.4.2", "OTHER_SENDER", "OTHER_TARGET"),
                new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(config), 0, logFactory, new QuickFix.DefaultMessageFactory(), "blah");
            session2.SetResponder(responder);
            session2.CheckLatency = false;

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
            session.Next(msg.ToString());
        }

        public bool SENT_SEQUENCE_RESET()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.SEQUENCE_RESET) &&
                responder.msgLookup[QuickFix.Fields.MsgType.SEQUENCE_RESET].Count > 0;
        }

        public bool SENT_RESEND_REQUEST()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.RESEND_REQUEST) &&
                responder.msgLookup[QuickFix.Fields.MsgType.RESEND_REQUEST].Count > 0;
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

        public bool SENT_BUSINESS_REJECT(int reason)
        {
            if (!SENT_BUSINESS_REJECT())
                return false;

            QuickFix.Message msg = responder.msgLookup[QuickFix.Fields.MsgType.BUSINESS_MESSAGE_REJECT].First();

            if (!msg.IsSetField(QuickFix.Fields.Tags.BusinessRejectReason))
                return false;

            QuickFix.Fields.BusinessRejectReason reasonField = new QuickFix.Fields.BusinessRejectReason();
            msg.GetField(reasonField);
            if (reasonField.getValue() != reason)
                return false;

            return true;
        }

        public bool SENT_LOGOUT()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.LOGOUT) &&
                responder.msgLookup[QuickFix.Fields.MsgType.LOGOUT].Count > 0;
        }

        public bool SENT_NOS()
        {
            return responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.NEWORDERSINGLE) &&
                responder.msgLookup[QuickFix.Fields.MsgType.NEWORDERSINGLE].Count > 0;
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

            session.Next(order.ToString());
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

            session.Next(msg.ToString());
        }

        [Test]
        public void ConditionalTagMissingReject()
        {   
            application.fromAppException = new QuickFix.FieldNotFoundException(61);

            Logon();
            SendNOSMessage();

            Assert.That(SENT_BUSINESS_REJECT(QuickFix.Fields.BusinessRejectReason.CONDITIONALLY_REQUIRED_FIELD_MISSING));
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
            Assert.That(SENT_SEQUENCE_RESET());
            Assert.IsFalse(RESENT());
        }

        [Test]
        public void TestGapFillOnResend()
        {
            // Engineer a gap fill at the beginning of a re-send range, in the middle, and at the end
            Logon(); //seq 1
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                new QuickFix.Fields.ClOrdID("1"),
                new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                new QuickFix.Fields.Symbol("IBM"),
                new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                new QuickFix.Fields.TransactTime(),
                new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

            order.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.TargetCompID));
            order.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.SenderCompID));

            int[] gapStarts = new[] { 1, 5, 11 }; // 1st gap  from seq num 1 to 2 is just the Logon message
            int[] gapEnds = new[] { 2, 8, 15 };
            int orderCount = 0;

            for (int msgSeqNum = gapEnds[0]; msgSeqNum < gapStarts[1]; ++msgSeqNum)
            {
                order.Header.SetField(new QuickFix.Fields.MsgSeqNum(msgSeqNum));
                session.Send(order);
                ++orderCount;
            } //seq 4, next is 5

            for (int msgSeqNum = gapStarts[1]; msgSeqNum < gapEnds[1]; ++msgSeqNum)
            {
                session.GenerateHeartbeat();
            } //seq 7, next is 8

            for (int msgSeqNum = gapEnds[1]; msgSeqNum < gapStarts[2]; ++msgSeqNum)
            {
                order.Header.SetField(new QuickFix.Fields.MsgSeqNum(msgSeqNum));
                session.Send(order);
                ++orderCount;
            } //seq 10, next is 11

            for (int msgSeqNum = gapStarts[2]; msgSeqNum < gapEnds[2]; ++msgSeqNum)
            {
                session.GenerateHeartbeat();
            } // seq 11 - 14

            responder.msgLookup.Clear();
            SendResendRequest(1, 100);

            Assert.AreEqual(responder.GetCount(QuickFix.Fields.MsgType.NEWORDERSINGLE), orderCount);
            Assert.AreEqual(responder.GetCount(QuickFix.Fields.MsgType.SEQUENCE_RESET), gapStarts.Length);

            int count = -1;
            foreach (QuickFix.Message sequenceResestMsg in responder.msgLookup[QuickFix.Fields.MsgType.SEQUENCE_RESET])
            {
                Assert.AreEqual(sequenceResestMsg.GetString(QuickFix.Fields.Tags.GapFillFlag), "Y");
                Assert.AreEqual(sequenceResestMsg.Header.GetInt(QuickFix.Fields.Tags.MsgSeqNum), gapStarts[++count]);
                Assert.AreEqual(sequenceResestMsg.GetInt(QuickFix.Fields.Tags.NewSeqNo), gapEnds[count]);
            }
        }

        [Test]
        public void TestResendSessionLevelReject()
        {
            Assert.False(session.ResendSessionLevelRejects); // check for correct default
            Logon(); 

            QuickFix.FIX42.Reject reject = new QuickFix.FIX42.Reject(
                new QuickFix.Fields.RefSeqNum(10));

            reject.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.TargetCompID));
            reject.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.SenderCompID));
            session.Send(reject);

            responder.msgLookup.Clear();
            session.ResendSessionLevelRejects = true;
            SendResendRequest(1, 100);
            Assert.That(responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT));

            responder.msgLookup.Clear();
            session.ResendSessionLevelRejects = false;
            SendResendRequest(1, 100);
            Assert.False(responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT));
        }

        public void AssertMsInTag(string msgType, int tag, bool shouldHaveMs)
        {
            QuickFix.Message msg = responder.msgLookup[msgType].Last();
            string sendingTime = msg.Header.GetString(tag);
            Match m = msRegex.Match(sendingTime);
            Assert.That(m.Success == shouldHaveMs);
        }

        public void AssertMicrosecondsInTag(string msgType, int tag, bool shouldHaveMicrosecond)
        {
            QuickFix.Message msg = responder.msgLookup[msgType].Last();
            string sendingTime = msg.Header.GetString(tag);
            Match m = microsecondRegex.Match(sendingTime);
            Assert.That(m.Success == shouldHaveMicrosecond);
        }

        [Test]
        public void TestMillisecondsInSendingTimeStamp()
        {
            // MS in timestamp should default to Y
            Assert.That(session.TimeStampPrecision == QuickFix.Fields.Converters.TimeStampPrecision.Millisecond );

            // Ms should show up
            Logon();
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);
            
            // No ms
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Second;
            Logon();
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Count == 2);
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);

            // Less than FIX42 - no ms in timestamp, even if you tell it to
            sessionID = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
            session.SessionID = sessionID;
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Millisecond;
            Logon40();
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Count == 3);
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);
        }

        [Test]
        public void TestMicrosecondsInSendingTimeStamp()
        {
            // Microseconds in timestamp
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;

            // Microseconds should show up
            Logon();
            AssertMicrosecondsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);

            // Milliseconds in timestamp
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Millisecond;
            Logon();
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Count == 2);
            AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);

            // Less than FIX42 - no microseconds in timestamp, even if you tell it to
            sessionID = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
            session.SessionID = sessionID;
            session.TimeStampPrecision =  QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;
            Logon40();
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.LOGON].Count == 3);
            AssertMicrosecondsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);
        }

        [Test]
        public void TestMillisecondsInOrigSendingTimeStamp()
        {
            // MS in timestamp should default 
            Assert.That( session.TimeStampPrecision == QuickFix.Fields.Converters.TimeStampPrecision.Millisecond );
            
            // Logon first
            Logon();
            
            // Do a resend request
            SendResendRequest(0, 2);
            AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, true);

            // NO MS
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Second;
            SendResendRequest(0, 2);
            AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);

            // Less than FIX42 - no ms in timestamp, even if you tell it to
            sessionID = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
            session.SessionID = sessionID;
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Millisecond;
            SendResendRequest40(0, 2);
            AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);
        }

        [Test]
        public void TestMicrosecondsInOrigSendingTimeStamp()
        {
            // Microsecond in timestamp 
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;

            // Logon first
            Logon();

            // Do a resend request
            SendResendRequest(0, 2);
            AssertMicrosecondsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, true);

            // NO MS
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Second;
            SendResendRequest(0, 2);
            AssertMicrosecondsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);

            // Less than FIX42 - no ms in timestamp, even if you tell it to
            sessionID = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
            session.SessionID = sessionID;
            session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;
            SendResendRequest40(0, 2);
            AssertMicrosecondsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);
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

            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 1);
            QuickFix.Message msg = responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(2));
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(2501));

            // Jump forward to the end of the resend chunk with a fillgap reset message
            QuickFix.FIX42.SequenceReset reset = new QuickFix.FIX42.SequenceReset();
            reset.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            reset.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            reset.SetField(new QuickFix.Fields.GapFillFlag(true));

            reset.Header.SetField(new QuickFix.Fields.MsgSeqNum(2));
            reset.SetField(new QuickFix.Fields.NewSeqNo(2501));
            session.Next(reset.ToString());

            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(2501));
            session.Next(order.ToString());

            // Should have triggered next resend (2502->5001), check this
            //Console.WriteLine(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count);
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 1);
            msg = responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(2502));
            Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(5001));

            // Jump forward to the end of the resend chunk with a fillgap reset message
            reset.Header.SetField(new QuickFix.Fields.MsgSeqNum(2502));
            reset.SetField(new QuickFix.Fields.NewSeqNo(5001));
            session.Next(reset.ToString());

            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(5001));
            session.Next(order.ToString());   // Triggers next resend (5002->5005)

            //Console.WriteLine(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count);
            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 1);
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

        [Test]
        public void TestRequiresOrigSendingTime_Y()
        {
            // Under default configuration, session should reject a ResendRequest that lacks OrigSendingTime unset

            // Check default is as expected
            Assert.That(session.RequiresOrigSendingTime, Is.EqualTo(true));

            Logon();

            QuickFix.FIX42.SequenceReset sr = new QuickFix.FIX42.SequenceReset(new QuickFix.Fields.NewSeqNo(5));
            sr.GapFillFlag = new QuickFix.Fields.GapFillFlag(true);
            sr.Header.SetField(new QuickFix.Fields.PossDupFlag(true));

            sr.Header.SetField(new QuickFix.Fields.MsgSeqNum(seqNum--)); // so it triggers DoTargetTooLow code

            SendTheMessage(sr);

            Assert.That(responder.msgLookup[QuickFix.Fields.MsgType.REJECT].Count == 1);
            QuickFix.FIX42.Reject rej = responder.msgLookup[QuickFix.Fields.MsgType.REJECT].Peek() as QuickFix.FIX42.Reject;
            Assert.That(rej.SessionRejectReason.getValue(), Is.EqualTo(QuickFix.Fields.SessionRejectReason.REQUIRED_TAG_MISSING));
        }

        [Test]
        public void TestRequiresOrigSendingTime_N()
        {
            // Under OrigSendingTime=N, session will allow ResendRequest that lacks OrigSendingTime
            session.RequiresOrigSendingTime = false;

            Logon();

            QuickFix.FIX42.SequenceReset sr = new QuickFix.FIX42.SequenceReset(new QuickFix.Fields.NewSeqNo(5));
            sr.GapFillFlag = new QuickFix.Fields.GapFillFlag(true);
            sr.Header.SetField(new QuickFix.Fields.PossDupFlag(true));

            sr.Header.SetField(new QuickFix.Fields.MsgSeqNum(seqNum--)); // so it triggers DoTargetTooLow code

            SendTheMessage(sr);

            Assert.False(responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT));
        }
        [Test]
        public void TestToAppDoNotSend()
        {
            Logon();
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                 new QuickFix.Fields.ClOrdID("1"),
                 new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                 new QuickFix.Fields.Symbol("IBM"),
                 new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                 new QuickFix.Fields.TransactTime(),
                 new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

            application.doNotSendException = new QuickFix.DoNotSend();
            session.Send(order);
            Assert.False(SENT_NOS());
        }

        [Test]
        public void TestToAppResendDoNotSend()
        {
            Logon();
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                 new QuickFix.Fields.ClOrdID("1"),
                 new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                 new QuickFix.Fields.Symbol("IBM"),
                 new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                 new QuickFix.Fields.TransactTime(),
                 new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

            session.Send(order);
            Assert.True(SENT_NOS());

            responder.msgLookup.Remove(QuickFix.Fields.MsgType.NEWORDERSINGLE);
            application.doNotSendException = new QuickFix.DoNotSend();

            SendResendRequest(1, 0);
            Assert.False(SENT_NOS());
        }


        [Test]
        public void TestApplicationExtension()
        {
            var mockApp = new MockApplicationExt();
            session = new QuickFix.Session(true, mockApp, new QuickFix.MemoryStoreFactory(), sessionID,
                new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(config), 0, new QuickFix.NullLogFactory(), new QuickFix.DefaultMessageFactory(), "blah");
            session.SetResponder(responder);
            session.CheckLatency = false;

            Logon();
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                new QuickFix.Fields.ClOrdID("1"),
                new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                new QuickFix.Fields.Symbol("IBM"),
                new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                new QuickFix.Fields.TransactTime(),
                new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

            order.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            order.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(2));

            session.Next(order.ToString());

            Assert.That(mockApp.InterceptedMessageTypes.Count, Is.EqualTo(2));
            Assert.True(mockApp.InterceptedMessageTypes.Contains(QuickFix.Fields.MsgType.LOGON));
            Assert.True(mockApp.InterceptedMessageTypes.Contains(QuickFix.Fields.MsgType.NEWORDERSINGLE));
        }

        [Test]
        public void TestRequireLogon()
        {
            QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
                new QuickFix.Fields.ClOrdID("1"),
                new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
                new QuickFix.Fields.Symbol("IBM"),
                new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
                new QuickFix.Fields.TransactTime(),
                new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));
            // This should cause disconnect, because first message is something other than a logon.
            SendTheMessage(order);
            Assert.That(DISCONNECTED());
        }

        [Test]
        public void TestResendRequestMsgSeqNumNotIgnoredWhenNoPersistance()
        {
            session.PersistMessages = false;

            Logon();

            SendNOSMessage();
            SendNOSMessage();

            //The below will trigger a sequence reset
            SendResendRequest(2, 0);

            SendNOSMessage();
            Assert.That(!SENT_RESEND_REQUEST());
        }
    }
}
