// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class OrderCancelRequest : Message
{
    public const string MsgType = "F";

    public OrderCancelRequest() : base()
    {
        Header.SetField(new MsgType("F"));
    }

    public OrderCancelRequest(
            OrigClOrdID aOrigClOrdID,
            ClOrdID aClOrdID,
            CxlType aCxlType,
            Symbol aSymbol,
            Side aSide,
            OrderQty aOrderQty
        ) : this()
    {
        OrigClOrdID = aOrigClOrdID;
        ClOrdID = aClOrdID;
        CxlType = aCxlType;
        Symbol = aSymbol;
        Side = aSide;
        OrderQty = aOrderQty;
    }

    public OrigClOrdID OrigClOrdID
    {
        get
        {
            OrigClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigClOrdID val) { OrigClOrdID = val; }
    public OrigClOrdID Get(OrigClOrdID val) { GetField(val); return val; }
    public bool IsSet(OrigClOrdID val) { return IsSetOrigClOrdID(); }
    public bool IsSetOrigClOrdID() { return IsSetField(Tags.OrigClOrdID); }

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

    public ClOrdID ClOrdID
    {
        get
        {
            ClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdID val) { ClOrdID = val; }
    public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
    public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
    public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

    public CxlType CxlType
    {
        get
        {
            CxlType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CxlType val) { CxlType = val; }
    public CxlType Get(CxlType val) { GetField(val); return val; }
    public bool IsSet(CxlType val) { return IsSetCxlType(); }
    public bool IsSetCxlType() { return IsSetField(Tags.CxlType); }

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

    public SymbolSfx SymbolSfx
    {
        get
        {
            SymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SymbolSfx val) { SymbolSfx = val; }
    public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
    public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
    public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

    public SecurityID SecurityID
    {
        get
        {
            SecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityID val) { SecurityID = val; }
    public SecurityID Get(SecurityID val) { GetField(val); return val; }
    public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
    public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

    public IDSource IDSource
    {
        get
        {
            IDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IDSource val) { IDSource = val; }
    public IDSource Get(IDSource val) { GetField(val); return val; }
    public bool IsSet(IDSource val) { return IsSetIDSource(); }
    public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

    public Issuer Issuer
    {
        get
        {
            Issuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Issuer val) { Issuer = val; }
    public Issuer Get(Issuer val) { GetField(val); return val; }
    public bool IsSet(Issuer val) { return IsSetIssuer(); }
    public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

    public SecurityDesc SecurityDesc
    {
        get
        {
            SecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityDesc val) { SecurityDesc = val; }
    public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
    public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
    public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

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
