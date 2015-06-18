using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class QuoteStatusReport : Message
    {
        public const string MsgType = "AI";

        public QuoteStatusReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public QuoteStatusReport(QuickFix.Fields.QuoteID aQuoteID,
				QuickFix.Fields.Symbol aSymbol)
               : this()
        {
            this.QuoteID = aQuoteID;
			this.Symbol = aSymbol;
        }

        public QuickFix.Fields.QuoteStatusReqID QuoteStatusReqID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteStatusReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteStatusReqID val) { this.QuoteStatusReqID = val; }

        public QuickFix.Fields.QuoteStatusReqID Get(QuickFix.Fields.QuoteStatusReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteStatusReqID val) { return IsSetQuoteStatusReqID(); }

        public bool IsSetQuoteStatusReqID() { return IsSetField(Tags.QuoteStatusReqID); }

        public QuickFix.Fields.QuoteReqID QuoteReqID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteReqID val) { this.QuoteReqID = val; }

        public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteReqID val) { return IsSetQuoteReqID(); }

        public bool IsSetQuoteReqID() { return IsSetField(Tags.QuoteReqID); }

        public QuickFix.Fields.QuoteID QuoteID
        {
            get
            {
                var val = new QuickFix.Fields.QuoteID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteID val) { this.QuoteID = val; }

        public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteID val) { return IsSetQuoteID(); }

        public bool IsSetQuoteID() { return IsSetField(Tags.QuoteID); }

        public QuickFix.Fields.QuoteType QuoteType
        {
            get
            {
                var val = new QuickFix.Fields.QuoteType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteType val) { this.QuoteType = val; }

        public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteType val) { return IsSetQuoteType(); }

        public bool IsSetQuoteType() { return IsSetField(Tags.QuoteType); }

        public QuickFix.Fields.NoPartyIDs NoPartyIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoPartyIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoPartyIDs val) { this.NoPartyIDs = val; }

        public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoPartyIDs val) { return IsSetNoPartyIDs(); }

        public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

        public QuickFix.Fields.Account Account
        {
            get
            {
                var val = new QuickFix.Fields.Account();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Account val) { this.Account = val; }

        public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Account val) { return IsSetAccount(); }

        public bool IsSetAccount() { return IsSetField(Tags.Account); }

        public QuickFix.Fields.AccountType AccountType
        {
            get
            {
                var val = new QuickFix.Fields.AccountType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.AccountType val) { this.AccountType = val; }

        public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.AccountType val) { return IsSetAccountType(); }

        public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

        public QuickFix.Fields.TradingSessionID TradingSessionID
        {
            get
            {
                var val = new QuickFix.Fields.TradingSessionID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradingSessionID val) { this.TradingSessionID = val; }

        public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradingSessionID val) { return IsSetTradingSessionID(); }

        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

        public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
        {
            get
            {
                var val = new QuickFix.Fields.TradingSessionSubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradingSessionSubID val) { this.TradingSessionSubID = val; }

        public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradingSessionSubID val) { return IsSetTradingSessionSubID(); }

        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

        public QuickFix.Fields.Symbol Symbol
        {
            get
            {
                var val = new QuickFix.Fields.Symbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Symbol val) { this.Symbol = val; }

        public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Symbol val) { return IsSetSymbol(); }

        public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

        public QuickFix.Fields.SymbolSfx SymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.SymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SymbolSfx val) { this.SymbolSfx = val; }

        public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SymbolSfx val) { return IsSetSymbolSfx(); }

        public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

        public QuickFix.Fields.SecurityID SecurityID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityID val) { this.SecurityID = val; }

        public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityID val) { return IsSetSecurityID(); }

        public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

        public QuickFix.Fields.SecurityIDSource SecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.SecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityIDSource val) { this.SecurityIDSource = val; }

        public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityIDSource val) { return IsSetSecurityIDSource(); }

        public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

        public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoSecurityAltID val) { this.NoSecurityAltID = val; }

        public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoSecurityAltID val) { return IsSetNoSecurityAltID(); }

        public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

        public QuickFix.Fields.Product Product
        {
            get
            {
                var val = new QuickFix.Fields.Product();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Product val) { this.Product = val; }

        public QuickFix.Fields.Product Get(QuickFix.Fields.Product val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Product val) { return IsSetProduct(); }

        public bool IsSetProduct() { return IsSetField(Tags.Product); }

        public QuickFix.Fields.CFICode CFICode
        {
            get
            {
                var val = new QuickFix.Fields.CFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CFICode val) { this.CFICode = val; }

        public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CFICode val) { return IsSetCFICode(); }

        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

        public QuickFix.Fields.SecurityType SecurityType
        {
            get
            {
                var val = new QuickFix.Fields.SecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityType val) { this.SecurityType = val; }

        public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityType val) { return IsSetSecurityType(); }

        public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

        public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.MaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityMonthYear val) { this.MaturityMonthYear = val; }

        public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityMonthYear val) { return IsSetMaturityMonthYear(); }

        public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

        public QuickFix.Fields.MaturityDate MaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.MaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaturityDate val) { this.MaturityDate = val; }

        public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaturityDate val) { return IsSetMaturityDate(); }

        public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

        public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.CouponPaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CouponPaymentDate val) { this.CouponPaymentDate = val; }

        public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CouponPaymentDate val) { return IsSetCouponPaymentDate(); }

        public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

        public QuickFix.Fields.IssueDate IssueDate
        {
            get
            {
                var val = new QuickFix.Fields.IssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.IssueDate val) { this.IssueDate = val; }

        public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.IssueDate val) { return IsSetIssueDate(); }

        public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

        public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.RepoCollateralSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RepoCollateralSecurityType val) { this.RepoCollateralSecurityType = val; }

        public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }

        public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

        public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
        {
            get
            {
                var val = new QuickFix.Fields.RepurchaseTerm();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RepurchaseTerm val) { this.RepurchaseTerm = val; }

        public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RepurchaseTerm val) { return IsSetRepurchaseTerm(); }

        public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

        public QuickFix.Fields.RepurchaseRate RepurchaseRate
        {
            get
            {
                var val = new QuickFix.Fields.RepurchaseRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RepurchaseRate val) { this.RepurchaseRate = val; }

        public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RepurchaseRate val) { return IsSetRepurchaseRate(); }

        public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

        public QuickFix.Fields.Factor Factor
        {
            get
            {
                var val = new QuickFix.Fields.Factor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Factor val) { this.Factor = val; }

        public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Factor val) { return IsSetFactor(); }

        public bool IsSetFactor() { return IsSetField(Tags.Factor); }

        public QuickFix.Fields.CreditRating CreditRating
        {
            get
            {
                var val = new QuickFix.Fields.CreditRating();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CreditRating val) { this.CreditRating = val; }

        public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CreditRating val) { return IsSetCreditRating(); }

        public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

        public QuickFix.Fields.InstrRegistry InstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.InstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.InstrRegistry val) { this.InstrRegistry = val; }

        public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.InstrRegistry val) { return IsSetInstrRegistry(); }

        public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

        public QuickFix.Fields.CountryOfIssue CountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.CountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CountryOfIssue val) { this.CountryOfIssue = val; }

        public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CountryOfIssue val) { return IsSetCountryOfIssue(); }

        public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

        public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.StateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) { this.StateOrProvinceOfIssue = val; }

        public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }

        public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

        public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LocaleOfIssue val) { this.LocaleOfIssue = val; }

        public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LocaleOfIssue val) { return IsSetLocaleOfIssue(); }

        public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

        public QuickFix.Fields.RedemptionDate RedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.RedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RedemptionDate val) { this.RedemptionDate = val; }

        public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RedemptionDate val) { return IsSetRedemptionDate(); }

        public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

        public QuickFix.Fields.StrikePrice StrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.StrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StrikePrice val) { this.StrikePrice = val; }

        public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StrikePrice val) { return IsSetStrikePrice(); }

        public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

        public QuickFix.Fields.OptAttribute OptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.OptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OptAttribute val) { this.OptAttribute = val; }

        public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OptAttribute val) { return IsSetOptAttribute(); }

        public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

        public QuickFix.Fields.ContractMultiplier ContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.ContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ContractMultiplier val) { this.ContractMultiplier = val; }

        public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ContractMultiplier val) { return IsSetContractMultiplier(); }

        public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

        public QuickFix.Fields.CouponRate CouponRate
        {
            get
            {
                var val = new QuickFix.Fields.CouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CouponRate val) { this.CouponRate = val; }

        public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CouponRate val) { return IsSetCouponRate(); }

        public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

        public QuickFix.Fields.SecurityExchange SecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.SecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityExchange val) { this.SecurityExchange = val; }

        public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityExchange val) { return IsSetSecurityExchange(); }

        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

        public QuickFix.Fields.Issuer Issuer
        {
            get
            {
                var val = new QuickFix.Fields.Issuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Issuer val) { this.Issuer = val; }

        public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Issuer val) { return IsSetIssuer(); }

        public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

        public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedIssuerLen val) { this.EncodedIssuerLen = val; }

        public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }

        public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

        public QuickFix.Fields.EncodedIssuer EncodedIssuer
        {
            get
            {
                var val = new QuickFix.Fields.EncodedIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedIssuer val) { this.EncodedIssuer = val; }

        public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedIssuer val) { return IsSetEncodedIssuer(); }

        public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

        public QuickFix.Fields.SecurityDesc SecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.SecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityDesc val) { this.SecurityDesc = val; }

        public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityDesc val) { return IsSetSecurityDesc(); }

        public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

        public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedSecurityDescLen val) { this.EncodedSecurityDescLen = val; }

        public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }

        public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

        public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.EncodedSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedSecurityDesc val) { this.EncodedSecurityDesc = val; }

        public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }

        public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

        public QuickFix.Fields.BidPx BidPx
        {
            get
            {
                var val = new QuickFix.Fields.BidPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidPx val) { this.BidPx = val; }

        public QuickFix.Fields.BidPx Get(QuickFix.Fields.BidPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidPx val) { return IsSetBidPx(); }

        public bool IsSetBidPx() { return IsSetField(Tags.BidPx); }

        public QuickFix.Fields.OfferPx OfferPx
        {
            get
            {
                var val = new QuickFix.Fields.OfferPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferPx val) { this.OfferPx = val; }

        public QuickFix.Fields.OfferPx Get(QuickFix.Fields.OfferPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferPx val) { return IsSetOfferPx(); }

        public bool IsSetOfferPx() { return IsSetField(Tags.OfferPx); }

        public QuickFix.Fields.MktBidPx MktBidPx
        {
            get
            {
                var val = new QuickFix.Fields.MktBidPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MktBidPx val) { this.MktBidPx = val; }

        public QuickFix.Fields.MktBidPx Get(QuickFix.Fields.MktBidPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MktBidPx val) { return IsSetMktBidPx(); }

        public bool IsSetMktBidPx() { return IsSetField(Tags.MktBidPx); }

        public QuickFix.Fields.MktOfferPx MktOfferPx
        {
            get
            {
                var val = new QuickFix.Fields.MktOfferPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MktOfferPx val) { this.MktOfferPx = val; }

        public QuickFix.Fields.MktOfferPx Get(QuickFix.Fields.MktOfferPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MktOfferPx val) { return IsSetMktOfferPx(); }

        public bool IsSetMktOfferPx() { return IsSetField(Tags.MktOfferPx); }

        public QuickFix.Fields.MinBidSize MinBidSize
        {
            get
            {
                var val = new QuickFix.Fields.MinBidSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinBidSize val) { this.MinBidSize = val; }

        public QuickFix.Fields.MinBidSize Get(QuickFix.Fields.MinBidSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinBidSize val) { return IsSetMinBidSize(); }

        public bool IsSetMinBidSize() { return IsSetField(Tags.MinBidSize); }

        public QuickFix.Fields.BidSize BidSize
        {
            get
            {
                var val = new QuickFix.Fields.BidSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidSize val) { this.BidSize = val; }

        public QuickFix.Fields.BidSize Get(QuickFix.Fields.BidSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidSize val) { return IsSetBidSize(); }

        public bool IsSetBidSize() { return IsSetField(Tags.BidSize); }

        public QuickFix.Fields.MinOfferSize MinOfferSize
        {
            get
            {
                var val = new QuickFix.Fields.MinOfferSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinOfferSize val) { this.MinOfferSize = val; }

        public QuickFix.Fields.MinOfferSize Get(QuickFix.Fields.MinOfferSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinOfferSize val) { return IsSetMinOfferSize(); }

        public bool IsSetMinOfferSize() { return IsSetField(Tags.MinOfferSize); }

        public QuickFix.Fields.OfferSize OfferSize
        {
            get
            {
                var val = new QuickFix.Fields.OfferSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferSize val) { this.OfferSize = val; }

        public QuickFix.Fields.OfferSize Get(QuickFix.Fields.OfferSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferSize val) { return IsSetOfferSize(); }

        public bool IsSetOfferSize() { return IsSetField(Tags.OfferSize); }

        public QuickFix.Fields.ValidUntilTime ValidUntilTime
        {
            get
            {
                var val = new QuickFix.Fields.ValidUntilTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ValidUntilTime val) { this.ValidUntilTime = val; }

        public QuickFix.Fields.ValidUntilTime Get(QuickFix.Fields.ValidUntilTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ValidUntilTime val) { return IsSetValidUntilTime(); }

        public bool IsSetValidUntilTime() { return IsSetField(Tags.ValidUntilTime); }

        public QuickFix.Fields.BidSpotRate BidSpotRate
        {
            get
            {
                var val = new QuickFix.Fields.BidSpotRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidSpotRate val) { this.BidSpotRate = val; }

        public QuickFix.Fields.BidSpotRate Get(QuickFix.Fields.BidSpotRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidSpotRate val) { return IsSetBidSpotRate(); }

        public bool IsSetBidSpotRate() { return IsSetField(Tags.BidSpotRate); }

        public QuickFix.Fields.OfferSpotRate OfferSpotRate
        {
            get
            {
                var val = new QuickFix.Fields.OfferSpotRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferSpotRate val) { this.OfferSpotRate = val; }

        public QuickFix.Fields.OfferSpotRate Get(QuickFix.Fields.OfferSpotRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferSpotRate val) { return IsSetOfferSpotRate(); }

        public bool IsSetOfferSpotRate() { return IsSetField(Tags.OfferSpotRate); }

        public QuickFix.Fields.BidForwardPoints BidForwardPoints
        {
            get
            {
                var val = new QuickFix.Fields.BidForwardPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidForwardPoints val) { this.BidForwardPoints = val; }

        public QuickFix.Fields.BidForwardPoints Get(QuickFix.Fields.BidForwardPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidForwardPoints val) { return IsSetBidForwardPoints(); }

        public bool IsSetBidForwardPoints() { return IsSetField(Tags.BidForwardPoints); }

        public QuickFix.Fields.OfferForwardPoints OfferForwardPoints
        {
            get
            {
                var val = new QuickFix.Fields.OfferForwardPoints();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferForwardPoints val) { this.OfferForwardPoints = val; }

        public QuickFix.Fields.OfferForwardPoints Get(QuickFix.Fields.OfferForwardPoints val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferForwardPoints val) { return IsSetOfferForwardPoints(); }

        public bool IsSetOfferForwardPoints() { return IsSetField(Tags.OfferForwardPoints); }

        public QuickFix.Fields.MidPx MidPx
        {
            get
            {
                var val = new QuickFix.Fields.MidPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MidPx val) { this.MidPx = val; }

        public QuickFix.Fields.MidPx Get(QuickFix.Fields.MidPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MidPx val) { return IsSetMidPx(); }

        public bool IsSetMidPx() { return IsSetField(Tags.MidPx); }

        public QuickFix.Fields.BidYield BidYield
        {
            get
            {
                var val = new QuickFix.Fields.BidYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidYield val) { this.BidYield = val; }

        public QuickFix.Fields.BidYield Get(QuickFix.Fields.BidYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidYield val) { return IsSetBidYield(); }

        public bool IsSetBidYield() { return IsSetField(Tags.BidYield); }

        public QuickFix.Fields.MidYield MidYield
        {
            get
            {
                var val = new QuickFix.Fields.MidYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MidYield val) { this.MidYield = val; }

        public QuickFix.Fields.MidYield Get(QuickFix.Fields.MidYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MidYield val) { return IsSetMidYield(); }

        public bool IsSetMidYield() { return IsSetField(Tags.MidYield); }

        public QuickFix.Fields.OfferYield OfferYield
        {
            get
            {
                var val = new QuickFix.Fields.OfferYield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferYield val) { this.OfferYield = val; }

        public QuickFix.Fields.OfferYield Get(QuickFix.Fields.OfferYield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferYield val) { return IsSetOfferYield(); }

        public bool IsSetOfferYield() { return IsSetField(Tags.OfferYield); }

        public QuickFix.Fields.TransactTime TransactTime
        {
            get
            {
                var val = new QuickFix.Fields.TransactTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

        public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

        public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

        public QuickFix.Fields.FutSettDate FutSettDate
        {
            get
            {
                var val = new QuickFix.Fields.FutSettDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FutSettDate val) { this.FutSettDate = val; }

        public QuickFix.Fields.FutSettDate Get(QuickFix.Fields.FutSettDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FutSettDate val) { return IsSetFutSettDate(); }

        public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

        public QuickFix.Fields.OrdType OrdType
        {
            get
            {
                var val = new QuickFix.Fields.OrdType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrdType val) { this.OrdType = val; }

        public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrdType val) { return IsSetOrdType(); }

        public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

        public QuickFix.Fields.FutSettDate2 FutSettDate2
        {
            get
            {
                var val = new QuickFix.Fields.FutSettDate2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.FutSettDate2 val) { this.FutSettDate2 = val; }

        public QuickFix.Fields.FutSettDate2 Get(QuickFix.Fields.FutSettDate2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.FutSettDate2 val) { return IsSetFutSettDate2(); }

        public bool IsSetFutSettDate2() { return IsSetField(Tags.FutSettDate2); }

        public QuickFix.Fields.OrderQty2 OrderQty2
        {
            get
            {
                var val = new QuickFix.Fields.OrderQty2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderQty2 val) { this.OrderQty2 = val; }

        public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderQty2 val) { return IsSetOrderQty2(); }

        public bool IsSetOrderQty2() { return IsSetField(Tags.OrderQty2); }

        public QuickFix.Fields.BidForwardPoints2 BidForwardPoints2
        {
            get
            {
                var val = new QuickFix.Fields.BidForwardPoints2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BidForwardPoints2 val) { this.BidForwardPoints2 = val; }

        public QuickFix.Fields.BidForwardPoints2 Get(QuickFix.Fields.BidForwardPoints2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BidForwardPoints2 val) { return IsSetBidForwardPoints2(); }

        public bool IsSetBidForwardPoints2() { return IsSetField(Tags.BidForwardPoints2); }

        public QuickFix.Fields.OfferForwardPoints2 OfferForwardPoints2
        {
            get
            {
                var val = new QuickFix.Fields.OfferForwardPoints2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OfferForwardPoints2 val) { this.OfferForwardPoints2 = val; }

        public QuickFix.Fields.OfferForwardPoints2 Get(QuickFix.Fields.OfferForwardPoints2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OfferForwardPoints2 val) { return IsSetOfferForwardPoints2(); }

        public bool IsSetOfferForwardPoints2() { return IsSetField(Tags.OfferForwardPoints2); }

        public QuickFix.Fields.Currency Currency
        {
            get
            {
                var val = new QuickFix.Fields.Currency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Currency val) { this.Currency = val; }

        public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Currency val) { return IsSetCurrency(); }

        public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

        public QuickFix.Fields.SettlCurrBidFxRate SettlCurrBidFxRate
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrBidFxRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrBidFxRate val) { this.SettlCurrBidFxRate = val; }

        public QuickFix.Fields.SettlCurrBidFxRate Get(QuickFix.Fields.SettlCurrBidFxRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrBidFxRate val) { return IsSetSettlCurrBidFxRate(); }

        public bool IsSetSettlCurrBidFxRate() { return IsSetField(Tags.SettlCurrBidFxRate); }

        public QuickFix.Fields.SettlCurrOfferFxRate SettlCurrOfferFxRate
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrOfferFxRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrOfferFxRate val) { this.SettlCurrOfferFxRate = val; }

        public QuickFix.Fields.SettlCurrOfferFxRate Get(QuickFix.Fields.SettlCurrOfferFxRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrOfferFxRate val) { return IsSetSettlCurrOfferFxRate(); }

        public bool IsSetSettlCurrOfferFxRate() { return IsSetField(Tags.SettlCurrOfferFxRate); }

        public QuickFix.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
        {
            get
            {
                var val = new QuickFix.Fields.SettlCurrFxRateCalc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlCurrFxRateCalc val) { this.SettlCurrFxRateCalc = val; }

        public QuickFix.Fields.SettlCurrFxRateCalc Get(QuickFix.Fields.SettlCurrFxRateCalc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlCurrFxRateCalc val) { return IsSetSettlCurrFxRateCalc(); }

        public bool IsSetSettlCurrFxRateCalc() { return IsSetField(Tags.SettlCurrFxRateCalc); }

        public QuickFix.Fields.CommType CommType
        {
            get
            {
                var val = new QuickFix.Fields.CommType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CommType val) { this.CommType = val; }

        public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CommType val) { return IsSetCommType(); }

        public bool IsSetCommType() { return IsSetField(Tags.CommType); }

        public QuickFix.Fields.Commission Commission
        {
            get
            {
                var val = new QuickFix.Fields.Commission();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Commission val) { this.Commission = val; }

        public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Commission val) { return IsSetCommission(); }

        public bool IsSetCommission() { return IsSetField(Tags.Commission); }

        public QuickFix.Fields.CustOrderCapacity CustOrderCapacity
        {
            get
            {
                var val = new QuickFix.Fields.CustOrderCapacity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CustOrderCapacity val) { this.CustOrderCapacity = val; }

        public QuickFix.Fields.CustOrderCapacity Get(QuickFix.Fields.CustOrderCapacity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CustOrderCapacity val) { return IsSetCustOrderCapacity(); }

        public bool IsSetCustOrderCapacity() { return IsSetField(Tags.CustOrderCapacity); }

        public QuickFix.Fields.ExDestination ExDestination
        {
            get
            {
                var val = new QuickFix.Fields.ExDestination();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExDestination val) { this.ExDestination = val; }

        public QuickFix.Fields.ExDestination Get(QuickFix.Fields.ExDestination val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExDestination val) { return IsSetExDestination(); }

        public bool IsSetExDestination() { return IsSetField(Tags.ExDestination); }

        public QuickFix.Fields.QuoteStatus QuoteStatus
        {
            get
            {
                var val = new QuickFix.Fields.QuoteStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteStatus val) { this.QuoteStatus = val; }

        public QuickFix.Fields.QuoteStatus Get(QuickFix.Fields.QuoteStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteStatus val) { return IsSetQuoteStatus(); }

        public bool IsSetQuoteStatus() { return IsSetField(Tags.QuoteStatus); }


        public class NoPartyIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};

            public NoPartyIDsGroup() : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.PartyID PartyID
        {
            get
            {
                var val = new QuickFix.Fields.PartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyID val) { this.PartyID = val; }

        public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyID val) { return IsSetPartyID(); }

        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public QuickFix.Fields.PartyIDSource PartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.PartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyIDSource val) { this.PartyIDSource = val; }

        public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyIDSource val) { return IsSetPartyIDSource(); }

        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public QuickFix.Fields.PartyRole PartyRole
        {
            get
            {
                var val = new QuickFix.Fields.PartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartyRole val) { this.PartyRole = val; }

        public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartyRole val) { return IsSetPartyRole(); }

        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public QuickFix.Fields.PartySubID PartySubID
        {
            get
            {
                var val = new QuickFix.Fields.PartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PartySubID val) { this.PartySubID = val; }

        public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PartySubID val) { return IsSetPartySubID(); }

        public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }


        }


        public class NoSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

            public NoSecurityAltIDGroup() : base(Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.SecurityAltID SecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityAltID val) { this.SecurityAltID = val; }

        public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityAltID val) { return IsSetSecurityAltID(); }

        public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

        public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.SecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityAltIDSource val) { this.SecurityAltIDSource = val; }

        public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }

        public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }


        }


    }
}
