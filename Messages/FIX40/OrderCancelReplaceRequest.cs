// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class OrderCancelReplaceRequest : Message
{
    public const string MsgType = "G";

    public OrderCancelReplaceRequest() : base()
    {
        Header.SetField(new MsgType("G"));
    }

    public OrderCancelReplaceRequest(
            OrigClOrdID aOrigClOrdID,
            ClOrdID aClOrdID,
            HandlInst aHandlInst,
            Symbol aSymbol,
            Side aSide,
            OrderQty aOrderQty,
            OrdType aOrdType
        ) : this()
    {
        OrigClOrdID = aOrigClOrdID;
        ClOrdID = aClOrdID;
        HandlInst = aHandlInst;
        Symbol = aSymbol;
        Side = aSide;
        OrderQty = aOrderQty;
        OrdType = aOrdType;
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

    public Account Account
    {
        get
        {
            Account val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account val) { Account = val; }
    public Account Get(Account val) { GetField(val); return val; }
    public bool IsSet(Account val) { return IsSetAccount(); }
    public bool IsSetAccount() { return IsSetField(Tags.Account); }

    public SettlmntTyp SettlmntTyp
    {
        get
        {
            SettlmntTyp val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlmntTyp val) { SettlmntTyp = val; }
    public SettlmntTyp Get(SettlmntTyp val) { GetField(val); return val; }
    public bool IsSet(SettlmntTyp val) { return IsSetSettlmntTyp(); }
    public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

    public FutSettDate FutSettDate
    {
        get
        {
            FutSettDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FutSettDate val) { FutSettDate = val; }
    public FutSettDate Get(FutSettDate val) { GetField(val); return val; }
    public bool IsSet(FutSettDate val) { return IsSetFutSettDate(); }
    public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

    public HandlInst HandlInst
    {
        get
        {
            HandlInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HandlInst val) { HandlInst = val; }
    public HandlInst Get(HandlInst val) { GetField(val); return val; }
    public bool IsSet(HandlInst val) { return IsSetHandlInst(); }
    public bool IsSetHandlInst() { return IsSetField(Tags.HandlInst); }

    public ExecInst ExecInst
    {
        get
        {
            ExecInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecInst val) { ExecInst = val; }
    public ExecInst Get(ExecInst val) { GetField(val); return val; }
    public bool IsSet(ExecInst val) { return IsSetExecInst(); }
    public bool IsSetExecInst() { return IsSetField(Tags.ExecInst); }

    public MinQty MinQty
    {
        get
        {
            MinQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinQty val) { MinQty = val; }
    public MinQty Get(MinQty val) { GetField(val); return val; }
    public bool IsSet(MinQty val) { return IsSetMinQty(); }
    public bool IsSetMinQty() { return IsSetField(Tags.MinQty); }

    public MaxFloor MaxFloor
    {
        get
        {
            MaxFloor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxFloor val) { MaxFloor = val; }
    public MaxFloor Get(MaxFloor val) { GetField(val); return val; }
    public bool IsSet(MaxFloor val) { return IsSetMaxFloor(); }
    public bool IsSetMaxFloor() { return IsSetField(Tags.MaxFloor); }

    public ExDestination ExDestination
    {
        get
        {
            ExDestination val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExDestination val) { ExDestination = val; }
    public ExDestination Get(ExDestination val) { GetField(val); return val; }
    public bool IsSet(ExDestination val) { return IsSetExDestination(); }
    public bool IsSetExDestination() { return IsSetField(Tags.ExDestination); }

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

    public OrdType OrdType
    {
        get
        {
            OrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdType val) { OrdType = val; }
    public OrdType Get(OrdType val) { GetField(val); return val; }
    public bool IsSet(OrdType val) { return IsSetOrdType(); }
    public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

    public Price Price
    {
        get
        {
            Price val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price val) { Price = val; }
    public Price Get(Price val) { GetField(val); return val; }
    public bool IsSet(Price val) { return IsSetPrice(); }
    public bool IsSetPrice() { return IsSetField(Tags.Price); }

    public StopPx StopPx
    {
        get
        {
            StopPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StopPx val) { StopPx = val; }
    public StopPx Get(StopPx val) { GetField(val); return val; }
    public bool IsSet(StopPx val) { return IsSetStopPx(); }
    public bool IsSetStopPx() { return IsSetField(Tags.StopPx); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public TimeInForce TimeInForce
    {
        get
        {
            TimeInForce val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeInForce val) { TimeInForce = val; }
    public TimeInForce Get(TimeInForce val) { GetField(val); return val; }
    public bool IsSet(TimeInForce val) { return IsSetTimeInForce(); }
    public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }

    public ExpireTime ExpireTime
    {
        get
        {
            ExpireTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpireTime val) { ExpireTime = val; }
    public ExpireTime Get(ExpireTime val) { GetField(val); return val; }
    public bool IsSet(ExpireTime val) { return IsSetExpireTime(); }
    public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

    public Commission Commission
    {
        get
        {
            Commission val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Commission val) { Commission = val; }
    public Commission Get(Commission val) { GetField(val); return val; }
    public bool IsSet(Commission val) { return IsSetCommission(); }
    public bool IsSetCommission() { return IsSetField(Tags.Commission); }

    public CommType CommType
    {
        get
        {
            CommType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CommType val) { CommType = val; }
    public CommType Get(CommType val) { GetField(val); return val; }
    public bool IsSet(CommType val) { return IsSetCommType(); }
    public bool IsSetCommType() { return IsSetField(Tags.CommType); }

    public Rule80A Rule80A
    {
        get
        {
            Rule80A val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Rule80A val) { Rule80A = val; }
    public Rule80A Get(Rule80A val) { GetField(val); return val; }
    public bool IsSet(Rule80A val) { return IsSetRule80A(); }
    public bool IsSetRule80A() { return IsSetField(Tags.Rule80A); }

    public ForexReq ForexReq
    {
        get
        {
            ForexReq val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ForexReq val) { ForexReq = val; }
    public ForexReq Get(ForexReq val) { GetField(val); return val; }
    public bool IsSet(ForexReq val) { return IsSetForexReq(); }
    public bool IsSetForexReq() { return IsSetField(Tags.ForexReq); }

    public SettlCurrency SettlCurrency
    {
        get
        {
            SettlCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrency val) { SettlCurrency = val; }
    public SettlCurrency Get(SettlCurrency val) { GetField(val); return val; }
    public bool IsSet(SettlCurrency val) { return IsSetSettlCurrency(); }
    public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }

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
