// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class AdjustedPositionReport : Message
        {
            public const string MsgType = "BL";

            public AdjustedPositionReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BL"));
            }

            public AdjustedPositionReport(
                    QuickFix.Fields.PosMaintRptID aPosMaintRptID,
                    QuickFix.Fields.ClearingBusinessDate aClearingBusinessDate
                ) : this()
            {
                this.PosMaintRptID = aPosMaintRptID;
                this.ClearingBusinessDate = aClearingBusinessDate;
            }

            public QuickFix.Fields.PosMaintRptID PosMaintRptID
            { 
                get 
                {
                    QuickFix.Fields.PosMaintRptID val = new QuickFix.Fields.PosMaintRptID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PosMaintRptID val) 
            { 
                this.PosMaintRptID = val;
            }
            
            public QuickFix.Fields.PosMaintRptID Get(QuickFix.Fields.PosMaintRptID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PosMaintRptID val) 
            { 
                return IsSetPosMaintRptID();
            }
            
            public bool IsSetPosMaintRptID() 
            { 
                return IsSetField(Tags.PosMaintRptID);
            }
            public QuickFix.Fields.PosReqType PosReqType
            { 
                get 
                {
                    QuickFix.Fields.PosReqType val = new QuickFix.Fields.PosReqType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PosReqType val) 
            { 
                this.PosReqType = val;
            }
            
            public QuickFix.Fields.PosReqType Get(QuickFix.Fields.PosReqType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PosReqType val) 
            { 
                return IsSetPosReqType();
            }
            
            public bool IsSetPosReqType() 
            { 
                return IsSetField(Tags.PosReqType);
            }
            public QuickFix.Fields.ClearingBusinessDate ClearingBusinessDate
            { 
                get 
                {
                    QuickFix.Fields.ClearingBusinessDate val = new QuickFix.Fields.ClearingBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                this.ClearingBusinessDate = val;
            }
            
            public QuickFix.Fields.ClearingBusinessDate Get(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                return IsSetClearingBusinessDate();
            }
            
            public bool IsSetClearingBusinessDate() 
            { 
                return IsSetField(Tags.ClearingBusinessDate);
            }
            public QuickFix.Fields.SettlSessID SettlSessID
            { 
                get 
                {
                    QuickFix.Fields.SettlSessID val = new QuickFix.Fields.SettlSessID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlSessID val) 
            { 
                this.SettlSessID = val;
            }
            
            public QuickFix.Fields.SettlSessID Get(QuickFix.Fields.SettlSessID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlSessID val) 
            { 
                return IsSetSettlSessID();
            }
            
            public bool IsSetSettlSessID() 
            { 
                return IsSetField(Tags.SettlSessID);
            }
            public QuickFix.Fields.NoPartyIDs NoPartyIDs
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
                this.NoPartyIDs = val;
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
            public QuickFix.Fields.NoPositions NoPositions
            { 
                get 
                {
                    QuickFix.Fields.NoPositions val = new QuickFix.Fields.NoPositions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPositions val) 
            { 
                this.NoPositions = val;
            }
            
            public QuickFix.Fields.NoPositions Get(QuickFix.Fields.NoPositions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPositions val) 
            { 
                return IsSetNoPositions();
            }
            
            public bool IsSetNoPositions() 
            { 
                return IsSetField(Tags.NoPositions);
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
            public QuickFix.Fields.SecurityStat SecurityStat
            { 
                get 
                {
                    QuickFix.Fields.SecurityStat val = new QuickFix.Fields.SecurityStat();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityStat val) 
            { 
                this.SecurityStat = val;
            }
            
            public QuickFix.Fields.SecurityStat Get(QuickFix.Fields.SecurityStat val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityStat val) 
            { 
                return IsSetSecurityStat();
            }
            
            public bool IsSetSecurityStat() 
            { 
                return IsSetField(Tags.SecurityStat);
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
            public QuickFix.Fields.SettlPrice SettlPrice
            { 
                get 
                {
                    QuickFix.Fields.SettlPrice val = new QuickFix.Fields.SettlPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlPrice val) 
            { 
                this.SettlPrice = val;
            }
            
            public QuickFix.Fields.SettlPrice Get(QuickFix.Fields.SettlPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlPrice val) 
            { 
                return IsSetSettlPrice();
            }
            
            public bool IsSetSettlPrice() 
            { 
                return IsSetField(Tags.SettlPrice);
            }
            public QuickFix.Fields.PriorSettlPrice PriorSettlPrice
            { 
                get 
                {
                    QuickFix.Fields.PriorSettlPrice val = new QuickFix.Fields.PriorSettlPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriorSettlPrice val) 
            { 
                this.PriorSettlPrice = val;
            }
            
            public QuickFix.Fields.PriorSettlPrice Get(QuickFix.Fields.PriorSettlPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriorSettlPrice val) 
            { 
                return IsSetPriorSettlPrice();
            }
            
            public bool IsSetPriorSettlPrice() 
            { 
                return IsSetField(Tags.PriorSettlPrice);
            }
            public QuickFix.Fields.PosMaintRptRefID PosMaintRptRefID
            { 
                get 
                {
                    QuickFix.Fields.PosMaintRptRefID val = new QuickFix.Fields.PosMaintRptRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PosMaintRptRefID val) 
            { 
                this.PosMaintRptRefID = val;
            }
            
            public QuickFix.Fields.PosMaintRptRefID Get(QuickFix.Fields.PosMaintRptRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PosMaintRptRefID val) 
            { 
                return IsSetPosMaintRptRefID();
            }
            
            public bool IsSetPosMaintRptRefID() 
            { 
                return IsSetField(Tags.PosMaintRptRefID);
            }
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
            
                public NoPartyIDsGroup() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
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
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    this.PartyID = val;
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
                public QuickFix.Fields.PartyIDSource PartyIDSource
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
                    this.PartyIDSource = val;
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
                public QuickFix.Fields.PartyRole PartyRole
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
                    this.PartyRole = val;
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
                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
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
                    this.NoPartySubIDs = val;
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
                            public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                
                    public NoPartySubIDsGroup() 
                      :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.PartySubID PartySubID
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
                        this.PartySubID = val;
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
                    public QuickFix.Fields.PartySubIDType PartySubIDType
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
                        this.PartySubIDType = val;
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
            public class NoPositionsGroup : Group
            {
                public static int[] fieldOrder = {Tags.PosType, Tags.LongQty, Tags.ShortQty, Tags.PosQtyStatus, Tags.NoNestedPartyIDs, Tags.QuantityDate, 0};
            
                public NoPositionsGroup() 
                  :base( Tags.NoPositions, Tags.PosType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPositionsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.PosType PosType
                { 
                    get 
                    {
                        QuickFix.Fields.PosType val = new QuickFix.Fields.PosType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PosType val) 
                { 
                    this.PosType = val;
                }
                
                public QuickFix.Fields.PosType Get(QuickFix.Fields.PosType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PosType val) 
                { 
                    return IsSetPosType();
                }
                
                public bool IsSetPosType() 
                { 
                    return IsSetField(Tags.PosType);
                }
                public QuickFix.Fields.LongQty LongQty
                { 
                    get 
                    {
                        QuickFix.Fields.LongQty val = new QuickFix.Fields.LongQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LongQty val) 
                { 
                    this.LongQty = val;
                }
                
                public QuickFix.Fields.LongQty Get(QuickFix.Fields.LongQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LongQty val) 
                { 
                    return IsSetLongQty();
                }
                
                public bool IsSetLongQty() 
                { 
                    return IsSetField(Tags.LongQty);
                }
                public QuickFix.Fields.ShortQty ShortQty
                { 
                    get 
                    {
                        QuickFix.Fields.ShortQty val = new QuickFix.Fields.ShortQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ShortQty val) 
                { 
                    this.ShortQty = val;
                }
                
                public QuickFix.Fields.ShortQty Get(QuickFix.Fields.ShortQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ShortQty val) 
                { 
                    return IsSetShortQty();
                }
                
                public bool IsSetShortQty() 
                { 
                    return IsSetField(Tags.ShortQty);
                }
                public QuickFix.Fields.PosQtyStatus PosQtyStatus
                { 
                    get 
                    {
                        QuickFix.Fields.PosQtyStatus val = new QuickFix.Fields.PosQtyStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PosQtyStatus val) 
                { 
                    this.PosQtyStatus = val;
                }
                
                public QuickFix.Fields.PosQtyStatus Get(QuickFix.Fields.PosQtyStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PosQtyStatus val) 
                { 
                    return IsSetPosQtyStatus();
                }
                
                public bool IsSetPosQtyStatus() 
                { 
                    return IsSetField(Tags.PosQtyStatus);
                }
                public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    this.NoNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(Tags.NoNestedPartyIDs);
                }
                public QuickFix.Fields.QuantityDate QuantityDate
                { 
                    get 
                    {
                        QuickFix.Fields.QuantityDate val = new QuickFix.Fields.QuantityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuantityDate val) 
                { 
                    this.QuantityDate = val;
                }
                
                public QuickFix.Fields.QuantityDate Get(QuickFix.Fields.QuantityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuantityDate val) 
                { 
                    return IsSetQuantityDate();
                }
                
                public bool IsSetQuantityDate() 
                { 
                    return IsSetField(Tags.QuantityDate);
                }
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        this.NestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(Tags.NestedPartyID);
                    }
                    public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        this.NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(Tags.NestedPartyIDSource);
                    }
                    public QuickFix.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        this.NestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(Tags.NestedPartyRole);
                    }
                    public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        this.NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoNestedPartySubIDs);
                    }
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.NestedPartySubID NestedPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubID val = new QuickFix.Fields.NestedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            this.NestedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            return IsSetNestedPartySubID();
                        }
                        
                        public bool IsSetNestedPartySubID() 
                        { 
                            return IsSetField(Tags.NestedPartySubID);
                        }
                        public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            this.NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(Tags.NestedPartySubIDType);
                        }
                    
                    }
                }
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
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};
            
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
        }
    }
}
