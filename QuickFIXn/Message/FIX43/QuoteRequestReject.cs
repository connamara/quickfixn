using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class QuoteRequestReject : Message
    {
        public const string MsgType = "AG";

        public QuoteRequestReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public QuoteRequestReject(QuickFix.Fields.QuoteReqID aQuoteReqID,
				QuickFix.Fields.QuoteRequestRejectReason aQuoteRequestRejectReason)
               : this()
        {
            this.QuoteReqID = aQuoteReqID;
			this.QuoteRequestRejectReason = aQuoteRequestRejectReason;
        }

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

        public QuickFix.Fields.RFQReqID RFQReqID
        {
            get
            {
                var val = new QuickFix.Fields.RFQReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RFQReqID val) { this.RFQReqID = val; }

        public QuickFix.Fields.RFQReqID Get(QuickFix.Fields.RFQReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RFQReqID val) { return IsSetRFQReqID(); }

        public bool IsSetRFQReqID() { return IsSetField(Tags.RFQReqID); }

        public QuickFix.Fields.QuoteRequestRejectReason QuoteRequestRejectReason
        {
            get
            {
                var val = new QuickFix.Fields.QuoteRequestRejectReason();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteRequestRejectReason val) { this.QuoteRequestRejectReason = val; }

        public QuickFix.Fields.QuoteRequestRejectReason Get(QuickFix.Fields.QuoteRequestRejectReason val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteRequestRejectReason val) { return IsSetQuoteRequestRejectReason(); }

        public bool IsSetQuoteRequestRejectReason() { return IsSetField(Tags.QuoteRequestRejectReason); }

        public QuickFix.Fields.NoRelatedSym NoRelatedSym
        {
            get
            {
                var val = new QuickFix.Fields.NoRelatedSym();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoRelatedSym val) { this.NoRelatedSym = val; }

        public QuickFix.Fields.NoRelatedSym Get(QuickFix.Fields.NoRelatedSym val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoRelatedSym val) { return IsSetNoRelatedSym(); }

        public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

        public QuickFix.Fields.Text Text
        {
            get
            {
                var val = new QuickFix.Fields.Text();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Text val) { this.Text = val; }

        public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

        public bool IsSetText() { return IsSetField(Tags.Text); }

        public QuickFix.Fields.EncodedTextLen EncodedTextLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedTextLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

        public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

        public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

        public QuickFix.Fields.EncodedText EncodedText
        {
            get
            {
                var val = new QuickFix.Fields.EncodedText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

        public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

        public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }


        public class NoRelatedSymGroup : Group
        {
            public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.PrevClosePx, Tags.QuoteRequestType, Tags.QuoteType, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TradeOriginationDate, Tags.NoStipulations, Tags.Side, Tags.QuantityType, Tags.OrderQty, Tags.CashOrderQty, Tags.SettlmntTyp, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.ExpireTime, Tags.TransactTime, Tags.Currency, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.PriceType, Tags.Price, Tags.Price2, Tags.YieldType, Tags.Yield, 0};

            public NoRelatedSymGroup() : base(Tags.NoRelatedSym, Tags.Symbol, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoRelatedSymGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
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

        public QuickFix.Fields.PrevClosePx PrevClosePx
        {
            get
            {
                var val = new QuickFix.Fields.PrevClosePx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PrevClosePx val) { this.PrevClosePx = val; }

        public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PrevClosePx val) { return IsSetPrevClosePx(); }

        public bool IsSetPrevClosePx() { return IsSetField(Tags.PrevClosePx); }

        public QuickFix.Fields.QuoteRequestType QuoteRequestType
        {
            get
            {
                var val = new QuickFix.Fields.QuoteRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuoteRequestType val) { this.QuoteRequestType = val; }

        public QuickFix.Fields.QuoteRequestType Get(QuickFix.Fields.QuoteRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuoteRequestType val) { return IsSetQuoteRequestType(); }

        public bool IsSetQuoteRequestType() { return IsSetField(Tags.QuoteRequestType); }

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

        public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
        {
            get
            {
                var val = new QuickFix.Fields.TradeOriginationDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TradeOriginationDate val) { this.TradeOriginationDate = val; }

        public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TradeOriginationDate val) { return IsSetTradeOriginationDate(); }

        public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

        public QuickFix.Fields.NoStipulations NoStipulations
        {
            get
            {
                var val = new QuickFix.Fields.NoStipulations();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoStipulations val) { this.NoStipulations = val; }

        public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoStipulations val) { return IsSetNoStipulations(); }

        public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }

        public QuickFix.Fields.Side Side
        {
            get
            {
                var val = new QuickFix.Fields.Side();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Side val) { this.Side = val; }

        public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Side val) { return IsSetSide(); }

        public bool IsSetSide() { return IsSetField(Tags.Side); }

        public QuickFix.Fields.QuantityType QuantityType
        {
            get
            {
                var val = new QuickFix.Fields.QuantityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.QuantityType val) { this.QuantityType = val; }

        public QuickFix.Fields.QuantityType Get(QuickFix.Fields.QuantityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.QuantityType val) { return IsSetQuantityType(); }

        public bool IsSetQuantityType() { return IsSetField(Tags.QuantityType); }

        public QuickFix.Fields.OrderQty OrderQty
        {
            get
            {
                var val = new QuickFix.Fields.OrderQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrderQty val) { this.OrderQty = val; }

        public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrderQty val) { return IsSetOrderQty(); }

        public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }

        public QuickFix.Fields.CashOrderQty CashOrderQty
        {
            get
            {
                var val = new QuickFix.Fields.CashOrderQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.CashOrderQty val) { this.CashOrderQty = val; }

        public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.CashOrderQty val) { return IsSetCashOrderQty(); }

        public bool IsSetCashOrderQty() { return IsSetField(Tags.CashOrderQty); }

        public QuickFix.Fields.SettlmntTyp SettlmntTyp
        {
            get
            {
                var val = new QuickFix.Fields.SettlmntTyp();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SettlmntTyp val) { this.SettlmntTyp = val; }

        public QuickFix.Fields.SettlmntTyp Get(QuickFix.Fields.SettlmntTyp val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SettlmntTyp val) { return IsSetSettlmntTyp(); }

        public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

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

        public QuickFix.Fields.ExpireTime ExpireTime
        {
            get
            {
                var val = new QuickFix.Fields.ExpireTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ExpireTime val) { this.ExpireTime = val; }

        public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ExpireTime val) { return IsSetExpireTime(); }

        public bool IsSetExpireTime() { return IsSetField(Tags.ExpireTime); }

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

        public QuickFix.Fields.Spread Spread
        {
            get
            {
                var val = new QuickFix.Fields.Spread();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Spread val) { this.Spread = val; }

        public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Spread val) { return IsSetSpread(); }

        public bool IsSetSpread() { return IsSetField(Tags.Spread); }

        public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkCurveCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) { this.BenchmarkCurveCurrency = val; }

        public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }

        public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }

        public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkCurveName();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkCurveName val) { this.BenchmarkCurveName = val; }

        public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }

        public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }

        public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
        {
            get
            {
                var val = new QuickFix.Fields.BenchmarkCurvePoint();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.BenchmarkCurvePoint val) { this.BenchmarkCurvePoint = val; }

        public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }

        public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }

        public QuickFix.Fields.PriceType PriceType
        {
            get
            {
                var val = new QuickFix.Fields.PriceType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.PriceType val) { this.PriceType = val; }

        public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.PriceType val) { return IsSetPriceType(); }

        public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

        public QuickFix.Fields.Price Price
        {
            get
            {
                var val = new QuickFix.Fields.Price();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Price val) { this.Price = val; }

        public QuickFix.Fields.Price Get(QuickFix.Fields.Price val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Price val) { return IsSetPrice(); }

        public bool IsSetPrice() { return IsSetField(Tags.Price); }

        public QuickFix.Fields.Price2 Price2
        {
            get
            {
                var val = new QuickFix.Fields.Price2();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Price2 val) { this.Price2 = val; }

        public QuickFix.Fields.Price2 Get(QuickFix.Fields.Price2 val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Price2 val) { return IsSetPrice2(); }

        public bool IsSetPrice2() { return IsSetField(Tags.Price2); }

        public QuickFix.Fields.YieldType YieldType
        {
            get
            {
                var val = new QuickFix.Fields.YieldType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.YieldType val) { this.YieldType = val; }

        public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.YieldType val) { return IsSetYieldType(); }

        public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }

        public QuickFix.Fields.Yield Yield
        {
            get
            {
                var val = new QuickFix.Fields.Yield();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Yield val) { this.Yield = val; }

        public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Yield val) { return IsSetYield(); }

        public bool IsSetYield() { return IsSetField(Tags.Yield); }


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
        public class NoStipulationsGroup : Group
        {
            public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

            public NoStipulationsGroup() : base(Tags.NoStipulations, Tags.StipulationType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoStipulationsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.StipulationType StipulationType
        {
            get
            {
                var val = new QuickFix.Fields.StipulationType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StipulationType val) { this.StipulationType = val; }

        public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StipulationType val) { return IsSetStipulationType(); }

        public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }

        public QuickFix.Fields.StipulationValue StipulationValue
        {
            get
            {
                var val = new QuickFix.Fields.StipulationValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.StipulationValue val) { this.StipulationValue = val; }

        public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.StipulationValue val) { return IsSetStipulationValue(); }

        public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }


        }
        }


    }
}
