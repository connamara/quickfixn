// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class QuoteRequest : Message
{
    public const string MsgType = "R";

    public QuoteRequest() : base()
    {
        Header.SetField(new MsgType("R"));
    }

    public QuoteRequest(
            QuoteReqID aQuoteReqID
        ) : this()
    {
        QuoteReqID = aQuoteReqID;
    }

    public QuoteReqID QuoteReqID
    {
        get
        {
            QuoteReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteReqID val) { QuoteReqID = val; }
    public QuoteReqID Get(QuoteReqID val) { GetField(val); return val; }
    public bool IsSet(QuoteReqID val) { return IsSetQuoteReqID(); }
    public bool IsSetQuoteReqID() { return IsSetField(Tags.QuoteReqID); }

    public NoRelatedSym NoRelatedSym
    {
        get
        {
            NoRelatedSym val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelatedSym val) { NoRelatedSym = val; }
    public NoRelatedSym Get(NoRelatedSym val) { GetField(val); return val; }
    public bool IsSet(NoRelatedSym val) { return IsSetNoRelatedSym(); }
    public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

    public class NoRelatedSymGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.QuoteRequestType, Tags.TradingSessionID, Tags.Side, Tags.OrderQty, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.ExpireTime, Tags.TransactTime, Tags.Currency, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.QuoteRequestType, Tags.TradingSessionID, Tags.Side, Tags.OrderQty, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.ExpireTime, Tags.TransactTime, Tags.Currency, 0};

        public NoRelatedSymGroup()
          : base(Tags.NoRelatedSym, Tags.Symbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelatedSymGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public QuoteRequestType QuoteRequestType
        {
            get
            {
                QuoteRequestType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteRequestType val) { QuoteRequestType = val; }
        public QuoteRequestType Get(QuoteRequestType val) { GetField(val); return val; }
        public bool IsSet(QuoteRequestType val) { return IsSetQuoteRequestType(); }
        public bool IsSetQuoteRequestType() { return IsSetField(Tags.QuoteRequestType); }

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
    }
}
