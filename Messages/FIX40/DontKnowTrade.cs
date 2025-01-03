// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class DontKnowTrade : Message
{
    public const string MsgType = "Q";

    public DontKnowTrade() : base()
    {
        Header.SetField(new MsgType("Q"));
    }

    public DontKnowTrade(
            DKReason aDKReason,
            Symbol aSymbol,
            Side aSide,
            OrderQty aOrderQty,
            LastShares aLastShares,
            LastPx aLastPx
        ) : this()
    {
        DKReason = aDKReason;
        Symbol = aSymbol;
        Side = aSide;
        OrderQty = aOrderQty;
        LastShares = aLastShares;
        LastPx = aLastPx;
    }

    public OrderID OrderID
    {
        get
        {
            OrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderID val) { OrderID = val; }
    public OrderID Get(OrderID val) { GetField(val); return val; }
    public bool IsSet(OrderID val) { return IsSetOrderID(); }
    public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

    public ExecID ExecID
    {
        get
        {
            ExecID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecID val) { ExecID = val; }
    public ExecID Get(ExecID val) { GetField(val); return val; }
    public bool IsSet(ExecID val) { return IsSetExecID(); }
    public bool IsSetExecID() { return IsSetField(Tags.ExecID); }

    public DKReason DKReason
    {
        get
        {
            DKReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DKReason val) { DKReason = val; }
    public DKReason Get(DKReason val) { GetField(val); return val; }
    public bool IsSet(DKReason val) { return IsSetDKReason(); }
    public bool IsSetDKReason() { return IsSetField(Tags.DKReason); }

    public Symbol Symbol
    {
        get
        {
            Symbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Symbol val) { Symbol = val; }
    public Symbol Get(Symbol val) { GetField(val); return val; }
    public bool IsSet(Symbol val) { return IsSetSymbol(); }
    public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

    public Side Side
    {
        get
        {
            Side val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Side val) { Side = val; }
    public Side Get(Side val) { GetField(val); return val; }
    public bool IsSet(Side val) { return IsSetSide(); }
    public bool IsSetSide() { return IsSetField(Tags.Side); }

    public OrderQty OrderQty
    {
        get
        {
            OrderQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderQty val) { OrderQty = val; }
    public OrderQty Get(OrderQty val) { GetField(val); return val; }
    public bool IsSet(OrderQty val) { return IsSetOrderQty(); }
    public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

    public LastShares LastShares
    {
        get
        {
            LastShares val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastShares val) { LastShares = val; }
    public LastShares Get(LastShares val) { GetField(val); return val; }
    public bool IsSet(LastShares val) { return IsSetLastShares(); }
    public bool IsSetLastShares() { return IsSetField(Tags.LastShares); }

    public LastPx LastPx
    {
        get
        {
            LastPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastPx val) { LastPx = val; }
    public LastPx Get(LastPx val) { GetField(val); return val; }
    public bool IsSet(LastPx val) { return IsSetLastPx(); }
    public bool IsSetLastPx() { return IsSetField(Tags.LastPx); }

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
