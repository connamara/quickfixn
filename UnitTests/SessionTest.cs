using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Threading;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests;

[TestFixture]
public class SessionTest
{
    private SessionTestSupport.MockResponder _responder = new();

    private QuickFix.SessionID _sessionId = new("unset", "unset", "unset");
    private QuickFix.SessionSettings _settings = new();
    private SessionTestSupport.MockApplication _application = new();
    private QuickFix.Session? _session = null;
    private QuickFix.Session? _session2 = null;
    private QuickFix.SettingsDictionary _config = new();
    private SeqNumType _seqNum = 1;
    private readonly Regex _msRegex = new(@"\.[\d]{1,3}$");
    private readonly Regex _microsecondRegex = new(@"\.[\d]{1,6}$");

    [SetUp]
    public void Setup()
    {
        _responder = new SessionTestSupport.MockResponder();
        _sessionId = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");
        _application = new SessionTestSupport.MockApplication();
        _settings = new QuickFix.SessionSettings();

        _config = new QuickFix.SettingsDictionary();
        _config.SetBool(QuickFix.SessionSettings.PERSIST_MESSAGES, false);
        _config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        _config.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
        _config.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
        _settings.Set(_sessionId, _config);

        var logFactory = new NullLogFactory(); // use QuickFix.ScreenLogFactory(settings) if you need to see output

        // acceptor
        _session = new QuickFix.Session(false, _application, new MemoryStoreFactory(), _sessionId,
            new QuickFix.DataDictionaryProvider(),new QuickFix.SessionSchedule(_config), 0, logFactory, new QuickFix.DefaultMessageFactory(), "blah");
        _session.SetResponder(_responder);
        _session.CheckLatency = false;

        // initiator
        _session2 = new QuickFix.Session(true, _application, new MemoryStoreFactory(), new QuickFix.SessionID("FIX.4.2", "OTHER_SENDER", "OTHER_TARGET"),
            new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(_config), 0, logFactory, new QuickFix.DefaultMessageFactory(), "blah");
        _session2.SetResponder(_responder);
        _session2.CheckLatency = false;

        _seqNum = 1;
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
        msg.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        msg.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));
        msg.Header.SetField(new QuickFix.Fields.SendingTime(DateTime.UtcNow));
        msg.SetField(new QuickFix.Fields.HeartBtInt(1));
        _session!.Next(msg.ConstructString());
    }

    public bool SENT_SEQUENCE_RESET()
    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.SEQUENCE_RESET) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.SEQUENCE_RESET].Count > 0;
    }

    public bool SENT_RESEND_REQUEST()
    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.RESEND_REQUEST) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.RESEND_REQUEST].Count > 0;
    }

    public bool RESENT()
    {
        if (_responder.Dups.Count == 0)
            return false;

        _responder.Dups.Dequeue();
        return true;
    }

    public bool SENT_REJECT()
    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.REJECT].Count>0;
    }

	    public bool SENT_HEART_BEAT()
	    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.HEARTBEAT) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.HEARTBEAT].Count > 0;
	    }

    public bool SENT_BUSINESS_REJECT()
    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.BUSINESS_MESSAGE_REJECT) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.BUSINESS_MESSAGE_REJECT].Count > 0;
    }

    public bool SENT_BUSINESS_REJECT(int reason)
    {
        if (!SENT_BUSINESS_REJECT())
            return false;

        QuickFix.Message msg = _responder.MsgLookup[QuickFix.Fields.MsgType.BUSINESS_MESSAGE_REJECT].First();

        if (!msg.IsSetField(QuickFix.Fields.Tags.BusinessRejectReason))
            return false;

        QuickFix.Fields.BusinessRejectReason reasonField = new QuickFix.Fields.BusinessRejectReason();
        msg.GetField(reasonField);
        return reasonField.Value == reason;
    }

    public bool SENT_LOGOUT()
    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.LOGOUT) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.LOGOUT].Count > 0;
    }

    public bool SENT_NOS()
    {
        return _responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.NEWORDERSINGLE) &&
            _responder.MsgLookup[QuickFix.Fields.MsgType.NEWORDERSINGLE].Count > 0;
    }

    public bool DISCONNECTED()
    {
        return _responder.Disconnected;
    }

    public bool SENT_REJECT(int reason, int refTag)
    {
        if (!SENT_REJECT())
            return false;

        QuickFix.Message msg = _responder.MsgLookup[QuickFix.Fields.MsgType.REJECT].First();

        if (!msg.IsSetField(QuickFix.Fields.Tags.SessionRejectReason))
            return false;

        QuickFix.Fields.SessionRejectReason reasonField = new QuickFix.Fields.SessionRejectReason();
        msg.GetField(reasonField);
        if(reasonField.Value != reason)
            return false;

        if (!msg.IsSetField(QuickFix.Fields.Tags.RefTagID))
            return false;

        QuickFix.Fields.RefTagID refTagField = new QuickFix.Fields.RefTagID();
        msg.GetField(refTagField);
        return refTagField.Value == refTag;
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

        order.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        order.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));

        _session!.Next(order.ConstructString());
    }

    public void SendResendRequest(SeqNumType begin, SeqNumType end)
    {
        SendTheMessage(new QuickFix.FIX42.ResendRequest(
            new QuickFix.Fields.BeginSeqNo(begin),
            new QuickFix.Fields.EndSeqNo(end)));
    }

    public void SendResendRequest40(SeqNumType begin, SeqNumType end)
    {
        SendTheMessage(new QuickFix.FIX40.ResendRequest(
            new QuickFix.Fields.BeginSeqNo(begin),
            new QuickFix.Fields.EndSeqNo(end)));
    }

    private void SendTheMessage(QuickFix.Message msg)
    {
        msg.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        msg.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));

        _session!.Next(msg.ConstructString());
    }

    [Test]
    public void ConditionalTagMissingReject()
    {
        _application.FromAppException = new QuickFix.FieldNotFoundException(61);

        Logon();
        SendNOSMessage();

        Assert.That(SENT_BUSINESS_REJECT(QuickFix.Fields.BusinessRejectReason.CONDITIONALLY_REQUIRED_FIELD_MISSING));
    }

    [Test]
    public void IncorrectTagValueReject()
    {
        _application.FromAppException = new QuickFix.IncorrectTagValue(54);

        Logon();
        SendNOSMessage();
        Assert.That(SENT_REJECT(QuickFix.Fields.SessionRejectReason.VALUE_IS_INCORRECT,54));

    }

    [Test]
    public void UnsupportedMessageReject()
    {
        _application.FromAppException = new QuickFix.UnsupportedMessageType();

        Logon();
        SendNOSMessage();
        Assert.That(SENT_BUSINESS_REJECT());
    }

    [Test]
    public void LogonReject()
    {
        _application.FromAdminException  = new QuickFix.RejectLogon("Failed Logon");
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
        _session!.PersistMessages = false;

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

        order.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.TargetCompID));
        order.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.SenderCompID));

        SeqNumType[] gapStarts = new[] { 1UL, 5UL, 11UL }; // 1st gap  from seq num 1 to 2 is just the Logon message
        SeqNumType[] gapEnds = new[] { 2UL, 8UL, 15UL };
        int orderCount = 0;

        for (SeqNumType msgSeqNum = gapEnds[0]; msgSeqNum < gapStarts[1]; ++msgSeqNum)
        {
            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(msgSeqNum));
            _session!.Send(order);
            ++orderCount;
        } //seq 4, next is 5

        for (SeqNumType msgSeqNum = gapStarts[1]; msgSeqNum < gapEnds[1]; ++msgSeqNum)
        {
            _session!.GenerateHeartbeat();
        } //seq 7, next is 8

        for (SeqNumType msgSeqNum = gapEnds[1]; msgSeqNum < gapStarts[2]; ++msgSeqNum)
        {
            order.Header.SetField(new QuickFix.Fields.MsgSeqNum(msgSeqNum));
            _session!.Send(order);
            ++orderCount;
        } //seq 10, next is 11

        for (SeqNumType msgSeqNum = gapStarts[2]; msgSeqNum < gapEnds[2]; ++msgSeqNum)
        {
            _session!.GenerateHeartbeat();
        } // seq 11 - 14

        _responder.MsgLookup.Clear();
        SendResendRequest(1, 100);

        Assert.AreEqual(_responder.GetCount(QuickFix.Fields.MsgType.NEWORDERSINGLE), orderCount);
        Assert.AreEqual(_responder.GetCount(QuickFix.Fields.MsgType.SEQUENCE_RESET), gapStarts.Length);

        int count = -1;
        foreach (QuickFix.Message sequenceResestMsg in _responder.MsgLookup[QuickFix.Fields.MsgType.SEQUENCE_RESET])
        {
            Assert.AreEqual(sequenceResestMsg.GetString(QuickFix.Fields.Tags.GapFillFlag), "Y");
            Assert.AreEqual(sequenceResestMsg.Header.GetULong(QuickFix.Fields.Tags.MsgSeqNum), gapStarts[++count]);
            Assert.AreEqual(sequenceResestMsg.GetInt(QuickFix.Fields.Tags.NewSeqNo), gapEnds[count]);
        }
    }

    [Test]
    public void TestResendSessionLevelReject()
    {
        Assert.False(_session!.ResendSessionLevelRejects); // check for correct default
        Logon();

        QuickFix.FIX42.Reject reject = new QuickFix.FIX42.Reject(
            new QuickFix.Fields.RefSeqNum(10));

        reject.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.TargetCompID));
        reject.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.SenderCompID));
        _session.Send(reject);

        _responder.MsgLookup.Clear();
        _session.ResendSessionLevelRejects = true;
        SendResendRequest(1, 100);
        Assert.That(_responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT));

        _responder.MsgLookup.Clear();
        _session.ResendSessionLevelRejects = false;
        SendResendRequest(1, 100);
        Assert.False(_responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT));
    }

    public void AssertMsInTag(string msgType, int tag, bool shouldHaveMs)
    {
        QuickFix.Message msg = _responder.MsgLookup[msgType].Last();
        string sendingTime = msg.Header.GetString(tag);
        Match m = _msRegex.Match(sendingTime);
        Assert.That(m.Success == shouldHaveMs);
    }

    public void AssertMicrosecondsInTag(string msgType, int tag, bool shouldHaveMicrosecond)
    {
        QuickFix.Message msg = _responder.MsgLookup[msgType].Last();
        string sendingTime = msg.Header.GetString(tag);
        Match m = _microsecondRegex.Match(sendingTime);
        Assert.That(m.Success == shouldHaveMicrosecond);
    }

    [Test]
    public void TestMillisecondsInSendingTimeStamp()
    {
        // MS in timestamp should default to Y
        Assert.That(_session!.TimeStampPrecision == QuickFix.Fields.Converters.TimeStampPrecision.Millisecond );

        // Ms should show up
        Logon();
        AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);

        // No ms
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Second;
        Logon();
        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.LOGON].Count == 2);
        AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);

        // Less than FIX42 - no ms in timestamp, even if you tell it to
        _sessionId = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
        _session.SessionID = _sessionId;
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Millisecond;
        Logon40();
        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.LOGON].Count == 3);
        AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);
    }

    [Test]
    public void TestMicrosecondsInSendingTimeStamp()
    {
        // Microseconds in timestamp
        _session!.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;

        // Microseconds should show up
        Logon();
        AssertMicrosecondsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);

        // Milliseconds in timestamp
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Millisecond;
        Logon();
        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.LOGON].Count == 2);
        AssertMsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, true);

        // Less than FIX42 - no microseconds in timestamp, even if you tell it to
        _sessionId = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
        _session.SessionID = _sessionId;
        _session.TimeStampPrecision =  QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;
        Logon40();
        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.LOGON].Count == 3);
        AssertMicrosecondsInTag(QuickFix.Fields.MsgType.LOGON, QuickFix.Fields.Tags.SendingTime, false);
    }

    [Test]
    public void TestMillisecondsInOrigSendingTimeStamp()
    {
        // MS in timestamp should default
        Assert.That(_session!.TimeStampPrecision == QuickFix.Fields.Converters.TimeStampPrecision.Millisecond);

        // Logon first
        Logon();

        // Do a resend request
        SendResendRequest(0, 2);
        AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, true);

        // NO MS
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Second;
        SendResendRequest(0, 2);
        AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);

        // Less than FIX42 - no ms in timestamp, even if you tell it to
        _sessionId = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
        _session.SessionID = _sessionId;
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Millisecond;
        SendResendRequest40(0, 2);
        AssertMsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);
    }

    [Test]
    public void TestMicrosecondsInOrigSendingTimeStamp()
    {
        // Microsecond in timestamp
        _session!.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;

        // Logon first
        Logon();

        // Do a resend request
        SendResendRequest(0, 2);
        AssertMicrosecondsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, true);

        // NO MS
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Second;
        SendResendRequest(0, 2);
        AssertMicrosecondsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);

        // Less than FIX42 - no ms in timestamp, even if you tell it to
        _sessionId = new QuickFix.SessionID(QuickFix.FixValues.BeginString.FIX40, "SENDER", "TARGET");
        _session.SessionID = _sessionId;
        _session.TimeStampPrecision = QuickFix.Fields.Converters.TimeStampPrecision.Microsecond;
        SendResendRequest40(0, 2);
        AssertMicrosecondsInTag(QuickFix.Fields.MsgType.SEQUENCERESET, QuickFix.Fields.Tags.OrigSendingTime, false);
    }

    [Test]
    public void TestLastMsgSeqNumProcessed()
    {
        // Disabled by default
        Assert.That(_session!.EnableLastMsgSeqNumProcessed, Is.False);

        _session.EnableLastMsgSeqNumProcessed = true;

        // Logon
        Logon();
        QuickFix.Message msg = _responder.MsgLookup[QuickFix.Fields.MsgType.LOGON].Last();
        SeqNumType lastSeqNumProcessed = msg.Header.GetULong(QuickFix.Fields.Tags.LastMsgSeqNumProcessed);
        Assert.That(lastSeqNumProcessed == 1);

        // NOS
        QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
            new QuickFix.Fields.ClOrdID("1"),
            new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
            new QuickFix.Fields.Symbol("IBM"),
            new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
            new QuickFix.Fields.TransactTime(),
            new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

        order.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        order.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));
        _session.Send(order);

        msg = _responder.MsgLookup[QuickFix.Fields.MsgType.NEW_ORDER_D].Last();
        lastSeqNumProcessed = msg.Header.GetULong(QuickFix.Fields.Tags.LastMsgSeqNumProcessed);
        Assert.That(lastSeqNumProcessed == 1);
    }

    [Test]
    public void TestMaxMessagesInResendRequest()
    {
        // Default
        Assert.That(_session!.MaxMessagesInResendRequest, Is.EqualTo(0));

        _session.MaxMessagesInResendRequest = 2500;
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

        order.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        order.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(5005));
        // This will generate resend requests
        _session.Verify(order, true, false);

        // 3 resend requests
        //  2->2501
        //  2502->5001
        //  5002->5005

        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 1);
        QuickFix.Message msg = _responder.MsgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
        Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(2));
        Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(2501));

        // Jump forward to the end of the resend chunk with a fillgap reset message
        QuickFix.FIX42.SequenceReset reset = new QuickFix.FIX42.SequenceReset();
        reset.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        reset.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        reset.SetField(new QuickFix.Fields.GapFillFlag(true));

        reset.Header.SetField(new QuickFix.Fields.MsgSeqNum(2));
        reset.SetField(new QuickFix.Fields.NewSeqNo(2501));
        _session.Next(reset.ConstructString());

        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(2501));
        _session.Next(order.ConstructString());

        // Should have triggered next resend (2502->5001), check this
        //Console.WriteLine(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count);
        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 1);
        msg = _responder.MsgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
        Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(2502));
        Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(5001));

        // Jump forward to the end of the resend chunk with a fillgap reset message
        reset.Header.SetField(new QuickFix.Fields.MsgSeqNum(2502));
        reset.SetField(new QuickFix.Fields.NewSeqNo(5001));
        _session.Next(reset.ConstructString());

        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(5001));
        _session.Next(order.ConstructString());   // Triggers next resend (5002->5005)

        //Console.WriteLine(responder.msgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count);
        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Count == 1);
        msg = _responder.MsgLookup[QuickFix.Fields.MsgType.RESENDREQUEST].Dequeue();
        Assert.That(msg.GetInt(QuickFix.Fields.Tags.BeginSeqNo), Is.EqualTo(5002));
        Assert.That(msg.GetInt(QuickFix.Fields.Tags.EndSeqNo), Is.EqualTo(5004));
    }

    [Test]
    public void TestIgnorePossDupInResendRequest()
    {
        // Default is false
        Assert.That(_session!.IgnorePossDupResendRequests, Is.EqualTo(false));

        _session.IgnorePossDupResendRequests = true;
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

        order.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        order.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));
        // This will generate resend requests
        _session.Send(order);

        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.NEWORDERSINGLE].Count == 1);

        QuickFix.Message msg = new QuickFix.FIX42.ResendRequest(
            new QuickFix.Fields.BeginSeqNo(1),
            new QuickFix.Fields.EndSeqNo(0));
        msg.Header.SetField(new QuickFix.Fields.PossDupFlag(true));
        SendTheMessage(msg);

        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.NEWORDERSINGLE].Count == 1);
    }

    [Test]
    public void TestDoesSessionExist()
    {
        QuickFix.SessionID invalidSessionId = new QuickFix.SessionID("FIX.4.2", "NOT_SENDER", "NOT_TARGET");
        QuickFix.SessionID validSessionId = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");

        Assert.That(QuickFix.Session.DoesSessionExist(invalidSessionId), Is.EqualTo(false));
        Assert.That(QuickFix.Session.DoesSessionExist(validSessionId), Is.EqualTo(true));
    }

    [Test]
    public void TestSettingNextTargetMsgSeqNum()
    {
        _session!.NextTargetMsgSeqNum = 100;
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(100));
    }

    [Test]
    public void TestSettingNextSenderMsgSeqNum()
    {
        _session!.NextSenderMsgSeqNum = 200;
        Assert.That(_session.NextSenderMsgSeqNum, Is.EqualTo(200));
    }

    [Test]
    public void TestGettingIsInitiator()
    {
        Assert.That(_session2!.IsInitiator, Is.EqualTo(true));
    }

    [Test]
    public void TestGettingIsAcceptor()
    {
        Assert.That(_session2!.IsAcceptor, Is.EqualTo(false));
    }

    [Test]
    public void TestMessageStoreAccessor()
    {
        List<string> messages = new List<string>();

        messages.Clear();
        _session!.MessageStore.Get(0, 100, messages);
        Assert.That(messages.Count, Is.EqualTo(0));

        Logon();

        messages.Clear();
        _session.MessageStore.Get(0, 100, messages);
        Assert.That(messages.Count, Is.EqualTo(1)); // logon response
    }

    [Test]
    public void TestRequiresOrigSendingTime_Y()
    {
        // Under default configuration, session should reject a ResendRequest that lacks OrigSendingTime unset

        // Check default is as expected
        Assert.That(_session!.RequiresOrigSendingTime, Is.EqualTo(true));

        Logon();

        QuickFix.FIX42.SequenceReset sr = new(new QuickFix.Fields.NewSeqNo(5));
        sr.GapFillFlag = new QuickFix.Fields.GapFillFlag(true);
        sr.Header.SetField(new QuickFix.Fields.PossDupFlag(true));

        sr.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum--)); // so it triggers DoTargetTooLow code

        SendTheMessage(sr);

        Assert.That(_responder.MsgLookup[QuickFix.Fields.MsgType.REJECT].Count == 1);
        QuickFix.FIX42.Reject rej =
            (_responder.MsgLookup[QuickFix.Fields.MsgType.REJECT].Peek() as QuickFix.FIX42.Reject)!;
        Assert.That(rej.SessionRejectReason.Value, Is.EqualTo(QuickFix.Fields.SessionRejectReason.REQUIRED_TAG_MISSING));
    }

    [Test]
    public void TestRequiresOrigSendingTime_N()
    {
        // Under OrigSendingTime=N, session will allow ResendRequest that lacks OrigSendingTime
        _session!.RequiresOrigSendingTime = false;

        Logon();

        QuickFix.FIX42.SequenceReset sr = new(new QuickFix.Fields.NewSeqNo(5));
        sr.GapFillFlag = new QuickFix.Fields.GapFillFlag(true);
        sr.Header.SetField(new QuickFix.Fields.PossDupFlag(true));

        sr.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum--)); // so it triggers DoTargetTooLow code

        SendTheMessage(sr);

        Assert.False(_responder.MsgLookup.ContainsKey(QuickFix.Fields.MsgType.REJECT));
    }
    [Test]
    public void TestToAppDoNotSend()
    {
        Logon();
        QuickFix.FIX42.NewOrderSingle order = new(
             new QuickFix.Fields.ClOrdID("1"),
             new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
             new QuickFix.Fields.Symbol("IBM"),
             new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
             new QuickFix.Fields.TransactTime(),
             new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

        _application.DoNotSendException = new QuickFix.DoNotSend();
        _session!.Send(order);
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

        _session!.Send(order);
        Assert.True(SENT_NOS());

        _responder.MsgLookup.Remove(QuickFix.Fields.MsgType.NEWORDERSINGLE);
        _application.DoNotSendException = new QuickFix.DoNotSend();

        SendResendRequest(1, 0);
        Assert.False(SENT_NOS());
    }


    [Test]
    public void TestApplicationExtension()
    {
        var mockApp = new SessionTestSupport.MockApplicationExt();
        _session = new QuickFix.Session(true, mockApp, new MemoryStoreFactory(), _sessionId,
            new QuickFix.DataDictionaryProvider(), new QuickFix.SessionSchedule(_config), 0, new NullLogFactory(), new QuickFix.DefaultMessageFactory(), "blah");
        _session.SetResponder(_responder);
        _session.CheckLatency = false;

        Logon();
        QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(
            new QuickFix.Fields.ClOrdID("1"),
            new QuickFix.Fields.HandlInst(QuickFix.Fields.HandlInst.MANUAL_ORDER),
            new QuickFix.Fields.Symbol("IBM"),
            new QuickFix.Fields.Side(QuickFix.Fields.Side.BUY),
            new QuickFix.Fields.TransactTime(),
            new QuickFix.Fields.OrdType(QuickFix.Fields.OrdType.LIMIT));

        order.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        order.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(2));

        _session.Next(order.ConstructString());

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
        _session!.PersistMessages = false;

        Logon();

        SendNOSMessage();
        SendNOSMessage();

        //The below will trigger a sequence reset
        SendResendRequest(2, 0);

        SendNOSMessage();
        Assert.That(!SENT_RESEND_REQUEST());
    }
}

