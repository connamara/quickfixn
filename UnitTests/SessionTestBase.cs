using System;
using System.Linq;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests;

public abstract class SessionTestBase
{
    protected SessionTestSupport.MockResponder _responder = new();

    protected QuickFix.SessionID _sessionId = new("unset", "unset", "unset");
    protected SessionTestSupport.MockApplication _application = new();
    protected QuickFix.Session? _session = null;
    protected QuickFix.Session? _session2 = null;
    protected QuickFix.SettingsDictionary _config = new();
    protected SeqNumType _seqNum = 1;

    public void BaseSetup()
    {
        _responder = new SessionTestSupport.MockResponder();
        _sessionId = new QuickFix.SessionID("FIX.4.2", "SENDER", "TARGET");
        _application = new SessionTestSupport.MockApplication();
        QuickFix.SessionSettings _settings = new QuickFix.SessionSettings();

        _config = new QuickFix.SettingsDictionary();
        _config.SetBool(QuickFix.SessionSettings.PERSIST_MESSAGES, false);
        _config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        _config.SetString(QuickFix.SessionSettings.START_TIME, "00:00:00");
        _config.SetString(QuickFix.SessionSettings.END_TIME, "00:00:00");
        _settings.Set(_sessionId, _config);

        var logFactory = new LogFactoryAdapter(new NullLogFactory());

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

    protected void SendLogon(QuickFix.Message msg, SeqNumType n = 0UL)
    {
        msg.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        msg.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(n == 0 ? _seqNum++ : n));
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

    public QuickFix.FIX42.NewOrderSingle CreateNOSMessage(SeqNumType n)
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
        order.Header.SetField(new QuickFix.Fields.SendingTime(DateTime.UtcNow));
        order.Header.SetField(new QuickFix.Fields.MsgSeqNum(n));
        return order;
    }

    public void SendNOSMessage()
    {
        _session!.Next(CreateNOSMessage(_seqNum++).ConstructString());
    }

    public void SendNOSMessage(SeqNumType n)
    {
        _session!.Next(CreateNOSMessage(n).ConstructString());
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

    protected void SendTheMessage(QuickFix.Message msg, SeqNumType n = 0)
    {
        msg.Header.SetField(new QuickFix.Fields.TargetCompID(_sessionId.SenderCompID));
        msg.Header.SetField(new QuickFix.Fields.SenderCompID(_sessionId.TargetCompID));
        msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(n == 0 ? _seqNum++ : n));

        _session!.Next(msg.ConstructString());
    }
}
