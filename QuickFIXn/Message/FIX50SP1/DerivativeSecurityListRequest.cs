using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class DerivativeSecurityListRequest : Message
    {
        public const string MsgType = "z";

        public DerivativeSecurityListRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public DerivativeSecurityListRequest(QuickFix.Fields.SecurityReqID aSecurityReqID,
				QuickFix.Fields.SecurityListRequestType aSecurityListRequestType)
               : this()
        {
            this.SecurityReqID = aSecurityReqID;
			this.SecurityListRequestType = aSecurityListRequestType;
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

        public QuickFix.Fields.SecurityListRequestType SecurityListRequestType
        {
            get
            {
                var val = new QuickFix.Fields.SecurityListRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecurityListRequestType val) { this.SecurityListRequestType = val; }

        public QuickFix.Fields.SecurityListRequestType Get(QuickFix.Fields.SecurityListRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecurityListRequestType val) { return IsSetSecurityListRequestType(); }

        public bool IsSetSecurityListRequestType() { return IsSetField(Tags.SecurityListRequestType); }

        public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSymbol val) { this.UnderlyingSymbol = val; }

        public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }

        public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }

        public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) { this.UnderlyingSymbolSfx = val; }

        public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }

        public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }

        public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityID val) { this.UnderlyingSecurityID = val; }

        public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }

        public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }

        public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) { this.UnderlyingSecurityIDSource = val; }

        public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }

        public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }

        public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) { this.NoUnderlyingSecurityAltID = val; }

        public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }

        public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }

        public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingProduct val) { this.UnderlyingProduct = val; }

        public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingProduct val) { return IsSetUnderlyingProduct(); }

        public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }

        public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCFICode val) { this.UnderlyingCFICode = val; }

        public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }

        public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }

        public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityType val) { this.UnderlyingSecurityType = val; }

        public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }

        public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }

        public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) { this.UnderlyingSecuritySubType = val; }

        public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }

        public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }

        public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) { this.UnderlyingMaturityMonthYear = val; }

        public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }

        public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }

        public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingMaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingMaturityDate val) { this.UnderlyingMaturityDate = val; }

        public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }

        public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }

        public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) { this.UnderlyingCouponPaymentDate = val; }

        public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }

        public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }

        public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingIssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingIssueDate val) { this.UnderlyingIssueDate = val; }

        public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }

        public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }

        public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) { this.UnderlyingRepoCollateralSecurityType = val; }

        public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }

        public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }

        public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) { this.UnderlyingRepurchaseTerm = val; }

        public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }

        public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }

        public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) { this.UnderlyingRepurchaseRate = val; }

        public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }

        public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }

        public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFactor();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFactor val) { this.UnderlyingFactor = val; }

        public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFactor val) { return IsSetUnderlyingFactor(); }

        public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }

        public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCreditRating();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCreditRating val) { this.UnderlyingCreditRating = val; }

        public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }

        public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }

        public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingInstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) { this.UnderlyingInstrRegistry = val; }

        public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }

        public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }

        public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) { this.UnderlyingCountryOfIssue = val; }

        public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }

        public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }

        public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) { this.UnderlyingStateOrProvinceOfIssue = val; }

        public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }

        public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }

        public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) { this.UnderlyingLocaleOfIssue = val; }

        public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }

        public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }

        public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingRedemptionDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) { this.UnderlyingRedemptionDate = val; }

        public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }

        public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }

        public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStrikePrice val) { this.UnderlyingStrikePrice = val; }

        public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }

        public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }

        public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) { this.UnderlyingStrikeCurrency = val; }

        public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }

        public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }

        public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingOptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingOptAttribute val) { this.UnderlyingOptAttribute = val; }

        public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }

        public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }

        public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) { this.UnderlyingContractMultiplier = val; }

        public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }

        public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }

        public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCouponRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCouponRate val) { this.UnderlyingCouponRate = val; }

        public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }

        public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }

        public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) { this.UnderlyingSecurityExchange = val; }

        public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }

        public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }

        public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingIssuer val) { this.UnderlyingIssuer = val; }

        public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }

        public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }

        public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) { this.EncodedUnderlyingIssuerLen = val; }

        public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }

        public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }

        public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) { this.EncodedUnderlyingIssuer = val; }

        public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }

        public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }

        public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) { this.UnderlyingSecurityDesc = val; }

        public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }

        public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }

        public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) { this.EncodedUnderlyingSecurityDescLen = val; }

        public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }

        public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }

        public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) { this.EncodedUnderlyingSecurityDesc = val; }

        public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }

        public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }

        public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCPProgram();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCPProgram val) { this.UnderlyingCPProgram = val; }

        public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }

        public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }

        public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCPRegType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCPRegType val) { this.UnderlyingCPRegType = val; }

        public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }

        public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }

        public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCurrency val) { this.UnderlyingCurrency = val; }

        public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }

        public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }

        public QuickFix.Fields.UnderlyingQty UnderlyingQty
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingQty val) { this.UnderlyingQty = val; }

        public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingQty val) { return IsSetUnderlyingQty(); }

        public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }

        public QuickFix.Fields.UnderlyingPx UnderlyingPx
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPx val) { this.UnderlyingPx = val; }

        public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPx val) { return IsSetUnderlyingPx(); }

        public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }

        public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingDirtyPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) { this.UnderlyingDirtyPrice = val; }

        public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }

        public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }

        public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingEndPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingEndPrice val) { this.UnderlyingEndPrice = val; }

        public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }

        public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }

        public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStartValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStartValue val) { this.UnderlyingStartValue = val; }

        public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }

        public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }

        public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCurrentValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCurrentValue val) { this.UnderlyingCurrentValue = val; }

        public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }

        public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }

        public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingEndValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingEndValue val) { this.UnderlyingEndValue = val; }

        public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }

        public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }

        public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
        {
            get
            {
                var val = new QuickFix.Fields.NoUnderlyingStips();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUnderlyingStips val) { this.NoUnderlyingStips = val; }

        public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }

        public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

        public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingAllocationPercent();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) { this.UnderlyingAllocationPercent = val; }

        public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) { return IsSetUnderlyingAllocationPercent(); }

        public bool IsSetUnderlyingAllocationPercent() { return IsSetField(Tags.UnderlyingAllocationPercent); }

        public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSettlementType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSettlementType val) { this.UnderlyingSettlementType = val; }

        public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) { return IsSetUnderlyingSettlementType(); }

        public bool IsSetUnderlyingSettlementType() { return IsSetField(Tags.UnderlyingSettlementType); }

        public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCashAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCashAmount val) { this.UnderlyingCashAmount = val; }

        public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) { return IsSetUnderlyingCashAmount(); }

        public bool IsSetUnderlyingCashAmount() { return IsSetField(Tags.UnderlyingCashAmount); }

        public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCashType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCashType val) { this.UnderlyingCashType = val; }

        public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCashType val) { return IsSetUnderlyingCashType(); }

        public bool IsSetUnderlyingCashType() { return IsSetField(Tags.UnderlyingCashType); }

        public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) { this.UnderlyingUnitOfMeasure = val; }

        public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) { return IsSetUnderlyingUnitOfMeasure(); }

        public bool IsSetUnderlyingUnitOfMeasure() { return IsSetField(Tags.UnderlyingUnitOfMeasure); }

        public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingTimeUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingTimeUnit val) { this.UnderlyingTimeUnit = val; }

        public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) { return IsSetUnderlyingTimeUnit(); }

        public bool IsSetUnderlyingTimeUnit() { return IsSetField(Tags.UnderlyingTimeUnit); }

        public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingCapValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingCapValue val) { this.UnderlyingCapValue = val; }

        public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) { return IsSetUnderlyingCapValue(); }

        public bool IsSetUnderlyingCapValue() { return IsSetField(Tags.UnderlyingCapValue); }

        public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
        {
            get
            {
                var val = new QuickFix.Fields.NoUndlyInstrumentParties();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) { this.NoUndlyInstrumentParties = val; }

        public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) { return IsSetNoUndlyInstrumentParties(); }

        public bool IsSetNoUndlyInstrumentParties() { return IsSetField(Tags.NoUndlyInstrumentParties); }

        public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSettlMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSettlMethod val) { this.UnderlyingSettlMethod = val; }

        public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) { return IsSetUnderlyingSettlMethod(); }

        public bool IsSetUnderlyingSettlMethod() { return IsSetField(Tags.UnderlyingSettlMethod); }

        public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) { this.UnderlyingAdjustedQuantity = val; }

        public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) { return IsSetUnderlyingAdjustedQuantity(); }

        public bool IsSetUnderlyingAdjustedQuantity() { return IsSetField(Tags.UnderlyingAdjustedQuantity); }

        public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFXRate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFXRate val) { this.UnderlyingFXRate = val; }

        public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) { return IsSetUnderlyingFXRate(); }

        public bool IsSetUnderlyingFXRate() { return IsSetField(Tags.UnderlyingFXRate); }

        public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingFXRateCalc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) { this.UnderlyingFXRateCalc = val; }

        public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) { return IsSetUnderlyingFXRateCalc(); }

        public bool IsSetUnderlyingFXRateCalc() { return IsSetField(Tags.UnderlyingFXRateCalc); }

        public QuickFix.Fields.UnderlyingMaturityTime UnderlyingMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingMaturityTime val) { this.UnderlyingMaturityTime = val; }

        public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) { return IsSetUnderlyingMaturityTime(); }

        public bool IsSetUnderlyingMaturityTime() { return IsSetField(Tags.UnderlyingMaturityTime); }

        public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPutOrCall val) { this.UnderlyingPutOrCall = val; }

        public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }

        public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }

        public QuickFix.Fields.UnderlyingExerciseStyle UnderlyingExerciseStyle
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingExerciseStyle();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) { this.UnderlyingExerciseStyle = val; }

        public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) { return IsSetUnderlyingExerciseStyle(); }

        public bool IsSetUnderlyingExerciseStyle() { return IsSetField(Tags.UnderlyingExerciseStyle); }

        public QuickFix.Fields.UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) { this.UnderlyingUnitOfMeasureQty = val; }

        public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) { return IsSetUnderlyingUnitOfMeasureQty(); }

        public bool IsSetUnderlyingUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingUnitOfMeasureQty); }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) { this.UnderlyingPriceUnitOfMeasure = val; }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) { return IsSetUnderlyingPriceUnitOfMeasure(); }

        public bool IsSetUnderlyingPriceUnitOfMeasure() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasure); }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) { this.UnderlyingPriceUnitOfMeasureQty = val; }

        public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) { return IsSetUnderlyingPriceUnitOfMeasureQty(); }

        public bool IsSetUnderlyingPriceUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty); }

        public QuickFix.Fields.SecuritySubType SecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.SecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SecuritySubType val) { this.SecuritySubType = val; }

        public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SecuritySubType val) { return IsSetSecuritySubType(); }

        public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }

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

        public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
        {
            get
            {
                var val = new QuickFix.Fields.SubscriptionRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.SubscriptionRequestType val) { this.SubscriptionRequestType = val; }

        public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }

        public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

        public QuickFix.Fields.MarketID MarketID
        {
            get
            {
                var val = new QuickFix.Fields.MarketID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketID val) { this.MarketID = val; }

        public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketID val) { return IsSetMarketID(); }

        public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

        public QuickFix.Fields.MarketSegmentID MarketSegmentID
        {
            get
            {
                var val = new QuickFix.Fields.MarketSegmentID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MarketSegmentID val) { this.MarketSegmentID = val; }

        public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MarketSegmentID val) { return IsSetMarketSegmentID(); }

        public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

        public QuickFix.Fields.DerivativeSymbol DerivativeSymbol
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSymbol();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSymbol val) { this.DerivativeSymbol = val; }

        public QuickFix.Fields.DerivativeSymbol Get(QuickFix.Fields.DerivativeSymbol val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSymbol val) { return IsSetDerivativeSymbol(); }

        public bool IsSetDerivativeSymbol() { return IsSetField(Tags.DerivativeSymbol); }

        public QuickFix.Fields.DerivativeSymbolSfx DerivativeSymbolSfx
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSymbolSfx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSymbolSfx val) { this.DerivativeSymbolSfx = val; }

        public QuickFix.Fields.DerivativeSymbolSfx Get(QuickFix.Fields.DerivativeSymbolSfx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSymbolSfx val) { return IsSetDerivativeSymbolSfx(); }

        public bool IsSetDerivativeSymbolSfx() { return IsSetField(Tags.DerivativeSymbolSfx); }

        public QuickFix.Fields.DerivativeSecurityID DerivativeSecurityID
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityID val) { this.DerivativeSecurityID = val; }

        public QuickFix.Fields.DerivativeSecurityID Get(QuickFix.Fields.DerivativeSecurityID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityID val) { return IsSetDerivativeSecurityID(); }

        public bool IsSetDerivativeSecurityID() { return IsSetField(Tags.DerivativeSecurityID); }

        public QuickFix.Fields.DerivativeSecurityIDSource DerivativeSecurityIDSource
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityIDSource val) { this.DerivativeSecurityIDSource = val; }

        public QuickFix.Fields.DerivativeSecurityIDSource Get(QuickFix.Fields.DerivativeSecurityIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityIDSource val) { return IsSetDerivativeSecurityIDSource(); }

        public bool IsSetDerivativeSecurityIDSource() { return IsSetField(Tags.DerivativeSecurityIDSource); }

        public QuickFix.Fields.NoDerivativeSecurityAltID NoDerivativeSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.NoDerivativeSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoDerivativeSecurityAltID val) { this.NoDerivativeSecurityAltID = val; }

        public QuickFix.Fields.NoDerivativeSecurityAltID Get(QuickFix.Fields.NoDerivativeSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoDerivativeSecurityAltID val) { return IsSetNoDerivativeSecurityAltID(); }

        public bool IsSetNoDerivativeSecurityAltID() { return IsSetField(Tags.NoDerivativeSecurityAltID); }

        public QuickFix.Fields.DerivativeProduct DerivativeProduct
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeProduct();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeProduct val) { this.DerivativeProduct = val; }

        public QuickFix.Fields.DerivativeProduct Get(QuickFix.Fields.DerivativeProduct val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeProduct val) { return IsSetDerivativeProduct(); }

        public bool IsSetDerivativeProduct() { return IsSetField(Tags.DerivativeProduct); }

        public QuickFix.Fields.DerivativeProductComplex DerivativeProductComplex
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeProductComplex();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeProductComplex val) { this.DerivativeProductComplex = val; }

        public QuickFix.Fields.DerivativeProductComplex Get(QuickFix.Fields.DerivativeProductComplex val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeProductComplex val) { return IsSetDerivativeProductComplex(); }

        public bool IsSetDerivativeProductComplex() { return IsSetField(Tags.DerivativeProductComplex); }

        public QuickFix.Fields.DerivFlexProductEligibilityIndicator DerivFlexProductEligibilityIndicator
        {
            get
            {
                var val = new QuickFix.Fields.DerivFlexProductEligibilityIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) { this.DerivFlexProductEligibilityIndicator = val; }

        public QuickFix.Fields.DerivFlexProductEligibilityIndicator Get(QuickFix.Fields.DerivFlexProductEligibilityIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) { return IsSetDerivFlexProductEligibilityIndicator(); }

        public bool IsSetDerivFlexProductEligibilityIndicator() { return IsSetField(Tags.DerivFlexProductEligibilityIndicator); }

        public QuickFix.Fields.DerivativeSecurityGroup DerivativeSecurityGroup
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityGroup();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityGroup val) { this.DerivativeSecurityGroup = val; }

        public QuickFix.Fields.DerivativeSecurityGroup Get(QuickFix.Fields.DerivativeSecurityGroup val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityGroup val) { return IsSetDerivativeSecurityGroup(); }

        public bool IsSetDerivativeSecurityGroup() { return IsSetField(Tags.DerivativeSecurityGroup); }

        public QuickFix.Fields.DerivativeCFICode DerivativeCFICode
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeCFICode();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeCFICode val) { this.DerivativeCFICode = val; }

        public QuickFix.Fields.DerivativeCFICode Get(QuickFix.Fields.DerivativeCFICode val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeCFICode val) { return IsSetDerivativeCFICode(); }

        public bool IsSetDerivativeCFICode() { return IsSetField(Tags.DerivativeCFICode); }

        public QuickFix.Fields.DerivativeSecurityType DerivativeSecurityType
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityType val) { this.DerivativeSecurityType = val; }

        public QuickFix.Fields.DerivativeSecurityType Get(QuickFix.Fields.DerivativeSecurityType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityType val) { return IsSetDerivativeSecurityType(); }

        public bool IsSetDerivativeSecurityType() { return IsSetField(Tags.DerivativeSecurityType); }

        public QuickFix.Fields.DerivativeSecuritySubType DerivativeSecuritySubType
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecuritySubType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecuritySubType val) { this.DerivativeSecuritySubType = val; }

        public QuickFix.Fields.DerivativeSecuritySubType Get(QuickFix.Fields.DerivativeSecuritySubType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecuritySubType val) { return IsSetDerivativeSecuritySubType(); }

        public bool IsSetDerivativeSecuritySubType() { return IsSetField(Tags.DerivativeSecuritySubType); }

        public QuickFix.Fields.DerivativeMaturityMonthYear DerivativeMaturityMonthYear
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeMaturityMonthYear();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeMaturityMonthYear val) { this.DerivativeMaturityMonthYear = val; }

        public QuickFix.Fields.DerivativeMaturityMonthYear Get(QuickFix.Fields.DerivativeMaturityMonthYear val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeMaturityMonthYear val) { return IsSetDerivativeMaturityMonthYear(); }

        public bool IsSetDerivativeMaturityMonthYear() { return IsSetField(Tags.DerivativeMaturityMonthYear); }

        public QuickFix.Fields.DerivativeMaturityDate DerivativeMaturityDate
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeMaturityDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeMaturityDate val) { this.DerivativeMaturityDate = val; }

        public QuickFix.Fields.DerivativeMaturityDate Get(QuickFix.Fields.DerivativeMaturityDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeMaturityDate val) { return IsSetDerivativeMaturityDate(); }

        public bool IsSetDerivativeMaturityDate() { return IsSetField(Tags.DerivativeMaturityDate); }

        public QuickFix.Fields.DerivativeMaturityTime DerivativeMaturityTime
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeMaturityTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeMaturityTime val) { this.DerivativeMaturityTime = val; }

        public QuickFix.Fields.DerivativeMaturityTime Get(QuickFix.Fields.DerivativeMaturityTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeMaturityTime val) { return IsSetDerivativeMaturityTime(); }

        public bool IsSetDerivativeMaturityTime() { return IsSetField(Tags.DerivativeMaturityTime); }

        public QuickFix.Fields.DerivativeSettleOnOpenFlag DerivativeSettleOnOpenFlag
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSettleOnOpenFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSettleOnOpenFlag val) { this.DerivativeSettleOnOpenFlag = val; }

        public QuickFix.Fields.DerivativeSettleOnOpenFlag Get(QuickFix.Fields.DerivativeSettleOnOpenFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSettleOnOpenFlag val) { return IsSetDerivativeSettleOnOpenFlag(); }

        public bool IsSetDerivativeSettleOnOpenFlag() { return IsSetField(Tags.DerivativeSettleOnOpenFlag); }

        public QuickFix.Fields.DerivativeInstrmtAssignmentMethod DerivativeInstrmtAssignmentMethod
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrmtAssignmentMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) { this.DerivativeInstrmtAssignmentMethod = val; }

        public QuickFix.Fields.DerivativeInstrmtAssignmentMethod Get(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) { return IsSetDerivativeInstrmtAssignmentMethod(); }

        public bool IsSetDerivativeInstrmtAssignmentMethod() { return IsSetField(Tags.DerivativeInstrmtAssignmentMethod); }

        public QuickFix.Fields.DerivativeSecurityStatus DerivativeSecurityStatus
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityStatus();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityStatus val) { this.DerivativeSecurityStatus = val; }

        public QuickFix.Fields.DerivativeSecurityStatus Get(QuickFix.Fields.DerivativeSecurityStatus val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityStatus val) { return IsSetDerivativeSecurityStatus(); }

        public bool IsSetDerivativeSecurityStatus() { return IsSetField(Tags.DerivativeSecurityStatus); }

        public QuickFix.Fields.DerivativeIssueDate DerivativeIssueDate
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeIssueDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeIssueDate val) { this.DerivativeIssueDate = val; }

        public QuickFix.Fields.DerivativeIssueDate Get(QuickFix.Fields.DerivativeIssueDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeIssueDate val) { return IsSetDerivativeIssueDate(); }

        public bool IsSetDerivativeIssueDate() { return IsSetField(Tags.DerivativeIssueDate); }

        public QuickFix.Fields.DerivativeInstrRegistry DerivativeInstrRegistry
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrRegistry();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrRegistry val) { this.DerivativeInstrRegistry = val; }

        public QuickFix.Fields.DerivativeInstrRegistry Get(QuickFix.Fields.DerivativeInstrRegistry val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrRegistry val) { return IsSetDerivativeInstrRegistry(); }

        public bool IsSetDerivativeInstrRegistry() { return IsSetField(Tags.DerivativeInstrRegistry); }

        public QuickFix.Fields.DerivativeCountryOfIssue DerivativeCountryOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeCountryOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeCountryOfIssue val) { this.DerivativeCountryOfIssue = val; }

        public QuickFix.Fields.DerivativeCountryOfIssue Get(QuickFix.Fields.DerivativeCountryOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeCountryOfIssue val) { return IsSetDerivativeCountryOfIssue(); }

        public bool IsSetDerivativeCountryOfIssue() { return IsSetField(Tags.DerivativeCountryOfIssue); }

        public QuickFix.Fields.DerivativeStateOrProvinceOfIssue DerivativeStateOrProvinceOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeStateOrProvinceOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) { this.DerivativeStateOrProvinceOfIssue = val; }

        public QuickFix.Fields.DerivativeStateOrProvinceOfIssue Get(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) { return IsSetDerivativeStateOrProvinceOfIssue(); }

        public bool IsSetDerivativeStateOrProvinceOfIssue() { return IsSetField(Tags.DerivativeStateOrProvinceOfIssue); }

        public QuickFix.Fields.DerivativeStrikePrice DerivativeStrikePrice
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeStrikePrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeStrikePrice val) { this.DerivativeStrikePrice = val; }

        public QuickFix.Fields.DerivativeStrikePrice Get(QuickFix.Fields.DerivativeStrikePrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeStrikePrice val) { return IsSetDerivativeStrikePrice(); }

        public bool IsSetDerivativeStrikePrice() { return IsSetField(Tags.DerivativeStrikePrice); }

        public QuickFix.Fields.DerivativeLocaleOfIssue DerivativeLocaleOfIssue
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeLocaleOfIssue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeLocaleOfIssue val) { this.DerivativeLocaleOfIssue = val; }

        public QuickFix.Fields.DerivativeLocaleOfIssue Get(QuickFix.Fields.DerivativeLocaleOfIssue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeLocaleOfIssue val) { return IsSetDerivativeLocaleOfIssue(); }

        public bool IsSetDerivativeLocaleOfIssue() { return IsSetField(Tags.DerivativeLocaleOfIssue); }

        public QuickFix.Fields.DerivativeStrikeCurrency DerivativeStrikeCurrency
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeStrikeCurrency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeStrikeCurrency val) { this.DerivativeStrikeCurrency = val; }

        public QuickFix.Fields.DerivativeStrikeCurrency Get(QuickFix.Fields.DerivativeStrikeCurrency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeStrikeCurrency val) { return IsSetDerivativeStrikeCurrency(); }

        public bool IsSetDerivativeStrikeCurrency() { return IsSetField(Tags.DerivativeStrikeCurrency); }

        public QuickFix.Fields.DerivativeStrikeMultiplier DerivativeStrikeMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeStrikeMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeStrikeMultiplier val) { this.DerivativeStrikeMultiplier = val; }

        public QuickFix.Fields.DerivativeStrikeMultiplier Get(QuickFix.Fields.DerivativeStrikeMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeStrikeMultiplier val) { return IsSetDerivativeStrikeMultiplier(); }

        public bool IsSetDerivativeStrikeMultiplier() { return IsSetField(Tags.DerivativeStrikeMultiplier); }

        public QuickFix.Fields.DerivativeStrikeValue DerivativeStrikeValue
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeStrikeValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeStrikeValue val) { this.DerivativeStrikeValue = val; }

        public QuickFix.Fields.DerivativeStrikeValue Get(QuickFix.Fields.DerivativeStrikeValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeStrikeValue val) { return IsSetDerivativeStrikeValue(); }

        public bool IsSetDerivativeStrikeValue() { return IsSetField(Tags.DerivativeStrikeValue); }

        public QuickFix.Fields.DerivativeOptAttribute DerivativeOptAttribute
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeOptAttribute();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeOptAttribute val) { this.DerivativeOptAttribute = val; }

        public QuickFix.Fields.DerivativeOptAttribute Get(QuickFix.Fields.DerivativeOptAttribute val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeOptAttribute val) { return IsSetDerivativeOptAttribute(); }

        public bool IsSetDerivativeOptAttribute() { return IsSetField(Tags.DerivativeOptAttribute); }

        public QuickFix.Fields.DerivativeContractMultiplier DerivativeContractMultiplier
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeContractMultiplier();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeContractMultiplier val) { this.DerivativeContractMultiplier = val; }

        public QuickFix.Fields.DerivativeContractMultiplier Get(QuickFix.Fields.DerivativeContractMultiplier val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeContractMultiplier val) { return IsSetDerivativeContractMultiplier(); }

        public bool IsSetDerivativeContractMultiplier() { return IsSetField(Tags.DerivativeContractMultiplier); }

        public QuickFix.Fields.DerivativeMinPriceIncrement DerivativeMinPriceIncrement
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeMinPriceIncrement();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeMinPriceIncrement val) { this.DerivativeMinPriceIncrement = val; }

        public QuickFix.Fields.DerivativeMinPriceIncrement Get(QuickFix.Fields.DerivativeMinPriceIncrement val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeMinPriceIncrement val) { return IsSetDerivativeMinPriceIncrement(); }

        public bool IsSetDerivativeMinPriceIncrement() { return IsSetField(Tags.DerivativeMinPriceIncrement); }

        public QuickFix.Fields.DerivativeMinPriceIncrementAmount DerivativeMinPriceIncrementAmount
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeMinPriceIncrementAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) { this.DerivativeMinPriceIncrementAmount = val; }

        public QuickFix.Fields.DerivativeMinPriceIncrementAmount Get(QuickFix.Fields.DerivativeMinPriceIncrementAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) { return IsSetDerivativeMinPriceIncrementAmount(); }

        public bool IsSetDerivativeMinPriceIncrementAmount() { return IsSetField(Tags.DerivativeMinPriceIncrementAmount); }

        public QuickFix.Fields.DerivativeUnitOfMeasure DerivativeUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeUnitOfMeasure val) { this.DerivativeUnitOfMeasure = val; }

        public QuickFix.Fields.DerivativeUnitOfMeasure Get(QuickFix.Fields.DerivativeUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeUnitOfMeasure val) { return IsSetDerivativeUnitOfMeasure(); }

        public bool IsSetDerivativeUnitOfMeasure() { return IsSetField(Tags.DerivativeUnitOfMeasure); }

        public QuickFix.Fields.DerivativeUnitOfMeasureQty DerivativeUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeUnitOfMeasureQty val) { this.DerivativeUnitOfMeasureQty = val; }

        public QuickFix.Fields.DerivativeUnitOfMeasureQty Get(QuickFix.Fields.DerivativeUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeUnitOfMeasureQty val) { return IsSetDerivativeUnitOfMeasureQty(); }

        public bool IsSetDerivativeUnitOfMeasureQty() { return IsSetField(Tags.DerivativeUnitOfMeasureQty); }

        public QuickFix.Fields.DerivativePriceUnitOfMeasure DerivativePriceUnitOfMeasure
        {
            get
            {
                var val = new QuickFix.Fields.DerivativePriceUnitOfMeasure();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativePriceUnitOfMeasure val) { this.DerivativePriceUnitOfMeasure = val; }

        public QuickFix.Fields.DerivativePriceUnitOfMeasure Get(QuickFix.Fields.DerivativePriceUnitOfMeasure val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativePriceUnitOfMeasure val) { return IsSetDerivativePriceUnitOfMeasure(); }

        public bool IsSetDerivativePriceUnitOfMeasure() { return IsSetField(Tags.DerivativePriceUnitOfMeasure); }

        public QuickFix.Fields.DerivativePriceUnitOfMeasureQty DerivativePriceUnitOfMeasureQty
        {
            get
            {
                var val = new QuickFix.Fields.DerivativePriceUnitOfMeasureQty();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) { this.DerivativePriceUnitOfMeasureQty = val; }

        public QuickFix.Fields.DerivativePriceUnitOfMeasureQty Get(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) { return IsSetDerivativePriceUnitOfMeasureQty(); }

        public bool IsSetDerivativePriceUnitOfMeasureQty() { return IsSetField(Tags.DerivativePriceUnitOfMeasureQty); }

        public QuickFix.Fields.DerivativeExerciseStyle DerivativeExerciseStyle
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeExerciseStyle();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeExerciseStyle val) { this.DerivativeExerciseStyle = val; }

        public QuickFix.Fields.DerivativeExerciseStyle Get(QuickFix.Fields.DerivativeExerciseStyle val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeExerciseStyle val) { return IsSetDerivativeExerciseStyle(); }

        public bool IsSetDerivativeExerciseStyle() { return IsSetField(Tags.DerivativeExerciseStyle); }

        public QuickFix.Fields.DerivativeOptPayAmount DerivativeOptPayAmount
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeOptPayAmount();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeOptPayAmount val) { this.DerivativeOptPayAmount = val; }

        public QuickFix.Fields.DerivativeOptPayAmount Get(QuickFix.Fields.DerivativeOptPayAmount val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeOptPayAmount val) { return IsSetDerivativeOptPayAmount(); }

        public bool IsSetDerivativeOptPayAmount() { return IsSetField(Tags.DerivativeOptPayAmount); }

        public QuickFix.Fields.DerivativeTimeUnit DerivativeTimeUnit
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeTimeUnit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeTimeUnit val) { this.DerivativeTimeUnit = val; }

        public QuickFix.Fields.DerivativeTimeUnit Get(QuickFix.Fields.DerivativeTimeUnit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeTimeUnit val) { return IsSetDerivativeTimeUnit(); }

        public bool IsSetDerivativeTimeUnit() { return IsSetField(Tags.DerivativeTimeUnit); }

        public QuickFix.Fields.DerivativeSecurityExchange DerivativeSecurityExchange
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityExchange();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityExchange val) { this.DerivativeSecurityExchange = val; }

        public QuickFix.Fields.DerivativeSecurityExchange Get(QuickFix.Fields.DerivativeSecurityExchange val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityExchange val) { return IsSetDerivativeSecurityExchange(); }

        public bool IsSetDerivativeSecurityExchange() { return IsSetField(Tags.DerivativeSecurityExchange); }

        public QuickFix.Fields.DerivativePositionLimit DerivativePositionLimit
        {
            get
            {
                var val = new QuickFix.Fields.DerivativePositionLimit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativePositionLimit val) { this.DerivativePositionLimit = val; }

        public QuickFix.Fields.DerivativePositionLimit Get(QuickFix.Fields.DerivativePositionLimit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativePositionLimit val) { return IsSetDerivativePositionLimit(); }

        public bool IsSetDerivativePositionLimit() { return IsSetField(Tags.DerivativePositionLimit); }

        public QuickFix.Fields.DerivativeNTPositionLimit DerivativeNTPositionLimit
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeNTPositionLimit();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeNTPositionLimit val) { this.DerivativeNTPositionLimit = val; }

        public QuickFix.Fields.DerivativeNTPositionLimit Get(QuickFix.Fields.DerivativeNTPositionLimit val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeNTPositionLimit val) { return IsSetDerivativeNTPositionLimit(); }

        public bool IsSetDerivativeNTPositionLimit() { return IsSetField(Tags.DerivativeNTPositionLimit); }

        public QuickFix.Fields.DerivativeIssuer DerivativeIssuer
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeIssuer val) { this.DerivativeIssuer = val; }

        public QuickFix.Fields.DerivativeIssuer Get(QuickFix.Fields.DerivativeIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeIssuer val) { return IsSetDerivativeIssuer(); }

        public bool IsSetDerivativeIssuer() { return IsSetField(Tags.DerivativeIssuer); }

        public QuickFix.Fields.DerivativeEncodedIssuerLen DerivativeEncodedIssuerLen
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEncodedIssuerLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEncodedIssuerLen val) { this.DerivativeEncodedIssuerLen = val; }

        public QuickFix.Fields.DerivativeEncodedIssuerLen Get(QuickFix.Fields.DerivativeEncodedIssuerLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEncodedIssuerLen val) { return IsSetDerivativeEncodedIssuerLen(); }

        public bool IsSetDerivativeEncodedIssuerLen() { return IsSetField(Tags.DerivativeEncodedIssuerLen); }

        public QuickFix.Fields.DerivativeEncodedIssuer DerivativeEncodedIssuer
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEncodedIssuer();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEncodedIssuer val) { this.DerivativeEncodedIssuer = val; }

        public QuickFix.Fields.DerivativeEncodedIssuer Get(QuickFix.Fields.DerivativeEncodedIssuer val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEncodedIssuer val) { return IsSetDerivativeEncodedIssuer(); }

        public bool IsSetDerivativeEncodedIssuer() { return IsSetField(Tags.DerivativeEncodedIssuer); }

        public QuickFix.Fields.DerivativeSecurityDesc DerivativeSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityDesc val) { this.DerivativeSecurityDesc = val; }

        public QuickFix.Fields.DerivativeSecurityDesc Get(QuickFix.Fields.DerivativeSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityDesc val) { return IsSetDerivativeSecurityDesc(); }

        public bool IsSetDerivativeSecurityDesc() { return IsSetField(Tags.DerivativeSecurityDesc); }

        public QuickFix.Fields.DerivativeEncodedSecurityDescLen DerivativeEncodedSecurityDescLen
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEncodedSecurityDescLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) { this.DerivativeEncodedSecurityDescLen = val; }

        public QuickFix.Fields.DerivativeEncodedSecurityDescLen Get(QuickFix.Fields.DerivativeEncodedSecurityDescLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) { return IsSetDerivativeEncodedSecurityDescLen(); }

        public bool IsSetDerivativeEncodedSecurityDescLen() { return IsSetField(Tags.DerivativeEncodedSecurityDescLen); }

        public QuickFix.Fields.DerivativeEncodedSecurityDesc DerivativeEncodedSecurityDesc
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEncodedSecurityDesc();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEncodedSecurityDesc val) { this.DerivativeEncodedSecurityDesc = val; }

        public QuickFix.Fields.DerivativeEncodedSecurityDesc Get(QuickFix.Fields.DerivativeEncodedSecurityDesc val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEncodedSecurityDesc val) { return IsSetDerivativeEncodedSecurityDesc(); }

        public bool IsSetDerivativeEncodedSecurityDesc() { return IsSetField(Tags.DerivativeEncodedSecurityDesc); }

        public QuickFix.Fields.DerivativeContractSettlMonth DerivativeContractSettlMonth
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeContractSettlMonth();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeContractSettlMonth val) { this.DerivativeContractSettlMonth = val; }

        public QuickFix.Fields.DerivativeContractSettlMonth Get(QuickFix.Fields.DerivativeContractSettlMonth val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeContractSettlMonth val) { return IsSetDerivativeContractSettlMonth(); }

        public bool IsSetDerivativeContractSettlMonth() { return IsSetField(Tags.DerivativeContractSettlMonth); }

        public QuickFix.Fields.NoDerivativeEvents NoDerivativeEvents
        {
            get
            {
                var val = new QuickFix.Fields.NoDerivativeEvents();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoDerivativeEvents val) { this.NoDerivativeEvents = val; }

        public QuickFix.Fields.NoDerivativeEvents Get(QuickFix.Fields.NoDerivativeEvents val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoDerivativeEvents val) { return IsSetNoDerivativeEvents(); }

        public bool IsSetNoDerivativeEvents() { return IsSetField(Tags.NoDerivativeEvents); }

        public QuickFix.Fields.NoDerivativeInstrumentParties NoDerivativeInstrumentParties
        {
            get
            {
                var val = new QuickFix.Fields.NoDerivativeInstrumentParties();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoDerivativeInstrumentParties val) { this.NoDerivativeInstrumentParties = val; }

        public QuickFix.Fields.NoDerivativeInstrumentParties Get(QuickFix.Fields.NoDerivativeInstrumentParties val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoDerivativeInstrumentParties val) { return IsSetNoDerivativeInstrumentParties(); }

        public bool IsSetNoDerivativeInstrumentParties() { return IsSetField(Tags.NoDerivativeInstrumentParties); }

        public QuickFix.Fields.DerivativeSettlMethod DerivativeSettlMethod
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSettlMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSettlMethod val) { this.DerivativeSettlMethod = val; }

        public QuickFix.Fields.DerivativeSettlMethod Get(QuickFix.Fields.DerivativeSettlMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSettlMethod val) { return IsSetDerivativeSettlMethod(); }

        public bool IsSetDerivativeSettlMethod() { return IsSetField(Tags.DerivativeSettlMethod); }

        public QuickFix.Fields.DerivativePriceQuoteMethod DerivativePriceQuoteMethod
        {
            get
            {
                var val = new QuickFix.Fields.DerivativePriceQuoteMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativePriceQuoteMethod val) { this.DerivativePriceQuoteMethod = val; }

        public QuickFix.Fields.DerivativePriceQuoteMethod Get(QuickFix.Fields.DerivativePriceQuoteMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativePriceQuoteMethod val) { return IsSetDerivativePriceQuoteMethod(); }

        public bool IsSetDerivativePriceQuoteMethod() { return IsSetField(Tags.DerivativePriceQuoteMethod); }

        public QuickFix.Fields.DerivativeFuturesValuationMethod DerivativeFuturesValuationMethod
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeFuturesValuationMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeFuturesValuationMethod val) { this.DerivativeFuturesValuationMethod = val; }

        public QuickFix.Fields.DerivativeFuturesValuationMethod Get(QuickFix.Fields.DerivativeFuturesValuationMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeFuturesValuationMethod val) { return IsSetDerivativeFuturesValuationMethod(); }

        public bool IsSetDerivativeFuturesValuationMethod() { return IsSetField(Tags.DerivativeFuturesValuationMethod); }

        public QuickFix.Fields.DerivativeListMethod DerivativeListMethod
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeListMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeListMethod val) { this.DerivativeListMethod = val; }

        public QuickFix.Fields.DerivativeListMethod Get(QuickFix.Fields.DerivativeListMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeListMethod val) { return IsSetDerivativeListMethod(); }

        public bool IsSetDerivativeListMethod() { return IsSetField(Tags.DerivativeListMethod); }

        public QuickFix.Fields.DerivativeCapPrice DerivativeCapPrice
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeCapPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeCapPrice val) { this.DerivativeCapPrice = val; }

        public QuickFix.Fields.DerivativeCapPrice Get(QuickFix.Fields.DerivativeCapPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeCapPrice val) { return IsSetDerivativeCapPrice(); }

        public bool IsSetDerivativeCapPrice() { return IsSetField(Tags.DerivativeCapPrice); }

        public QuickFix.Fields.DerivativeFloorPrice DerivativeFloorPrice
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeFloorPrice();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeFloorPrice val) { this.DerivativeFloorPrice = val; }

        public QuickFix.Fields.DerivativeFloorPrice Get(QuickFix.Fields.DerivativeFloorPrice val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeFloorPrice val) { return IsSetDerivativeFloorPrice(); }

        public bool IsSetDerivativeFloorPrice() { return IsSetField(Tags.DerivativeFloorPrice); }

        public QuickFix.Fields.DerivativePutOrCall DerivativePutOrCall
        {
            get
            {
                var val = new QuickFix.Fields.DerivativePutOrCall();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativePutOrCall val) { this.DerivativePutOrCall = val; }

        public QuickFix.Fields.DerivativePutOrCall Get(QuickFix.Fields.DerivativePutOrCall val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativePutOrCall val) { return IsSetDerivativePutOrCall(); }

        public bool IsSetDerivativePutOrCall() { return IsSetField(Tags.DerivativePutOrCall); }

        public QuickFix.Fields.DerivativeSecurityXMLLen DerivativeSecurityXMLLen
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityXMLLen();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityXMLLen val) { this.DerivativeSecurityXMLLen = val; }

        public QuickFix.Fields.DerivativeSecurityXMLLen Get(QuickFix.Fields.DerivativeSecurityXMLLen val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityXMLLen val) { return IsSetDerivativeSecurityXMLLen(); }

        public bool IsSetDerivativeSecurityXMLLen() { return IsSetField(Tags.DerivativeSecurityXMLLen); }

        public QuickFix.Fields.DerivativeSecurityXML DerivativeSecurityXML
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityXML();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityXML val) { this.DerivativeSecurityXML = val; }

        public QuickFix.Fields.DerivativeSecurityXML Get(QuickFix.Fields.DerivativeSecurityXML val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityXML val) { return IsSetDerivativeSecurityXML(); }

        public bool IsSetDerivativeSecurityXML() { return IsSetField(Tags.DerivativeSecurityXML); }

        public QuickFix.Fields.DerivativeSecurityXMLSchema DerivativeSecurityXMLSchema
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityXMLSchema();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityXMLSchema val) { this.DerivativeSecurityXMLSchema = val; }

        public QuickFix.Fields.DerivativeSecurityXMLSchema Get(QuickFix.Fields.DerivativeSecurityXMLSchema val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityXMLSchema val) { return IsSetDerivativeSecurityXMLSchema(); }

        public bool IsSetDerivativeSecurityXMLSchema() { return IsSetField(Tags.DerivativeSecurityXMLSchema); }


        public class NoUnderlyingSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

            public NoUnderlyingSecurityAltIDGroup() : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) { this.UnderlyingSecurityAltID = val; }

        public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }

        public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }

        public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) { this.UnderlyingSecurityAltIDSource = val; }

        public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }

        public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }


        }


        public class NoUnderlyingStipsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

            public NoUnderlyingStipsGroup() : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUnderlyingStipsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStipType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStipType val) { this.UnderlyingStipType = val; }

        public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStipType val) { return IsSetUnderlyingStipType(); }

        public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }

        public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
        {
            get
            {
                var val = new QuickFix.Fields.UnderlyingStipValue();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UnderlyingStipValue val) { this.UnderlyingStipValue = val; }

        public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }

        public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }


        }


        public class NoUndlyInstrumentPartiesGroup : Group
        {
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

            public NoUndlyInstrumentPartiesGroup() : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UndlyInstrumentPartyID UndlyInstrumentPartyID
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyID val) { this.UndlyInstrumentPartyID = val; }

        public QuickFix.Fields.UndlyInstrumentPartyID Get(QuickFix.Fields.UndlyInstrumentPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyID val) { return IsSetUndlyInstrumentPartyID(); }

        public bool IsSetUndlyInstrumentPartyID() { return IsSetField(Tags.UndlyInstrumentPartyID); }

        public QuickFix.Fields.UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) { this.UndlyInstrumentPartyIDSource = val; }

        public QuickFix.Fields.UndlyInstrumentPartyIDSource Get(QuickFix.Fields.UndlyInstrumentPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) { return IsSetUndlyInstrumentPartyIDSource(); }

        public bool IsSetUndlyInstrumentPartyIDSource() { return IsSetField(Tags.UndlyInstrumentPartyIDSource); }

        public QuickFix.Fields.UndlyInstrumentPartyRole UndlyInstrumentPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartyRole val) { this.UndlyInstrumentPartyRole = val; }

        public QuickFix.Fields.UndlyInstrumentPartyRole Get(QuickFix.Fields.UndlyInstrumentPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartyRole val) { return IsSetUndlyInstrumentPartyRole(); }

        public bool IsSetUndlyInstrumentPartyRole() { return IsSetField(Tags.UndlyInstrumentPartyRole); }

        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) { this.NoUndlyInstrumentPartySubIDs = val; }

        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) { return IsSetNoUndlyInstrumentPartySubIDs(); }

        public bool IsSetNoUndlyInstrumentPartySubIDs() { return IsSetField(Tags.NoUndlyInstrumentPartySubIDs); }


        public class NoUndlyInstrumentPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup() : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.UndlyInstrumentPartySubID UndlyInstrumentPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val) { this.UndlyInstrumentPartySubID = val; }

        public QuickFix.Fields.UndlyInstrumentPartySubID Get(QuickFix.Fields.UndlyInstrumentPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubID val) { return IsSetUndlyInstrumentPartySubID(); }

        public bool IsSetUndlyInstrumentPartySubID() { return IsSetField(Tags.UndlyInstrumentPartySubID); }

        public QuickFix.Fields.UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) { this.UndlyInstrumentPartySubIDType = val; }

        public QuickFix.Fields.UndlyInstrumentPartySubIDType Get(QuickFix.Fields.UndlyInstrumentPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) { return IsSetUndlyInstrumentPartySubIDType(); }

        public bool IsSetUndlyInstrumentPartySubIDType() { return IsSetField(Tags.UndlyInstrumentPartySubIDType); }


        }
        }


        public class NoDerivativeSecurityAltIDGroup : Group
        {
            public static int[] fieldOrder = {Tags.DerivativeSecurityAltID, Tags.DerivativeSecurityAltIDSource, 0};

            public NoDerivativeSecurityAltIDGroup() : base(Tags.NoDerivativeSecurityAltID, Tags.DerivativeSecurityAltID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDerivativeSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.DerivativeSecurityAltID DerivativeSecurityAltID
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityAltID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityAltID val) { this.DerivativeSecurityAltID = val; }

        public QuickFix.Fields.DerivativeSecurityAltID Get(QuickFix.Fields.DerivativeSecurityAltID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityAltID val) { return IsSetDerivativeSecurityAltID(); }

        public bool IsSetDerivativeSecurityAltID() { return IsSetField(Tags.DerivativeSecurityAltID); }

        public QuickFix.Fields.DerivativeSecurityAltIDSource DerivativeSecurityAltIDSource
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeSecurityAltIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeSecurityAltIDSource val) { this.DerivativeSecurityAltIDSource = val; }

        public QuickFix.Fields.DerivativeSecurityAltIDSource Get(QuickFix.Fields.DerivativeSecurityAltIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeSecurityAltIDSource val) { return IsSetDerivativeSecurityAltIDSource(); }

        public bool IsSetDerivativeSecurityAltIDSource() { return IsSetField(Tags.DerivativeSecurityAltIDSource); }


        }


        public class NoDerivativeEventsGroup : Group
        {
            public static int[] fieldOrder = {Tags.DerivativeEventType, Tags.DerivativeEventDate, Tags.DerivativeEventTime, Tags.DerivativeEventPx, Tags.DerivativeEventText, 0};

            public NoDerivativeEventsGroup() : base(Tags.NoDerivativeEvents, Tags.DerivativeEventType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDerivativeEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.DerivativeEventType DerivativeEventType
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEventType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEventType val) { this.DerivativeEventType = val; }

        public QuickFix.Fields.DerivativeEventType Get(QuickFix.Fields.DerivativeEventType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEventType val) { return IsSetDerivativeEventType(); }

        public bool IsSetDerivativeEventType() { return IsSetField(Tags.DerivativeEventType); }

        public QuickFix.Fields.DerivativeEventDate DerivativeEventDate
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEventDate();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEventDate val) { this.DerivativeEventDate = val; }

        public QuickFix.Fields.DerivativeEventDate Get(QuickFix.Fields.DerivativeEventDate val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEventDate val) { return IsSetDerivativeEventDate(); }

        public bool IsSetDerivativeEventDate() { return IsSetField(Tags.DerivativeEventDate); }

        public QuickFix.Fields.DerivativeEventTime DerivativeEventTime
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEventTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEventTime val) { this.DerivativeEventTime = val; }

        public QuickFix.Fields.DerivativeEventTime Get(QuickFix.Fields.DerivativeEventTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEventTime val) { return IsSetDerivativeEventTime(); }

        public bool IsSetDerivativeEventTime() { return IsSetField(Tags.DerivativeEventTime); }

        public QuickFix.Fields.DerivativeEventPx DerivativeEventPx
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEventPx();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEventPx val) { this.DerivativeEventPx = val; }

        public QuickFix.Fields.DerivativeEventPx Get(QuickFix.Fields.DerivativeEventPx val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEventPx val) { return IsSetDerivativeEventPx(); }

        public bool IsSetDerivativeEventPx() { return IsSetField(Tags.DerivativeEventPx); }

        public QuickFix.Fields.DerivativeEventText DerivativeEventText
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeEventText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeEventText val) { this.DerivativeEventText = val; }

        public QuickFix.Fields.DerivativeEventText Get(QuickFix.Fields.DerivativeEventText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeEventText val) { return IsSetDerivativeEventText(); }

        public bool IsSetDerivativeEventText() { return IsSetField(Tags.DerivativeEventText); }


        }


        public class NoDerivativeInstrumentPartiesGroup : Group
        {
            public static int[] fieldOrder = {Tags.DerivativeInstrumentPartyID, Tags.DerivativeInstrumentPartyIDSource, Tags.DerivativeInstrumentPartyRole, Tags.NoDerivativeInstrumentPartySubIDs, 0};

            public NoDerivativeInstrumentPartiesGroup() : base(Tags.NoDerivativeInstrumentParties, Tags.DerivativeInstrumentPartyID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDerivativeInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.DerivativeInstrumentPartyID DerivativeInstrumentPartyID
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrumentPartyID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrumentPartyID val) { this.DerivativeInstrumentPartyID = val; }

        public QuickFix.Fields.DerivativeInstrumentPartyID Get(QuickFix.Fields.DerivativeInstrumentPartyID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyID val) { return IsSetDerivativeInstrumentPartyID(); }

        public bool IsSetDerivativeInstrumentPartyID() { return IsSetField(Tags.DerivativeInstrumentPartyID); }

        public QuickFix.Fields.DerivativeInstrumentPartyIDSource DerivativeInstrumentPartyIDSource
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrumentPartyIDSource();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) { this.DerivativeInstrumentPartyIDSource = val; }

        public QuickFix.Fields.DerivativeInstrumentPartyIDSource Get(QuickFix.Fields.DerivativeInstrumentPartyIDSource val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) { return IsSetDerivativeInstrumentPartyIDSource(); }

        public bool IsSetDerivativeInstrumentPartyIDSource() { return IsSetField(Tags.DerivativeInstrumentPartyIDSource); }

        public QuickFix.Fields.DerivativeInstrumentPartyRole DerivativeInstrumentPartyRole
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrumentPartyRole();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrumentPartyRole val) { this.DerivativeInstrumentPartyRole = val; }

        public QuickFix.Fields.DerivativeInstrumentPartyRole Get(QuickFix.Fields.DerivativeInstrumentPartyRole val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyRole val) { return IsSetDerivativeInstrumentPartyRole(); }

        public bool IsSetDerivativeInstrumentPartyRole() { return IsSetField(Tags.DerivativeInstrumentPartyRole); }

        public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs NoDerivativeInstrumentPartySubIDs
        {
            get
            {
                var val = new QuickFix.Fields.NoDerivativeInstrumentPartySubIDs();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) { this.NoDerivativeInstrumentPartySubIDs = val; }

        public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs Get(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) { return IsSetNoDerivativeInstrumentPartySubIDs(); }

        public bool IsSetNoDerivativeInstrumentPartySubIDs() { return IsSetField(Tags.NoDerivativeInstrumentPartySubIDs); }


        public class NoDerivativeInstrumentPartySubIDsGroup : Group
        {
            public static int[] fieldOrder = {Tags.DerivativeInstrumentPartySubID, Tags.DerivativeInstrumentPartySubIDType, 0};

            public NoDerivativeInstrumentPartySubIDsGroup() : base(Tags.NoDerivativeInstrumentPartySubIDs, Tags.DerivativeInstrumentPartySubID, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDerivativeInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.DerivativeInstrumentPartySubID DerivativeInstrumentPartySubID
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrumentPartySubID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrumentPartySubID val) { this.DerivativeInstrumentPartySubID = val; }

        public QuickFix.Fields.DerivativeInstrumentPartySubID Get(QuickFix.Fields.DerivativeInstrumentPartySubID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartySubID val) { return IsSetDerivativeInstrumentPartySubID(); }

        public bool IsSetDerivativeInstrumentPartySubID() { return IsSetField(Tags.DerivativeInstrumentPartySubID); }

        public QuickFix.Fields.DerivativeInstrumentPartySubIDType DerivativeInstrumentPartySubIDType
        {
            get
            {
                var val = new QuickFix.Fields.DerivativeInstrumentPartySubIDType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) { this.DerivativeInstrumentPartySubIDType = val; }

        public QuickFix.Fields.DerivativeInstrumentPartySubIDType Get(QuickFix.Fields.DerivativeInstrumentPartySubIDType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) { return IsSetDerivativeInstrumentPartySubIDType(); }

        public bool IsSetDerivativeInstrumentPartySubIDType() { return IsSetField(Tags.DerivativeInstrumentPartySubIDType); }


        }
        }


    }
}
