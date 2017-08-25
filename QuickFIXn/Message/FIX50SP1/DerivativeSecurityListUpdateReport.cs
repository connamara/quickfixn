// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class DerivativeSecurityListUpdateReport : Message
        {
            public const string MsgType = "BR";

            public DerivativeSecurityListUpdateReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BR"));
            }


            public QuickFix.Fields.SecurityReqID SecurityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.SecurityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return IsSetSecurityReqID();
            }
            
            public bool IsSetSecurityReqID() 
            { 
                return IsSetField(Tags.SecurityReqID);
            }
            public QuickFix.Fields.SecurityResponseID SecurityResponseID
            { 
                get 
                {
                    QuickFix.Fields.SecurityResponseID val = new QuickFix.Fields.SecurityResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityResponseID val) 
            { 
                this.SecurityResponseID = val;
            }
            
            public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityResponseID val) 
            { 
                return IsSetSecurityResponseID();
            }
            
            public bool IsSetSecurityResponseID() 
            { 
                return IsSetField(Tags.SecurityResponseID);
            }
            public QuickFix.Fields.SecurityRequestResult SecurityRequestResult
            { 
                get 
                {
                    QuickFix.Fields.SecurityRequestResult val = new QuickFix.Fields.SecurityRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityRequestResult val) 
            { 
                this.SecurityRequestResult = val;
            }
            
            public QuickFix.Fields.SecurityRequestResult Get(QuickFix.Fields.SecurityRequestResult val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityRequestResult val) 
            { 
                return IsSetSecurityRequestResult();
            }
            
            public bool IsSetSecurityRequestResult() 
            { 
                return IsSetField(Tags.SecurityRequestResult);
            }
            public QuickFix.Fields.SecurityUpdateAction SecurityUpdateAction
            { 
                get 
                {
                    QuickFix.Fields.SecurityUpdateAction val = new QuickFix.Fields.SecurityUpdateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                this.SecurityUpdateAction = val;
            }
            
            public QuickFix.Fields.SecurityUpdateAction Get(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                return IsSetSecurityUpdateAction();
            }
            
            public bool IsSetSecurityUpdateAction() 
            { 
                return IsSetField(Tags.SecurityUpdateAction);
            }
            public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
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
                this.UnderlyingSymbol = val;
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
            public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
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
                this.UnderlyingSymbolSfx = val;
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
            public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
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
                this.UnderlyingSecurityID = val;
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
            public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
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
                this.UnderlyingSecurityIDSource = val;
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
            public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
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
                this.NoUnderlyingSecurityAltID = val;
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
            public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
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
                this.UnderlyingProduct = val;
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
            public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
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
                this.UnderlyingCFICode = val;
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
            public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
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
                this.UnderlyingSecurityType = val;
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
            public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
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
                this.UnderlyingSecuritySubType = val;
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
            public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
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
                this.UnderlyingMaturityMonthYear = val;
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
            public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
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
                this.UnderlyingMaturityDate = val;
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
            public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
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
                this.UnderlyingCouponPaymentDate = val;
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
            public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
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
                this.UnderlyingIssueDate = val;
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
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
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
                this.UnderlyingRepoCollateralSecurityType = val;
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
            public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
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
                this.UnderlyingRepurchaseTerm = val;
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
            public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
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
                this.UnderlyingRepurchaseRate = val;
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
            public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
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
                this.UnderlyingFactor = val;
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
            public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
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
                this.UnderlyingCreditRating = val;
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
            public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
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
                this.UnderlyingInstrRegistry = val;
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
            public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
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
                this.UnderlyingCountryOfIssue = val;
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
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
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
                this.UnderlyingStateOrProvinceOfIssue = val;
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
            public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
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
                this.UnderlyingLocaleOfIssue = val;
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
            public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
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
                this.UnderlyingRedemptionDate = val;
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
            public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
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
                this.UnderlyingStrikePrice = val;
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
            public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
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
                this.UnderlyingStrikeCurrency = val;
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
            public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
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
                this.UnderlyingOptAttribute = val;
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
            public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
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
                this.UnderlyingContractMultiplier = val;
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
            public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
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
                this.UnderlyingCouponRate = val;
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
            public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
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
                this.UnderlyingSecurityExchange = val;
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
            public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
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
                this.UnderlyingIssuer = val;
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
            public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
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
                this.EncodedUnderlyingIssuerLen = val;
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
            public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
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
                this.EncodedUnderlyingIssuer = val;
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
            public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
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
                this.UnderlyingSecurityDesc = val;
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
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
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
                this.EncodedUnderlyingSecurityDescLen = val;
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
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
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
                this.EncodedUnderlyingSecurityDesc = val;
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
            public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
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
                this.UnderlyingCPProgram = val;
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
            public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
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
                this.UnderlyingCPRegType = val;
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
            public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
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
                this.UnderlyingCurrency = val;
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
            public QuickFix.Fields.UnderlyingQty UnderlyingQty
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
                this.UnderlyingQty = val;
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
            public QuickFix.Fields.UnderlyingPx UnderlyingPx
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
                this.UnderlyingPx = val;
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
            public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
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
                this.UnderlyingDirtyPrice = val;
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
            public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
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
                this.UnderlyingEndPrice = val;
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
            public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
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
                this.UnderlyingStartValue = val;
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
            public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
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
                this.UnderlyingCurrentValue = val;
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
            public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
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
                this.UnderlyingEndValue = val;
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
            public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
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
                this.NoUnderlyingStips = val;
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
            public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
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
                this.UnderlyingAllocationPercent = val;
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
            public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
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
                this.UnderlyingSettlementType = val;
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
            public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
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
                this.UnderlyingCashAmount = val;
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
            public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
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
                this.UnderlyingCashType = val;
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
            public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
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
                this.UnderlyingUnitOfMeasure = val;
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
            public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
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
                this.UnderlyingTimeUnit = val;
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
            public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
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
                this.UnderlyingCapValue = val;
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
            public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
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
                this.NoUndlyInstrumentParties = val;
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
            public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
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
                this.UnderlyingSettlMethod = val;
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
            public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
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
                this.UnderlyingAdjustedQuantity = val;
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
            public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
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
                this.UnderlyingFXRate = val;
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
            public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
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
                this.UnderlyingFXRateCalc = val;
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
            public QuickFix.Fields.UnderlyingMaturityTime UnderlyingMaturityTime
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
                this.UnderlyingMaturityTime = val;
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
            public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
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
                this.UnderlyingPutOrCall = val;
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
            public QuickFix.Fields.UnderlyingExerciseStyle UnderlyingExerciseStyle
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
                this.UnderlyingExerciseStyle = val;
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
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
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
                this.UnderlyingUnitOfMeasureQty = val;
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
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
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
                this.UnderlyingPriceUnitOfMeasure = val;
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
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
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
                this.UnderlyingPriceUnitOfMeasureQty = val;
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
            public QuickFix.Fields.DerivativeSymbol DerivativeSymbol
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSymbol val = new QuickFix.Fields.DerivativeSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSymbol val) 
            { 
                this.DerivativeSymbol = val;
            }
            
            public QuickFix.Fields.DerivativeSymbol Get(QuickFix.Fields.DerivativeSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSymbol val) 
            { 
                return IsSetDerivativeSymbol();
            }
            
            public bool IsSetDerivativeSymbol() 
            { 
                return IsSetField(Tags.DerivativeSymbol);
            }
            public QuickFix.Fields.DerivativeSymbolSfx DerivativeSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSymbolSfx val = new QuickFix.Fields.DerivativeSymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                this.DerivativeSymbolSfx = val;
            }
            
            public QuickFix.Fields.DerivativeSymbolSfx Get(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                return IsSetDerivativeSymbolSfx();
            }
            
            public bool IsSetDerivativeSymbolSfx() 
            { 
                return IsSetField(Tags.DerivativeSymbolSfx);
            }
            public QuickFix.Fields.DerivativeSecurityID DerivativeSecurityID
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityID val = new QuickFix.Fields.DerivativeSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                this.DerivativeSecurityID = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityID Get(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                return IsSetDerivativeSecurityID();
            }
            
            public bool IsSetDerivativeSecurityID() 
            { 
                return IsSetField(Tags.DerivativeSecurityID);
            }
            public QuickFix.Fields.DerivativeSecurityIDSource DerivativeSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityIDSource val = new QuickFix.Fields.DerivativeSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                this.DerivativeSecurityIDSource = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityIDSource Get(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                return IsSetDerivativeSecurityIDSource();
            }
            
            public bool IsSetDerivativeSecurityIDSource() 
            { 
                return IsSetField(Tags.DerivativeSecurityIDSource);
            }
            public QuickFix.Fields.NoDerivativeSecurityAltID NoDerivativeSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeSecurityAltID val = new QuickFix.Fields.NoDerivativeSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                this.NoDerivativeSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoDerivativeSecurityAltID Get(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                return IsSetNoDerivativeSecurityAltID();
            }
            
            public bool IsSetNoDerivativeSecurityAltID() 
            { 
                return IsSetField(Tags.NoDerivativeSecurityAltID);
            }
            public QuickFix.Fields.DerivativeProduct DerivativeProduct
            { 
                get 
                {
                    QuickFix.Fields.DerivativeProduct val = new QuickFix.Fields.DerivativeProduct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeProduct val) 
            { 
                this.DerivativeProduct = val;
            }
            
            public QuickFix.Fields.DerivativeProduct Get(QuickFix.Fields.DerivativeProduct val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeProduct val) 
            { 
                return IsSetDerivativeProduct();
            }
            
            public bool IsSetDerivativeProduct() 
            { 
                return IsSetField(Tags.DerivativeProduct);
            }
            public QuickFix.Fields.DerivativeProductComplex DerivativeProductComplex
            { 
                get 
                {
                    QuickFix.Fields.DerivativeProductComplex val = new QuickFix.Fields.DerivativeProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                this.DerivativeProductComplex = val;
            }
            
            public QuickFix.Fields.DerivativeProductComplex Get(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                return IsSetDerivativeProductComplex();
            }
            
            public bool IsSetDerivativeProductComplex() 
            { 
                return IsSetField(Tags.DerivativeProductComplex);
            }
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator DerivFlexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.DerivFlexProductEligibilityIndicator val = new QuickFix.Fields.DerivFlexProductEligibilityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                this.DerivFlexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator Get(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                return IsSetDerivFlexProductEligibilityIndicator();
            }
            
            public bool IsSetDerivFlexProductEligibilityIndicator() 
            { 
                return IsSetField(Tags.DerivFlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.DerivativeSecurityGroup DerivativeSecurityGroup
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityGroup val = new QuickFix.Fields.DerivativeSecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                this.DerivativeSecurityGroup = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityGroup Get(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                return IsSetDerivativeSecurityGroup();
            }
            
            public bool IsSetDerivativeSecurityGroup() 
            { 
                return IsSetField(Tags.DerivativeSecurityGroup);
            }
            public QuickFix.Fields.DerivativeCFICode DerivativeCFICode
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCFICode val = new QuickFix.Fields.DerivativeCFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeCFICode val) 
            { 
                this.DerivativeCFICode = val;
            }
            
            public QuickFix.Fields.DerivativeCFICode Get(QuickFix.Fields.DerivativeCFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeCFICode val) 
            { 
                return IsSetDerivativeCFICode();
            }
            
            public bool IsSetDerivativeCFICode() 
            { 
                return IsSetField(Tags.DerivativeCFICode);
            }
            public QuickFix.Fields.DerivativeSecurityType DerivativeSecurityType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityType val = new QuickFix.Fields.DerivativeSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                this.DerivativeSecurityType = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityType Get(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                return IsSetDerivativeSecurityType();
            }
            
            public bool IsSetDerivativeSecurityType() 
            { 
                return IsSetField(Tags.DerivativeSecurityType);
            }
            public QuickFix.Fields.DerivativeSecuritySubType DerivativeSecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecuritySubType val = new QuickFix.Fields.DerivativeSecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                this.DerivativeSecuritySubType = val;
            }
            
            public QuickFix.Fields.DerivativeSecuritySubType Get(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                return IsSetDerivativeSecuritySubType();
            }
            
            public bool IsSetDerivativeSecuritySubType() 
            { 
                return IsSetField(Tags.DerivativeSecuritySubType);
            }
            public QuickFix.Fields.DerivativeMaturityMonthYear DerivativeMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityMonthYear val = new QuickFix.Fields.DerivativeMaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                this.DerivativeMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityMonthYear Get(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                return IsSetDerivativeMaturityMonthYear();
            }
            
            public bool IsSetDerivativeMaturityMonthYear() 
            { 
                return IsSetField(Tags.DerivativeMaturityMonthYear);
            }
            public QuickFix.Fields.DerivativeMaturityDate DerivativeMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityDate val = new QuickFix.Fields.DerivativeMaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                this.DerivativeMaturityDate = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityDate Get(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                return IsSetDerivativeMaturityDate();
            }
            
            public bool IsSetDerivativeMaturityDate() 
            { 
                return IsSetField(Tags.DerivativeMaturityDate);
            }
            public QuickFix.Fields.DerivativeMaturityTime DerivativeMaturityTime
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityTime val = new QuickFix.Fields.DerivativeMaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                this.DerivativeMaturityTime = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityTime Get(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                return IsSetDerivativeMaturityTime();
            }
            
            public bool IsSetDerivativeMaturityTime() 
            { 
                return IsSetField(Tags.DerivativeMaturityTime);
            }
            public QuickFix.Fields.DerivativeSettleOnOpenFlag DerivativeSettleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSettleOnOpenFlag val = new QuickFix.Fields.DerivativeSettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                this.DerivativeSettleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.DerivativeSettleOnOpenFlag Get(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                return IsSetDerivativeSettleOnOpenFlag();
            }
            
            public bool IsSetDerivativeSettleOnOpenFlag() 
            { 
                return IsSetField(Tags.DerivativeSettleOnOpenFlag);
            }
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod DerivativeInstrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeInstrmtAssignmentMethod val = new QuickFix.Fields.DerivativeInstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                this.DerivativeInstrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod Get(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                return IsSetDerivativeInstrmtAssignmentMethod();
            }
            
            public bool IsSetDerivativeInstrmtAssignmentMethod() 
            { 
                return IsSetField(Tags.DerivativeInstrmtAssignmentMethod);
            }
            public QuickFix.Fields.DerivativeSecurityStatus DerivativeSecurityStatus
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityStatus val = new QuickFix.Fields.DerivativeSecurityStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                this.DerivativeSecurityStatus = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityStatus Get(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                return IsSetDerivativeSecurityStatus();
            }
            
            public bool IsSetDerivativeSecurityStatus() 
            { 
                return IsSetField(Tags.DerivativeSecurityStatus);
            }
            public QuickFix.Fields.DerivativeIssueDate DerivativeIssueDate
            { 
                get 
                {
                    QuickFix.Fields.DerivativeIssueDate val = new QuickFix.Fields.DerivativeIssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                this.DerivativeIssueDate = val;
            }
            
            public QuickFix.Fields.DerivativeIssueDate Get(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                return IsSetDerivativeIssueDate();
            }
            
            public bool IsSetDerivativeIssueDate() 
            { 
                return IsSetField(Tags.DerivativeIssueDate);
            }
            public QuickFix.Fields.DerivativeInstrRegistry DerivativeInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.DerivativeInstrRegistry val = new QuickFix.Fields.DerivativeInstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                this.DerivativeInstrRegistry = val;
            }
            
            public QuickFix.Fields.DerivativeInstrRegistry Get(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                return IsSetDerivativeInstrRegistry();
            }
            
            public bool IsSetDerivativeInstrRegistry() 
            { 
                return IsSetField(Tags.DerivativeInstrRegistry);
            }
            public QuickFix.Fields.DerivativeCountryOfIssue DerivativeCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCountryOfIssue val = new QuickFix.Fields.DerivativeCountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                this.DerivativeCountryOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeCountryOfIssue Get(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                return IsSetDerivativeCountryOfIssue();
            }
            
            public bool IsSetDerivativeCountryOfIssue() 
            { 
                return IsSetField(Tags.DerivativeCountryOfIssue);
            }
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue DerivativeStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStateOrProvinceOfIssue val = new QuickFix.Fields.DerivativeStateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                this.DerivativeStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue Get(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                return IsSetDerivativeStateOrProvinceOfIssue();
            }
            
            public bool IsSetDerivativeStateOrProvinceOfIssue() 
            { 
                return IsSetField(Tags.DerivativeStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.DerivativeStrikePrice DerivativeStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikePrice val = new QuickFix.Fields.DerivativeStrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                this.DerivativeStrikePrice = val;
            }
            
            public QuickFix.Fields.DerivativeStrikePrice Get(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                return IsSetDerivativeStrikePrice();
            }
            
            public bool IsSetDerivativeStrikePrice() 
            { 
                return IsSetField(Tags.DerivativeStrikePrice);
            }
            public QuickFix.Fields.DerivativeLocaleOfIssue DerivativeLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeLocaleOfIssue val = new QuickFix.Fields.DerivativeLocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                this.DerivativeLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeLocaleOfIssue Get(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                return IsSetDerivativeLocaleOfIssue();
            }
            
            public bool IsSetDerivativeLocaleOfIssue() 
            { 
                return IsSetField(Tags.DerivativeLocaleOfIssue);
            }
            public QuickFix.Fields.DerivativeStrikeCurrency DerivativeStrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeCurrency val = new QuickFix.Fields.DerivativeStrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                this.DerivativeStrikeCurrency = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeCurrency Get(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                return IsSetDerivativeStrikeCurrency();
            }
            
            public bool IsSetDerivativeStrikeCurrency() 
            { 
                return IsSetField(Tags.DerivativeStrikeCurrency);
            }
            public QuickFix.Fields.DerivativeStrikeMultiplier DerivativeStrikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeMultiplier val = new QuickFix.Fields.DerivativeStrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                this.DerivativeStrikeMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeMultiplier Get(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                return IsSetDerivativeStrikeMultiplier();
            }
            
            public bool IsSetDerivativeStrikeMultiplier() 
            { 
                return IsSetField(Tags.DerivativeStrikeMultiplier);
            }
            public QuickFix.Fields.DerivativeStrikeValue DerivativeStrikeValue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeValue val = new QuickFix.Fields.DerivativeStrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                this.DerivativeStrikeValue = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeValue Get(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                return IsSetDerivativeStrikeValue();
            }
            
            public bool IsSetDerivativeStrikeValue() 
            { 
                return IsSetField(Tags.DerivativeStrikeValue);
            }
            public QuickFix.Fields.DerivativeOptAttribute DerivativeOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.DerivativeOptAttribute val = new QuickFix.Fields.DerivativeOptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                this.DerivativeOptAttribute = val;
            }
            
            public QuickFix.Fields.DerivativeOptAttribute Get(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                return IsSetDerivativeOptAttribute();
            }
            
            public bool IsSetDerivativeOptAttribute() 
            { 
                return IsSetField(Tags.DerivativeOptAttribute);
            }
            public QuickFix.Fields.DerivativeContractMultiplier DerivativeContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractMultiplier val = new QuickFix.Fields.DerivativeContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                this.DerivativeContractMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeContractMultiplier Get(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                return IsSetDerivativeContractMultiplier();
            }
            
            public bool IsSetDerivativeContractMultiplier() 
            { 
                return IsSetField(Tags.DerivativeContractMultiplier);
            }
            public QuickFix.Fields.DerivativeMinPriceIncrement DerivativeMinPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMinPriceIncrement val = new QuickFix.Fields.DerivativeMinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                this.DerivativeMinPriceIncrement = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrement Get(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                return IsSetDerivativeMinPriceIncrement();
            }
            
            public bool IsSetDerivativeMinPriceIncrement() 
            { 
                return IsSetField(Tags.DerivativeMinPriceIncrement);
            }
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount DerivativeMinPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMinPriceIncrementAmount val = new QuickFix.Fields.DerivativeMinPriceIncrementAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                this.DerivativeMinPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount Get(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                return IsSetDerivativeMinPriceIncrementAmount();
            }
            
            public bool IsSetDerivativeMinPriceIncrementAmount() 
            { 
                return IsSetField(Tags.DerivativeMinPriceIncrementAmount);
            }
            public QuickFix.Fields.DerivativeUnitOfMeasure DerivativeUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.DerivativeUnitOfMeasure val = new QuickFix.Fields.DerivativeUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                this.DerivativeUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasure Get(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                return IsSetDerivativeUnitOfMeasure();
            }
            
            public bool IsSetDerivativeUnitOfMeasure() 
            { 
                return IsSetField(Tags.DerivativeUnitOfMeasure);
            }
            public QuickFix.Fields.DerivativeUnitOfMeasureQty DerivativeUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.DerivativeUnitOfMeasureQty val = new QuickFix.Fields.DerivativeUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                this.DerivativeUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasureQty Get(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                return IsSetDerivativeUnitOfMeasureQty();
            }
            
            public bool IsSetDerivativeUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.DerivativeUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativePriceUnitOfMeasure DerivativePriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceUnitOfMeasure val = new QuickFix.Fields.DerivativePriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                this.DerivativePriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasure Get(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                return IsSetDerivativePriceUnitOfMeasure();
            }
            
            public bool IsSetDerivativePriceUnitOfMeasure() 
            { 
                return IsSetField(Tags.DerivativePriceUnitOfMeasure);
            }
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty DerivativePriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceUnitOfMeasureQty val = new QuickFix.Fields.DerivativePriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                this.DerivativePriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty Get(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                return IsSetDerivativePriceUnitOfMeasureQty();
            }
            
            public bool IsSetDerivativePriceUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.DerivativePriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativeExerciseStyle DerivativeExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.DerivativeExerciseStyle val = new QuickFix.Fields.DerivativeExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                this.DerivativeExerciseStyle = val;
            }
            
            public QuickFix.Fields.DerivativeExerciseStyle Get(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                return IsSetDerivativeExerciseStyle();
            }
            
            public bool IsSetDerivativeExerciseStyle() 
            { 
                return IsSetField(Tags.DerivativeExerciseStyle);
            }
            public QuickFix.Fields.DerivativeOptPayAmount DerivativeOptPayAmount
            { 
                get 
                {
                    QuickFix.Fields.DerivativeOptPayAmount val = new QuickFix.Fields.DerivativeOptPayAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                this.DerivativeOptPayAmount = val;
            }
            
            public QuickFix.Fields.DerivativeOptPayAmount Get(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                return IsSetDerivativeOptPayAmount();
            }
            
            public bool IsSetDerivativeOptPayAmount() 
            { 
                return IsSetField(Tags.DerivativeOptPayAmount);
            }
            public QuickFix.Fields.DerivativeTimeUnit DerivativeTimeUnit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeTimeUnit val = new QuickFix.Fields.DerivativeTimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                this.DerivativeTimeUnit = val;
            }
            
            public QuickFix.Fields.DerivativeTimeUnit Get(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                return IsSetDerivativeTimeUnit();
            }
            
            public bool IsSetDerivativeTimeUnit() 
            { 
                return IsSetField(Tags.DerivativeTimeUnit);
            }
            public QuickFix.Fields.DerivativeSecurityExchange DerivativeSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityExchange val = new QuickFix.Fields.DerivativeSecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                this.DerivativeSecurityExchange = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityExchange Get(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                return IsSetDerivativeSecurityExchange();
            }
            
            public bool IsSetDerivativeSecurityExchange() 
            { 
                return IsSetField(Tags.DerivativeSecurityExchange);
            }
            public QuickFix.Fields.DerivativePositionLimit DerivativePositionLimit
            { 
                get 
                {
                    QuickFix.Fields.DerivativePositionLimit val = new QuickFix.Fields.DerivativePositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                this.DerivativePositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativePositionLimit Get(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                return IsSetDerivativePositionLimit();
            }
            
            public bool IsSetDerivativePositionLimit() 
            { 
                return IsSetField(Tags.DerivativePositionLimit);
            }
            public QuickFix.Fields.DerivativeNTPositionLimit DerivativeNTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeNTPositionLimit val = new QuickFix.Fields.DerivativeNTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                this.DerivativeNTPositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativeNTPositionLimit Get(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                return IsSetDerivativeNTPositionLimit();
            }
            
            public bool IsSetDerivativeNTPositionLimit() 
            { 
                return IsSetField(Tags.DerivativeNTPositionLimit);
            }
            public QuickFix.Fields.DerivativeIssuer DerivativeIssuer
            { 
                get 
                {
                    QuickFix.Fields.DerivativeIssuer val = new QuickFix.Fields.DerivativeIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeIssuer val) 
            { 
                this.DerivativeIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeIssuer Get(QuickFix.Fields.DerivativeIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeIssuer val) 
            { 
                return IsSetDerivativeIssuer();
            }
            
            public bool IsSetDerivativeIssuer() 
            { 
                return IsSetField(Tags.DerivativeIssuer);
            }
            public QuickFix.Fields.DerivativeEncodedIssuerLen DerivativeEncodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedIssuerLen val = new QuickFix.Fields.DerivativeEncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                this.DerivativeEncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuerLen Get(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                return IsSetDerivativeEncodedIssuerLen();
            }
            
            public bool IsSetDerivativeEncodedIssuerLen() 
            { 
                return IsSetField(Tags.DerivativeEncodedIssuerLen);
            }
            public QuickFix.Fields.DerivativeEncodedIssuer DerivativeEncodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedIssuer val = new QuickFix.Fields.DerivativeEncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                this.DerivativeEncodedIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuer Get(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                return IsSetDerivativeEncodedIssuer();
            }
            
            public bool IsSetDerivativeEncodedIssuer() 
            { 
                return IsSetField(Tags.DerivativeEncodedIssuer);
            }
            public QuickFix.Fields.DerivativeSecurityDesc DerivativeSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityDesc val = new QuickFix.Fields.DerivativeSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                this.DerivativeSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityDesc Get(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                return IsSetDerivativeSecurityDesc();
            }
            
            public bool IsSetDerivativeSecurityDesc() 
            { 
                return IsSetField(Tags.DerivativeSecurityDesc);
            }
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen DerivativeEncodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedSecurityDescLen val = new QuickFix.Fields.DerivativeEncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                this.DerivativeEncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen Get(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                return IsSetDerivativeEncodedSecurityDescLen();
            }
            
            public bool IsSetDerivativeEncodedSecurityDescLen() 
            { 
                return IsSetField(Tags.DerivativeEncodedSecurityDescLen);
            }
            public QuickFix.Fields.DerivativeEncodedSecurityDesc DerivativeEncodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedSecurityDesc val = new QuickFix.Fields.DerivativeEncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                this.DerivativeEncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDesc Get(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                return IsSetDerivativeEncodedSecurityDesc();
            }
            
            public bool IsSetDerivativeEncodedSecurityDesc() 
            { 
                return IsSetField(Tags.DerivativeEncodedSecurityDesc);
            }
            public QuickFix.Fields.DerivativeContractSettlMonth DerivativeContractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractSettlMonth val = new QuickFix.Fields.DerivativeContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                this.DerivativeContractSettlMonth = val;
            }
            
            public QuickFix.Fields.DerivativeContractSettlMonth Get(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                return IsSetDerivativeContractSettlMonth();
            }
            
            public bool IsSetDerivativeContractSettlMonth() 
            { 
                return IsSetField(Tags.DerivativeContractSettlMonth);
            }
            public QuickFix.Fields.NoDerivativeEvents NoDerivativeEvents
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeEvents val = new QuickFix.Fields.NoDerivativeEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                this.NoDerivativeEvents = val;
            }
            
            public QuickFix.Fields.NoDerivativeEvents Get(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                return IsSetNoDerivativeEvents();
            }
            
            public bool IsSetNoDerivativeEvents() 
            { 
                return IsSetField(Tags.NoDerivativeEvents);
            }
            public QuickFix.Fields.NoDerivativeInstrumentParties NoDerivativeInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeInstrumentParties val = new QuickFix.Fields.NoDerivativeInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                this.NoDerivativeInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrumentParties Get(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                return IsSetNoDerivativeInstrumentParties();
            }
            
            public bool IsSetNoDerivativeInstrumentParties() 
            { 
                return IsSetField(Tags.NoDerivativeInstrumentParties);
            }
            public QuickFix.Fields.DerivativeSettlMethod DerivativeSettlMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSettlMethod val = new QuickFix.Fields.DerivativeSettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                this.DerivativeSettlMethod = val;
            }
            
            public QuickFix.Fields.DerivativeSettlMethod Get(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                return IsSetDerivativeSettlMethod();
            }
            
            public bool IsSetDerivativeSettlMethod() 
            { 
                return IsSetField(Tags.DerivativeSettlMethod);
            }
            public QuickFix.Fields.DerivativePriceQuoteMethod DerivativePriceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceQuoteMethod val = new QuickFix.Fields.DerivativePriceQuoteMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                this.DerivativePriceQuoteMethod = val;
            }
            
            public QuickFix.Fields.DerivativePriceQuoteMethod Get(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                return IsSetDerivativePriceQuoteMethod();
            }
            
            public bool IsSetDerivativePriceQuoteMethod() 
            { 
                return IsSetField(Tags.DerivativePriceQuoteMethod);
            }
            public QuickFix.Fields.DerivativeFuturesValuationMethod DerivativeFuturesValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeFuturesValuationMethod val = new QuickFix.Fields.DerivativeFuturesValuationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                this.DerivativeFuturesValuationMethod = val;
            }
            
            public QuickFix.Fields.DerivativeFuturesValuationMethod Get(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                return IsSetDerivativeFuturesValuationMethod();
            }
            
            public bool IsSetDerivativeFuturesValuationMethod() 
            { 
                return IsSetField(Tags.DerivativeFuturesValuationMethod);
            }
            public QuickFix.Fields.DerivativeListMethod DerivativeListMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeListMethod val = new QuickFix.Fields.DerivativeListMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeListMethod val) 
            { 
                this.DerivativeListMethod = val;
            }
            
            public QuickFix.Fields.DerivativeListMethod Get(QuickFix.Fields.DerivativeListMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeListMethod val) 
            { 
                return IsSetDerivativeListMethod();
            }
            
            public bool IsSetDerivativeListMethod() 
            { 
                return IsSetField(Tags.DerivativeListMethod);
            }
            public QuickFix.Fields.DerivativeCapPrice DerivativeCapPrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCapPrice val = new QuickFix.Fields.DerivativeCapPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                this.DerivativeCapPrice = val;
            }
            
            public QuickFix.Fields.DerivativeCapPrice Get(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                return IsSetDerivativeCapPrice();
            }
            
            public bool IsSetDerivativeCapPrice() 
            { 
                return IsSetField(Tags.DerivativeCapPrice);
            }
            public QuickFix.Fields.DerivativeFloorPrice DerivativeFloorPrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeFloorPrice val = new QuickFix.Fields.DerivativeFloorPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                this.DerivativeFloorPrice = val;
            }
            
            public QuickFix.Fields.DerivativeFloorPrice Get(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                return IsSetDerivativeFloorPrice();
            }
            
            public bool IsSetDerivativeFloorPrice() 
            { 
                return IsSetField(Tags.DerivativeFloorPrice);
            }
            public QuickFix.Fields.DerivativePutOrCall DerivativePutOrCall
            { 
                get 
                {
                    QuickFix.Fields.DerivativePutOrCall val = new QuickFix.Fields.DerivativePutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                this.DerivativePutOrCall = val;
            }
            
            public QuickFix.Fields.DerivativePutOrCall Get(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                return IsSetDerivativePutOrCall();
            }
            
            public bool IsSetDerivativePutOrCall() 
            { 
                return IsSetField(Tags.DerivativePutOrCall);
            }
            public QuickFix.Fields.DerivativeSecurityXMLLen DerivativeSecurityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXMLLen val = new QuickFix.Fields.DerivativeSecurityXMLLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                this.DerivativeSecurityXMLLen = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLLen Get(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                return IsSetDerivativeSecurityXMLLen();
            }
            
            public bool IsSetDerivativeSecurityXMLLen() 
            { 
                return IsSetField(Tags.DerivativeSecurityXMLLen);
            }
            public QuickFix.Fields.DerivativeSecurityXML DerivativeSecurityXML
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXML val = new QuickFix.Fields.DerivativeSecurityXML();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                this.DerivativeSecurityXML = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXML Get(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                return IsSetDerivativeSecurityXML();
            }
            
            public bool IsSetDerivativeSecurityXML() 
            { 
                return IsSetField(Tags.DerivativeSecurityXML);
            }
            public QuickFix.Fields.DerivativeSecurityXMLSchema DerivativeSecurityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXMLSchema val = new QuickFix.Fields.DerivativeSecurityXMLSchema();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                this.DerivativeSecurityXMLSchema = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLSchema Get(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                return IsSetDerivativeSecurityXMLSchema();
            }
            
            public bool IsSetDerivativeSecurityXMLSchema() 
            { 
                return IsSetField(Tags.DerivativeSecurityXMLSchema);
            }
            public QuickFix.Fields.NoDerivativeInstrAttrib NoDerivativeInstrAttrib
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeInstrAttrib val = new QuickFix.Fields.NoDerivativeInstrAttrib();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                this.NoDerivativeInstrAttrib = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrAttrib Get(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                return IsSetNoDerivativeInstrAttrib();
            }
            
            public bool IsSetNoDerivativeInstrAttrib() 
            { 
                return IsSetField(Tags.NoDerivativeInstrAttrib);
            }
            public QuickFix.Fields.NoMarketSegments NoMarketSegments
            { 
                get 
                {
                    QuickFix.Fields.NoMarketSegments val = new QuickFix.Fields.NoMarketSegments();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMarketSegments val) 
            { 
                this.NoMarketSegments = val;
            }
            
            public QuickFix.Fields.NoMarketSegments Get(QuickFix.Fields.NoMarketSegments val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMarketSegments val) 
            { 
                return IsSetNoMarketSegments();
            }
            
            public bool IsSetNoMarketSegments() 
            { 
                return IsSetField(Tags.NoMarketSegments);
            }
            public QuickFix.Fields.TotNoRelatedSym TotNoRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.TotNoRelatedSym val = new QuickFix.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                this.TotNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym Get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return IsSetTotNoRelatedSym();
            }
            
            public bool IsSetTotNoRelatedSym() 
            { 
                return IsSetField(Tags.TotNoRelatedSym);
            }
            public QuickFix.Fields.LastFragment LastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                this.LastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoRelatedSym NoRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.NoRelatedSym val = new QuickFix.Fields.NoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRelatedSym val) 
            { 
                this.NoRelatedSym = val;
            }
            
            public QuickFix.Fields.NoRelatedSym Get(QuickFix.Fields.NoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRelatedSym val) 
            { 
                return IsSetNoRelatedSym();
            }
            
            public bool IsSetNoRelatedSym() 
            { 
                return IsSetField(Tags.NoRelatedSym);
            }
            public QuickFix.Fields.ApplID ApplID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                this.ApplID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.ApplSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.ApplLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.ApplResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(Tags.ApplResendFlag);
            }
            public class NoUnderlyingSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
            
                public NoUnderlyingSecurityAltIDGroup() 
                  :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
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
                        QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    this.UnderlyingSecurityAltID = val;
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
                public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
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
                    this.UnderlyingSecurityAltIDSource = val;
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
            public class NoUnderlyingStipsGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
            
                public NoUnderlyingStipsGroup() 
                  :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
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
                        QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    this.UnderlyingStipType = val;
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
                public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
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
                    this.UnderlyingStipValue = val;
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
            public class NoUndlyInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
            
                public NoUndlyInstrumentPartiesGroup() 
                  :base( Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
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
                        QuickFix.Fields.UndlyInstrumentPartyID val = new QuickFix.Fields.UndlyInstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    this.UndlyInstrumentPartyID = val;
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
                public QuickFix.Fields.UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
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
                    this.UndlyInstrumentPartyIDSource = val;
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
                public QuickFix.Fields.UndlyInstrumentPartyRole UndlyInstrumentPartyRole
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
                    this.UndlyInstrumentPartyRole = val;
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
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
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
                    this.NoUndlyInstrumentPartySubIDs = val;
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
                            public class NoUndlyInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};
                
                    public NoUndlyInstrumentPartySubIDsGroup() 
                      :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
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
                            QuickFix.Fields.UndlyInstrumentPartySubID val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        this.UndlyInstrumentPartySubID = val;
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
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
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
                        this.UndlyInstrumentPartySubIDType = val;
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
            public class NoDerivativeSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Tags.DerivativeSecurityAltID, Tags.DerivativeSecurityAltIDSource, 0};
            
                public NoDerivativeSecurityAltIDGroup() 
                  :base( Tags.NoDerivativeSecurityAltID, Tags.DerivativeSecurityAltID, fieldOrder)
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
                        QuickFix.Fields.DerivativeSecurityAltID val = new QuickFix.Fields.DerivativeSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    this.DerivativeSecurityAltID = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltID Get(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    return IsSetDerivativeSecurityAltID();
                }
                
                public bool IsSetDerivativeSecurityAltID() 
                { 
                    return IsSetField(Tags.DerivativeSecurityAltID);
                }
                public QuickFix.Fields.DerivativeSecurityAltIDSource DerivativeSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeSecurityAltIDSource val = new QuickFix.Fields.DerivativeSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    this.DerivativeSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltIDSource Get(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    return IsSetDerivativeSecurityAltIDSource();
                }
                
                public bool IsSetDerivativeSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.DerivativeSecurityAltIDSource);
                }
            
            }
            public class NoDerivativeEventsGroup : Group
            {
                public static int[] fieldOrder = {Tags.DerivativeEventType, Tags.DerivativeEventDate, Tags.DerivativeEventTime, Tags.DerivativeEventPx, Tags.DerivativeEventText, 0};
            
                public NoDerivativeEventsGroup() 
                  :base( Tags.NoDerivativeEvents, Tags.DerivativeEventType, fieldOrder)
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
                        QuickFix.Fields.DerivativeEventType val = new QuickFix.Fields.DerivativeEventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventType val) 
                { 
                    this.DerivativeEventType = val;
                }
                
                public QuickFix.Fields.DerivativeEventType Get(QuickFix.Fields.DerivativeEventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventType val) 
                { 
                    return IsSetDerivativeEventType();
                }
                
                public bool IsSetDerivativeEventType() 
                { 
                    return IsSetField(Tags.DerivativeEventType);
                }
                public QuickFix.Fields.DerivativeEventDate DerivativeEventDate
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventDate val = new QuickFix.Fields.DerivativeEventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    this.DerivativeEventDate = val;
                }
                
                public QuickFix.Fields.DerivativeEventDate Get(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    return IsSetDerivativeEventDate();
                }
                
                public bool IsSetDerivativeEventDate() 
                { 
                    return IsSetField(Tags.DerivativeEventDate);
                }
                public QuickFix.Fields.DerivativeEventTime DerivativeEventTime
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventTime val = new QuickFix.Fields.DerivativeEventTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    this.DerivativeEventTime = val;
                }
                
                public QuickFix.Fields.DerivativeEventTime Get(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    return IsSetDerivativeEventTime();
                }
                
                public bool IsSetDerivativeEventTime() 
                { 
                    return IsSetField(Tags.DerivativeEventTime);
                }
                public QuickFix.Fields.DerivativeEventPx DerivativeEventPx
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventPx val = new QuickFix.Fields.DerivativeEventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    this.DerivativeEventPx = val;
                }
                
                public QuickFix.Fields.DerivativeEventPx Get(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    return IsSetDerivativeEventPx();
                }
                
                public bool IsSetDerivativeEventPx() 
                { 
                    return IsSetField(Tags.DerivativeEventPx);
                }
                public QuickFix.Fields.DerivativeEventText DerivativeEventText
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventText val = new QuickFix.Fields.DerivativeEventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeEventText val) 
                { 
                    this.DerivativeEventText = val;
                }
                
                public QuickFix.Fields.DerivativeEventText Get(QuickFix.Fields.DerivativeEventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeEventText val) 
                { 
                    return IsSetDerivativeEventText();
                }
                
                public bool IsSetDerivativeEventText() 
                { 
                    return IsSetField(Tags.DerivativeEventText);
                }
            
            }
            public class NoDerivativeInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {Tags.DerivativeInstrumentPartyID, Tags.DerivativeInstrumentPartyIDSource, Tags.DerivativeInstrumentPartyRole, Tags.NoDerivativeInstrumentPartySubIDs, 0};
            
                public NoDerivativeInstrumentPartiesGroup() 
                  :base( Tags.NoDerivativeInstrumentParties, Tags.DerivativeInstrumentPartyID, fieldOrder)
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
                        QuickFix.Fields.DerivativeInstrumentPartyID val = new QuickFix.Fields.DerivativeInstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    this.DerivativeInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyID Get(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    return IsSetDerivativeInstrumentPartyID();
                }
                
                public bool IsSetDerivativeInstrumentPartyID() 
                { 
                    return IsSetField(Tags.DerivativeInstrumentPartyID);
                }
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource DerivativeInstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyIDSource val = new QuickFix.Fields.DerivativeInstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    this.DerivativeInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource Get(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    return IsSetDerivativeInstrumentPartyIDSource();
                }
                
                public bool IsSetDerivativeInstrumentPartyIDSource() 
                { 
                    return IsSetField(Tags.DerivativeInstrumentPartyIDSource);
                }
                public QuickFix.Fields.DerivativeInstrumentPartyRole DerivativeInstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyRole val = new QuickFix.Fields.DerivativeInstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    this.DerivativeInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyRole Get(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    return IsSetDerivativeInstrumentPartyRole();
                }
                
                public bool IsSetDerivativeInstrumentPartyRole() 
                { 
                    return IsSetField(Tags.DerivativeInstrumentPartyRole);
                }
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs NoDerivativeInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val = new QuickFix.Fields.NoDerivativeInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    this.NoDerivativeInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs Get(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    return IsSetNoDerivativeInstrumentPartySubIDs();
                }
                
                public bool IsSetNoDerivativeInstrumentPartySubIDs() 
                { 
                    return IsSetField(Tags.NoDerivativeInstrumentPartySubIDs);
                }
                            public class NoDerivativeInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.DerivativeInstrumentPartySubID, Tags.DerivativeInstrumentPartySubIDType, 0};
                
                    public NoDerivativeInstrumentPartySubIDsGroup() 
                      :base( Tags.NoDerivativeInstrumentPartySubIDs, Tags.DerivativeInstrumentPartySubID, fieldOrder)
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
                            QuickFix.Fields.DerivativeInstrumentPartySubID val = new QuickFix.Fields.DerivativeInstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        this.DerivativeInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubID Get(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        return IsSetDerivativeInstrumentPartySubID();
                    }
                    
                    public bool IsSetDerivativeInstrumentPartySubID() 
                    { 
                        return IsSetField(Tags.DerivativeInstrumentPartySubID);
                    }
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType DerivativeInstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.DerivativeInstrumentPartySubIDType val = new QuickFix.Fields.DerivativeInstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        this.DerivativeInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType Get(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        return IsSetDerivativeInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetDerivativeInstrumentPartySubIDType() 
                    { 
                        return IsSetField(Tags.DerivativeInstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoDerivativeInstrAttribGroup : Group
            {
                public static int[] fieldOrder = {Tags.DerivativeInstrAttribType, Tags.DerivativeInstrAttribValue, 0};
            
                public NoDerivativeInstrAttribGroup() 
                  :base( Tags.NoDerivativeInstrAttrib, Tags.DerivativeInstrAttribType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoDerivativeInstrAttribGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.DerivativeInstrAttribType DerivativeInstrAttribType
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrAttribType val = new QuickFix.Fields.DerivativeInstrAttribType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    this.DerivativeInstrAttribType = val;
                }
                
                public QuickFix.Fields.DerivativeInstrAttribType Get(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    return IsSetDerivativeInstrAttribType();
                }
                
                public bool IsSetDerivativeInstrAttribType() 
                { 
                    return IsSetField(Tags.DerivativeInstrAttribType);
                }
                public QuickFix.Fields.DerivativeInstrAttribValue DerivativeInstrAttribValue
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrAttribValue val = new QuickFix.Fields.DerivativeInstrAttribValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    this.DerivativeInstrAttribValue = val;
                }
                
                public QuickFix.Fields.DerivativeInstrAttribValue Get(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    return IsSetDerivativeInstrAttribValue();
                }
                
                public bool IsSetDerivativeInstrAttribValue() 
                { 
                    return IsSetField(Tags.DerivativeInstrAttribValue);
                }
            
            }
            public class NoMarketSegmentsGroup : Group
            {
                public static int[] fieldOrder = {Tags.MarketID, Tags.MarketSegmentID, Tags.NoTickRules, Tags.NoLotTypeRules, Tags.PriceLimitType, Tags.LowLimitPrice, Tags.HighLimitPrice, Tags.TradingReferencePrice, Tags.ExpirationCycle, Tags.MinTradeVol, Tags.MaxTradeVol, Tags.MaxPriceVariation, Tags.ImpliedMarketIndicator, Tags.TradingCurrency, Tags.RoundLot, Tags.MultilegModel, Tags.MultilegPriceMethod, Tags.PriceType, Tags.NoTradingSessionRules, Tags.NoNestedInstrAttrib, Tags.NoStrikeRules, 0};
            
                public NoMarketSegmentsGroup() 
                  :base( Tags.NoMarketSegments, Tags.MarketID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMarketSegmentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.MarketID MarketID
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
                    this.MarketID = val;
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
                public QuickFix.Fields.MarketSegmentID MarketSegmentID
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
                    this.MarketSegmentID = val;
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
                public QuickFix.Fields.NoTickRules NoTickRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoTickRules val = new QuickFix.Fields.NoTickRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTickRules val) 
                { 
                    this.NoTickRules = val;
                }
                
                public QuickFix.Fields.NoTickRules Get(QuickFix.Fields.NoTickRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTickRules val) 
                { 
                    return IsSetNoTickRules();
                }
                
                public bool IsSetNoTickRules() 
                { 
                    return IsSetField(Tags.NoTickRules);
                }
                public QuickFix.Fields.NoLotTypeRules NoLotTypeRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoLotTypeRules val = new QuickFix.Fields.NoLotTypeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    this.NoLotTypeRules = val;
                }
                
                public QuickFix.Fields.NoLotTypeRules Get(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    return IsSetNoLotTypeRules();
                }
                
                public bool IsSetNoLotTypeRules() 
                { 
                    return IsSetField(Tags.NoLotTypeRules);
                }
                public QuickFix.Fields.PriceLimitType PriceLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceLimitType val = new QuickFix.Fields.PriceLimitType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceLimitType val) 
                { 
                    this.PriceLimitType = val;
                }
                
                public QuickFix.Fields.PriceLimitType Get(QuickFix.Fields.PriceLimitType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceLimitType val) 
                { 
                    return IsSetPriceLimitType();
                }
                
                public bool IsSetPriceLimitType() 
                { 
                    return IsSetField(Tags.PriceLimitType);
                }
                public QuickFix.Fields.LowLimitPrice LowLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.LowLimitPrice val = new QuickFix.Fields.LowLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LowLimitPrice val) 
                { 
                    this.LowLimitPrice = val;
                }
                
                public QuickFix.Fields.LowLimitPrice Get(QuickFix.Fields.LowLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LowLimitPrice val) 
                { 
                    return IsSetLowLimitPrice();
                }
                
                public bool IsSetLowLimitPrice() 
                { 
                    return IsSetField(Tags.LowLimitPrice);
                }
                public QuickFix.Fields.HighLimitPrice HighLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.HighLimitPrice val = new QuickFix.Fields.HighLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.HighLimitPrice val) 
                { 
                    this.HighLimitPrice = val;
                }
                
                public QuickFix.Fields.HighLimitPrice Get(QuickFix.Fields.HighLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.HighLimitPrice val) 
                { 
                    return IsSetHighLimitPrice();
                }
                
                public bool IsSetHighLimitPrice() 
                { 
                    return IsSetField(Tags.HighLimitPrice);
                }
                public QuickFix.Fields.TradingReferencePrice TradingReferencePrice
                { 
                    get 
                    {
                        QuickFix.Fields.TradingReferencePrice val = new QuickFix.Fields.TradingReferencePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    this.TradingReferencePrice = val;
                }
                
                public QuickFix.Fields.TradingReferencePrice Get(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    return IsSetTradingReferencePrice();
                }
                
                public bool IsSetTradingReferencePrice() 
                { 
                    return IsSetField(Tags.TradingReferencePrice);
                }
                public QuickFix.Fields.ExpirationCycle ExpirationCycle
                { 
                    get 
                    {
                        QuickFix.Fields.ExpirationCycle val = new QuickFix.Fields.ExpirationCycle();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpirationCycle val) 
                { 
                    this.ExpirationCycle = val;
                }
                
                public QuickFix.Fields.ExpirationCycle Get(QuickFix.Fields.ExpirationCycle val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpirationCycle val) 
                { 
                    return IsSetExpirationCycle();
                }
                
                public bool IsSetExpirationCycle() 
                { 
                    return IsSetField(Tags.ExpirationCycle);
                }
                public QuickFix.Fields.MinTradeVol MinTradeVol
                { 
                    get 
                    {
                        QuickFix.Fields.MinTradeVol val = new QuickFix.Fields.MinTradeVol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinTradeVol val) 
                { 
                    this.MinTradeVol = val;
                }
                
                public QuickFix.Fields.MinTradeVol Get(QuickFix.Fields.MinTradeVol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinTradeVol val) 
                { 
                    return IsSetMinTradeVol();
                }
                
                public bool IsSetMinTradeVol() 
                { 
                    return IsSetField(Tags.MinTradeVol);
                }
                public QuickFix.Fields.MaxTradeVol MaxTradeVol
                { 
                    get 
                    {
                        QuickFix.Fields.MaxTradeVol val = new QuickFix.Fields.MaxTradeVol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxTradeVol val) 
                { 
                    this.MaxTradeVol = val;
                }
                
                public QuickFix.Fields.MaxTradeVol Get(QuickFix.Fields.MaxTradeVol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxTradeVol val) 
                { 
                    return IsSetMaxTradeVol();
                }
                
                public bool IsSetMaxTradeVol() 
                { 
                    return IsSetField(Tags.MaxTradeVol);
                }
                public QuickFix.Fields.MaxPriceVariation MaxPriceVariation
                { 
                    get 
                    {
                        QuickFix.Fields.MaxPriceVariation val = new QuickFix.Fields.MaxPriceVariation();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    this.MaxPriceVariation = val;
                }
                
                public QuickFix.Fields.MaxPriceVariation Get(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    return IsSetMaxPriceVariation();
                }
                
                public bool IsSetMaxPriceVariation() 
                { 
                    return IsSetField(Tags.MaxPriceVariation);
                }
                public QuickFix.Fields.ImpliedMarketIndicator ImpliedMarketIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.ImpliedMarketIndicator val = new QuickFix.Fields.ImpliedMarketIndicator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    this.ImpliedMarketIndicator = val;
                }
                
                public QuickFix.Fields.ImpliedMarketIndicator Get(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    return IsSetImpliedMarketIndicator();
                }
                
                public bool IsSetImpliedMarketIndicator() 
                { 
                    return IsSetField(Tags.ImpliedMarketIndicator);
                }
                public QuickFix.Fields.TradingCurrency TradingCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.TradingCurrency val = new QuickFix.Fields.TradingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingCurrency val) 
                { 
                    this.TradingCurrency = val;
                }
                
                public QuickFix.Fields.TradingCurrency Get(QuickFix.Fields.TradingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingCurrency val) 
                { 
                    return IsSetTradingCurrency();
                }
                
                public bool IsSetTradingCurrency() 
                { 
                    return IsSetField(Tags.TradingCurrency);
                }
                public QuickFix.Fields.RoundLot RoundLot
                { 
                    get 
                    {
                        QuickFix.Fields.RoundLot val = new QuickFix.Fields.RoundLot();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoundLot val) 
                { 
                    this.RoundLot = val;
                }
                
                public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoundLot val) 
                { 
                    return IsSetRoundLot();
                }
                
                public bool IsSetRoundLot() 
                { 
                    return IsSetField(Tags.RoundLot);
                }
                public QuickFix.Fields.MultilegModel MultilegModel
                { 
                    get 
                    {
                        QuickFix.Fields.MultilegModel val = new QuickFix.Fields.MultilegModel();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MultilegModel val) 
                { 
                    this.MultilegModel = val;
                }
                
                public QuickFix.Fields.MultilegModel Get(QuickFix.Fields.MultilegModel val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MultilegModel val) 
                { 
                    return IsSetMultilegModel();
                }
                
                public bool IsSetMultilegModel() 
                { 
                    return IsSetField(Tags.MultilegModel);
                }
                public QuickFix.Fields.MultilegPriceMethod MultilegPriceMethod
                { 
                    get 
                    {
                        QuickFix.Fields.MultilegPriceMethod val = new QuickFix.Fields.MultilegPriceMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    this.MultilegPriceMethod = val;
                }
                
                public QuickFix.Fields.MultilegPriceMethod Get(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    return IsSetMultilegPriceMethod();
                }
                
                public bool IsSetMultilegPriceMethod() 
                { 
                    return IsSetField(Tags.MultilegPriceMethod);
                }
                public QuickFix.Fields.PriceType PriceType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceType val) 
                { 
                    this.PriceType = val;
                }
                
                public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceType val) 
                { 
                    return IsSetPriceType();
                }
                
                public bool IsSetPriceType() 
                { 
                    return IsSetField(Tags.PriceType);
                }
                public QuickFix.Fields.NoTradingSessionRules NoTradingSessionRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoTradingSessionRules val = new QuickFix.Fields.NoTradingSessionRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    this.NoTradingSessionRules = val;
                }
                
                public QuickFix.Fields.NoTradingSessionRules Get(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    return IsSetNoTradingSessionRules();
                }
                
                public bool IsSetNoTradingSessionRules() 
                { 
                    return IsSetField(Tags.NoTradingSessionRules);
                }
                public QuickFix.Fields.NoNestedInstrAttrib NoNestedInstrAttrib
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedInstrAttrib val = new QuickFix.Fields.NoNestedInstrAttrib();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    this.NoNestedInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoNestedInstrAttrib Get(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    return IsSetNoNestedInstrAttrib();
                }
                
                public bool IsSetNoNestedInstrAttrib() 
                { 
                    return IsSetField(Tags.NoNestedInstrAttrib);
                }
                public QuickFix.Fields.NoStrikeRules NoStrikeRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoStrikeRules val = new QuickFix.Fields.NoStrikeRules();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoStrikeRules val) 
                { 
                    this.NoStrikeRules = val;
                }
                
                public QuickFix.Fields.NoStrikeRules Get(QuickFix.Fields.NoStrikeRules val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoStrikeRules val) 
                { 
                    return IsSetNoStrikeRules();
                }
                
                public bool IsSetNoStrikeRules() 
                { 
                    return IsSetField(Tags.NoStrikeRules);
                }
                            public class NoTickRulesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0};
                
                    public NoTickRulesGroup() 
                      :base( Tags.NoTickRules, Tags.StartTickPriceRange, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTickRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StartTickPriceRange StartTickPriceRange
                    { 
                        get 
                        {
                            QuickFix.Fields.StartTickPriceRange val = new QuickFix.Fields.StartTickPriceRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        this.StartTickPriceRange = val;
                    }
                    
                    public QuickFix.Fields.StartTickPriceRange Get(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        return IsSetStartTickPriceRange();
                    }
                    
                    public bool IsSetStartTickPriceRange() 
                    { 
                        return IsSetField(Tags.StartTickPriceRange);
                    }
                    public QuickFix.Fields.EndTickPriceRange EndTickPriceRange
                    { 
                        get 
                        {
                            QuickFix.Fields.EndTickPriceRange val = new QuickFix.Fields.EndTickPriceRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        this.EndTickPriceRange = val;
                    }
                    
                    public QuickFix.Fields.EndTickPriceRange Get(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        return IsSetEndTickPriceRange();
                    }
                    
                    public bool IsSetEndTickPriceRange() 
                    { 
                        return IsSetField(Tags.EndTickPriceRange);
                    }
                    public QuickFix.Fields.TickIncrement TickIncrement
                    { 
                        get 
                        {
                            QuickFix.Fields.TickIncrement val = new QuickFix.Fields.TickIncrement();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TickIncrement val) 
                    { 
                        this.TickIncrement = val;
                    }
                    
                    public QuickFix.Fields.TickIncrement Get(QuickFix.Fields.TickIncrement val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TickIncrement val) 
                    { 
                        return IsSetTickIncrement();
                    }
                    
                    public bool IsSetTickIncrement() 
                    { 
                        return IsSetField(Tags.TickIncrement);
                    }
                    public QuickFix.Fields.TickRuleType TickRuleType
                    { 
                        get 
                        {
                            QuickFix.Fields.TickRuleType val = new QuickFix.Fields.TickRuleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TickRuleType val) 
                    { 
                        this.TickRuleType = val;
                    }
                    
                    public QuickFix.Fields.TickRuleType Get(QuickFix.Fields.TickRuleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TickRuleType val) 
                    { 
                        return IsSetTickRuleType();
                    }
                    
                    public bool IsSetTickRuleType() 
                    { 
                        return IsSetField(Tags.TickRuleType);
                    }
                
                }
                public class NoLotTypeRulesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LotType, Tags.MinLotSize, 0};
                
                    public NoLotTypeRulesGroup() 
                      :base( Tags.NoLotTypeRules, Tags.LotType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLotTypeRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LotType LotType
                    { 
                        get 
                        {
                            QuickFix.Fields.LotType val = new QuickFix.Fields.LotType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LotType val) 
                    { 
                        this.LotType = val;
                    }
                    
                    public QuickFix.Fields.LotType Get(QuickFix.Fields.LotType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LotType val) 
                    { 
                        return IsSetLotType();
                    }
                    
                    public bool IsSetLotType() 
                    { 
                        return IsSetField(Tags.LotType);
                    }
                    public QuickFix.Fields.MinLotSize MinLotSize
                    { 
                        get 
                        {
                            QuickFix.Fields.MinLotSize val = new QuickFix.Fields.MinLotSize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MinLotSize val) 
                    { 
                        this.MinLotSize = val;
                    }
                    
                    public QuickFix.Fields.MinLotSize Get(QuickFix.Fields.MinLotSize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MinLotSize val) 
                    { 
                        return IsSetMinLotSize();
                    }
                    
                    public bool IsSetMinLotSize() 
                    { 
                        return IsSetField(Tags.MinLotSize);
                    }
                
                }
                public class NoTradingSessionRulesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, 0};
                
                    public NoTradingSessionRulesGroup() 
                      :base( Tags.NoTradingSessionRules, Tags.TradingSessionID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoTradingSessionRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.TradingSessionID TradingSessionID
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
                        this.TradingSessionID = val;
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
                    public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
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
                        this.TradingSessionSubID = val;
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
                    public QuickFix.Fields.NoOrdTypeRules NoOrdTypeRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        this.NoOrdTypeRules = val;
                    }
                    
                    public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        return IsSetNoOrdTypeRules();
                    }
                    
                    public bool IsSetNoOrdTypeRules() 
                    { 
                        return IsSetField(Tags.NoOrdTypeRules);
                    }
                    public QuickFix.Fields.NoTimeInForceRules NoTimeInForceRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        this.NoTimeInForceRules = val;
                    }
                    
                    public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        return IsSetNoTimeInForceRules();
                    }
                    
                    public bool IsSetNoTimeInForceRules() 
                    { 
                        return IsSetField(Tags.NoTimeInForceRules);
                    }
                    public QuickFix.Fields.NoExecInstRules NoExecInstRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        this.NoExecInstRules = val;
                    }
                    
                    public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        return IsSetNoExecInstRules();
                    }
                    
                    public bool IsSetNoExecInstRules() 
                    { 
                        return IsSetField(Tags.NoExecInstRules);
                    }
                    public QuickFix.Fields.NoMatchRules NoMatchRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoMatchRules val = new QuickFix.Fields.NoMatchRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMatchRules val) 
                    { 
                        this.NoMatchRules = val;
                    }
                    
                    public QuickFix.Fields.NoMatchRules Get(QuickFix.Fields.NoMatchRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMatchRules val) 
                    { 
                        return IsSetNoMatchRules();
                    }
                    
                    public bool IsSetNoMatchRules() 
                    { 
                        return IsSetField(Tags.NoMatchRules);
                    }
                    public QuickFix.Fields.NoMDFeedTypes NoMDFeedTypes
                    { 
                        get 
                        {
                            QuickFix.Fields.NoMDFeedTypes val = new QuickFix.Fields.NoMDFeedTypes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        this.NoMDFeedTypes = val;
                    }
                    
                    public QuickFix.Fields.NoMDFeedTypes Get(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        return IsSetNoMDFeedTypes();
                    }
                    
                    public bool IsSetNoMDFeedTypes() 
                    { 
                        return IsSetField(Tags.NoMDFeedTypes);
                    }
                                    public class NoOrdTypeRulesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.OrdType, 0};
                    
                        public NoOrdTypeRulesGroup() 
                          :base( Tags.NoOrdTypeRules, Tags.OrdType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoOrdTypeRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.OrdType OrdType
                        { 
                            get 
                            {
                                QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.OrdType val) 
                        { 
                            this.OrdType = val;
                        }
                        
                        public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.OrdType val) 
                        { 
                            return IsSetOrdType();
                        }
                        
                        public bool IsSetOrdType() 
                        { 
                            return IsSetField(Tags.OrdType);
                        }
                    
                    }
                    public class NoTimeInForceRulesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.TimeInForce, 0};
                    
                        public NoTimeInForceRulesGroup() 
                          :base( Tags.NoTimeInForceRules, Tags.TimeInForce, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoTimeInForceRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.TimeInForce TimeInForce
                        { 
                            get 
                            {
                                QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.TimeInForce val) 
                        { 
                            this.TimeInForce = val;
                        }
                        
                        public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.TimeInForce val) 
                        { 
                            return IsSetTimeInForce();
                        }
                        
                        public bool IsSetTimeInForce() 
                        { 
                            return IsSetField(Tags.TimeInForce);
                        }
                    
                    }
                    public class NoExecInstRulesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.ExecInstValue, 0};
                    
                        public NoExecInstRulesGroup() 
                          :base( Tags.NoExecInstRules, Tags.ExecInstValue, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoExecInstRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.ExecInstValue ExecInstValue
                        { 
                            get 
                            {
                                QuickFix.Fields.ExecInstValue val = new QuickFix.Fields.ExecInstValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ExecInstValue val) 
                        { 
                            this.ExecInstValue = val;
                        }
                        
                        public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ExecInstValue val) 
                        { 
                            return IsSetExecInstValue();
                        }
                        
                        public bool IsSetExecInstValue() 
                        { 
                            return IsSetField(Tags.ExecInstValue);
                        }
                    
                    }
                    public class NoMatchRulesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.MatchAlgorithm, Tags.MatchType, 0};
                    
                        public NoMatchRulesGroup() 
                          :base( Tags.NoMatchRules, Tags.MatchAlgorithm, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMatchRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MatchAlgorithm MatchAlgorithm
                        { 
                            get 
                            {
                                QuickFix.Fields.MatchAlgorithm val = new QuickFix.Fields.MatchAlgorithm();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            this.MatchAlgorithm = val;
                        }
                        
                        public QuickFix.Fields.MatchAlgorithm Get(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            return IsSetMatchAlgorithm();
                        }
                        
                        public bool IsSetMatchAlgorithm() 
                        { 
                            return IsSetField(Tags.MatchAlgorithm);
                        }
                        public QuickFix.Fields.MatchType MatchType
                        { 
                            get 
                            {
                                QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MatchType val) 
                        { 
                            this.MatchType = val;
                        }
                        
                        public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MatchType val) 
                        { 
                            return IsSetMatchType();
                        }
                        
                        public bool IsSetMatchType() 
                        { 
                            return IsSetField(Tags.MatchType);
                        }
                    
                    }
                    public class NoMDFeedTypesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0};
                    
                        public NoMDFeedTypesGroup() 
                          :base( Tags.NoMDFeedTypes, Tags.MDFeedType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMDFeedTypesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MDFeedType MDFeedType
                        { 
                            get 
                            {
                                QuickFix.Fields.MDFeedType val = new QuickFix.Fields.MDFeedType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MDFeedType val) 
                        { 
                            this.MDFeedType = val;
                        }
                        
                        public QuickFix.Fields.MDFeedType Get(QuickFix.Fields.MDFeedType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MDFeedType val) 
                        { 
                            return IsSetMDFeedType();
                        }
                        
                        public bool IsSetMDFeedType() 
                        { 
                            return IsSetField(Tags.MDFeedType);
                        }
                        public QuickFix.Fields.MarketDepth MarketDepth
                        { 
                            get 
                            {
                                QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MarketDepth val) 
                        { 
                            this.MarketDepth = val;
                        }
                        
                        public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MarketDepth val) 
                        { 
                            return IsSetMarketDepth();
                        }
                        
                        public bool IsSetMarketDepth() 
                        { 
                            return IsSetField(Tags.MarketDepth);
                        }
                        public QuickFix.Fields.MDBookType MDBookType
                        { 
                            get 
                            {
                                QuickFix.Fields.MDBookType val = new QuickFix.Fields.MDBookType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MDBookType val) 
                        { 
                            this.MDBookType = val;
                        }
                        
                        public QuickFix.Fields.MDBookType Get(QuickFix.Fields.MDBookType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MDBookType val) 
                        { 
                            return IsSetMDBookType();
                        }
                        
                        public bool IsSetMDBookType() 
                        { 
                            return IsSetField(Tags.MDBookType);
                        }
                    
                    }
                }
                public class NoNestedInstrAttribGroup : Group
                {
                    public static int[] fieldOrder = {Tags.NestedInstrAttribType, Tags.NestedInstrAttribValue, 0};
                
                    public NoNestedInstrAttribGroup() 
                      :base( Tags.NoNestedInstrAttrib, Tags.NestedInstrAttribType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedInstrAttribGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedInstrAttribType NestedInstrAttribType
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedInstrAttribType val = new QuickFix.Fields.NestedInstrAttribType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        this.NestedInstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribType Get(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        return IsSetNestedInstrAttribType();
                    }
                    
                    public bool IsSetNestedInstrAttribType() 
                    { 
                        return IsSetField(Tags.NestedInstrAttribType);
                    }
                    public QuickFix.Fields.NestedInstrAttribValue NestedInstrAttribValue
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedInstrAttribValue val = new QuickFix.Fields.NestedInstrAttribValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        this.NestedInstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribValue Get(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        return IsSetNestedInstrAttribValue();
                    }
                    
                    public bool IsSetNestedInstrAttribValue() 
                    { 
                        return IsSetField(Tags.NestedInstrAttribValue);
                    }
                
                }
                public class NoStrikeRulesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.StrikeRuleID, Tags.StartStrikePxRange, Tags.EndStrikePxRange, Tags.StrikeIncrement, Tags.StrikeExerciseStyle, Tags.NoMaturityRules, 0};
                
                    public NoStrikeRulesGroup() 
                      :base( Tags.NoStrikeRules, Tags.StrikeRuleID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoStrikeRulesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.StrikeRuleID StrikeRuleID
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeRuleID val = new QuickFix.Fields.StrikeRuleID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        this.StrikeRuleID = val;
                    }
                    
                    public QuickFix.Fields.StrikeRuleID Get(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        return IsSetStrikeRuleID();
                    }
                    
                    public bool IsSetStrikeRuleID() 
                    { 
                        return IsSetField(Tags.StrikeRuleID);
                    }
                    public QuickFix.Fields.StartStrikePxRange StartStrikePxRange
                    { 
                        get 
                        {
                            QuickFix.Fields.StartStrikePxRange val = new QuickFix.Fields.StartStrikePxRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        this.StartStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.StartStrikePxRange Get(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        return IsSetStartStrikePxRange();
                    }
                    
                    public bool IsSetStartStrikePxRange() 
                    { 
                        return IsSetField(Tags.StartStrikePxRange);
                    }
                    public QuickFix.Fields.EndStrikePxRange EndStrikePxRange
                    { 
                        get 
                        {
                            QuickFix.Fields.EndStrikePxRange val = new QuickFix.Fields.EndStrikePxRange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        this.EndStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.EndStrikePxRange Get(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        return IsSetEndStrikePxRange();
                    }
                    
                    public bool IsSetEndStrikePxRange() 
                    { 
                        return IsSetField(Tags.EndStrikePxRange);
                    }
                    public QuickFix.Fields.StrikeIncrement StrikeIncrement
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeIncrement val = new QuickFix.Fields.StrikeIncrement();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        this.StrikeIncrement = val;
                    }
                    
                    public QuickFix.Fields.StrikeIncrement Get(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        return IsSetStrikeIncrement();
                    }
                    
                    public bool IsSetStrikeIncrement() 
                    { 
                        return IsSetField(Tags.StrikeIncrement);
                    }
                    public QuickFix.Fields.StrikeExerciseStyle StrikeExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeExerciseStyle val = new QuickFix.Fields.StrikeExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        this.StrikeExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.StrikeExerciseStyle Get(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        return IsSetStrikeExerciseStyle();
                    }
                    
                    public bool IsSetStrikeExerciseStyle() 
                    { 
                        return IsSetField(Tags.StrikeExerciseStyle);
                    }
                    public QuickFix.Fields.NoMaturityRules NoMaturityRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoMaturityRules val = new QuickFix.Fields.NoMaturityRules();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        this.NoMaturityRules = val;
                    }
                    
                    public QuickFix.Fields.NoMaturityRules Get(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        return IsSetNoMaturityRules();
                    }
                    
                    public bool IsSetNoMaturityRules() 
                    { 
                        return IsSetField(Tags.NoMaturityRules);
                    }
                                    public class NoMaturityRulesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.MaturityRuleID, Tags.MaturityMonthYearFormat, Tags.MaturityMonthYearIncrementUnits, Tags.StartMaturityMonthYear, Tags.EndMaturityMonthYear, Tags.MaturityMonthYearIncrement, 0};
                    
                        public NoMaturityRulesGroup() 
                          :base( Tags.NoMaturityRules, Tags.MaturityRuleID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoMaturityRulesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.MaturityRuleID MaturityRuleID
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityRuleID val = new QuickFix.Fields.MaturityRuleID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            this.MaturityRuleID = val;
                        }
                        
                        public QuickFix.Fields.MaturityRuleID Get(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            return IsSetMaturityRuleID();
                        }
                        
                        public bool IsSetMaturityRuleID() 
                        { 
                            return IsSetField(Tags.MaturityRuleID);
                        }
                        public QuickFix.Fields.MaturityMonthYearFormat MaturityMonthYearFormat
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityMonthYearFormat val = new QuickFix.Fields.MaturityMonthYearFormat();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            this.MaturityMonthYearFormat = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearFormat Get(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            return IsSetMaturityMonthYearFormat();
                        }
                        
                        public bool IsSetMaturityMonthYearFormat() 
                        { 
                            return IsSetField(Tags.MaturityMonthYearFormat);
                        }
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits MaturityMonthYearIncrementUnits
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityMonthYearIncrementUnits val = new QuickFix.Fields.MaturityMonthYearIncrementUnits();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            this.MaturityMonthYearIncrementUnits = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits Get(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            return IsSetMaturityMonthYearIncrementUnits();
                        }
                        
                        public bool IsSetMaturityMonthYearIncrementUnits() 
                        { 
                            return IsSetField(Tags.MaturityMonthYearIncrementUnits);
                        }
                        public QuickFix.Fields.StartMaturityMonthYear StartMaturityMonthYear
                        { 
                            get 
                            {
                                QuickFix.Fields.StartMaturityMonthYear val = new QuickFix.Fields.StartMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            this.StartMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.StartMaturityMonthYear Get(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            return IsSetStartMaturityMonthYear();
                        }
                        
                        public bool IsSetStartMaturityMonthYear() 
                        { 
                            return IsSetField(Tags.StartMaturityMonthYear);
                        }
                        public QuickFix.Fields.EndMaturityMonthYear EndMaturityMonthYear
                        { 
                            get 
                            {
                                QuickFix.Fields.EndMaturityMonthYear val = new QuickFix.Fields.EndMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            this.EndMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.EndMaturityMonthYear Get(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            return IsSetEndMaturityMonthYear();
                        }
                        
                        public bool IsSetEndMaturityMonthYear() 
                        { 
                            return IsSetField(Tags.EndMaturityMonthYear);
                        }
                        public QuickFix.Fields.MaturityMonthYearIncrement MaturityMonthYearIncrement
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityMonthYearIncrement val = new QuickFix.Fields.MaturityMonthYearIncrement();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            this.MaturityMonthYearIncrement = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrement Get(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            return IsSetMaturityMonthYearIncrement();
                        }
                        
                        public bool IsSetMaturityMonthYearIncrement() 
                        { 
                            return IsSetField(Tags.MaturityMonthYearIncrement);
                        }
                    
                    }
                }
            }
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {Tags.ListUpdateAction, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.DeliveryForm, Tags.PctAtRisk, Tags.NoInstrAttrib, Tags.SecondaryPriceLimitType, Tags.SecondaryLowLimitPrice, Tags.SecondaryHighLimitPrice, Tags.SecondaryTradingReferencePrice, Tags.Currency, Tags.NoLegs, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.CorporateAction, 0};
            
                public NoRelatedSymGroup() 
                  :base( Tags.NoRelatedSym, Tags.ListUpdateAction, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ListUpdateAction ListUpdateAction
                { 
                    get 
                    {
                        QuickFix.Fields.ListUpdateAction val = new QuickFix.Fields.ListUpdateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListUpdateAction val) 
                { 
                    this.ListUpdateAction = val;
                }
                
                public QuickFix.Fields.ListUpdateAction Get(QuickFix.Fields.ListUpdateAction val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListUpdateAction val) 
                { 
                    return IsSetListUpdateAction();
                }
                
                public bool IsSetListUpdateAction() 
                { 
                    return IsSetField(Tags.ListUpdateAction);
                }
                public QuickFix.Fields.Symbol Symbol
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
                    this.Symbol = val;
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
                public QuickFix.Fields.SymbolSfx SymbolSfx
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
                    this.SymbolSfx = val;
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
                public QuickFix.Fields.SecurityID SecurityID
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
                    this.SecurityID = val;
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
                public QuickFix.Fields.SecurityIDSource SecurityIDSource
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
                    this.SecurityIDSource = val;
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
                public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
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
                    this.NoSecurityAltID = val;
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
                public QuickFix.Fields.Product Product
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
                    this.Product = val;
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
                public QuickFix.Fields.CFICode CFICode
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
                    this.CFICode = val;
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
                public QuickFix.Fields.SecurityType SecurityType
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
                    this.SecurityType = val;
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
                public QuickFix.Fields.SecuritySubType SecuritySubType
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
                    this.SecuritySubType = val;
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
                public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
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
                    this.MaturityMonthYear = val;
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
                public QuickFix.Fields.MaturityDate MaturityDate
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
                    this.MaturityDate = val;
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
                public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
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
                    this.CouponPaymentDate = val;
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
                public QuickFix.Fields.IssueDate IssueDate
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
                    this.IssueDate = val;
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
                public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
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
                    this.RepoCollateralSecurityType = val;
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
                public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
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
                    this.RepurchaseTerm = val;
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
                public QuickFix.Fields.RepurchaseRate RepurchaseRate
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
                    this.RepurchaseRate = val;
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
                public QuickFix.Fields.Factor Factor
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
                    this.Factor = val;
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
                public QuickFix.Fields.CreditRating CreditRating
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
                    this.CreditRating = val;
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
                public QuickFix.Fields.InstrRegistry InstrRegistry
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
                    this.InstrRegistry = val;
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
                public QuickFix.Fields.CountryOfIssue CountryOfIssue
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
                    this.CountryOfIssue = val;
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
                public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
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
                    this.StateOrProvinceOfIssue = val;
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
                public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
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
                    this.LocaleOfIssue = val;
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
                public QuickFix.Fields.RedemptionDate RedemptionDate
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
                    this.RedemptionDate = val;
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
                public QuickFix.Fields.StrikePrice StrikePrice
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
                    this.StrikePrice = val;
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
                public QuickFix.Fields.StrikeCurrency StrikeCurrency
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
                    this.StrikeCurrency = val;
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
                public QuickFix.Fields.OptAttribute OptAttribute
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
                    this.OptAttribute = val;
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
                public QuickFix.Fields.ContractMultiplier ContractMultiplier
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
                    this.ContractMultiplier = val;
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
                public QuickFix.Fields.CouponRate CouponRate
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
                    this.CouponRate = val;
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
                public QuickFix.Fields.SecurityExchange SecurityExchange
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
                    this.SecurityExchange = val;
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
                public QuickFix.Fields.Issuer Issuer
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
                    this.Issuer = val;
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
                public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
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
                    this.EncodedIssuerLen = val;
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
                public QuickFix.Fields.EncodedIssuer EncodedIssuer
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
                    this.EncodedIssuer = val;
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
                public QuickFix.Fields.SecurityDesc SecurityDesc
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
                    this.SecurityDesc = val;
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
                public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
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
                    this.EncodedSecurityDescLen = val;
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
                public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
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
                    this.EncodedSecurityDesc = val;
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
                public QuickFix.Fields.Pool Pool
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
                    this.Pool = val;
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
                public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
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
                    this.ContractSettlMonth = val;
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
                public QuickFix.Fields.CPProgram CPProgram
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
                    this.CPProgram = val;
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
                public QuickFix.Fields.CPRegType CPRegType
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
                    this.CPRegType = val;
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
                public QuickFix.Fields.NoEvents NoEvents
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
                    this.NoEvents = val;
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
                public QuickFix.Fields.DatedDate DatedDate
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
                    this.DatedDate = val;
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
                public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
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
                    this.InterestAccrualDate = val;
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
                public QuickFix.Fields.SecurityStatus SecurityStatus
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
                    this.SecurityStatus = val;
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
                public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
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
                    this.SettleOnOpenFlag = val;
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
                public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
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
                    this.InstrmtAssignmentMethod = val;
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
                public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
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
                    this.StrikeMultiplier = val;
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
                public QuickFix.Fields.StrikeValue StrikeValue
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
                    this.StrikeValue = val;
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
                public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
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
                    this.MinPriceIncrement = val;
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
                public QuickFix.Fields.PositionLimit PositionLimit
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
                    this.PositionLimit = val;
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
                public QuickFix.Fields.NTPositionLimit NTPositionLimit
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
                    this.NTPositionLimit = val;
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
                public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
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
                    this.NoInstrumentParties = val;
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
                public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
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
                    this.UnitOfMeasure = val;
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
                public QuickFix.Fields.TimeUnit TimeUnit
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
                    this.TimeUnit = val;
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
                public QuickFix.Fields.MaturityTime MaturityTime
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
                    this.MaturityTime = val;
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
                public QuickFix.Fields.SecurityGroup SecurityGroup
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
                    this.SecurityGroup = val;
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
                public QuickFix.Fields.MinPriceIncrementAmount MinPriceIncrementAmount
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
                    this.MinPriceIncrementAmount = val;
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
                public QuickFix.Fields.UnitOfMeasureQty UnitOfMeasureQty
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
                    this.UnitOfMeasureQty = val;
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
                public QuickFix.Fields.SecurityXMLLen SecurityXMLLen
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
                    this.SecurityXMLLen = val;
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
                public QuickFix.Fields.SecurityXML SecurityXML
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
                    this.SecurityXML = val;
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
                public QuickFix.Fields.SecurityXMLSchema SecurityXMLSchema
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
                    this.SecurityXMLSchema = val;
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
                public QuickFix.Fields.ProductComplex ProductComplex
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
                    this.ProductComplex = val;
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
                public QuickFix.Fields.PriceUnitOfMeasure PriceUnitOfMeasure
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
                    this.PriceUnitOfMeasure = val;
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
                public QuickFix.Fields.PriceUnitOfMeasureQty PriceUnitOfMeasureQty
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
                    this.PriceUnitOfMeasureQty = val;
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
                public QuickFix.Fields.SettlMethod SettlMethod
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
                    this.SettlMethod = val;
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
                public QuickFix.Fields.ExerciseStyle ExerciseStyle
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
                    this.ExerciseStyle = val;
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
                public QuickFix.Fields.OptPayAmount OptPayAmount
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
                    this.OptPayAmount = val;
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
                public QuickFix.Fields.PriceQuoteMethod PriceQuoteMethod
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
                    this.PriceQuoteMethod = val;
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
                public QuickFix.Fields.ListMethod ListMethod
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
                    this.ListMethod = val;
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
                public QuickFix.Fields.CapPrice CapPrice
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
                    this.CapPrice = val;
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
                public QuickFix.Fields.FloorPrice FloorPrice
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
                    this.FloorPrice = val;
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
                public QuickFix.Fields.PutOrCall PutOrCall
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
                    this.PutOrCall = val;
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
                public QuickFix.Fields.FlexibleIndicator FlexibleIndicator
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
                    this.FlexibleIndicator = val;
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
                public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
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
                    this.FlexProductEligibilityIndicator = val;
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
                public QuickFix.Fields.FuturesValuationMethod FuturesValuationMethod
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
                    this.FuturesValuationMethod = val;
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
                public QuickFix.Fields.DeliveryForm DeliveryForm
                { 
                    get 
                    {
                        QuickFix.Fields.DeliveryForm val = new QuickFix.Fields.DeliveryForm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeliveryForm val) 
                { 
                    this.DeliveryForm = val;
                }
                
                public QuickFix.Fields.DeliveryForm Get(QuickFix.Fields.DeliveryForm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeliveryForm val) 
                { 
                    return IsSetDeliveryForm();
                }
                
                public bool IsSetDeliveryForm() 
                { 
                    return IsSetField(Tags.DeliveryForm);
                }
                public QuickFix.Fields.PctAtRisk PctAtRisk
                { 
                    get 
                    {
                        QuickFix.Fields.PctAtRisk val = new QuickFix.Fields.PctAtRisk();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PctAtRisk val) 
                { 
                    this.PctAtRisk = val;
                }
                
                public QuickFix.Fields.PctAtRisk Get(QuickFix.Fields.PctAtRisk val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PctAtRisk val) 
                { 
                    return IsSetPctAtRisk();
                }
                
                public bool IsSetPctAtRisk() 
                { 
                    return IsSetField(Tags.PctAtRisk);
                }
                public QuickFix.Fields.NoInstrAttrib NoInstrAttrib
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrAttrib val = new QuickFix.Fields.NoInstrAttrib();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    this.NoInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoInstrAttrib Get(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    return IsSetNoInstrAttrib();
                }
                
                public bool IsSetNoInstrAttrib() 
                { 
                    return IsSetField(Tags.NoInstrAttrib);
                }
                public QuickFix.Fields.SecondaryPriceLimitType SecondaryPriceLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryPriceLimitType val = new QuickFix.Fields.SecondaryPriceLimitType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    this.SecondaryPriceLimitType = val;
                }
                
                public QuickFix.Fields.SecondaryPriceLimitType Get(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    return IsSetSecondaryPriceLimitType();
                }
                
                public bool IsSetSecondaryPriceLimitType() 
                { 
                    return IsSetField(Tags.SecondaryPriceLimitType);
                }
                public QuickFix.Fields.SecondaryLowLimitPrice SecondaryLowLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryLowLimitPrice val = new QuickFix.Fields.SecondaryLowLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    this.SecondaryLowLimitPrice = val;
                }
                
                public QuickFix.Fields.SecondaryLowLimitPrice Get(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    return IsSetSecondaryLowLimitPrice();
                }
                
                public bool IsSetSecondaryLowLimitPrice() 
                { 
                    return IsSetField(Tags.SecondaryLowLimitPrice);
                }
                public QuickFix.Fields.SecondaryHighLimitPrice SecondaryHighLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryHighLimitPrice val = new QuickFix.Fields.SecondaryHighLimitPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    this.SecondaryHighLimitPrice = val;
                }
                
                public QuickFix.Fields.SecondaryHighLimitPrice Get(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    return IsSetSecondaryHighLimitPrice();
                }
                
                public bool IsSetSecondaryHighLimitPrice() 
                { 
                    return IsSetField(Tags.SecondaryHighLimitPrice);
                }
                public QuickFix.Fields.SecondaryTradingReferencePrice SecondaryTradingReferencePrice
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryTradingReferencePrice val = new QuickFix.Fields.SecondaryTradingReferencePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    this.SecondaryTradingReferencePrice = val;
                }
                
                public QuickFix.Fields.SecondaryTradingReferencePrice Get(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    return IsSetSecondaryTradingReferencePrice();
                }
                
                public bool IsSetSecondaryTradingReferencePrice() 
                { 
                    return IsSetField(Tags.SecondaryTradingReferencePrice);
                }
                public QuickFix.Fields.Currency Currency
                { 
                    get 
                    {
                        QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Currency val) 
                { 
                    this.Currency = val;
                }
                
                public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Currency val) 
                { 
                    return IsSetCurrency();
                }
                
                public bool IsSetCurrency() 
                { 
                    return IsSetField(Tags.Currency);
                }
                public QuickFix.Fields.NoLegs NoLegs
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegs val) 
                { 
                    this.NoLegs = val;
                }
                
                public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegs val) 
                { 
                    return IsSetNoLegs();
                }
                
                public bool IsSetNoLegs() 
                { 
                    return IsSetField(Tags.NoLegs);
                }
                public QuickFix.Fields.Text Text
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
                    this.Text = val;
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
                public QuickFix.Fields.EncodedTextLen EncodedTextLen
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
                    this.EncodedTextLen = val;
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
                public QuickFix.Fields.EncodedText EncodedText
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
                    this.EncodedText = val;
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
                public QuickFix.Fields.CorporateAction CorporateAction
                { 
                    get 
                    {
                        QuickFix.Fields.CorporateAction val = new QuickFix.Fields.CorporateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CorporateAction val) 
                { 
                    this.CorporateAction = val;
                }
                
                public QuickFix.Fields.CorporateAction Get(QuickFix.Fields.CorporateAction val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CorporateAction val) 
                { 
                    return IsSetCorporateAction();
                }
                
                public bool IsSetCorporateAction() 
                { 
                    return IsSetField(Tags.CorporateAction);
                }
                            public class NoSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                
                    public NoSecurityAltIDGroup() 
                      :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
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
                            QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityAltID val) 
                    { 
                        this.SecurityAltID = val;
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
                    public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
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
                        this.SecurityAltIDSource = val;
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
                public class NoEventsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                
                    public NoEventsGroup() 
                      :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoEventsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.EventType EventType
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
                        this.EventType = val;
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
                    public QuickFix.Fields.EventDate EventDate
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
                        this.EventDate = val;
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
                    public QuickFix.Fields.EventPx EventPx
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
                        this.EventPx = val;
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
                    public QuickFix.Fields.EventText EventText
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
                        this.EventText = val;
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
                    public QuickFix.Fields.EventTime EventTime
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
                        this.EventTime = val;
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
                public class NoInstrumentPartiesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                
                    public NoInstrumentPartiesGroup() 
                      :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrumentPartiesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
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
                        this.InstrumentPartyID = val;
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
                    public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
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
                        this.InstrumentPartyIDSource = val;
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
                    public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
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
                        this.InstrumentPartyRole = val;
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
                    public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
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
                        this.NoInstrumentPartySubIDs = val;
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
                                    public class NoInstrumentPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                    
                        public NoInstrumentPartySubIDsGroup() 
                          :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoInstrumentPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
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
                            this.InstrumentPartySubID = val;
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
                        public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
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
                            this.InstrumentPartySubIDType = val;
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
                public class NoInstrAttribGroup : Group
                {
                    public static int[] fieldOrder = {Tags.InstrAttribType, Tags.InstrAttribValue, 0};
                
                    public NoInstrAttribGroup() 
                      :base( Tags.NoInstrAttrib, Tags.InstrAttribType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrAttribGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrAttribType InstrAttribType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrAttribType val = new QuickFix.Fields.InstrAttribType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrAttribType val) 
                    { 
                        this.InstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribType Get(QuickFix.Fields.InstrAttribType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrAttribType val) 
                    { 
                        return IsSetInstrAttribType();
                    }
                    
                    public bool IsSetInstrAttribType() 
                    { 
                        return IsSetField(Tags.InstrAttribType);
                    }
                    public QuickFix.Fields.InstrAttribValue InstrAttribValue
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrAttribValue val = new QuickFix.Fields.InstrAttribValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        this.InstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribValue Get(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        return IsSetInstrAttribValue();
                    }
                    
                    public bool IsSetInstrAttribValue() 
                    { 
                        return IsSetField(Tags.InstrAttribValue);
                    }
                
                }
                public class NoLegsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, 0};
                
                    public NoLegsGroup() 
                      :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
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
                            QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSymbol val) 
                    { 
                        this.LegSymbol = val;
                    }
                    
                    public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSymbol val) 
                    { 
                        return IsSetLegSymbol();
                    }
                    
                    public bool IsSetLegSymbol() 
                    { 
                        return IsSetField(Tags.LegSymbol);
                    }
                    public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        this.LegSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        return IsSetLegSymbolSfx();
                    }
                    
                    public bool IsSetLegSymbolSfx() 
                    { 
                        return IsSetField(Tags.LegSymbolSfx);
                    }
                    public QuickFix.Fields.LegSecurityID LegSecurityID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityID val) 
                    { 
                        this.LegSecurityID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                    { 
                        return IsSetLegSecurityID();
                    }
                    
                    public bool IsSetLegSecurityID() 
                    { 
                        return IsSetField(Tags.LegSecurityID);
                    }
                    public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        this.LegSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        return IsSetLegSecurityIDSource();
                    }
                    
                    public bool IsSetLegSecurityIDSource() 
                    { 
                        return IsSetField(Tags.LegSecurityIDSource);
                    }
                    public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        this.NoLegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        return IsSetNoLegSecurityAltID();
                    }
                    
                    public bool IsSetNoLegSecurityAltID() 
                    { 
                        return IsSetField(Tags.NoLegSecurityAltID);
                    }
                    public QuickFix.Fields.LegProduct LegProduct
                    { 
                        get 
                        {
                            QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegProduct val) 
                    { 
                        this.LegProduct = val;
                    }
                    
                    public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegProduct val) 
                    { 
                        return IsSetLegProduct();
                    }
                    
                    public bool IsSetLegProduct() 
                    { 
                        return IsSetField(Tags.LegProduct);
                    }
                    public QuickFix.Fields.LegCFICode LegCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCFICode val) 
                    { 
                        this.LegCFICode = val;
                    }
                    
                    public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCFICode val) 
                    { 
                        return IsSetLegCFICode();
                    }
                    
                    public bool IsSetLegCFICode() 
                    { 
                        return IsSetField(Tags.LegCFICode);
                    }
                    public QuickFix.Fields.LegSecurityType LegSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityType val) 
                    { 
                        this.LegSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                    { 
                        return IsSetLegSecurityType();
                    }
                    
                    public bool IsSetLegSecurityType() 
                    { 
                        return IsSetField(Tags.LegSecurityType);
                    }
                    public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        this.LegSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        return IsSetLegSecuritySubType();
                    }
                    
                    public bool IsSetLegSecuritySubType() 
                    { 
                        return IsSetField(Tags.LegSecuritySubType);
                    }
                    public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        this.LegMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        return IsSetLegMaturityMonthYear();
                    }
                    
                    public bool IsSetLegMaturityMonthYear() 
                    { 
                        return IsSetField(Tags.LegMaturityMonthYear);
                    }
                    public QuickFix.Fields.LegMaturityDate LegMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        this.LegMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        return IsSetLegMaturityDate();
                    }
                    
                    public bool IsSetLegMaturityDate() 
                    { 
                        return IsSetField(Tags.LegMaturityDate);
                    }
                    public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        this.LegCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        return IsSetLegCouponPaymentDate();
                    }
                    
                    public bool IsSetLegCouponPaymentDate() 
                    { 
                        return IsSetField(Tags.LegCouponPaymentDate);
                    }
                    public QuickFix.Fields.LegIssueDate LegIssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIssueDate val) 
                    { 
                        this.LegIssueDate = val;
                    }
                    
                    public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                    { 
                        return IsSetLegIssueDate();
                    }
                    
                    public bool IsSetLegIssueDate() 
                    { 
                        return IsSetField(Tags.LegIssueDate);
                    }
                    public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        this.LegRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        return IsSetLegRepoCollateralSecurityType();
                    }
                    
                    public bool IsSetLegRepoCollateralSecurityType() 
                    { 
                        return IsSetField(Tags.LegRepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        this.LegRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        return IsSetLegRepurchaseTerm();
                    }
                    
                    public bool IsSetLegRepurchaseTerm() 
                    { 
                        return IsSetField(Tags.LegRepurchaseTerm);
                    }
                    public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        this.LegRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        return IsSetLegRepurchaseRate();
                    }
                    
                    public bool IsSetLegRepurchaseRate() 
                    { 
                        return IsSetField(Tags.LegRepurchaseRate);
                    }
                    public QuickFix.Fields.LegFactor LegFactor
                    { 
                        get 
                        {
                            QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegFactor val) 
                    { 
                        this.LegFactor = val;
                    }
                    
                    public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegFactor val) 
                    { 
                        return IsSetLegFactor();
                    }
                    
                    public bool IsSetLegFactor() 
                    { 
                        return IsSetField(Tags.LegFactor);
                    }
                    public QuickFix.Fields.LegCreditRating LegCreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCreditRating val) 
                    { 
                        this.LegCreditRating = val;
                    }
                    
                    public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                    { 
                        return IsSetLegCreditRating();
                    }
                    
                    public bool IsSetLegCreditRating() 
                    { 
                        return IsSetField(Tags.LegCreditRating);
                    }
                    public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        this.LegInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        return IsSetLegInstrRegistry();
                    }
                    
                    public bool IsSetLegInstrRegistry() 
                    { 
                        return IsSetField(Tags.LegInstrRegistry);
                    }
                    public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        this.LegCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        return IsSetLegCountryOfIssue();
                    }
                    
                    public bool IsSetLegCountryOfIssue() 
                    { 
                        return IsSetField(Tags.LegCountryOfIssue);
                    }
                    public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        this.LegStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        return IsSetLegStateOrProvinceOfIssue();
                    }
                    
                    public bool IsSetLegStateOrProvinceOfIssue() 
                    { 
                        return IsSetField(Tags.LegStateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        this.LegLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        return IsSetLegLocaleOfIssue();
                    }
                    
                    public bool IsSetLegLocaleOfIssue() 
                    { 
                        return IsSetField(Tags.LegLocaleOfIssue);
                    }
                    public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        this.LegRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        return IsSetLegRedemptionDate();
                    }
                    
                    public bool IsSetLegRedemptionDate() 
                    { 
                        return IsSetField(Tags.LegRedemptionDate);
                    }
                    public QuickFix.Fields.LegStrikePrice LegStrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        this.LegStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        return IsSetLegStrikePrice();
                    }
                    
                    public bool IsSetLegStrikePrice() 
                    { 
                        return IsSetField(Tags.LegStrikePrice);
                    }
                    public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        this.LegStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        return IsSetLegStrikeCurrency();
                    }
                    
                    public bool IsSetLegStrikeCurrency() 
                    { 
                        return IsSetField(Tags.LegStrikeCurrency);
                    }
                    public QuickFix.Fields.LegOptAttribute LegOptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        this.LegOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        return IsSetLegOptAttribute();
                    }
                    
                    public bool IsSetLegOptAttribute() 
                    { 
                        return IsSetField(Tags.LegOptAttribute);
                    }
                    public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        this.LegContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        return IsSetLegContractMultiplier();
                    }
                    
                    public bool IsSetLegContractMultiplier() 
                    { 
                        return IsSetField(Tags.LegContractMultiplier);
                    }
                    public QuickFix.Fields.LegCouponRate LegCouponRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCouponRate val) 
                    { 
                        this.LegCouponRate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                    { 
                        return IsSetLegCouponRate();
                    }
                    
                    public bool IsSetLegCouponRate() 
                    { 
                        return IsSetField(Tags.LegCouponRate);
                    }
                    public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        this.LegSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        return IsSetLegSecurityExchange();
                    }
                    
                    public bool IsSetLegSecurityExchange() 
                    { 
                        return IsSetField(Tags.LegSecurityExchange);
                    }
                    public QuickFix.Fields.LegIssuer LegIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIssuer val) 
                    { 
                        this.LegIssuer = val;
                    }
                    
                    public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIssuer val) 
                    { 
                        return IsSetLegIssuer();
                    }
                    
                    public bool IsSetLegIssuer() 
                    { 
                        return IsSetField(Tags.LegIssuer);
                    }
                    public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        this.EncodedLegIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        return IsSetEncodedLegIssuerLen();
                    }
                    
                    public bool IsSetEncodedLegIssuerLen() 
                    { 
                        return IsSetField(Tags.EncodedLegIssuerLen);
                    }
                    public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        this.EncodedLegIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        return IsSetEncodedLegIssuer();
                    }
                    
                    public bool IsSetEncodedLegIssuer() 
                    { 
                        return IsSetField(Tags.EncodedLegIssuer);
                    }
                    public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        this.LegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        return IsSetLegSecurityDesc();
                    }
                    
                    public bool IsSetLegSecurityDesc() 
                    { 
                        return IsSetField(Tags.LegSecurityDesc);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        this.EncodedLegSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        return IsSetEncodedLegSecurityDescLen();
                    }
                    
                    public bool IsSetEncodedLegSecurityDescLen() 
                    { 
                        return IsSetField(Tags.EncodedLegSecurityDescLen);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        this.EncodedLegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        return IsSetEncodedLegSecurityDesc();
                    }
                    
                    public bool IsSetEncodedLegSecurityDesc() 
                    { 
                        return IsSetField(Tags.EncodedLegSecurityDesc);
                    }
                    public QuickFix.Fields.LegRatioQty LegRatioQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRatioQty val) 
                    { 
                        this.LegRatioQty = val;
                    }
                    
                    public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                    { 
                        return IsSetLegRatioQty();
                    }
                    
                    public bool IsSetLegRatioQty() 
                    { 
                        return IsSetField(Tags.LegRatioQty);
                    }
                    public QuickFix.Fields.LegSide LegSide
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSide val) 
                    { 
                        this.LegSide = val;
                    }
                    
                    public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSide val) 
                    { 
                        return IsSetLegSide();
                    }
                    
                    public bool IsSetLegSide() 
                    { 
                        return IsSetField(Tags.LegSide);
                    }
                    public QuickFix.Fields.LegCurrency LegCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCurrency val) 
                    { 
                        this.LegCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCurrency val) 
                    { 
                        return IsSetLegCurrency();
                    }
                    
                    public bool IsSetLegCurrency() 
                    { 
                        return IsSetField(Tags.LegCurrency);
                    }
                    public QuickFix.Fields.LegPool LegPool
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPool val) 
                    { 
                        this.LegPool = val;
                    }
                    
                    public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPool val) 
                    { 
                        return IsSetLegPool();
                    }
                    
                    public bool IsSetLegPool() 
                    { 
                        return IsSetField(Tags.LegPool);
                    }
                    public QuickFix.Fields.LegDatedDate LegDatedDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegDatedDate val) 
                    { 
                        this.LegDatedDate = val;
                    }
                    
                    public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                    { 
                        return IsSetLegDatedDate();
                    }
                    
                    public bool IsSetLegDatedDate() 
                    { 
                        return IsSetField(Tags.LegDatedDate);
                    }
                    public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        this.LegContractSettlMonth = val;
                    }
                    
                    public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        return IsSetLegContractSettlMonth();
                    }
                    
                    public bool IsSetLegContractSettlMonth() 
                    { 
                        return IsSetField(Tags.LegContractSettlMonth);
                    }
                    public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        this.LegInterestAccrualDate = val;
                    }
                    
                    public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        return IsSetLegInterestAccrualDate();
                    }
                    
                    public bool IsSetLegInterestAccrualDate() 
                    { 
                        return IsSetField(Tags.LegInterestAccrualDate);
                    }
                    public QuickFix.Fields.LegUnitOfMeasure LegUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        this.LegUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        return IsSetLegUnitOfMeasure();
                    }
                    
                    public bool IsSetLegUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.LegUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegTimeUnit LegTimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        this.LegTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        return IsSetLegTimeUnit();
                    }
                    
                    public bool IsSetLegTimeUnit() 
                    { 
                        return IsSetField(Tags.LegTimeUnit);
                    }
                    public QuickFix.Fields.LegOptionRatio LegOptionRatio
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptionRatio val = new QuickFix.Fields.LegOptionRatio();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        this.LegOptionRatio = val;
                    }
                    
                    public QuickFix.Fields.LegOptionRatio Get(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        return IsSetLegOptionRatio();
                    }
                    
                    public bool IsSetLegOptionRatio() 
                    { 
                        return IsSetField(Tags.LegOptionRatio);
                    }
                    public QuickFix.Fields.LegPrice LegPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPrice val) 
                    { 
                        this.LegPrice = val;
                    }
                    
                    public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPrice val) 
                    { 
                        return IsSetLegPrice();
                    }
                    
                    public bool IsSetLegPrice() 
                    { 
                        return IsSetField(Tags.LegPrice);
                    }
                    public QuickFix.Fields.LegMaturityTime LegMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityTime val = new QuickFix.Fields.LegMaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        this.LegMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityTime Get(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        return IsSetLegMaturityTime();
                    }
                    
                    public bool IsSetLegMaturityTime() 
                    { 
                        return IsSetField(Tags.LegMaturityTime);
                    }
                    public QuickFix.Fields.LegPutOrCall LegPutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPutOrCall val = new QuickFix.Fields.LegPutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        this.LegPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.LegPutOrCall Get(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        return IsSetLegPutOrCall();
                    }
                    
                    public bool IsSetLegPutOrCall() 
                    { 
                        return IsSetField(Tags.LegPutOrCall);
                    }
                    public QuickFix.Fields.LegExerciseStyle LegExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.LegExerciseStyle val = new QuickFix.Fields.LegExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        this.LegExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle Get(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        return IsSetLegExerciseStyle();
                    }
                    
                    public bool IsSetLegExerciseStyle() 
                    { 
                        return IsSetField(Tags.LegExerciseStyle);
                    }
                    public QuickFix.Fields.LegUnitOfMeasureQty LegUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasureQty val = new QuickFix.Fields.LegUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        this.LegUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty Get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        return IsSetLegUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.LegUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasure LegPriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasure val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        this.LegPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure Get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        return IsSetLegPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.LegPriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasureQty val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        this.LegPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty Get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        return IsSetLegPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.LegPriceUnitOfMeasureQty);
                    }
                                    public class NoLegSecurityAltIDGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                    
                        public NoLegSecurityAltIDGroup() 
                          :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
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
                                QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            this.LegSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            return IsSetLegSecurityAltID();
                        }
                        
                        public bool IsSetLegSecurityAltID() 
                        { 
                            return IsSetField(Tags.LegSecurityAltID);
                        }
                        public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            this.LegSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            return IsSetLegSecurityAltIDSource();
                        }
                        
                        public bool IsSetLegSecurityAltIDSource() 
                        { 
                            return IsSetField(Tags.LegSecurityAltIDSource);
                        }
                    
                    }
                }
            }
        }
    }
}
