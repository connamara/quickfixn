// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX41;

public class Allocation : Message
{
    public const string MsgType = "J";

    public Allocation() : base()
    {
        Header.SetField(new MsgType("J"));
    }

    public Allocation(
            AllocID aAllocID,
            AllocTransType aAllocTransType,
            Side aSide,
            Symbol aSymbol,
            Shares aShares,
            AvgPx aAvgPx,
            TradeDate aTradeDate
        ) : this()
    {
        AllocID = aAllocID;
        AllocTransType = aAllocTransType;
        Side = aSide;
        Symbol = aSymbol;
        Shares = aShares;
        AvgPx = aAvgPx;
        TradeDate = aTradeDate;
    }

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

    public AllocTransType AllocTransType
    {
        get
        {
            AllocTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocTransType val) { AllocTransType = val; }
    public AllocTransType Get(AllocTransType val) { GetField(val); return val; }
    public bool IsSet(AllocTransType val) { return IsSetAllocTransType(); }
    public bool IsSetAllocTransType() { return IsSetField(Tags.AllocTransType); }

    public RefAllocID RefAllocID
    {
        get
        {
            RefAllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RefAllocID val) { RefAllocID = val; }
    public RefAllocID Get(RefAllocID val) { GetField(val); return val; }
    public bool IsSet(RefAllocID val) { return IsSetRefAllocID(); }
    public bool IsSetRefAllocID() { return IsSetField(Tags.RefAllocID); }

    public AllocLinkID AllocLinkID
    {
        get
        {
            AllocLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocLinkID val) { AllocLinkID = val; }
    public AllocLinkID Get(AllocLinkID val) { GetField(val); return val; }
    public bool IsSet(AllocLinkID val) { return IsSetAllocLinkID(); }
    public bool IsSetAllocLinkID() { return IsSetField(Tags.AllocLinkID); }

    public AllocLinkType AllocLinkType
    {
        get
        {
            AllocLinkType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocLinkType val) { AllocLinkType = val; }
    public AllocLinkType Get(AllocLinkType val) { GetField(val); return val; }
    public bool IsSet(AllocLinkType val) { return IsSetAllocLinkType(); }
    public bool IsSetAllocLinkType() { return IsSetField(Tags.AllocLinkType); }

    public NoOrders NoOrders
    {
        get
        {
            NoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOrders val) { NoOrders = val; }
    public NoOrders Get(NoOrders val) { GetField(val); return val; }
    public bool IsSet(NoOrders val) { return IsSetNoOrders(); }
    public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }

    public NoExecs NoExecs
    {
        get
        {
            NoExecs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoExecs val) { NoExecs = val; }
    public NoExecs Get(NoExecs val) { GetField(val); return val; }
    public bool IsSet(NoExecs val) { return IsSetNoExecs(); }
    public bool IsSetNoExecs() { return IsSetField(Tags.NoExecs); }

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

    public SecurityType SecurityType
    {
        get
        {
            SecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityType val) { SecurityType = val; }
    public SecurityType Get(SecurityType val) { GetField(val); return val; }
    public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
    public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

    public MaturityMonthYear MaturityMonthYear
    {
        get
        {
            MaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
    public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
    public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

    public MaturityDay MaturityDay
    {
        get
        {
            MaturityDay val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityDay val) { MaturityDay = val; }
    public MaturityDay Get(MaturityDay val) { GetField(val); return val; }
    public bool IsSet(MaturityDay val) { return IsSetMaturityDay(); }
    public bool IsSetMaturityDay() { return IsSetField(Tags.MaturityDay); }

    public PutOrCall PutOrCall
    {
        get
        {
            PutOrCall val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PutOrCall val) { PutOrCall = val; }
    public PutOrCall Get(PutOrCall val) { GetField(val); return val; }
    public bool IsSet(PutOrCall val) { return IsSetPutOrCall(); }
    public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

    public StrikePrice StrikePrice
    {
        get
        {
            StrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePrice val) { StrikePrice = val; }
    public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
    public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
    public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

    public OptAttribute OptAttribute
    {
        get
        {
            OptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptAttribute val) { OptAttribute = val; }
    public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
    public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
    public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

    public SecurityExchange SecurityExchange
    {
        get
        {
            SecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityExchange val) { SecurityExchange = val; }
    public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
    public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
    public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

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

    public Shares Shares
    {
        get
        {
            Shares val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Shares val) { Shares = val; }
    public Shares Get(Shares val) { GetField(val); return val; }
    public bool IsSet(Shares val) { return IsSetShares(); }
    public bool IsSetShares() { return IsSetField(Tags.Shares); }

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

    public AvgPrxPrecision AvgPrxPrecision
    {
        get
        {
            AvgPrxPrecision val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPrxPrecision val) { AvgPrxPrecision = val; }
    public AvgPrxPrecision Get(AvgPrxPrecision val) { GetField(val); return val; }
    public bool IsSet(AvgPrxPrecision val) { return IsSetAvgPrxPrecision(); }
    public bool IsSetAvgPrxPrecision() { return IsSetField(Tags.AvgPrxPrecision); }

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

    public OpenClose OpenClose
    {
        get
        {
            OpenClose val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OpenClose val) { OpenClose = val; }
    public OpenClose Get(OpenClose val) { GetField(val); return val; }
    public bool IsSet(OpenClose val) { return IsSetOpenClose(); }
    public bool IsSetOpenClose() { return IsSetField(Tags.OpenClose); }

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

    public NumDaysInterest NumDaysInterest
    {
        get
        {
            NumDaysInterest val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NumDaysInterest val) { NumDaysInterest = val; }
    public NumDaysInterest Get(NumDaysInterest val) { GetField(val); return val; }
    public bool IsSet(NumDaysInterest val) { return IsSetNumDaysInterest(); }
    public bool IsSetNumDaysInterest() { return IsSetField(Tags.NumDaysInterest); }

    public AccruedInterestRate AccruedInterestRate
    {
        get
        {
            AccruedInterestRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AccruedInterestRate val) { AccruedInterestRate = val; }
    public AccruedInterestRate Get(AccruedInterestRate val) { GetField(val); return val; }
    public bool IsSet(AccruedInterestRate val) { return IsSetAccruedInterestRate(); }
    public bool IsSetAccruedInterestRate() { return IsSetField(Tags.AccruedInterestRate); }

    public NoAllocs NoAllocs
    {
        get
        {
            NoAllocs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoAllocs val) { NoAllocs = val; }
    public NoAllocs Get(NoAllocs val) { GetField(val); return val; }
    public bool IsSet(NoAllocs val) { return IsSetNoAllocs(); }
    public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }

    public class NoOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.ListID, Tags.WaveNo, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.ListID, Tags.WaveNo, 0};

        public NoOrdersGroup()
          : base(Tags.NoOrders, Tags.ClOrdID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOrdersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public SecondaryOrderID SecondaryOrderID
        {
            get
            {
                SecondaryOrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryOrderID val) { SecondaryOrderID = val; }
        public SecondaryOrderID Get(SecondaryOrderID val) { GetField(val); return val; }
        public bool IsSet(SecondaryOrderID val) { return IsSetSecondaryOrderID(); }
        public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

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

        public WaveNo WaveNo
        {
            get
            {
                WaveNo val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(WaveNo val) { WaveNo = val; }
        public WaveNo Get(WaveNo val) { GetField(val); return val; }
        public bool IsSet(WaveNo val) { return IsSetWaveNo(); }
        public bool IsSetWaveNo() { return IsSetField(Tags.WaveNo); }
    }

    public class NoExecsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LastShares, Tags.ExecID, Tags.LastPx, Tags.LastCapacity, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LastShares, Tags.ExecID, Tags.LastPx, Tags.LastCapacity, 0};

        public NoExecsGroup()
          : base(Tags.NoExecs, Tags.LastShares, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoExecsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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
    }

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocShares, Tags.ProcessCode, Tags.BrokerOfCredit, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.ExecBroker, Tags.ClientID, Tags.Commission, Tags.CommType, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AccruedInterestAmt, Tags.SettlInstMode, Tags.NoMiscFees, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, Tags.ProcessCode, Tags.BrokerOfCredit, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.ExecBroker, Tags.ClientID, Tags.Commission, Tags.CommType, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AccruedInterestAmt, Tags.SettlInstMode, Tags.NoMiscFees, 0};

        public NoAllocsGroup()
          : base(Tags.NoAllocs, Tags.AllocAccount, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoAllocsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public AllocAccount AllocAccount
        {
            get
            {
                AllocAccount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocAccount val) { AllocAccount = val; }
        public AllocAccount Get(AllocAccount val) { GetField(val); return val; }
        public bool IsSet(AllocAccount val) { return IsSetAllocAccount(); }
        public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }

        public AllocShares AllocShares
        {
            get
            {
                AllocShares val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocShares val) { AllocShares = val; }
        public AllocShares Get(AllocShares val) { GetField(val); return val; }
        public bool IsSet(AllocShares val) { return IsSetAllocShares(); }
        public bool IsSetAllocShares() { return IsSetField(Tags.AllocShares); }

        public ProcessCode ProcessCode
        {
            get
            {
                ProcessCode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ProcessCode val) { ProcessCode = val; }
        public ProcessCode Get(ProcessCode val) { GetField(val); return val; }
        public bool IsSet(ProcessCode val) { return IsSetProcessCode(); }
        public bool IsSetProcessCode() { return IsSetField(Tags.ProcessCode); }

        public BrokerOfCredit BrokerOfCredit
        {
            get
            {
                BrokerOfCredit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(BrokerOfCredit val) { BrokerOfCredit = val; }
        public BrokerOfCredit Get(BrokerOfCredit val) { GetField(val); return val; }
        public bool IsSet(BrokerOfCredit val) { return IsSetBrokerOfCredit(); }
        public bool IsSetBrokerOfCredit() { return IsSetField(Tags.BrokerOfCredit); }

        public NotifyBrokerOfCredit NotifyBrokerOfCredit
        {
            get
            {
                NotifyBrokerOfCredit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NotifyBrokerOfCredit val) { NotifyBrokerOfCredit = val; }
        public NotifyBrokerOfCredit Get(NotifyBrokerOfCredit val) { GetField(val); return val; }
        public bool IsSet(NotifyBrokerOfCredit val) { return IsSetNotifyBrokerOfCredit(); }
        public bool IsSetNotifyBrokerOfCredit() { return IsSetField(Tags.NotifyBrokerOfCredit); }

        public AllocHandlInst AllocHandlInst
        {
            get
            {
                AllocHandlInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocHandlInst val) { AllocHandlInst = val; }
        public AllocHandlInst Get(AllocHandlInst val) { GetField(val); return val; }
        public bool IsSet(AllocHandlInst val) { return IsSetAllocHandlInst(); }
        public bool IsSetAllocHandlInst() { return IsSetField(Tags.AllocHandlInst); }

        public AllocText AllocText
        {
            get
            {
                AllocText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocText val) { AllocText = val; }
        public AllocText Get(AllocText val) { GetField(val); return val; }
        public bool IsSet(AllocText val) { return IsSetAllocText(); }
        public bool IsSetAllocText() { return IsSetField(Tags.AllocText); }

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

        public AllocAvgPx AllocAvgPx
        {
            get
            {
                AllocAvgPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocAvgPx val) { AllocAvgPx = val; }
        public AllocAvgPx Get(AllocAvgPx val) { GetField(val); return val; }
        public bool IsSet(AllocAvgPx val) { return IsSetAllocAvgPx(); }
        public bool IsSetAllocAvgPx() { return IsSetField(Tags.AllocAvgPx); }

        public AllocNetMoney AllocNetMoney
        {
            get
            {
                AllocNetMoney val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocNetMoney val) { AllocNetMoney = val; }
        public AllocNetMoney Get(AllocNetMoney val) { GetField(val); return val; }
        public bool IsSet(AllocNetMoney val) { return IsSetAllocNetMoney(); }
        public bool IsSetAllocNetMoney() { return IsSetField(Tags.AllocNetMoney); }

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

        public SettlCurrFxRate SettlCurrFxRate
        {
            get
            {
                SettlCurrFxRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlCurrFxRate val) { SettlCurrFxRate = val; }
        public SettlCurrFxRate Get(SettlCurrFxRate val) { GetField(val); return val; }
        public bool IsSet(SettlCurrFxRate val) { return IsSetSettlCurrFxRate(); }
        public bool IsSetSettlCurrFxRate() { return IsSetField(Tags.SettlCurrFxRate); }

        public SettlCurrFxRateCalc SettlCurrFxRateCalc
        {
            get
            {
                SettlCurrFxRateCalc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlCurrFxRateCalc val) { SettlCurrFxRateCalc = val; }
        public SettlCurrFxRateCalc Get(SettlCurrFxRateCalc val) { GetField(val); return val; }
        public bool IsSet(SettlCurrFxRateCalc val) { return IsSetSettlCurrFxRateCalc(); }
        public bool IsSetSettlCurrFxRateCalc() { return IsSetField(Tags.SettlCurrFxRateCalc); }

        public AccruedInterestAmt AccruedInterestAmt
        {
            get
            {
                AccruedInterestAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AccruedInterestAmt val) { AccruedInterestAmt = val; }
        public AccruedInterestAmt Get(AccruedInterestAmt val) { GetField(val); return val; }
        public bool IsSet(AccruedInterestAmt val) { return IsSetAccruedInterestAmt(); }
        public bool IsSetAccruedInterestAmt() { return IsSetField(Tags.AccruedInterestAmt); }

        public SettlInstMode SettlInstMode
        {
            get
            {
                SettlInstMode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlInstMode val) { SettlInstMode = val; }
        public SettlInstMode Get(SettlInstMode val) { GetField(val); return val; }
        public bool IsSet(SettlInstMode val) { return IsSetSettlInstMode(); }
        public bool IsSetSettlInstMode() { return IsSetField(Tags.SettlInstMode); }

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
}
