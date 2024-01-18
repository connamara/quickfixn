using NUnit.Framework;
using QuickFix.Fields;
using QuickFix.FIX42;
using System.Text.RegularExpressions;

namespace UnitTests
{

    [TestFixture]
    public class InitiatorSessionResendMessagesTest
    {
        MockResponder responder = null;

        QuickFix.SessionID sessionID = null;
        QuickFix.SessionSettings settings = null;
        MockApplication application = null;
        QuickFix.Session session = null;
        QuickFix.Dictionary config = null;
        SeqNumType seqNum = 1;
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
            config.SetBool(QuickFix.SessionSettings.RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME, false);
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
            config.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
            settings.Set(sessionID, config);

            // initiator
            session = new QuickFix.Session(true, application, new QuickFix.MemoryStoreFactory(), sessionID,
                new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(config), 0, new QuickFix.ScreenLogFactory(settings), new QuickFix.DefaultMessageFactory(), "blah");
            session.SetResponder(responder);
            session.CheckLatency = false;

            seqNum = 1;
        }

        public void Logon()
        {
            SendLogon(new QuickFix.FIX42.Logon());
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

      
        public bool RESENT()
        {
            if (responder.dups.Count == 0)
                return false;

            responder.dups.Dequeue();
            return true;
        }


        public void SendResendRequest(SeqNumType begin, SeqNumType end)
        {
            SendTheMessage(new QuickFix.FIX42.ResendRequest(
                new QuickFix.Fields.BeginSeqNo(begin),
                new QuickFix.Fields.EndSeqNo(end)));
        }

        private void SendTheMessage(QuickFix.Message msg)
        {
            SendTheMessage(msg, seqNum++);
        }

        private void SendTheMessage(QuickFix.Message msg, SeqNumType msgSeqNum, bool possDupFlag=false)
        {
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(sessionID.SenderCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(sessionID.TargetCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(msgSeqNum));
            msg.Header.SetField(new QuickFix.Fields.PossDupFlag(possDupFlag));
            session.Next(msg.ToString());
        }
 
        [Test]
        public void TestSequenceResetNoGapFillIsProcessed()
        {
            // Default is false
            Assert.That(session.IgnorePossDupResendRequests, Is.EqualTo(false));
            
            session.Next();// causes Logon send
            // Logon 
            Logon();

            // quote
            var quote = new QuickFix.FIX42.Quote();

            
            SendTheMessage(quote);
            SendTheMessage(quote);
            SendTheMessage(quote);
            
            var seqReset = new SequenceReset( new NewSeqNo(seqNum + 10) );

            SendTheMessage(seqReset);


            Assert.That(session.NextTargetMsgSeqNum, Is.EqualTo(seqNum +9 ));
        }

        [Test]
        public void TestSequenceResetWithGapFillIsProcessed()
        {
            // Default is false
            Assert.That(session.IgnorePossDupResendRequests, Is.EqualTo(false));
            
            session.Next();// causes Logon send
            // Logon 
            Logon();

            // quote
            var quote = new QuickFix.FIX42.Quote();


            SendTheMessage(quote);
            SendTheMessage(quote);
            SendTheMessage(quote);

            var seqReset = new SequenceReset(new NewSeqNo(seqNum + 10));
            seqReset.GapFillFlag = new GapFillFlag(true);

            SendTheMessage(seqReset);

            Assert.That(session.NextTargetMsgSeqNum, Is.EqualTo(seqNum + 9));
        }

        [Test]
        public void TestSequenceResetDuringResendRequestIsProcessed()
        {
            // Default is false
            Assert.That(session.IgnorePossDupResendRequests, Is.EqualTo(false));
            session.RequiresOrigSendingTime = false;
            session.Next(); // causes Logon send
            // Logon 
            Logon();

            // quote
            var quote = new QuickFix.FIX42.Quote();


            SendTheMessage(quote, 2);
            SendTheMessage(quote, 3);
            SendTheMessage(quote, 10); // causes ResendRequest

            Assert.That(session.NextTargetMsgSeqNum, Is.EqualTo(4));

            SendTheMessage(quote, 4);
            SendTheMessage(quote, 5);

            var seqReset = new SequenceReset(new NewSeqNo(9)); // already been sent 10 so will process it

            SendTheMessage(seqReset, 6);
            SendTheMessage(quote, 9);

            Assert.That(session.NextTargetMsgSeqNum, Is.EqualTo(11));
        }

        [Test]
        public void TestSequenceResetWithGapFillAndPossDupFlagTrueDuringResendRequestIsProcessed()
        {
            // Default is false
            Assert.That(session.IgnorePossDupResendRequests, Is.EqualTo(false));
            session.RequiresOrigSendingTime = false;
            session.Next(); // causes Logon send
            // Logon 
            Logon();

            // quote
            var quote = new QuickFix.FIX42.Quote();

            SendTheMessage(quote, 2);
            SendTheMessage(quote, 3);
            SendTheMessage(quote, 4);

            seqNum = 10;
            // without changes the arrowed comments scenario happens
            Logon(); // <--- Will cause resend from 5 and is queued (all cases)

            SendTheMessage(quote, 5, true);
            SendTheMessage(quote, 6, true);
            SendTheMessage(quote, 7, true);
            SendTheMessage(quote, 8, true);
            SendTheMessage(quote, 9, true); // <--will cause logon message queued above to be replayed AND advance msgSeqNum to 11! (all cases)
            var seqReset = new SequenceReset(new NewSeqNo(12));
            seqReset.GapFillFlag = new GapFillFlag(true);
            SendTheMessage(seqReset, 10, true); // <-- Without change this message will be ignored as too low but poss dup is Y so will NOT throw - in the changed version this WILL be honored

            Assert.That(session.NextTargetMsgSeqNum, Is.EqualTo(12));

            Assert.That(responder.msgLookup.ContainsKey(QuickFix.Fields.MsgType.RESEND_REQUEST) && responder.msgLookup[QuickFix.Fields.MsgType.RESEND_REQUEST].Count == 1);
        }
    }
}
