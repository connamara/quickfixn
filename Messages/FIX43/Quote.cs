// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class Quote : Message
{
    public const string MsgType = "S";

    public Quote() : base()
    {
        Header.SetField(new MsgType("S"));
    }

    public Quote(
            QuoteID aQuoteID,
            Symbol aSymbol
        ) : this()
    {
        QuoteID = aQuoteID;
        Symbol = aSymbol;
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

    public QuoteType QuoteType
    {
        get
        {
            QuoteType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteType val) { QuoteType = val; }
    public QuoteType Get(QuoteType val) { GetField(val); return val; }
    public bool IsSet(QuoteType val) { return IsSetQuoteType(); }
    public bool IsSetQuoteType() { return IsSetField(Tags.QuoteType); }

    public QuoteResponseLevel QuoteResponseLevel
    {
        get
        {
            QuoteResponseLevel val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(QuoteResponseLevel val) { QuoteResponseLevel = val; }
    public QuoteResponseLevel Get(QuoteResponseLevel val) { GetField(val); return val; }
    public bool IsSet(QuoteResponseLevel val) { return IsSetQuoteResponseLevel(); }
    public bool IsSetQuoteResponseLevel() { return IsSetField(Tags.QuoteResponseLevel); }

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

    public BidPx BidPx
    {
        get
        {
            BidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidPx val) { BidPx = val; }
    public BidPx Get(BidPx val) { GetField(val); return val; }
    public bool IsSet(BidPx val) { return IsSetBidPx(); }
    public bool IsSetBidPx() { return IsSetField(Tags.BidPx); }

    public OfferPx OfferPx
    {
        get
        {
            OfferPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferPx val) { OfferPx = val; }
    public OfferPx Get(OfferPx val) { GetField(val); return val; }
    public bool IsSet(OfferPx val) { return IsSetOfferPx(); }
    public bool IsSetOfferPx() { return IsSetField(Tags.OfferPx); }

    public MktBidPx MktBidPx
    {
        get
        {
            MktBidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MktBidPx val) { MktBidPx = val; }
    public MktBidPx Get(MktBidPx val) { GetField(val); return val; }
    public bool IsSet(MktBidPx val) { return IsSetMktBidPx(); }
    public bool IsSetMktBidPx() { return IsSetField(Tags.MktBidPx); }

    public MktOfferPx MktOfferPx
    {
        get
        {
            MktOfferPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MktOfferPx val) { MktOfferPx = val; }
    public MktOfferPx Get(MktOfferPx val) { GetField(val); return val; }
    public bool IsSet(MktOfferPx val) { return IsSetMktOfferPx(); }
    public bool IsSetMktOfferPx() { return IsSetField(Tags.MktOfferPx); }

    public MinBidSize MinBidSize
    {
        get
        {
            MinBidSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinBidSize val) { MinBidSize = val; }
    public MinBidSize Get(MinBidSize val) { GetField(val); return val; }
    public bool IsSet(MinBidSize val) { return IsSetMinBidSize(); }
    public bool IsSetMinBidSize() { return IsSetField(Tags.MinBidSize); }

    public BidSize BidSize
    {
        get
        {
            BidSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidSize val) { BidSize = val; }
    public BidSize Get(BidSize val) { GetField(val); return val; }
    public bool IsSet(BidSize val) { return IsSetBidSize(); }
    public bool IsSetBidSize() { return IsSetField(Tags.BidSize); }

    public MinOfferSize MinOfferSize
    {
        get
        {
            MinOfferSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinOfferSize val) { MinOfferSize = val; }
    public MinOfferSize Get(MinOfferSize val) { GetField(val); return val; }
    public bool IsSet(MinOfferSize val) { return IsSetMinOfferSize(); }
    public bool IsSetMinOfferSize() { return IsSetField(Tags.MinOfferSize); }

    public OfferSize OfferSize
    {
        get
        {
            OfferSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferSize val) { OfferSize = val; }
    public OfferSize Get(OfferSize val) { GetField(val); return val; }
    public bool IsSet(OfferSize val) { return IsSetOfferSize(); }
    public bool IsSetOfferSize() { return IsSetField(Tags.OfferSize); }

    public ValidUntilTime ValidUntilTime
    {
        get
        {
            ValidUntilTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ValidUntilTime val) { ValidUntilTime = val; }
    public ValidUntilTime Get(ValidUntilTime val) { GetField(val); return val; }
    public bool IsSet(ValidUntilTime val) { return IsSetValidUntilTime(); }
    public bool IsSetValidUntilTime() { return IsSetField(Tags.ValidUntilTime); }

    public BidSpotRate BidSpotRate
    {
        get
        {
            BidSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidSpotRate val) { BidSpotRate = val; }
    public BidSpotRate Get(BidSpotRate val) { GetField(val); return val; }
    public bool IsSet(BidSpotRate val) { return IsSetBidSpotRate(); }
    public bool IsSetBidSpotRate() { return IsSetField(Tags.BidSpotRate); }

    public OfferSpotRate OfferSpotRate
    {
        get
        {
            OfferSpotRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferSpotRate val) { OfferSpotRate = val; }
    public OfferSpotRate Get(OfferSpotRate val) { GetField(val); return val; }
    public bool IsSet(OfferSpotRate val) { return IsSetOfferSpotRate(); }
    public bool IsSetOfferSpotRate() { return IsSetField(Tags.OfferSpotRate); }

    public BidForwardPoints BidForwardPoints
    {
        get
        {
            BidForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidForwardPoints val) { BidForwardPoints = val; }
    public BidForwardPoints Get(BidForwardPoints val) { GetField(val); return val; }
    public bool IsSet(BidForwardPoints val) { return IsSetBidForwardPoints(); }
    public bool IsSetBidForwardPoints() { return IsSetField(Tags.BidForwardPoints); }

    public OfferForwardPoints OfferForwardPoints
    {
        get
        {
            OfferForwardPoints val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferForwardPoints val) { OfferForwardPoints = val; }
    public OfferForwardPoints Get(OfferForwardPoints val) { GetField(val); return val; }
    public bool IsSet(OfferForwardPoints val) { return IsSetOfferForwardPoints(); }
    public bool IsSetOfferForwardPoints() { return IsSetField(Tags.OfferForwardPoints); }

    public MidPx MidPx
    {
        get
        {
            MidPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MidPx val) { MidPx = val; }
    public MidPx Get(MidPx val) { GetField(val); return val; }
    public bool IsSet(MidPx val) { return IsSetMidPx(); }
    public bool IsSetMidPx() { return IsSetField(Tags.MidPx); }

    public BidYield BidYield
    {
        get
        {
            BidYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidYield val) { BidYield = val; }
    public BidYield Get(BidYield val) { GetField(val); return val; }
    public bool IsSet(BidYield val) { return IsSetBidYield(); }
    public bool IsSetBidYield() { return IsSetField(Tags.BidYield); }

    public MidYield MidYield
    {
        get
        {
            MidYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MidYield val) { MidYield = val; }
    public MidYield Get(MidYield val) { GetField(val); return val; }
    public bool IsSet(MidYield val) { return IsSetMidYield(); }
    public bool IsSetMidYield() { return IsSetField(Tags.MidYield); }

    public OfferYield OfferYield
    {
        get
        {
            OfferYield val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferYield val) { OfferYield = val; }
    public OfferYield Get(OfferYield val) { GetField(val); return val; }
    public bool IsSet(OfferYield val) { return IsSetOfferYield(); }
    public bool IsSetOfferYield() { return IsSetField(Tags.OfferYield); }

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

    public BidForwardPoints2 BidForwardPoints2
    {
        get
        {
            BidForwardPoints2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidForwardPoints2 val) { BidForwardPoints2 = val; }
    public BidForwardPoints2 Get(BidForwardPoints2 val) { GetField(val); return val; }
    public bool IsSet(BidForwardPoints2 val) { return IsSetBidForwardPoints2(); }
    public bool IsSetBidForwardPoints2() { return IsSetField(Tags.BidForwardPoints2); }

    public OfferForwardPoints2 OfferForwardPoints2
    {
        get
        {
            OfferForwardPoints2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OfferForwardPoints2 val) { OfferForwardPoints2 = val; }
    public OfferForwardPoints2 Get(OfferForwardPoints2 val) { GetField(val); return val; }
    public bool IsSet(OfferForwardPoints2 val) { return IsSetOfferForwardPoints2(); }
    public bool IsSetOfferForwardPoints2() { return IsSetField(Tags.OfferForwardPoints2); }

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

    public SettlCurrBidFxRate SettlCurrBidFxRate
    {
        get
        {
            SettlCurrBidFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrBidFxRate val) { SettlCurrBidFxRate = val; }
    public SettlCurrBidFxRate Get(SettlCurrBidFxRate val) { GetField(val); return val; }
    public bool IsSet(SettlCurrBidFxRate val) { return IsSetSettlCurrBidFxRate(); }
    public bool IsSetSettlCurrBidFxRate() { return IsSetField(Tags.SettlCurrBidFxRate); }

    public SettlCurrOfferFxRate SettlCurrOfferFxRate
    {
        get
        {
            SettlCurrOfferFxRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SettlCurrOfferFxRate val) { SettlCurrOfferFxRate = val; }
    public SettlCurrOfferFxRate Get(SettlCurrOfferFxRate val) { GetField(val); return val; }
    public bool IsSet(SettlCurrOfferFxRate val) { return IsSetSettlCurrOfferFxRate(); }
    public bool IsSetSettlCurrOfferFxRate() { return IsSetField(Tags.SettlCurrOfferFxRate); }

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
}
