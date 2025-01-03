// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class AllocationACK : Message
{
    public const string MsgType = "P";

    public AllocationACK() : base()
    {
        Header.SetField(new MsgType("P"));
    }

    public AllocationACK(
            AllocID aAllocID,
            TradeDate aTradeDate,
            AllocStatus aAllocStatus
        ) : this()
    {
        AllocID = aAllocID;
        TradeDate = aTradeDate;
        AllocStatus = aAllocStatus;
    }

    public ClientID ClientID
    {
        get
        {
            ClientID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientID val) { ClientID = val; }
    public ClientID Get(ClientID val) { GetField(val); return val; }
    public bool IsSet(ClientID val) { return IsSetClientID(); }
    public bool IsSetClientID() { return IsSetField(Tags.ClientID); }

    public ExecBroker ExecBroker
    {
        get
        {
            ExecBroker val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecBroker val) { ExecBroker = val; }
    public ExecBroker Get(ExecBroker val) { GetField(val); return val; }
    public bool IsSet(ExecBroker val) { return IsSetExecBroker(); }
    public bool IsSetExecBroker() { return IsSetField(Tags.ExecBroker); }

    public AllocID AllocID
    {
        get
        {
            AllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocID val) { AllocID = val; }
    public AllocID Get(AllocID val) { GetField(val); return val; }
    public bool IsSet(AllocID val) { return IsSetAllocID(); }
    public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }

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

    public AllocStatus AllocStatus
    {
        get
        {
            AllocStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocStatus val) { AllocStatus = val; }
    public AllocStatus Get(AllocStatus val) { GetField(val); return val; }
    public bool IsSet(AllocStatus val) { return IsSetAllocStatus(); }
    public bool IsSetAllocStatus() { return IsSetField(Tags.AllocStatus); }

    public AllocRejCode AllocRejCode
    {
        get
        {
            AllocRejCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocRejCode val) { AllocRejCode = val; }
    public AllocRejCode Get(AllocRejCode val) { GetField(val); return val; }
    public bool IsSet(AllocRejCode val) { return IsSetAllocRejCode(); }
    public bool IsSetAllocRejCode() { return IsSetField(Tags.AllocRejCode); }

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
}
