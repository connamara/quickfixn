// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class ConfirmationAck : Message
{
    public const string MsgType = "AU";

    public ConfirmationAck() : base()
    {
        Header.SetField(new MsgType("AU"));
    }

    public ConfirmationAck(
            ConfirmID aConfirmID,
            TradeDate aTradeDate,
            TransactTime aTransactTime,
            AffirmStatus aAffirmStatus
        ) : this()
    {
        ConfirmID = aConfirmID;
        TradeDate = aTradeDate;
        TransactTime = aTransactTime;
        AffirmStatus = aAffirmStatus;
    }

    public ConfirmID ConfirmID
    {
        get
        {
            ConfirmID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConfirmID val) { ConfirmID = val; }
    public ConfirmID Get(ConfirmID val) { GetField(val); return val; }
    public bool IsSet(ConfirmID val) { return IsSetConfirmID(); }
    public bool IsSetConfirmID() { return IsSetField(Tags.ConfirmID); }

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public AffirmStatus AffirmStatus
    {
        get
        {
            AffirmStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AffirmStatus val) { AffirmStatus = val; }
    public AffirmStatus Get(AffirmStatus val) { GetField(val); return val; }
    public bool IsSet(AffirmStatus val) { return IsSetAffirmStatus(); }
    public bool IsSetAffirmStatus() { return IsSetField(Tags.AffirmStatus); }

    public ConfirmRejReason ConfirmRejReason
    {
        get
        {
            ConfirmRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ConfirmRejReason val) { ConfirmRejReason = val; }
    public ConfirmRejReason Get(ConfirmRejReason val) { GetField(val); return val; }
    public bool IsSet(ConfirmRejReason val) { return IsSetConfirmRejReason(); }
    public bool IsSetConfirmRejReason() { return IsSetField(Tags.ConfirmRejReason); }

    public MatchStatus MatchStatus
    {
        get
        {
            MatchStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchStatus val) { MatchStatus = val; }
    public MatchStatus Get(MatchStatus val) { GetField(val); return val; }
    public bool IsSet(MatchStatus val) { return IsSetMatchStatus(); }
    public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
}
