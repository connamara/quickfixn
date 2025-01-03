// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class TradeCaptureReport : Message
{
    public const string MsgType = "AE";

    public TradeCaptureReport() : base()
    {
        Header.SetField(new MsgType("AE"));
    }

    public TradeCaptureReport(
            TradeReportID aTradeReportID,
            ExecType aExecType,
            PreviouslyReported aPreviouslyReported,
            Symbol aSymbol,
            LastQty aLastQty,
            LastPx aLastPx,
            TradeDate aTradeDate,
            TransactTime aTransactTime
        ) : this()
    {
        TradeReportID = aTradeReportID;
        ExecType = aExecType;
        PreviouslyReported = aPreviouslyReported;
        Symbol = aSymbol;
        LastQty = aLastQty;
        LastPx = aLastPx;
        TradeDate = aTradeDate;
        TransactTime = aTransactTime;
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

    public class NoSidesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.NoPartyIDs, Tags.Account, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.ClearingFeeIndicator, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.GrossTradeAmt, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MultiLegReportingType, Tags.NoContAmts, Tags.NoMiscFees, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Side, Tags.OrderID, Tags.SecondaryOrderID, Tags.ClOrdID, Tags.NoPartyIDs, Tags.Account, Tags.AccountType, Tags.ProcessCode, Tags.OddLot, Tags.NoClearingInstructions, Tags.ClearingFeeIndicator, Tags.TradeInputSource, Tags.TradeInputDevice, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.TransBkdTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.GrossTradeAmt, Tags.NumDaysInterest, Tags.ExDate, Tags.AccruedInterestRate, Tags.AccruedInterestAmt, Tags.Concession, Tags.TotalTakedown, Tags.NetMoney, Tags.SettlCurrAmt, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.PositionEffect, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.MultiLegReportingType, Tags.NoContAmts, Tags.NoMiscFees, 0};

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
