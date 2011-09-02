// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class DerivativeSecurityListRequest : Message
        {
            public const string MsgType = "z";

            public DerivativeSecurityListRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("z"));
            }

            public DerivativeSecurityListRequest(
                    QuickFix.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.Fields.SecurityListRequestType aSecurityListRequestType
                ) : this()
            {
                this.securityReqID = aSecurityReqID;
                this.securityListRequestType = aSecurityListRequestType;
            }

            public QuickFix.Fields.SecurityReqID securityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.securityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID get(QuickFix.Fields.SecurityReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return isSetSecurityReqID();
            }
            
            public bool isSetSecurityReqID() 
            { 
                return isSetField(Tags.SecurityReqID);
            }
            public QuickFix.Fields.SecurityListRequestType securityListRequestType
            { 
                get 
                {
                    QuickFix.Fields.SecurityListRequestType val = new QuickFix.Fields.SecurityListRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityListRequestType val) 
            { 
                this.securityListRequestType = val;
            }
            
            public QuickFix.Fields.SecurityListRequestType get(QuickFix.Fields.SecurityListRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityListRequestType val) 
            { 
                return isSetSecurityListRequestType();
            }
            
            public bool isSetSecurityListRequestType() 
            { 
                return isSetField(Tags.SecurityListRequestType);
            }
            public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                this.underlyingSymbol = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbol get(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                return isSetUnderlyingSymbol();
            }
            
            public bool isSetUnderlyingSymbol() 
            { 
                return isSetField(Tags.UnderlyingSymbol);
            }
            public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                this.underlyingSymbolSfx = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbolSfx get(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                return isSetUnderlyingSymbolSfx();
            }
            
            public bool isSetUnderlyingSymbolSfx() 
            { 
                return isSetField(Tags.UnderlyingSymbolSfx);
            }
            public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                this.underlyingSecurityID = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityID get(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                return isSetUnderlyingSecurityID();
            }
            
            public bool isSetUnderlyingSecurityID() 
            { 
                return isSetField(Tags.UnderlyingSecurityID);
            }
            public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                this.underlyingSecurityIDSource = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityIDSource get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                return isSetUnderlyingSecurityIDSource();
            }
            
            public bool isSetUnderlyingSecurityIDSource() 
            { 
                return isSetField(Tags.UnderlyingSecurityIDSource);
            }
            public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                this.noUnderlyingSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                return isSetNoUnderlyingSecurityAltID();
            }
            
            public bool isSetNoUnderlyingSecurityAltID() 
            { 
                return isSetField(Tags.NoUnderlyingSecurityAltID);
            }
            public QuickFix.Fields.UnderlyingProduct underlyingProduct
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingProduct val) 
            { 
                this.underlyingProduct = val;
            }
            
            public QuickFix.Fields.UnderlyingProduct get(QuickFix.Fields.UnderlyingProduct val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingProduct val) 
            { 
                return isSetUnderlyingProduct();
            }
            
            public bool isSetUnderlyingProduct() 
            { 
                return isSetField(Tags.UnderlyingProduct);
            }
            public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                this.underlyingCFICode = val;
            }
            
            public QuickFix.Fields.UnderlyingCFICode get(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                return isSetUnderlyingCFICode();
            }
            
            public bool isSetUnderlyingCFICode() 
            { 
                return isSetField(Tags.UnderlyingCFICode);
            }
            public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                this.underlyingSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityType get(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                return isSetUnderlyingSecurityType();
            }
            
            public bool isSetUnderlyingSecurityType() 
            { 
                return isSetField(Tags.UnderlyingSecurityType);
            }
            public QuickFix.Fields.UnderlyingSecuritySubType underlyingSecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                this.underlyingSecuritySubType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecuritySubType get(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                return isSetUnderlyingSecuritySubType();
            }
            
            public bool isSetUnderlyingSecuritySubType() 
            { 
                return isSetField(Tags.UnderlyingSecuritySubType);
            }
            public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                this.underlyingMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityMonthYear get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                return isSetUnderlyingMaturityMonthYear();
            }
            
            public bool isSetUnderlyingMaturityMonthYear() 
            { 
                return isSetField(Tags.UnderlyingMaturityMonthYear);
            }
            public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                this.underlyingMaturityDate = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityDate get(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                return isSetUnderlyingMaturityDate();
            }
            
            public bool isSetUnderlyingMaturityDate() 
            { 
                return isSetField(Tags.UnderlyingMaturityDate);
            }
            public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                this.underlyingCouponPaymentDate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponPaymentDate get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                return isSetUnderlyingCouponPaymentDate();
            }
            
            public bool isSetUnderlyingCouponPaymentDate() 
            { 
                return isSetField(Tags.UnderlyingCouponPaymentDate);
            }
            public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                this.underlyingIssueDate = val;
            }
            
            public QuickFix.Fields.UnderlyingIssueDate get(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                return isSetUnderlyingIssueDate();
            }
            
            public bool isSetUnderlyingIssueDate() 
            { 
                return isSetField(Tags.UnderlyingIssueDate);
            }
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                this.underlyingRepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                return isSetUnderlyingRepoCollateralSecurityType();
            }
            
            public bool isSetUnderlyingRepoCollateralSecurityType() 
            { 
                return isSetField(Tags.UnderlyingRepoCollateralSecurityType);
            }
            public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                this.underlyingRepurchaseTerm = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseTerm get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                return isSetUnderlyingRepurchaseTerm();
            }
            
            public bool isSetUnderlyingRepurchaseTerm() 
            { 
                return isSetField(Tags.UnderlyingRepurchaseTerm);
            }
            public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                this.underlyingRepurchaseRate = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseRate get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                return isSetUnderlyingRepurchaseRate();
            }
            
            public bool isSetUnderlyingRepurchaseRate() 
            { 
                return isSetField(Tags.UnderlyingRepurchaseRate);
            }
            public QuickFix.Fields.UnderlyingFactor underlyingFactor
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFactor val) 
            { 
                this.underlyingFactor = val;
            }
            
            public QuickFix.Fields.UnderlyingFactor get(QuickFix.Fields.UnderlyingFactor val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFactor val) 
            { 
                return isSetUnderlyingFactor();
            }
            
            public bool isSetUnderlyingFactor() 
            { 
                return isSetField(Tags.UnderlyingFactor);
            }
            public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                this.underlyingCreditRating = val;
            }
            
            public QuickFix.Fields.UnderlyingCreditRating get(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                return isSetUnderlyingCreditRating();
            }
            
            public bool isSetUnderlyingCreditRating() 
            { 
                return isSetField(Tags.UnderlyingCreditRating);
            }
            public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                this.underlyingInstrRegistry = val;
            }
            
            public QuickFix.Fields.UnderlyingInstrRegistry get(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                return isSetUnderlyingInstrRegistry();
            }
            
            public bool isSetUnderlyingInstrRegistry() 
            { 
                return isSetField(Tags.UnderlyingInstrRegistry);
            }
            public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                this.underlyingCountryOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingCountryOfIssue get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                return isSetUnderlyingCountryOfIssue();
            }
            
            public bool isSetUnderlyingCountryOfIssue() 
            { 
                return isSetField(Tags.UnderlyingCountryOfIssue);
            }
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                this.underlyingStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                return isSetUnderlyingStateOrProvinceOfIssue();
            }
            
            public bool isSetUnderlyingStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.UnderlyingStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                this.underlyingLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingLocaleOfIssue get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                return isSetUnderlyingLocaleOfIssue();
            }
            
            public bool isSetUnderlyingLocaleOfIssue() 
            { 
                return isSetField(Tags.UnderlyingLocaleOfIssue);
            }
            public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                this.underlyingRedemptionDate = val;
            }
            
            public QuickFix.Fields.UnderlyingRedemptionDate get(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                return isSetUnderlyingRedemptionDate();
            }
            
            public bool isSetUnderlyingRedemptionDate() 
            { 
                return isSetField(Tags.UnderlyingRedemptionDate);
            }
            public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                this.underlyingStrikePrice = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikePrice get(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                return isSetUnderlyingStrikePrice();
            }
            
            public bool isSetUnderlyingStrikePrice() 
            { 
                return isSetField(Tags.UnderlyingStrikePrice);
            }
            public QuickFix.Fields.UnderlyingStrikeCurrency underlyingStrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                this.underlyingStrikeCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikeCurrency get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                return isSetUnderlyingStrikeCurrency();
            }
            
            public bool isSetUnderlyingStrikeCurrency() 
            { 
                return isSetField(Tags.UnderlyingStrikeCurrency);
            }
            public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                this.underlyingOptAttribute = val;
            }
            
            public QuickFix.Fields.UnderlyingOptAttribute get(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                return isSetUnderlyingOptAttribute();
            }
            
            public bool isSetUnderlyingOptAttribute() 
            { 
                return isSetField(Tags.UnderlyingOptAttribute);
            }
            public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                this.underlyingContractMultiplier = val;
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplier get(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                return isSetUnderlyingContractMultiplier();
            }
            
            public bool isSetUnderlyingContractMultiplier() 
            { 
                return isSetField(Tags.UnderlyingContractMultiplier);
            }
            public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                this.underlyingCouponRate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponRate get(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                return isSetUnderlyingCouponRate();
            }
            
            public bool isSetUnderlyingCouponRate() 
            { 
                return isSetField(Tags.UnderlyingCouponRate);
            }
            public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                this.underlyingSecurityExchange = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityExchange get(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                return isSetUnderlyingSecurityExchange();
            }
            
            public bool isSetUnderlyingSecurityExchange() 
            { 
                return isSetField(Tags.UnderlyingSecurityExchange);
            }
            public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                this.underlyingIssuer = val;
            }
            
            public QuickFix.Fields.UnderlyingIssuer get(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                return isSetUnderlyingIssuer();
            }
            
            public bool isSetUnderlyingIssuer() 
            { 
                return isSetField(Tags.UnderlyingIssuer);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                this.encodedUnderlyingIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuerLen get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                return isSetEncodedUnderlyingIssuerLen();
            }
            
            public bool isSetEncodedUnderlyingIssuerLen() 
            { 
                return isSetField(Tags.EncodedUnderlyingIssuerLen);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                this.encodedUnderlyingIssuer = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuer get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                return isSetEncodedUnderlyingIssuer();
            }
            
            public bool isSetEncodedUnderlyingIssuer() 
            { 
                return isSetField(Tags.EncodedUnderlyingIssuer);
            }
            public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                this.underlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityDesc get(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                return isSetUnderlyingSecurityDesc();
            }
            
            public bool isSetUnderlyingSecurityDesc() 
            { 
                return isSetField(Tags.UnderlyingSecurityDesc);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                this.encodedUnderlyingSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                return isSetEncodedUnderlyingSecurityDescLen();
            }
            
            public bool isSetEncodedUnderlyingSecurityDescLen() 
            { 
                return isSetField(Tags.EncodedUnderlyingSecurityDescLen);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                this.encodedUnderlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                return isSetEncodedUnderlyingSecurityDesc();
            }
            
            public bool isSetEncodedUnderlyingSecurityDesc() 
            { 
                return isSetField(Tags.EncodedUnderlyingSecurityDesc);
            }
            public QuickFix.Fields.UnderlyingCPProgram underlyingCPProgram
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                this.underlyingCPProgram = val;
            }
            
            public QuickFix.Fields.UnderlyingCPProgram get(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                return isSetUnderlyingCPProgram();
            }
            
            public bool isSetUnderlyingCPProgram() 
            { 
                return isSetField(Tags.UnderlyingCPProgram);
            }
            public QuickFix.Fields.UnderlyingCPRegType underlyingCPRegType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                this.underlyingCPRegType = val;
            }
            
            public QuickFix.Fields.UnderlyingCPRegType get(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                return isSetUnderlyingCPRegType();
            }
            
            public bool isSetUnderlyingCPRegType() 
            { 
                return isSetField(Tags.UnderlyingCPRegType);
            }
            public QuickFix.Fields.UnderlyingCurrency underlyingCurrency
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                this.underlyingCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrency get(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                return isSetUnderlyingCurrency();
            }
            
            public bool isSetUnderlyingCurrency() 
            { 
                return isSetField(Tags.UnderlyingCurrency);
            }
            public QuickFix.Fields.UnderlyingQty underlyingQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingQty val) 
            { 
                this.underlyingQty = val;
            }
            
            public QuickFix.Fields.UnderlyingQty get(QuickFix.Fields.UnderlyingQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingQty val) 
            { 
                return isSetUnderlyingQty();
            }
            
            public bool isSetUnderlyingQty() 
            { 
                return isSetField(Tags.UnderlyingQty);
            }
            public QuickFix.Fields.UnderlyingPx underlyingPx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPx val) 
            { 
                this.underlyingPx = val;
            }
            
            public QuickFix.Fields.UnderlyingPx get(QuickFix.Fields.UnderlyingPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPx val) 
            { 
                return isSetUnderlyingPx();
            }
            
            public bool isSetUnderlyingPx() 
            { 
                return isSetField(Tags.UnderlyingPx);
            }
            public QuickFix.Fields.UnderlyingDirtyPrice underlyingDirtyPrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                this.underlyingDirtyPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingDirtyPrice get(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                return isSetUnderlyingDirtyPrice();
            }
            
            public bool isSetUnderlyingDirtyPrice() 
            { 
                return isSetField(Tags.UnderlyingDirtyPrice);
            }
            public QuickFix.Fields.UnderlyingEndPrice underlyingEndPrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                this.underlyingEndPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingEndPrice get(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                return isSetUnderlyingEndPrice();
            }
            
            public bool isSetUnderlyingEndPrice() 
            { 
                return isSetField(Tags.UnderlyingEndPrice);
            }
            public QuickFix.Fields.UnderlyingStartValue underlyingStartValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                this.underlyingStartValue = val;
            }
            
            public QuickFix.Fields.UnderlyingStartValue get(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                return isSetUnderlyingStartValue();
            }
            
            public bool isSetUnderlyingStartValue() 
            { 
                return isSetField(Tags.UnderlyingStartValue);
            }
            public QuickFix.Fields.UnderlyingCurrentValue underlyingCurrentValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                this.underlyingCurrentValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrentValue get(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                return isSetUnderlyingCurrentValue();
            }
            
            public bool isSetUnderlyingCurrentValue() 
            { 
                return isSetField(Tags.UnderlyingCurrentValue);
            }
            public QuickFix.Fields.UnderlyingEndValue underlyingEndValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                this.underlyingEndValue = val;
            }
            
            public QuickFix.Fields.UnderlyingEndValue get(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                return isSetUnderlyingEndValue();
            }
            
            public bool isSetUnderlyingEndValue() 
            { 
                return isSetField(Tags.UnderlyingEndValue);
            }
            public QuickFix.Fields.NoUnderlyingStips noUnderlyingStips
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                this.noUnderlyingStips = val;
            }
            
            public QuickFix.Fields.NoUnderlyingStips get(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                return isSetNoUnderlyingStips();
            }
            
            public bool isSetNoUnderlyingStips() 
            { 
                return isSetField(Tags.NoUnderlyingStips);
            }
            public QuickFix.Fields.UnderlyingAllocationPercent underlyingAllocationPercent
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                this.underlyingAllocationPercent = val;
            }
            
            public QuickFix.Fields.UnderlyingAllocationPercent get(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                return isSetUnderlyingAllocationPercent();
            }
            
            public bool isSetUnderlyingAllocationPercent() 
            { 
                return isSetField(Tags.UnderlyingAllocationPercent);
            }
            public QuickFix.Fields.UnderlyingSettlementType underlyingSettlementType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                this.underlyingSettlementType = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlementType get(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                return isSetUnderlyingSettlementType();
            }
            
            public bool isSetUnderlyingSettlementType() 
            { 
                return isSetField(Tags.UnderlyingSettlementType);
            }
            public QuickFix.Fields.UnderlyingCashAmount underlyingCashAmount
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                this.underlyingCashAmount = val;
            }
            
            public QuickFix.Fields.UnderlyingCashAmount get(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                return isSetUnderlyingCashAmount();
            }
            
            public bool isSetUnderlyingCashAmount() 
            { 
                return isSetField(Tags.UnderlyingCashAmount);
            }
            public QuickFix.Fields.UnderlyingCashType underlyingCashType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCashType val) 
            { 
                this.underlyingCashType = val;
            }
            
            public QuickFix.Fields.UnderlyingCashType get(QuickFix.Fields.UnderlyingCashType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCashType val) 
            { 
                return isSetUnderlyingCashType();
            }
            
            public bool isSetUnderlyingCashType() 
            { 
                return isSetField(Tags.UnderlyingCashType);
            }
            public QuickFix.Fields.UnderlyingUnitOfMeasure underlyingUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                this.underlyingUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasure get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                return isSetUnderlyingUnitOfMeasure();
            }
            
            public bool isSetUnderlyingUnitOfMeasure() 
            { 
                return isSetField(Tags.UnderlyingUnitOfMeasure);
            }
            public QuickFix.Fields.UnderlyingTimeUnit underlyingTimeUnit
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                this.underlyingTimeUnit = val;
            }
            
            public QuickFix.Fields.UnderlyingTimeUnit get(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                return isSetUnderlyingTimeUnit();
            }
            
            public bool isSetUnderlyingTimeUnit() 
            { 
                return isSetField(Tags.UnderlyingTimeUnit);
            }
            public QuickFix.Fields.UnderlyingCapValue underlyingCapValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                this.underlyingCapValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCapValue get(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                return isSetUnderlyingCapValue();
            }
            
            public bool isSetUnderlyingCapValue() 
            { 
                return isSetField(Tags.UnderlyingCapValue);
            }
            public QuickFix.Fields.NoUndlyInstrumentParties noUndlyInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                this.noUndlyInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoUndlyInstrumentParties get(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                return isSetNoUndlyInstrumentParties();
            }
            
            public bool isSetNoUndlyInstrumentParties() 
            { 
                return isSetField(Tags.NoUndlyInstrumentParties);
            }
            public QuickFix.Fields.UnderlyingSettlMethod underlyingSettlMethod
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                this.underlyingSettlMethod = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlMethod get(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                return isSetUnderlyingSettlMethod();
            }
            
            public bool isSetUnderlyingSettlMethod() 
            { 
                return isSetField(Tags.UnderlyingSettlMethod);
            }
            public QuickFix.Fields.UnderlyingAdjustedQuantity underlyingAdjustedQuantity
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                this.underlyingAdjustedQuantity = val;
            }
            
            public QuickFix.Fields.UnderlyingAdjustedQuantity get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                return isSetUnderlyingAdjustedQuantity();
            }
            
            public bool isSetUnderlyingAdjustedQuantity() 
            { 
                return isSetField(Tags.UnderlyingAdjustedQuantity);
            }
            public QuickFix.Fields.UnderlyingFXRate underlyingFXRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                this.underlyingFXRate = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRate get(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                return isSetUnderlyingFXRate();
            }
            
            public bool isSetUnderlyingFXRate() 
            { 
                return isSetField(Tags.UnderlyingFXRate);
            }
            public QuickFix.Fields.UnderlyingFXRateCalc underlyingFXRateCalc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                this.underlyingFXRateCalc = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRateCalc get(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                return isSetUnderlyingFXRateCalc();
            }
            
            public bool isSetUnderlyingFXRateCalc() 
            { 
                return isSetField(Tags.UnderlyingFXRateCalc);
            }
            public QuickFix.Fields.UnderlyingMaturityTime underlyingMaturityTime
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                this.underlyingMaturityTime = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityTime get(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                return isSetUnderlyingMaturityTime();
            }
            
            public bool isSetUnderlyingMaturityTime() 
            { 
                return isSetField(Tags.UnderlyingMaturityTime);
            }
            public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                this.underlyingPutOrCall = val;
            }
            
            public QuickFix.Fields.UnderlyingPutOrCall get(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                return isSetUnderlyingPutOrCall();
            }
            
            public bool isSetUnderlyingPutOrCall() 
            { 
                return isSetField(Tags.UnderlyingPutOrCall);
            }
            public QuickFix.Fields.UnderlyingExerciseStyle underlyingExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                this.underlyingExerciseStyle = val;
            }
            
            public QuickFix.Fields.UnderlyingExerciseStyle get(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                return isSetUnderlyingExerciseStyle();
            }
            
            public bool isSetUnderlyingExerciseStyle() 
            { 
                return isSetField(Tags.UnderlyingExerciseStyle);
            }
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty underlyingUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                this.underlyingUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                return isSetUnderlyingUnitOfMeasureQty();
            }
            
            public bool isSetUnderlyingUnitOfMeasureQty() 
            { 
                return isSetField(Tags.UnderlyingUnitOfMeasureQty);
            }
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure underlyingPriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                this.underlyingPriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                return isSetUnderlyingPriceUnitOfMeasure();
            }
            
            public bool isSetUnderlyingPriceUnitOfMeasure() 
            { 
                return isSetField(Tags.UnderlyingPriceUnitOfMeasure);
            }
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty underlyingPriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                this.underlyingPriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                return isSetUnderlyingPriceUnitOfMeasureQty();
            }
            
            public bool isSetUnderlyingPriceUnitOfMeasureQty() 
            { 
                return isSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.UnderlyingContractMultiplierUnit underlyingContractMultiplierUnit
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingContractMultiplierUnit val = new QuickFix.Fields.UnderlyingContractMultiplierUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
            { 
                this.underlyingContractMultiplierUnit = val;
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplierUnit get(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
            { 
                return isSetUnderlyingContractMultiplierUnit();
            }
            
            public bool isSetUnderlyingContractMultiplierUnit() 
            { 
                return isSetField(Tags.UnderlyingContractMultiplierUnit);
            }
            public QuickFix.Fields.UnderlyingFlowScheduleType underlyingFlowScheduleType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFlowScheduleType val = new QuickFix.Fields.UnderlyingFlowScheduleType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFlowScheduleType val) 
            { 
                this.underlyingFlowScheduleType = val;
            }
            
            public QuickFix.Fields.UnderlyingFlowScheduleType get(QuickFix.Fields.UnderlyingFlowScheduleType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFlowScheduleType val) 
            { 
                return isSetUnderlyingFlowScheduleType();
            }
            
            public bool isSetUnderlyingFlowScheduleType() 
            { 
                return isSetField(Tags.UnderlyingFlowScheduleType);
            }
            public QuickFix.Fields.UnderlyingRestructuringType underlyingRestructuringType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRestructuringType val = new QuickFix.Fields.UnderlyingRestructuringType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRestructuringType val) 
            { 
                this.underlyingRestructuringType = val;
            }
            
            public QuickFix.Fields.UnderlyingRestructuringType get(QuickFix.Fields.UnderlyingRestructuringType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRestructuringType val) 
            { 
                return isSetUnderlyingRestructuringType();
            }
            
            public bool isSetUnderlyingRestructuringType() 
            { 
                return isSetField(Tags.UnderlyingRestructuringType);
            }
            public QuickFix.Fields.UnderlyingSeniority underlyingSeniority
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSeniority val = new QuickFix.Fields.UnderlyingSeniority();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSeniority val) 
            { 
                this.underlyingSeniority = val;
            }
            
            public QuickFix.Fields.UnderlyingSeniority get(QuickFix.Fields.UnderlyingSeniority val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSeniority val) 
            { 
                return isSetUnderlyingSeniority();
            }
            
            public bool isSetUnderlyingSeniority() 
            { 
                return isSetField(Tags.UnderlyingSeniority);
            }
            public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding underlyingNotionalPercentageOutstanding
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingNotionalPercentageOutstanding();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
            { 
                this.underlyingNotionalPercentageOutstanding = val;
            }
            
            public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding get(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
            { 
                return isSetUnderlyingNotionalPercentageOutstanding();
            }
            
            public bool isSetUnderlyingNotionalPercentageOutstanding() 
            { 
                return isSetField(Tags.UnderlyingNotionalPercentageOutstanding);
            }
            public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding underlyingOriginalNotionalPercentageOutstanding
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
            { 
                this.underlyingOriginalNotionalPercentageOutstanding = val;
            }
            
            public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding get(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
            { 
                return isSetUnderlyingOriginalNotionalPercentageOutstanding();
            }
            
            public bool isSetUnderlyingOriginalNotionalPercentageOutstanding() 
            { 
                return isSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding);
            }
            public QuickFix.Fields.UnderlyingAttachmentPoint underlyingAttachmentPoint
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAttachmentPoint val = new QuickFix.Fields.UnderlyingAttachmentPoint();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingAttachmentPoint val) 
            { 
                this.underlyingAttachmentPoint = val;
            }
            
            public QuickFix.Fields.UnderlyingAttachmentPoint get(QuickFix.Fields.UnderlyingAttachmentPoint val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingAttachmentPoint val) 
            { 
                return isSetUnderlyingAttachmentPoint();
            }
            
            public bool isSetUnderlyingAttachmentPoint() 
            { 
                return isSetField(Tags.UnderlyingAttachmentPoint);
            }
            public QuickFix.Fields.UnderlyingDetachmentPoint underlyingDetachmentPoint
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingDetachmentPoint val = new QuickFix.Fields.UnderlyingDetachmentPoint();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingDetachmentPoint val) 
            { 
                this.underlyingDetachmentPoint = val;
            }
            
            public QuickFix.Fields.UnderlyingDetachmentPoint get(QuickFix.Fields.UnderlyingDetachmentPoint val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingDetachmentPoint val) 
            { 
                return isSetUnderlyingDetachmentPoint();
            }
            
            public bool isSetUnderlyingDetachmentPoint() 
            { 
                return isSetField(Tags.UnderlyingDetachmentPoint);
            }
            public QuickFix.Fields.SecuritySubType securitySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.securitySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType get(QuickFix.Fields.SecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return isSetSecuritySubType();
            }
            
            public bool isSetSecuritySubType() 
            { 
                return isSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.Currency currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Currency val) 
            { 
                this.currency = val;
            }
            
            public QuickFix.Fields.Currency get(QuickFix.Fields.Currency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Currency val) 
            { 
                return isSetCurrency();
            }
            
            public bool isSetCurrency() 
            { 
                return isSetField(Tags.Currency);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Text val) 
            { 
                return isSetText();
            }
            
            public bool isSetText() 
            { 
                return isSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return isSetEncodedTextLen();
            }
            
            public bool isSetEncodedTextLen() 
            { 
                return isSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedText val) 
            { 
                return isSetEncodedText();
            }
            
            public bool isSetEncodedText() 
            { 
                return isSetField(Tags.EncodedText);
            }
            public QuickFix.Fields.TradingSessionID tradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.tradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return isSetTradingSessionID();
            }
            
            public bool isSetTradingSessionID() 
            { 
                return isSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionSubID val) 
            { 
                this.tradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
            { 
                return isSetTradingSessionSubID();
            }
            
            public bool isSetTradingSessionSubID() 
            { 
                return isSetField(Tags.TradingSessionSubID);
            }
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.subscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return isSetSubscriptionRequestType();
            }
            
            public bool isSetSubscriptionRequestType() 
            { 
                return isSetField(Tags.SubscriptionRequestType);
            }
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID get(QuickFix.Fields.MarketID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketID val) 
            { 
                return isSetMarketID();
            }
            
            public bool isSetMarketID() 
            { 
                return isSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID get(QuickFix.Fields.MarketSegmentID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return isSetMarketSegmentID();
            }
            
            public bool isSetMarketSegmentID() 
            { 
                return isSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.DerivativeSymbol derivativeSymbol
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSymbol val = new QuickFix.Fields.DerivativeSymbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSymbol val) 
            { 
                this.derivativeSymbol = val;
            }
            
            public QuickFix.Fields.DerivativeSymbol get(QuickFix.Fields.DerivativeSymbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSymbol val) 
            { 
                return isSetDerivativeSymbol();
            }
            
            public bool isSetDerivativeSymbol() 
            { 
                return isSetField(Tags.DerivativeSymbol);
            }
            public QuickFix.Fields.DerivativeSymbolSfx derivativeSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSymbolSfx val = new QuickFix.Fields.DerivativeSymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                this.derivativeSymbolSfx = val;
            }
            
            public QuickFix.Fields.DerivativeSymbolSfx get(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                return isSetDerivativeSymbolSfx();
            }
            
            public bool isSetDerivativeSymbolSfx() 
            { 
                return isSetField(Tags.DerivativeSymbolSfx);
            }
            public QuickFix.Fields.DerivativeSecurityID derivativeSecurityID
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityID val = new QuickFix.Fields.DerivativeSecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                this.derivativeSecurityID = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityID get(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                return isSetDerivativeSecurityID();
            }
            
            public bool isSetDerivativeSecurityID() 
            { 
                return isSetField(Tags.DerivativeSecurityID);
            }
            public QuickFix.Fields.DerivativeSecurityIDSource derivativeSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityIDSource val = new QuickFix.Fields.DerivativeSecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                this.derivativeSecurityIDSource = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityIDSource get(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                return isSetDerivativeSecurityIDSource();
            }
            
            public bool isSetDerivativeSecurityIDSource() 
            { 
                return isSetField(Tags.DerivativeSecurityIDSource);
            }
            public QuickFix.Fields.NoDerivativeSecurityAltID noDerivativeSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeSecurityAltID val = new QuickFix.Fields.NoDerivativeSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                this.noDerivativeSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoDerivativeSecurityAltID get(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                return isSetNoDerivativeSecurityAltID();
            }
            
            public bool isSetNoDerivativeSecurityAltID() 
            { 
                return isSetField(Tags.NoDerivativeSecurityAltID);
            }
            public QuickFix.Fields.DerivativeProduct derivativeProduct
            { 
                get 
                {
                    QuickFix.Fields.DerivativeProduct val = new QuickFix.Fields.DerivativeProduct();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeProduct val) 
            { 
                this.derivativeProduct = val;
            }
            
            public QuickFix.Fields.DerivativeProduct get(QuickFix.Fields.DerivativeProduct val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeProduct val) 
            { 
                return isSetDerivativeProduct();
            }
            
            public bool isSetDerivativeProduct() 
            { 
                return isSetField(Tags.DerivativeProduct);
            }
            public QuickFix.Fields.DerivativeProductComplex derivativeProductComplex
            { 
                get 
                {
                    QuickFix.Fields.DerivativeProductComplex val = new QuickFix.Fields.DerivativeProductComplex();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                this.derivativeProductComplex = val;
            }
            
            public QuickFix.Fields.DerivativeProductComplex get(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                return isSetDerivativeProductComplex();
            }
            
            public bool isSetDerivativeProductComplex() 
            { 
                return isSetField(Tags.DerivativeProductComplex);
            }
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator derivFlexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.DerivFlexProductEligibilityIndicator val = new QuickFix.Fields.DerivFlexProductEligibilityIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                this.derivFlexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator get(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                return isSetDerivFlexProductEligibilityIndicator();
            }
            
            public bool isSetDerivFlexProductEligibilityIndicator() 
            { 
                return isSetField(Tags.DerivFlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.DerivativeSecurityGroup derivativeSecurityGroup
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityGroup val = new QuickFix.Fields.DerivativeSecurityGroup();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                this.derivativeSecurityGroup = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityGroup get(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                return isSetDerivativeSecurityGroup();
            }
            
            public bool isSetDerivativeSecurityGroup() 
            { 
                return isSetField(Tags.DerivativeSecurityGroup);
            }
            public QuickFix.Fields.DerivativeCFICode derivativeCFICode
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCFICode val = new QuickFix.Fields.DerivativeCFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeCFICode val) 
            { 
                this.derivativeCFICode = val;
            }
            
            public QuickFix.Fields.DerivativeCFICode get(QuickFix.Fields.DerivativeCFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeCFICode val) 
            { 
                return isSetDerivativeCFICode();
            }
            
            public bool isSetDerivativeCFICode() 
            { 
                return isSetField(Tags.DerivativeCFICode);
            }
            public QuickFix.Fields.DerivativeSecurityType derivativeSecurityType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityType val = new QuickFix.Fields.DerivativeSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                this.derivativeSecurityType = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityType get(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                return isSetDerivativeSecurityType();
            }
            
            public bool isSetDerivativeSecurityType() 
            { 
                return isSetField(Tags.DerivativeSecurityType);
            }
            public QuickFix.Fields.DerivativeSecuritySubType derivativeSecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecuritySubType val = new QuickFix.Fields.DerivativeSecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                this.derivativeSecuritySubType = val;
            }
            
            public QuickFix.Fields.DerivativeSecuritySubType get(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                return isSetDerivativeSecuritySubType();
            }
            
            public bool isSetDerivativeSecuritySubType() 
            { 
                return isSetField(Tags.DerivativeSecuritySubType);
            }
            public QuickFix.Fields.DerivativeMaturityMonthYear derivativeMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityMonthYear val = new QuickFix.Fields.DerivativeMaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                this.derivativeMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityMonthYear get(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                return isSetDerivativeMaturityMonthYear();
            }
            
            public bool isSetDerivativeMaturityMonthYear() 
            { 
                return isSetField(Tags.DerivativeMaturityMonthYear);
            }
            public QuickFix.Fields.DerivativeMaturityDate derivativeMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityDate val = new QuickFix.Fields.DerivativeMaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                this.derivativeMaturityDate = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityDate get(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                return isSetDerivativeMaturityDate();
            }
            
            public bool isSetDerivativeMaturityDate() 
            { 
                return isSetField(Tags.DerivativeMaturityDate);
            }
            public QuickFix.Fields.DerivativeMaturityTime derivativeMaturityTime
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityTime val = new QuickFix.Fields.DerivativeMaturityTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                this.derivativeMaturityTime = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityTime get(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                return isSetDerivativeMaturityTime();
            }
            
            public bool isSetDerivativeMaturityTime() 
            { 
                return isSetField(Tags.DerivativeMaturityTime);
            }
            public QuickFix.Fields.DerivativeSettleOnOpenFlag derivativeSettleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSettleOnOpenFlag val = new QuickFix.Fields.DerivativeSettleOnOpenFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                this.derivativeSettleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.DerivativeSettleOnOpenFlag get(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                return isSetDerivativeSettleOnOpenFlag();
            }
            
            public bool isSetDerivativeSettleOnOpenFlag() 
            { 
                return isSetField(Tags.DerivativeSettleOnOpenFlag);
            }
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod derivativeInstrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeInstrmtAssignmentMethod val = new QuickFix.Fields.DerivativeInstrmtAssignmentMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                this.derivativeInstrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod get(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                return isSetDerivativeInstrmtAssignmentMethod();
            }
            
            public bool isSetDerivativeInstrmtAssignmentMethod() 
            { 
                return isSetField(Tags.DerivativeInstrmtAssignmentMethod);
            }
            public QuickFix.Fields.DerivativeSecurityStatus derivativeSecurityStatus
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityStatus val = new QuickFix.Fields.DerivativeSecurityStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                this.derivativeSecurityStatus = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityStatus get(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                return isSetDerivativeSecurityStatus();
            }
            
            public bool isSetDerivativeSecurityStatus() 
            { 
                return isSetField(Tags.DerivativeSecurityStatus);
            }
            public QuickFix.Fields.DerivativeIssueDate derivativeIssueDate
            { 
                get 
                {
                    QuickFix.Fields.DerivativeIssueDate val = new QuickFix.Fields.DerivativeIssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                this.derivativeIssueDate = val;
            }
            
            public QuickFix.Fields.DerivativeIssueDate get(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                return isSetDerivativeIssueDate();
            }
            
            public bool isSetDerivativeIssueDate() 
            { 
                return isSetField(Tags.DerivativeIssueDate);
            }
            public QuickFix.Fields.DerivativeInstrRegistry derivativeInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.DerivativeInstrRegistry val = new QuickFix.Fields.DerivativeInstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                this.derivativeInstrRegistry = val;
            }
            
            public QuickFix.Fields.DerivativeInstrRegistry get(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                return isSetDerivativeInstrRegistry();
            }
            
            public bool isSetDerivativeInstrRegistry() 
            { 
                return isSetField(Tags.DerivativeInstrRegistry);
            }
            public QuickFix.Fields.DerivativeCountryOfIssue derivativeCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCountryOfIssue val = new QuickFix.Fields.DerivativeCountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                this.derivativeCountryOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeCountryOfIssue get(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                return isSetDerivativeCountryOfIssue();
            }
            
            public bool isSetDerivativeCountryOfIssue() 
            { 
                return isSetField(Tags.DerivativeCountryOfIssue);
            }
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue derivativeStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStateOrProvinceOfIssue val = new QuickFix.Fields.DerivativeStateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                this.derivativeStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue get(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                return isSetDerivativeStateOrProvinceOfIssue();
            }
            
            public bool isSetDerivativeStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.DerivativeStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.DerivativeStrikePrice derivativeStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikePrice val = new QuickFix.Fields.DerivativeStrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                this.derivativeStrikePrice = val;
            }
            
            public QuickFix.Fields.DerivativeStrikePrice get(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                return isSetDerivativeStrikePrice();
            }
            
            public bool isSetDerivativeStrikePrice() 
            { 
                return isSetField(Tags.DerivativeStrikePrice);
            }
            public QuickFix.Fields.DerivativeLocaleOfIssue derivativeLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeLocaleOfIssue val = new QuickFix.Fields.DerivativeLocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                this.derivativeLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeLocaleOfIssue get(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                return isSetDerivativeLocaleOfIssue();
            }
            
            public bool isSetDerivativeLocaleOfIssue() 
            { 
                return isSetField(Tags.DerivativeLocaleOfIssue);
            }
            public QuickFix.Fields.DerivativeStrikeCurrency derivativeStrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeCurrency val = new QuickFix.Fields.DerivativeStrikeCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                this.derivativeStrikeCurrency = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeCurrency get(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                return isSetDerivativeStrikeCurrency();
            }
            
            public bool isSetDerivativeStrikeCurrency() 
            { 
                return isSetField(Tags.DerivativeStrikeCurrency);
            }
            public QuickFix.Fields.DerivativeStrikeMultiplier derivativeStrikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeMultiplier val = new QuickFix.Fields.DerivativeStrikeMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                this.derivativeStrikeMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeMultiplier get(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                return isSetDerivativeStrikeMultiplier();
            }
            
            public bool isSetDerivativeStrikeMultiplier() 
            { 
                return isSetField(Tags.DerivativeStrikeMultiplier);
            }
            public QuickFix.Fields.DerivativeStrikeValue derivativeStrikeValue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeValue val = new QuickFix.Fields.DerivativeStrikeValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                this.derivativeStrikeValue = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeValue get(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                return isSetDerivativeStrikeValue();
            }
            
            public bool isSetDerivativeStrikeValue() 
            { 
                return isSetField(Tags.DerivativeStrikeValue);
            }
            public QuickFix.Fields.DerivativeOptAttribute derivativeOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.DerivativeOptAttribute val = new QuickFix.Fields.DerivativeOptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                this.derivativeOptAttribute = val;
            }
            
            public QuickFix.Fields.DerivativeOptAttribute get(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                return isSetDerivativeOptAttribute();
            }
            
            public bool isSetDerivativeOptAttribute() 
            { 
                return isSetField(Tags.DerivativeOptAttribute);
            }
            public QuickFix.Fields.DerivativeContractMultiplier derivativeContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractMultiplier val = new QuickFix.Fields.DerivativeContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                this.derivativeContractMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeContractMultiplier get(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                return isSetDerivativeContractMultiplier();
            }
            
            public bool isSetDerivativeContractMultiplier() 
            { 
                return isSetField(Tags.DerivativeContractMultiplier);
            }
            public QuickFix.Fields.DerivativeMinPriceIncrement derivativeMinPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMinPriceIncrement val = new QuickFix.Fields.DerivativeMinPriceIncrement();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                this.derivativeMinPriceIncrement = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrement get(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                return isSetDerivativeMinPriceIncrement();
            }
            
            public bool isSetDerivativeMinPriceIncrement() 
            { 
                return isSetField(Tags.DerivativeMinPriceIncrement);
            }
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount derivativeMinPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMinPriceIncrementAmount val = new QuickFix.Fields.DerivativeMinPriceIncrementAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                this.derivativeMinPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount get(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                return isSetDerivativeMinPriceIncrementAmount();
            }
            
            public bool isSetDerivativeMinPriceIncrementAmount() 
            { 
                return isSetField(Tags.DerivativeMinPriceIncrementAmount);
            }
            public QuickFix.Fields.DerivativeUnitOfMeasure derivativeUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.DerivativeUnitOfMeasure val = new QuickFix.Fields.DerivativeUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                this.derivativeUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasure get(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                return isSetDerivativeUnitOfMeasure();
            }
            
            public bool isSetDerivativeUnitOfMeasure() 
            { 
                return isSetField(Tags.DerivativeUnitOfMeasure);
            }
            public QuickFix.Fields.DerivativeUnitOfMeasureQty derivativeUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.DerivativeUnitOfMeasureQty val = new QuickFix.Fields.DerivativeUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                this.derivativeUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasureQty get(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                return isSetDerivativeUnitOfMeasureQty();
            }
            
            public bool isSetDerivativeUnitOfMeasureQty() 
            { 
                return isSetField(Tags.DerivativeUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativePriceUnitOfMeasure derivativePriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceUnitOfMeasure val = new QuickFix.Fields.DerivativePriceUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                this.derivativePriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasure get(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                return isSetDerivativePriceUnitOfMeasure();
            }
            
            public bool isSetDerivativePriceUnitOfMeasure() 
            { 
                return isSetField(Tags.DerivativePriceUnitOfMeasure);
            }
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty derivativePriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceUnitOfMeasureQty val = new QuickFix.Fields.DerivativePriceUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                this.derivativePriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty get(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                return isSetDerivativePriceUnitOfMeasureQty();
            }
            
            public bool isSetDerivativePriceUnitOfMeasureQty() 
            { 
                return isSetField(Tags.DerivativePriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativeExerciseStyle derivativeExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.DerivativeExerciseStyle val = new QuickFix.Fields.DerivativeExerciseStyle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                this.derivativeExerciseStyle = val;
            }
            
            public QuickFix.Fields.DerivativeExerciseStyle get(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                return isSetDerivativeExerciseStyle();
            }
            
            public bool isSetDerivativeExerciseStyle() 
            { 
                return isSetField(Tags.DerivativeExerciseStyle);
            }
            public QuickFix.Fields.DerivativeOptPayAmount derivativeOptPayAmount
            { 
                get 
                {
                    QuickFix.Fields.DerivativeOptPayAmount val = new QuickFix.Fields.DerivativeOptPayAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                this.derivativeOptPayAmount = val;
            }
            
            public QuickFix.Fields.DerivativeOptPayAmount get(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                return isSetDerivativeOptPayAmount();
            }
            
            public bool isSetDerivativeOptPayAmount() 
            { 
                return isSetField(Tags.DerivativeOptPayAmount);
            }
            public QuickFix.Fields.DerivativeTimeUnit derivativeTimeUnit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeTimeUnit val = new QuickFix.Fields.DerivativeTimeUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                this.derivativeTimeUnit = val;
            }
            
            public QuickFix.Fields.DerivativeTimeUnit get(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                return isSetDerivativeTimeUnit();
            }
            
            public bool isSetDerivativeTimeUnit() 
            { 
                return isSetField(Tags.DerivativeTimeUnit);
            }
            public QuickFix.Fields.DerivativeSecurityExchange derivativeSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityExchange val = new QuickFix.Fields.DerivativeSecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                this.derivativeSecurityExchange = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityExchange get(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                return isSetDerivativeSecurityExchange();
            }
            
            public bool isSetDerivativeSecurityExchange() 
            { 
                return isSetField(Tags.DerivativeSecurityExchange);
            }
            public QuickFix.Fields.DerivativePositionLimit derivativePositionLimit
            { 
                get 
                {
                    QuickFix.Fields.DerivativePositionLimit val = new QuickFix.Fields.DerivativePositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                this.derivativePositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativePositionLimit get(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                return isSetDerivativePositionLimit();
            }
            
            public bool isSetDerivativePositionLimit() 
            { 
                return isSetField(Tags.DerivativePositionLimit);
            }
            public QuickFix.Fields.DerivativeNTPositionLimit derivativeNTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeNTPositionLimit val = new QuickFix.Fields.DerivativeNTPositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                this.derivativeNTPositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativeNTPositionLimit get(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                return isSetDerivativeNTPositionLimit();
            }
            
            public bool isSetDerivativeNTPositionLimit() 
            { 
                return isSetField(Tags.DerivativeNTPositionLimit);
            }
            public QuickFix.Fields.DerivativeIssuer derivativeIssuer
            { 
                get 
                {
                    QuickFix.Fields.DerivativeIssuer val = new QuickFix.Fields.DerivativeIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeIssuer val) 
            { 
                this.derivativeIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeIssuer get(QuickFix.Fields.DerivativeIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeIssuer val) 
            { 
                return isSetDerivativeIssuer();
            }
            
            public bool isSetDerivativeIssuer() 
            { 
                return isSetField(Tags.DerivativeIssuer);
            }
            public QuickFix.Fields.DerivativeEncodedIssuerLen derivativeEncodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedIssuerLen val = new QuickFix.Fields.DerivativeEncodedIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                this.derivativeEncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuerLen get(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                return isSetDerivativeEncodedIssuerLen();
            }
            
            public bool isSetDerivativeEncodedIssuerLen() 
            { 
                return isSetField(Tags.DerivativeEncodedIssuerLen);
            }
            public QuickFix.Fields.DerivativeEncodedIssuer derivativeEncodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedIssuer val = new QuickFix.Fields.DerivativeEncodedIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                this.derivativeEncodedIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuer get(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                return isSetDerivativeEncodedIssuer();
            }
            
            public bool isSetDerivativeEncodedIssuer() 
            { 
                return isSetField(Tags.DerivativeEncodedIssuer);
            }
            public QuickFix.Fields.DerivativeSecurityDesc derivativeSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityDesc val = new QuickFix.Fields.DerivativeSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                this.derivativeSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityDesc get(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                return isSetDerivativeSecurityDesc();
            }
            
            public bool isSetDerivativeSecurityDesc() 
            { 
                return isSetField(Tags.DerivativeSecurityDesc);
            }
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen derivativeEncodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedSecurityDescLen val = new QuickFix.Fields.DerivativeEncodedSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                this.derivativeEncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen get(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                return isSetDerivativeEncodedSecurityDescLen();
            }
            
            public bool isSetDerivativeEncodedSecurityDescLen() 
            { 
                return isSetField(Tags.DerivativeEncodedSecurityDescLen);
            }
            public QuickFix.Fields.DerivativeEncodedSecurityDesc derivativeEncodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedSecurityDesc val = new QuickFix.Fields.DerivativeEncodedSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                this.derivativeEncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDesc get(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                return isSetDerivativeEncodedSecurityDesc();
            }
            
            public bool isSetDerivativeEncodedSecurityDesc() 
            { 
                return isSetField(Tags.DerivativeEncodedSecurityDesc);
            }
            public QuickFix.Fields.DerivativeContractSettlMonth derivativeContractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractSettlMonth val = new QuickFix.Fields.DerivativeContractSettlMonth();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                this.derivativeContractSettlMonth = val;
            }
            
            public QuickFix.Fields.DerivativeContractSettlMonth get(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                return isSetDerivativeContractSettlMonth();
            }
            
            public bool isSetDerivativeContractSettlMonth() 
            { 
                return isSetField(Tags.DerivativeContractSettlMonth);
            }
            public QuickFix.Fields.NoDerivativeEvents noDerivativeEvents
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeEvents val = new QuickFix.Fields.NoDerivativeEvents();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                this.noDerivativeEvents = val;
            }
            
            public QuickFix.Fields.NoDerivativeEvents get(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                return isSetNoDerivativeEvents();
            }
            
            public bool isSetNoDerivativeEvents() 
            { 
                return isSetField(Tags.NoDerivativeEvents);
            }
            public QuickFix.Fields.NoDerivativeInstrumentParties noDerivativeInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeInstrumentParties val = new QuickFix.Fields.NoDerivativeInstrumentParties();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                this.noDerivativeInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrumentParties get(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                return isSetNoDerivativeInstrumentParties();
            }
            
            public bool isSetNoDerivativeInstrumentParties() 
            { 
                return isSetField(Tags.NoDerivativeInstrumentParties);
            }
            public QuickFix.Fields.DerivativeSettlMethod derivativeSettlMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSettlMethod val = new QuickFix.Fields.DerivativeSettlMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                this.derivativeSettlMethod = val;
            }
            
            public QuickFix.Fields.DerivativeSettlMethod get(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                return isSetDerivativeSettlMethod();
            }
            
            public bool isSetDerivativeSettlMethod() 
            { 
                return isSetField(Tags.DerivativeSettlMethod);
            }
            public QuickFix.Fields.DerivativePriceQuoteMethod derivativePriceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceQuoteMethod val = new QuickFix.Fields.DerivativePriceQuoteMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                this.derivativePriceQuoteMethod = val;
            }
            
            public QuickFix.Fields.DerivativePriceQuoteMethod get(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                return isSetDerivativePriceQuoteMethod();
            }
            
            public bool isSetDerivativePriceQuoteMethod() 
            { 
                return isSetField(Tags.DerivativePriceQuoteMethod);
            }
            public QuickFix.Fields.DerivativeValuationMethod derivativeValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeValuationMethod val = new QuickFix.Fields.DerivativeValuationMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeValuationMethod val) 
            { 
                this.derivativeValuationMethod = val;
            }
            
            public QuickFix.Fields.DerivativeValuationMethod get(QuickFix.Fields.DerivativeValuationMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeValuationMethod val) 
            { 
                return isSetDerivativeValuationMethod();
            }
            
            public bool isSetDerivativeValuationMethod() 
            { 
                return isSetField(Tags.DerivativeValuationMethod);
            }
            public QuickFix.Fields.DerivativeListMethod derivativeListMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeListMethod val = new QuickFix.Fields.DerivativeListMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeListMethod val) 
            { 
                this.derivativeListMethod = val;
            }
            
            public QuickFix.Fields.DerivativeListMethod get(QuickFix.Fields.DerivativeListMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeListMethod val) 
            { 
                return isSetDerivativeListMethod();
            }
            
            public bool isSetDerivativeListMethod() 
            { 
                return isSetField(Tags.DerivativeListMethod);
            }
            public QuickFix.Fields.DerivativeCapPrice derivativeCapPrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCapPrice val = new QuickFix.Fields.DerivativeCapPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                this.derivativeCapPrice = val;
            }
            
            public QuickFix.Fields.DerivativeCapPrice get(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                return isSetDerivativeCapPrice();
            }
            
            public bool isSetDerivativeCapPrice() 
            { 
                return isSetField(Tags.DerivativeCapPrice);
            }
            public QuickFix.Fields.DerivativeFloorPrice derivativeFloorPrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeFloorPrice val = new QuickFix.Fields.DerivativeFloorPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                this.derivativeFloorPrice = val;
            }
            
            public QuickFix.Fields.DerivativeFloorPrice get(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                return isSetDerivativeFloorPrice();
            }
            
            public bool isSetDerivativeFloorPrice() 
            { 
                return isSetField(Tags.DerivativeFloorPrice);
            }
            public QuickFix.Fields.DerivativePutOrCall derivativePutOrCall
            { 
                get 
                {
                    QuickFix.Fields.DerivativePutOrCall val = new QuickFix.Fields.DerivativePutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                this.derivativePutOrCall = val;
            }
            
            public QuickFix.Fields.DerivativePutOrCall get(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                return isSetDerivativePutOrCall();
            }
            
            public bool isSetDerivativePutOrCall() 
            { 
                return isSetField(Tags.DerivativePutOrCall);
            }
            public QuickFix.Fields.DerivativeSecurityXMLLen derivativeSecurityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXMLLen val = new QuickFix.Fields.DerivativeSecurityXMLLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                this.derivativeSecurityXMLLen = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLLen get(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                return isSetDerivativeSecurityXMLLen();
            }
            
            public bool isSetDerivativeSecurityXMLLen() 
            { 
                return isSetField(Tags.DerivativeSecurityXMLLen);
            }
            public QuickFix.Fields.DerivativeSecurityXML derivativeSecurityXML
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXML val = new QuickFix.Fields.DerivativeSecurityXML();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                this.derivativeSecurityXML = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXML get(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                return isSetDerivativeSecurityXML();
            }
            
            public bool isSetDerivativeSecurityXML() 
            { 
                return isSetField(Tags.DerivativeSecurityXML);
            }
            public QuickFix.Fields.DerivativeSecurityXMLSchema derivativeSecurityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXMLSchema val = new QuickFix.Fields.DerivativeSecurityXMLSchema();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                this.derivativeSecurityXMLSchema = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLSchema get(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                return isSetDerivativeSecurityXMLSchema();
            }
            
            public bool isSetDerivativeSecurityXMLSchema() 
            { 
                return isSetField(Tags.DerivativeSecurityXMLSchema);
            }
            public QuickFix.Fields.DerivativeContractMultiplierUnit derivativeContractMultiplierUnit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractMultiplierUnit val = new QuickFix.Fields.DerivativeContractMultiplierUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeContractMultiplierUnit val) 
            { 
                this.derivativeContractMultiplierUnit = val;
            }
            
            public QuickFix.Fields.DerivativeContractMultiplierUnit get(QuickFix.Fields.DerivativeContractMultiplierUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeContractMultiplierUnit val) 
            { 
                return isSetDerivativeContractMultiplierUnit();
            }
            
            public bool isSetDerivativeContractMultiplierUnit() 
            { 
                return isSetField(Tags.DerivativeContractMultiplierUnit);
            }
            public QuickFix.Fields.DerivativeFlowScheduleType derivativeFlowScheduleType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeFlowScheduleType val = new QuickFix.Fields.DerivativeFlowScheduleType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeFlowScheduleType val) 
            { 
                this.derivativeFlowScheduleType = val;
            }
            
            public QuickFix.Fields.DerivativeFlowScheduleType get(QuickFix.Fields.DerivativeFlowScheduleType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeFlowScheduleType val) 
            { 
                return isSetDerivativeFlowScheduleType();
            }
            
            public bool isSetDerivativeFlowScheduleType() 
            { 
                return isSetField(Tags.DerivativeFlowScheduleType);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    this.underlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltID get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    return isSetUnderlyingSecurityAltID();
                }
                
                public bool isSetUnderlyingSecurityAltID() 
                { 
                    return isSetField(Tags.UnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    this.underlyingSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    return isSetUnderlyingSecurityAltIDSource();
                }
                
                public bool isSetUnderlyingSecurityAltIDSource() 
                { 
                    return isSetField(Tags.UnderlyingSecurityAltIDSource);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    this.underlyingStipType = val;
                }
                
                public QuickFix.Fields.UnderlyingStipType get(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    return isSetUnderlyingStipType();
                }
                
                public bool isSetUnderlyingStipType() 
                { 
                    return isSetField(Tags.UnderlyingStipType);
                }
                public QuickFix.Fields.UnderlyingStipValue underlyingStipValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    this.underlyingStipValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStipValue get(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    return isSetUnderlyingStipValue();
                }
                
                public bool isSetUnderlyingStipValue() 
                { 
                    return isSetField(Tags.UnderlyingStipValue);
                }
            
            }
            public class NoUndlyInstrumentParties : Group
            {
                public NoUndlyInstrumentParties() 
                  :base( Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.UnderlyingInstrumentPartyID underlyingInstrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrumentPartyID val = new QuickFix.Fields.UnderlyingInstrumentPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                { 
                    this.underlyingInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrumentPartyID get(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                { 
                    return isSetUnderlyingInstrumentPartyID();
                }
                
                public bool isSetUnderlyingInstrumentPartyID() 
                { 
                    return isSetField(Tags.UnderlyingInstrumentPartyID);
                }
                public QuickFix.Fields.UnderlyingInstrumentPartyIDSource underlyingInstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrumentPartyIDSource val = new QuickFix.Fields.UnderlyingInstrumentPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                { 
                    this.underlyingInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrumentPartyIDSource get(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                { 
                    return isSetUnderlyingInstrumentPartyIDSource();
                }
                
                public bool isSetUnderlyingInstrumentPartyIDSource() 
                { 
                    return isSetField(Tags.UnderlyingInstrumentPartyIDSource);
                }
                public QuickFix.Fields.UnderlyingInstrumentPartyRole underlyingInstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrumentPartyRole val = new QuickFix.Fields.UnderlyingInstrumentPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                { 
                    this.underlyingInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrumentPartyRole get(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                { 
                    return isSetUnderlyingInstrumentPartyRole();
                }
                
                public bool isSetUnderlyingInstrumentPartyRole() 
                { 
                    return isSetField(Tags.UnderlyingInstrumentPartyRole);
                }
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs noUndlyInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    this.noUndlyInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    return isSetNoUndlyInstrumentPartySubIDs();
                }
                
                public bool isSetNoUndlyInstrumentPartySubIDs() 
                { 
                    return isSetField(Tags.NoUndlyInstrumentPartySubIDs);
                }
                            public class NoUndlyInstrumentPartySubIDs : Group
                {
                    public NoUndlyInstrumentPartySubIDs() 
                      :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.UnderlyingInstrumentPartySubID underlyingInstrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrumentPartySubID val = new QuickFix.Fields.UnderlyingInstrumentPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                    { 
                        this.underlyingInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrumentPartySubID get(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                    { 
                        return isSetUnderlyingInstrumentPartySubID();
                    }
                    
                    public bool isSetUnderlyingInstrumentPartySubID() 
                    { 
                        return isSetField(Tags.UnderlyingInstrumentPartySubID);
                    }
                    public QuickFix.Fields.UnderlyingInstrumentPartySubIDType underlyingInstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrumentPartySubIDType val = new QuickFix.Fields.UnderlyingInstrumentPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                    { 
                        this.underlyingInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrumentPartySubIDType get(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                    { 
                        return isSetUnderlyingInstrumentPartySubIDType();
                    }
                    
                    public bool isSetUnderlyingInstrumentPartySubIDType() 
                    { 
                        return isSetField(Tags.UnderlyingInstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoDerivativeSecurityAltID : Group
            {
                public NoDerivativeSecurityAltID() 
                  :base( Tags.NoDerivativeSecurityAltID, Tags.DerivativeSecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeSecurityAltID, Tags.DerivativeSecurityAltIDSource, 0};
                            public QuickFix.Fields.DerivativeSecurityAltID derivativeSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeSecurityAltID val = new QuickFix.Fields.DerivativeSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    this.derivativeSecurityAltID = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltID get(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    return isSetDerivativeSecurityAltID();
                }
                
                public bool isSetDerivativeSecurityAltID() 
                { 
                    return isSetField(Tags.DerivativeSecurityAltID);
                }
                public QuickFix.Fields.DerivativeSecurityAltIDSource derivativeSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeSecurityAltIDSource val = new QuickFix.Fields.DerivativeSecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    this.derivativeSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltIDSource get(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    return isSetDerivativeSecurityAltIDSource();
                }
                
                public bool isSetDerivativeSecurityAltIDSource() 
                { 
                    return isSetField(Tags.DerivativeSecurityAltIDSource);
                }
            
            }
            public class NoDerivativeEvents : Group
            {
                public NoDerivativeEvents() 
                  :base( Tags.NoDerivativeEvents, Tags.DerivativeEventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeEventType, Tags.DerivativeEventDate, Tags.DerivativeEventTime, Tags.DerivativeEventPx, Tags.DerivativeEventText, 0};
                            public QuickFix.Fields.DerivativeEventType derivativeEventType
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventType val = new QuickFix.Fields.DerivativeEventType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventType val) 
                { 
                    this.derivativeEventType = val;
                }
                
                public QuickFix.Fields.DerivativeEventType get(QuickFix.Fields.DerivativeEventType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventType val) 
                { 
                    return isSetDerivativeEventType();
                }
                
                public bool isSetDerivativeEventType() 
                { 
                    return isSetField(Tags.DerivativeEventType);
                }
                public QuickFix.Fields.DerivativeEventDate derivativeEventDate
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventDate val = new QuickFix.Fields.DerivativeEventDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    this.derivativeEventDate = val;
                }
                
                public QuickFix.Fields.DerivativeEventDate get(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    return isSetDerivativeEventDate();
                }
                
                public bool isSetDerivativeEventDate() 
                { 
                    return isSetField(Tags.DerivativeEventDate);
                }
                public QuickFix.Fields.DerivativeEventTime derivativeEventTime
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventTime val = new QuickFix.Fields.DerivativeEventTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    this.derivativeEventTime = val;
                }
                
                public QuickFix.Fields.DerivativeEventTime get(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    return isSetDerivativeEventTime();
                }
                
                public bool isSetDerivativeEventTime() 
                { 
                    return isSetField(Tags.DerivativeEventTime);
                }
                public QuickFix.Fields.DerivativeEventPx derivativeEventPx
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventPx val = new QuickFix.Fields.DerivativeEventPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    this.derivativeEventPx = val;
                }
                
                public QuickFix.Fields.DerivativeEventPx get(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    return isSetDerivativeEventPx();
                }
                
                public bool isSetDerivativeEventPx() 
                { 
                    return isSetField(Tags.DerivativeEventPx);
                }
                public QuickFix.Fields.DerivativeEventText derivativeEventText
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventText val = new QuickFix.Fields.DerivativeEventText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventText val) 
                { 
                    this.derivativeEventText = val;
                }
                
                public QuickFix.Fields.DerivativeEventText get(QuickFix.Fields.DerivativeEventText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventText val) 
                { 
                    return isSetDerivativeEventText();
                }
                
                public bool isSetDerivativeEventText() 
                { 
                    return isSetField(Tags.DerivativeEventText);
                }
            
            }
            public class NoDerivativeInstrumentParties : Group
            {
                public NoDerivativeInstrumentParties() 
                  :base( Tags.NoDerivativeInstrumentParties, Tags.DerivativeInstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeInstrumentPartyID, Tags.DerivativeInstrumentPartyIDSource, Tags.DerivativeInstrumentPartyRole, Tags.NoDerivativeInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.DerivativeInstrumentPartyID derivativeInstrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyID val = new QuickFix.Fields.DerivativeInstrumentPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    this.derivativeInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyID get(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    return isSetDerivativeInstrumentPartyID();
                }
                
                public bool isSetDerivativeInstrumentPartyID() 
                { 
                    return isSetField(Tags.DerivativeInstrumentPartyID);
                }
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource derivativeInstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyIDSource val = new QuickFix.Fields.DerivativeInstrumentPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    this.derivativeInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource get(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    return isSetDerivativeInstrumentPartyIDSource();
                }
                
                public bool isSetDerivativeInstrumentPartyIDSource() 
                { 
                    return isSetField(Tags.DerivativeInstrumentPartyIDSource);
                }
                public QuickFix.Fields.DerivativeInstrumentPartyRole derivativeInstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyRole val = new QuickFix.Fields.DerivativeInstrumentPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    this.derivativeInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyRole get(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    return isSetDerivativeInstrumentPartyRole();
                }
                
                public bool isSetDerivativeInstrumentPartyRole() 
                { 
                    return isSetField(Tags.DerivativeInstrumentPartyRole);
                }
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs noDerivativeInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val = new QuickFix.Fields.NoDerivativeInstrumentPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    this.noDerivativeInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs get(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    return isSetNoDerivativeInstrumentPartySubIDs();
                }
                
                public bool isSetNoDerivativeInstrumentPartySubIDs() 
                { 
                    return isSetField(Tags.NoDerivativeInstrumentPartySubIDs);
                }
                            public class NoDerivativeInstrumentPartySubIDs : Group
                {
                    public NoDerivativeInstrumentPartySubIDs() 
                      :base( Tags.NoDerivativeInstrumentPartySubIDs, Tags.DerivativeInstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.DerivativeInstrumentPartySubID, Tags.DerivativeInstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.DerivativeInstrumentPartySubID derivativeInstrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.DerivativeInstrumentPartySubID val = new QuickFix.Fields.DerivativeInstrumentPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        this.derivativeInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubID get(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        return isSetDerivativeInstrumentPartySubID();
                    }
                    
                    public bool isSetDerivativeInstrumentPartySubID() 
                    { 
                        return isSetField(Tags.DerivativeInstrumentPartySubID);
                    }
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType derivativeInstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.DerivativeInstrumentPartySubIDType val = new QuickFix.Fields.DerivativeInstrumentPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        this.derivativeInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType get(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        return isSetDerivativeInstrumentPartySubIDType();
                    }
                    
                    public bool isSetDerivativeInstrumentPartySubIDType() 
                    { 
                        return isSetField(Tags.DerivativeInstrumentPartySubIDType);
                    }
                
                }
            }
        }
    }
}
