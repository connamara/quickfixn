// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class OrderMassActionReport : Message
{
    public const string MsgType = "BZ";

    public OrderMassActionReport() : base()
    {
        Header.SetField(new MsgType("BZ"));
    }

    public OrderMassActionReport(
            MassActionReportID aMassActionReportID,
            MassActionType aMassActionType,
            MassActionScope aMassActionScope,
            MassActionResponse aMassActionResponse
        ) : this()
    {
        MassActionReportID = aMassActionReportID;
        MassActionType = aMassActionType;
        MassActionScope = aMassActionScope;
        MassActionResponse = aMassActionResponse;
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

    public MassActionReportID MassActionReportID
    {
        get
        {
            MassActionReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassActionReportID val) { MassActionReportID = val; }
    public MassActionReportID Get(MassActionReportID val) { GetField(val); return val; }
    public bool IsSet(MassActionReportID val) { return IsSetMassActionReportID(); }
    public bool IsSetMassActionReportID() { return IsSetField(Tags.MassActionReportID); }

    public MassActionType MassActionType
    {
        get
        {
            MassActionType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassActionType val) { MassActionType = val; }
    public MassActionType Get(MassActionType val) { GetField(val); return val; }
    public bool IsSet(MassActionType val) { return IsSetMassActionType(); }
    public bool IsSetMassActionType() { return IsSetField(Tags.MassActionType); }

    public MassActionScope MassActionScope
    {
        get
        {
            MassActionScope val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassActionScope val) { MassActionScope = val; }
    public MassActionScope Get(MassActionScope val) { GetField(val); return val; }
    public bool IsSet(MassActionScope val) { return IsSetMassActionScope(); }
    public bool IsSetMassActionScope() { return IsSetField(Tags.MassActionScope); }

    public MassActionResponse MassActionResponse
    {
        get
        {
            MassActionResponse val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassActionResponse val) { MassActionResponse = val; }
    public MassActionResponse Get(MassActionResponse val) { GetField(val); return val; }
    public bool IsSet(MassActionResponse val) { return IsSetMassActionResponse(); }
    public bool IsSetMassActionResponse() { return IsSetField(Tags.MassActionResponse); }

    public MassActionRejectReason MassActionRejectReason
    {
        get
        {
            MassActionRejectReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MassActionRejectReason val) { MassActionRejectReason = val; }
    public MassActionRejectReason Get(MassActionRejectReason val) { GetField(val); return val; }
    public bool IsSet(MassActionRejectReason val) { return IsSetMassActionRejectReason(); }
    public bool IsSetMassActionRejectReason() { return IsSetField(Tags.MassActionRejectReason); }

    public TotalAffectedOrders TotalAffectedOrders
    {
        get
        {
            TotalAffectedOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotalAffectedOrders val) { TotalAffectedOrders = val; }
    public TotalAffectedOrders Get(TotalAffectedOrders val) { GetField(val); return val; }
    public bool IsSet(TotalAffectedOrders val) { return IsSetTotalAffectedOrders(); }
    public bool IsSetTotalAffectedOrders() { return IsSetField(Tags.TotalAffectedOrders); }

    public NoAffectedOrders NoAffectedOrders
    {
        get
        {
            NoAffectedOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoAffectedOrders val) { NoAffectedOrders = val; }
    public NoAffectedOrders Get(NoAffectedOrders val) { GetField(val); return val; }
    public bool IsSet(NoAffectedOrders val) { return IsSetNoAffectedOrders(); }
    public bool IsSetNoAffectedOrders() { return IsSetField(Tags.NoAffectedOrders); }

    public MarketID MarketID
    {
        get
        {
            MarketID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketID val) { MarketID = val; }
    public MarketID Get(MarketID val) { GetField(val); return val; }
    public bool IsSet(MarketID val) { return IsSetMarketID(); }
    public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

    public MarketSegmentID MarketSegmentID
    {
        get
        {
            MarketSegmentID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketSegmentID val) { MarketSegmentID = val; }
    public MarketSegmentID Get(MarketSegmentID val) { GetField(val); return val; }
    public bool IsSet(MarketSegmentID val) { return IsSetMarketSegmentID(); }
    public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

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

    public SecuritySubType SecuritySubType
    {
        get
        {
            SecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySubType val) { SecuritySubType = val; }
    public SecuritySubType Get(SecuritySubType val) { GetField(val); return val; }
    public bool IsSet(SecuritySubType val) { return IsSetSecuritySubType(); }
    public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }

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

    public StrikeCurrency StrikeCurrency
    {
        get
        {
            StrikeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeCurrency val) { StrikeCurrency = val; }
    public StrikeCurrency Get(StrikeCurrency val) { GetField(val); return val; }
    public bool IsSet(StrikeCurrency val) { return IsSetStrikeCurrency(); }
    public bool IsSetStrikeCurrency() { return IsSetField(Tags.StrikeCurrency); }

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

    public Pool Pool
    {
        get
        {
            Pool val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Pool val) { Pool = val; }
    public Pool Get(Pool val) { GetField(val); return val; }
    public bool IsSet(Pool val) { return IsSetPool(); }
    public bool IsSetPool() { return IsSetField(Tags.Pool); }

    public ContractSettlMonth ContractSettlMonth
    {
        get
        {
            ContractSettlMonth val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractSettlMonth val) { ContractSettlMonth = val; }
    public ContractSettlMonth Get(ContractSettlMonth val) { GetField(val); return val; }
    public bool IsSet(ContractSettlMonth val) { return IsSetContractSettlMonth(); }
    public bool IsSetContractSettlMonth() { return IsSetField(Tags.ContractSettlMonth); }

    public CPProgram CPProgram
    {
        get
        {
            CPProgram val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CPProgram val) { CPProgram = val; }
    public CPProgram Get(CPProgram val) { GetField(val); return val; }
    public bool IsSet(CPProgram val) { return IsSetCPProgram(); }
    public bool IsSetCPProgram() { return IsSetField(Tags.CPProgram); }

    public CPRegType CPRegType
    {
        get
        {
            CPRegType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CPRegType val) { CPRegType = val; }
    public CPRegType Get(CPRegType val) { GetField(val); return val; }
    public bool IsSet(CPRegType val) { return IsSetCPRegType(); }
    public bool IsSetCPRegType() { return IsSetField(Tags.CPRegType); }

    public NoEvents NoEvents
    {
        get
        {
            NoEvents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoEvents val) { NoEvents = val; }
    public NoEvents Get(NoEvents val) { GetField(val); return val; }
    public bool IsSet(NoEvents val) { return IsSetNoEvents(); }
    public bool IsSetNoEvents() { return IsSetField(Tags.NoEvents); }

    public DatedDate DatedDate
    {
        get
        {
            DatedDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DatedDate val) { DatedDate = val; }
    public DatedDate Get(DatedDate val) { GetField(val); return val; }
    public bool IsSet(DatedDate val) { return IsSetDatedDate(); }
    public bool IsSetDatedDate() { return IsSetField(Tags.DatedDate); }

    public InterestAccrualDate InterestAccrualDate
    {
        get
        {
            InterestAccrualDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterestAccrualDate val) { InterestAccrualDate = val; }
    public InterestAccrualDate Get(InterestAccrualDate val) { GetField(val); return val; }
    public bool IsSet(InterestAccrualDate val) { return IsSetInterestAccrualDate(); }
    public bool IsSetInterestAccrualDate() { return IsSetField(Tags.InterestAccrualDate); }

    public Fields.SecurityStatus SecurityStatus
    {
        get
        {
            Fields.SecurityStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Fields.SecurityStatus val) { SecurityStatus = val; }
    public Fields.SecurityStatus Get(Fields.SecurityStatus val) { GetField(val); return val; }
    public bool IsSet(Fields.SecurityStatus val) { return IsSetSecurityStatus(); }
    public bool IsSetSecurityStatus() { return IsSetField(Tags.SecurityStatus); }

    public SettleOnOpenFlag SettleOnOpenFlag
    {
        get
        {
            SettleOnOpenFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettleOnOpenFlag val) { SettleOnOpenFlag = val; }
    public SettleOnOpenFlag Get(SettleOnOpenFlag val) { GetField(val); return val; }
    public bool IsSet(SettleOnOpenFlag val) { return IsSetSettleOnOpenFlag(); }
    public bool IsSetSettleOnOpenFlag() { return IsSetField(Tags.SettleOnOpenFlag); }

    public InstrmtAssignmentMethod InstrmtAssignmentMethod
    {
        get
        {
            InstrmtAssignmentMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InstrmtAssignmentMethod val) { InstrmtAssignmentMethod = val; }
    public InstrmtAssignmentMethod Get(InstrmtAssignmentMethod val) { GetField(val); return val; }
    public bool IsSet(InstrmtAssignmentMethod val) { return IsSetInstrmtAssignmentMethod(); }
    public bool IsSetInstrmtAssignmentMethod() { return IsSetField(Tags.InstrmtAssignmentMethod); }

    public StrikeMultiplier StrikeMultiplier
    {
        get
        {
            StrikeMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeMultiplier val) { StrikeMultiplier = val; }
    public StrikeMultiplier Get(StrikeMultiplier val) { GetField(val); return val; }
    public bool IsSet(StrikeMultiplier val) { return IsSetStrikeMultiplier(); }
    public bool IsSetStrikeMultiplier() { return IsSetField(Tags.StrikeMultiplier); }

    public StrikeValue StrikeValue
    {
        get
        {
            StrikeValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeValue val) { StrikeValue = val; }
    public StrikeValue Get(StrikeValue val) { GetField(val); return val; }
    public bool IsSet(StrikeValue val) { return IsSetStrikeValue(); }
    public bool IsSetStrikeValue() { return IsSetField(Tags.StrikeValue); }

    public MinPriceIncrement MinPriceIncrement
    {
        get
        {
            MinPriceIncrement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinPriceIncrement val) { MinPriceIncrement = val; }
    public MinPriceIncrement Get(MinPriceIncrement val) { GetField(val); return val; }
    public bool IsSet(MinPriceIncrement val) { return IsSetMinPriceIncrement(); }
    public bool IsSetMinPriceIncrement() { return IsSetField(Tags.MinPriceIncrement); }

    public PositionLimit PositionLimit
    {
        get
        {
            PositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PositionLimit val) { PositionLimit = val; }
    public PositionLimit Get(PositionLimit val) { GetField(val); return val; }
    public bool IsSet(PositionLimit val) { return IsSetPositionLimit(); }
    public bool IsSetPositionLimit() { return IsSetField(Tags.PositionLimit); }

    public NTPositionLimit NTPositionLimit
    {
        get
        {
            NTPositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NTPositionLimit val) { NTPositionLimit = val; }
    public NTPositionLimit Get(NTPositionLimit val) { GetField(val); return val; }
    public bool IsSet(NTPositionLimit val) { return IsSetNTPositionLimit(); }
    public bool IsSetNTPositionLimit() { return IsSetField(Tags.NTPositionLimit); }

    public NoInstrumentParties NoInstrumentParties
    {
        get
        {
            NoInstrumentParties val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoInstrumentParties val) { NoInstrumentParties = val; }
    public NoInstrumentParties Get(NoInstrumentParties val) { GetField(val); return val; }
    public bool IsSet(NoInstrumentParties val) { return IsSetNoInstrumentParties(); }
    public bool IsSetNoInstrumentParties() { return IsSetField(Tags.NoInstrumentParties); }

    public UnitOfMeasure UnitOfMeasure
    {
        get
        {
            UnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnitOfMeasure val) { UnitOfMeasure = val; }
    public UnitOfMeasure Get(UnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnitOfMeasure val) { return IsSetUnitOfMeasure(); }
    public bool IsSetUnitOfMeasure() { return IsSetField(Tags.UnitOfMeasure); }

    public TimeUnit TimeUnit
    {
        get
        {
            TimeUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TimeUnit val) { TimeUnit = val; }
    public TimeUnit Get(TimeUnit val) { GetField(val); return val; }
    public bool IsSet(TimeUnit val) { return IsSetTimeUnit(); }
    public bool IsSetTimeUnit() { return IsSetField(Tags.TimeUnit); }

    public MaturityTime MaturityTime
    {
        get
        {
            MaturityTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaturityTime val) { MaturityTime = val; }
    public MaturityTime Get(MaturityTime val) { GetField(val); return val; }
    public bool IsSet(MaturityTime val) { return IsSetMaturityTime(); }
    public bool IsSetMaturityTime() { return IsSetField(Tags.MaturityTime); }

    public SecurityGroup SecurityGroup
    {
        get
        {
            SecurityGroup val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityGroup val) { SecurityGroup = val; }
    public SecurityGroup Get(SecurityGroup val) { GetField(val); return val; }
    public bool IsSet(SecurityGroup val) { return IsSetSecurityGroup(); }
    public bool IsSetSecurityGroup() { return IsSetField(Tags.SecurityGroup); }

    public MinPriceIncrementAmount MinPriceIncrementAmount
    {
        get
        {
            MinPriceIncrementAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinPriceIncrementAmount val) { MinPriceIncrementAmount = val; }
    public MinPriceIncrementAmount Get(MinPriceIncrementAmount val) { GetField(val); return val; }
    public bool IsSet(MinPriceIncrementAmount val) { return IsSetMinPriceIncrementAmount(); }
    public bool IsSetMinPriceIncrementAmount() { return IsSetField(Tags.MinPriceIncrementAmount); }

    public UnitOfMeasureQty UnitOfMeasureQty
    {
        get
        {
            UnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnitOfMeasureQty val) { UnitOfMeasureQty = val; }
    public UnitOfMeasureQty Get(UnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(UnitOfMeasureQty val) { return IsSetUnitOfMeasureQty(); }
    public bool IsSetUnitOfMeasureQty() { return IsSetField(Tags.UnitOfMeasureQty); }

    public SecurityXMLLen SecurityXMLLen
    {
        get
        {
            SecurityXMLLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityXMLLen val) { SecurityXMLLen = val; }
    public SecurityXMLLen Get(SecurityXMLLen val) { GetField(val); return val; }
    public bool IsSet(SecurityXMLLen val) { return IsSetSecurityXMLLen(); }
    public bool IsSetSecurityXMLLen() { return IsSetField(Tags.SecurityXMLLen); }

    public SecurityXML SecurityXML
    {
        get
        {
            SecurityXML val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityXML val) { SecurityXML = val; }
    public SecurityXML Get(SecurityXML val) { GetField(val); return val; }
    public bool IsSet(SecurityXML val) { return IsSetSecurityXML(); }
    public bool IsSetSecurityXML() { return IsSetField(Tags.SecurityXML); }

    public SecurityXMLSchema SecurityXMLSchema
    {
        get
        {
            SecurityXMLSchema val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityXMLSchema val) { SecurityXMLSchema = val; }
    public SecurityXMLSchema Get(SecurityXMLSchema val) { GetField(val); return val; }
    public bool IsSet(SecurityXMLSchema val) { return IsSetSecurityXMLSchema(); }
    public bool IsSetSecurityXMLSchema() { return IsSetField(Tags.SecurityXMLSchema); }

    public ProductComplex ProductComplex
    {
        get
        {
            ProductComplex val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProductComplex val) { ProductComplex = val; }
    public ProductComplex Get(ProductComplex val) { GetField(val); return val; }
    public bool IsSet(ProductComplex val) { return IsSetProductComplex(); }
    public bool IsSetProductComplex() { return IsSetField(Tags.ProductComplex); }

    public PriceUnitOfMeasure PriceUnitOfMeasure
    {
        get
        {
            PriceUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceUnitOfMeasure val) { PriceUnitOfMeasure = val; }
    public PriceUnitOfMeasure Get(PriceUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(PriceUnitOfMeasure val) { return IsSetPriceUnitOfMeasure(); }
    public bool IsSetPriceUnitOfMeasure() { return IsSetField(Tags.PriceUnitOfMeasure); }

    public PriceUnitOfMeasureQty PriceUnitOfMeasureQty
    {
        get
        {
            PriceUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceUnitOfMeasureQty val) { PriceUnitOfMeasureQty = val; }
    public PriceUnitOfMeasureQty Get(PriceUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(PriceUnitOfMeasureQty val) { return IsSetPriceUnitOfMeasureQty(); }
    public bool IsSetPriceUnitOfMeasureQty() { return IsSetField(Tags.PriceUnitOfMeasureQty); }

    public SettlMethod SettlMethod
    {
        get
        {
            SettlMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlMethod val) { SettlMethod = val; }
    public SettlMethod Get(SettlMethod val) { GetField(val); return val; }
    public bool IsSet(SettlMethod val) { return IsSetSettlMethod(); }
    public bool IsSetSettlMethod() { return IsSetField(Tags.SettlMethod); }

    public ExerciseStyle ExerciseStyle
    {
        get
        {
            ExerciseStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExerciseStyle val) { ExerciseStyle = val; }
    public ExerciseStyle Get(ExerciseStyle val) { GetField(val); return val; }
    public bool IsSet(ExerciseStyle val) { return IsSetExerciseStyle(); }
    public bool IsSetExerciseStyle() { return IsSetField(Tags.ExerciseStyle); }

    public OptPayAmount OptPayAmount
    {
        get
        {
            OptPayAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptPayAmount val) { OptPayAmount = val; }
    public OptPayAmount Get(OptPayAmount val) { GetField(val); return val; }
    public bool IsSet(OptPayAmount val) { return IsSetOptPayAmount(); }
    public bool IsSetOptPayAmount() { return IsSetField(Tags.OptPayAmount); }

    public PriceQuoteMethod PriceQuoteMethod
    {
        get
        {
            PriceQuoteMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceQuoteMethod val) { PriceQuoteMethod = val; }
    public PriceQuoteMethod Get(PriceQuoteMethod val) { GetField(val); return val; }
    public bool IsSet(PriceQuoteMethod val) { return IsSetPriceQuoteMethod(); }
    public bool IsSetPriceQuoteMethod() { return IsSetField(Tags.PriceQuoteMethod); }

    public ListMethod ListMethod
    {
        get
        {
            ListMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListMethod val) { ListMethod = val; }
    public ListMethod Get(ListMethod val) { GetField(val); return val; }
    public bool IsSet(ListMethod val) { return IsSetListMethod(); }
    public bool IsSetListMethod() { return IsSetField(Tags.ListMethod); }

    public CapPrice CapPrice
    {
        get
        {
            CapPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CapPrice val) { CapPrice = val; }
    public CapPrice Get(CapPrice val) { GetField(val); return val; }
    public bool IsSet(CapPrice val) { return IsSetCapPrice(); }
    public bool IsSetCapPrice() { return IsSetField(Tags.CapPrice); }

    public FloorPrice FloorPrice
    {
        get
        {
            FloorPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FloorPrice val) { FloorPrice = val; }
    public FloorPrice Get(FloorPrice val) { GetField(val); return val; }
    public bool IsSet(FloorPrice val) { return IsSetFloorPrice(); }
    public bool IsSetFloorPrice() { return IsSetField(Tags.FloorPrice); }

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

    public FlexibleIndicator FlexibleIndicator
    {
        get
        {
            FlexibleIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlexibleIndicator val) { FlexibleIndicator = val; }
    public FlexibleIndicator Get(FlexibleIndicator val) { GetField(val); return val; }
    public bool IsSet(FlexibleIndicator val) { return IsSetFlexibleIndicator(); }
    public bool IsSetFlexibleIndicator() { return IsSetField(Tags.FlexibleIndicator); }

    public FlexProductEligibilityIndicator FlexProductEligibilityIndicator
    {
        get
        {
            FlexProductEligibilityIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlexProductEligibilityIndicator val) { FlexProductEligibilityIndicator = val; }
    public FlexProductEligibilityIndicator Get(FlexProductEligibilityIndicator val) { GetField(val); return val; }
    public bool IsSet(FlexProductEligibilityIndicator val) { return IsSetFlexProductEligibilityIndicator(); }
    public bool IsSetFlexProductEligibilityIndicator() { return IsSetField(Tags.FlexProductEligibilityIndicator); }

    public FuturesValuationMethod FuturesValuationMethod
    {
        get
        {
            FuturesValuationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FuturesValuationMethod val) { FuturesValuationMethod = val; }
    public FuturesValuationMethod Get(FuturesValuationMethod val) { GetField(val); return val; }
    public bool IsSet(FuturesValuationMethod val) { return IsSetFuturesValuationMethod(); }
    public bool IsSetFuturesValuationMethod() { return IsSetField(Tags.FuturesValuationMethod); }

    public UnderlyingSymbol UnderlyingSymbol
    {
        get
        {
            UnderlyingSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSymbol val) { UnderlyingSymbol = val; }
    public UnderlyingSymbol Get(UnderlyingSymbol val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }
    public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }

    public UnderlyingSymbolSfx UnderlyingSymbolSfx
    {
        get
        {
            UnderlyingSymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSymbolSfx val) { UnderlyingSymbolSfx = val; }
    public UnderlyingSymbolSfx Get(UnderlyingSymbolSfx val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }
    public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }

    public UnderlyingSecurityID UnderlyingSecurityID
    {
        get
        {
            UnderlyingSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityID val) { UnderlyingSecurityID = val; }
    public UnderlyingSecurityID Get(UnderlyingSecurityID val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }
    public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }

    public UnderlyingSecurityIDSource UnderlyingSecurityIDSource
    {
        get
        {
            UnderlyingSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityIDSource val) { UnderlyingSecurityIDSource = val; }
    public UnderlyingSecurityIDSource Get(UnderlyingSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }
    public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }

    public NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
    {
        get
        {
            NoUnderlyingSecurityAltID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyingSecurityAltID val) { NoUnderlyingSecurityAltID = val; }
    public NoUnderlyingSecurityAltID Get(NoUnderlyingSecurityAltID val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }
    public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }

    public UnderlyingProduct UnderlyingProduct
    {
        get
        {
            UnderlyingProduct val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingProduct val) { UnderlyingProduct = val; }
    public UnderlyingProduct Get(UnderlyingProduct val) { GetField(val); return val; }
    public bool IsSet(UnderlyingProduct val) { return IsSetUnderlyingProduct(); }
    public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }

    public UnderlyingCFICode UnderlyingCFICode
    {
        get
        {
            UnderlyingCFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCFICode val) { UnderlyingCFICode = val; }
    public UnderlyingCFICode Get(UnderlyingCFICode val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }
    public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }

    public UnderlyingSecurityType UnderlyingSecurityType
    {
        get
        {
            UnderlyingSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityType val) { UnderlyingSecurityType = val; }
    public UnderlyingSecurityType Get(UnderlyingSecurityType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }
    public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }

    public UnderlyingSecuritySubType UnderlyingSecuritySubType
    {
        get
        {
            UnderlyingSecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecuritySubType val) { UnderlyingSecuritySubType = val; }
    public UnderlyingSecuritySubType Get(UnderlyingSecuritySubType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }
    public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }

    public UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
    {
        get
        {
            UnderlyingMaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingMaturityMonthYear val) { UnderlyingMaturityMonthYear = val; }
    public UnderlyingMaturityMonthYear Get(UnderlyingMaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }
    public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }

    public UnderlyingMaturityDate UnderlyingMaturityDate
    {
        get
        {
            UnderlyingMaturityDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingMaturityDate val) { UnderlyingMaturityDate = val; }
    public UnderlyingMaturityDate Get(UnderlyingMaturityDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }
    public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }

    public UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
    {
        get
        {
            UnderlyingCouponPaymentDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCouponPaymentDate val) { UnderlyingCouponPaymentDate = val; }
    public UnderlyingCouponPaymentDate Get(UnderlyingCouponPaymentDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }
    public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }

    public UnderlyingIssueDate UnderlyingIssueDate
    {
        get
        {
            UnderlyingIssueDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingIssueDate val) { UnderlyingIssueDate = val; }
    public UnderlyingIssueDate Get(UnderlyingIssueDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }
    public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }

    public UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
    {
        get
        {
            UnderlyingRepoCollateralSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRepoCollateralSecurityType val) { UnderlyingRepoCollateralSecurityType = val; }
    public UnderlyingRepoCollateralSecurityType Get(UnderlyingRepoCollateralSecurityType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }
    public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }

    public UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
    {
        get
        {
            UnderlyingRepurchaseTerm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRepurchaseTerm val) { UnderlyingRepurchaseTerm = val; }
    public UnderlyingRepurchaseTerm Get(UnderlyingRepurchaseTerm val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }
    public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }

    public UnderlyingRepurchaseRate UnderlyingRepurchaseRate
    {
        get
        {
            UnderlyingRepurchaseRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRepurchaseRate val) { UnderlyingRepurchaseRate = val; }
    public UnderlyingRepurchaseRate Get(UnderlyingRepurchaseRate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }
    public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }

    public UnderlyingFactor UnderlyingFactor
    {
        get
        {
            UnderlyingFactor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFactor val) { UnderlyingFactor = val; }
    public UnderlyingFactor Get(UnderlyingFactor val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFactor val) { return IsSetUnderlyingFactor(); }
    public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }

    public UnderlyingCreditRating UnderlyingCreditRating
    {
        get
        {
            UnderlyingCreditRating val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCreditRating val) { UnderlyingCreditRating = val; }
    public UnderlyingCreditRating Get(UnderlyingCreditRating val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }
    public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }

    public UnderlyingInstrRegistry UnderlyingInstrRegistry
    {
        get
        {
            UnderlyingInstrRegistry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingInstrRegistry val) { UnderlyingInstrRegistry = val; }
    public UnderlyingInstrRegistry Get(UnderlyingInstrRegistry val) { GetField(val); return val; }
    public bool IsSet(UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }
    public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }

    public UnderlyingCountryOfIssue UnderlyingCountryOfIssue
    {
        get
        {
            UnderlyingCountryOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCountryOfIssue val) { UnderlyingCountryOfIssue = val; }
    public UnderlyingCountryOfIssue Get(UnderlyingCountryOfIssue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }
    public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }

    public UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
    {
        get
        {
            UnderlyingStateOrProvinceOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStateOrProvinceOfIssue val) { UnderlyingStateOrProvinceOfIssue = val; }
    public UnderlyingStateOrProvinceOfIssue Get(UnderlyingStateOrProvinceOfIssue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }
    public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }

    public UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
    {
        get
        {
            UnderlyingLocaleOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingLocaleOfIssue val) { UnderlyingLocaleOfIssue = val; }
    public UnderlyingLocaleOfIssue Get(UnderlyingLocaleOfIssue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }
    public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }

    public UnderlyingRedemptionDate UnderlyingRedemptionDate
    {
        get
        {
            UnderlyingRedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRedemptionDate val) { UnderlyingRedemptionDate = val; }
    public UnderlyingRedemptionDate Get(UnderlyingRedemptionDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }
    public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }

    public UnderlyingStrikePrice UnderlyingStrikePrice
    {
        get
        {
            UnderlyingStrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStrikePrice val) { UnderlyingStrikePrice = val; }
    public UnderlyingStrikePrice Get(UnderlyingStrikePrice val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }
    public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }

    public UnderlyingStrikeCurrency UnderlyingStrikeCurrency
    {
        get
        {
            UnderlyingStrikeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStrikeCurrency val) { UnderlyingStrikeCurrency = val; }
    public UnderlyingStrikeCurrency Get(UnderlyingStrikeCurrency val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }
    public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }

    public UnderlyingOptAttribute UnderlyingOptAttribute
    {
        get
        {
            UnderlyingOptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingOptAttribute val) { UnderlyingOptAttribute = val; }
    public UnderlyingOptAttribute Get(UnderlyingOptAttribute val) { GetField(val); return val; }
    public bool IsSet(UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }
    public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }

    public UnderlyingContractMultiplier UnderlyingContractMultiplier
    {
        get
        {
            UnderlyingContractMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingContractMultiplier val) { UnderlyingContractMultiplier = val; }
    public UnderlyingContractMultiplier Get(UnderlyingContractMultiplier val) { GetField(val); return val; }
    public bool IsSet(UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }
    public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }

    public UnderlyingCouponRate UnderlyingCouponRate
    {
        get
        {
            UnderlyingCouponRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCouponRate val) { UnderlyingCouponRate = val; }
    public UnderlyingCouponRate Get(UnderlyingCouponRate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }
    public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }

    public UnderlyingSecurityExchange UnderlyingSecurityExchange
    {
        get
        {
            UnderlyingSecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityExchange val) { UnderlyingSecurityExchange = val; }
    public UnderlyingSecurityExchange Get(UnderlyingSecurityExchange val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }
    public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }

    public UnderlyingIssuer UnderlyingIssuer
    {
        get
        {
            UnderlyingIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingIssuer val) { UnderlyingIssuer = val; }
    public UnderlyingIssuer Get(UnderlyingIssuer val) { GetField(val); return val; }
    public bool IsSet(UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }
    public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }

    public EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
    {
        get
        {
            EncodedUnderlyingIssuerLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingIssuerLen val) { EncodedUnderlyingIssuerLen = val; }
    public EncodedUnderlyingIssuerLen Get(EncodedUnderlyingIssuerLen val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }
    public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }

    public EncodedUnderlyingIssuer EncodedUnderlyingIssuer
    {
        get
        {
            EncodedUnderlyingIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingIssuer val) { EncodedUnderlyingIssuer = val; }
    public EncodedUnderlyingIssuer Get(EncodedUnderlyingIssuer val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }
    public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }

    public UnderlyingSecurityDesc UnderlyingSecurityDesc
    {
        get
        {
            UnderlyingSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityDesc val) { UnderlyingSecurityDesc = val; }
    public UnderlyingSecurityDesc Get(UnderlyingSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }
    public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }

    public EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
    {
        get
        {
            EncodedUnderlyingSecurityDescLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingSecurityDescLen val) { EncodedUnderlyingSecurityDescLen = val; }
    public EncodedUnderlyingSecurityDescLen Get(EncodedUnderlyingSecurityDescLen val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }
    public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }

    public EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
    {
        get
        {
            EncodedUnderlyingSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingSecurityDesc val) { EncodedUnderlyingSecurityDesc = val; }
    public EncodedUnderlyingSecurityDesc Get(EncodedUnderlyingSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }
    public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }

    public UnderlyingCPProgram UnderlyingCPProgram
    {
        get
        {
            UnderlyingCPProgram val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCPProgram val) { UnderlyingCPProgram = val; }
    public UnderlyingCPProgram Get(UnderlyingCPProgram val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }
    public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }

    public UnderlyingCPRegType UnderlyingCPRegType
    {
        get
        {
            UnderlyingCPRegType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCPRegType val) { UnderlyingCPRegType = val; }
    public UnderlyingCPRegType Get(UnderlyingCPRegType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }
    public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }

    public UnderlyingCurrency UnderlyingCurrency
    {
        get
        {
            UnderlyingCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCurrency val) { UnderlyingCurrency = val; }
    public UnderlyingCurrency Get(UnderlyingCurrency val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }
    public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }

    public UnderlyingQty UnderlyingQty
    {
        get
        {
            UnderlyingQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingQty val) { UnderlyingQty = val; }
    public UnderlyingQty Get(UnderlyingQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingQty val) { return IsSetUnderlyingQty(); }
    public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }

    public UnderlyingPx UnderlyingPx
    {
        get
        {
            UnderlyingPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPx val) { UnderlyingPx = val; }
    public UnderlyingPx Get(UnderlyingPx val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPx val) { return IsSetUnderlyingPx(); }
    public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }

    public UnderlyingDirtyPrice UnderlyingDirtyPrice
    {
        get
        {
            UnderlyingDirtyPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingDirtyPrice val) { UnderlyingDirtyPrice = val; }
    public UnderlyingDirtyPrice Get(UnderlyingDirtyPrice val) { GetField(val); return val; }
    public bool IsSet(UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }
    public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }

    public UnderlyingEndPrice UnderlyingEndPrice
    {
        get
        {
            UnderlyingEndPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingEndPrice val) { UnderlyingEndPrice = val; }
    public UnderlyingEndPrice Get(UnderlyingEndPrice val) { GetField(val); return val; }
    public bool IsSet(UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }
    public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }

    public UnderlyingStartValue UnderlyingStartValue
    {
        get
        {
            UnderlyingStartValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStartValue val) { UnderlyingStartValue = val; }
    public UnderlyingStartValue Get(UnderlyingStartValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }
    public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }

    public UnderlyingCurrentValue UnderlyingCurrentValue
    {
        get
        {
            UnderlyingCurrentValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCurrentValue val) { UnderlyingCurrentValue = val; }
    public UnderlyingCurrentValue Get(UnderlyingCurrentValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }
    public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }

    public UnderlyingEndValue UnderlyingEndValue
    {
        get
        {
            UnderlyingEndValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingEndValue val) { UnderlyingEndValue = val; }
    public UnderlyingEndValue Get(UnderlyingEndValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }
    public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }

    public NoUnderlyingStips NoUnderlyingStips
    {
        get
        {
            NoUnderlyingStips val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyingStips val) { NoUnderlyingStips = val; }
    public NoUnderlyingStips Get(NoUnderlyingStips val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }
    public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

    public UnderlyingAllocationPercent UnderlyingAllocationPercent
    {
        get
        {
            UnderlyingAllocationPercent val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingAllocationPercent val) { UnderlyingAllocationPercent = val; }
    public UnderlyingAllocationPercent Get(UnderlyingAllocationPercent val) { GetField(val); return val; }
    public bool IsSet(UnderlyingAllocationPercent val) { return IsSetUnderlyingAllocationPercent(); }
    public bool IsSetUnderlyingAllocationPercent() { return IsSetField(Tags.UnderlyingAllocationPercent); }

    public UnderlyingSettlementType UnderlyingSettlementType
    {
        get
        {
            UnderlyingSettlementType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSettlementType val) { UnderlyingSettlementType = val; }
    public UnderlyingSettlementType Get(UnderlyingSettlementType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSettlementType val) { return IsSetUnderlyingSettlementType(); }
    public bool IsSetUnderlyingSettlementType() { return IsSetField(Tags.UnderlyingSettlementType); }

    public UnderlyingCashAmount UnderlyingCashAmount
    {
        get
        {
            UnderlyingCashAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCashAmount val) { UnderlyingCashAmount = val; }
    public UnderlyingCashAmount Get(UnderlyingCashAmount val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCashAmount val) { return IsSetUnderlyingCashAmount(); }
    public bool IsSetUnderlyingCashAmount() { return IsSetField(Tags.UnderlyingCashAmount); }

    public UnderlyingCashType UnderlyingCashType
    {
        get
        {
            UnderlyingCashType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCashType val) { UnderlyingCashType = val; }
    public UnderlyingCashType Get(UnderlyingCashType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCashType val) { return IsSetUnderlyingCashType(); }
    public bool IsSetUnderlyingCashType() { return IsSetField(Tags.UnderlyingCashType); }

    public UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
    {
        get
        {
            UnderlyingUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingUnitOfMeasure val) { UnderlyingUnitOfMeasure = val; }
    public UnderlyingUnitOfMeasure Get(UnderlyingUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnderlyingUnitOfMeasure val) { return IsSetUnderlyingUnitOfMeasure(); }
    public bool IsSetUnderlyingUnitOfMeasure() { return IsSetField(Tags.UnderlyingUnitOfMeasure); }

    public UnderlyingTimeUnit UnderlyingTimeUnit
    {
        get
        {
            UnderlyingTimeUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingTimeUnit val) { UnderlyingTimeUnit = val; }
    public UnderlyingTimeUnit Get(UnderlyingTimeUnit val) { GetField(val); return val; }
    public bool IsSet(UnderlyingTimeUnit val) { return IsSetUnderlyingTimeUnit(); }
    public bool IsSetUnderlyingTimeUnit() { return IsSetField(Tags.UnderlyingTimeUnit); }

    public UnderlyingCapValue UnderlyingCapValue
    {
        get
        {
            UnderlyingCapValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCapValue val) { UnderlyingCapValue = val; }
    public UnderlyingCapValue Get(UnderlyingCapValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCapValue val) { return IsSetUnderlyingCapValue(); }
    public bool IsSetUnderlyingCapValue() { return IsSetField(Tags.UnderlyingCapValue); }

    public NoUndlyInstrumentParties NoUndlyInstrumentParties
    {
        get
        {
            NoUndlyInstrumentParties val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUndlyInstrumentParties val) { NoUndlyInstrumentParties = val; }
    public NoUndlyInstrumentParties Get(NoUndlyInstrumentParties val) { GetField(val); return val; }
    public bool IsSet(NoUndlyInstrumentParties val) { return IsSetNoUndlyInstrumentParties(); }
    public bool IsSetNoUndlyInstrumentParties() { return IsSetField(Tags.NoUndlyInstrumentParties); }

    public UnderlyingSettlMethod UnderlyingSettlMethod
    {
        get
        {
            UnderlyingSettlMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSettlMethod val) { UnderlyingSettlMethod = val; }
    public UnderlyingSettlMethod Get(UnderlyingSettlMethod val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSettlMethod val) { return IsSetUnderlyingSettlMethod(); }
    public bool IsSetUnderlyingSettlMethod() { return IsSetField(Tags.UnderlyingSettlMethod); }

    public UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
    {
        get
        {
            UnderlyingAdjustedQuantity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingAdjustedQuantity val) { UnderlyingAdjustedQuantity = val; }
    public UnderlyingAdjustedQuantity Get(UnderlyingAdjustedQuantity val) { GetField(val); return val; }
    public bool IsSet(UnderlyingAdjustedQuantity val) { return IsSetUnderlyingAdjustedQuantity(); }
    public bool IsSetUnderlyingAdjustedQuantity() { return IsSetField(Tags.UnderlyingAdjustedQuantity); }

    public UnderlyingFXRate UnderlyingFXRate
    {
        get
        {
            UnderlyingFXRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFXRate val) { UnderlyingFXRate = val; }
    public UnderlyingFXRate Get(UnderlyingFXRate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFXRate val) { return IsSetUnderlyingFXRate(); }
    public bool IsSetUnderlyingFXRate() { return IsSetField(Tags.UnderlyingFXRate); }

    public UnderlyingFXRateCalc UnderlyingFXRateCalc
    {
        get
        {
            UnderlyingFXRateCalc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFXRateCalc val) { UnderlyingFXRateCalc = val; }
    public UnderlyingFXRateCalc Get(UnderlyingFXRateCalc val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFXRateCalc val) { return IsSetUnderlyingFXRateCalc(); }
    public bool IsSetUnderlyingFXRateCalc() { return IsSetField(Tags.UnderlyingFXRateCalc); }

    public UnderlyingMaturityTime UnderlyingMaturityTime
    {
        get
        {
            UnderlyingMaturityTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingMaturityTime val) { UnderlyingMaturityTime = val; }
    public UnderlyingMaturityTime Get(UnderlyingMaturityTime val) { GetField(val); return val; }
    public bool IsSet(UnderlyingMaturityTime val) { return IsSetUnderlyingMaturityTime(); }
    public bool IsSetUnderlyingMaturityTime() { return IsSetField(Tags.UnderlyingMaturityTime); }

    public UnderlyingPutOrCall UnderlyingPutOrCall
    {
        get
        {
            UnderlyingPutOrCall val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPutOrCall val) { UnderlyingPutOrCall = val; }
    public UnderlyingPutOrCall Get(UnderlyingPutOrCall val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }
    public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }

    public UnderlyingExerciseStyle UnderlyingExerciseStyle
    {
        get
        {
            UnderlyingExerciseStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingExerciseStyle val) { UnderlyingExerciseStyle = val; }
    public UnderlyingExerciseStyle Get(UnderlyingExerciseStyle val) { GetField(val); return val; }
    public bool IsSet(UnderlyingExerciseStyle val) { return IsSetUnderlyingExerciseStyle(); }
    public bool IsSetUnderlyingExerciseStyle() { return IsSetField(Tags.UnderlyingExerciseStyle); }

    public UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
    {
        get
        {
            UnderlyingUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingUnitOfMeasureQty val) { UnderlyingUnitOfMeasureQty = val; }
    public UnderlyingUnitOfMeasureQty Get(UnderlyingUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingUnitOfMeasureQty val) { return IsSetUnderlyingUnitOfMeasureQty(); }
    public bool IsSetUnderlyingUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingUnitOfMeasureQty); }

    public UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
    {
        get
        {
            UnderlyingPriceUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPriceUnitOfMeasure val) { UnderlyingPriceUnitOfMeasure = val; }
    public UnderlyingPriceUnitOfMeasure Get(UnderlyingPriceUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPriceUnitOfMeasure val) { return IsSetUnderlyingPriceUnitOfMeasure(); }
    public bool IsSetUnderlyingPriceUnitOfMeasure() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasure); }

    public UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
    {
        get
        {
            UnderlyingPriceUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPriceUnitOfMeasureQty val) { UnderlyingPriceUnitOfMeasureQty = val; }
    public UnderlyingPriceUnitOfMeasureQty Get(UnderlyingPriceUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPriceUnitOfMeasureQty val) { return IsSetUnderlyingPriceUnitOfMeasureQty(); }
    public bool IsSetUnderlyingPriceUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty); }

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

    public NoNotAffectedOrders NoNotAffectedOrders
    {
        get
        {
            NoNotAffectedOrders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoNotAffectedOrders val) { NoNotAffectedOrders = val; }
    public NoNotAffectedOrders Get(NoNotAffectedOrders val) { GetField(val); return val; }
    public bool IsSet(NoNotAffectedOrders val) { return IsSetNoNotAffectedOrders(); }
    public bool IsSetNoNotAffectedOrders() { return IsSetField(Tags.NoNotAffectedOrders); }

    public class NoAffectedOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.OrigClOrdID, Tags.AffectedOrderID, Tags.AffectedSecondaryOrderID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.OrigClOrdID, Tags.AffectedOrderID, Tags.AffectedSecondaryOrderID, 0};

        public NoAffectedOrdersGroup()
          : base(Tags.NoAffectedOrders, Tags.OrigClOrdID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoAffectedOrdersGroup();
            clone.CopyStateFrom(this);
            return clone;
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

        public AffectedOrderID AffectedOrderID
        {
            get
            {
                AffectedOrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AffectedOrderID val) { AffectedOrderID = val; }
        public AffectedOrderID Get(AffectedOrderID val) { GetField(val); return val; }
        public bool IsSet(AffectedOrderID val) { return IsSetAffectedOrderID(); }
        public bool IsSetAffectedOrderID() { return IsSetField(Tags.AffectedOrderID); }

        public AffectedSecondaryOrderID AffectedSecondaryOrderID
        {
            get
            {
                AffectedSecondaryOrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AffectedSecondaryOrderID val) { AffectedSecondaryOrderID = val; }
        public AffectedSecondaryOrderID Get(AffectedSecondaryOrderID val) { GetField(val); return val; }
        public bool IsSet(AffectedSecondaryOrderID val) { return IsSetAffectedSecondaryOrderID(); }
        public bool IsSetAffectedSecondaryOrderID() { return IsSetField(Tags.AffectedSecondaryOrderID); }
    }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

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

        public NoPartySubIDs NoPartySubIDs
        {
            get
            {
                NoPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
        public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup()
              : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

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

            public PartySubIDType PartySubIDType
            {
                get
                {
                    PartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubIDType val) { PartySubIDType = val; }
            public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
            public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
            public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
        }
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

    public class NoEventsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};

        public NoEventsGroup()
          : base(Tags.NoEvents, Tags.EventType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoEventsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public EventType EventType
        {
            get
            {
                EventType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventType val) { EventType = val; }
        public EventType Get(EventType val) { GetField(val); return val; }
        public bool IsSet(EventType val) { return IsSetEventType(); }
        public bool IsSetEventType() { return IsSetField(Tags.EventType); }

        public EventDate EventDate
        {
            get
            {
                EventDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventDate val) { EventDate = val; }
        public EventDate Get(EventDate val) { GetField(val); return val; }
        public bool IsSet(EventDate val) { return IsSetEventDate(); }
        public bool IsSetEventDate() { return IsSetField(Tags.EventDate); }

        public EventPx EventPx
        {
            get
            {
                EventPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventPx val) { EventPx = val; }
        public EventPx Get(EventPx val) { GetField(val); return val; }
        public bool IsSet(EventPx val) { return IsSetEventPx(); }
        public bool IsSetEventPx() { return IsSetField(Tags.EventPx); }

        public EventText EventText
        {
            get
            {
                EventText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventText val) { EventText = val; }
        public EventText Get(EventText val) { GetField(val); return val; }
        public bool IsSet(EventText val) { return IsSetEventText(); }
        public bool IsSetEventText() { return IsSetField(Tags.EventText); }

        public EventTime EventTime
        {
            get
            {
                EventTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EventTime val) { EventTime = val; }
        public EventTime Get(EventTime val) { GetField(val); return val; }
        public bool IsSet(EventTime val) { return IsSetEventTime(); }
        public bool IsSetEventTime() { return IsSetField(Tags.EventTime); }
    }

    public class NoInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};

        public NoInstrumentPartiesGroup()
          : base(Tags.NoInstrumentParties, Tags.InstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public InstrumentPartyID InstrumentPartyID
        {
            get
            {
                InstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyID val) { InstrumentPartyID = val; }
        public InstrumentPartyID Get(InstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyID val) { return IsSetInstrumentPartyID(); }
        public bool IsSetInstrumentPartyID() { return IsSetField(Tags.InstrumentPartyID); }

        public InstrumentPartyIDSource InstrumentPartyIDSource
        {
            get
            {
                InstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyIDSource val) { InstrumentPartyIDSource = val; }
        public InstrumentPartyIDSource Get(InstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyIDSource val) { return IsSetInstrumentPartyIDSource(); }
        public bool IsSetInstrumentPartyIDSource() { return IsSetField(Tags.InstrumentPartyIDSource); }

        public InstrumentPartyRole InstrumentPartyRole
        {
            get
            {
                InstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrumentPartyRole val) { InstrumentPartyRole = val; }
        public InstrumentPartyRole Get(InstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(InstrumentPartyRole val) { return IsSetInstrumentPartyRole(); }
        public bool IsSetInstrumentPartyRole() { return IsSetField(Tags.InstrumentPartyRole); }

        public NoInstrumentPartySubIDs NoInstrumentPartySubIDs
        {
            get
            {
                NoInstrumentPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoInstrumentPartySubIDs val) { NoInstrumentPartySubIDs = val; }
        public NoInstrumentPartySubIDs Get(NoInstrumentPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoInstrumentPartySubIDs val) { return IsSetNoInstrumentPartySubIDs(); }
        public bool IsSetNoInstrumentPartySubIDs() { return IsSetField(Tags.NoInstrumentPartySubIDs); }

        public class NoInstrumentPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};

            public NoInstrumentPartySubIDsGroup()
              : base(Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public InstrumentPartySubID InstrumentPartySubID
            {
                get
                {
                    InstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartySubID val) { InstrumentPartySubID = val; }
            public InstrumentPartySubID Get(InstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartySubID val) { return IsSetInstrumentPartySubID(); }
            public bool IsSetInstrumentPartySubID() { return IsSetField(Tags.InstrumentPartySubID); }

            public InstrumentPartySubIDType InstrumentPartySubIDType
            {
                get
                {
                    InstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartySubIDType val) { InstrumentPartySubIDType = val; }
            public InstrumentPartySubIDType Get(InstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartySubIDType val) { return IsSetInstrumentPartySubIDType(); }
            public bool IsSetInstrumentPartySubIDType() { return IsSetField(Tags.InstrumentPartySubIDType); }
        }
    }

    public class NoUnderlyingSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

        public NoUnderlyingSecurityAltIDGroup()
          : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingSecurityAltIDGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UnderlyingSecurityAltID UnderlyingSecurityAltID
        {
            get
            {
                UnderlyingSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityAltID val) { UnderlyingSecurityAltID = val; }
        public UnderlyingSecurityAltID Get(UnderlyingSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }
        public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }

        public UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
        {
            get
            {
                UnderlyingSecurityAltIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityAltIDSource val) { UnderlyingSecurityAltIDSource = val; }
        public UnderlyingSecurityAltIDSource Get(UnderlyingSecurityAltIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }
        public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }
    }

    public class NoUnderlyingStipsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

        public NoUnderlyingStipsGroup()
          : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingStipsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UnderlyingStipType UnderlyingStipType
        {
            get
            {
                UnderlyingStipType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStipType val) { UnderlyingStipType = val; }
        public UnderlyingStipType Get(UnderlyingStipType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStipType val) { return IsSetUnderlyingStipType(); }
        public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }

        public UnderlyingStipValue UnderlyingStipValue
        {
            get
            {
                UnderlyingStipValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStipValue val) { UnderlyingStipValue = val; }
        public UnderlyingStipValue Get(UnderlyingStipValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }
        public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }
    }

    public class NoUndlyInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

        public NoUndlyInstrumentPartiesGroup()
          : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUndlyInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UndlyInstrumentPartyID UndlyInstrumentPartyID
        {
            get
            {
                UndlyInstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UndlyInstrumentPartyID val) { UndlyInstrumentPartyID = val; }
        public UndlyInstrumentPartyID Get(UndlyInstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(UndlyInstrumentPartyID val) { return IsSetUndlyInstrumentPartyID(); }
        public bool IsSetUndlyInstrumentPartyID() { return IsSetField(Tags.UndlyInstrumentPartyID); }

        public UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
        {
            get
            {
                UndlyInstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UndlyInstrumentPartyIDSource val) { UndlyInstrumentPartyIDSource = val; }
        public UndlyInstrumentPartyIDSource Get(UndlyInstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(UndlyInstrumentPartyIDSource val) { return IsSetUndlyInstrumentPartyIDSource(); }
        public bool IsSetUndlyInstrumentPartyIDSource() { return IsSetField(Tags.UndlyInstrumentPartyIDSource); }

        public UndlyInstrumentPartyRole UndlyInstrumentPartyRole
        {
            get
            {
                UndlyInstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UndlyInstrumentPartyRole val) { UndlyInstrumentPartyRole = val; }
        public UndlyInstrumentPartyRole Get(UndlyInstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(UndlyInstrumentPartyRole val) { return IsSetUndlyInstrumentPartyRole(); }
        public bool IsSetUndlyInstrumentPartyRole() { return IsSetField(Tags.UndlyInstrumentPartyRole); }

        public NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
        {
            get
            {
                NoUndlyInstrumentPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUndlyInstrumentPartySubIDs val) { NoUndlyInstrumentPartySubIDs = val; }
        public NoUndlyInstrumentPartySubIDs Get(NoUndlyInstrumentPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoUndlyInstrumentPartySubIDs val) { return IsSetNoUndlyInstrumentPartySubIDs(); }
        public bool IsSetNoUndlyInstrumentPartySubIDs() { return IsSetField(Tags.NoUndlyInstrumentPartySubIDs); }

        public class NoUndlyInstrumentPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup()
              : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UndlyInstrumentPartySubID UndlyInstrumentPartySubID
            {
                get
                {
                    UndlyInstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartySubID val) { UndlyInstrumentPartySubID = val; }
            public UndlyInstrumentPartySubID Get(UndlyInstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartySubID val) { return IsSetUndlyInstrumentPartySubID(); }
            public bool IsSetUndlyInstrumentPartySubID() { return IsSetField(Tags.UndlyInstrumentPartySubID); }

            public UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
            {
                get
                {
                    UndlyInstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartySubIDType val) { UndlyInstrumentPartySubIDType = val; }
            public UndlyInstrumentPartySubIDType Get(UndlyInstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartySubIDType val) { return IsSetUndlyInstrumentPartySubIDType(); }
            public bool IsSetUndlyInstrumentPartySubIDType() { return IsSetField(Tags.UndlyInstrumentPartySubIDType); }
        }
    }

    public class NoNotAffectedOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.NotAffOrigClOrdID, Tags.NotAffectedOrderID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.NotAffOrigClOrdID, Tags.NotAffectedOrderID, 0};

        public NoNotAffectedOrdersGroup()
          : base(Tags.NoNotAffectedOrders, Tags.NotAffOrigClOrdID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoNotAffectedOrdersGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public NotAffOrigClOrdID NotAffOrigClOrdID
        {
            get
            {
                NotAffOrigClOrdID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NotAffOrigClOrdID val) { NotAffOrigClOrdID = val; }
        public NotAffOrigClOrdID Get(NotAffOrigClOrdID val) { GetField(val); return val; }
        public bool IsSet(NotAffOrigClOrdID val) { return IsSetNotAffOrigClOrdID(); }
        public bool IsSetNotAffOrigClOrdID() { return IsSetField(Tags.NotAffOrigClOrdID); }

        public NotAffectedOrderID NotAffectedOrderID
        {
            get
            {
                NotAffectedOrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NotAffectedOrderID val) { NotAffectedOrderID = val; }
        public NotAffectedOrderID Get(NotAffectedOrderID val) { GetField(val); return val; }
        public bool IsSet(NotAffectedOrderID val) { return IsSetNotAffectedOrderID(); }
        public bool IsSetNotAffectedOrderID() { return IsSetField(Tags.NotAffectedOrderID); }
    }
}
