using NUnit.Framework;
using QuickFix.Fields;
using QuickFix.FIX42;
using System.Text.RegularExpressions;
using UnitTests.SessionTestSupport;

namespace UnitTests
{

  [TestFixture]
  public class InitiatorSessionResendMessagesTest
  {
    private MockResponder _responder = new();

    private QuickFix.SessionID _sessionID = new("unset", "unset", "unset");
    private QuickFix.SessionSettings _settings = new();
    private MockApplication _application = new();
    private QuickFix.Session? _session = null;
    private QuickFix.SettingsDictionary _config = new();
    private SeqNumType _seqNum = 1;

    [SetUp]
    public void Setup()
    {
      _responder = new MockResponder();
      _sessionID = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");
      _application = new MockApplication();
      _settings = new QuickFix.SessionSettings();

      _config = new QuickFix.SettingsDictionary();
      _config.SetBool(QuickFix.SessionSettings.PERSIST_MESSAGES, false);
      _config.SetBool(QuickFix.SessionSettings.RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME, false);
      _config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
      _config.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
      _config.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
      _settings.Set(_sessionID, _config);

      // initiator
      _session = new QuickFix.Session(true, _application, new QuickFix.Store.MemoryStoreFactory(), _sessionID,
          new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(_config), 0, new QuickFix.Logger.ScreenLogFactory(_settings), new QuickFix.DefaultMessageFactory(), "blah");
      _session.SetResponder(_responder);
      _session.CheckLatency = false;

      _seqNum = 1;
    }

    public void Logon()
    {
      SendLogon(new QuickFix.FIX42.Logon());
    }

    private void SendLogon(QuickFix.Message msg)
    {
      msg.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionID.SenderCompID));
      msg.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionID.TargetCompID));
      msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));
      msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
      msg.SetField(new QuickFix.Fields.HeartBtInt(1));
      _session!.Next(msg.ConstructString());
    }


    public bool RESENT()
    {
      if (_responder.Dups.Count == 0)
        return false;

      _responder.Dups.Dequeue();
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
      SendTheMessage(msg, _seqNum++);
    }

    private void SendTheMessage(QuickFix.Message msg, SeqNumType msgSeqNum, bool possDupFlag = false)
    {
      msg.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionID.SenderCompID));
      msg.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionID.TargetCompID));
      msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(msgSeqNum));
      msg.Header.SetField(new QuickFix.Fields.PossDupFlag(possDupFlag));
      _session.Next(msg.ConstructString());
    }

    [Test]
    public void TestSequenceResetNoGapFillIsProcessed()
    {
      // Default is false
      Assert.That(_session.IgnorePossDupResendRequests, Is.EqualTo(false));

      _session.Next();// causes Logon send
      // Logon 
      Logon();

      // quote
      var quote = new QuickFix.FIX42.Quote();
      
      SendTheMessage(quote);
      SendTheMessage(quote);
      SendTheMessage(quote);

      var seqReset = new SequenceReset(new NewSeqNo(_seqNum + 10));

      SendTheMessage(seqReset);


      Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(_seqNum + 9));
    }

    [Test]
    public void TestSequenceResetWithGapFillIsProcessed()
    {
      // Default is false
      Assert.That(_session.IgnorePossDupResendRequests, Is.EqualTo(false));

      _session.Next();// causes Logon send
      // Logon 
      Logon();

      // quote
      var quote = new QuickFix.FIX42.Quote();


      SendTheMessage(quote);
      SendTheMessage(quote);
      SendTheMessage(quote);

      var seqReset = new SequenceReset(new NewSeqNo(_seqNum + 10));
      seqReset.GapFillFlag = new GapFillFlag(true);

      SendTheMessage(seqReset);

      Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(_seqNum + 9));
    }

    [Test]
    public void TestSequenceResetDuringResendRequestIsProcessed()
    {
      // Default is false
      Assert.That(_session.IgnorePossDupResendRequests, Is.EqualTo(false));
      _session.RequiresOrigSendingTime = false;
      _session.Next(); // causes Logon send
      // Logon 
      Logon();

      // quote
      var quote = new QuickFix.FIX42.Quote();


      SendTheMessage(quote, 2);
      SendTheMessage(quote, 3);
      SendTheMessage(quote, 10); // causes ResendRequest

      Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(4));

      SendTheMessage(quote, 4);
      SendTheMessage(quote, 5);

      var seqReset = new SequenceReset(new NewSeqNo(9)); // already been sent 10 so will process it

      SendTheMessage(seqReset, 6);
      SendTheMessage(quote, 9);

      Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(11));
    }

    [Test]
    public void TestSequenceResetWithGapFillAndPossDupFlagTrueDuringResendRequestIsProcessed()
    {
      // Default is false
      Assert.That(_session.IgnorePossDupResendRequests, Is.EqualTo(false));
      _session.RequiresOrigSendingTime = false;
      _session.Next(); // causes Logon send
      // Logon 
      Logon();

      // quote
      var quote = new QuickFix.FIX42.Quote();

      SendTheMessage(quote, 2);
      SendTheMessage(quote, 3);
      SendTheMessage(quote, 4);

      _seqNum = 10;
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

      Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(12));

      Assert.That(_responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.RESEND_REQUEST) && _responder.MsgLookup[QuickFix.Fields.MsgType.RESEND_REQUEST].Count == 1);
    }
  }
}