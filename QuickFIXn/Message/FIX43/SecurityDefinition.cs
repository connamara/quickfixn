using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class SecurityDefinition : Message
    {
        public const string MsgType = "d";

        public SecurityDefinition():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public SecurityDefinition(QuickFix.Fields.SecurityReqID aSecurityReqID,
				QuickFix.Fields.SecurityResponseID aSecurityResponseID,
				QuickFix.Fields.SecurityResponseType aSecurityResponseType,
				QuickFix.Fields.Symbol aSymbol)
               : this()
        {
            this.SecurityReqID = aSecurityReqID;
			this.SecurityResponseID = aSecurityResponseID;
			this.SecurityResponseType = aSecurityResponseType;
			this.Symbol = aSymbol;
        }

        public QuickFix.Fields.SecurityReqID SecurityReqID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityReqID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityReqID val) { this.SecurityReqID = val; }

        public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityReqID val) { return IsSetSecurityReqID(); }

        public bool IsSetSecurityReqID() { return IsSetField(Tags.SecurityReqID); }

        public QuickFix.Fields.SecurityResponseID SecurityResponseID
        {
            get
            {
                var val = new QuickFix.Fields.SecurityResponseID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityResponseID val) { this.SecurityResponseID = val; }

        public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityResponseID val) { return IsSetSecurityResponseID(); }

        public bool IsSetSecurityResponseID() { return IsSetField(Tags.SecurityResponseID); }

        public QuickFix.Fields.SecurityResponseType SecurityResponseType
        {
            get
            {
                var val = new QuickFix.Fields.SecurityResponseType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityResponseType val) { this.SecurityResponseType = val; }

        public QuickFix.Fields.SecurityResponseType Get(QuickFix.Fields.SecurityResponseType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityResponseType val) { return IsSetSecurityResponseType(); }

        public bool IsSetSecurityResponseType() { return IsSetField(Tags.SecurityResponseType); }

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

        public QuickFix.Fields.NoLegs NoLegs
        {
            get
            {
                var val = new QuickFix.Fields.NoLegs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoLegs val) { this.NoLegs = val; }

        public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoLegs val) { return IsSetNoLegs(); }

        public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }

        public QuickFix.Fields.RoundLot RoundLot
        {
            get
            {
                var val = new QuickFix.Fields.RoundLot();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RoundLot val) { this.RoundLot = val; }

        public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RoundLot val) { return IsSetRoundLot(); }

        public bool IsSetRoundLot() { return IsSetField(Tags.RoundLot); }

        public QuickFix.Fields.MinTradeVol MinTradeVol
        {
            get
            {
                var val = new QuickFix.Fields.MinTradeVol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MinTradeVol val) { this.MinTradeVol = val; }

        public QuickFix.Fields.MinTradeVol Get(QuickFix.Fields.MinTradeVol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MinTradeVol val) { return IsSetMinTradeVol(); }

        public bool IsSetMinTradeVol() { return IsSetField(Tags.MinTradeVol); }


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


        public class NoLegsGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, 0};

            public NoLegsGroup() : base(Tags.NoLegs, Tags.LegSymbol, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.LegSymbol LegSymbol
        {
            get
            {
                var val = new QuickFix.Fields.LegSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSymbol val) { this.LegSymbol = val; }

        public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSymbol val) { return IsSetLegSymbol(); }

        public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }

        public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.LegSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSymbolSfx val) { this.LegSymbolSfx = val; }

        public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSymbolSfx val) { return IsSetLegSymbolSfx(); }

        public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }

        public QuickFix.Fields.LegSecurityID LegSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityID val) { this.LegSecurityID = val; }

        public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityID val) { return IsSetLegSecurityID(); }

        public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }

        public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityIDSource val) { this.LegSecurityIDSource = val; }

        public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }

        public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }

        public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoLegSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoLegSecurityAltID val) { this.NoLegSecurityAltID = val; }

        public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }

        public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }

        public QuickFix.Fields.LegProduct LegProduct
        {
            get
            {
                var val = new QuickFix.Fields.LegProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegProduct val) { this.LegProduct = val; }

        public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegProduct val) { return IsSetLegProduct(); }

        public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }

        public QuickFix.Fields.LegCFICode LegCFICode
        {
            get
            {
                var val = new QuickFix.Fields.LegCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCFICode val) { this.LegCFICode = val; }

        public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCFICode val) { return IsSetLegCFICode(); }

        public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }

        public QuickFix.Fields.LegSecurityType LegSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityType val) { this.LegSecurityType = val; }

        public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityType val) { return IsSetLegSecurityType(); }

        public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

        public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.LegMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegMaturityMonthYear val) { this.LegMaturityMonthYear = val; }

        public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }

        public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }

        public QuickFix.Fields.LegMaturityDate LegMaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.LegMaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegMaturityDate val) { this.LegMaturityDate = val; }

        public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegMaturityDate val) { return IsSetLegMaturityDate(); }

        public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }

        public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.LegCouponPaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCouponPaymentDate val) { this.LegCouponPaymentDate = val; }

        public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }

        public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }

        public QuickFix.Fields.LegIssueDate LegIssueDate
        {
            get
            {
                var val = new QuickFix.Fields.LegIssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegIssueDate val) { this.LegIssueDate = val; }

        public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegIssueDate val) { return IsSetLegIssueDate(); }

        public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }

        public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) { this.LegRepoCollateralSecurityType = val; }

        public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }

        public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }

        public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
        {
            get
            {
                var val = new QuickFix.Fields.LegRepurchaseTerm();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRepurchaseTerm val) { this.LegRepurchaseTerm = val; }

        public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }

        public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }

        public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
        {
            get
            {
                var val = new QuickFix.Fields.LegRepurchaseRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRepurchaseRate val) { this.LegRepurchaseRate = val; }

        public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }

        public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }

        public QuickFix.Fields.LegFactor LegFactor
        {
            get
            {
                var val = new QuickFix.Fields.LegFactor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegFactor val) { this.LegFactor = val; }

        public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegFactor val) { return IsSetLegFactor(); }

        public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }

        public QuickFix.Fields.LegCreditRating LegCreditRating
        {
            get
            {
                var val = new QuickFix.Fields.LegCreditRating();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCreditRating val) { this.LegCreditRating = val; }

        public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCreditRating val) { return IsSetLegCreditRating(); }

        public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }

        public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.LegInstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegInstrRegistry val) { this.LegInstrRegistry = val; }

        public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegInstrRegistry val) { return IsSetLegInstrRegistry(); }

        public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }

        public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LegCountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCountryOfIssue val) { this.LegCountryOfIssue = val; }

        public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }

        public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }

        public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) { this.LegStateOrProvinceOfIssue = val; }

        public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }

        public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }

        public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.LegLocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegLocaleOfIssue val) { this.LegLocaleOfIssue = val; }

        public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }

        public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }

        public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.LegRedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRedemptionDate val) { this.LegRedemptionDate = val; }

        public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRedemptionDate val) { return IsSetLegRedemptionDate(); }

        public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }

        public QuickFix.Fields.LegStrikePrice LegStrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.LegStrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegStrikePrice val) { this.LegStrikePrice = val; }

        public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegStrikePrice val) { return IsSetLegStrikePrice(); }

        public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }

        public QuickFix.Fields.LegOptAttribute LegOptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.LegOptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegOptAttribute val) { this.LegOptAttribute = val; }

        public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegOptAttribute val) { return IsSetLegOptAttribute(); }

        public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }

        public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.LegContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegContractMultiplier val) { this.LegContractMultiplier = val; }

        public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegContractMultiplier val) { return IsSetLegContractMultiplier(); }

        public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }

        public QuickFix.Fields.LegCouponRate LegCouponRate
        {
            get
            {
                var val = new QuickFix.Fields.LegCouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCouponRate val) { this.LegCouponRate = val; }

        public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCouponRate val) { return IsSetLegCouponRate(); }

        public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }

        public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityExchange val) { this.LegSecurityExchange = val; }

        public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityExchange val) { return IsSetLegSecurityExchange(); }

        public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }

        public QuickFix.Fields.LegIssuer LegIssuer
        {
            get
            {
                var val = new QuickFix.Fields.LegIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegIssuer val) { this.LegIssuer = val; }

        public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegIssuer val) { return IsSetLegIssuer(); }

        public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }

        public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegIssuerLen val) { this.EncodedLegIssuerLen = val; }

        public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }

        public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }

        public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegIssuer val) { this.EncodedLegIssuer = val; }

        public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }

        public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }

        public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityDesc val) { this.LegSecurityDesc = val; }

        public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityDesc val) { return IsSetLegSecurityDesc(); }

        public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }

        public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) { this.EncodedLegSecurityDescLen = val; }

        public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }

        public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }

        public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.EncodedLegSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) { this.EncodedLegSecurityDesc = val; }

        public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }

        public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }

        public QuickFix.Fields.LegRatioQty LegRatioQty
        {
            get
            {
                var val = new QuickFix.Fields.LegRatioQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegRatioQty val) { this.LegRatioQty = val; }

        public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegRatioQty val) { return IsSetLegRatioQty(); }

        public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }

        public QuickFix.Fields.LegSide LegSide
        {
            get
            {
                var val = new QuickFix.Fields.LegSide();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSide val) { this.LegSide = val; }

        public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSide val) { return IsSetLegSide(); }

        public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }

        public QuickFix.Fields.LegCurrency LegCurrency
        {
            get
            {
                var val = new QuickFix.Fields.LegCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegCurrency val) { this.LegCurrency = val; }

        public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegCurrency val) { return IsSetLegCurrency(); }

        public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }


        public class NoLegSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

            public NoLegSecurityAltIDGroup() : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityAltID val) { this.LegSecurityAltID = val; }

        public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityAltID val) { return IsSetLegSecurityAltID(); }

        public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }

        public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.LegSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LegSecurityAltIDSource val) { this.LegSecurityAltIDSource = val; }

        public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }

        public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }


        }
        }


    }
}
