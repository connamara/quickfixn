// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class TradeCaptureReport : Message
{
    public const string MsgType = "AE";

    public TradeCaptureReport() : base()
    {
        Header.SetField(new MsgType("AE"));
    }

    public TradeCaptureReport(
            LastQty aLastQty,
            LastPx aLastPx
        ) : this()
    {
        LastQty = aLastQty;
        LastPx = aLastPx;
    }

    public TradeReportID TradeReportID
    {
        get
        {
            TradeReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportID val) { TradeReportID = val; }
    public TradeReportID Get(TradeReportID val) { GetField(val); return val; }
    public bool IsSet(TradeReportID val) { return IsSetTradeReportID(); }
    public bool IsSetTradeReportID() { return IsSetField(Tags.TradeReportID); }

    public TradeReportTransType TradeReportTransType
    {
        get
        {
            TradeReportTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportTransType val) { TradeReportTransType = val; }
    public TradeReportTransType Get(TradeReportTransType val) { GetField(val); return val; }
    public bool IsSet(TradeReportTransType val) { return IsSetTradeReportTransType(); }
    public bool IsSetTradeReportTransType() { return IsSetField(Tags.TradeReportTransType); }

    public TradeReportType TradeReportType
    {
        get
        {
            TradeReportType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportType val) { TradeReportType = val; }
    public TradeReportType Get(TradeReportType val) { GetField(val); return val; }
    public bool IsSet(TradeReportType val) { return IsSetTradeReportType(); }
    public bool IsSetTradeReportType() { return IsSetField(Tags.TradeReportType); }

    public TradeRequestID TradeRequestID
    {
        get
        {
            TradeRequestID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeRequestID val) { TradeRequestID = val; }
    public TradeRequestID Get(TradeRequestID val) { GetField(val); return val; }
    public bool IsSet(TradeRequestID val) { return IsSetTradeRequestID(); }
    public bool IsSetTradeRequestID() { return IsSetField(Tags.TradeRequestID); }

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

    public SecondaryTrdType SecondaryTrdType
    {
        get
        {
            SecondaryTrdType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTrdType val) { SecondaryTrdType = val; }
    public SecondaryTrdType Get(SecondaryTrdType val) { GetField(val); return val; }
    public bool IsSet(SecondaryTrdType val) { return IsSetSecondaryTrdType(); }
    public bool IsSetSecondaryTrdType() { return IsSetField(Tags.SecondaryTrdType); }

    public TransferReason TransferReason
    {
        get
        {
            TransferReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransferReason val) { TransferReason = val; }
    public TransferReason Get(TransferReason val) { GetField(val); return val; }
    public bool IsSet(TransferReason val) { return IsSetTransferReason(); }
    public bool IsSetTransferReason() { return IsSetField(Tags.TransferReason); }

    public ExecType ExecType
    {
        get
        {
            ExecType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecType val) { ExecType = val; }
    public ExecType Get(ExecType val) { GetField(val); return val; }
    public bool IsSet(ExecType val) { return IsSetExecType(); }
    public bool IsSetExecType() { return IsSetField(Tags.ExecType); }

    public TotNumTradeReports TotNumTradeReports
    {
        get
        {
            TotNumTradeReports val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNumTradeReports val) { TotNumTradeReports = val; }
    public TotNumTradeReports Get(TotNumTradeReports val) { GetField(val); return val; }
    public bool IsSet(TotNumTradeReports val) { return IsSetTotNumTradeReports(); }
    public bool IsSetTotNumTradeReports() { return IsSetField(Tags.TotNumTradeReports); }

    public LastRptRequested LastRptRequested
    {
        get
        {
            LastRptRequested val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastRptRequested val) { LastRptRequested = val; }
    public LastRptRequested Get(LastRptRequested val) { GetField(val); return val; }
    public bool IsSet(LastRptRequested val) { return IsSetLastRptRequested(); }
    public bool IsSetLastRptRequested() { return IsSetField(Tags.LastRptRequested); }

    public UnsolicitedIndicator UnsolicitedIndicator
    {
        get
        {
            UnsolicitedIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnsolicitedIndicator val) { UnsolicitedIndicator = val; }
    public UnsolicitedIndicator Get(UnsolicitedIndicator val) { GetField(val); return val; }
    public bool IsSet(UnsolicitedIndicator val) { return IsSetUnsolicitedIndicator(); }
    public bool IsSetUnsolicitedIndicator() { return IsSetField(Tags.UnsolicitedIndicator); }

    public SubscriptionRequestType SubscriptionRequestType
    {
        get
        {
            SubscriptionRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SubscriptionRequestType val) { SubscriptionRequestType = val; }
    public SubscriptionRequestType Get(SubscriptionRequestType val) { GetField(val); return val; }
    public bool IsSet(SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }
    public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

    public TradeReportRefID TradeReportRefID
    {
        get
        {
            TradeReportRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeReportRefID val) { TradeReportRefID = val; }
    public TradeReportRefID Get(TradeReportRefID val) { GetField(val); return val; }
    public bool IsSet(TradeReportRefID val) { return IsSetTradeReportRefID(); }
    public bool IsSetTradeReportRefID() { return IsSetField(Tags.TradeReportRefID); }

    public SecondaryTradeReportRefID SecondaryTradeReportRefID
    {
        get
        {
            SecondaryTradeReportRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTradeReportRefID val) { SecondaryTradeReportRefID = val; }
    public SecondaryTradeReportRefID Get(SecondaryTradeReportRefID val) { GetField(val); return val; }
    public bool IsSet(SecondaryTradeReportRefID val) { return IsSetSecondaryTradeReportRefID(); }
    public bool IsSetSecondaryTradeReportRefID() { return IsSetField(Tags.SecondaryTradeReportRefID); }

    public SecondaryTradeReportID SecondaryTradeReportID
    {
        get
        {
            SecondaryTradeReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTradeReportID val) { SecondaryTradeReportID = val; }
    public SecondaryTradeReportID Get(SecondaryTradeReportID val) { GetField(val); return val; }
    public bool IsSet(SecondaryTradeReportID val) { return IsSetSecondaryTradeReportID(); }
    public bool IsSetSecondaryTradeReportID() { return IsSetField(Tags.SecondaryTradeReportID); }

    public TradeLinkID TradeLinkID
    {
        get
        {
            TradeLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeLinkID val) { TradeLinkID = val; }
    public TradeLinkID Get(TradeLinkID val) { GetField(val); return val; }
    public bool IsSet(TradeLinkID val) { return IsSetTradeLinkID(); }
    public bool IsSetTradeLinkID() { return IsSetField(Tags.TradeLinkID); }

    public TrdMatchID TrdMatchID
    {
        get
        {
            TrdMatchID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdMatchID val) { TrdMatchID = val; }
    public TrdMatchID Get(TrdMatchID val) { GetField(val); return val; }
    public bool IsSet(TrdMatchID val) { return IsSetTrdMatchID(); }
    public bool IsSetTrdMatchID() { return IsSetField(Tags.TrdMatchID); }

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

    public ExecRestatementReason ExecRestatementReason
    {
        get
        {
            ExecRestatementReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExecRestatementReason val) { ExecRestatementReason = val; }
    public ExecRestatementReason Get(ExecRestatementReason val) { GetField(val); return val; }
    public bool IsSet(ExecRestatementReason val) { return IsSetExecRestatementReason(); }
    public bool IsSetExecRestatementReason() { return IsSetField(Tags.ExecRestatementReason); }

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

    public OptPayoutAmount OptPayoutAmount
    {
        get
        {
            OptPayoutAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptPayoutAmount val) { OptPayoutAmount = val; }
    public OptPayoutAmount Get(OptPayoutAmount val) { GetField(val); return val; }
    public bool IsSet(OptPayoutAmount val) { return IsSetOptPayoutAmount(); }
    public bool IsSetOptPayoutAmount() { return IsSetField(Tags.OptPayoutAmount); }

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

    public ValuationMethod ValuationMethod
    {
        get
        {
            ValuationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ValuationMethod val) { ValuationMethod = val; }
    public ValuationMethod Get(ValuationMethod val) { GetField(val); return val; }
    public bool IsSet(ValuationMethod val) { return IsSetValuationMethod(); }
    public bool IsSetValuationMethod() { return IsSetField(Tags.ValuationMethod); }

    public ContractMultiplierUnit ContractMultiplierUnit
    {
        get
        {
            ContractMultiplierUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ContractMultiplierUnit val) { ContractMultiplierUnit = val; }
    public ContractMultiplierUnit Get(ContractMultiplierUnit val) { GetField(val); return val; }
    public bool IsSet(ContractMultiplierUnit val) { return IsSetContractMultiplierUnit(); }
    public bool IsSetContractMultiplierUnit() { return IsSetField(Tags.ContractMultiplierUnit); }

    public FlowScheduleType FlowScheduleType
    {
        get
        {
            FlowScheduleType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FlowScheduleType val) { FlowScheduleType = val; }
    public FlowScheduleType Get(FlowScheduleType val) { GetField(val); return val; }
    public bool IsSet(FlowScheduleType val) { return IsSetFlowScheduleType(); }
    public bool IsSetFlowScheduleType() { return IsSetField(Tags.FlowScheduleType); }

    public RestructuringType RestructuringType
    {
        get
        {
            RestructuringType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RestructuringType val) { RestructuringType = val; }
    public RestructuringType Get(RestructuringType val) { GetField(val); return val; }
    public bool IsSet(RestructuringType val) { return IsSetRestructuringType(); }
    public bool IsSetRestructuringType() { return IsSetField(Tags.RestructuringType); }

    public Seniority Seniority
    {
        get
        {
            Seniority val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Seniority val) { Seniority = val; }
    public Seniority Get(Seniority val) { GetField(val); return val; }
    public bool IsSet(Seniority val) { return IsSetSeniority(); }
    public bool IsSetSeniority() { return IsSetField(Tags.Seniority); }

    public NotionalPercentageOutstanding NotionalPercentageOutstanding
    {
        get
        {
            NotionalPercentageOutstanding val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NotionalPercentageOutstanding val) { NotionalPercentageOutstanding = val; }
    public NotionalPercentageOutstanding Get(NotionalPercentageOutstanding val) { GetField(val); return val; }
    public bool IsSet(NotionalPercentageOutstanding val) { return IsSetNotionalPercentageOutstanding(); }
    public bool IsSetNotionalPercentageOutstanding() { return IsSetField(Tags.NotionalPercentageOutstanding); }

    public OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
    {
        get
        {
            OriginalNotionalPercentageOutstanding val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OriginalNotionalPercentageOutstanding val) { OriginalNotionalPercentageOutstanding = val; }
    public OriginalNotionalPercentageOutstanding Get(OriginalNotionalPercentageOutstanding val) { GetField(val); return val; }
    public bool IsSet(OriginalNotionalPercentageOutstanding val) { return IsSetOriginalNotionalPercentageOutstanding(); }
    public bool IsSetOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.OriginalNotionalPercentageOutstanding); }

    public AttachmentPoint AttachmentPoint
    {
        get
        {
            AttachmentPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AttachmentPoint val) { AttachmentPoint = val; }
    public AttachmentPoint Get(AttachmentPoint val) { GetField(val); return val; }
    public bool IsSet(AttachmentPoint val) { return IsSetAttachmentPoint(); }
    public bool IsSetAttachmentPoint() { return IsSetField(Tags.AttachmentPoint); }

    public DetachmentPoint DetachmentPoint
    {
        get
        {
            DetachmentPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DetachmentPoint val) { DetachmentPoint = val; }
    public DetachmentPoint Get(DetachmentPoint val) { GetField(val); return val; }
    public bool IsSet(DetachmentPoint val) { return IsSetDetachmentPoint(); }
    public bool IsSetDetachmentPoint() { return IsSetField(Tags.DetachmentPoint); }

    public StrikePriceDeterminationMethod StrikePriceDeterminationMethod
    {
        get
        {
            StrikePriceDeterminationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePriceDeterminationMethod val) { StrikePriceDeterminationMethod = val; }
    public StrikePriceDeterminationMethod Get(StrikePriceDeterminationMethod val) { GetField(val); return val; }
    public bool IsSet(StrikePriceDeterminationMethod val) { return IsSetStrikePriceDeterminationMethod(); }
    public bool IsSetStrikePriceDeterminationMethod() { return IsSetField(Tags.StrikePriceDeterminationMethod); }

    public StrikePriceBoundaryMethod StrikePriceBoundaryMethod
    {
        get
        {
            StrikePriceBoundaryMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePriceBoundaryMethod val) { StrikePriceBoundaryMethod = val; }
    public StrikePriceBoundaryMethod Get(StrikePriceBoundaryMethod val) { GetField(val); return val; }
    public bool IsSet(StrikePriceBoundaryMethod val) { return IsSetStrikePriceBoundaryMethod(); }
    public bool IsSetStrikePriceBoundaryMethod() { return IsSetField(Tags.StrikePriceBoundaryMethod); }

    public StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
    {
        get
        {
            StrikePriceBoundaryPrecision val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikePriceBoundaryPrecision val) { StrikePriceBoundaryPrecision = val; }
    public StrikePriceBoundaryPrecision Get(StrikePriceBoundaryPrecision val) { GetField(val); return val; }
    public bool IsSet(StrikePriceBoundaryPrecision val) { return IsSetStrikePriceBoundaryPrecision(); }
    public bool IsSetStrikePriceBoundaryPrecision() { return IsSetField(Tags.StrikePriceBoundaryPrecision); }

    public UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
    {
        get
        {
            UnderlyingPriceDeterminationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPriceDeterminationMethod val) { UnderlyingPriceDeterminationMethod = val; }
    public UnderlyingPriceDeterminationMethod Get(UnderlyingPriceDeterminationMethod val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPriceDeterminationMethod val) { return IsSetUnderlyingPriceDeterminationMethod(); }
    public bool IsSetUnderlyingPriceDeterminationMethod() { return IsSetField(Tags.UnderlyingPriceDeterminationMethod); }

    public OptPayoutType OptPayoutType
    {
        get
        {
            OptPayoutType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OptPayoutType val) { OptPayoutType = val; }
    public OptPayoutType Get(OptPayoutType val) { GetField(val); return val; }
    public bool IsSet(OptPayoutType val) { return IsSetOptPayoutType(); }
    public bool IsSetOptPayoutType() { return IsSetField(Tags.OptPayoutType); }

    public NoComplexEvents NoComplexEvents
    {
        get
        {
            NoComplexEvents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoComplexEvents val) { NoComplexEvents = val; }
    public NoComplexEvents Get(NoComplexEvents val) { GetField(val); return val; }
    public bool IsSet(NoComplexEvents val) { return IsSetNoComplexEvents(); }
    public bool IsSetNoComplexEvents() { return IsSetField(Tags.NoComplexEvents); }

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

    public UnderlyingTradingSessionID UnderlyingTradingSessionID
    {
        get
        {
            UnderlyingTradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingTradingSessionID val) { UnderlyingTradingSessionID = val; }
    public UnderlyingTradingSessionID Get(UnderlyingTradingSessionID val) { GetField(val); return val; }
    public bool IsSet(UnderlyingTradingSessionID val) { return IsSetUnderlyingTradingSessionID(); }
    public bool IsSetUnderlyingTradingSessionID() { return IsSetField(Tags.UnderlyingTradingSessionID); }

    public UnderlyingTradingSessionSubID UnderlyingTradingSessionSubID
    {
        get
        {
            UnderlyingTradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingTradingSessionSubID val) { UnderlyingTradingSessionSubID = val; }
    public UnderlyingTradingSessionSubID Get(UnderlyingTradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(UnderlyingTradingSessionSubID val) { return IsSetUnderlyingTradingSessionSubID(); }
    public bool IsSetUnderlyingTradingSessionSubID() { return IsSetField(Tags.UnderlyingTradingSessionSubID); }

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

    public LastSpotRate LastSpotRate
    {
        get
        {
            LastSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastSpotRate val) { LastSpotRate = val; }
    public LastSpotRate Get(LastSpotRate val) { GetField(val); return val; }
    public bool IsSet(LastSpotRate val) { return IsSetLastSpotRate(); }
    public bool IsSetLastSpotRate() { return IsSetField(Tags.LastSpotRate); }

    public LastForwardPoints LastForwardPoints
    {
        get
        {
            LastForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastForwardPoints val) { LastForwardPoints = val; }
    public LastForwardPoints Get(LastForwardPoints val) { GetField(val); return val; }
    public bool IsSet(LastForwardPoints val) { return IsSetLastForwardPoints(); }
    public bool IsSetLastForwardPoints() { return IsSetField(Tags.LastForwardPoints); }

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

    public TradeLegRefID TradeLegRefID
    {
        get
        {
            TradeLegRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeLegRefID val) { TradeLegRefID = val; }
    public TradeLegRefID Get(TradeLegRefID val) { GetField(val); return val; }
    public bool IsSet(TradeLegRefID val) { return IsSetTradeLegRefID(); }
    public bool IsSetTradeLegRefID() { return IsSetField(Tags.TradeLegRefID); }

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

    public NoTrdRegTimestamps NoTrdRegTimestamps
    {
        get
        {
            NoTrdRegTimestamps val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTrdRegTimestamps val) { NoTrdRegTimestamps = val; }
    public NoTrdRegTimestamps Get(NoTrdRegTimestamps val) { GetField(val); return val; }
    public bool IsSet(NoTrdRegTimestamps val) { return IsSetNoTrdRegTimestamps(); }
    public bool IsSetNoTrdRegTimestamps() { return IsSetField(Tags.NoTrdRegTimestamps); }

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

    public NoSides NoSides
    {
        get
        {
            NoSides val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoSides val) { NoSides = val; }
    public NoSides Get(NoSides val) { GetField(val); return val; }
    public bool IsSet(NoSides val) { return IsSetNoSides(); }
    public bool IsSetNoSides() { return IsSetField(Tags.NoSides); }

    public CopyMsgIndicator CopyMsgIndicator
    {
        get
        {
            CopyMsgIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CopyMsgIndicator val) { CopyMsgIndicator = val; }
    public CopyMsgIndicator Get(CopyMsgIndicator val) { GetField(val); return val; }
    public bool IsSet(CopyMsgIndicator val) { return IsSetCopyMsgIndicator(); }
    public bool IsSetCopyMsgIndicator() { return IsSetField(Tags.CopyMsgIndicator); }

    public PublishTrdIndicator PublishTrdIndicator
    {
        get
        {
            PublishTrdIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PublishTrdIndicator val) { PublishTrdIndicator = val; }
    public PublishTrdIndicator Get(PublishTrdIndicator val) { GetField(val); return val; }
    public bool IsSet(PublishTrdIndicator val) { return IsSetPublishTrdIndicator(); }
    public bool IsSetPublishTrdIndicator() { return IsSetField(Tags.PublishTrdIndicator); }

    public ShortSaleReason ShortSaleReason
    {
        get
        {
            ShortSaleReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ShortSaleReason val) { ShortSaleReason = val; }
    public ShortSaleReason Get(ShortSaleReason val) { GetField(val); return val; }
    public bool IsSet(ShortSaleReason val) { return IsSetShortSaleReason(); }
    public bool IsSetShortSaleReason() { return IsSetField(Tags.ShortSaleReason); }

    public TrdRptStatus TrdRptStatus
    {
        get
        {
            TrdRptStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TrdRptStatus val) { TrdRptStatus = val; }
    public TrdRptStatus Get(TrdRptStatus val) { GetField(val); return val; }
    public bool IsSet(TrdRptStatus val) { return IsSetTrdRptStatus(); }
    public bool IsSetTrdRptStatus() { return IsSetField(Tags.TrdRptStatus); }

    public AsOfIndicator AsOfIndicator
    {
        get
        {
            AsOfIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AsOfIndicator val) { AsOfIndicator = val; }
    public AsOfIndicator Get(AsOfIndicator val) { GetField(val); return val; }
    public bool IsSet(AsOfIndicator val) { return IsSetAsOfIndicator(); }
    public bool IsSetAsOfIndicator() { return IsSetField(Tags.AsOfIndicator); }

    public SettlSessID SettlSessID
    {
        get
        {
            SettlSessID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlSessID val) { SettlSessID = val; }
    public SettlSessID Get(SettlSessID val) { GetField(val); return val; }
    public bool IsSet(SettlSessID val) { return IsSetSettlSessID(); }
    public bool IsSetSettlSessID() { return IsSetField(Tags.SettlSessID); }

    public SettlSessSubID SettlSessSubID
    {
        get
        {
            SettlSessSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlSessSubID val) { SettlSessSubID = val; }
    public SettlSessSubID Get(SettlSessSubID val) { GetField(val); return val; }
    public bool IsSet(SettlSessSubID val) { return IsSetSettlSessSubID(); }
    public bool IsSetSettlSessSubID() { return IsSetField(Tags.SettlSessSubID); }

    public TierCode TierCode
    {
        get
        {
            TierCode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TierCode val) { TierCode = val; }
    public TierCode Get(TierCode val) { GetField(val); return val; }
    public bool IsSet(TierCode val) { return IsSetTierCode(); }
    public bool IsSetTierCode() { return IsSetField(Tags.TierCode); }

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

    public LastUpdateTime LastUpdateTime
    {
        get
        {
            LastUpdateTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastUpdateTime val) { LastUpdateTime = val; }
    public LastUpdateTime Get(LastUpdateTime val) { GetField(val); return val; }
    public bool IsSet(LastUpdateTime val) { return IsSetLastUpdateTime(); }
    public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

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

    public SecondaryTradeID SecondaryTradeID
    {
        get
        {
            SecondaryTradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryTradeID val) { SecondaryTradeID = val; }
    public SecondaryTradeID Get(SecondaryTradeID val) { GetField(val); return val; }
    public bool IsSet(SecondaryTradeID val) { return IsSetSecondaryTradeID(); }
    public bool IsSetSecondaryTradeID() { return IsSetField(Tags.SecondaryTradeID); }

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

    public SecondaryFirmTradeID SecondaryFirmTradeID
    {
        get
        {
            SecondaryFirmTradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryFirmTradeID val) { SecondaryFirmTradeID = val; }
    public SecondaryFirmTradeID Get(SecondaryFirmTradeID val) { GetField(val); return val; }
    public bool IsSet(SecondaryFirmTradeID val) { return IsSetSecondaryFirmTradeID(); }
    public bool IsSetSecondaryFirmTradeID() { return IsSetField(Tags.SecondaryFirmTradeID); }

    public CalculatedCcyLastQty CalculatedCcyLastQty
    {
        get
        {
            CalculatedCcyLastQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CalculatedCcyLastQty val) { CalculatedCcyLastQty = val; }
    public CalculatedCcyLastQty Get(CalculatedCcyLastQty val) { GetField(val); return val; }
    public bool IsSet(CalculatedCcyLastQty val) { return IsSetCalculatedCcyLastQty(); }
    public bool IsSetCalculatedCcyLastQty() { return IsSetField(Tags.CalculatedCcyLastQty); }

    public LastSwapPoints LastSwapPoints
    {
        get
        {
            LastSwapPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastSwapPoints val) { LastSwapPoints = val; }
    public LastSwapPoints Get(LastSwapPoints val) { GetField(val); return val; }
    public bool IsSet(LastSwapPoints val) { return IsSetLastSwapPoints(); }
    public bool IsSetLastSwapPoints() { return IsSetField(Tags.LastSwapPoints); }

    public UnderlyingSettlementDate UnderlyingSettlementDate
    {
        get
        {
            UnderlyingSettlementDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSettlementDate val) { UnderlyingSettlementDate = val; }
    public UnderlyingSettlementDate Get(UnderlyingSettlementDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSettlementDate val) { return IsSetUnderlyingSettlementDate(); }
    public bool IsSetUnderlyingSettlementDate() { return IsSetField(Tags.UnderlyingSettlementDate); }

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

    public NoRootPartyIDs NoRootPartyIDs
    {
        get
        {
            NoRootPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRootPartyIDs val) { NoRootPartyIDs = val; }
    public NoRootPartyIDs Get(NoRootPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoRootPartyIDs val) { return IsSetNoRootPartyIDs(); }
    public bool IsSetNoRootPartyIDs() { return IsSetField(Tags.NoRootPartyIDs); }

    public TradeHandlingInstr TradeHandlingInstr
    {
        get
        {
            TradeHandlingInstr val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeHandlingInstr val) { TradeHandlingInstr = val; }
    public TradeHandlingInstr Get(TradeHandlingInstr val) { GetField(val); return val; }
    public bool IsSet(TradeHandlingInstr val) { return IsSetTradeHandlingInstr(); }
    public bool IsSetTradeHandlingInstr() { return IsSetField(Tags.TradeHandlingInstr); }

    public OrigTradeHandlingInstr OrigTradeHandlingInstr
    {
        get
        {
            OrigTradeHandlingInstr val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigTradeHandlingInstr val) { OrigTradeHandlingInstr = val; }
    public OrigTradeHandlingInstr Get(OrigTradeHandlingInstr val) { GetField(val); return val; }
    public bool IsSet(OrigTradeHandlingInstr val) { return IsSetOrigTradeHandlingInstr(); }
    public bool IsSetOrigTradeHandlingInstr() { return IsSetField(Tags.OrigTradeHandlingInstr); }

    public OrigTradeDate OrigTradeDate
    {
        get
        {
            OrigTradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigTradeDate val) { OrigTradeDate = val; }
    public OrigTradeDate Get(OrigTradeDate val) { GetField(val); return val; }
    public bool IsSet(OrigTradeDate val) { return IsSetOrigTradeDate(); }
    public bool IsSetOrigTradeDate() { return IsSetField(Tags.OrigTradeDate); }

    public OrigTradeID OrigTradeID
    {
        get
        {
            OrigTradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigTradeID val) { OrigTradeID = val; }
    public OrigTradeID Get(OrigTradeID val) { GetField(val); return val; }
    public bool IsSet(OrigTradeID val) { return IsSetOrigTradeID(); }
    public bool IsSetOrigTradeID() { return IsSetField(Tags.OrigTradeID); }

    public OrigSecondaryTradeID OrigSecondaryTradeID
    {
        get
        {
            OrigSecondaryTradeID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigSecondaryTradeID val) { OrigSecondaryTradeID = val; }
    public OrigSecondaryTradeID Get(OrigSecondaryTradeID val) { GetField(val); return val; }
    public bool IsSet(OrigSecondaryTradeID val) { return IsSetOrigSecondaryTradeID(); }
    public bool IsSetOrigSecondaryTradeID() { return IsSetField(Tags.OrigSecondaryTradeID); }

    public TZTransactTime TZTransactTime
    {
        get
        {
            TZTransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TZTransactTime val) { TZTransactTime = val; }
    public TZTransactTime Get(TZTransactTime val) { GetField(val); return val; }
    public bool IsSet(TZTransactTime val) { return IsSetTZTransactTime(); }
    public bool IsSetTZTransactTime() { return IsSetField(Tags.TZTransactTime); }

    public ReportedPxDiff ReportedPxDiff
    {
        get
        {
            ReportedPxDiff val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ReportedPxDiff val) { ReportedPxDiff = val; }
    public ReportedPxDiff Get(ReportedPxDiff val) { GetField(val); return val; }
    public bool IsSet(ReportedPxDiff val) { return IsSetReportedPxDiff(); }
    public bool IsSetReportedPxDiff() { return IsSetField(Tags.ReportedPxDiff); }

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

    public RejectText RejectText
    {
        get
        {
            RejectText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RejectText val) { RejectText = val; }
    public RejectText Get(RejectText val) { GetField(val); return val; }
    public bool IsSet(RejectText val) { return IsSetRejectText(); }
    public bool IsSetRejectText() { return IsSetField(Tags.RejectText); }

    public FeeMultiplier FeeMultiplier
    {
        get
        {
            FeeMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(FeeMultiplier val) { FeeMultiplier = val; }
    public FeeMultiplier Get(FeeMultiplier val) { GetField(val); return val; }
    public bool IsSet(FeeMultiplier val) { return IsSetFeeMultiplier(); }
    public bool IsSetFeeMultiplier() { return IsSetField(Tags.FeeMultiplier); }

    public Volatility Volatility
    {
        get
        {
            Volatility val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Volatility val) { Volatility = val; }
    public Volatility Get(Volatility val) { GetField(val); return val; }
    public bool IsSet(Volatility val) { return IsSetVolatility(); }
    public bool IsSetVolatility() { return IsSetField(Tags.Volatility); }

    public DividendYield DividendYield
    {
        get
        {
            DividendYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DividendYield val) { DividendYield = val; }
    public DividendYield Get(DividendYield val) { GetField(val); return val; }
    public bool IsSet(DividendYield val) { return IsSetDividendYield(); }
    public bool IsSetDividendYield() { return IsSetField(Tags.DividendYield); }

    public RiskFreeRate RiskFreeRate
    {
        get
        {
            RiskFreeRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RiskFreeRate val) { RiskFreeRate = val; }
    public RiskFreeRate Get(RiskFreeRate val) { GetField(val); return val; }
    public bool IsSet(RiskFreeRate val) { return IsSetRiskFreeRate(); }
    public bool IsSetRiskFreeRate() { return IsSetField(Tags.RiskFreeRate); }

    public CurrencyRatio CurrencyRatio
    {
        get
        {
            CurrencyRatio val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CurrencyRatio val) { CurrencyRatio = val; }
    public CurrencyRatio Get(CurrencyRatio val) { GetField(val); return val; }
    public bool IsSet(CurrencyRatio val) { return IsSetCurrencyRatio(); }
    public bool IsSetCurrencyRatio() { return IsSetField(Tags.CurrencyRatio); }

    public NoTrdRepIndicators NoTrdRepIndicators
    {
        get
        {
            NoTrdRepIndicators val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTrdRepIndicators val) { NoTrdRepIndicators = val; }
    public NoTrdRepIndicators Get(NoTrdRepIndicators val) { GetField(val); return val; }
    public bool IsSet(NoTrdRepIndicators val) { return IsSetNoTrdRepIndicators(); }
    public bool IsSetNoTrdRepIndicators() { return IsSetField(Tags.NoTrdRepIndicators); }

    public TradePublishIndicator TradePublishIndicator
    {
        get
        {
            TradePublishIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradePublishIndicator val) { TradePublishIndicator = val; }
    public TradePublishIndicator Get(TradePublishIndicator val) { GetField(val); return val; }
    public bool IsSet(TradePublishIndicator val) { return IsSetTradePublishIndicator(); }
    public bool IsSetTradePublishIndicator() { return IsSetField(Tags.TradePublishIndicator); }

    public ApplID ApplID
    {
        get
        {
            ApplID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplID val) { ApplID = val; }
    public ApplID Get(ApplID val) { GetField(val); return val; }
    public bool IsSet(ApplID val) { return IsSetApplID(); }
    public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

    public ApplSeqNum ApplSeqNum
    {
        get
        {
            ApplSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplSeqNum val) { ApplSeqNum = val; }
    public ApplSeqNum Get(ApplSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplSeqNum val) { return IsSetApplSeqNum(); }
    public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

    public ApplLastSeqNum ApplLastSeqNum
    {
        get
        {
            ApplLastSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplLastSeqNum val) { ApplLastSeqNum = val; }
    public ApplLastSeqNum Get(ApplLastSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }
    public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

    public ApplResendFlag ApplResendFlag
    {
        get
        {
            ApplResendFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResendFlag val) { ApplResendFlag = val; }
    public ApplResendFlag Get(ApplResendFlag val) { GetField(val); return val; }
    public bool IsSet(ApplResendFlag val) { return IsSetApplResendFlag(); }
    public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

    public VenueType VenueType
    {
        get
        {
            VenueType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(VenueType val) { VenueType = val; }
    public VenueType Get(VenueType val) { GetField(val); return val; }
    public bool IsSet(VenueType val) { return IsSetVenueType(); }
    public bool IsSetVenueType() { return IsSetField(Tags.VenueType); }

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

    public class NoComplexEventsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};

        public NoComplexEventsGroup()
          : base(Tags.NoComplexEvents, Tags.ComplexEventType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoComplexEventsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ComplexEventType ComplexEventType
        {
            get
            {
                ComplexEventType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventType val) { ComplexEventType = val; }
        public ComplexEventType Get(ComplexEventType val) { GetField(val); return val; }
        public bool IsSet(ComplexEventType val) { return IsSetComplexEventType(); }
        public bool IsSetComplexEventType() { return IsSetField(Tags.ComplexEventType); }

        public ComplexOptPayoutAmount ComplexOptPayoutAmount
        {
            get
            {
                ComplexOptPayoutAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexOptPayoutAmount val) { ComplexOptPayoutAmount = val; }
        public ComplexOptPayoutAmount Get(ComplexOptPayoutAmount val) { GetField(val); return val; }
        public bool IsSet(ComplexOptPayoutAmount val) { return IsSetComplexOptPayoutAmount(); }
        public bool IsSetComplexOptPayoutAmount() { return IsSetField(Tags.ComplexOptPayoutAmount); }

        public ComplexEventPrice ComplexEventPrice
        {
            get
            {
                ComplexEventPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPrice val) { ComplexEventPrice = val; }
        public ComplexEventPrice Get(ComplexEventPrice val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPrice val) { return IsSetComplexEventPrice(); }
        public bool IsSetComplexEventPrice() { return IsSetField(Tags.ComplexEventPrice); }

        public ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
        {
            get
            {
                ComplexEventPriceBoundaryMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPriceBoundaryMethod val) { ComplexEventPriceBoundaryMethod = val; }
        public ComplexEventPriceBoundaryMethod Get(ComplexEventPriceBoundaryMethod val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPriceBoundaryMethod val) { return IsSetComplexEventPriceBoundaryMethod(); }
        public bool IsSetComplexEventPriceBoundaryMethod() { return IsSetField(Tags.ComplexEventPriceBoundaryMethod); }

        public ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
        {
            get
            {
                ComplexEventPriceBoundaryPrecision val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPriceBoundaryPrecision val) { ComplexEventPriceBoundaryPrecision = val; }
        public ComplexEventPriceBoundaryPrecision Get(ComplexEventPriceBoundaryPrecision val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPriceBoundaryPrecision val) { return IsSetComplexEventPriceBoundaryPrecision(); }
        public bool IsSetComplexEventPriceBoundaryPrecision() { return IsSetField(Tags.ComplexEventPriceBoundaryPrecision); }

        public ComplexEventPriceTimeType ComplexEventPriceTimeType
        {
            get
            {
                ComplexEventPriceTimeType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventPriceTimeType val) { ComplexEventPriceTimeType = val; }
        public ComplexEventPriceTimeType Get(ComplexEventPriceTimeType val) { GetField(val); return val; }
        public bool IsSet(ComplexEventPriceTimeType val) { return IsSetComplexEventPriceTimeType(); }
        public bool IsSetComplexEventPriceTimeType() { return IsSetField(Tags.ComplexEventPriceTimeType); }

        public ComplexEventCondition ComplexEventCondition
        {
            get
            {
                ComplexEventCondition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ComplexEventCondition val) { ComplexEventCondition = val; }
        public ComplexEventCondition Get(ComplexEventCondition val) { GetField(val); return val; }
        public bool IsSet(ComplexEventCondition val) { return IsSetComplexEventCondition(); }
        public bool IsSetComplexEventCondition() { return IsSetField(Tags.ComplexEventCondition); }

        public NoComplexEventDates NoComplexEventDates
        {
            get
            {
                NoComplexEventDates val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoComplexEventDates val) { NoComplexEventDates = val; }
        public NoComplexEventDates Get(NoComplexEventDates val) { GetField(val); return val; }
        public bool IsSet(NoComplexEventDates val) { return IsSetNoComplexEventDates(); }
        public bool IsSetNoComplexEventDates() { return IsSetField(Tags.NoComplexEventDates); }

        public class NoComplexEventDatesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};

            public NoComplexEventDatesGroup()
              : base(Tags.NoComplexEventDates, Tags.ComplexEventStartDate, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoComplexEventDatesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ComplexEventStartDate ComplexEventStartDate
            {
                get
                {
                    ComplexEventStartDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventStartDate val) { ComplexEventStartDate = val; }
            public ComplexEventStartDate Get(ComplexEventStartDate val) { GetField(val); return val; }
            public bool IsSet(ComplexEventStartDate val) { return IsSetComplexEventStartDate(); }
            public bool IsSetComplexEventStartDate() { return IsSetField(Tags.ComplexEventStartDate); }

            public ComplexEventEndDate ComplexEventEndDate
            {
                get
                {
                    ComplexEventEndDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ComplexEventEndDate val) { ComplexEventEndDate = val; }
            public ComplexEventEndDate Get(ComplexEventEndDate val) { GetField(val); return val; }
            public bool IsSet(ComplexEventEndDate val) { return IsSetComplexEventEndDate(); }
            public bool IsSetComplexEventEndDate() { return IsSetField(Tags.ComplexEventEndDate); }

            public NoComplexEventTimes NoComplexEventTimes
            {
                get
                {
                    NoComplexEventTimes val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoComplexEventTimes val) { NoComplexEventTimes = val; }
            public NoComplexEventTimes Get(NoComplexEventTimes val) { GetField(val); return val; }
            public bool IsSet(NoComplexEventTimes val) { return IsSetNoComplexEventTimes(); }
            public bool IsSetNoComplexEventTimes() { return IsSetField(Tags.NoComplexEventTimes); }

            public class NoComplexEventTimesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};

                public NoComplexEventTimesGroup()
                  : base(Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoComplexEventTimesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public ComplexEventStartTime ComplexEventStartTime
                {
                    get
                    {
                        ComplexEventStartTime val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ComplexEventStartTime val) { ComplexEventStartTime = val; }
                public ComplexEventStartTime Get(ComplexEventStartTime val) { GetField(val); return val; }
                public bool IsSet(ComplexEventStartTime val) { return IsSetComplexEventStartTime(); }
                public bool IsSetComplexEventStartTime() { return IsSetField(Tags.ComplexEventStartTime); }

                public ComplexEventEndTime ComplexEventEndTime
                {
                    get
                    {
                        ComplexEventEndTime val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ComplexEventEndTime val) { ComplexEventEndTime = val; }
                public ComplexEventEndTime Get(ComplexEventEndTime val) { GetField(val); return val; }
                public bool IsSet(ComplexEventEndTime val) { return IsSetComplexEventEndTime(); }
                public bool IsSetComplexEventEndTime() { return IsSetField(Tags.ComplexEventEndTime); }
            }
        }
    }

    public class NoUnderlyingsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, 0};

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

        public UnderlyingContractMultiplierUnit UnderlyingContractMultiplierUnit
        {
            get
            {
                UnderlyingContractMultiplierUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingContractMultiplierUnit val) { UnderlyingContractMultiplierUnit = val; }
        public UnderlyingContractMultiplierUnit Get(UnderlyingContractMultiplierUnit val) { GetField(val); return val; }
        public bool IsSet(UnderlyingContractMultiplierUnit val) { return IsSetUnderlyingContractMultiplierUnit(); }
        public bool IsSetUnderlyingContractMultiplierUnit() { return IsSetField(Tags.UnderlyingContractMultiplierUnit); }

        public UnderlyingFlowScheduleType UnderlyingFlowScheduleType
        {
            get
            {
                UnderlyingFlowScheduleType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingFlowScheduleType val) { UnderlyingFlowScheduleType = val; }
        public UnderlyingFlowScheduleType Get(UnderlyingFlowScheduleType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingFlowScheduleType val) { return IsSetUnderlyingFlowScheduleType(); }
        public bool IsSetUnderlyingFlowScheduleType() { return IsSetField(Tags.UnderlyingFlowScheduleType); }

        public UnderlyingRestructuringType UnderlyingRestructuringType
        {
            get
            {
                UnderlyingRestructuringType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingRestructuringType val) { UnderlyingRestructuringType = val; }
        public UnderlyingRestructuringType Get(UnderlyingRestructuringType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingRestructuringType val) { return IsSetUnderlyingRestructuringType(); }
        public bool IsSetUnderlyingRestructuringType() { return IsSetField(Tags.UnderlyingRestructuringType); }

        public UnderlyingSeniority UnderlyingSeniority
        {
            get
            {
                UnderlyingSeniority val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSeniority val) { UnderlyingSeniority = val; }
        public UnderlyingSeniority Get(UnderlyingSeniority val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSeniority val) { return IsSetUnderlyingSeniority(); }
        public bool IsSetUnderlyingSeniority() { return IsSetField(Tags.UnderlyingSeniority); }

        public UnderlyingNotionalPercentageOutstanding UnderlyingNotionalPercentageOutstanding
        {
            get
            {
                UnderlyingNotionalPercentageOutstanding val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingNotionalPercentageOutstanding val) { UnderlyingNotionalPercentageOutstanding = val; }
        public UnderlyingNotionalPercentageOutstanding Get(UnderlyingNotionalPercentageOutstanding val) { GetField(val); return val; }
        public bool IsSet(UnderlyingNotionalPercentageOutstanding val) { return IsSetUnderlyingNotionalPercentageOutstanding(); }
        public bool IsSetUnderlyingNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingNotionalPercentageOutstanding); }

        public UnderlyingOriginalNotionalPercentageOutstanding UnderlyingOriginalNotionalPercentageOutstanding
        {
            get
            {
                UnderlyingOriginalNotionalPercentageOutstanding val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingOriginalNotionalPercentageOutstanding val) { UnderlyingOriginalNotionalPercentageOutstanding = val; }
        public UnderlyingOriginalNotionalPercentageOutstanding Get(UnderlyingOriginalNotionalPercentageOutstanding val) { GetField(val); return val; }
        public bool IsSet(UnderlyingOriginalNotionalPercentageOutstanding val) { return IsSetUnderlyingOriginalNotionalPercentageOutstanding(); }
        public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding); }

        public UnderlyingAttachmentPoint UnderlyingAttachmentPoint
        {
            get
            {
                UnderlyingAttachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingAttachmentPoint val) { UnderlyingAttachmentPoint = val; }
        public UnderlyingAttachmentPoint Get(UnderlyingAttachmentPoint val) { GetField(val); return val; }
        public bool IsSet(UnderlyingAttachmentPoint val) { return IsSetUnderlyingAttachmentPoint(); }
        public bool IsSetUnderlyingAttachmentPoint() { return IsSetField(Tags.UnderlyingAttachmentPoint); }

        public UnderlyingDetachmentPoint UnderlyingDetachmentPoint
        {
            get
            {
                UnderlyingDetachmentPoint val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingDetachmentPoint val) { UnderlyingDetachmentPoint = val; }
        public UnderlyingDetachmentPoint Get(UnderlyingDetachmentPoint val) { GetField(val); return val; }
        public bool IsSet(UnderlyingDetachmentPoint val) { return IsSetUnderlyingDetachmentPoint(); }
        public bool IsSetUnderlyingDetachmentPoint() { return IsSetField(Tags.UnderlyingDetachmentPoint); }

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
            public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup()
              : base(Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingInstrumentPartyID UnderlyingInstrumentPartyID
            {
                get
                {
                    UnderlyingInstrumentPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartyID val) { UnderlyingInstrumentPartyID = val; }
            public UnderlyingInstrumentPartyID Get(UnderlyingInstrumentPartyID val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartyID val) { return IsSetUnderlyingInstrumentPartyID(); }
            public bool IsSetUnderlyingInstrumentPartyID() { return IsSetField(Tags.UnderlyingInstrumentPartyID); }

            public UnderlyingInstrumentPartyIDSource UnderlyingInstrumentPartyIDSource
            {
                get
                {
                    UnderlyingInstrumentPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartyIDSource val) { UnderlyingInstrumentPartyIDSource = val; }
            public UnderlyingInstrumentPartyIDSource Get(UnderlyingInstrumentPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartyIDSource val) { return IsSetUnderlyingInstrumentPartyIDSource(); }
            public bool IsSetUnderlyingInstrumentPartyIDSource() { return IsSetField(Tags.UnderlyingInstrumentPartyIDSource); }

            public UnderlyingInstrumentPartyRole UnderlyingInstrumentPartyRole
            {
                get
                {
                    UnderlyingInstrumentPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartyRole val) { UnderlyingInstrumentPartyRole = val; }
            public UnderlyingInstrumentPartyRole Get(UnderlyingInstrumentPartyRole val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartyRole val) { return IsSetUnderlyingInstrumentPartyRole(); }
            public bool IsSetUnderlyingInstrumentPartyRole() { return IsSetField(Tags.UnderlyingInstrumentPartyRole); }

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
                public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};

                public NoUndlyInstrumentPartySubIDsGroup()
                  : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUndlyInstrumentPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public UnderlyingInstrumentPartySubID UnderlyingInstrumentPartySubID
                {
                    get
                    {
                        UnderlyingInstrumentPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UnderlyingInstrumentPartySubID val) { UnderlyingInstrumentPartySubID = val; }
                public UnderlyingInstrumentPartySubID Get(UnderlyingInstrumentPartySubID val) { GetField(val); return val; }
                public bool IsSet(UnderlyingInstrumentPartySubID val) { return IsSetUnderlyingInstrumentPartySubID(); }
                public bool IsSetUnderlyingInstrumentPartySubID() { return IsSetField(Tags.UnderlyingInstrumentPartySubID); }

                public UnderlyingInstrumentPartySubIDType UnderlyingInstrumentPartySubIDType
                {
                    get
                    {
                        UnderlyingInstrumentPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UnderlyingInstrumentPartySubIDType val) { UnderlyingInstrumentPartySubIDType = val; }
                public UnderlyingInstrumentPartySubIDType Get(UnderlyingInstrumentPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(UnderlyingInstrumentPartySubIDType val) { return IsSetUnderlyingInstrumentPartySubIDType(); }
                public bool IsSetUnderlyingInstrumentPartySubIDType() { return IsSetField(Tags.UnderlyingInstrumentPartySubIDType); }
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

    public class NoLegsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegReportID, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.LegNumber, Tags.NoOfLegUnderlyings, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegReportID, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.LegNumber, Tags.NoOfLegUnderlyings, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0};

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

        public LegOptionRatio LegOptionRatio
        {
            get
            {
                LegOptionRatio val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegOptionRatio val) { LegOptionRatio = val; }
        public LegOptionRatio Get(LegOptionRatio val) { GetField(val); return val; }
        public bool IsSet(LegOptionRatio val) { return IsSetLegOptionRatio(); }
        public bool IsSetLegOptionRatio() { return IsSetField(Tags.LegOptionRatio); }

        public LegPrice LegPrice
        {
            get
            {
                LegPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPrice val) { LegPrice = val; }
        public LegPrice Get(LegPrice val) { GetField(val); return val; }
        public bool IsSet(LegPrice val) { return IsSetLegPrice(); }
        public bool IsSetLegPrice() { return IsSetField(Tags.LegPrice); }

        public LegMaturityTime LegMaturityTime
        {
            get
            {
                LegMaturityTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegMaturityTime val) { LegMaturityTime = val; }
        public LegMaturityTime Get(LegMaturityTime val) { GetField(val); return val; }
        public bool IsSet(LegMaturityTime val) { return IsSetLegMaturityTime(); }
        public bool IsSetLegMaturityTime() { return IsSetField(Tags.LegMaturityTime); }

        public LegPutOrCall LegPutOrCall
        {
            get
            {
                LegPutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPutOrCall val) { LegPutOrCall = val; }
        public LegPutOrCall Get(LegPutOrCall val) { GetField(val); return val; }
        public bool IsSet(LegPutOrCall val) { return IsSetLegPutOrCall(); }
        public bool IsSetLegPutOrCall() { return IsSetField(Tags.LegPutOrCall); }

        public LegExerciseStyle LegExerciseStyle
        {
            get
            {
                LegExerciseStyle val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegExerciseStyle val) { LegExerciseStyle = val; }
        public LegExerciseStyle Get(LegExerciseStyle val) { GetField(val); return val; }
        public bool IsSet(LegExerciseStyle val) { return IsSetLegExerciseStyle(); }
        public bool IsSetLegExerciseStyle() { return IsSetField(Tags.LegExerciseStyle); }

        public LegUnitOfMeasureQty LegUnitOfMeasureQty
        {
            get
            {
                LegUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegUnitOfMeasureQty val) { LegUnitOfMeasureQty = val; }
        public LegUnitOfMeasureQty Get(LegUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(LegUnitOfMeasureQty val) { return IsSetLegUnitOfMeasureQty(); }
        public bool IsSetLegUnitOfMeasureQty() { return IsSetField(Tags.LegUnitOfMeasureQty); }

        public LegPriceUnitOfMeasure LegPriceUnitOfMeasure
        {
            get
            {
                LegPriceUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPriceUnitOfMeasure val) { LegPriceUnitOfMeasure = val; }
        public LegPriceUnitOfMeasure Get(LegPriceUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(LegPriceUnitOfMeasure val) { return IsSetLegPriceUnitOfMeasure(); }
        public bool IsSetLegPriceUnitOfMeasure() { return IsSetField(Tags.LegPriceUnitOfMeasure); }

        public LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
        {
            get
            {
                LegPriceUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPriceUnitOfMeasureQty val) { LegPriceUnitOfMeasureQty = val; }
        public LegPriceUnitOfMeasureQty Get(LegPriceUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(LegPriceUnitOfMeasureQty val) { return IsSetLegPriceUnitOfMeasureQty(); }
        public bool IsSetLegPriceUnitOfMeasureQty() { return IsSetField(Tags.LegPriceUnitOfMeasureQty); }

        public LegContractMultiplierUnit LegContractMultiplierUnit
        {
            get
            {
                LegContractMultiplierUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegContractMultiplierUnit val) { LegContractMultiplierUnit = val; }
        public LegContractMultiplierUnit Get(LegContractMultiplierUnit val) { GetField(val); return val; }
        public bool IsSet(LegContractMultiplierUnit val) { return IsSetLegContractMultiplierUnit(); }
        public bool IsSetLegContractMultiplierUnit() { return IsSetField(Tags.LegContractMultiplierUnit); }

        public LegFlowScheduleType LegFlowScheduleType
        {
            get
            {
                LegFlowScheduleType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegFlowScheduleType val) { LegFlowScheduleType = val; }
        public LegFlowScheduleType Get(LegFlowScheduleType val) { GetField(val); return val; }
        public bool IsSet(LegFlowScheduleType val) { return IsSetLegFlowScheduleType(); }
        public bool IsSetLegFlowScheduleType() { return IsSetField(Tags.LegFlowScheduleType); }

        public LegQty LegQty
        {
            get
            {
                LegQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegQty val) { LegQty = val; }
        public LegQty Get(LegQty val) { GetField(val); return val; }
        public bool IsSet(LegQty val) { return IsSetLegQty(); }
        public bool IsSetLegQty() { return IsSetField(Tags.LegQty); }

        public LegSwapType LegSwapType
        {
            get
            {
                LegSwapType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSwapType val) { LegSwapType = val; }
        public LegSwapType Get(LegSwapType val) { GetField(val); return val; }
        public bool IsSet(LegSwapType val) { return IsSetLegSwapType(); }
        public bool IsSetLegSwapType() { return IsSetField(Tags.LegSwapType); }

        public NoLegStipulations NoLegStipulations
        {
            get
            {
                NoLegStipulations val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegStipulations val) { NoLegStipulations = val; }
        public NoLegStipulations Get(NoLegStipulations val) { GetField(val); return val; }
        public bool IsSet(NoLegStipulations val) { return IsSetNoLegStipulations(); }
        public bool IsSetNoLegStipulations() { return IsSetField(Tags.NoLegStipulations); }

        public LegPositionEffect LegPositionEffect
        {
            get
            {
                LegPositionEffect val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegPositionEffect val) { LegPositionEffect = val; }
        public LegPositionEffect Get(LegPositionEffect val) { GetField(val); return val; }
        public bool IsSet(LegPositionEffect val) { return IsSetLegPositionEffect(); }
        public bool IsSetLegPositionEffect() { return IsSetField(Tags.LegPositionEffect); }

        public LegCoveredOrUncovered LegCoveredOrUncovered
        {
            get
            {
                LegCoveredOrUncovered val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCoveredOrUncovered val) { LegCoveredOrUncovered = val; }
        public LegCoveredOrUncovered Get(LegCoveredOrUncovered val) { GetField(val); return val; }
        public bool IsSet(LegCoveredOrUncovered val) { return IsSetLegCoveredOrUncovered(); }
        public bool IsSetLegCoveredOrUncovered() { return IsSetField(Tags.LegCoveredOrUncovered); }

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

        public LegRefID LegRefID
        {
            get
            {
                LegRefID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegRefID val) { LegRefID = val; }
        public LegRefID Get(LegRefID val) { GetField(val); return val; }
        public bool IsSet(LegRefID val) { return IsSetLegRefID(); }
        public bool IsSetLegRefID() { return IsSetField(Tags.LegRefID); }

        public LegSettlType LegSettlType
        {
            get
            {
                LegSettlType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlType val) { LegSettlType = val; }
        public LegSettlType Get(LegSettlType val) { GetField(val); return val; }
        public bool IsSet(LegSettlType val) { return IsSetLegSettlType(); }
        public bool IsSetLegSettlType() { return IsSetField(Tags.LegSettlType); }

        public LegSettlDate LegSettlDate
        {
            get
            {
                LegSettlDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlDate val) { LegSettlDate = val; }
        public LegSettlDate Get(LegSettlDate val) { GetField(val); return val; }
        public bool IsSet(LegSettlDate val) { return IsSetLegSettlDate(); }
        public bool IsSetLegSettlDate() { return IsSetField(Tags.LegSettlDate); }

        public LegLastPx LegLastPx
        {
            get
            {
                LegLastPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastPx val) { LegLastPx = val; }
        public LegLastPx Get(LegLastPx val) { GetField(val); return val; }
        public bool IsSet(LegLastPx val) { return IsSetLegLastPx(); }
        public bool IsSetLegLastPx() { return IsSetField(Tags.LegLastPx); }

        public LegReportID LegReportID
        {
            get
            {
                LegReportID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegReportID val) { LegReportID = val; }
        public LegReportID Get(LegReportID val) { GetField(val); return val; }
        public bool IsSet(LegReportID val) { return IsSetLegReportID(); }
        public bool IsSetLegReportID() { return IsSetField(Tags.LegReportID); }

        public LegSettlCurrency LegSettlCurrency
        {
            get
            {
                LegSettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegSettlCurrency val) { LegSettlCurrency = val; }
        public LegSettlCurrency Get(LegSettlCurrency val) { GetField(val); return val; }
        public bool IsSet(LegSettlCurrency val) { return IsSetLegSettlCurrency(); }
        public bool IsSetLegSettlCurrency() { return IsSetField(Tags.LegSettlCurrency); }

        public LegLastForwardPoints LegLastForwardPoints
        {
            get
            {
                LegLastForwardPoints val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastForwardPoints val) { LegLastForwardPoints = val; }
        public LegLastForwardPoints Get(LegLastForwardPoints val) { GetField(val); return val; }
        public bool IsSet(LegLastForwardPoints val) { return IsSetLegLastForwardPoints(); }
        public bool IsSetLegLastForwardPoints() { return IsSetField(Tags.LegLastForwardPoints); }

        public LegCalculatedCcyLastQty LegCalculatedCcyLastQty
        {
            get
            {
                LegCalculatedCcyLastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCalculatedCcyLastQty val) { LegCalculatedCcyLastQty = val; }
        public LegCalculatedCcyLastQty Get(LegCalculatedCcyLastQty val) { GetField(val); return val; }
        public bool IsSet(LegCalculatedCcyLastQty val) { return IsSetLegCalculatedCcyLastQty(); }
        public bool IsSetLegCalculatedCcyLastQty() { return IsSetField(Tags.LegCalculatedCcyLastQty); }

        public LegGrossTradeAmt LegGrossTradeAmt
        {
            get
            {
                LegGrossTradeAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegGrossTradeAmt val) { LegGrossTradeAmt = val; }
        public LegGrossTradeAmt Get(LegGrossTradeAmt val) { GetField(val); return val; }
        public bool IsSet(LegGrossTradeAmt val) { return IsSetLegGrossTradeAmt(); }
        public bool IsSetLegGrossTradeAmt() { return IsSetField(Tags.LegGrossTradeAmt); }

        public LegNumber LegNumber
        {
            get
            {
                LegNumber val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegNumber val) { LegNumber = val; }
        public LegNumber Get(LegNumber val) { GetField(val); return val; }
        public bool IsSet(LegNumber val) { return IsSetLegNumber(); }
        public bool IsSetLegNumber() { return IsSetField(Tags.LegNumber); }

        public NoOfLegUnderlyings NoOfLegUnderlyings
        {
            get
            {
                NoOfLegUnderlyings val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoOfLegUnderlyings val) { NoOfLegUnderlyings = val; }
        public NoOfLegUnderlyings Get(NoOfLegUnderlyings val) { GetField(val); return val; }
        public bool IsSet(NoOfLegUnderlyings val) { return IsSetNoOfLegUnderlyings(); }
        public bool IsSetNoOfLegUnderlyings() { return IsSetField(Tags.NoOfLegUnderlyings); }

        public LegVolatility LegVolatility
        {
            get
            {
                LegVolatility val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegVolatility val) { LegVolatility = val; }
        public LegVolatility Get(LegVolatility val) { GetField(val); return val; }
        public bool IsSet(LegVolatility val) { return IsSetLegVolatility(); }
        public bool IsSetLegVolatility() { return IsSetField(Tags.LegVolatility); }

        public LegDividendYield LegDividendYield
        {
            get
            {
                LegDividendYield val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegDividendYield val) { LegDividendYield = val; }
        public LegDividendYield Get(LegDividendYield val) { GetField(val); return val; }
        public bool IsSet(LegDividendYield val) { return IsSetLegDividendYield(); }
        public bool IsSetLegDividendYield() { return IsSetField(Tags.LegDividendYield); }

        public LegCurrencyRatio LegCurrencyRatio
        {
            get
            {
                LegCurrencyRatio val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegCurrencyRatio val) { LegCurrencyRatio = val; }
        public LegCurrencyRatio Get(LegCurrencyRatio val) { GetField(val); return val; }
        public bool IsSet(LegCurrencyRatio val) { return IsSetLegCurrencyRatio(); }
        public bool IsSetLegCurrencyRatio() { return IsSetField(Tags.LegCurrencyRatio); }

        public LegExecInst LegExecInst
        {
            get
            {
                LegExecInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegExecInst val) { LegExecInst = val; }
        public LegExecInst Get(LegExecInst val) { GetField(val); return val; }
        public bool IsSet(LegExecInst val) { return IsSetLegExecInst(); }
        public bool IsSetLegExecInst() { return IsSetField(Tags.LegExecInst); }

        public LegLastQty LegLastQty
        {
            get
            {
                LegLastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LegLastQty val) { LegLastQty = val; }
        public LegLastQty Get(LegLastQty val) { GetField(val); return val; }
        public bool IsSet(LegLastQty val) { return IsSetLegLastQty(); }
        public bool IsSetLegLastQty() { return IsSetField(Tags.LegLastQty); }

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

        public class NoLegStipulationsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegStipulationType, Tags.LegStipulationValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};

            public NoLegStipulationsGroup()
              : base(Tags.NoLegStipulations, Tags.LegStipulationType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegStipulationType LegStipulationType
            {
                get
                {
                    LegStipulationType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStipulationType val) { LegStipulationType = val; }
            public LegStipulationType Get(LegStipulationType val) { GetField(val); return val; }
            public bool IsSet(LegStipulationType val) { return IsSetLegStipulationType(); }
            public bool IsSetLegStipulationType() { return IsSetField(Tags.LegStipulationType); }

            public LegStipulationValue LegStipulationValue
            {
                get
                {
                    LegStipulationValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStipulationValue val) { LegStipulationValue = val; }
            public LegStipulationValue Get(LegStipulationValue val) { GetField(val); return val; }
            public bool IsSet(LegStipulationValue val) { return IsSetLegStipulationValue(); }
            public bool IsSetLegStipulationValue() { return IsSetField(Tags.LegStipulationValue); }
        }

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

        public class NoOfLegUnderlyingsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingLegSymbol, Tags.UnderlyingLegSymbolSfx, Tags.UnderlyingLegSecurityID, Tags.UnderlyingLegSecurityIDSource, Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegCFICode, Tags.UnderlyingLegSecurityType, Tags.UnderlyingLegSecuritySubType, Tags.UnderlyingLegMaturityMonthYear, Tags.UnderlyingLegMaturityDate, Tags.UnderlyingLegMaturityTime, Tags.UnderlyingLegStrikePrice, Tags.UnderlyingLegOptAttribute, Tags.UnderlyingLegPutOrCall, Tags.UnderlyingLegSecurityExchange, Tags.UnderlyingLegSecurityDesc, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UnderlyingLegSymbol, Tags.UnderlyingLegSymbolSfx, Tags.UnderlyingLegSecurityID, Tags.UnderlyingLegSecurityIDSource, Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegCFICode, Tags.UnderlyingLegSecurityType, Tags.UnderlyingLegSecuritySubType, Tags.UnderlyingLegMaturityMonthYear, Tags.UnderlyingLegMaturityDate, Tags.UnderlyingLegMaturityTime, Tags.UnderlyingLegStrikePrice, Tags.UnderlyingLegOptAttribute, Tags.UnderlyingLegPutOrCall, Tags.UnderlyingLegSecurityExchange, Tags.UnderlyingLegSecurityDesc, 0};

            public NoOfLegUnderlyingsGroup()
              : base(Tags.NoOfLegUnderlyings, Tags.UnderlyingLegSymbol, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoOfLegUnderlyingsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingLegSymbol UnderlyingLegSymbol
            {
                get
                {
                    UnderlyingLegSymbol val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSymbol val) { UnderlyingLegSymbol = val; }
            public UnderlyingLegSymbol Get(UnderlyingLegSymbol val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSymbol val) { return IsSetUnderlyingLegSymbol(); }
            public bool IsSetUnderlyingLegSymbol() { return IsSetField(Tags.UnderlyingLegSymbol); }

            public UnderlyingLegSymbolSfx UnderlyingLegSymbolSfx
            {
                get
                {
                    UnderlyingLegSymbolSfx val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSymbolSfx val) { UnderlyingLegSymbolSfx = val; }
            public UnderlyingLegSymbolSfx Get(UnderlyingLegSymbolSfx val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSymbolSfx val) { return IsSetUnderlyingLegSymbolSfx(); }
            public bool IsSetUnderlyingLegSymbolSfx() { return IsSetField(Tags.UnderlyingLegSymbolSfx); }

            public UnderlyingLegSecurityID UnderlyingLegSecurityID
            {
                get
                {
                    UnderlyingLegSecurityID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSecurityID val) { UnderlyingLegSecurityID = val; }
            public UnderlyingLegSecurityID Get(UnderlyingLegSecurityID val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSecurityID val) { return IsSetUnderlyingLegSecurityID(); }
            public bool IsSetUnderlyingLegSecurityID() { return IsSetField(Tags.UnderlyingLegSecurityID); }

            public UnderlyingLegSecurityIDSource UnderlyingLegSecurityIDSource
            {
                get
                {
                    UnderlyingLegSecurityIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSecurityIDSource val) { UnderlyingLegSecurityIDSource = val; }
            public UnderlyingLegSecurityIDSource Get(UnderlyingLegSecurityIDSource val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSecurityIDSource val) { return IsSetUnderlyingLegSecurityIDSource(); }
            public bool IsSetUnderlyingLegSecurityIDSource() { return IsSetField(Tags.UnderlyingLegSecurityIDSource); }

            public NoUnderlyingLegSecurityAltID NoUnderlyingLegSecurityAltID
            {
                get
                {
                    NoUnderlyingLegSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoUnderlyingLegSecurityAltID val) { NoUnderlyingLegSecurityAltID = val; }
            public NoUnderlyingLegSecurityAltID Get(NoUnderlyingLegSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(NoUnderlyingLegSecurityAltID val) { return IsSetNoUnderlyingLegSecurityAltID(); }
            public bool IsSetNoUnderlyingLegSecurityAltID() { return IsSetField(Tags.NoUnderlyingLegSecurityAltID); }

            public UnderlyingLegCFICode UnderlyingLegCFICode
            {
                get
                {
                    UnderlyingLegCFICode val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegCFICode val) { UnderlyingLegCFICode = val; }
            public UnderlyingLegCFICode Get(UnderlyingLegCFICode val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegCFICode val) { return IsSetUnderlyingLegCFICode(); }
            public bool IsSetUnderlyingLegCFICode() { return IsSetField(Tags.UnderlyingLegCFICode); }

            public UnderlyingLegSecurityType UnderlyingLegSecurityType
            {
                get
                {
                    UnderlyingLegSecurityType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSecurityType val) { UnderlyingLegSecurityType = val; }
            public UnderlyingLegSecurityType Get(UnderlyingLegSecurityType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSecurityType val) { return IsSetUnderlyingLegSecurityType(); }
            public bool IsSetUnderlyingLegSecurityType() { return IsSetField(Tags.UnderlyingLegSecurityType); }

            public UnderlyingLegSecuritySubType UnderlyingLegSecuritySubType
            {
                get
                {
                    UnderlyingLegSecuritySubType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSecuritySubType val) { UnderlyingLegSecuritySubType = val; }
            public UnderlyingLegSecuritySubType Get(UnderlyingLegSecuritySubType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSecuritySubType val) { return IsSetUnderlyingLegSecuritySubType(); }
            public bool IsSetUnderlyingLegSecuritySubType() { return IsSetField(Tags.UnderlyingLegSecuritySubType); }

            public UnderlyingLegMaturityMonthYear UnderlyingLegMaturityMonthYear
            {
                get
                {
                    UnderlyingLegMaturityMonthYear val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegMaturityMonthYear val) { UnderlyingLegMaturityMonthYear = val; }
            public UnderlyingLegMaturityMonthYear Get(UnderlyingLegMaturityMonthYear val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegMaturityMonthYear val) { return IsSetUnderlyingLegMaturityMonthYear(); }
            public bool IsSetUnderlyingLegMaturityMonthYear() { return IsSetField(Tags.UnderlyingLegMaturityMonthYear); }

            public UnderlyingLegMaturityDate UnderlyingLegMaturityDate
            {
                get
                {
                    UnderlyingLegMaturityDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegMaturityDate val) { UnderlyingLegMaturityDate = val; }
            public UnderlyingLegMaturityDate Get(UnderlyingLegMaturityDate val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegMaturityDate val) { return IsSetUnderlyingLegMaturityDate(); }
            public bool IsSetUnderlyingLegMaturityDate() { return IsSetField(Tags.UnderlyingLegMaturityDate); }

            public UnderlyingLegMaturityTime UnderlyingLegMaturityTime
            {
                get
                {
                    UnderlyingLegMaturityTime val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegMaturityTime val) { UnderlyingLegMaturityTime = val; }
            public UnderlyingLegMaturityTime Get(UnderlyingLegMaturityTime val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegMaturityTime val) { return IsSetUnderlyingLegMaturityTime(); }
            public bool IsSetUnderlyingLegMaturityTime() { return IsSetField(Tags.UnderlyingLegMaturityTime); }

            public UnderlyingLegStrikePrice UnderlyingLegStrikePrice
            {
                get
                {
                    UnderlyingLegStrikePrice val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegStrikePrice val) { UnderlyingLegStrikePrice = val; }
            public UnderlyingLegStrikePrice Get(UnderlyingLegStrikePrice val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegStrikePrice val) { return IsSetUnderlyingLegStrikePrice(); }
            public bool IsSetUnderlyingLegStrikePrice() { return IsSetField(Tags.UnderlyingLegStrikePrice); }

            public UnderlyingLegOptAttribute UnderlyingLegOptAttribute
            {
                get
                {
                    UnderlyingLegOptAttribute val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegOptAttribute val) { UnderlyingLegOptAttribute = val; }
            public UnderlyingLegOptAttribute Get(UnderlyingLegOptAttribute val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegOptAttribute val) { return IsSetUnderlyingLegOptAttribute(); }
            public bool IsSetUnderlyingLegOptAttribute() { return IsSetField(Tags.UnderlyingLegOptAttribute); }

            public UnderlyingLegPutOrCall UnderlyingLegPutOrCall
            {
                get
                {
                    UnderlyingLegPutOrCall val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegPutOrCall val) { UnderlyingLegPutOrCall = val; }
            public UnderlyingLegPutOrCall Get(UnderlyingLegPutOrCall val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegPutOrCall val) { return IsSetUnderlyingLegPutOrCall(); }
            public bool IsSetUnderlyingLegPutOrCall() { return IsSetField(Tags.UnderlyingLegPutOrCall); }

            public UnderlyingLegSecurityExchange UnderlyingLegSecurityExchange
            {
                get
                {
                    UnderlyingLegSecurityExchange val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSecurityExchange val) { UnderlyingLegSecurityExchange = val; }
            public UnderlyingLegSecurityExchange Get(UnderlyingLegSecurityExchange val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSecurityExchange val) { return IsSetUnderlyingLegSecurityExchange(); }
            public bool IsSetUnderlyingLegSecurityExchange() { return IsSetField(Tags.UnderlyingLegSecurityExchange); }

            public UnderlyingLegSecurityDesc UnderlyingLegSecurityDesc
            {
                get
                {
                    UnderlyingLegSecurityDesc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingLegSecurityDesc val) { UnderlyingLegSecurityDesc = val; }
            public UnderlyingLegSecurityDesc Get(UnderlyingLegSecurityDesc val) { GetField(val); return val; }
            public bool IsSet(UnderlyingLegSecurityDesc val) { return IsSetUnderlyingLegSecurityDesc(); }
            public bool IsSetUnderlyingLegSecurityDesc() { return IsSetField(Tags.UnderlyingLegSecurityDesc); }

            public class NoUnderlyingLegSecurityAltIDGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.UnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltIDSource, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.UnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltIDSource, 0};

                public NoUnderlyingLegSecurityAltIDGroup()
                  : base(Tags.NoUnderlyingLegSecurityAltID, Tags.UnderlyingLegSecurityAltID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUnderlyingLegSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public UnderlyingLegSecurityAltID UnderlyingLegSecurityAltID
                {
                    get
                    {
                        UnderlyingLegSecurityAltID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UnderlyingLegSecurityAltID val) { UnderlyingLegSecurityAltID = val; }
                public UnderlyingLegSecurityAltID Get(UnderlyingLegSecurityAltID val) { GetField(val); return val; }
                public bool IsSet(UnderlyingLegSecurityAltID val) { return IsSetUnderlyingLegSecurityAltID(); }
                public bool IsSetUnderlyingLegSecurityAltID() { return IsSetField(Tags.UnderlyingLegSecurityAltID); }

                public UnderlyingLegSecurityAltIDSource UnderlyingLegSecurityAltIDSource
                {
                    get
                    {
                        UnderlyingLegSecurityAltIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(UnderlyingLegSecurityAltIDSource val) { UnderlyingLegSecurityAltIDSource = val; }
                public UnderlyingLegSecurityAltIDSource Get(UnderlyingLegSecurityAltIDSource val) { GetField(val); return val; }
                public bool IsSet(UnderlyingLegSecurityAltIDSource val) { return IsSetUnderlyingLegSecurityAltIDSource(); }
                public bool IsSetUnderlyingLegSecurityAltIDSource() { return IsSetField(Tags.UnderlyingLegSecurityAltIDSource); }
            }
        }
    }

    public class NoTrdRegTimestampsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};

        public NoTrdRegTimestampsGroup()
          : base(Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTrdRegTimestampsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TrdRegTimestamp TrdRegTimestamp
        {
            get
            {
                TrdRegTimestamp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestamp val) { TrdRegTimestamp = val; }
        public TrdRegTimestamp Get(TrdRegTimestamp val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestamp val) { return IsSetTrdRegTimestamp(); }
        public bool IsSetTrdRegTimestamp() { return IsSetField(Tags.TrdRegTimestamp); }

        public TrdRegTimestampType TrdRegTimestampType
        {
            get
            {
                TrdRegTimestampType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestampType val) { TrdRegTimestampType = val; }
        public TrdRegTimestampType Get(TrdRegTimestampType val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestampType val) { return IsSetTrdRegTimestampType(); }
        public bool IsSetTrdRegTimestampType() { return IsSetField(Tags.TrdRegTimestampType); }

        public TrdRegTimestampOrigin TrdRegTimestampOrigin
        {
            get
            {
                TrdRegTimestampOrigin val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRegTimestampOrigin val) { TrdRegTimestampOrigin = val; }
        public TrdRegTimestampOrigin Get(TrdRegTimestampOrigin val) { GetField(val); return val; }
        public bool IsSet(TrdRegTimestampOrigin val) { return IsSetTrdRegTimestampOrigin(); }
        public bool IsSetTrdRegTimestampOrigin() { return IsSetField(Tags.TrdRegTimestampOrigin); }

        public DeskType DeskType
        {
            get
            {
                DeskType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskType val) { DeskType = val; }
        public DeskType Get(DeskType val) { GetField(val); return val; }
        public bool IsSet(DeskType val) { return IsSetDeskType(); }
        public bool IsSetDeskType() { return IsSetField(Tags.DeskType); }

        public DeskTypeSource DeskTypeSource
        {
            get
            {
                DeskTypeSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskTypeSource val) { DeskTypeSource = val; }
        public DeskTypeSource Get(DeskTypeSource val) { GetField(val); return val; }
        public bool IsSet(DeskTypeSource val) { return IsSetDeskTypeSource(); }
        public bool IsSetDeskTypeSource() { return IsSetField(Tags.DeskTypeSource); }

        public DeskOrderHandlingInst DeskOrderHandlingInst
        {
            get
            {
                DeskOrderHandlingInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeskOrderHandlingInst val) { DeskOrderHandlingInst = val; }
        public DeskOrderHandlingInst Get(DeskOrderHandlingInst val) { GetField(val); return val; }
        public bool IsSet(DeskOrderHandlingInst val) { return IsSetDeskOrderHandlingInst(); }
        public bool IsSetDeskOrderHandlingInst() { return IsSetField(Tags.DeskOrderHandlingInst); }
    }

    public class NoSidesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Side, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.ComplianceID, Tags.SolicitedFlag, Tags.CustOrderCapacity, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.SideLastQty, Tags.SideTradeReportID, Tags.SideFillStationCd, Tags.SideReasonCd, Tags.RptSeq, Tags.SideTrdSubTyp, Tags.NoSideTrdRegTS, Tags.SideGrossTradeAmt, Tags.AggressorIndicator, Tags.ExchangeSpecialInstructions, Tags.NetGrossInd, Tags.SideCurrency, Tags.SideSettlCurrency, Tags.NoSettlDetails, Tags.OrderCategory, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.RefOrderID, Tags.RefOrderIDSource, Tags.RefOrdIDReason, Tags.OrdType, Tags.Price, Tags.StopPx, Tags.ExecInst, Tags.OrdStatus, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.LeavesQty, Tags.CumQty, Tags.TimeInForce, Tags.ExpireTime, Tags.SecondaryDisplayQty, Tags.DisplayWhen, Tags.DisplayMethod, Tags.DisplayLowQty, Tags.DisplayHighQty, Tags.DisplayMinIncr, Tags.RefreshQty, Tags.DisplayQty, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.OrigCustOrderCapacity, Tags.OrderInputDevice, Tags.LotType, Tags.TransBkdTime, Tags.OrigOrdModTime, Tags.BookingType, Tags.SideExecID, Tags.OrderDelay, Tags.OrderDelayUnit, Tags.SideLiquidityInd, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Side, Tags.NoPartyIDs, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.ComplianceID, Tags.SolicitedFlag, Tags.CustOrderCapacity, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TimeBracket, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.InterestAtMaturity, Tags.EndAccruedInterestAmt, Tags.StartCash, Tags.EndCash, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SideMultiLegReportingType, Tags.NoContAmts, Tags.NoStipulations, Tags.NoMiscFees, Tags.ExchangeRule, Tags.TradeAllocIndicator, Tags.PreallocMethod, Tags.AllocID, Tags.NoAllocs, Tags.SideLastQty, Tags.SideTradeReportID, Tags.SideFillStationCd, Tags.SideReasonCd, Tags.RptSeq, Tags.SideTrdSubTyp, Tags.NoSideTrdRegTS, Tags.SideGrossTradeAmt, Tags.AggressorIndicator, Tags.ExchangeSpecialInstructions, Tags.NetGrossInd, Tags.SideCurrency, Tags.SideSettlCurrency, Tags.NoSettlDetails, Tags.OrderCategory, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListID, Tags.RefOrderID, Tags.RefOrderIDSource, Tags.RefOrdIDReason, Tags.OrdType, Tags.Price, Tags.StopPx, Tags.ExecInst, Tags.OrdStatus, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.LeavesQty, Tags.CumQty, Tags.TimeInForce, Tags.ExpireTime, Tags.SecondaryDisplayQty, Tags.DisplayWhen, Tags.DisplayMethod, Tags.DisplayLowQty, Tags.DisplayHighQty, Tags.DisplayMinIncr, Tags.RefreshQty, Tags.DisplayQty, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.OrigCustOrderCapacity, Tags.OrderInputDevice, Tags.LotType, Tags.TransBkdTime, Tags.OrigOrdModTime, Tags.BookingType, Tags.SideExecID, Tags.OrderDelay, Tags.OrderDelayUnit, Tags.SideLiquidityInd, 0};

        public NoSidesGroup()
          : base(Tags.NoSides, Tags.Side, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoSidesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public AcctIDSource AcctIDSource
        {
            get
            {
                AcctIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AcctIDSource val) { AcctIDSource = val; }
        public AcctIDSource Get(AcctIDSource val) { GetField(val); return val; }
        public bool IsSet(AcctIDSource val) { return IsSetAcctIDSource(); }
        public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

        public AccountType AccountType
        {
            get
            {
                AccountType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AccountType val) { AccountType = val; }
        public AccountType Get(AccountType val) { GetField(val); return val; }
        public bool IsSet(AccountType val) { return IsSetAccountType(); }
        public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

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

        public OddLot OddLot
        {
            get
            {
                OddLot val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OddLot val) { OddLot = val; }
        public OddLot Get(OddLot val) { GetField(val); return val; }
        public bool IsSet(OddLot val) { return IsSetOddLot(); }
        public bool IsSetOddLot() { return IsSetField(Tags.OddLot); }

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

        public TimeBracket TimeBracket
        {
            get
            {
                TimeBracket val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TimeBracket val) { TimeBracket = val; }
        public TimeBracket Get(TimeBracket val) { GetField(val); return val; }
        public bool IsSet(TimeBracket val) { return IsSetTimeBracket(); }
        public bool IsSetTimeBracket() { return IsSetField(Tags.TimeBracket); }

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

        public ExDate ExDate
        {
            get
            {
                ExDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExDate val) { ExDate = val; }
        public ExDate Get(ExDate val) { GetField(val); return val; }
        public bool IsSet(ExDate val) { return IsSetExDate(); }
        public bool IsSetExDate() { return IsSetField(Tags.ExDate); }

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

        public SideMultiLegReportingType SideMultiLegReportingType
        {
            get
            {
                SideMultiLegReportingType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideMultiLegReportingType val) { SideMultiLegReportingType = val; }
        public SideMultiLegReportingType Get(SideMultiLegReportingType val) { GetField(val); return val; }
        public bool IsSet(SideMultiLegReportingType val) { return IsSetSideMultiLegReportingType(); }
        public bool IsSetSideMultiLegReportingType() { return IsSetField(Tags.SideMultiLegReportingType); }

        public NoContAmts NoContAmts
        {
            get
            {
                NoContAmts val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoContAmts val) { NoContAmts = val; }
        public NoContAmts Get(NoContAmts val) { GetField(val); return val; }
        public bool IsSet(NoContAmts val) { return IsSetNoContAmts(); }
        public bool IsSetNoContAmts() { return IsSetField(Tags.NoContAmts); }

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

        public ExchangeRule ExchangeRule
        {
            get
            {
                ExchangeRule val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExchangeRule val) { ExchangeRule = val; }
        public ExchangeRule Get(ExchangeRule val) { GetField(val); return val; }
        public bool IsSet(ExchangeRule val) { return IsSetExchangeRule(); }
        public bool IsSetExchangeRule() { return IsSetField(Tags.ExchangeRule); }

        public TradeAllocIndicator TradeAllocIndicator
        {
            get
            {
                TradeAllocIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeAllocIndicator val) { TradeAllocIndicator = val; }
        public TradeAllocIndicator Get(TradeAllocIndicator val) { GetField(val); return val; }
        public bool IsSet(TradeAllocIndicator val) { return IsSetTradeAllocIndicator(); }
        public bool IsSetTradeAllocIndicator() { return IsSetField(Tags.TradeAllocIndicator); }

        public PreallocMethod PreallocMethod
        {
            get
            {
                PreallocMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PreallocMethod val) { PreallocMethod = val; }
        public PreallocMethod Get(PreallocMethod val) { GetField(val); return val; }
        public bool IsSet(PreallocMethod val) { return IsSetPreallocMethod(); }
        public bool IsSetPreallocMethod() { return IsSetField(Tags.PreallocMethod); }

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

        public SideLastQty SideLastQty
        {
            get
            {
                SideLastQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideLastQty val) { SideLastQty = val; }
        public SideLastQty Get(SideLastQty val) { GetField(val); return val; }
        public bool IsSet(SideLastQty val) { return IsSetSideLastQty(); }
        public bool IsSetSideLastQty() { return IsSetField(Tags.SideLastQty); }

        public SideTradeReportID SideTradeReportID
        {
            get
            {
                SideTradeReportID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideTradeReportID val) { SideTradeReportID = val; }
        public SideTradeReportID Get(SideTradeReportID val) { GetField(val); return val; }
        public bool IsSet(SideTradeReportID val) { return IsSetSideTradeReportID(); }
        public bool IsSetSideTradeReportID() { return IsSetField(Tags.SideTradeReportID); }

        public SideFillStationCd SideFillStationCd
        {
            get
            {
                SideFillStationCd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideFillStationCd val) { SideFillStationCd = val; }
        public SideFillStationCd Get(SideFillStationCd val) { GetField(val); return val; }
        public bool IsSet(SideFillStationCd val) { return IsSetSideFillStationCd(); }
        public bool IsSetSideFillStationCd() { return IsSetField(Tags.SideFillStationCd); }

        public SideReasonCd SideReasonCd
        {
            get
            {
                SideReasonCd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideReasonCd val) { SideReasonCd = val; }
        public SideReasonCd Get(SideReasonCd val) { GetField(val); return val; }
        public bool IsSet(SideReasonCd val) { return IsSetSideReasonCd(); }
        public bool IsSetSideReasonCd() { return IsSetField(Tags.SideReasonCd); }

        public RptSeq RptSeq
        {
            get
            {
                RptSeq val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RptSeq val) { RptSeq = val; }
        public RptSeq Get(RptSeq val) { GetField(val); return val; }
        public bool IsSet(RptSeq val) { return IsSetRptSeq(); }
        public bool IsSetRptSeq() { return IsSetField(Tags.RptSeq); }

        public SideTrdSubTyp SideTrdSubTyp
        {
            get
            {
                SideTrdSubTyp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideTrdSubTyp val) { SideTrdSubTyp = val; }
        public SideTrdSubTyp Get(SideTrdSubTyp val) { GetField(val); return val; }
        public bool IsSet(SideTrdSubTyp val) { return IsSetSideTrdSubTyp(); }
        public bool IsSetSideTrdSubTyp() { return IsSetField(Tags.SideTrdSubTyp); }

        public NoSideTrdRegTS NoSideTrdRegTS
        {
            get
            {
                NoSideTrdRegTS val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoSideTrdRegTS val) { NoSideTrdRegTS = val; }
        public NoSideTrdRegTS Get(NoSideTrdRegTS val) { GetField(val); return val; }
        public bool IsSet(NoSideTrdRegTS val) { return IsSetNoSideTrdRegTS(); }
        public bool IsSetNoSideTrdRegTS() { return IsSetField(Tags.NoSideTrdRegTS); }

        public SideGrossTradeAmt SideGrossTradeAmt
        {
            get
            {
                SideGrossTradeAmt val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideGrossTradeAmt val) { SideGrossTradeAmt = val; }
        public SideGrossTradeAmt Get(SideGrossTradeAmt val) { GetField(val); return val; }
        public bool IsSet(SideGrossTradeAmt val) { return IsSetSideGrossTradeAmt(); }
        public bool IsSetSideGrossTradeAmt() { return IsSetField(Tags.SideGrossTradeAmt); }

        public AggressorIndicator AggressorIndicator
        {
            get
            {
                AggressorIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(AggressorIndicator val) { AggressorIndicator = val; }
        public AggressorIndicator Get(AggressorIndicator val) { GetField(val); return val; }
        public bool IsSet(AggressorIndicator val) { return IsSetAggressorIndicator(); }
        public bool IsSetAggressorIndicator() { return IsSetField(Tags.AggressorIndicator); }

        public ExchangeSpecialInstructions ExchangeSpecialInstructions
        {
            get
            {
                ExchangeSpecialInstructions val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExchangeSpecialInstructions val) { ExchangeSpecialInstructions = val; }
        public ExchangeSpecialInstructions Get(ExchangeSpecialInstructions val) { GetField(val); return val; }
        public bool IsSet(ExchangeSpecialInstructions val) { return IsSetExchangeSpecialInstructions(); }
        public bool IsSetExchangeSpecialInstructions() { return IsSetField(Tags.ExchangeSpecialInstructions); }

        public NetGrossInd NetGrossInd
        {
            get
            {
                NetGrossInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NetGrossInd val) { NetGrossInd = val; }
        public NetGrossInd Get(NetGrossInd val) { GetField(val); return val; }
        public bool IsSet(NetGrossInd val) { return IsSetNetGrossInd(); }
        public bool IsSetNetGrossInd() { return IsSetField(Tags.NetGrossInd); }

        public SideCurrency SideCurrency
        {
            get
            {
                SideCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideCurrency val) { SideCurrency = val; }
        public SideCurrency Get(SideCurrency val) { GetField(val); return val; }
        public bool IsSet(SideCurrency val) { return IsSetSideCurrency(); }
        public bool IsSetSideCurrency() { return IsSetField(Tags.SideCurrency); }

        public SideSettlCurrency SideSettlCurrency
        {
            get
            {
                SideSettlCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideSettlCurrency val) { SideSettlCurrency = val; }
        public SideSettlCurrency Get(SideSettlCurrency val) { GetField(val); return val; }
        public bool IsSet(SideSettlCurrency val) { return IsSetSideSettlCurrency(); }
        public bool IsSetSideSettlCurrency() { return IsSetField(Tags.SideSettlCurrency); }

        public NoSettlDetails NoSettlDetails
        {
            get
            {
                NoSettlDetails val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoSettlDetails val) { NoSettlDetails = val; }
        public NoSettlDetails Get(NoSettlDetails val) { GetField(val); return val; }
        public bool IsSet(NoSettlDetails val) { return IsSetNoSettlDetails(); }
        public bool IsSetNoSettlDetails() { return IsSetField(Tags.NoSettlDetails); }

        public OrderCategory OrderCategory
        {
            get
            {
                OrderCategory val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderCategory val) { OrderCategory = val; }
        public OrderCategory Get(OrderCategory val) { GetField(val); return val; }
        public bool IsSet(OrderCategory val) { return IsSetOrderCategory(); }
        public bool IsSetOrderCategory() { return IsSetField(Tags.OrderCategory); }

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

        public RefOrderID RefOrderID
        {
            get
            {
                RefOrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefOrderID val) { RefOrderID = val; }
        public RefOrderID Get(RefOrderID val) { GetField(val); return val; }
        public bool IsSet(RefOrderID val) { return IsSetRefOrderID(); }
        public bool IsSetRefOrderID() { return IsSetField(Tags.RefOrderID); }

        public RefOrderIDSource RefOrderIDSource
        {
            get
            {
                RefOrderIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefOrderIDSource val) { RefOrderIDSource = val; }
        public RefOrderIDSource Get(RefOrderIDSource val) { GetField(val); return val; }
        public bool IsSet(RefOrderIDSource val) { return IsSetRefOrderIDSource(); }
        public bool IsSetRefOrderIDSource() { return IsSetField(Tags.RefOrderIDSource); }

        public RefOrdIDReason RefOrdIDReason
        {
            get
            {
                RefOrdIDReason val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefOrdIDReason val) { RefOrdIDReason = val; }
        public RefOrdIDReason Get(RefOrdIDReason val) { GetField(val); return val; }
        public bool IsSet(RefOrdIDReason val) { return IsSetRefOrdIDReason(); }
        public bool IsSetRefOrdIDReason() { return IsSetField(Tags.RefOrdIDReason); }

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

        public OrderPercent OrderPercent
        {
            get
            {
                OrderPercent val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderPercent val) { OrderPercent = val; }
        public OrderPercent Get(OrderPercent val) { GetField(val); return val; }
        public bool IsSet(OrderPercent val) { return IsSetOrderPercent(); }
        public bool IsSetOrderPercent() { return IsSetField(Tags.OrderPercent); }

        public RoundingDirection RoundingDirection
        {
            get
            {
                RoundingDirection val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RoundingDirection val) { RoundingDirection = val; }
        public RoundingDirection Get(RoundingDirection val) { GetField(val); return val; }
        public bool IsSet(RoundingDirection val) { return IsSetRoundingDirection(); }
        public bool IsSetRoundingDirection() { return IsSetField(Tags.RoundingDirection); }

        public RoundingModulus RoundingModulus
        {
            get
            {
                RoundingModulus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RoundingModulus val) { RoundingModulus = val; }
        public RoundingModulus Get(RoundingModulus val) { GetField(val); return val; }
        public bool IsSet(RoundingModulus val) { return IsSetRoundingModulus(); }
        public bool IsSetRoundingModulus() { return IsSetField(Tags.RoundingModulus); }

        public LeavesQty LeavesQty
        {
            get
            {
                LeavesQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LeavesQty val) { LeavesQty = val; }
        public LeavesQty Get(LeavesQty val) { GetField(val); return val; }
        public bool IsSet(LeavesQty val) { return IsSetLeavesQty(); }
        public bool IsSetLeavesQty() { return IsSetField(Tags.LeavesQty); }

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

        public SecondaryDisplayQty SecondaryDisplayQty
        {
            get
            {
                SecondaryDisplayQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryDisplayQty val) { SecondaryDisplayQty = val; }
        public SecondaryDisplayQty Get(SecondaryDisplayQty val) { GetField(val); return val; }
        public bool IsSet(SecondaryDisplayQty val) { return IsSetSecondaryDisplayQty(); }
        public bool IsSetSecondaryDisplayQty() { return IsSetField(Tags.SecondaryDisplayQty); }

        public DisplayWhen DisplayWhen
        {
            get
            {
                DisplayWhen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DisplayWhen val) { DisplayWhen = val; }
        public DisplayWhen Get(DisplayWhen val) { GetField(val); return val; }
        public bool IsSet(DisplayWhen val) { return IsSetDisplayWhen(); }
        public bool IsSetDisplayWhen() { return IsSetField(Tags.DisplayWhen); }

        public DisplayMethod DisplayMethod
        {
            get
            {
                DisplayMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DisplayMethod val) { DisplayMethod = val; }
        public DisplayMethod Get(DisplayMethod val) { GetField(val); return val; }
        public bool IsSet(DisplayMethod val) { return IsSetDisplayMethod(); }
        public bool IsSetDisplayMethod() { return IsSetField(Tags.DisplayMethod); }

        public DisplayLowQty DisplayLowQty
        {
            get
            {
                DisplayLowQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DisplayLowQty val) { DisplayLowQty = val; }
        public DisplayLowQty Get(DisplayLowQty val) { GetField(val); return val; }
        public bool IsSet(DisplayLowQty val) { return IsSetDisplayLowQty(); }
        public bool IsSetDisplayLowQty() { return IsSetField(Tags.DisplayLowQty); }

        public DisplayHighQty DisplayHighQty
        {
            get
            {
                DisplayHighQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DisplayHighQty val) { DisplayHighQty = val; }
        public DisplayHighQty Get(DisplayHighQty val) { GetField(val); return val; }
        public bool IsSet(DisplayHighQty val) { return IsSetDisplayHighQty(); }
        public bool IsSetDisplayHighQty() { return IsSetField(Tags.DisplayHighQty); }

        public DisplayMinIncr DisplayMinIncr
        {
            get
            {
                DisplayMinIncr val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DisplayMinIncr val) { DisplayMinIncr = val; }
        public DisplayMinIncr Get(DisplayMinIncr val) { GetField(val); return val; }
        public bool IsSet(DisplayMinIncr val) { return IsSetDisplayMinIncr(); }
        public bool IsSetDisplayMinIncr() { return IsSetField(Tags.DisplayMinIncr); }

        public RefreshQty RefreshQty
        {
            get
            {
                RefreshQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefreshQty val) { RefreshQty = val; }
        public RefreshQty Get(RefreshQty val) { GetField(val); return val; }
        public bool IsSet(RefreshQty val) { return IsSetRefreshQty(); }
        public bool IsSetRefreshQty() { return IsSetField(Tags.RefreshQty); }

        public DisplayQty DisplayQty
        {
            get
            {
                DisplayQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DisplayQty val) { DisplayQty = val; }
        public DisplayQty Get(DisplayQty val) { GetField(val); return val; }
        public bool IsSet(DisplayQty val) { return IsSetDisplayQty(); }
        public bool IsSetDisplayQty() { return IsSetField(Tags.DisplayQty); }

        public OrderCapacity OrderCapacity
        {
            get
            {
                OrderCapacity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderCapacity val) { OrderCapacity = val; }
        public OrderCapacity Get(OrderCapacity val) { GetField(val); return val; }
        public bool IsSet(OrderCapacity val) { return IsSetOrderCapacity(); }
        public bool IsSetOrderCapacity() { return IsSetField(Tags.OrderCapacity); }

        public OrderRestrictions OrderRestrictions
        {
            get
            {
                OrderRestrictions val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderRestrictions val) { OrderRestrictions = val; }
        public OrderRestrictions Get(OrderRestrictions val) { GetField(val); return val; }
        public bool IsSet(OrderRestrictions val) { return IsSetOrderRestrictions(); }
        public bool IsSetOrderRestrictions() { return IsSetField(Tags.OrderRestrictions); }

        public OrigCustOrderCapacity OrigCustOrderCapacity
        {
            get
            {
                OrigCustOrderCapacity val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrigCustOrderCapacity val) { OrigCustOrderCapacity = val; }
        public OrigCustOrderCapacity Get(OrigCustOrderCapacity val) { GetField(val); return val; }
        public bool IsSet(OrigCustOrderCapacity val) { return IsSetOrigCustOrderCapacity(); }
        public bool IsSetOrigCustOrderCapacity() { return IsSetField(Tags.OrigCustOrderCapacity); }

        public OrderInputDevice OrderInputDevice
        {
            get
            {
                OrderInputDevice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderInputDevice val) { OrderInputDevice = val; }
        public OrderInputDevice Get(OrderInputDevice val) { GetField(val); return val; }
        public bool IsSet(OrderInputDevice val) { return IsSetOrderInputDevice(); }
        public bool IsSetOrderInputDevice() { return IsSetField(Tags.OrderInputDevice); }

        public LotType LotType
        {
            get
            {
                LotType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LotType val) { LotType = val; }
        public LotType Get(LotType val) { GetField(val); return val; }
        public bool IsSet(LotType val) { return IsSetLotType(); }
        public bool IsSetLotType() { return IsSetField(Tags.LotType); }

        public TransBkdTime TransBkdTime
        {
            get
            {
                TransBkdTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TransBkdTime val) { TransBkdTime = val; }
        public TransBkdTime Get(TransBkdTime val) { GetField(val); return val; }
        public bool IsSet(TransBkdTime val) { return IsSetTransBkdTime(); }
        public bool IsSetTransBkdTime() { return IsSetField(Tags.TransBkdTime); }

        public OrigOrdModTime OrigOrdModTime
        {
            get
            {
                OrigOrdModTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrigOrdModTime val) { OrigOrdModTime = val; }
        public OrigOrdModTime Get(OrigOrdModTime val) { GetField(val); return val; }
        public bool IsSet(OrigOrdModTime val) { return IsSetOrigOrdModTime(); }
        public bool IsSetOrigOrdModTime() { return IsSetField(Tags.OrigOrdModTime); }

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

        public SideExecID SideExecID
        {
            get
            {
                SideExecID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideExecID val) { SideExecID = val; }
        public SideExecID Get(SideExecID val) { GetField(val); return val; }
        public bool IsSet(SideExecID val) { return IsSetSideExecID(); }
        public bool IsSetSideExecID() { return IsSetField(Tags.SideExecID); }

        public OrderDelay OrderDelay
        {
            get
            {
                OrderDelay val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderDelay val) { OrderDelay = val; }
        public OrderDelay Get(OrderDelay val) { GetField(val); return val; }
        public bool IsSet(OrderDelay val) { return IsSetOrderDelay(); }
        public bool IsSetOrderDelay() { return IsSetField(Tags.OrderDelay); }

        public OrderDelayUnit OrderDelayUnit
        {
            get
            {
                OrderDelayUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderDelayUnit val) { OrderDelayUnit = val; }
        public OrderDelayUnit Get(OrderDelayUnit val) { GetField(val); return val; }
        public bool IsSet(OrderDelayUnit val) { return IsSetOrderDelayUnit(); }
        public bool IsSetOrderDelayUnit() { return IsSetField(Tags.OrderDelayUnit); }

        public SideLiquidityInd SideLiquidityInd
        {
            get
            {
                SideLiquidityInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideLiquidityInd val) { SideLiquidityInd = val; }
        public SideLiquidityInd Get(SideLiquidityInd val) { GetField(val); return val; }
        public bool IsSet(SideLiquidityInd val) { return IsSetSideLiquidityInd(); }
        public bool IsSetSideLiquidityInd() { return IsSetField(Tags.SideLiquidityInd); }

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

        public class NoContAmtsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};

            public NoContAmtsGroup()
              : base(Tags.NoContAmts, Tags.ContAmtType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoContAmtsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public ContAmtType ContAmtType
            {
                get
                {
                    ContAmtType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContAmtType val) { ContAmtType = val; }
            public ContAmtType Get(ContAmtType val) { GetField(val); return val; }
            public bool IsSet(ContAmtType val) { return IsSetContAmtType(); }
            public bool IsSetContAmtType() { return IsSetField(Tags.ContAmtType); }

            public ContAmtValue ContAmtValue
            {
                get
                {
                    ContAmtValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContAmtValue val) { ContAmtValue = val; }
            public ContAmtValue Get(ContAmtValue val) { GetField(val); return val; }
            public bool IsSet(ContAmtValue val) { return IsSetContAmtValue(); }
            public bool IsSetContAmtValue() { return IsSetField(Tags.ContAmtValue); }

            public ContAmtCurr ContAmtCurr
            {
                get
                {
                    ContAmtCurr val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(ContAmtCurr val) { ContAmtCurr = val; }
            public ContAmtCurr Get(ContAmtCurr val) { GetField(val); return val; }
            public bool IsSet(ContAmtCurr val) { return IsSetContAmtCurr(); }
            public bool IsSetContAmtCurr() { return IsSetField(Tags.ContAmtCurr); }
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

        public class NoAllocsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNested2PartyIDs, Tags.AllocQty, Tags.AllocCustomerCapacity, Tags.AllocMethod, Tags.SecondaryIndividualAllocID, Tags.AllocClearingFeeIndicator, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNested2PartyIDs, Tags.AllocQty, Tags.AllocCustomerCapacity, Tags.AllocMethod, Tags.SecondaryIndividualAllocID, Tags.AllocClearingFeeIndicator, 0};

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

            public AllocClearingFeeIndicator AllocClearingFeeIndicator
            {
                get
                {
                    AllocClearingFeeIndicator val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(AllocClearingFeeIndicator val) { AllocClearingFeeIndicator = val; }
            public AllocClearingFeeIndicator Get(AllocClearingFeeIndicator val) { GetField(val); return val; }
            public bool IsSet(AllocClearingFeeIndicator val) { return IsSetAllocClearingFeeIndicator(); }
            public bool IsSetAllocClearingFeeIndicator() { return IsSetField(Tags.AllocClearingFeeIndicator); }

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

        public class NoSideTrdRegTSGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SideTrdRegTimestamp, Tags.SideTrdRegTimestampType, Tags.SideTrdRegTimestampSrc, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SideTrdRegTimestamp, Tags.SideTrdRegTimestampType, Tags.SideTrdRegTimestampSrc, 0};

            public NoSideTrdRegTSGroup()
              : base(Tags.NoSideTrdRegTS, Tags.SideTrdRegTimestamp, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSideTrdRegTSGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public SideTrdRegTimestamp SideTrdRegTimestamp
            {
                get
                {
                    SideTrdRegTimestamp val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SideTrdRegTimestamp val) { SideTrdRegTimestamp = val; }
            public SideTrdRegTimestamp Get(SideTrdRegTimestamp val) { GetField(val); return val; }
            public bool IsSet(SideTrdRegTimestamp val) { return IsSetSideTrdRegTimestamp(); }
            public bool IsSetSideTrdRegTimestamp() { return IsSetField(Tags.SideTrdRegTimestamp); }

            public SideTrdRegTimestampType SideTrdRegTimestampType
            {
                get
                {
                    SideTrdRegTimestampType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SideTrdRegTimestampType val) { SideTrdRegTimestampType = val; }
            public SideTrdRegTimestampType Get(SideTrdRegTimestampType val) { GetField(val); return val; }
            public bool IsSet(SideTrdRegTimestampType val) { return IsSetSideTrdRegTimestampType(); }
            public bool IsSetSideTrdRegTimestampType() { return IsSetField(Tags.SideTrdRegTimestampType); }

            public SideTrdRegTimestampSrc SideTrdRegTimestampSrc
            {
                get
                {
                    SideTrdRegTimestampSrc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SideTrdRegTimestampSrc val) { SideTrdRegTimestampSrc = val; }
            public SideTrdRegTimestampSrc Get(SideTrdRegTimestampSrc val) { GetField(val); return val; }
            public bool IsSet(SideTrdRegTimestampSrc val) { return IsSetSideTrdRegTimestampSrc(); }
            public bool IsSetSideTrdRegTimestampSrc() { return IsSetField(Tags.SideTrdRegTimestampSrc); }
        }

        public class NoSettlDetailsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0};

            public NoSettlDetailsGroup()
              : base(Tags.NoSettlDetails, Tags.SettlObligSource, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSettlDetailsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public SettlObligSource SettlObligSource
            {
                get
                {
                    SettlObligSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SettlObligSource val) { SettlObligSource = val; }
            public SettlObligSource Get(SettlObligSource val) { GetField(val); return val; }
            public bool IsSet(SettlObligSource val) { return IsSetSettlObligSource(); }
            public bool IsSetSettlObligSource() { return IsSetField(Tags.SettlObligSource); }

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

    public class NoRootPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RootPartyID, Tags.RootPartyIDSource, Tags.RootPartyRole, Tags.NoRootPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RootPartyID, Tags.RootPartyIDSource, Tags.RootPartyRole, Tags.NoRootPartySubIDs, 0};

        public NoRootPartyIDsGroup()
          : base(Tags.NoRootPartyIDs, Tags.RootPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRootPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RootPartyID RootPartyID
        {
            get
            {
                RootPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RootPartyID val) { RootPartyID = val; }
        public RootPartyID Get(RootPartyID val) { GetField(val); return val; }
        public bool IsSet(RootPartyID val) { return IsSetRootPartyID(); }
        public bool IsSetRootPartyID() { return IsSetField(Tags.RootPartyID); }

        public RootPartyIDSource RootPartyIDSource
        {
            get
            {
                RootPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RootPartyIDSource val) { RootPartyIDSource = val; }
        public RootPartyIDSource Get(RootPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(RootPartyIDSource val) { return IsSetRootPartyIDSource(); }
        public bool IsSetRootPartyIDSource() { return IsSetField(Tags.RootPartyIDSource); }

        public RootPartyRole RootPartyRole
        {
            get
            {
                RootPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RootPartyRole val) { RootPartyRole = val; }
        public RootPartyRole Get(RootPartyRole val) { GetField(val); return val; }
        public bool IsSet(RootPartyRole val) { return IsSetRootPartyRole(); }
        public bool IsSetRootPartyRole() { return IsSetField(Tags.RootPartyRole); }

        public NoRootPartySubIDs NoRootPartySubIDs
        {
            get
            {
                NoRootPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoRootPartySubIDs val) { NoRootPartySubIDs = val; }
        public NoRootPartySubIDs Get(NoRootPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoRootPartySubIDs val) { return IsSetNoRootPartySubIDs(); }
        public bool IsSetNoRootPartySubIDs() { return IsSetField(Tags.NoRootPartySubIDs); }

        public class NoRootPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.RootPartySubID, Tags.RootPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.RootPartySubID, Tags.RootPartySubIDType, 0};

            public NoRootPartySubIDsGroup()
              : base(Tags.NoRootPartySubIDs, Tags.RootPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRootPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public RootPartySubID RootPartySubID
            {
                get
                {
                    RootPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RootPartySubID val) { RootPartySubID = val; }
            public RootPartySubID Get(RootPartySubID val) { GetField(val); return val; }
            public bool IsSet(RootPartySubID val) { return IsSetRootPartySubID(); }
            public bool IsSetRootPartySubID() { return IsSetField(Tags.RootPartySubID); }

            public RootPartySubIDType RootPartySubIDType
            {
                get
                {
                    RootPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(RootPartySubIDType val) { RootPartySubIDType = val; }
            public RootPartySubIDType Get(RootPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(RootPartySubIDType val) { return IsSetRootPartySubIDType(); }
            public bool IsSetRootPartySubIDType() { return IsSetField(Tags.RootPartySubIDType); }
        }
    }

    public class NoTrdRepIndicatorsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TrdRepPartyRole, Tags.TrdRepIndicator, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TrdRepPartyRole, Tags.TrdRepIndicator, 0};

        public NoTrdRepIndicatorsGroup()
          : base(Tags.NoTrdRepIndicators, Tags.TrdRepPartyRole, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTrdRepIndicatorsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TrdRepPartyRole TrdRepPartyRole
        {
            get
            {
                TrdRepPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRepPartyRole val) { TrdRepPartyRole = val; }
        public TrdRepPartyRole Get(TrdRepPartyRole val) { GetField(val); return val; }
        public bool IsSet(TrdRepPartyRole val) { return IsSetTrdRepPartyRole(); }
        public bool IsSetTrdRepPartyRole() { return IsSetField(Tags.TrdRepPartyRole); }

        public TrdRepIndicator TrdRepIndicator
        {
            get
            {
                TrdRepIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TrdRepIndicator val) { TrdRepIndicator = val; }
        public TrdRepIndicator Get(TrdRepIndicator val) { GetField(val); return val; }
        public bool IsSet(TrdRepIndicator val) { return IsSetTrdRepIndicator(); }
        public bool IsSetTrdRepIndicator() { return IsSetField(Tags.TrdRepIndicator); }
    }
}
