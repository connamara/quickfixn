// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class AllocationReport : Message
{
    public const string MsgType = "AS";

    public AllocationReport() : base()
    {
        Header.SetField(new MsgType("AS"));
    }

    public AllocationReport(
            AllocReportID aAllocReportID,
            AllocTransType aAllocTransType,
            AllocReportType aAllocReportType,
            AllocStatus aAllocStatus,
            Side aSide,
            Quantity aQuantity,
            AvgPx aAvgPx,
            TradeDate aTradeDate
        ) : this()
    {
        AllocReportID = aAllocReportID;
        AllocTransType = aAllocTransType;
        AllocReportType = aAllocReportType;
        AllocStatus = aAllocStatus;
        Side = aSide;
        Quantity = aQuantity;
        AvgPx = aAvgPx;
        TradeDate = aTradeDate;
    }

    public AllocReportID AllocReportID
    {
        get
        {
            AllocReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocReportID val) { AllocReportID = val; }
    public AllocReportID Get(AllocReportID val) { GetField(val); return val; }
    public bool IsSet(AllocReportID val) { return IsSetAllocReportID(); }
    public bool IsSetAllocReportID() { return IsSetField(Tags.AllocReportID); }

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

    public AllocReportRefID AllocReportRefID
    {
        get
        {
            AllocReportRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocReportRefID val) { AllocReportRefID = val; }
    public AllocReportRefID Get(AllocReportRefID val) { GetField(val); return val; }
    public bool IsSet(AllocReportRefID val) { return IsSetAllocReportRefID(); }
    public bool IsSetAllocReportRefID() { return IsSetField(Tags.AllocReportRefID); }

    public AllocCancReplaceReason AllocCancReplaceReason
    {
        get
        {
            AllocCancReplaceReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocCancReplaceReason val) { AllocCancReplaceReason = val; }
    public AllocCancReplaceReason Get(AllocCancReplaceReason val) { GetField(val); return val; }
    public bool IsSet(AllocCancReplaceReason val) { return IsSetAllocCancReplaceReason(); }
    public bool IsSetAllocCancReplaceReason() { return IsSetField(Tags.AllocCancReplaceReason); }

    public SecondaryAllocID SecondaryAllocID
    {
        get
        {
            SecondaryAllocID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryAllocID val) { SecondaryAllocID = val; }
    public SecondaryAllocID Get(SecondaryAllocID val) { GetField(val); return val; }
    public bool IsSet(SecondaryAllocID val) { return IsSetSecondaryAllocID(); }
    public bool IsSetSecondaryAllocID() { return IsSetField(Tags.SecondaryAllocID); }

    public AllocReportType AllocReportType
    {
        get
        {
            AllocReportType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocReportType val) { AllocReportType = val; }
    public AllocReportType Get(AllocReportType val) { GetField(val); return val; }
    public bool IsSet(AllocReportType val) { return IsSetAllocReportType(); }
    public bool IsSetAllocReportType() { return IsSetField(Tags.AllocReportType); }

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

    public AllocIntermedReqType AllocIntermedReqType
    {
        get
        {
            AllocIntermedReqType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocIntermedReqType val) { AllocIntermedReqType = val; }
    public AllocIntermedReqType Get(AllocIntermedReqType val) { GetField(val); return val; }
    public bool IsSet(AllocIntermedReqType val) { return IsSetAllocIntermedReqType(); }
    public bool IsSetAllocIntermedReqType() { return IsSetField(Tags.AllocIntermedReqType); }

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

    public AllocNoOrdersType AllocNoOrdersType
    {
        get
        {
            AllocNoOrdersType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AllocNoOrdersType val) { AllocNoOrdersType = val; }
    public AllocNoOrdersType Get(AllocNoOrdersType val) { GetField(val); return val; }
    public bool IsSet(AllocNoOrdersType val) { return IsSetAllocNoOrdersType(); }
    public bool IsSetAllocNoOrdersType() { return IsSetField(Tags.AllocNoOrdersType); }

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

    public PreviouslyReported PreviouslyReported
    {
        get
        {
            PreviouslyReported val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PreviouslyReported val) { PreviouslyReported = val; }
    public PreviouslyReported Get(PreviouslyReported val) { GetField(val); return val; }
    public bool IsSet(PreviouslyReported val) { return IsSetPreviouslyReported(); }
    public bool IsSetPreviouslyReported() { return IsSetField(Tags.PreviouslyReported); }

    public ReversalIndicator ReversalIndicator
    {
        get
        {
            ReversalIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReversalIndicator val) { ReversalIndicator = val; }
    public ReversalIndicator Get(ReversalIndicator val) { GetField(val); return val; }
    public bool IsSet(ReversalIndicator val) { return IsSetReversalIndicator(); }
    public bool IsSetReversalIndicator() { return IsSetField(Tags.ReversalIndicator); }

    public MatchType MatchType
    {
        get
        {
            MatchType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MatchType val) { MatchType = val; }
    public MatchType Get(MatchType val) { GetField(val); return val; }
    public bool IsSet(MatchType val) { return IsSetMatchType(); }
    public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }

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

    public DeliveryForm DeliveryForm
    {
        get
        {
            DeliveryForm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DeliveryForm val) { DeliveryForm = val; }
    public DeliveryForm Get(DeliveryForm val) { GetField(val); return val; }
    public bool IsSet(DeliveryForm val) { return IsSetDeliveryForm(); }
    public bool IsSetDeliveryForm() { return IsSetField(Tags.DeliveryForm); }

    public PctAtRisk PctAtRisk
    {
        get
        {
            PctAtRisk val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PctAtRisk val) { PctAtRisk = val; }
    public PctAtRisk Get(PctAtRisk val) { GetField(val); return val; }
    public bool IsSet(PctAtRisk val) { return IsSetPctAtRisk(); }
    public bool IsSetPctAtRisk() { return IsSetField(Tags.PctAtRisk); }

    public NoInstrAttrib NoInstrAttrib
    {
        get
        {
            NoInstrAttrib val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoInstrAttrib val) { NoInstrAttrib = val; }
    public NoInstrAttrib Get(NoInstrAttrib val) { GetField(val); return val; }
    public bool IsSet(NoInstrAttrib val) { return IsSetNoInstrAttrib(); }
    public bool IsSetNoInstrAttrib() { return IsSetField(Tags.NoInstrAttrib); }

    public AgreementDesc AgreementDesc
    {
        get
        {
            AgreementDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementDesc val) { AgreementDesc = val; }
    public AgreementDesc Get(AgreementDesc val) { GetField(val); return val; }
    public bool IsSet(AgreementDesc val) { return IsSetAgreementDesc(); }
    public bool IsSetAgreementDesc() { return IsSetField(Tags.AgreementDesc); }

    public AgreementID AgreementID
    {
        get
        {
            AgreementID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementID val) { AgreementID = val; }
    public AgreementID Get(AgreementID val) { GetField(val); return val; }
    public bool IsSet(AgreementID val) { return IsSetAgreementID(); }
    public bool IsSetAgreementID() { return IsSetField(Tags.AgreementID); }

    public AgreementDate AgreementDate
    {
        get
        {
            AgreementDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementDate val) { AgreementDate = val; }
    public AgreementDate Get(AgreementDate val) { GetField(val); return val; }
    public bool IsSet(AgreementDate val) { return IsSetAgreementDate(); }
    public bool IsSetAgreementDate() { return IsSetField(Tags.AgreementDate); }

    public AgreementCurrency AgreementCurrency
    {
        get
        {
            AgreementCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AgreementCurrency val) { AgreementCurrency = val; }
    public AgreementCurrency Get(AgreementCurrency val) { GetField(val); return val; }
    public bool IsSet(AgreementCurrency val) { return IsSetAgreementCurrency(); }
    public bool IsSetAgreementCurrency() { return IsSetField(Tags.AgreementCurrency); }

    public TerminationType TerminationType
    {
        get
        {
            TerminationType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TerminationType val) { TerminationType = val; }
    public TerminationType Get(TerminationType val) { GetField(val); return val; }
    public bool IsSet(TerminationType val) { return IsSetTerminationType(); }
    public bool IsSetTerminationType() { return IsSetField(Tags.TerminationType); }

    public StartDate StartDate
    {
        get
        {
            StartDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StartDate val) { StartDate = val; }
    public StartDate Get(StartDate val) { GetField(val); return val; }
    public bool IsSet(StartDate val) { return IsSetStartDate(); }
    public bool IsSetStartDate() { return IsSetField(Tags.StartDate); }

    public EndDate EndDate
    {
        get
        {
            EndDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndDate val) { EndDate = val; }
    public EndDate Get(EndDate val) { GetField(val); return val; }
    public bool IsSet(EndDate val) { return IsSetEndDate(); }
    public bool IsSetEndDate() { return IsSetField(Tags.EndDate); }

    public DeliveryType DeliveryType
    {
        get
        {
            DeliveryType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DeliveryType val) { DeliveryType = val; }
    public DeliveryType Get(DeliveryType val) { GetField(val); return val; }
    public bool IsSet(DeliveryType val) { return IsSetDeliveryType(); }
    public bool IsSetDeliveryType() { return IsSetField(Tags.DeliveryType); }

    public MarginRatio MarginRatio
    {
        get
        {
            MarginRatio val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarginRatio val) { MarginRatio = val; }
    public MarginRatio Get(MarginRatio val) { GetField(val); return val; }
    public bool IsSet(MarginRatio val) { return IsSetMarginRatio(); }
    public bool IsSetMarginRatio() { return IsSetField(Tags.MarginRatio); }

    public NoUnderlyings NoUnderlyings
    {
        get
        {
            NoUnderlyings val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyings val) { NoUnderlyings = val; }
    public NoUnderlyings Get(NoUnderlyings val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyings val) { return IsSetNoUnderlyings(); }
    public bool IsSetNoUnderlyings() { return IsSetField(Tags.NoUnderlyings); }

    public NoLegs NoLegs
    {
        get
        {
            NoLegs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoLegs val) { NoLegs = val; }
    public NoLegs Get(NoLegs val) { GetField(val); return val; }
    public bool IsSet(NoLegs val) { return IsSetNoLegs(); }
    public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }

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

    public QtyType QtyType
    {
        get
        {
            QtyType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QtyType val) { QtyType = val; }
    public QtyType Get(QtyType val) { GetField(val); return val; }
    public bool IsSet(QtyType val) { return IsSetQtyType(); }
    public bool IsSetQtyType() { return IsSetField(Tags.QtyType); }

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

    public AvgParPx AvgParPx
    {
        get
        {
            AvgParPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgParPx val) { AvgParPx = val; }
    public AvgParPx Get(AvgParPx val) { GetField(val); return val; }
    public bool IsSet(AvgParPx val) { return IsSetAvgParPx(); }
    public bool IsSetAvgParPx() { return IsSetField(Tags.AvgParPx); }

    public Spread Spread
    {
        get
        {
            Spread val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Spread val) { Spread = val; }
    public Spread Get(Spread val) { GetField(val); return val; }
    public bool IsSet(Spread val) { return IsSetSpread(); }
    public bool IsSetSpread() { return IsSetField(Tags.Spread); }

    public BenchmarkCurveCurrency BenchmarkCurveCurrency
    {
        get
        {
            BenchmarkCurveCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurveCurrency val) { BenchmarkCurveCurrency = val; }
    public BenchmarkCurveCurrency Get(BenchmarkCurveCurrency val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }
    public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }

    public BenchmarkCurveName BenchmarkCurveName
    {
        get
        {
            BenchmarkCurveName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurveName val) { BenchmarkCurveName = val; }
    public BenchmarkCurveName Get(BenchmarkCurveName val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }
    public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }

    public BenchmarkCurvePoint BenchmarkCurvePoint
    {
        get
        {
            BenchmarkCurvePoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkCurvePoint val) { BenchmarkCurvePoint = val; }
    public BenchmarkCurvePoint Get(BenchmarkCurvePoint val) { GetField(val); return val; }
    public bool IsSet(BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }
    public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }

    public BenchmarkPrice BenchmarkPrice
    {
        get
        {
            BenchmarkPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkPrice val) { BenchmarkPrice = val; }
    public BenchmarkPrice Get(BenchmarkPrice val) { GetField(val); return val; }
    public bool IsSet(BenchmarkPrice val) { return IsSetBenchmarkPrice(); }
    public bool IsSetBenchmarkPrice() { return IsSetField(Tags.BenchmarkPrice); }

    public BenchmarkPriceType BenchmarkPriceType
    {
        get
        {
            BenchmarkPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkPriceType val) { BenchmarkPriceType = val; }
    public BenchmarkPriceType Get(BenchmarkPriceType val) { GetField(val); return val; }
    public bool IsSet(BenchmarkPriceType val) { return IsSetBenchmarkPriceType(); }
    public bool IsSetBenchmarkPriceType() { return IsSetField(Tags.BenchmarkPriceType); }

    public BenchmarkSecurityID BenchmarkSecurityID
    {
        get
        {
            BenchmarkSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityID val) { BenchmarkSecurityID = val; }
    public BenchmarkSecurityID Get(BenchmarkSecurityID val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityID val) { return IsSetBenchmarkSecurityID(); }
    public bool IsSetBenchmarkSecurityID() { return IsSetField(Tags.BenchmarkSecurityID); }

    public BenchmarkSecurityIDSource BenchmarkSecurityIDSource
    {
        get
        {
            BenchmarkSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BenchmarkSecurityIDSource val) { BenchmarkSecurityIDSource = val; }
    public BenchmarkSecurityIDSource Get(BenchmarkSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(BenchmarkSecurityIDSource val) { return IsSetBenchmarkSecurityIDSource(); }
    public bool IsSetBenchmarkSecurityIDSource() { return IsSetField(Tags.BenchmarkSecurityIDSource); }

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

    public AvgPxPrecision AvgPxPrecision
    {
        get
        {
            AvgPxPrecision val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPxPrecision val) { AvgPxPrecision = val; }
    public AvgPxPrecision Get(AvgPxPrecision val) { GetField(val); return val; }
    public bool IsSet(AvgPxPrecision val) { return IsSetAvgPxPrecision(); }
    public bool IsSetAvgPxPrecision() { return IsSetField(Tags.AvgPxPrecision); }

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

    public SettlType SettlType
    {
        get
        {
            SettlType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlType val) { SettlType = val; }
    public SettlType Get(SettlType val) { GetField(val); return val; }
    public bool IsSet(SettlType val) { return IsSetSettlType(); }
    public bool IsSetSettlType() { return IsSetField(Tags.SettlType); }

    public SettlDate SettlDate
    {
        get
        {
            SettlDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlDate val) { SettlDate = val; }
    public SettlDate Get(SettlDate val) { GetField(val); return val; }
    public bool IsSet(SettlDate val) { return IsSetSettlDate(); }
    public bool IsSetSettlDate() { return IsSetField(Tags.SettlDate); }

    public BookingType BookingType
    {
        get
        {
            BookingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingType val) { BookingType = val; }
    public BookingType Get(BookingType val) { GetField(val); return val; }
    public bool IsSet(BookingType val) { return IsSetBookingType(); }
    public bool IsSetBookingType() { return IsSetField(Tags.BookingType); }

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

    public AutoAcceptIndicator AutoAcceptIndicator
    {
        get
        {
            AutoAcceptIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AutoAcceptIndicator val) { AutoAcceptIndicator = val; }
    public AutoAcceptIndicator Get(AutoAcceptIndicator val) { GetField(val); return val; }
    public bool IsSet(AutoAcceptIndicator val) { return IsSetAutoAcceptIndicator(); }
    public bool IsSetAutoAcceptIndicator() { return IsSetField(Tags.AutoAcceptIndicator); }

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

    public InterestAtMaturity InterestAtMaturity
    {
        get
        {
            InterestAtMaturity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(InterestAtMaturity val) { InterestAtMaturity = val; }
    public InterestAtMaturity Get(InterestAtMaturity val) { GetField(val); return val; }
    public bool IsSet(InterestAtMaturity val) { return IsSetInterestAtMaturity(); }
    public bool IsSetInterestAtMaturity() { return IsSetField(Tags.InterestAtMaturity); }

    public EndAccruedInterestAmt EndAccruedInterestAmt
    {
        get
        {
            EndAccruedInterestAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndAccruedInterestAmt val) { EndAccruedInterestAmt = val; }
    public EndAccruedInterestAmt Get(EndAccruedInterestAmt val) { GetField(val); return val; }
    public bool IsSet(EndAccruedInterestAmt val) { return IsSetEndAccruedInterestAmt(); }
    public bool IsSetEndAccruedInterestAmt() { return IsSetField(Tags.EndAccruedInterestAmt); }

    public StartCash StartCash
    {
        get
        {
            StartCash val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StartCash val) { StartCash = val; }
    public StartCash Get(StartCash val) { GetField(val); return val; }
    public bool IsSet(StartCash val) { return IsSetStartCash(); }
    public bool IsSetStartCash() { return IsSetField(Tags.StartCash); }

    public EndCash EndCash
    {
        get
        {
            EndCash val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EndCash val) { EndCash = val; }
    public EndCash Get(EndCash val) { GetField(val); return val; }
    public bool IsSet(EndCash val) { return IsSetEndCash(); }
    public bool IsSetEndCash() { return IsSetField(Tags.EndCash); }

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

    public NoStipulations NoStipulations
    {
        get
        {
            NoStipulations val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoStipulations val) { NoStipulations = val; }
    public NoStipulations Get(NoStipulations val) { GetField(val); return val; }
    public bool IsSet(NoStipulations val) { return IsSetNoStipulations(); }
    public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }

    public YieldType YieldType
    {
        get
        {
            YieldType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldType val) { YieldType = val; }
    public YieldType Get(YieldType val) { GetField(val); return val; }
    public bool IsSet(YieldType val) { return IsSetYieldType(); }
    public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }

    public Yield Yield
    {
        get
        {
            Yield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Yield val) { Yield = val; }
    public Yield Get(Yield val) { GetField(val); return val; }
    public bool IsSet(Yield val) { return IsSetYield(); }
    public bool IsSetYield() { return IsSetField(Tags.Yield); }

    public YieldCalcDate YieldCalcDate
    {
        get
        {
            YieldCalcDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldCalcDate val) { YieldCalcDate = val; }
    public YieldCalcDate Get(YieldCalcDate val) { GetField(val); return val; }
    public bool IsSet(YieldCalcDate val) { return IsSetYieldCalcDate(); }
    public bool IsSetYieldCalcDate() { return IsSetField(Tags.YieldCalcDate); }

    public YieldRedemptionDate YieldRedemptionDate
    {
        get
        {
            YieldRedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionDate val) { YieldRedemptionDate = val; }
    public YieldRedemptionDate Get(YieldRedemptionDate val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionDate val) { return IsSetYieldRedemptionDate(); }
    public bool IsSetYieldRedemptionDate() { return IsSetField(Tags.YieldRedemptionDate); }

    public YieldRedemptionPrice YieldRedemptionPrice
    {
        get
        {
            YieldRedemptionPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionPrice val) { YieldRedemptionPrice = val; }
    public YieldRedemptionPrice Get(YieldRedemptionPrice val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionPrice val) { return IsSetYieldRedemptionPrice(); }
    public bool IsSetYieldRedemptionPrice() { return IsSetField(Tags.YieldRedemptionPrice); }

    public YieldRedemptionPriceType YieldRedemptionPriceType
    {
        get
        {
            YieldRedemptionPriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(YieldRedemptionPriceType val) { YieldRedemptionPriceType = val; }
    public YieldRedemptionPriceType Get(YieldRedemptionPriceType val) { GetField(val); return val; }
    public bool IsSet(YieldRedemptionPriceType val) { return IsSetYieldRedemptionPriceType(); }
    public bool IsSetYieldRedemptionPriceType() { return IsSetField(Tags.YieldRedemptionPriceType); }

    public TotNoAllocs TotNoAllocs
    {
        get
        {
            TotNoAllocs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoAllocs val) { TotNoAllocs = val; }
    public TotNoAllocs Get(TotNoAllocs val) { GetField(val); return val; }
    public bool IsSet(TotNoAllocs val) { return IsSetTotNoAllocs(); }
    public bool IsSetTotNoAllocs() { return IsSetField(Tags.TotNoAllocs); }

    public LastFragment LastFragment
    {
        get
        {
            LastFragment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastFragment val) { LastFragment = val; }
    public LastFragment Get(LastFragment val) { GetField(val); return val; }
    public bool IsSet(LastFragment val) { return IsSetLastFragment(); }
    public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

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

    public ClearingBusinessDate ClearingBusinessDate
    {
        get
        {
            ClearingBusinessDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClearingBusinessDate val) { ClearingBusinessDate = val; }
    public ClearingBusinessDate Get(ClearingBusinessDate val) { GetField(val); return val; }
    public bool IsSet(ClearingBusinessDate val) { return IsSetClearingBusinessDate(); }
    public bool IsSetClearingBusinessDate() { return IsSetField(Tags.ClearingBusinessDate); }

    public TrdType TrdType
    {
        get
        {
            TrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdType val) { TrdType = val; }
    public TrdType Get(TrdType val) { GetField(val); return val; }
    public bool IsSet(TrdType val) { return IsSetTrdType(); }
    public bool IsSetTrdType() { return IsSetField(Tags.TrdType); }

    public TrdSubType TrdSubType
    {
        get
        {
            TrdSubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdSubType val) { TrdSubType = val; }
    public TrdSubType Get(TrdSubType val) { GetField(val); return val; }
    public bool IsSet(TrdSubType val) { return IsSetTrdSubType(); }
    public bool IsSetTrdSubType() { return IsSetField(Tags.TrdSubType); }

    public MultiLegReportingType MultiLegReportingType
    {
        get
        {
            MultiLegReportingType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MultiLegReportingType val) { MultiLegReportingType = val; }
    public MultiLegReportingType Get(MultiLegReportingType val) { GetField(val); return val; }
    public bool IsSet(MultiLegReportingType val) { return IsSetMultiLegReportingType(); }
    public bool IsSetMultiLegReportingType() { return IsSetField(Tags.MultiLegReportingType); }

    public CustOrderCapacity CustOrderCapacity
    {
        get
        {
            CustOrderCapacity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CustOrderCapacity val) { CustOrderCapacity = val; }
    public CustOrderCapacity Get(CustOrderCapacity val) { GetField(val); return val; }
    public bool IsSet(CustOrderCapacity val) { return IsSetCustOrderCapacity(); }
    public bool IsSetCustOrderCapacity() { return IsSetField(Tags.CustOrderCapacity); }

    public TradeInputSource TradeInputSource
    {
        get
        {
            TradeInputSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeInputSource val) { TradeInputSource = val; }
    public TradeInputSource Get(TradeInputSource val) { GetField(val); return val; }
    public bool IsSet(TradeInputSource val) { return IsSetTradeInputSource(); }
    public bool IsSetTradeInputSource() { return IsSetField(Tags.TradeInputSource); }

    public RndPx RndPx
    {
        get
        {
            RndPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RndPx val) { RndPx = val; }
    public RndPx Get(RndPx val) { GetField(val); return val; }
    public bool IsSet(RndPx val) { return IsSetRndPx(); }
    public bool IsSetRndPx() { return IsSetField(Tags.RndPx); }

    public MessageEventSource MessageEventSource
    {
        get
        {
            MessageEventSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MessageEventSource val) { MessageEventSource = val; }
    public MessageEventSource Get(MessageEventSource val) { GetField(val); return val; }
    public bool IsSet(MessageEventSource val) { return IsSetMessageEventSource(); }
    public bool IsSetMessageEventSource() { return IsSetField(Tags.MessageEventSource); }

    public TradeInputDevice TradeInputDevice
    {
        get
        {
            TradeInputDevice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeInputDevice val) { TradeInputDevice = val; }
    public TradeInputDevice Get(TradeInputDevice val) { GetField(val); return val; }
    public bool IsSet(TradeInputDevice val) { return IsSetTradeInputDevice(); }
    public bool IsSetTradeInputDevice() { return IsSetField(Tags.TradeInputDevice); }

    public AvgPxIndicator AvgPxIndicator
    {
        get
        {
            AvgPxIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AvgPxIndicator val) { AvgPxIndicator = val; }
    public AvgPxIndicator Get(AvgPxIndicator val) { GetField(val); return val; }
    public bool IsSet(AvgPxIndicator val) { return IsSetAvgPxIndicator(); }
    public bool IsSetAvgPxIndicator() { return IsSetField(Tags.AvgPxIndicator); }

    public NoPosAmt NoPosAmt
    {
        get
        {
            NoPosAmt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPosAmt val) { NoPosAmt = val; }
    public NoPosAmt Get(NoPosAmt val) { GetField(val); return val; }
    public bool IsSet(NoPosAmt val) { return IsSetNoPosAmt(); }
    public bool IsSetNoPosAmt() { return IsSetField(Tags.NoPosAmt); }

    public class NoOrdersGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0};

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

        public NoNested2PartyIDs NoNested2PartyIDs
        {
            get
            {
                NoNested2PartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNested2PartyIDs val) { NoNested2PartyIDs = val; }
        public NoNested2PartyIDs Get(NoNested2PartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNested2PartyIDs val) { return IsSetNoNested2PartyIDs(); }
        public bool IsSetNoNested2PartyIDs() { return IsSetField(Tags.NoNested2PartyIDs); }

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

        public OrderAvgPx OrderAvgPx
        {
            get
            {
                OrderAvgPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderAvgPx val) { OrderAvgPx = val; }
        public OrderAvgPx Get(OrderAvgPx val) { GetField(val); return val; }
        public bool IsSet(OrderAvgPx val) { return IsSetOrderAvgPx(); }
        public bool IsSetOrderAvgPx() { return IsSetField(Tags.OrderAvgPx); }

        public OrderBookingQty OrderBookingQty
        {
            get
            {
                OrderBookingQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderBookingQty val) { OrderBookingQty = val; }
        public OrderBookingQty Get(OrderBookingQty val) { GetField(val); return val; }
        public bool IsSet(OrderBookingQty val) { return IsSetOrderBookingQty(); }
        public bool IsSetOrderBookingQty() { return IsSetField(Tags.OrderBookingQty); }

        public class NoNested2PartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};

            public NoNested2PartyIDsGroup()
              : base(Tags.NoNested2PartyIDs, Tags.Nested2PartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNested2PartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public Nested2PartyID Nested2PartyID
            {
                get
                {
                    Nested2PartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested2PartyID val) { Nested2PartyID = val; }
            public Nested2PartyID Get(Nested2PartyID val) { GetField(val); return val; }
            public bool IsSet(Nested2PartyID val) { return IsSetNested2PartyID(); }
            public bool IsSetNested2PartyID() { return IsSetField(Tags.Nested2PartyID); }

            public Nested2PartyIDSource Nested2PartyIDSource
            {
                get
                {
                    Nested2PartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested2PartyIDSource val) { Nested2PartyIDSource = val; }
            public Nested2PartyIDSource Get(Nested2PartyIDSource val) { GetField(val); return val; }
            public bool IsSet(Nested2PartyIDSource val) { return IsSetNested2PartyIDSource(); }
            public bool IsSetNested2PartyIDSource() { return IsSetField(Tags.Nested2PartyIDSource); }

            public Nested2PartyRole Nested2PartyRole
            {
                get
                {
                    Nested2PartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(Nested2PartyRole val) { Nested2PartyRole = val; }
            public Nested2PartyRole Get(Nested2PartyRole val) { GetField(val); return val; }
            public bool IsSet(Nested2PartyRole val) { return IsSetNested2PartyRole(); }
            public bool IsSetNested2PartyRole() { return IsSetField(Tags.Nested2PartyRole); }

            public NoNested2PartySubIDs NoNested2PartySubIDs
            {
                get
                {
                    NoNested2PartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNested2PartySubIDs val) { NoNested2PartySubIDs = val; }
            public NoNested2PartySubIDs Get(NoNested2PartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNested2PartySubIDs val) { return IsSetNoNested2PartySubIDs(); }
            public bool IsSetNoNested2PartySubIDs() { return IsSetField(Tags.NoNested2PartySubIDs); }

            public class NoNested2PartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};

                public NoNested2PartySubIDsGroup()
                  : base(Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNested2PartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public Nested2PartySubID Nested2PartySubID
                {
                    get
                    {
                        Nested2PartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartySubID val) { Nested2PartySubID = val; }
                public Nested2PartySubID Get(Nested2PartySubID val) { GetField(val); return val; }
                public bool IsSet(Nested2PartySubID val) { return IsSetNested2PartySubID(); }
                public bool IsSetNested2PartySubID() { return IsSetField(Tags.Nested2PartySubID); }

                public Nested2PartySubIDType Nested2PartySubIDType
                {
                    get
                    {
                        Nested2PartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(Nested2PartySubIDType val) { Nested2PartySubIDType = val; }
                public Nested2PartySubIDType Get(Nested2PartySubIDType val) { GetField(val); return val; }
                public bool IsSet(Nested2PartySubIDType val) { return IsSetNested2PartySubIDType(); }
                public bool IsSetNested2PartySubIDType() { return IsSetField(Tags.Nested2PartySubIDType); }
            }
        }
    }

    public class NoExecsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LastQty, Tags.ExecID, Tags.SecondaryExecID, Tags.LastPx, Tags.LastParPx, Tags.LastCapacity, Tags.TradeID, Tags.FirmTradeID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LastQty, Tags.ExecID, Tags.SecondaryExecID, Tags.LastPx, Tags.LastParPx, Tags.LastCapacity, Tags.TradeID, Tags.FirmTradeID, 0};

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

        public LastParPx LastParPx
        {
            get
            {
                LastParPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LastParPx val) { LastParPx = val; }
        public LastParPx Get(LastParPx val) { GetField(val); return val; }
        public bool IsSet(LastParPx val) { return IsSetLastParPx(); }
        public bool IsSetLastParPx() { return IsSetField(Tags.LastParPx); }

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

        public TradeID TradeID
        {
            get
            {
                TradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeID val) { TradeID = val; }
        public TradeID Get(TradeID val) { GetField(val); return val; }
        public bool IsSet(TradeID val) { return IsSetTradeID(); }
        public bool IsSetTradeID() { return IsSetField(Tags.TradeID); }

        public FirmTradeID FirmTradeID
        {
            get
            {
                FirmTradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FirmTradeID val) { FirmTradeID = val; }
        public FirmTradeID Get(FirmTradeID val) { GetField(val); return val; }
        public bool IsSet(FirmTradeID val) { return IsSetFirmTradeID(); }
        public bool IsSetFirmTradeID() { return IsSetField(Tags.FirmTradeID); }
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
        public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};

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

    public class NoInstrAttribGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.InstrAttribType, Tags.InstrAttribValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.InstrAttribType, Tags.InstrAttribValue, 0};

        public NoInstrAttribGroup()
          : base(Tags.NoInstrAttrib, Tags.InstrAttribType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoInstrAttribGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public InstrAttribType InstrAttribType
        {
            get
            {
                InstrAttribType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrAttribType val) { InstrAttribType = val; }
        public InstrAttribType Get(InstrAttribType val) { GetField(val); return val; }
        public bool IsSet(InstrAttribType val) { return IsSetInstrAttribType(); }
        public bool IsSetInstrAttribType() { return IsSetField(Tags.InstrAttribType); }

        public InstrAttribValue InstrAttribValue
        {
            get
            {
                InstrAttribValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrAttribValue val) { InstrAttribValue = val; }
        public InstrAttribValue Get(InstrAttribValue val) { GetField(val); return val; }
        public bool IsSet(InstrAttribValue val) { return IsSetInstrAttribValue(); }
        public bool IsSetInstrAttribValue() { return IsSetField(Tags.InstrAttribValue); }
    }

    public class NoUnderlyingsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, 0};

        public NoUnderlyingsGroup()
          : base(Tags.NoUnderlyings, Tags.UnderlyingSymbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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
    }

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, 0};

        public NoLegsGroup()
          : base(Tags.NoLegs, Tags.LegSymbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoLegsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public LegSymbol LegSymbol
        {
            get
            {
                LegSymbol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSymbol val) { LegSymbol = val; }
        public LegSymbol Get(LegSymbol val) { GetField(val); return val; }
        public bool IsSet(LegSymbol val) { return IsSetLegSymbol(); }
        public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }

        public LegSymbolSfx LegSymbolSfx
        {
            get
            {
                LegSymbolSfx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSymbolSfx val) { LegSymbolSfx = val; }
        public LegSymbolSfx Get(LegSymbolSfx val) { GetField(val); return val; }
        public bool IsSet(LegSymbolSfx val) { return IsSetLegSymbolSfx(); }
        public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }

        public LegSecurityID LegSecurityID
        {
            get
            {
                LegSecurityID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityID val) { LegSecurityID = val; }
        public LegSecurityID Get(LegSecurityID val) { GetField(val); return val; }
        public bool IsSet(LegSecurityID val) { return IsSetLegSecurityID(); }
        public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }

        public LegSecurityIDSource LegSecurityIDSource
        {
            get
            {
                LegSecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityIDSource val) { LegSecurityIDSource = val; }
        public LegSecurityIDSource Get(LegSecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }
        public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }

        public NoLegSecurityAltID NoLegSecurityAltID
        {
            get
            {
                NoLegSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegSecurityAltID val) { NoLegSecurityAltID = val; }
        public NoLegSecurityAltID Get(NoLegSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }
        public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }

        public LegProduct LegProduct
        {
            get
            {
                LegProduct val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegProduct val) { LegProduct = val; }
        public LegProduct Get(LegProduct val) { GetField(val); return val; }
        public bool IsSet(LegProduct val) { return IsSetLegProduct(); }
        public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }

        public LegCFICode LegCFICode
        {
            get
            {
                LegCFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCFICode val) { LegCFICode = val; }
        public LegCFICode Get(LegCFICode val) { GetField(val); return val; }
        public bool IsSet(LegCFICode val) { return IsSetLegCFICode(); }
        public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }

        public LegSecurityType LegSecurityType
        {
            get
            {
                LegSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityType val) { LegSecurityType = val; }
        public LegSecurityType Get(LegSecurityType val) { GetField(val); return val; }
        public bool IsSet(LegSecurityType val) { return IsSetLegSecurityType(); }
        public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

        public LegSecuritySubType LegSecuritySubType
        {
            get
            {
                LegSecuritySubType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecuritySubType val) { LegSecuritySubType = val; }
        public LegSecuritySubType Get(LegSecuritySubType val) { GetField(val); return val; }
        public bool IsSet(LegSecuritySubType val) { return IsSetLegSecuritySubType(); }
        public bool IsSetLegSecuritySubType() { return IsSetField(Tags.LegSecuritySubType); }

        public LegMaturityMonthYear LegMaturityMonthYear
        {
            get
            {
                LegMaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityMonthYear val) { LegMaturityMonthYear = val; }
        public LegMaturityMonthYear Get(LegMaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }
        public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }

        public LegMaturityDate LegMaturityDate
        {
            get
            {
                LegMaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityDate val) { LegMaturityDate = val; }
        public LegMaturityDate Get(LegMaturityDate val) { GetField(val); return val; }
        public bool IsSet(LegMaturityDate val) { return IsSetLegMaturityDate(); }
        public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }

        public LegCouponPaymentDate LegCouponPaymentDate
        {
            get
            {
                LegCouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponPaymentDate val) { LegCouponPaymentDate = val; }
        public LegCouponPaymentDate Get(LegCouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }
        public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }

        public LegIssueDate LegIssueDate
        {
            get
            {
                LegIssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIssueDate val) { LegIssueDate = val; }
        public LegIssueDate Get(LegIssueDate val) { GetField(val); return val; }
        public bool IsSet(LegIssueDate val) { return IsSetLegIssueDate(); }
        public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }

        public LegRepoCollateralSecurityType LegRepoCollateralSecurityType
        {
            get
            {
                LegRepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepoCollateralSecurityType val) { LegRepoCollateralSecurityType = val; }
        public LegRepoCollateralSecurityType Get(LegRepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }
        public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }

        public LegRepurchaseTerm LegRepurchaseTerm
        {
            get
            {
                LegRepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepurchaseTerm val) { LegRepurchaseTerm = val; }
        public LegRepurchaseTerm Get(LegRepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }
        public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }

        public LegRepurchaseRate LegRepurchaseRate
        {
            get
            {
                LegRepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRepurchaseRate val) { LegRepurchaseRate = val; }
        public LegRepurchaseRate Get(LegRepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }
        public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }

        public LegFactor LegFactor
        {
            get
            {
                LegFactor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegFactor val) { LegFactor = val; }
        public LegFactor Get(LegFactor val) { GetField(val); return val; }
        public bool IsSet(LegFactor val) { return IsSetLegFactor(); }
        public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }

        public LegCreditRating LegCreditRating
        {
            get
            {
                LegCreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCreditRating val) { LegCreditRating = val; }
        public LegCreditRating Get(LegCreditRating val) { GetField(val); return val; }
        public bool IsSet(LegCreditRating val) { return IsSetLegCreditRating(); }
        public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }

        public LegInstrRegistry LegInstrRegistry
        {
            get
            {
                LegInstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegInstrRegistry val) { LegInstrRegistry = val; }
        public LegInstrRegistry Get(LegInstrRegistry val) { GetField(val); return val; }
        public bool IsSet(LegInstrRegistry val) { return IsSetLegInstrRegistry(); }
        public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }

        public LegCountryOfIssue LegCountryOfIssue
        {
            get
            {
                LegCountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCountryOfIssue val) { LegCountryOfIssue = val; }
        public LegCountryOfIssue Get(LegCountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }
        public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }

        public LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
        {
            get
            {
                LegStateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStateOrProvinceOfIssue val) { LegStateOrProvinceOfIssue = val; }
        public LegStateOrProvinceOfIssue Get(LegStateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }
        public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }

        public LegLocaleOfIssue LegLocaleOfIssue
        {
            get
            {
                LegLocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLocaleOfIssue val) { LegLocaleOfIssue = val; }
        public LegLocaleOfIssue Get(LegLocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }
        public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }

        public LegRedemptionDate LegRedemptionDate
        {
            get
            {
                LegRedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRedemptionDate val) { LegRedemptionDate = val; }
        public LegRedemptionDate Get(LegRedemptionDate val) { GetField(val); return val; }
        public bool IsSet(LegRedemptionDate val) { return IsSetLegRedemptionDate(); }
        public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }

        public LegStrikePrice LegStrikePrice
        {
            get
            {
                LegStrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrikePrice val) { LegStrikePrice = val; }
        public LegStrikePrice Get(LegStrikePrice val) { GetField(val); return val; }
        public bool IsSet(LegStrikePrice val) { return IsSetLegStrikePrice(); }
        public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }

        public LegStrikeCurrency LegStrikeCurrency
        {
            get
            {
                LegStrikeCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegStrikeCurrency val) { LegStrikeCurrency = val; }
        public LegStrikeCurrency Get(LegStrikeCurrency val) { GetField(val); return val; }
        public bool IsSet(LegStrikeCurrency val) { return IsSetLegStrikeCurrency(); }
        public bool IsSetLegStrikeCurrency() { return IsSetField(Tags.LegStrikeCurrency); }

        public LegOptAttribute LegOptAttribute
        {
            get
            {
                LegOptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptAttribute val) { LegOptAttribute = val; }
        public LegOptAttribute Get(LegOptAttribute val) { GetField(val); return val; }
        public bool IsSet(LegOptAttribute val) { return IsSetLegOptAttribute(); }
        public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }

        public LegContractMultiplier LegContractMultiplier
        {
            get
            {
                LegContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractMultiplier val) { LegContractMultiplier = val; }
        public LegContractMultiplier Get(LegContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(LegContractMultiplier val) { return IsSetLegContractMultiplier(); }
        public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }

        public LegCouponRate LegCouponRate
        {
            get
            {
                LegCouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCouponRate val) { LegCouponRate = val; }
        public LegCouponRate Get(LegCouponRate val) { GetField(val); return val; }
        public bool IsSet(LegCouponRate val) { return IsSetLegCouponRate(); }
        public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }

        public LegSecurityExchange LegSecurityExchange
        {
            get
            {
                LegSecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityExchange val) { LegSecurityExchange = val; }
        public LegSecurityExchange Get(LegSecurityExchange val) { GetField(val); return val; }
        public bool IsSet(LegSecurityExchange val) { return IsSetLegSecurityExchange(); }
        public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }

        public LegIssuer LegIssuer
        {
            get
            {
                LegIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegIssuer val) { LegIssuer = val; }
        public LegIssuer Get(LegIssuer val) { GetField(val); return val; }
        public bool IsSet(LegIssuer val) { return IsSetLegIssuer(); }
        public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }

        public EncodedLegIssuerLen EncodedLegIssuerLen
        {
            get
            {
                EncodedLegIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegIssuerLen val) { EncodedLegIssuerLen = val; }
        public EncodedLegIssuerLen Get(EncodedLegIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }
        public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }

        public EncodedLegIssuer EncodedLegIssuer
        {
            get
            {
                EncodedLegIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegIssuer val) { EncodedLegIssuer = val; }
        public EncodedLegIssuer Get(EncodedLegIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }
        public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }

        public LegSecurityDesc LegSecurityDesc
        {
            get
            {
                LegSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSecurityDesc val) { LegSecurityDesc = val; }
        public LegSecurityDesc Get(LegSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(LegSecurityDesc val) { return IsSetLegSecurityDesc(); }
        public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }

        public EncodedLegSecurityDescLen EncodedLegSecurityDescLen
        {
            get
            {
                EncodedLegSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegSecurityDescLen val) { EncodedLegSecurityDescLen = val; }
        public EncodedLegSecurityDescLen Get(EncodedLegSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }
        public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }

        public EncodedLegSecurityDesc EncodedLegSecurityDesc
        {
            get
            {
                EncodedLegSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedLegSecurityDesc val) { EncodedLegSecurityDesc = val; }
        public EncodedLegSecurityDesc Get(EncodedLegSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }
        public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }

        public LegRatioQty LegRatioQty
        {
            get
            {
                LegRatioQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRatioQty val) { LegRatioQty = val; }
        public LegRatioQty Get(LegRatioQty val) { GetField(val); return val; }
        public bool IsSet(LegRatioQty val) { return IsSetLegRatioQty(); }
        public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }

        public LegSide LegSide
        {
            get
            {
                LegSide val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSide val) { LegSide = val; }
        public LegSide Get(LegSide val) { GetField(val); return val; }
        public bool IsSet(LegSide val) { return IsSetLegSide(); }
        public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }

        public LegCurrency LegCurrency
        {
            get
            {
                LegCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCurrency val) { LegCurrency = val; }
        public LegCurrency Get(LegCurrency val) { GetField(val); return val; }
        public bool IsSet(LegCurrency val) { return IsSetLegCurrency(); }
        public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }

        public LegPool LegPool
        {
            get
            {
                LegPool val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPool val) { LegPool = val; }
        public LegPool Get(LegPool val) { GetField(val); return val; }
        public bool IsSet(LegPool val) { return IsSetLegPool(); }
        public bool IsSetLegPool() { return IsSetField(Tags.LegPool); }

        public LegDatedDate LegDatedDate
        {
            get
            {
                LegDatedDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDatedDate val) { LegDatedDate = val; }
        public LegDatedDate Get(LegDatedDate val) { GetField(val); return val; }
        public bool IsSet(LegDatedDate val) { return IsSetLegDatedDate(); }
        public bool IsSetLegDatedDate() { return IsSetField(Tags.LegDatedDate); }

        public LegContractSettlMonth LegContractSettlMonth
        {
            get
            {
                LegContractSettlMonth val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractSettlMonth val) { LegContractSettlMonth = val; }
        public LegContractSettlMonth Get(LegContractSettlMonth val) { GetField(val); return val; }
        public bool IsSet(LegContractSettlMonth val) { return IsSetLegContractSettlMonth(); }
        public bool IsSetLegContractSettlMonth() { return IsSetField(Tags.LegContractSettlMonth); }

        public LegInterestAccrualDate LegInterestAccrualDate
        {
            get
            {
                LegInterestAccrualDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegInterestAccrualDate val) { LegInterestAccrualDate = val; }
        public LegInterestAccrualDate Get(LegInterestAccrualDate val) { GetField(val); return val; }
        public bool IsSet(LegInterestAccrualDate val) { return IsSetLegInterestAccrualDate(); }
        public bool IsSetLegInterestAccrualDate() { return IsSetField(Tags.LegInterestAccrualDate); }

        public LegUnitOfMeasure LegUnitOfMeasure
        {
            get
            {
                LegUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegUnitOfMeasure val) { LegUnitOfMeasure = val; }
        public LegUnitOfMeasure Get(LegUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(LegUnitOfMeasure val) { return IsSetLegUnitOfMeasure(); }
        public bool IsSetLegUnitOfMeasure() { return IsSetField(Tags.LegUnitOfMeasure); }

        public LegTimeUnit LegTimeUnit
        {
            get
            {
                LegTimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegTimeUnit val) { LegTimeUnit = val; }
        public LegTimeUnit Get(LegTimeUnit val) { GetField(val); return val; }
        public bool IsSet(LegTimeUnit val) { return IsSetLegTimeUnit(); }
        public bool IsSetLegTimeUnit() { return IsSetField(Tags.LegTimeUnit); }

        public class NoLegSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

            public NoLegSecurityAltIDGroup()
              : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegSecurityAltID LegSecurityAltID
            {
                get
                {
                    LegSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityAltID val) { LegSecurityAltID = val; }
            public LegSecurityAltID Get(LegSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(LegSecurityAltID val) { return IsSetLegSecurityAltID(); }
            public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }

            public LegSecurityAltIDSource LegSecurityAltIDSource
            {
                get
                {
                    LegSecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityAltIDSource val) { LegSecurityAltIDSource = val; }
            public LegSecurityAltIDSource Get(LegSecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }
            public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }
        }
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

    public class NoStipulationsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StipulationType, Tags.StipulationValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

        public NoStipulationsGroup()
          : base(Tags.NoStipulations, Tags.StipulationType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoStipulationsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StipulationType StipulationType
        {
            get
            {
                StipulationType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StipulationType val) { StipulationType = val; }
        public StipulationType Get(StipulationType val) { GetField(val); return val; }
        public bool IsSet(StipulationType val) { return IsSetStipulationType(); }
        public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }

        public StipulationValue StipulationValue
        {
            get
            {
                StipulationValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StipulationValue val) { StipulationValue = val; }
        public StipulationValue Get(StipulationValue val) { GetField(val); return val; }
        public bool IsSet(StipulationValue val) { return IsSetStipulationValue(); }
        public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }
    }

    public class NoAllocsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.MatchStatus, Tags.AllocPrice, Tags.AllocQty, Tags.IndividualAllocID, Tags.ProcessCode, Tags.NoNestedPartyIDs, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.AllocSettlCurrAmt, Tags.SettlCurrency, Tags.AllocSettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AllocAccruedInterestAmt, Tags.AllocInterestAtMaturity, Tags.NoMiscFees, Tags.NoClearingInstructions, Tags.AllocSettlInstType, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, Tags.SecondaryIndividualAllocID, Tags.AllocMethod, Tags.AllocCustomerCapacity, Tags.IndividualAllocType, Tags.AllocPositionEffect, Tags.ClearingFeeIndicator, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.MatchStatus, Tags.AllocPrice, Tags.AllocQty, Tags.IndividualAllocID, Tags.ProcessCode, Tags.NoNestedPartyIDs, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.AllocSettlCurrAmt, Tags.SettlCurrency, Tags.AllocSettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AllocAccruedInterestAmt, Tags.AllocInterestAtMaturity, Tags.NoMiscFees, Tags.NoClearingInstructions, Tags.AllocSettlInstType, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, Tags.SecondaryIndividualAllocID, Tags.AllocMethod, Tags.AllocCustomerCapacity, Tags.IndividualAllocType, Tags.AllocPositionEffect, Tags.ClearingFeeIndicator, 0};

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

        public AllocAcctIDSource AllocAcctIDSource
        {
            get
            {
                AllocAcctIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocAcctIDSource val) { AllocAcctIDSource = val; }
        public AllocAcctIDSource Get(AllocAcctIDSource val) { GetField(val); return val; }
        public bool IsSet(AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }
        public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }

        public MatchStatus MatchStatus
        {
            get
            {
                MatchStatus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MatchStatus val) { MatchStatus = val; }
        public MatchStatus Get(MatchStatus val) { GetField(val); return val; }
        public bool IsSet(MatchStatus val) { return IsSetMatchStatus(); }
        public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }

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

        public AllocSettlCurrAmt AllocSettlCurrAmt
        {
            get
            {
                AllocSettlCurrAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocSettlCurrAmt val) { AllocSettlCurrAmt = val; }
        public AllocSettlCurrAmt Get(AllocSettlCurrAmt val) { GetField(val); return val; }
        public bool IsSet(AllocSettlCurrAmt val) { return IsSetAllocSettlCurrAmt(); }
        public bool IsSetAllocSettlCurrAmt() { return IsSetField(Tags.AllocSettlCurrAmt); }

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

        public AllocSettlCurrency AllocSettlCurrency
        {
            get
            {
                AllocSettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocSettlCurrency val) { AllocSettlCurrency = val; }
        public AllocSettlCurrency Get(AllocSettlCurrency val) { GetField(val); return val; }
        public bool IsSet(AllocSettlCurrency val) { return IsSetAllocSettlCurrency(); }
        public bool IsSetAllocSettlCurrency() { return IsSetField(Tags.AllocSettlCurrency); }

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

        public AllocAccruedInterestAmt AllocAccruedInterestAmt
        {
            get
            {
                AllocAccruedInterestAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocAccruedInterestAmt val) { AllocAccruedInterestAmt = val; }
        public AllocAccruedInterestAmt Get(AllocAccruedInterestAmt val) { GetField(val); return val; }
        public bool IsSet(AllocAccruedInterestAmt val) { return IsSetAllocAccruedInterestAmt(); }
        public bool IsSetAllocAccruedInterestAmt() { return IsSetField(Tags.AllocAccruedInterestAmt); }

        public AllocInterestAtMaturity AllocInterestAtMaturity
        {
            get
            {
                AllocInterestAtMaturity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocInterestAtMaturity val) { AllocInterestAtMaturity = val; }
        public AllocInterestAtMaturity Get(AllocInterestAtMaturity val) { GetField(val); return val; }
        public bool IsSet(AllocInterestAtMaturity val) { return IsSetAllocInterestAtMaturity(); }
        public bool IsSetAllocInterestAtMaturity() { return IsSetField(Tags.AllocInterestAtMaturity); }

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

        public NoClearingInstructions NoClearingInstructions
        {
            get
            {
                NoClearingInstructions val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoClearingInstructions val) { NoClearingInstructions = val; }
        public NoClearingInstructions Get(NoClearingInstructions val) { GetField(val); return val; }
        public bool IsSet(NoClearingInstructions val) { return IsSetNoClearingInstructions(); }
        public bool IsSetNoClearingInstructions() { return IsSetField(Tags.NoClearingInstructions); }

        public AllocSettlInstType AllocSettlInstType
        {
            get
            {
                AllocSettlInstType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocSettlInstType val) { AllocSettlInstType = val; }
        public AllocSettlInstType Get(AllocSettlInstType val) { GetField(val); return val; }
        public bool IsSet(AllocSettlInstType val) { return IsSetAllocSettlInstType(); }
        public bool IsSetAllocSettlInstType() { return IsSetField(Tags.AllocSettlInstType); }

        public SettlDeliveryType SettlDeliveryType
        {
            get
            {
                SettlDeliveryType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlDeliveryType val) { SettlDeliveryType = val; }
        public SettlDeliveryType Get(SettlDeliveryType val) { GetField(val); return val; }
        public bool IsSet(SettlDeliveryType val) { return IsSetSettlDeliveryType(); }
        public bool IsSetSettlDeliveryType() { return IsSetField(Tags.SettlDeliveryType); }

        public StandInstDbType StandInstDbType
        {
            get
            {
                StandInstDbType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StandInstDbType val) { StandInstDbType = val; }
        public StandInstDbType Get(StandInstDbType val) { GetField(val); return val; }
        public bool IsSet(StandInstDbType val) { return IsSetStandInstDbType(); }
        public bool IsSetStandInstDbType() { return IsSetField(Tags.StandInstDbType); }

        public StandInstDbName StandInstDbName
        {
            get
            {
                StandInstDbName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StandInstDbName val) { StandInstDbName = val; }
        public StandInstDbName Get(StandInstDbName val) { GetField(val); return val; }
        public bool IsSet(StandInstDbName val) { return IsSetStandInstDbName(); }
        public bool IsSetStandInstDbName() { return IsSetField(Tags.StandInstDbName); }

        public StandInstDbID StandInstDbID
        {
            get
            {
                StandInstDbID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StandInstDbID val) { StandInstDbID = val; }
        public StandInstDbID Get(StandInstDbID val) { GetField(val); return val; }
        public bool IsSet(StandInstDbID val) { return IsSetStandInstDbID(); }
        public bool IsSetStandInstDbID() { return IsSetField(Tags.StandInstDbID); }

        public NoDlvyInst NoDlvyInst
        {
            get
            {
                NoDlvyInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoDlvyInst val) { NoDlvyInst = val; }
        public NoDlvyInst Get(NoDlvyInst val) { GetField(val); return val; }
        public bool IsSet(NoDlvyInst val) { return IsSetNoDlvyInst(); }
        public bool IsSetNoDlvyInst() { return IsSetField(Tags.NoDlvyInst); }

        public SecondaryIndividualAllocID SecondaryIndividualAllocID
        {
            get
            {
                SecondaryIndividualAllocID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryIndividualAllocID val) { SecondaryIndividualAllocID = val; }
        public SecondaryIndividualAllocID Get(SecondaryIndividualAllocID val) { GetField(val); return val; }
        public bool IsSet(SecondaryIndividualAllocID val) { return IsSetSecondaryIndividualAllocID(); }
        public bool IsSetSecondaryIndividualAllocID() { return IsSetField(Tags.SecondaryIndividualAllocID); }

        public AllocMethod AllocMethod
        {
            get
            {
                AllocMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocMethod val) { AllocMethod = val; }
        public AllocMethod Get(AllocMethod val) { GetField(val); return val; }
        public bool IsSet(AllocMethod val) { return IsSetAllocMethod(); }
        public bool IsSetAllocMethod() { return IsSetField(Tags.AllocMethod); }

        public AllocCustomerCapacity AllocCustomerCapacity
        {
            get
            {
                AllocCustomerCapacity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocCustomerCapacity val) { AllocCustomerCapacity = val; }
        public AllocCustomerCapacity Get(AllocCustomerCapacity val) { GetField(val); return val; }
        public bool IsSet(AllocCustomerCapacity val) { return IsSetAllocCustomerCapacity(); }
        public bool IsSetAllocCustomerCapacity() { return IsSetField(Tags.AllocCustomerCapacity); }

        public IndividualAllocType IndividualAllocType
        {
            get
            {
                IndividualAllocType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IndividualAllocType val) { IndividualAllocType = val; }
        public IndividualAllocType Get(IndividualAllocType val) { GetField(val); return val; }
        public bool IsSet(IndividualAllocType val) { return IsSetIndividualAllocType(); }
        public bool IsSetIndividualAllocType() { return IsSetField(Tags.IndividualAllocType); }

        public AllocPositionEffect AllocPositionEffect
        {
            get
            {
                AllocPositionEffect val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AllocPositionEffect val) { AllocPositionEffect = val; }
        public AllocPositionEffect Get(AllocPositionEffect val) { GetField(val); return val; }
        public bool IsSet(AllocPositionEffect val) { return IsSetAllocPositionEffect(); }
        public bool IsSetAllocPositionEffect() { return IsSetField(Tags.AllocPositionEffect); }

        public ClearingFeeIndicator ClearingFeeIndicator
        {
            get
            {
                ClearingFeeIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ClearingFeeIndicator val) { ClearingFeeIndicator = val; }
        public ClearingFeeIndicator Get(ClearingFeeIndicator val) { GetField(val); return val; }
        public bool IsSet(ClearingFeeIndicator val) { return IsSetClearingFeeIndicator(); }
        public bool IsSetClearingFeeIndicator() { return IsSetField(Tags.ClearingFeeIndicator); }

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

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

            public NoNestedPartySubIDs NoNestedPartySubIDs
            {
                get
                {
                    NoNestedPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNestedPartySubIDs val) { NoNestedPartySubIDs = val; }
            public NoNestedPartySubIDs Get(NoNestedPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }
            public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }

            public class NoNestedPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

                public NoNestedPartySubIDsGroup()
                  : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNestedPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

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

                public NestedPartySubIDType NestedPartySubIDType
                {
                    get
                    {
                        NestedPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubIDType val) { NestedPartySubIDType = val; }
                public NestedPartySubIDType Get(NestedPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }
                public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }
            }
        }

        public class NoMiscFeesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};

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

            public MiscFeeBasis MiscFeeBasis
            {
                get
                {
                    MiscFeeBasis val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MiscFeeBasis val) { MiscFeeBasis = val; }
            public MiscFeeBasis Get(MiscFeeBasis val) { GetField(val); return val; }
            public bool IsSet(MiscFeeBasis val) { return IsSetMiscFeeBasis(); }
            public bool IsSetMiscFeeBasis() { return IsSetField(Tags.MiscFeeBasis); }
        }

        public class NoClearingInstructionsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ClearingInstruction, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ClearingInstruction, 0};

            public NoClearingInstructionsGroup()
              : base(Tags.NoClearingInstructions, Tags.ClearingInstruction, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoClearingInstructionsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ClearingInstruction ClearingInstruction
            {
                get
                {
                    ClearingInstruction val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ClearingInstruction val) { ClearingInstruction = val; }
            public ClearingInstruction Get(ClearingInstruction val) { GetField(val); return val; }
            public bool IsSet(ClearingInstruction val) { return IsSetClearingInstruction(); }
            public bool IsSetClearingInstruction() { return IsSetField(Tags.ClearingInstruction); }
        }

        public class NoDlvyInstGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0};

            public NoDlvyInstGroup()
              : base(Tags.NoDlvyInst, Tags.SettlInstSource, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDlvyInstGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public SettlInstSource SettlInstSource
            {
                get
                {
                    SettlInstSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SettlInstSource val) { SettlInstSource = val; }
            public SettlInstSource Get(SettlInstSource val) { GetField(val); return val; }
            public bool IsSet(SettlInstSource val) { return IsSetSettlInstSource(); }
            public bool IsSetSettlInstSource() { return IsSetField(Tags.SettlInstSource); }

            public DlvyInstType DlvyInstType
            {
                get
                {
                    DlvyInstType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(DlvyInstType val) { DlvyInstType = val; }
            public DlvyInstType Get(DlvyInstType val) { GetField(val); return val; }
            public bool IsSet(DlvyInstType val) { return IsSetDlvyInstType(); }
            public bool IsSetDlvyInstType() { return IsSetField(Tags.DlvyInstType); }

            public NoSettlPartyIDs NoSettlPartyIDs
            {
                get
                {
                    NoSettlPartyIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoSettlPartyIDs val) { NoSettlPartyIDs = val; }
            public NoSettlPartyIDs Get(NoSettlPartyIDs val) { GetField(val); return val; }
            public bool IsSet(NoSettlPartyIDs val) { return IsSetNoSettlPartyIDs(); }
            public bool IsSetNoSettlPartyIDs() { return IsSetField(Tags.NoSettlPartyIDs); }

            public class NoSettlPartyIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

                public NoSettlPartyIDsGroup()
                  : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoSettlPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public SettlPartyID SettlPartyID
                {
                    get
                    {
                        SettlPartyID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyID val) { SettlPartyID = val; }
                public SettlPartyID Get(SettlPartyID val) { GetField(val); return val; }
                public bool IsSet(SettlPartyID val) { return IsSetSettlPartyID(); }
                public bool IsSetSettlPartyID() { return IsSetField(Tags.SettlPartyID); }

                public SettlPartyIDSource SettlPartyIDSource
                {
                    get
                    {
                        SettlPartyIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyIDSource val) { SettlPartyIDSource = val; }
                public SettlPartyIDSource Get(SettlPartyIDSource val) { GetField(val); return val; }
                public bool IsSet(SettlPartyIDSource val) { return IsSetSettlPartyIDSource(); }
                public bool IsSetSettlPartyIDSource() { return IsSetField(Tags.SettlPartyIDSource); }

                public SettlPartyRole SettlPartyRole
                {
                    get
                    {
                        SettlPartyRole val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(SettlPartyRole val) { SettlPartyRole = val; }
                public SettlPartyRole Get(SettlPartyRole val) { GetField(val); return val; }
                public bool IsSet(SettlPartyRole val) { return IsSetSettlPartyRole(); }
                public bool IsSetSettlPartyRole() { return IsSetField(Tags.SettlPartyRole); }

                public NoSettlPartySubIDs NoSettlPartySubIDs
                {
                    get
                    {
                        NoSettlPartySubIDs val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NoSettlPartySubIDs val) { NoSettlPartySubIDs = val; }
                public NoSettlPartySubIDs Get(NoSettlPartySubIDs val) { GetField(val); return val; }
                public bool IsSet(NoSettlPartySubIDs val) { return IsSetNoSettlPartySubIDs(); }
                public bool IsSetNoSettlPartySubIDs() { return IsSetField(Tags.NoSettlPartySubIDs); }

                public class NoSettlPartySubIDsGroup : Group
                {
                    public static int[] DefaultFieldOrder = [Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0];

                    [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                    public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

                    public NoSettlPartySubIDsGroup()
                      : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, DefaultFieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoSettlPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public SettlPartySubID SettlPartySubID
                    {
                        get
                        {
                            SettlPartySubID val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(SettlPartySubID val) { SettlPartySubID = val; }
                    public SettlPartySubID Get(SettlPartySubID val) { GetField(val); return val; }
                    public bool IsSet(SettlPartySubID val) { return IsSetSettlPartySubID(); }
                    public bool IsSetSettlPartySubID() { return IsSetField(Tags.SettlPartySubID); }

                    public SettlPartySubIDType SettlPartySubIDType
                    {
                        get
                        {
                            SettlPartySubIDType val = new();
                            GetField(val);
                            return val;
                        }
                        set  => SetField(value);
                    }

                    public void Set(SettlPartySubIDType val) { SettlPartySubIDType = val; }
                    public SettlPartySubIDType Get(SettlPartySubIDType val) { GetField(val); return val; }
                    public bool IsSet(SettlPartySubIDType val) { return IsSetSettlPartySubIDType(); }
                    public bool IsSetSettlPartySubIDType() { return IsSetField(Tags.SettlPartySubIDType); }
                }
            }
        }
    }

    public class NoPosAmtGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PosAmtType, Tags.PosAmt, Tags.PositionCurrency, 0};

        public NoPosAmtGroup()
          : base(Tags.NoPosAmt, Tags.PosAmtType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPosAmtGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PosAmtType PosAmtType
        {
            get
            {
                PosAmtType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PosAmtType val) { PosAmtType = val; }
        public PosAmtType Get(PosAmtType val) { GetField(val); return val; }
        public bool IsSet(PosAmtType val) { return IsSetPosAmtType(); }
        public bool IsSetPosAmtType() { return IsSetField(Tags.PosAmtType); }

        public PosAmt PosAmt
        {
            get
            {
                PosAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PosAmt val) { PosAmt = val; }
        public PosAmt Get(PosAmt val) { GetField(val); return val; }
        public bool IsSet(PosAmt val) { return IsSetPosAmt(); }
        public bool IsSetPosAmt() { return IsSetField(Tags.PosAmt); }

        public PositionCurrency PositionCurrency
        {
            get
            {
                PositionCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PositionCurrency val) { PositionCurrency = val; }
        public PositionCurrency Get(PositionCurrency val) { GetField(val); return val; }
        public bool IsSet(PositionCurrency val) { return IsSetPositionCurrency(); }
        public bool IsSetPositionCurrency() { return IsSetField(Tags.PositionCurrency); }
    }
}
