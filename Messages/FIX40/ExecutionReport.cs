// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class ExecutionReport : Message
{
    public const string MsgType = "8";

    public ExecutionReport() : base()
    {
        Header.SetField(new MsgType("8"));
    }

    public ExecutionReport(
            OrderID aOrderID,
            ExecID aExecID,
            ExecTransType aExecTransType,
            OrdStatus aOrdStatus,
            Symbol aSymbol,
            Side aSide,
            OrderQty aOrderQty,
            LastShares aLastShares,
            LastPx aLastPx,
            CumQty aCumQty,
            AvgPx aAvgPx
        ) : this()
    {
        OrderID = aOrderID;
        ExecID = aExecID;
        ExecTransType = aExecTransType;
        OrdStatus = aOrdStatus;
        Symbol = aSymbol;
        Side = aSide;
        OrderQty = aOrderQty;
        LastShares = aLastShares;
        LastPx = aLastPx;
        CumQty = aCumQty;
        AvgPx = aAvgPx;
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

    public ExecTransType ExecTransType
    {
        get
        {
            ExecTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecTransType val) { ExecTransType = val; }
    public ExecTransType Get(ExecTransType val) { GetField(val); return val; }
    public bool IsSet(ExecTransType val) { return IsSetExecTransType(); }
    public bool IsSetExecTransType() { return IsSetField(Tags.ExecTransType); }

    public ExecRefID ExecRefID
    {
        get
        {
            ExecRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecRefID val) { ExecRefID = val; }
    public ExecRefID Get(ExecRefID val) { GetField(val); return val; }
    public bool IsSet(ExecRefID val) { return IsSetExecRefID(); }
    public bool IsSetExecRefID() { return IsSetField(Tags.ExecRefID); }

    public OrdStatus OrdStatus
    {
        get
        {
            OrdStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdStatus val) { OrdStatus = val; }
    public OrdStatus Get(OrdStatus val) { GetField(val); return val; }
    public bool IsSet(OrdStatus val) { return IsSetOrdStatus(); }
    public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

    public OrdRejReason OrdRejReason
    {
        get
        {
            OrdRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdRejReason val) { OrdRejReason = val; }
    public OrdRejReason Get(OrdRejReason val) { GetField(val); return val; }
    public bool IsSet(OrdRejReason val) { return IsSetOrdRejReason(); }
    public bool IsSetOrdRejReason() { return IsSetField(Tags.OrdRejReason); }

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

    public LastMkt LastMkt
    {
        get
        {
            LastMkt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastMkt val) { LastMkt = val; }
    public LastMkt Get(LastMkt val) { GetField(val); return val; }
    public bool IsSet(LastMkt val) { return IsSetLastMkt(); }
    public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }

    public LastCapacity LastCapacity
    {
        get
        {
            LastCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastCapacity val) { LastCapacity = val; }
    public LastCapacity Get(LastCapacity val) { GetField(val); return val; }
    public bool IsSet(LastCapacity val) { return IsSetLastCapacity(); }
    public bool IsSetLastCapacity() { return IsSetField(Tags.LastCapacity); }

    public CumQty CumQty
    {
        get
        {
            CumQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CumQty val) { CumQty = val; }
    public CumQty Get(CumQty val) { GetField(val); return val; }
    public bool IsSet(CumQty val) { return IsSetCumQty(); }
    public bool IsSetCumQty() { return IsSetField(Tags.CumQty); }

    public AvgPx AvgPx
    {
        get
        {
            AvgPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPx val) { AvgPx = val; }
    public AvgPx Get(AvgPx val) { GetField(val); return val; }
    public bool IsSet(AvgPx val) { return IsSetAvgPx(); }
    public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }

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

    public ReportToExch ReportToExch
    {
        get
        {
            ReportToExch val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReportToExch val) { ReportToExch = val; }
    public ReportToExch Get(ReportToExch val) { GetField(val); return val; }
    public bool IsSet(ReportToExch val) { return IsSetReportToExch(); }
    public bool IsSetReportToExch() { return IsSetField(Tags.ReportToExch); }

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

    public NoMiscFees NoMiscFees
    {
        get
        {
            NoMiscFees val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMiscFees val) { NoMiscFees = val; }
    public NoMiscFees Get(NoMiscFees val) { GetField(val); return val; }
    public bool IsSet(NoMiscFees val) { return IsSetNoMiscFees(); }
    public bool IsSetNoMiscFees() { return IsSetField(Tags.NoMiscFees); }

    public NetMoney NetMoney
    {
        get
        {
            NetMoney val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NetMoney val) { NetMoney = val; }
    public NetMoney Get(NetMoney val) { GetField(val); return val; }
    public bool IsSet(NetMoney val) { return IsSetNetMoney(); }
    public bool IsSetNetMoney() { return IsSetField(Tags.NetMoney); }

    public SettlCurrAmt SettlCurrAmt
    {
        get
        {
            SettlCurrAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrAmt val) { SettlCurrAmt = val; }
    public SettlCurrAmt Get(SettlCurrAmt val) { GetField(val); return val; }
    public bool IsSet(SettlCurrAmt val) { return IsSetSettlCurrAmt(); }
    public bool IsSetSettlCurrAmt() { return IsSetField(Tags.SettlCurrAmt); }

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

    public class NoMiscFeesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, 0};

        public NoMiscFeesGroup()
          : base(Tags.NoMiscFees, Tags.MiscFeeAmt, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMiscFeesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public MiscFeeAmt MiscFeeAmt
        {
            get
            {
                MiscFeeAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeAmt val) { MiscFeeAmt = val; }
        public MiscFeeAmt Get(MiscFeeAmt val) { GetField(val); return val; }
        public bool IsSet(MiscFeeAmt val) { return IsSetMiscFeeAmt(); }
        public bool IsSetMiscFeeAmt() { return IsSetField(Tags.MiscFeeAmt); }

        public MiscFeeCurr MiscFeeCurr
        {
            get
            {
                MiscFeeCurr val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeCurr val) { MiscFeeCurr = val; }
        public MiscFeeCurr Get(MiscFeeCurr val) { GetField(val); return val; }
        public bool IsSet(MiscFeeCurr val) { return IsSetMiscFeeCurr(); }
        public bool IsSetMiscFeeCurr() { return IsSetField(Tags.MiscFeeCurr); }

        public MiscFeeType MiscFeeType
        {
            get
            {
                MiscFeeType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MiscFeeType val) { MiscFeeType = val; }
        public MiscFeeType Get(MiscFeeType val) { GetField(val); return val; }
        public bool IsSet(MiscFeeType val) { return IsSetMiscFeeType(); }
        public bool IsSetMiscFeeType() { return IsSetField(Tags.MiscFeeType); }
    }
}
