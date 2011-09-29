// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class OrderMassCancelRequest : Message
        {
            public const string MsgType = "q";

            public OrderMassCancelRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("q"));
            }

            public OrderMassCancelRequest(
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.MassCancelRequestType aMassCancelRequestType,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.clOrdID = aClOrdID;
                this.massCancelRequestType = aMassCancelRequestType;
                this.transactTime = aTransactTime;
            }

            public QuickFix.Fields.ClOrdID clOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdID val) 
            { 
                this.clOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.SecondaryClOrdID secondaryClOrdID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                this.secondaryClOrdID = val;
            }
            
            public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                return IsSetSecondaryClOrdID();
            }
            
            public bool IsSetSecondaryClOrdID() 
            { 
                return IsSetField(Tags.SecondaryClOrdID);
            }
            public QuickFix.Fields.MassCancelRequestType massCancelRequestType
            { 
                get 
                {
                    QuickFix.Fields.MassCancelRequestType val = new QuickFix.Fields.MassCancelRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassCancelRequestType val) 
            { 
                this.massCancelRequestType = val;
            }
            
            public QuickFix.Fields.MassCancelRequestType Get(QuickFix.Fields.MassCancelRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassCancelRequestType val) 
            { 
                return IsSetMassCancelRequestType();
            }
            
            public bool IsSetMassCancelRequestType() 
            { 
                return IsSetField(Tags.MassCancelRequestType);
            }
            public QuickFix.Fields.TradingSessionID tradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.tradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return IsSetTradingSessionID();
            }
            
            public bool IsSetTradingSessionID() 
            { 
                return IsSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingSessionSubID val) 
            { 
                this.tradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingSessionSubID val) 
            { 
                return IsSetTradingSessionSubID();
            }
            
            public bool IsSetTradingSessionSubID() 
            { 
                return IsSetField(Tags.TradingSessionSubID);
            }
            public QuickFix.Fields.Symbol symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx symbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.symbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID securityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                this.securityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.SecurityIDSource securityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.securityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID noSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.noSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                this.product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode cFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                this.cFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.SecuritySubType securitySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.securitySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.MaturityMonthYear maturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.maturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDate maturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                this.maturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate couponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.couponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate issueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                this.issueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.repoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm repurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.repurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate repurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.repurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                this.factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating creditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                this.creditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry instrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.instrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue countryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.countryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.stateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue localeOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.localeOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate redemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.redemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(Tags.RedemptionDate);
            }
            public QuickFix.Fields.StrikePrice strikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePrice val) 
            { 
                this.strikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.StrikeCurrency strikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeCurrency val) 
            { 
                this.strikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(Tags.StrikeCurrency);
            }
            public QuickFix.Fields.OptAttribute optAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptAttribute val) 
            { 
                this.optAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier contractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.contractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate couponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponRate val) 
            { 
                this.couponRate = val;
            }
            
            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(Tags.CouponRate);
            }
            public QuickFix.Fields.SecurityExchange securityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.securityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Issuer val) 
            { 
                this.issuer = val;
            }
            
            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.encodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer encodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.encodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc securityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.securityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.encodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.encodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Pool pool
            { 
                get 
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Pool val) 
            { 
                this.pool = val;
            }
            
            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(Tags.Pool);
            }
            public QuickFix.Fields.ContractSettlMonth contractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                this.contractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(Tags.ContractSettlMonth);
            }
            public QuickFix.Fields.CPProgram cPProgram
            { 
                get 
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPProgram val) 
            { 
                this.cPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(Tags.CPProgram);
            }
            public QuickFix.Fields.CPRegType cPRegType
            { 
                get 
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPRegType val) 
            { 
                this.cPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(Tags.CPRegType);
            }
            public QuickFix.Fields.NoEvents noEvents
            { 
                get 
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoEvents val) 
            { 
                this.noEvents = val;
            }
            
            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(Tags.NoEvents);
            }
            public QuickFix.Fields.DatedDate datedDate
            { 
                get 
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DatedDate val) 
            { 
                this.datedDate = val;
            }
            
            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(Tags.DatedDate);
            }
            public QuickFix.Fields.InterestAccrualDate interestAccrualDate
            { 
                get 
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                this.interestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(Tags.InterestAccrualDate);
            }
            public QuickFix.Fields.SecurityStatus securityStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityStatus val) 
            { 
                this.securityStatus = val;
            }
            
            public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityStatus val) 
            { 
                return IsSetSecurityStatus();
            }
            
            public bool IsSetSecurityStatus() 
            { 
                return IsSetField(Tags.SecurityStatus);
            }
            public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                this.settleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                return IsSetSettleOnOpenFlag();
            }
            
            public bool IsSetSettleOnOpenFlag() 
            { 
                return IsSetField(Tags.SettleOnOpenFlag);
            }
            public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                this.instrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                return IsSetInstrmtAssignmentMethod();
            }
            
            public bool IsSetInstrmtAssignmentMethod() 
            { 
                return IsSetField(Tags.InstrmtAssignmentMethod);
            }
            public QuickFix.Fields.StrikeMultiplier strikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeMultiplier val) 
            { 
                this.strikeMultiplier = val;
            }
            
            public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeMultiplier val) 
            { 
                return IsSetStrikeMultiplier();
            }
            
            public bool IsSetStrikeMultiplier() 
            { 
                return IsSetField(Tags.StrikeMultiplier);
            }
            public QuickFix.Fields.StrikeValue strikeValue
            { 
                get 
                {
                    QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeValue val) 
            { 
                this.strikeValue = val;
            }
            
            public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeValue val) 
            { 
                return IsSetStrikeValue();
            }
            
            public bool IsSetStrikeValue() 
            { 
                return IsSetField(Tags.StrikeValue);
            }
            public QuickFix.Fields.MinPriceIncrement minPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrement val) 
            { 
                this.minPriceIncrement = val;
            }
            
            public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrement val) 
            { 
                return IsSetMinPriceIncrement();
            }
            
            public bool IsSetMinPriceIncrement() 
            { 
                return IsSetField(Tags.MinPriceIncrement);
            }
            public QuickFix.Fields.PositionLimit positionLimit
            { 
                get 
                {
                    QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionLimit val) 
            { 
                this.positionLimit = val;
            }
            
            public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionLimit val) 
            { 
                return IsSetPositionLimit();
            }
            
            public bool IsSetPositionLimit() 
            { 
                return IsSetField(Tags.PositionLimit);
            }
            public QuickFix.Fields.NTPositionLimit nTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NTPositionLimit val) 
            { 
                this.nTPositionLimit = val;
            }
            
            public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NTPositionLimit val) 
            { 
                return IsSetNTPositionLimit();
            }
            
            public bool IsSetNTPositionLimit() 
            { 
                return IsSetField(Tags.NTPositionLimit);
            }
            public QuickFix.Fields.NoInstrumentParties noInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoInstrumentParties val) 
            { 
                this.noInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoInstrumentParties val) 
            { 
                return IsSetNoInstrumentParties();
            }
            
            public bool IsSetNoInstrumentParties() 
            { 
                return IsSetField(Tags.NoInstrumentParties);
            }
            public QuickFix.Fields.UnitOfMeasure unitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                this.unitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return IsSetUnitOfMeasure();
            }
            
            public bool IsSetUnitOfMeasure() 
            { 
                return IsSetField(Tags.UnitOfMeasure);
            }
            public QuickFix.Fields.TimeUnit timeUnit
            { 
                get 
                {
                    QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeUnit val) 
            { 
                this.timeUnit = val;
            }
            
            public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeUnit val) 
            { 
                return IsSetTimeUnit();
            }
            
            public bool IsSetTimeUnit() 
            { 
                return IsSetField(Tags.TimeUnit);
            }
            public QuickFix.Fields.MaturityTime maturityTime
            { 
                get 
                {
                    QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityTime val) 
            { 
                this.maturityTime = val;
            }
            
            public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityTime val) 
            { 
                return IsSetMaturityTime();
            }
            
            public bool IsSetMaturityTime() 
            { 
                return IsSetField(Tags.MaturityTime);
            }
            public QuickFix.Fields.SecurityGroup securityGroup
            { 
                get 
                {
                    QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityGroup val) 
            { 
                this.securityGroup = val;
            }
            
            public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityGroup val) 
            { 
                return IsSetSecurityGroup();
            }
            
            public bool IsSetSecurityGroup() 
            { 
                return IsSetField(Tags.SecurityGroup);
            }
            public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                this.minPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                return IsSetMinPriceIncrementAmount();
            }
            
            public bool IsSetMinPriceIncrementAmount() 
            { 
                return IsSetField(Tags.MinPriceIncrementAmount);
            }
            public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                this.unitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                return IsSetUnitOfMeasureQty();
            }
            
            public bool IsSetUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.UnitOfMeasureQty);
            }
            public QuickFix.Fields.SecurityXMLLen securityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLLen val) 
            { 
                this.securityXMLLen = val;
            }
            
            public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLLen val) 
            { 
                return IsSetSecurityXMLLen();
            }
            
            public bool IsSetSecurityXMLLen() 
            { 
                return IsSetField(Tags.SecurityXMLLen);
            }
            public QuickFix.Fields.SecurityXML securityXML
            { 
                get 
                {
                    QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXML val) 
            { 
                this.securityXML = val;
            }
            
            public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXML val) 
            { 
                return IsSetSecurityXML();
            }
            
            public bool IsSetSecurityXML() 
            { 
                return IsSetField(Tags.SecurityXML);
            }
            public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                this.securityXMLSchema = val;
            }
            
            public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                return IsSetSecurityXMLSchema();
            }
            
            public bool IsSetSecurityXMLSchema() 
            { 
                return IsSetField(Tags.SecurityXMLSchema);
            }
            public QuickFix.Fields.ProductComplex productComplex
            { 
                get 
                {
                    QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProductComplex val) 
            { 
                this.productComplex = val;
            }
            
            public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProductComplex val) 
            { 
                return IsSetProductComplex();
            }
            
            public bool IsSetProductComplex() 
            { 
                return IsSetField(Tags.ProductComplex);
            }
            public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                this.priceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                return IsSetPriceUnitOfMeasure();
            }
            
            public bool IsSetPriceUnitOfMeasure() 
            { 
                return IsSetField(Tags.PriceUnitOfMeasure);
            }
            public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                this.priceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                return IsSetPriceUnitOfMeasureQty();
            }
            
            public bool IsSetPriceUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.PriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.SettlMethod settlMethod
            { 
                get 
                {
                    QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlMethod val) 
            { 
                this.settlMethod = val;
            }
            
            public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlMethod val) 
            { 
                return IsSetSettlMethod();
            }
            
            public bool IsSetSettlMethod() 
            { 
                return IsSetField(Tags.SettlMethod);
            }
            public QuickFix.Fields.ExerciseStyle exerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExerciseStyle val) 
            { 
                this.exerciseStyle = val;
            }
            
            public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExerciseStyle val) 
            { 
                return IsSetExerciseStyle();
            }
            
            public bool IsSetExerciseStyle() 
            { 
                return IsSetField(Tags.ExerciseStyle);
            }
            public QuickFix.Fields.OptPayAmount optPayAmount
            { 
                get 
                {
                    QuickFix.Fields.OptPayAmount val = new QuickFix.Fields.OptPayAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptPayAmount val) 
            { 
                this.optPayAmount = val;
            }
            
            public QuickFix.Fields.OptPayAmount Get(QuickFix.Fields.OptPayAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptPayAmount val) 
            { 
                return IsSetOptPayAmount();
            }
            
            public bool IsSetOptPayAmount() 
            { 
                return IsSetField(Tags.OptPayAmount);
            }
            public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                this.priceQuoteMethod = val;
            }
            
            public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                return IsSetPriceQuoteMethod();
            }
            
            public bool IsSetPriceQuoteMethod() 
            { 
                return IsSetField(Tags.PriceQuoteMethod);
            }
            public QuickFix.Fields.ListMethod listMethod
            { 
                get 
                {
                    QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListMethod val) 
            { 
                this.listMethod = val;
            }
            
            public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListMethod val) 
            { 
                return IsSetListMethod();
            }
            
            public bool IsSetListMethod() 
            { 
                return IsSetField(Tags.ListMethod);
            }
            public QuickFix.Fields.CapPrice capPrice
            { 
                get 
                {
                    QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CapPrice val) 
            { 
                this.capPrice = val;
            }
            
            public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CapPrice val) 
            { 
                return IsSetCapPrice();
            }
            
            public bool IsSetCapPrice() 
            { 
                return IsSetField(Tags.CapPrice);
            }
            public QuickFix.Fields.FloorPrice floorPrice
            { 
                get 
                {
                    QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FloorPrice val) 
            { 
                this.floorPrice = val;
            }
            
            public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FloorPrice val) 
            { 
                return IsSetFloorPrice();
            }
            
            public bool IsSetFloorPrice() 
            { 
                return IsSetField(Tags.FloorPrice);
            }
            public QuickFix.Fields.PutOrCall putOrCall
            { 
                get 
                {
                    QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PutOrCall val) 
            { 
                this.putOrCall = val;
            }
            
            public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PutOrCall val) 
            { 
                return IsSetPutOrCall();
            }
            
            public bool IsSetPutOrCall() 
            { 
                return IsSetField(Tags.PutOrCall);
            }
            public QuickFix.Fields.FlexibleIndicator flexibleIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexibleIndicator val) 
            { 
                this.flexibleIndicator = val;
            }
            
            public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexibleIndicator val) 
            { 
                return IsSetFlexibleIndicator();
            }
            
            public bool IsSetFlexibleIndicator() 
            { 
                return IsSetField(Tags.FlexibleIndicator);
            }
            public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                this.flexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                return IsSetFlexProductEligibilityIndicator();
            }
            
            public bool IsSetFlexProductEligibilityIndicator() 
            { 
                return IsSetField(Tags.FlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.FuturesValuationMethod futuresValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.FuturesValuationMethod val = new QuickFix.Fields.FuturesValuationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                this.futuresValuationMethod = val;
            }
            
            public QuickFix.Fields.FuturesValuationMethod Get(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FuturesValuationMethod val) 
            { 
                return IsSetFuturesValuationMethod();
            }
            
            public bool IsSetFuturesValuationMethod() 
            { 
                return IsSetField(Tags.FuturesValuationMethod);
            }
            public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                this.underlyingSymbol = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                return IsSetUnderlyingSymbol();
            }
            
            public bool IsSetUnderlyingSymbol() 
            { 
                return IsSetField(Tags.UnderlyingSymbol);
            }
            public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                this.underlyingSymbolSfx = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                return IsSetUnderlyingSymbolSfx();
            }
            
            public bool IsSetUnderlyingSymbolSfx() 
            { 
                return IsSetField(Tags.UnderlyingSymbolSfx);
            }
            public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                this.underlyingSecurityID = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                return IsSetUnderlyingSecurityID();
            }
            
            public bool IsSetUnderlyingSecurityID() 
            { 
                return IsSetField(Tags.UnderlyingSecurityID);
            }
            public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                this.underlyingSecurityIDSource = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                return IsSetUnderlyingSecurityIDSource();
            }
            
            public bool IsSetUnderlyingSecurityIDSource() 
            { 
                return IsSetField(Tags.UnderlyingSecurityIDSource);
            }
            public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                this.noUnderlyingSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                return IsSetNoUnderlyingSecurityAltID();
            }
            
            public bool IsSetNoUnderlyingSecurityAltID() 
            { 
                return IsSetField(Tags.NoUnderlyingSecurityAltID);
            }
            public QuickFix.Fields.UnderlyingProduct underlyingProduct
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingProduct val) 
            { 
                this.underlyingProduct = val;
            }
            
            public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingProduct val) 
            { 
                return IsSetUnderlyingProduct();
            }
            
            public bool IsSetUnderlyingProduct() 
            { 
                return IsSetField(Tags.UnderlyingProduct);
            }
            public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                this.underlyingCFICode = val;
            }
            
            public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                return IsSetUnderlyingCFICode();
            }
            
            public bool IsSetUnderlyingCFICode() 
            { 
                return IsSetField(Tags.UnderlyingCFICode);
            }
            public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                this.underlyingSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                return IsSetUnderlyingSecurityType();
            }
            
            public bool IsSetUnderlyingSecurityType() 
            { 
                return IsSetField(Tags.UnderlyingSecurityType);
            }
            public QuickFix.Fields.UnderlyingSecuritySubType underlyingSecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                this.underlyingSecuritySubType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                return IsSetUnderlyingSecuritySubType();
            }
            
            public bool IsSetUnderlyingSecuritySubType() 
            { 
                return IsSetField(Tags.UnderlyingSecuritySubType);
            }
            public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                this.underlyingMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                return IsSetUnderlyingMaturityMonthYear();
            }
            
            public bool IsSetUnderlyingMaturityMonthYear() 
            { 
                return IsSetField(Tags.UnderlyingMaturityMonthYear);
            }
            public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                this.underlyingMaturityDate = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                return IsSetUnderlyingMaturityDate();
            }
            
            public bool IsSetUnderlyingMaturityDate() 
            { 
                return IsSetField(Tags.UnderlyingMaturityDate);
            }
            public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                this.underlyingCouponPaymentDate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                return IsSetUnderlyingCouponPaymentDate();
            }
            
            public bool IsSetUnderlyingCouponPaymentDate() 
            { 
                return IsSetField(Tags.UnderlyingCouponPaymentDate);
            }
            public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                this.underlyingIssueDate = val;
            }
            
            public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                return IsSetUnderlyingIssueDate();
            }
            
            public bool IsSetUnderlyingIssueDate() 
            { 
                return IsSetField(Tags.UnderlyingIssueDate);
            }
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                this.underlyingRepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                return IsSetUnderlyingRepoCollateralSecurityType();
            }
            
            public bool IsSetUnderlyingRepoCollateralSecurityType() 
            { 
                return IsSetField(Tags.UnderlyingRepoCollateralSecurityType);
            }
            public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                this.underlyingRepurchaseTerm = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                return IsSetUnderlyingRepurchaseTerm();
            }
            
            public bool IsSetUnderlyingRepurchaseTerm() 
            { 
                return IsSetField(Tags.UnderlyingRepurchaseTerm);
            }
            public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                this.underlyingRepurchaseRate = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                return IsSetUnderlyingRepurchaseRate();
            }
            
            public bool IsSetUnderlyingRepurchaseRate() 
            { 
                return IsSetField(Tags.UnderlyingRepurchaseRate);
            }
            public QuickFix.Fields.UnderlyingFactor underlyingFactor
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingFactor val) 
            { 
                this.underlyingFactor = val;
            }
            
            public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
            { 
                return IsSetUnderlyingFactor();
            }
            
            public bool IsSetUnderlyingFactor() 
            { 
                return IsSetField(Tags.UnderlyingFactor);
            }
            public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                this.underlyingCreditRating = val;
            }
            
            public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                return IsSetUnderlyingCreditRating();
            }
            
            public bool IsSetUnderlyingCreditRating() 
            { 
                return IsSetField(Tags.UnderlyingCreditRating);
            }
            public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                this.underlyingInstrRegistry = val;
            }
            
            public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                return IsSetUnderlyingInstrRegistry();
            }
            
            public bool IsSetUnderlyingInstrRegistry() 
            { 
                return IsSetField(Tags.UnderlyingInstrRegistry);
            }
            public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                this.underlyingCountryOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                return IsSetUnderlyingCountryOfIssue();
            }
            
            public bool IsSetUnderlyingCountryOfIssue() 
            { 
                return IsSetField(Tags.UnderlyingCountryOfIssue);
            }
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                this.underlyingStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                return IsSetUnderlyingStateOrProvinceOfIssue();
            }
            
            public bool IsSetUnderlyingStateOrProvinceOfIssue() 
            { 
                return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                this.underlyingLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                return IsSetUnderlyingLocaleOfIssue();
            }
            
            public bool IsSetUnderlyingLocaleOfIssue() 
            { 
                return IsSetField(Tags.UnderlyingLocaleOfIssue);
            }
            public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                this.underlyingRedemptionDate = val;
            }
            
            public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                return IsSetUnderlyingRedemptionDate();
            }
            
            public bool IsSetUnderlyingRedemptionDate() 
            { 
                return IsSetField(Tags.UnderlyingRedemptionDate);
            }
            public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                this.underlyingStrikePrice = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                return IsSetUnderlyingStrikePrice();
            }
            
            public bool IsSetUnderlyingStrikePrice() 
            { 
                return IsSetField(Tags.UnderlyingStrikePrice);
            }
            public QuickFix.Fields.UnderlyingStrikeCurrency underlyingStrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                this.underlyingStrikeCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                return IsSetUnderlyingStrikeCurrency();
            }
            
            public bool IsSetUnderlyingStrikeCurrency() 
            { 
                return IsSetField(Tags.UnderlyingStrikeCurrency);
            }
            public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                this.underlyingOptAttribute = val;
            }
            
            public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                return IsSetUnderlyingOptAttribute();
            }
            
            public bool IsSetUnderlyingOptAttribute() 
            { 
                return IsSetField(Tags.UnderlyingOptAttribute);
            }
            public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                this.underlyingContractMultiplier = val;
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                return IsSetUnderlyingContractMultiplier();
            }
            
            public bool IsSetUnderlyingContractMultiplier() 
            { 
                return IsSetField(Tags.UnderlyingContractMultiplier);
            }
            public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                this.underlyingCouponRate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                return IsSetUnderlyingCouponRate();
            }
            
            public bool IsSetUnderlyingCouponRate() 
            { 
                return IsSetField(Tags.UnderlyingCouponRate);
            }
            public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                this.underlyingSecurityExchange = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                return IsSetUnderlyingSecurityExchange();
            }
            
            public bool IsSetUnderlyingSecurityExchange() 
            { 
                return IsSetField(Tags.UnderlyingSecurityExchange);
            }
            public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                this.underlyingIssuer = val;
            }
            
            public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                return IsSetUnderlyingIssuer();
            }
            
            public bool IsSetUnderlyingIssuer() 
            { 
                return IsSetField(Tags.UnderlyingIssuer);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                this.encodedUnderlyingIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                return IsSetEncodedUnderlyingIssuerLen();
            }
            
            public bool IsSetEncodedUnderlyingIssuerLen() 
            { 
                return IsSetField(Tags.EncodedUnderlyingIssuerLen);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                this.encodedUnderlyingIssuer = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                return IsSetEncodedUnderlyingIssuer();
            }
            
            public bool IsSetEncodedUnderlyingIssuer() 
            { 
                return IsSetField(Tags.EncodedUnderlyingIssuer);
            }
            public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                this.underlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                return IsSetUnderlyingSecurityDesc();
            }
            
            public bool IsSetUnderlyingSecurityDesc() 
            { 
                return IsSetField(Tags.UnderlyingSecurityDesc);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                this.encodedUnderlyingSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                return IsSetEncodedUnderlyingSecurityDescLen();
            }
            
            public bool IsSetEncodedUnderlyingSecurityDescLen() 
            { 
                return IsSetField(Tags.EncodedUnderlyingSecurityDescLen);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                this.encodedUnderlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                return IsSetEncodedUnderlyingSecurityDesc();
            }
            
            public bool IsSetEncodedUnderlyingSecurityDesc() 
            { 
                return IsSetField(Tags.EncodedUnderlyingSecurityDesc);
            }
            public QuickFix.Fields.UnderlyingCPProgram underlyingCPProgram
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                this.underlyingCPProgram = val;
            }
            
            public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                return IsSetUnderlyingCPProgram();
            }
            
            public bool IsSetUnderlyingCPProgram() 
            { 
                return IsSetField(Tags.UnderlyingCPProgram);
            }
            public QuickFix.Fields.UnderlyingCPRegType underlyingCPRegType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                this.underlyingCPRegType = val;
            }
            
            public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                return IsSetUnderlyingCPRegType();
            }
            
            public bool IsSetUnderlyingCPRegType() 
            { 
                return IsSetField(Tags.UnderlyingCPRegType);
            }
            public QuickFix.Fields.UnderlyingCurrency underlyingCurrency
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                this.underlyingCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                return IsSetUnderlyingCurrency();
            }
            
            public bool IsSetUnderlyingCurrency() 
            { 
                return IsSetField(Tags.UnderlyingCurrency);
            }
            public QuickFix.Fields.UnderlyingQty underlyingQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingQty val) 
            { 
                this.underlyingQty = val;
            }
            
            public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingQty val) 
            { 
                return IsSetUnderlyingQty();
            }
            
            public bool IsSetUnderlyingQty() 
            { 
                return IsSetField(Tags.UnderlyingQty);
            }
            public QuickFix.Fields.UnderlyingPx underlyingPx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPx val) 
            { 
                this.underlyingPx = val;
            }
            
            public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPx val) 
            { 
                return IsSetUnderlyingPx();
            }
            
            public bool IsSetUnderlyingPx() 
            { 
                return IsSetField(Tags.UnderlyingPx);
            }
            public QuickFix.Fields.UnderlyingDirtyPrice underlyingDirtyPrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                this.underlyingDirtyPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                return IsSetUnderlyingDirtyPrice();
            }
            
            public bool IsSetUnderlyingDirtyPrice() 
            { 
                return IsSetField(Tags.UnderlyingDirtyPrice);
            }
            public QuickFix.Fields.UnderlyingEndPrice underlyingEndPrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                this.underlyingEndPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                return IsSetUnderlyingEndPrice();
            }
            
            public bool IsSetUnderlyingEndPrice() 
            { 
                return IsSetField(Tags.UnderlyingEndPrice);
            }
            public QuickFix.Fields.UnderlyingStartValue underlyingStartValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                this.underlyingStartValue = val;
            }
            
            public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                return IsSetUnderlyingStartValue();
            }
            
            public bool IsSetUnderlyingStartValue() 
            { 
                return IsSetField(Tags.UnderlyingStartValue);
            }
            public QuickFix.Fields.UnderlyingCurrentValue underlyingCurrentValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                this.underlyingCurrentValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                return IsSetUnderlyingCurrentValue();
            }
            
            public bool IsSetUnderlyingCurrentValue() 
            { 
                return IsSetField(Tags.UnderlyingCurrentValue);
            }
            public QuickFix.Fields.UnderlyingEndValue underlyingEndValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                this.underlyingEndValue = val;
            }
            
            public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                return IsSetUnderlyingEndValue();
            }
            
            public bool IsSetUnderlyingEndValue() 
            { 
                return IsSetField(Tags.UnderlyingEndValue);
            }
            public QuickFix.Fields.NoUnderlyingStips noUnderlyingStips
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                this.noUnderlyingStips = val;
            }
            
            public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                return IsSetNoUnderlyingStips();
            }
            
            public bool IsSetNoUnderlyingStips() 
            { 
                return IsSetField(Tags.NoUnderlyingStips);
            }
            public QuickFix.Fields.UnderlyingAllocationPercent underlyingAllocationPercent
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                this.underlyingAllocationPercent = val;
            }
            
            public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                return IsSetUnderlyingAllocationPercent();
            }
            
            public bool IsSetUnderlyingAllocationPercent() 
            { 
                return IsSetField(Tags.UnderlyingAllocationPercent);
            }
            public QuickFix.Fields.UnderlyingSettlementType underlyingSettlementType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                this.underlyingSettlementType = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                return IsSetUnderlyingSettlementType();
            }
            
            public bool IsSetUnderlyingSettlementType() 
            { 
                return IsSetField(Tags.UnderlyingSettlementType);
            }
            public QuickFix.Fields.UnderlyingCashAmount underlyingCashAmount
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                this.underlyingCashAmount = val;
            }
            
            public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                return IsSetUnderlyingCashAmount();
            }
            
            public bool IsSetUnderlyingCashAmount() 
            { 
                return IsSetField(Tags.UnderlyingCashAmount);
            }
            public QuickFix.Fields.UnderlyingCashType underlyingCashType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCashType val) 
            { 
                this.underlyingCashType = val;
            }
            
            public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCashType val) 
            { 
                return IsSetUnderlyingCashType();
            }
            
            public bool IsSetUnderlyingCashType() 
            { 
                return IsSetField(Tags.UnderlyingCashType);
            }
            public QuickFix.Fields.UnderlyingUnitOfMeasure underlyingUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                this.underlyingUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                return IsSetUnderlyingUnitOfMeasure();
            }
            
            public bool IsSetUnderlyingUnitOfMeasure() 
            { 
                return IsSetField(Tags.UnderlyingUnitOfMeasure);
            }
            public QuickFix.Fields.UnderlyingTimeUnit underlyingTimeUnit
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                this.underlyingTimeUnit = val;
            }
            
            public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                return IsSetUnderlyingTimeUnit();
            }
            
            public bool IsSetUnderlyingTimeUnit() 
            { 
                return IsSetField(Tags.UnderlyingTimeUnit);
            }
            public QuickFix.Fields.UnderlyingCapValue underlyingCapValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                this.underlyingCapValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                return IsSetUnderlyingCapValue();
            }
            
            public bool IsSetUnderlyingCapValue() 
            { 
                return IsSetField(Tags.UnderlyingCapValue);
            }
            public QuickFix.Fields.NoUndlyInstrumentParties noUndlyInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                this.noUndlyInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                return IsSetNoUndlyInstrumentParties();
            }
            
            public bool IsSetNoUndlyInstrumentParties() 
            { 
                return IsSetField(Tags.NoUndlyInstrumentParties);
            }
            public QuickFix.Fields.UnderlyingSettlMethod underlyingSettlMethod
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                this.underlyingSettlMethod = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                return IsSetUnderlyingSettlMethod();
            }
            
            public bool IsSetUnderlyingSettlMethod() 
            { 
                return IsSetField(Tags.UnderlyingSettlMethod);
            }
            public QuickFix.Fields.UnderlyingAdjustedQuantity underlyingAdjustedQuantity
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                this.underlyingAdjustedQuantity = val;
            }
            
            public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                return IsSetUnderlyingAdjustedQuantity();
            }
            
            public bool IsSetUnderlyingAdjustedQuantity() 
            { 
                return IsSetField(Tags.UnderlyingAdjustedQuantity);
            }
            public QuickFix.Fields.UnderlyingFXRate underlyingFXRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                this.underlyingFXRate = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                return IsSetUnderlyingFXRate();
            }
            
            public bool IsSetUnderlyingFXRate() 
            { 
                return IsSetField(Tags.UnderlyingFXRate);
            }
            public QuickFix.Fields.UnderlyingFXRateCalc underlyingFXRateCalc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                this.underlyingFXRateCalc = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                return IsSetUnderlyingFXRateCalc();
            }
            
            public bool IsSetUnderlyingFXRateCalc() 
            { 
                return IsSetField(Tags.UnderlyingFXRateCalc);
            }
            public QuickFix.Fields.UnderlyingMaturityTime underlyingMaturityTime
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                this.underlyingMaturityTime = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                return IsSetUnderlyingMaturityTime();
            }
            
            public bool IsSetUnderlyingMaturityTime() 
            { 
                return IsSetField(Tags.UnderlyingMaturityTime);
            }
            public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                this.underlyingPutOrCall = val;
            }
            
            public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                return IsSetUnderlyingPutOrCall();
            }
            
            public bool IsSetUnderlyingPutOrCall() 
            { 
                return IsSetField(Tags.UnderlyingPutOrCall);
            }
            public QuickFix.Fields.UnderlyingExerciseStyle underlyingExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                this.underlyingExerciseStyle = val;
            }
            
            public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                return IsSetUnderlyingExerciseStyle();
            }
            
            public bool IsSetUnderlyingExerciseStyle() 
            { 
                return IsSetField(Tags.UnderlyingExerciseStyle);
            }
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty underlyingUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                this.underlyingUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                return IsSetUnderlyingUnitOfMeasureQty();
            }
            
            public bool IsSetUnderlyingUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.UnderlyingUnitOfMeasureQty);
            }
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure underlyingPriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                this.underlyingPriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                return IsSetUnderlyingPriceUnitOfMeasure();
            }
            
            public bool IsSetUnderlyingPriceUnitOfMeasure() 
            { 
                return IsSetField(Tags.UnderlyingPriceUnitOfMeasure);
            }
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty underlyingPriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                this.underlyingPriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                return IsSetUnderlyingPriceUnitOfMeasureQty();
            }
            
            public bool IsSetUnderlyingPriceUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.Side side
            { 
                get 
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Side val) 
            { 
                this.side = val;
            }
            
            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Side val) 
            { 
                return IsSetSide();
            }
            
            public bool IsSetSide() 
            { 
                return IsSetField(Tags.Side);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(Tags.EncodedText);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketID val) 
            { 
                return IsSetMarketID();
            }
            
            public bool IsSetMarketID() 
            { 
                return IsSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return IsSetMarketSegmentID();
            }
            
            public bool IsSetMarketSegmentID() 
            { 
                return IsSetField(Tags.MarketSegmentID);
            }
            public class NoSecurityAltID : Group
            {
                public NoSecurityAltID() 
                  :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                            public QuickFix.Fields.SecurityAltID securityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.securityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.securityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoEvents : Group
            {
                public NoEvents() 
                  :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                            public QuickFix.Fields.EventType eventType
                { 
                    get 
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventType val) 
                { 
                    this.eventType = val;
                }
                
                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(Tags.EventType);
                }
                public QuickFix.Fields.EventDate eventDate
                { 
                    get 
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventDate val) 
                { 
                    this.eventDate = val;
                }
                
                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(Tags.EventDate);
                }
                public QuickFix.Fields.EventPx eventPx
                { 
                    get 
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventPx val) 
                { 
                    this.eventPx = val;
                }
                
                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(Tags.EventPx);
                }
                public QuickFix.Fields.EventText eventText
                { 
                    get 
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventText val) 
                { 
                    this.eventText = val;
                }
                
                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(Tags.EventText);
                }
                public QuickFix.Fields.EventTime eventTime
                { 
                    get 
                    {
                        QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventTime val) 
                { 
                    this.eventTime = val;
                }
                
                public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventTime val) 
                { 
                    return IsSetEventTime();
                }
                
                public bool IsSetEventTime() 
                { 
                    return IsSetField(Tags.EventTime);
                }
            
            }
            public class NoInstrumentParties : Group
            {
                public NoInstrumentParties() 
                  :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.InstrumentPartyID instrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    this.instrumentPartyID = val;
                }
                
                public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    return IsSetInstrumentPartyID();
                }
                
                public bool IsSetInstrumentPartyID() 
                { 
                    return IsSetField(Tags.InstrumentPartyID);
                }
                public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    this.instrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    return IsSetInstrumentPartyIDSource();
                }
                
                public bool IsSetInstrumentPartyIDSource() 
                { 
                    return IsSetField(Tags.InstrumentPartyIDSource);
                }
                public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    this.instrumentPartyRole = val;
                }
                
                public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    return IsSetInstrumentPartyRole();
                }
                
                public bool IsSetInstrumentPartyRole() 
                { 
                    return IsSetField(Tags.InstrumentPartyRole);
                }
                public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    this.noInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    return IsSetNoInstrumentPartySubIDs();
                }
                
                public bool IsSetNoInstrumentPartySubIDs() 
                { 
                    return IsSetField(Tags.NoInstrumentPartySubIDs);
                }
                            public class NoInstrumentPartySubIDs : Group
                {
                    public NoInstrumentPartySubIDs() 
                      :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        this.instrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        return IsSetInstrumentPartySubID();
                    }
                    
                    public bool IsSetInstrumentPartySubID() 
                    { 
                        return IsSetField(Tags.InstrumentPartySubID);
                    }
                    public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        this.instrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        return IsSetInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetInstrumentPartySubIDType() 
                    { 
                        return IsSetField(Tags.InstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoUnderlyingSecurityAltID : Group
            {
                public NoUnderlyingSecurityAltID() 
                  :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                            public QuickFix.Fields.UnderlyingSecurityAltID underlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    this.underlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    return IsSetUnderlyingSecurityAltID();
                }
                
                public bool IsSetUnderlyingSecurityAltID() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    this.underlyingSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    return IsSetUnderlyingSecurityAltIDSource();
                }
                
                public bool IsSetUnderlyingSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                }
            
            }
            public class NoUnderlyingStips : Group
            {
                public NoUnderlyingStips() 
                  :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                            public QuickFix.Fields.UnderlyingStipType underlyingStipType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    this.underlyingStipType = val;
                }
                
                public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    return IsSetUnderlyingStipType();
                }
                
                public bool IsSetUnderlyingStipType() 
                { 
                    return IsSetField(Tags.UnderlyingStipType);
                }
                public QuickFix.Fields.UnderlyingStipValue underlyingStipValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    this.underlyingStipValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    return IsSetUnderlyingStipValue();
                }
                
                public bool IsSetUnderlyingStipValue() 
                { 
                    return IsSetField(Tags.UnderlyingStipValue);
                }
            
            }
            public class NoUndlyInstrumentParties : Group
            {
                public NoUndlyInstrumentParties() 
                  :base( Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.UndlyInstrumentPartyID undlyInstrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.UndlyInstrumentPartyID val = new QuickFix.Fields.UndlyInstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    this.undlyInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyID Get(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    return IsSetUndlyInstrumentPartyID();
                }
                
                public bool IsSetUndlyInstrumentPartyID() 
                { 
                    return IsSetField(Tags.UndlyInstrumentPartyID);
                }
                public QuickFix.Fields.UndlyInstrumentPartyIDSource undlyInstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UndlyInstrumentPartyIDSource val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    this.undlyInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyIDSource Get(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    return IsSetUndlyInstrumentPartyIDSource();
                }
                
                public bool IsSetUndlyInstrumentPartyIDSource() 
                { 
                    return IsSetField(Tags.UndlyInstrumentPartyIDSource);
                }
                public QuickFix.Fields.UndlyInstrumentPartyRole undlyInstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.UndlyInstrumentPartyRole val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    this.undlyInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyRole Get(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    return IsSetUndlyInstrumentPartyRole();
                }
                
                public bool IsSetUndlyInstrumentPartyRole() 
                { 
                    return IsSetField(Tags.UndlyInstrumentPartyRole);
                }
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs noUndlyInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    this.noUndlyInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    return IsSetNoUndlyInstrumentPartySubIDs();
                }
                
                public bool IsSetNoUndlyInstrumentPartySubIDs() 
                { 
                    return IsSetField(Tags.NoUndlyInstrumentPartySubIDs);
                }
                            public class NoUndlyInstrumentPartySubIDs : Group
                {
                    public NoUndlyInstrumentPartySubIDs() 
                      :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.UndlyInstrumentPartySubID undlyInstrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartySubID val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        this.undlyInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubID Get(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        return IsSetUndlyInstrumentPartySubID();
                    }
                    
                    public bool IsSetUndlyInstrumentPartySubID() 
                    { 
                        return IsSetField(Tags.UndlyInstrumentPartySubID);
                    }
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType undlyInstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartySubIDType val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        this.undlyInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType Get(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        return IsSetUndlyInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetUndlyInstrumentPartySubIDType() 
                    { 
                        return IsSetField(Tags.UndlyInstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoPartyIDs : Group
            {
                public NoPartyIDs() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                            public QuickFix.Fields.PartyID partyID
                { 
                    get 
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    this.noPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(Tags.NoPartySubIDs);
                }
                            public class NoPartySubIDs : Group
                {
                    public NoPartySubIDs() 
                      :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                                    public QuickFix.Fields.PartySubID partySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.partySubID = val;
                    }
                    
                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubID val) 
                    { 
                        return IsSetPartySubID();
                    }
                    
                    public bool IsSetPartySubID() 
                    { 
                        return IsSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType partySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        this.partySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(Tags.PartySubIDType);
                    }
                
                }
            }
        }
    }
}
