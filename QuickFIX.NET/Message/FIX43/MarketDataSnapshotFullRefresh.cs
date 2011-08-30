// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class MarketDataSnapshotFullRefresh : Message
        {
            public const string MsgType = "W";

            public MarketDataSnapshotFullRefresh() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("W"));
            }

            public MarketDataSnapshotFullRefresh(
                    QuickFix.Fields.Symbol aSymbol
                ) : this()
            {
                this.symbol = aSymbol;
            }

            public QuickFix.Fields.MDReqID mDReqID
            { 
                get 
                {
                    QuickFix.Fields.MDReqID val = new QuickFix.Fields.MDReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MDReqID val) 
            { 
                this.mDReqID = val;
            }
            
            public QuickFix.Fields.MDReqID get(QuickFix.Fields.MDReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MDReqID val) 
            { 
                return isSetMDReqID();
            }
            
            public bool isSetMDReqID() 
            { 
                return isSetField(Tags.MDReqID);
            }
            public QuickFix.Fields.Symbol symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Symbol val) 
            { 
                this.symbol = val;
            }
            
            public QuickFix.Fields.Symbol get(QuickFix.Fields.Symbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Symbol val) 
            { 
                return isSetSymbol();
            }
            
            public bool isSetSymbol() 
            { 
                return isSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx symbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.symbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx get(QuickFix.Fields.SymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return isSetSymbolSfx();
            }
            
            public bool isSetSymbolSfx() 
            { 
                return isSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID securityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityID val) 
            { 
                this.securityID = val;
            }
            
            public QuickFix.Fields.SecurityID get(QuickFix.Fields.SecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityID val) 
            { 
                return isSetSecurityID();
            }
            
            public bool isSetSecurityID() 
            { 
                return isSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.SecurityIDSource securityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.securityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource get(QuickFix.Fields.SecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return isSetSecurityIDSource();
            }
            
            public bool isSetSecurityIDSource() 
            { 
                return isSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID noSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.noSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return isSetNoSecurityAltID();
            }
            
            public bool isSetNoSecurityAltID() 
            { 
                return isSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Product val) 
            { 
                this.product = val;
            }
            
            public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Product val) 
            { 
                return isSetProduct();
            }
            
            public bool isSetProduct() 
            { 
                return isSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode cFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CFICode val) 
            { 
                this.cFICode = val;
            }
            
            public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CFICode val) 
            { 
                return isSetCFICode();
            }
            
            public bool isSetCFICode() 
            { 
                return isSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityType val) 
            { 
                return isSetSecurityType();
            }
            
            public bool isSetSecurityType() 
            { 
                return isSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.MaturityMonthYear maturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.maturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return isSetMaturityMonthYear();
            }
            
            public bool isSetMaturityMonthYear() 
            { 
                return isSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDate maturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaturityDate val) 
            { 
                this.maturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate get(QuickFix.Fields.MaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaturityDate val) 
            { 
                return isSetMaturityDate();
            }
            
            public bool isSetMaturityDate() 
            { 
                return isSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate couponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.couponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return isSetCouponPaymentDate();
            }
            
            public bool isSetCouponPaymentDate() 
            { 
                return isSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate issueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IssueDate val) 
            { 
                this.issueDate = val;
            }
            
            public QuickFix.Fields.IssueDate get(QuickFix.Fields.IssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IssueDate val) 
            { 
                return isSetIssueDate();
            }
            
            public bool isSetIssueDate() 
            { 
                return isSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.repoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return isSetRepoCollateralSecurityType();
            }
            
            public bool isSetRepoCollateralSecurityType() 
            { 
                return isSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm repurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.repurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return isSetRepurchaseTerm();
            }
            
            public bool isSetRepurchaseTerm() 
            { 
                return isSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate repurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.repurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate get(QuickFix.Fields.RepurchaseRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return isSetRepurchaseRate();
            }
            
            public bool isSetRepurchaseRate() 
            { 
                return isSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Factor val) 
            { 
                this.factor = val;
            }
            
            public QuickFix.Fields.Factor get(QuickFix.Fields.Factor val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Factor val) 
            { 
                return isSetFactor();
            }
            
            public bool isSetFactor() 
            { 
                return isSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating creditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CreditRating val) 
            { 
                this.creditRating = val;
            }
            
            public QuickFix.Fields.CreditRating get(QuickFix.Fields.CreditRating val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CreditRating val) 
            { 
                return isSetCreditRating();
            }
            
            public bool isSetCreditRating() 
            { 
                return isSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry instrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.instrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry get(QuickFix.Fields.InstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return isSetInstrRegistry();
            }
            
            public bool isSetInstrRegistry() 
            { 
                return isSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue countryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.countryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue get(QuickFix.Fields.CountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return isSetCountryOfIssue();
            }
            
            public bool isSetCountryOfIssue() 
            { 
                return isSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.stateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return isSetStateOrProvinceOfIssue();
            }
            
            public bool isSetStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue localeOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.localeOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return isSetLocaleOfIssue();
            }
            
            public bool isSetLocaleOfIssue() 
            { 
                return isSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate redemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.redemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate get(QuickFix.Fields.RedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return isSetRedemptionDate();
            }
            
            public bool isSetRedemptionDate() 
            { 
                return isSetField(Tags.RedemptionDate);
            }
            public QuickFix.Fields.StrikePrice strikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikePrice val) 
            { 
                this.strikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice get(QuickFix.Fields.StrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikePrice val) 
            { 
                return isSetStrikePrice();
            }
            
            public bool isSetStrikePrice() 
            { 
                return isSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.OptAttribute optAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OptAttribute val) 
            { 
                this.optAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute get(QuickFix.Fields.OptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OptAttribute val) 
            { 
                return isSetOptAttribute();
            }
            
            public bool isSetOptAttribute() 
            { 
                return isSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier contractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.contractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier get(QuickFix.Fields.ContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return isSetContractMultiplier();
            }
            
            public bool isSetContractMultiplier() 
            { 
                return isSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate couponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CouponRate val) 
            { 
                this.couponRate = val;
            }
            
            public QuickFix.Fields.CouponRate get(QuickFix.Fields.CouponRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CouponRate val) 
            { 
                return isSetCouponRate();
            }
            
            public bool isSetCouponRate() 
            { 
                return isSetField(Tags.CouponRate);
            }
            public QuickFix.Fields.SecurityExchange securityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.securityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return isSetSecurityExchange();
            }
            
            public bool isSetSecurityExchange() 
            { 
                return isSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Issuer val) 
            { 
                this.issuer = val;
            }
            
            public QuickFix.Fields.Issuer get(QuickFix.Fields.Issuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Issuer val) 
            { 
                return isSetIssuer();
            }
            
            public bool isSetIssuer() 
            { 
                return isSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.encodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return isSetEncodedIssuerLen();
            }
            
            public bool isSetEncodedIssuerLen() 
            { 
                return isSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer encodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.encodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer get(QuickFix.Fields.EncodedIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return isSetEncodedIssuer();
            }
            
            public bool isSetEncodedIssuer() 
            { 
                return isSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc securityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.securityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc get(QuickFix.Fields.SecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return isSetSecurityDesc();
            }
            
            public bool isSetSecurityDesc() 
            { 
                return isSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.encodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return isSetEncodedSecurityDescLen();
            }
            
            public bool isSetEncodedSecurityDescLen() 
            { 
                return isSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.encodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return isSetEncodedSecurityDesc();
            }
            
            public bool isSetEncodedSecurityDesc() 
            { 
                return isSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.FinancialStatus financialStatus
            { 
                get 
                {
                    QuickFix.Fields.FinancialStatus val = new QuickFix.Fields.FinancialStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FinancialStatus val) 
            { 
                this.financialStatus = val;
            }
            
            public QuickFix.Fields.FinancialStatus get(QuickFix.Fields.FinancialStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FinancialStatus val) 
            { 
                return isSetFinancialStatus();
            }
            
            public bool isSetFinancialStatus() 
            { 
                return isSetField(Tags.FinancialStatus);
            }
            public QuickFix.Fields.CorporateAction corporateAction
            { 
                get 
                {
                    QuickFix.Fields.CorporateAction val = new QuickFix.Fields.CorporateAction();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CorporateAction val) 
            { 
                this.corporateAction = val;
            }
            
            public QuickFix.Fields.CorporateAction get(QuickFix.Fields.CorporateAction val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CorporateAction val) 
            { 
                return isSetCorporateAction();
            }
            
            public bool isSetCorporateAction() 
            { 
                return isSetField(Tags.CorporateAction);
            }
            public QuickFix.Fields.TotalVolumeTraded totalVolumeTraded
            { 
                get 
                {
                    QuickFix.Fields.TotalVolumeTraded val = new QuickFix.Fields.TotalVolumeTraded();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                this.totalVolumeTraded = val;
            }
            
            public QuickFix.Fields.TotalVolumeTraded get(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotalVolumeTraded val) 
            { 
                return isSetTotalVolumeTraded();
            }
            
            public bool isSetTotalVolumeTraded() 
            { 
                return isSetField(Tags.TotalVolumeTraded);
            }
            public QuickFix.Fields.TotalVolumeTradedDate totalVolumeTradedDate
            { 
                get 
                {
                    QuickFix.Fields.TotalVolumeTradedDate val = new QuickFix.Fields.TotalVolumeTradedDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotalVolumeTradedDate val) 
            { 
                this.totalVolumeTradedDate = val;
            }
            
            public QuickFix.Fields.TotalVolumeTradedDate get(QuickFix.Fields.TotalVolumeTradedDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotalVolumeTradedDate val) 
            { 
                return isSetTotalVolumeTradedDate();
            }
            
            public bool isSetTotalVolumeTradedDate() 
            { 
                return isSetField(Tags.TotalVolumeTradedDate);
            }
            public QuickFix.Fields.TotalVolumeTradedTime totalVolumeTradedTime
            { 
                get 
                {
                    QuickFix.Fields.TotalVolumeTradedTime val = new QuickFix.Fields.TotalVolumeTradedTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotalVolumeTradedTime val) 
            { 
                this.totalVolumeTradedTime = val;
            }
            
            public QuickFix.Fields.TotalVolumeTradedTime get(QuickFix.Fields.TotalVolumeTradedTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotalVolumeTradedTime val) 
            { 
                return isSetTotalVolumeTradedTime();
            }
            
            public bool isSetTotalVolumeTradedTime() 
            { 
                return isSetField(Tags.TotalVolumeTradedTime);
            }
            public QuickFix.Fields.NetChgPrevDay netChgPrevDay
            { 
                get 
                {
                    QuickFix.Fields.NetChgPrevDay val = new QuickFix.Fields.NetChgPrevDay();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetChgPrevDay val) 
            { 
                this.netChgPrevDay = val;
            }
            
            public QuickFix.Fields.NetChgPrevDay get(QuickFix.Fields.NetChgPrevDay val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetChgPrevDay val) 
            { 
                return isSetNetChgPrevDay();
            }
            
            public bool isSetNetChgPrevDay() 
            { 
                return isSetField(Tags.NetChgPrevDay);
            }
            public QuickFix.Fields.NoMDEntries noMDEntries
            { 
                get 
                {
                    QuickFix.Fields.NoMDEntries val = new QuickFix.Fields.NoMDEntries();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoMDEntries val) 
            { 
                this.noMDEntries = val;
            }
            
            public QuickFix.Fields.NoMDEntries get(QuickFix.Fields.NoMDEntries val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoMDEntries val) 
            { 
                return isSetNoMDEntries();
            }
            
            public bool isSetNoMDEntries() 
            { 
                return isSetField(Tags.NoMDEntries);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.securityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID get(QuickFix.Fields.SecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return isSetSecurityAltID();
                }
                
                public bool isSetSecurityAltID() 
                { 
                    return isSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.securityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return isSetSecurityAltIDSource();
                }
                
                public bool isSetSecurityAltIDSource() 
                { 
                    return isSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoMDEntries : Group
            {
                public NoMDEntries() 
                  :base( Tags.NoMDEntries, Tags.MDEntryType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.MDEntryType, Tags.MDEntryPx, Tags.Currency, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TickDirection, Tags.MDMkt, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.QuoteCondition, Tags.TradeCondition, Tags.MDEntryOriginator, Tags.LocationID, Tags.DeskID, Tags.OpenCloseSettleFlag, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.MinQty, Tags.ExecInst, Tags.SellerDays, Tags.OrderID, Tags.QuoteEntryID, Tags.MDEntryBuyer, Tags.MDEntrySeller, Tags.NumberOfOrders, Tags.MDEntryPositionNo, Tags.Scope, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
                            public QuickFix.Fields.MDEntryType mDEntryType
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryType val = new QuickFix.Fields.MDEntryType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryType val) 
                { 
                    this.mDEntryType = val;
                }
                
                public QuickFix.Fields.MDEntryType get(QuickFix.Fields.MDEntryType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryType val) 
                { 
                    return isSetMDEntryType();
                }
                
                public bool isSetMDEntryType() 
                { 
                    return isSetField(Tags.MDEntryType);
                }
                public QuickFix.Fields.MDEntryPx mDEntryPx
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryPx val = new QuickFix.Fields.MDEntryPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryPx val) 
                { 
                    this.mDEntryPx = val;
                }
                
                public QuickFix.Fields.MDEntryPx get(QuickFix.Fields.MDEntryPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryPx val) 
                { 
                    return isSetMDEntryPx();
                }
                
                public bool isSetMDEntryPx() 
                { 
                    return isSetField(Tags.MDEntryPx);
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
                public QuickFix.Fields.MDEntrySize mDEntrySize
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntrySize val = new QuickFix.Fields.MDEntrySize();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntrySize val) 
                { 
                    this.mDEntrySize = val;
                }
                
                public QuickFix.Fields.MDEntrySize get(QuickFix.Fields.MDEntrySize val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntrySize val) 
                { 
                    return isSetMDEntrySize();
                }
                
                public bool isSetMDEntrySize() 
                { 
                    return isSetField(Tags.MDEntrySize);
                }
                public QuickFix.Fields.MDEntryDate mDEntryDate
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryDate val = new QuickFix.Fields.MDEntryDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryDate val) 
                { 
                    this.mDEntryDate = val;
                }
                
                public QuickFix.Fields.MDEntryDate get(QuickFix.Fields.MDEntryDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryDate val) 
                { 
                    return isSetMDEntryDate();
                }
                
                public bool isSetMDEntryDate() 
                { 
                    return isSetField(Tags.MDEntryDate);
                }
                public QuickFix.Fields.MDEntryTime mDEntryTime
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryTime val = new QuickFix.Fields.MDEntryTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryTime val) 
                { 
                    this.mDEntryTime = val;
                }
                
                public QuickFix.Fields.MDEntryTime get(QuickFix.Fields.MDEntryTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryTime val) 
                { 
                    return isSetMDEntryTime();
                }
                
                public bool isSetMDEntryTime() 
                { 
                    return isSetField(Tags.MDEntryTime);
                }
                public QuickFix.Fields.TickDirection tickDirection
                { 
                    get 
                    {
                        QuickFix.Fields.TickDirection val = new QuickFix.Fields.TickDirection();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TickDirection val) 
                { 
                    this.tickDirection = val;
                }
                
                public QuickFix.Fields.TickDirection get(QuickFix.Fields.TickDirection val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TickDirection val) 
                { 
                    return isSetTickDirection();
                }
                
                public bool isSetTickDirection() 
                { 
                    return isSetField(Tags.TickDirection);
                }
                public QuickFix.Fields.MDMkt mDMkt
                { 
                    get 
                    {
                        QuickFix.Fields.MDMkt val = new QuickFix.Fields.MDMkt();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDMkt val) 
                { 
                    this.mDMkt = val;
                }
                
                public QuickFix.Fields.MDMkt get(QuickFix.Fields.MDMkt val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDMkt val) 
                { 
                    return isSetMDMkt();
                }
                
                public bool isSetMDMkt() 
                { 
                    return isSetField(Tags.MDMkt);
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
                public QuickFix.Fields.QuoteCondition quoteCondition
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteCondition val = new QuickFix.Fields.QuoteCondition();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.QuoteCondition val) 
                { 
                    this.quoteCondition = val;
                }
                
                public QuickFix.Fields.QuoteCondition get(QuickFix.Fields.QuoteCondition val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.QuoteCondition val) 
                { 
                    return isSetQuoteCondition();
                }
                
                public bool isSetQuoteCondition() 
                { 
                    return isSetField(Tags.QuoteCondition);
                }
                public QuickFix.Fields.TradeCondition tradeCondition
                { 
                    get 
                    {
                        QuickFix.Fields.TradeCondition val = new QuickFix.Fields.TradeCondition();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradeCondition val) 
                { 
                    this.tradeCondition = val;
                }
                
                public QuickFix.Fields.TradeCondition get(QuickFix.Fields.TradeCondition val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradeCondition val) 
                { 
                    return isSetTradeCondition();
                }
                
                public bool isSetTradeCondition() 
                { 
                    return isSetField(Tags.TradeCondition);
                }
                public QuickFix.Fields.MDEntryOriginator mDEntryOriginator
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryOriginator val = new QuickFix.Fields.MDEntryOriginator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    this.mDEntryOriginator = val;
                }
                
                public QuickFix.Fields.MDEntryOriginator get(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    return isSetMDEntryOriginator();
                }
                
                public bool isSetMDEntryOriginator() 
                { 
                    return isSetField(Tags.MDEntryOriginator);
                }
                public QuickFix.Fields.LocationID locationID
                { 
                    get 
                    {
                        QuickFix.Fields.LocationID val = new QuickFix.Fields.LocationID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LocationID val) 
                { 
                    this.locationID = val;
                }
                
                public QuickFix.Fields.LocationID get(QuickFix.Fields.LocationID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LocationID val) 
                { 
                    return isSetLocationID();
                }
                
                public bool isSetLocationID() 
                { 
                    return isSetField(Tags.LocationID);
                }
                public QuickFix.Fields.DeskID deskID
                { 
                    get 
                    {
                        QuickFix.Fields.DeskID val = new QuickFix.Fields.DeskID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeskID val) 
                { 
                    this.deskID = val;
                }
                
                public QuickFix.Fields.DeskID get(QuickFix.Fields.DeskID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeskID val) 
                { 
                    return isSetDeskID();
                }
                
                public bool isSetDeskID() 
                { 
                    return isSetField(Tags.DeskID);
                }
                public QuickFix.Fields.OpenCloseSettleFlag openCloseSettleFlag
                { 
                    get 
                    {
                        QuickFix.Fields.OpenCloseSettleFlag val = new QuickFix.Fields.OpenCloseSettleFlag();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    this.openCloseSettleFlag = val;
                }
                
                public QuickFix.Fields.OpenCloseSettleFlag get(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    return isSetOpenCloseSettleFlag();
                }
                
                public bool isSetOpenCloseSettleFlag() 
                { 
                    return isSetField(Tags.OpenCloseSettleFlag);
                }
                public QuickFix.Fields.TimeInForce timeInForce
                { 
                    get 
                    {
                        QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TimeInForce val) 
                { 
                    this.timeInForce = val;
                }
                
                public QuickFix.Fields.TimeInForce get(QuickFix.Fields.TimeInForce val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TimeInForce val) 
                { 
                    return isSetTimeInForce();
                }
                
                public bool isSetTimeInForce() 
                { 
                    return isSetField(Tags.TimeInForce);
                }
                public QuickFix.Fields.ExpireDate expireDate
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExpireDate val) 
                { 
                    this.expireDate = val;
                }
                
                public QuickFix.Fields.ExpireDate get(QuickFix.Fields.ExpireDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExpireDate val) 
                { 
                    return isSetExpireDate();
                }
                
                public bool isSetExpireDate() 
                { 
                    return isSetField(Tags.ExpireDate);
                }
                public QuickFix.Fields.ExpireTime expireTime
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExpireTime val) 
                { 
                    this.expireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime get(QuickFix.Fields.ExpireTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return isSetExpireTime();
                }
                
                public bool isSetExpireTime() 
                { 
                    return isSetField(Tags.ExpireTime);
                }
                public QuickFix.Fields.MinQty minQty
                { 
                    get 
                    {
                        QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinQty val) 
                { 
                    this.minQty = val;
                }
                
                public QuickFix.Fields.MinQty get(QuickFix.Fields.MinQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinQty val) 
                { 
                    return isSetMinQty();
                }
                
                public bool isSetMinQty() 
                { 
                    return isSetField(Tags.MinQty);
                }
                public QuickFix.Fields.ExecInst execInst
                { 
                    get 
                    {
                        QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExecInst val) 
                { 
                    this.execInst = val;
                }
                
                public QuickFix.Fields.ExecInst get(QuickFix.Fields.ExecInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExecInst val) 
                { 
                    return isSetExecInst();
                }
                
                public bool isSetExecInst() 
                { 
                    return isSetField(Tags.ExecInst);
                }
                public QuickFix.Fields.SellerDays sellerDays
                { 
                    get 
                    {
                        QuickFix.Fields.SellerDays val = new QuickFix.Fields.SellerDays();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SellerDays val) 
                { 
                    this.sellerDays = val;
                }
                
                public QuickFix.Fields.SellerDays get(QuickFix.Fields.SellerDays val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SellerDays val) 
                { 
                    return isSetSellerDays();
                }
                
                public bool isSetSellerDays() 
                { 
                    return isSetField(Tags.SellerDays);
                }
                public QuickFix.Fields.OrderID orderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderID val) 
                { 
                    this.orderID = val;
                }
                
                public QuickFix.Fields.OrderID get(QuickFix.Fields.OrderID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderID val) 
                { 
                    return isSetOrderID();
                }
                
                public bool isSetOrderID() 
                { 
                    return isSetField(Tags.OrderID);
                }
                public QuickFix.Fields.QuoteEntryID quoteEntryID
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteEntryID val = new QuickFix.Fields.QuoteEntryID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.QuoteEntryID val) 
                { 
                    this.quoteEntryID = val;
                }
                
                public QuickFix.Fields.QuoteEntryID get(QuickFix.Fields.QuoteEntryID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.QuoteEntryID val) 
                { 
                    return isSetQuoteEntryID();
                }
                
                public bool isSetQuoteEntryID() 
                { 
                    return isSetField(Tags.QuoteEntryID);
                }
                public QuickFix.Fields.MDEntryBuyer mDEntryBuyer
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryBuyer val = new QuickFix.Fields.MDEntryBuyer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    this.mDEntryBuyer = val;
                }
                
                public QuickFix.Fields.MDEntryBuyer get(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    return isSetMDEntryBuyer();
                }
                
                public bool isSetMDEntryBuyer() 
                { 
                    return isSetField(Tags.MDEntryBuyer);
                }
                public QuickFix.Fields.MDEntrySeller mDEntrySeller
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntrySeller val = new QuickFix.Fields.MDEntrySeller();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntrySeller val) 
                { 
                    this.mDEntrySeller = val;
                }
                
                public QuickFix.Fields.MDEntrySeller get(QuickFix.Fields.MDEntrySeller val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntrySeller val) 
                { 
                    return isSetMDEntrySeller();
                }
                
                public bool isSetMDEntrySeller() 
                { 
                    return isSetField(Tags.MDEntrySeller);
                }
                public QuickFix.Fields.NumberOfOrders numberOfOrders
                { 
                    get 
                    {
                        QuickFix.Fields.NumberOfOrders val = new QuickFix.Fields.NumberOfOrders();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NumberOfOrders val) 
                { 
                    this.numberOfOrders = val;
                }
                
                public QuickFix.Fields.NumberOfOrders get(QuickFix.Fields.NumberOfOrders val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NumberOfOrders val) 
                { 
                    return isSetNumberOfOrders();
                }
                
                public bool isSetNumberOfOrders() 
                { 
                    return isSetField(Tags.NumberOfOrders);
                }
                public QuickFix.Fields.MDEntryPositionNo mDEntryPositionNo
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryPositionNo val = new QuickFix.Fields.MDEntryPositionNo();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    this.mDEntryPositionNo = val;
                }
                
                public QuickFix.Fields.MDEntryPositionNo get(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    return isSetMDEntryPositionNo();
                }
                
                public bool isSetMDEntryPositionNo() 
                { 
                    return isSetField(Tags.MDEntryPositionNo);
                }
                public QuickFix.Fields.Scope scope
                { 
                    get 
                    {
                        QuickFix.Fields.Scope val = new QuickFix.Fields.Scope();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Scope val) 
                { 
                    this.scope = val;
                }
                
                public QuickFix.Fields.Scope get(QuickFix.Fields.Scope val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Scope val) 
                { 
                    return isSetScope();
                }
                
                public bool isSetScope() 
                { 
                    return isSetField(Tags.Scope);
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
            
            }
        }
    }
}
