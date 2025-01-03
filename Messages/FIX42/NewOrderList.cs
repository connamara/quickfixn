// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class NewOrderList : Message
{
    public const string MsgType = "E";

    public NewOrderList() : base()
    {
        Header.SetField(new MsgType("E"));
    }

    public NewOrderList(
            ListID aListID,
            BidType aBidType,
            TotNoOrders aTotNoOrders
        ) : this()
    {
        ListID = aListID;
        BidType = aBidType;
        TotNoOrders = aTotNoOrders;
    }

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

    public BidID BidID
    {
        get
        {
            BidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidID val) { BidID = val; }
    public BidID Get(BidID val) { GetField(val); return val; }
    public bool IsSet(BidID val) { return IsSetBidID(); }
    public bool IsSetBidID() { return IsSetField(Tags.BidID); }

    public ClientBidID ClientBidID
    {
        get
        {
            ClientBidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientBidID val) { ClientBidID = val; }
    public ClientBidID Get(ClientBidID val) { GetField(val); return val; }
    public bool IsSet(ClientBidID val) { return IsSetClientBidID(); }
    public bool IsSetClientBidID() { return IsSetField(Tags.ClientBidID); }

    public ProgRptReqs ProgRptReqs
    {
        get
        {
            ProgRptReqs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProgRptReqs val) { ProgRptReqs = val; }
    public ProgRptReqs Get(ProgRptReqs val) { GetField(val); return val; }
    public bool IsSet(ProgRptReqs val) { return IsSetProgRptReqs(); }
    public bool IsSetProgRptReqs() { return IsSetField(Tags.ProgRptReqs); }

    public BidType BidType
    {
        get
        {
            BidType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidType val) { BidType = val; }
    public BidType Get(BidType val) { GetField(val); return val; }
    public bool IsSet(BidType val) { return IsSetBidType(); }
    public bool IsSetBidType() { return IsSetField(Tags.BidType); }

    public ProgPeriodInterval ProgPeriodInterval
    {
        get
        {
            ProgPeriodInterval val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProgPeriodInterval val) { ProgPeriodInterval = val; }
    public ProgPeriodInterval Get(ProgPeriodInterval val) { GetField(val); return val; }
    public bool IsSet(ProgPeriodInterval val) { return IsSetProgPeriodInterval(); }
    public bool IsSetProgPeriodInterval() { return IsSetField(Tags.ProgPeriodInterval); }

    public ListExecInstType ListExecInstType
    {
        get
        {
            ListExecInstType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListExecInstType val) { ListExecInstType = val; }
    public ListExecInstType Get(ListExecInstType val) { GetField(val); return val; }
    public bool IsSet(ListExecInstType val) { return IsSetListExecInstType(); }
    public bool IsSetListExecInstType() { return IsSetField(Tags.ListExecInstType); }

    public ListExecInst ListExecInst
    {
        get
        {
            ListExecInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListExecInst val) { ListExecInst = val; }
    public ListExecInst Get(ListExecInst val) { GetField(val); return val; }
    public bool IsSet(ListExecInst val) { return IsSetListExecInst(); }
    public bool IsSetListExecInst() { return IsSetField(Tags.ListExecInst); }

    public EncodedListExecInstLen EncodedListExecInstLen
    {
        get
        {
            EncodedListExecInstLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedListExecInstLen val) { EncodedListExecInstLen = val; }
    public EncodedListExecInstLen Get(EncodedListExecInstLen val) { GetField(val); return val; }
    public bool IsSet(EncodedListExecInstLen val) { return IsSetEncodedListExecInstLen(); }
    public bool IsSetEncodedListExecInstLen() { return IsSetField(Tags.EncodedListExecInstLen); }

    public EncodedListExecInst EncodedListExecInst
    {
        get
        {
            EncodedListExecInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedListExecInst val) { EncodedListExecInst = val; }
    public EncodedListExecInst Get(EncodedListExecInst val) { GetField(val); return val; }
    public bool IsSet(EncodedListExecInst val) { return IsSetEncodedListExecInst(); }
    public bool IsSetEncodedListExecInst() { return IsSetField(Tags.EncodedListExecInst); }

    public TotNoOrders TotNoOrders
    {
        get
        {
            TotNoOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoOrders val) { TotNoOrders = val; }
    public TotNoOrders Get(TotNoOrders val) { GetField(val); return val; }
    public bool IsSet(TotNoOrders val) { return IsSetTotNoOrders(); }
    public bool IsSetTotNoOrders() { return IsSetField(Tags.TotNoOrders); }

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

    public class NoOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.ListSeqNo, Tags.SettlInstMode, Tags.ClientID, Tags.ExecBroker, Tags.Account, Tags.NoAllocs, Tags.SettlmntTyp, Tags.FutSettDate, Tags.HandlInst, Tags.ExecInst, Tags.MinQty, Tags.MaxFloor, Tags.ExDestination, Tags.NoTradingSessions, Tags.ProcessCode, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.Side, Tags.SideValueInd, Tags.LocateReqd, Tags.TransactTime, Tags.OrderQty, Tags.CashOrderQty, Tags.OrdType, Tags.Price, Tags.StopPx, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.IOIid, Tags.QuoteID, Tags.TimeInForce, Tags.EffectiveTime, Tags.ExpireDate, Tags.ExpireTime, Tags.GTBookingInst, Tags.Commission, Tags.CommType, Tags.Rule80A, Tags.ForexReq, Tags.SettlCurrency, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.FutSettDate2, Tags.OrderQty2, Tags.OpenClose, Tags.CoveredOrUncovered, Tags.CustomerOrFirm, Tags.MaxShow, Tags.PegDifference, Tags.DiscretionInst, Tags.DiscretionOffset, Tags.ClearingFirm, Tags.ClearingAccount, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.ListSeqNo, Tags.SettlInstMode, Tags.ClientID, Tags.ExecBroker, Tags.Account, Tags.NoAllocs, Tags.SettlmntTyp, Tags.FutSettDate, Tags.HandlInst, Tags.ExecInst, Tags.MinQty, Tags.MaxFloor, Tags.ExDestination, Tags.NoTradingSessions, Tags.ProcessCode, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.Side, Tags.SideValueInd, Tags.LocateReqd, Tags.TransactTime, Tags.OrderQty, Tags.CashOrderQty, Tags.OrdType, Tags.Price, Tags.StopPx, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.IOIid, Tags.QuoteID, Tags.TimeInForce, Tags.EffectiveTime, Tags.ExpireDate, Tags.ExpireTime, Tags.GTBookingInst, Tags.Commission, Tags.CommType, Tags.Rule80A, Tags.ForexReq, Tags.SettlCurrency, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.FutSettDate2, Tags.OrderQty2, Tags.OpenClose, Tags.CoveredOrUncovered, Tags.CustomerOrFirm, Tags.MaxShow, Tags.PegDifference, Tags.DiscretionInst, Tags.DiscretionOffset, Tags.ClearingFirm, Tags.ClearingAccount, 0};

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

        public ListSeqNo ListSeqNo
        {
            get
            {
                ListSeqNo val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ListSeqNo val) { ListSeqNo = val; }
        public ListSeqNo Get(ListSeqNo val) { GetField(val); return val; }
        public bool IsSet(ListSeqNo val) { return IsSetListSeqNo(); }
        public bool IsSetListSeqNo() { return IsSetField(Tags.ListSeqNo); }

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

        public NoTradingSessions NoTradingSessions
        {
            get
            {
                NoTradingSessions val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoTradingSessions val) { NoTradingSessions = val; }
        public NoTradingSessions Get(NoTradingSessions val) { GetField(val); return val; }
        public bool IsSet(NoTradingSessions val) { return IsSetNoTradingSessions(); }
        public bool IsSetNoTradingSessions() { return IsSetField(Tags.NoTradingSessions); }

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

        public ContractMultiplier ContractMultiplier
        {
            get
            {
                ContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractMultiplier val) { ContractMultiplier = val; }
        public ContractMultiplier Get(ContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(ContractMultiplier val) { return IsSetContractMultiplier(); }
        public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

        public CouponRate CouponRate
        {
            get
            {
                CouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CouponRate val) { CouponRate = val; }
        public CouponRate Get(CouponRate val) { GetField(val); return val; }
        public bool IsSet(CouponRate val) { return IsSetCouponRate(); }
        public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

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

        public EncodedIssuerLen EncodedIssuerLen
        {
            get
            {
                EncodedIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuerLen val) { EncodedIssuerLen = val; }
        public EncodedIssuerLen Get(EncodedIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }
        public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

        public EncodedIssuer EncodedIssuer
        {
            get
            {
                EncodedIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuer val) { EncodedIssuer = val; }
        public EncodedIssuer Get(EncodedIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuer val) { return IsSetEncodedIssuer(); }
        public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

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

        public EncodedSecurityDescLen EncodedSecurityDescLen
        {
            get
            {
                EncodedSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDescLen val) { EncodedSecurityDescLen = val; }
        public EncodedSecurityDescLen Get(EncodedSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }
        public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

        public EncodedSecurityDesc EncodedSecurityDesc
        {
            get
            {
                EncodedSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDesc val) { EncodedSecurityDesc = val; }
        public EncodedSecurityDesc Get(EncodedSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }
        public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

        public PrevClosePx PrevClosePx
        {
            get
            {
                PrevClosePx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PrevClosePx val) { PrevClosePx = val; }
        public PrevClosePx Get(PrevClosePx val) { GetField(val); return val; }
        public bool IsSet(PrevClosePx val) { return IsSetPrevClosePx(); }
        public bool IsSetPrevClosePx() { return IsSetField(Tags.PrevClosePx); }

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

        public SideValueInd SideValueInd
        {
            get
            {
                SideValueInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideValueInd val) { SideValueInd = val; }
        public SideValueInd Get(SideValueInd val) { GetField(val); return val; }
        public bool IsSet(SideValueInd val) { return IsSetSideValueInd(); }
        public bool IsSetSideValueInd() { return IsSetField(Tags.SideValueInd); }

        public LocateReqd LocateReqd
        {
            get
            {
                LocateReqd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LocateReqd val) { LocateReqd = val; }
        public LocateReqd Get(LocateReqd val) { GetField(val); return val; }
        public bool IsSet(LocateReqd val) { return IsSetLocateReqd(); }
        public bool IsSetLocateReqd() { return IsSetField(Tags.LocateReqd); }

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

        public CashOrderQty CashOrderQty
        {
            get
            {
                CashOrderQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashOrderQty val) { CashOrderQty = val; }
        public CashOrderQty Get(CashOrderQty val) { GetField(val); return val; }
        public bool IsSet(CashOrderQty val) { return IsSetCashOrderQty(); }
        public bool IsSetCashOrderQty() { return IsSetField(Tags.CashOrderQty); }

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

        public ComplianceID ComplianceID
        {
            get
            {
                ComplianceID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplianceID val) { ComplianceID = val; }
        public ComplianceID Get(ComplianceID val) { GetField(val); return val; }
        public bool IsSet(ComplianceID val) { return IsSetComplianceID(); }
        public bool IsSetComplianceID() { return IsSetField(Tags.ComplianceID); }

        public SolicitedFlag SolicitedFlag
        {
            get
            {
                SolicitedFlag val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SolicitedFlag val) { SolicitedFlag = val; }
        public SolicitedFlag Get(SolicitedFlag val) { GetField(val); return val; }
        public bool IsSet(SolicitedFlag val) { return IsSetSolicitedFlag(); }
        public bool IsSetSolicitedFlag() { return IsSetField(Tags.SolicitedFlag); }

        public IOIid IOIid
        {
            get
            {
                IOIid val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IOIid val) { IOIid = val; }
        public IOIid Get(IOIid val) { GetField(val); return val; }
        public bool IsSet(IOIid val) { return IsSetIOIid(); }
        public bool IsSetIOIid() { return IsSetField(Tags.IOIid); }

        public QuoteID QuoteID
        {
            get
            {
                QuoteID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteID val) { QuoteID = val; }
        public QuoteID Get(QuoteID val) { GetField(val); return val; }
        public bool IsSet(QuoteID val) { return IsSetQuoteID(); }
        public bool IsSetQuoteID() { return IsSetField(Tags.QuoteID); }

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

        public EffectiveTime EffectiveTime
        {
            get
            {
                EffectiveTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EffectiveTime val) { EffectiveTime = val; }
        public EffectiveTime Get(EffectiveTime val) { GetField(val); return val; }
        public bool IsSet(EffectiveTime val) { return IsSetEffectiveTime(); }
        public bool IsSetEffectiveTime() { return IsSetField(Tags.EffectiveTime); }

        public ExpireDate ExpireDate
        {
            get
            {
                ExpireDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExpireDate val) { ExpireDate = val; }
        public ExpireDate Get(ExpireDate val) { GetField(val); return val; }
        public bool IsSet(ExpireDate val) { return IsSetExpireDate(); }
        public bool IsSetExpireDate() { return IsSetField(Tags.ExpireDate); }

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

        public GTBookingInst GTBookingInst
        {
            get
            {
                GTBookingInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(GTBookingInst val) { GTBookingInst = val; }
        public GTBookingInst Get(GTBookingInst val) { GetField(val); return val; }
        public bool IsSet(GTBookingInst val) { return IsSetGTBookingInst(); }
        public bool IsSetGTBookingInst() { return IsSetField(Tags.GTBookingInst); }

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

        public FutSettDate2 FutSettDate2
        {
            get
            {
                FutSettDate2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FutSettDate2 val) { FutSettDate2 = val; }
        public FutSettDate2 Get(FutSettDate2 val) { GetField(val); return val; }
        public bool IsSet(FutSettDate2 val) { return IsSetFutSettDate2(); }
        public bool IsSetFutSettDate2() { return IsSetField(Tags.FutSettDate2); }

        public OrderQty2 OrderQty2
        {
            get
            {
                OrderQty2 val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderQty2 val) { OrderQty2 = val; }
        public OrderQty2 Get(OrderQty2 val) { GetField(val); return val; }
        public bool IsSet(OrderQty2 val) { return IsSetOrderQty2(); }
        public bool IsSetOrderQty2() { return IsSetField(Tags.OrderQty2); }

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

        public CoveredOrUncovered CoveredOrUncovered
        {
            get
            {
                CoveredOrUncovered val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CoveredOrUncovered val) { CoveredOrUncovered = val; }
        public CoveredOrUncovered Get(CoveredOrUncovered val) { GetField(val); return val; }
        public bool IsSet(CoveredOrUncovered val) { return IsSetCoveredOrUncovered(); }
        public bool IsSetCoveredOrUncovered() { return IsSetField(Tags.CoveredOrUncovered); }

        public CustomerOrFirm CustomerOrFirm
        {
            get
            {
                CustomerOrFirm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CustomerOrFirm val) { CustomerOrFirm = val; }
        public CustomerOrFirm Get(CustomerOrFirm val) { GetField(val); return val; }
        public bool IsSet(CustomerOrFirm val) { return IsSetCustomerOrFirm(); }
        public bool IsSetCustomerOrFirm() { return IsSetField(Tags.CustomerOrFirm); }

        public MaxShow MaxShow
        {
            get
            {
                MaxShow val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaxShow val) { MaxShow = val; }
        public MaxShow Get(MaxShow val) { GetField(val); return val; }
        public bool IsSet(MaxShow val) { return IsSetMaxShow(); }
        public bool IsSetMaxShow() { return IsSetField(Tags.MaxShow); }

        public PegDifference PegDifference
        {
            get
            {
                PegDifference val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PegDifference val) { PegDifference = val; }
        public PegDifference Get(PegDifference val) { GetField(val); return val; }
        public bool IsSet(PegDifference val) { return IsSetPegDifference(); }
        public bool IsSetPegDifference() { return IsSetField(Tags.PegDifference); }

        public DiscretionInst DiscretionInst
        {
            get
            {
                DiscretionInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DiscretionInst val) { DiscretionInst = val; }
        public DiscretionInst Get(DiscretionInst val) { GetField(val); return val; }
        public bool IsSet(DiscretionInst val) { return IsSetDiscretionInst(); }
        public bool IsSetDiscretionInst() { return IsSetField(Tags.DiscretionInst); }

        public DiscretionOffset DiscretionOffset
        {
            get
            {
                DiscretionOffset val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DiscretionOffset val) { DiscretionOffset = val; }
        public DiscretionOffset Get(DiscretionOffset val) { GetField(val); return val; }
        public bool IsSet(DiscretionOffset val) { return IsSetDiscretionOffset(); }
        public bool IsSetDiscretionOffset() { return IsSetField(Tags.DiscretionOffset); }

        public ClearingFirm ClearingFirm
        {
            get
            {
                ClearingFirm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClearingFirm val) { ClearingFirm = val; }
        public ClearingFirm Get(ClearingFirm val) { GetField(val); return val; }
        public bool IsSet(ClearingFirm val) { return IsSetClearingFirm(); }
        public bool IsSetClearingFirm() { return IsSetField(Tags.ClearingFirm); }

        public ClearingAccount ClearingAccount
        {
            get
            {
                ClearingAccount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClearingAccount val) { ClearingAccount = val; }
        public ClearingAccount Get(ClearingAccount val) { GetField(val); return val; }
        public bool IsSet(ClearingAccount val) { return IsSetClearingAccount(); }
        public bool IsSetClearingAccount() { return IsSetField(Tags.ClearingAccount); }

        public class NoAllocsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocShares, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocShares, 0};

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
        }

        public class NoTradingSessionsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.TradingSessionID, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.TradingSessionID, 0};

            public NoTradingSessionsGroup()
              : base(Tags.NoTradingSessions, Tags.TradingSessionID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoTradingSessionsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public TradingSessionID TradingSessionID
            {
                get
                {
                    TradingSessionID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(TradingSessionID val) { TradingSessionID = val; }
            public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
            public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
            public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }
        }
    }
}
