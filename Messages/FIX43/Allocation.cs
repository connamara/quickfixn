// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

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
            AllocType aAllocType,
            Side aSide,
            Symbol aSymbol,
            Quantity aQuantity,
            AvgPx aAvgPx,
            TradeDate aTradeDate
        ) : this()
    {
        AllocID = aAllocID;
        AllocTransType = aAllocTransType;
        AllocType = aAllocType;
        Side = aSide;
        Symbol = aSymbol;
        Quantity = aQuantity;
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

    public AllocType AllocType
    {
        get
        {
            AllocType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocType val) { AllocType = val; }
    public AllocType Get(AllocType val) { GetField(val); return val; }
    public bool IsSet(AllocType val) { return IsSetAllocType(); }
    public bool IsSetAllocType() { return IsSetField(Tags.AllocType); }

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

    public BookingRefID BookingRefID
    {
        get
        {
            BookingRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingRefID val) { BookingRefID = val; }
    public BookingRefID Get(BookingRefID val) { GetField(val); return val; }
    public bool IsSet(BookingRefID val) { return IsSetBookingRefID(); }
    public bool IsSetBookingRefID() { return IsSetField(Tags.BookingRefID); }

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

    public SecurityIDSource SecurityIDSource
    {
        get
        {
            SecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityIDSource val) { SecurityIDSource = val; }
    public SecurityIDSource Get(SecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(SecurityIDSource val) { return IsSetSecurityIDSource(); }
    public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

    public NoSecurityAltID NoSecurityAltID
    {
        get
        {
            NoSecurityAltID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSecurityAltID val) { NoSecurityAltID = val; }
    public NoSecurityAltID Get(NoSecurityAltID val) { GetField(val); return val; }
    public bool IsSet(NoSecurityAltID val) { return IsSetNoSecurityAltID(); }
    public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

    public Product Product
    {
        get
        {
            Product val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Product val) { Product = val; }
    public Product Get(Product val) { GetField(val); return val; }
    public bool IsSet(Product val) { return IsSetProduct(); }
    public bool IsSetProduct() { return IsSetField(Tags.Product); }

    public CFICode CFICode
    {
        get
        {
            CFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CFICode val) { CFICode = val; }
    public CFICode Get(CFICode val) { GetField(val); return val; }
    public bool IsSet(CFICode val) { return IsSetCFICode(); }
    public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

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

    public MaturityDate MaturityDate
    {
        get
        {
            MaturityDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityDate val) { MaturityDate = val; }
    public MaturityDate Get(MaturityDate val) { GetField(val); return val; }
    public bool IsSet(MaturityDate val) { return IsSetMaturityDate(); }
    public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

    public CouponPaymentDate CouponPaymentDate
    {
        get
        {
            CouponPaymentDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CouponPaymentDate val) { CouponPaymentDate = val; }
    public CouponPaymentDate Get(CouponPaymentDate val) { GetField(val); return val; }
    public bool IsSet(CouponPaymentDate val) { return IsSetCouponPaymentDate(); }
    public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

    public IssueDate IssueDate
    {
        get
        {
            IssueDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IssueDate val) { IssueDate = val; }
    public IssueDate Get(IssueDate val) { GetField(val); return val; }
    public bool IsSet(IssueDate val) { return IsSetIssueDate(); }
    public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

    public RepoCollateralSecurityType RepoCollateralSecurityType
    {
        get
        {
            RepoCollateralSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepoCollateralSecurityType val) { RepoCollateralSecurityType = val; }
    public RepoCollateralSecurityType Get(RepoCollateralSecurityType val) { GetField(val); return val; }
    public bool IsSet(RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }
    public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

    public RepurchaseTerm RepurchaseTerm
    {
        get
        {
            RepurchaseTerm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepurchaseTerm val) { RepurchaseTerm = val; }
    public RepurchaseTerm Get(RepurchaseTerm val) { GetField(val); return val; }
    public bool IsSet(RepurchaseTerm val) { return IsSetRepurchaseTerm(); }
    public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

    public RepurchaseRate RepurchaseRate
    {
        get
        {
            RepurchaseRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RepurchaseRate val) { RepurchaseRate = val; }
    public RepurchaseRate Get(RepurchaseRate val) { GetField(val); return val; }
    public bool IsSet(RepurchaseRate val) { return IsSetRepurchaseRate(); }
    public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

    public Factor Factor
    {
        get
        {
            Factor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Factor val) { Factor = val; }
    public Factor Get(Factor val) { GetField(val); return val; }
    public bool IsSet(Factor val) { return IsSetFactor(); }
    public bool IsSetFactor() { return IsSetField(Tags.Factor); }

    public CreditRating CreditRating
    {
        get
        {
            CreditRating val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CreditRating val) { CreditRating = val; }
    public CreditRating Get(CreditRating val) { GetField(val); return val; }
    public bool IsSet(CreditRating val) { return IsSetCreditRating(); }
    public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

    public InstrRegistry InstrRegistry
    {
        get
        {
            InstrRegistry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InstrRegistry val) { InstrRegistry = val; }
    public InstrRegistry Get(InstrRegistry val) { GetField(val); return val; }
    public bool IsSet(InstrRegistry val) { return IsSetInstrRegistry(); }
    public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

    public CountryOfIssue CountryOfIssue
    {
        get
        {
            CountryOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CountryOfIssue val) { CountryOfIssue = val; }
    public CountryOfIssue Get(CountryOfIssue val) { GetField(val); return val; }
    public bool IsSet(CountryOfIssue val) { return IsSetCountryOfIssue(); }
    public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

    public StateOrProvinceOfIssue StateOrProvinceOfIssue
    {
        get
        {
            StateOrProvinceOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StateOrProvinceOfIssue val) { StateOrProvinceOfIssue = val; }
    public StateOrProvinceOfIssue Get(StateOrProvinceOfIssue val) { GetField(val); return val; }
    public bool IsSet(StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }
    public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

    public LocaleOfIssue LocaleOfIssue
    {
        get
        {
            LocaleOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LocaleOfIssue val) { LocaleOfIssue = val; }
    public LocaleOfIssue Get(LocaleOfIssue val) { GetField(val); return val; }
    public bool IsSet(LocaleOfIssue val) { return IsSetLocaleOfIssue(); }
    public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

    public RedemptionDate RedemptionDate
    {
        get
        {
            RedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RedemptionDate val) { RedemptionDate = val; }
    public RedemptionDate Get(RedemptionDate val) { GetField(val); return val; }
    public bool IsSet(RedemptionDate val) { return IsSetRedemptionDate(); }
    public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

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

    public Quantity Quantity
    {
        get
        {
            Quantity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Quantity val) { Quantity = val; }
    public Quantity Get(Quantity val) { GetField(val); return val; }
    public bool IsSet(Quantity val) { return IsSetQuantity(); }
    public bool IsSetQuantity() { return IsSetField(Tags.Quantity); }

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

    public TradeOriginationDate TradeOriginationDate
    {
        get
        {
            TradeOriginationDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeOriginationDate val) { TradeOriginationDate = val; }
    public TradeOriginationDate Get(TradeOriginationDate val) { GetField(val); return val; }
    public bool IsSet(TradeOriginationDate val) { return IsSetTradeOriginationDate(); }
    public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

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

    public TradingSessionSubID TradingSessionSubID
    {
        get
        {
            TradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
    public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
    public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

    public PriceType PriceType
    {
        get
        {
            PriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceType val) { PriceType = val; }
    public PriceType Get(PriceType val) { GetField(val); return val; }
    public bool IsSet(PriceType val) { return IsSetPriceType(); }
    public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

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

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

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

    public GrossTradeAmt GrossTradeAmt
    {
        get
        {
            GrossTradeAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(GrossTradeAmt val) { GrossTradeAmt = val; }
    public GrossTradeAmt Get(GrossTradeAmt val) { GetField(val); return val; }
    public bool IsSet(GrossTradeAmt val) { return IsSetGrossTradeAmt(); }
    public bool IsSetGrossTradeAmt() { return IsSetField(Tags.GrossTradeAmt); }

    public Concession Concession
    {
        get
        {
            Concession val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Concession val) { Concession = val; }
    public Concession Get(Concession val) { GetField(val); return val; }
    public bool IsSet(Concession val) { return IsSetConcession(); }
    public bool IsSetConcession() { return IsSetField(Tags.Concession); }

    public TotalTakedown TotalTakedown
    {
        get
        {
            TotalTakedown val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotalTakedown val) { TotalTakedown = val; }
    public TotalTakedown Get(TotalTakedown val) { GetField(val); return val; }
    public bool IsSet(TotalTakedown val) { return IsSetTotalTakedown(); }
    public bool IsSetTotalTakedown() { return IsSetField(Tags.TotalTakedown); }

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

    public PositionEffect PositionEffect
    {
        get
        {
            PositionEffect val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PositionEffect val) { PositionEffect = val; }
    public PositionEffect Get(PositionEffect val) { GetField(val); return val; }
    public bool IsSet(PositionEffect val) { return IsSetPositionEffect(); }
    public bool IsSetPositionEffect() { return IsSetField(Tags.PositionEffect); }

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

    public TotalAccruedInterestAmt TotalAccruedInterestAmt
    {
        get
        {
            TotalAccruedInterestAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotalAccruedInterestAmt val) { TotalAccruedInterestAmt = val; }
    public TotalAccruedInterestAmt Get(TotalAccruedInterestAmt val) { GetField(val); return val; }
    public bool IsSet(TotalAccruedInterestAmt val) { return IsSetTotalAccruedInterestAmt(); }
    public bool IsSetTotalAccruedInterestAmt() { return IsSetField(Tags.TotalAccruedInterestAmt); }

    public LegalConfirm LegalConfirm
    {
        get
        {
            LegalConfirm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LegalConfirm val) { LegalConfirm = val; }
    public LegalConfirm Get(LegalConfirm val) { GetField(val); return val; }
    public bool IsSet(LegalConfirm val) { return IsSetLegalConfirm(); }
    public bool IsSetLegalConfirm() { return IsSetField(Tags.LegalConfirm); }

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
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, 0};

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

        public SecondaryClOrdID SecondaryClOrdID
        {
            get
            {
                SecondaryClOrdID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryClOrdID val) { SecondaryClOrdID = val; }
        public SecondaryClOrdID Get(SecondaryClOrdID val) { GetField(val); return val; }
        public bool IsSet(SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }
        public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

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
    }

    public class NoExecsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LastQty, Tags.ExecID, Tags.SecondaryExecID, Tags.LastPx, Tags.LastCapacity, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LastQty, Tags.ExecID, Tags.SecondaryExecID, Tags.LastPx, Tags.LastCapacity, 0};

        public NoExecsGroup()
          : base(Tags.NoExecs, Tags.LastQty, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoExecsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public LastQty LastQty
        {
            get
            {
                LastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LastQty val) { LastQty = val; }
        public LastQty Get(LastQty val) { GetField(val); return val; }
        public bool IsSet(LastQty val) { return IsSetLastQty(); }
        public bool IsSetLastQty() { return IsSetField(Tags.LastQty); }

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

        public SecondaryExecID SecondaryExecID
        {
            get
            {
                SecondaryExecID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryExecID val) { SecondaryExecID = val; }
        public SecondaryExecID Get(SecondaryExecID val) { GetField(val); return val; }
        public bool IsSet(SecondaryExecID val) { return IsSetSecondaryExecID(); }
        public bool IsSetSecondaryExecID() { return IsSetField(Tags.SecondaryExecID); }

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

    public class NoSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.SecurityAltID, Tags.SecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

        public NoSecurityAltIDGroup()
          : base(Tags.NoSecurityAltID, Tags.SecurityAltID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSecurityAltIDGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public SecurityAltID SecurityAltID
        {
            get
            {
                SecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityAltID val) { SecurityAltID = val; }
        public SecurityAltID Get(SecurityAltID val) { GetField(val); return val; }
        public bool IsSet(SecurityAltID val) { return IsSetSecurityAltID(); }
        public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

        public SecurityAltIDSource SecurityAltIDSource
        {
            get
            {
                SecurityAltIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityAltIDSource val) { SecurityAltIDSource = val; }
        public SecurityAltIDSource Get(SecurityAltIDSource val) { GetField(val); return val; }
        public bool IsSet(SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }
        public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }
    }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public PartySubID PartySubID
        {
            get
            {
                PartySubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartySubID val) { PartySubID = val; }
        public PartySubID Get(PartySubID val) { GetField(val); return val; }
        public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }
    }

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocPrice, Tags.AllocQty, Tags.IndividualAllocID, Tags.ProcessCode, Tags.NoNestedPartyIDs, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AccruedInterestAmt, Tags.SettlInstMode, Tags.NoMiscFees, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocPrice, Tags.AllocQty, Tags.IndividualAllocID, Tags.ProcessCode, Tags.NoNestedPartyIDs, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AccruedInterestAmt, Tags.SettlInstMode, Tags.NoMiscFees, 0};

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

        public AllocPrice AllocPrice
        {
            get
            {
                AllocPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocPrice val) { AllocPrice = val; }
        public AllocPrice Get(AllocPrice val) { GetField(val); return val; }
        public bool IsSet(AllocPrice val) { return IsSetAllocPrice(); }
        public bool IsSetAllocPrice() { return IsSetField(Tags.AllocPrice); }

        public AllocQty AllocQty
        {
            get
            {
                AllocQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocQty val) { AllocQty = val; }
        public AllocQty Get(AllocQty val) { GetField(val); return val; }
        public bool IsSet(AllocQty val) { return IsSetAllocQty(); }
        public bool IsSetAllocQty() { return IsSetField(Tags.AllocQty); }

        public IndividualAllocID IndividualAllocID
        {
            get
            {
                IndividualAllocID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IndividualAllocID val) { IndividualAllocID = val; }
        public IndividualAllocID Get(IndividualAllocID val) { GetField(val); return val; }
        public bool IsSet(IndividualAllocID val) { return IsSetIndividualAllocID(); }
        public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }

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

        public NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                NoNestedPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNestedPartyIDs val) { NoNestedPartyIDs = val; }
        public NoNestedPartyIDs Get(NoNestedPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }
        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

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

        public EncodedAllocTextLen EncodedAllocTextLen
        {
            get
            {
                EncodedAllocTextLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedAllocTextLen val) { EncodedAllocTextLen = val; }
        public EncodedAllocTextLen Get(EncodedAllocTextLen val) { GetField(val); return val; }
        public bool IsSet(EncodedAllocTextLen val) { return IsSetEncodedAllocTextLen(); }
        public bool IsSetEncodedAllocTextLen() { return IsSetField(Tags.EncodedAllocTextLen); }

        public EncodedAllocText EncodedAllocText
        {
            get
            {
                EncodedAllocText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedAllocText val) { EncodedAllocText = val; }
        public EncodedAllocText Get(EncodedAllocText val) { GetField(val); return val; }
        public bool IsSet(EncodedAllocText val) { return IsSetEncodedAllocText(); }
        public bool IsSetEncodedAllocText() { return IsSetField(Tags.EncodedAllocText); }

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

        public CommCurrency CommCurrency
        {
            get
            {
                CommCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CommCurrency val) { CommCurrency = val; }
        public CommCurrency Get(CommCurrency val) { GetField(val); return val; }
        public bool IsSet(CommCurrency val) { return IsSetCommCurrency(); }
        public bool IsSetCommCurrency() { return IsSetField(Tags.CommCurrency); }

        public FundRenewWaiv FundRenewWaiv
        {
            get
            {
                FundRenewWaiv val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FundRenewWaiv val) { FundRenewWaiv = val; }
        public FundRenewWaiv Get(FundRenewWaiv val) { GetField(val); return val; }
        public bool IsSet(FundRenewWaiv val) { return IsSetFundRenewWaiv(); }
        public bool IsSetFundRenewWaiv() { return IsSetField(Tags.FundRenewWaiv); }

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

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NestedPartySubID, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NestedPartySubID, 0};

            public NoNestedPartyIDsGroup()
              : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public NestedPartyID NestedPartyID
            {
                get
                {
                    NestedPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyID val) { NestedPartyID = val; }
            public NestedPartyID Get(NestedPartyID val) { GetField(val); return val; }
            public bool IsSet(NestedPartyID val) { return IsSetNestedPartyID(); }
            public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

            public NestedPartyIDSource NestedPartyIDSource
            {
                get
                {
                    NestedPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyIDSource val) { NestedPartyIDSource = val; }
            public NestedPartyIDSource Get(NestedPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }
            public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

            public NestedPartyRole NestedPartyRole
            {
                get
                {
                    NestedPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyRole val) { NestedPartyRole = val; }
            public NestedPartyRole Get(NestedPartyRole val) { GetField(val); return val; }
            public bool IsSet(NestedPartyRole val) { return IsSetNestedPartyRole(); }
            public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

            public NestedPartySubID NestedPartySubID
            {
                get
                {
                    NestedPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartySubID val) { NestedPartySubID = val; }
            public NestedPartySubID Get(NestedPartySubID val) { GetField(val); return val; }
            public bool IsSet(NestedPartySubID val) { return IsSetNestedPartySubID(); }
            public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }
        }

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
