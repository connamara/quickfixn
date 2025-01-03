// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class NewOrderSingle : Message
{
    public const string MsgType = "D";

    public NewOrderSingle() : base()
    {
        Header.SetField(new MsgType("D"));
    }

    public NewOrderSingle(
            ClOrdID aClOrdID,
            HandlInst aHandlInst,
            Symbol aSymbol,
            Side aSide,
            TransactTime aTransactTime,
            OrdType aOrdType
        ) : this()
    {
        ClOrdID = aClOrdID;
        HandlInst = aHandlInst;
        Symbol = aSymbol;
        Side = aSide;
        TransactTime = aTransactTime;
        OrdType = aOrdType;
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

    public ClOrdLinkID ClOrdLinkID
    {
        get
        {
            ClOrdLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdLinkID val) { ClOrdLinkID = val; }
    public ClOrdLinkID Get(ClOrdLinkID val) { GetField(val); return val; }
    public bool IsSet(ClOrdLinkID val) { return IsSetClOrdLinkID(); }
    public bool IsSetClOrdLinkID() { return IsSetField(Tags.ClOrdLinkID); }

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

    public DayBookingInst DayBookingInst
    {
        get
        {
            DayBookingInst val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DayBookingInst val) { DayBookingInst = val; }
    public DayBookingInst Get(DayBookingInst val) { GetField(val); return val; }
    public bool IsSet(DayBookingInst val) { return IsSetDayBookingInst(); }
    public bool IsSetDayBookingInst() { return IsSetField(Tags.DayBookingInst); }

    public BookingUnit BookingUnit
    {
        get
        {
            BookingUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BookingUnit val) { BookingUnit = val; }
    public BookingUnit Get(BookingUnit val) { GetField(val); return val; }
    public bool IsSet(BookingUnit val) { return IsSetBookingUnit(); }
    public bool IsSetBookingUnit() { return IsSetField(Tags.BookingUnit); }

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

    public CashMargin CashMargin
    {
        get
        {
            CashMargin val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CashMargin val) { CashMargin = val; }
    public CashMargin Get(CashMargin val) { GetField(val); return val; }
    public bool IsSet(CashMargin val) { return IsSetCashMargin(); }
    public bool IsSetCashMargin() { return IsSetField(Tags.CashMargin); }

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

    public QuantityType QuantityType
    {
        get
        {
            QuantityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuantityType val) { QuantityType = val; }
    public QuantityType Get(QuantityType val) { GetField(val); return val; }
    public bool IsSet(QuantityType val) { return IsSetQuantityType(); }
    public bool IsSetQuantityType() { return IsSetField(Tags.QuantityType); }

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

    public Price2 Price2
    {
        get
        {
            Price2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price2 val) { Price2 = val; }
    public Price2 Get(Price2 val) { GetField(val); return val; }
    public bool IsSet(Price2 val) { return IsSetPrice2(); }
    public bool IsSetPrice2() { return IsSetField(Tags.Price2); }

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

    public CancellationRights CancellationRights
    {
        get
        {
            CancellationRights val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CancellationRights val) { CancellationRights = val; }
    public CancellationRights Get(CancellationRights val) { GetField(val); return val; }
    public bool IsSet(CancellationRights val) { return IsSetCancellationRights(); }
    public bool IsSetCancellationRights() { return IsSetField(Tags.CancellationRights); }

    public MoneyLaunderingStatus MoneyLaunderingStatus
    {
        get
        {
            MoneyLaunderingStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MoneyLaunderingStatus val) { MoneyLaunderingStatus = val; }
    public MoneyLaunderingStatus Get(MoneyLaunderingStatus val) { GetField(val); return val; }
    public bool IsSet(MoneyLaunderingStatus val) { return IsSetMoneyLaunderingStatus(); }
    public bool IsSetMoneyLaunderingStatus() { return IsSetField(Tags.MoneyLaunderingStatus); }

    public RegistID RegistID
    {
        get
        {
            RegistID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistID val) { RegistID = val; }
    public RegistID Get(RegistID val) { GetField(val); return val; }
    public bool IsSet(RegistID val) { return IsSetRegistID(); }
    public bool IsSetRegistID() { return IsSetField(Tags.RegistID); }

    public Designation Designation
    {
        get
        {
            Designation val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Designation val) { Designation = val; }
    public Designation Get(Designation val) { GetField(val); return val; }
    public bool IsSet(Designation val) { return IsSetDesignation(); }
    public bool IsSetDesignation() { return IsSetField(Tags.Designation); }

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
        public static int[] DefaultFieldOrder = [Tags.AllocAccount, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.AllocAccount, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0};

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
    }

    public class NoTradingSessionsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TradingSessionID, Tags.TradingSessionSubID, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, 0};

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
}
