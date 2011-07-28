using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class MarketDataRequest : Message
        {
            public MarketDataRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("V"));
            }

            public MarketDataRequest(
                    QuickFix.Fields.MDReqID aMDReqID,
                    QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType,
                    QuickFix.Fields.MarketDepth aMarketDepth
                ) : this()
            {
                this.mDReqID = aMDReqID;
                this.subscriptionRequestType = aSubscriptionRequestType;
                this.marketDepth = aMarketDepth;
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
            public QuickFix.Fields.MarketDepth marketDepth
            { 
                get 
                {
                    QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketDepth val) 
            { 
                this.marketDepth = val;
            }
            
            public QuickFix.Fields.MarketDepth get(QuickFix.Fields.MarketDepth val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketDepth val) 
            { 
                return isSetMarketDepth();
            }
            
            public bool isSetMarketDepth() 
            { 
                return isSetField(Tags.MarketDepth);
            }
            public QuickFix.Fields.MDUpdateType mDUpdateType
            { 
                get 
                {
                    QuickFix.Fields.MDUpdateType val = new QuickFix.Fields.MDUpdateType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MDUpdateType val) 
            { 
                this.mDUpdateType = val;
            }
            
            public QuickFix.Fields.MDUpdateType get(QuickFix.Fields.MDUpdateType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MDUpdateType val) 
            { 
                return isSetMDUpdateType();
            }
            
            public bool isSetMDUpdateType() 
            { 
                return isSetField(Tags.MDUpdateType);
            }
            public QuickFix.Fields.AggregatedBook aggregatedBook
            { 
                get 
                {
                    QuickFix.Fields.AggregatedBook val = new QuickFix.Fields.AggregatedBook();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AggregatedBook val) 
            { 
                this.aggregatedBook = val;
            }
            
            public QuickFix.Fields.AggregatedBook get(QuickFix.Fields.AggregatedBook val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AggregatedBook val) 
            { 
                return isSetAggregatedBook();
            }
            
            public bool isSetAggregatedBook() 
            { 
                return isSetField(Tags.AggregatedBook);
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
            public QuickFix.Fields.MDImplicitDelete mDImplicitDelete
            { 
                get 
                {
                    QuickFix.Fields.MDImplicitDelete val = new QuickFix.Fields.MDImplicitDelete();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MDImplicitDelete val) 
            { 
                this.mDImplicitDelete = val;
            }
            
            public QuickFix.Fields.MDImplicitDelete get(QuickFix.Fields.MDImplicitDelete val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MDImplicitDelete val) 
            { 
                return isSetMDImplicitDelete();
            }
            
            public bool isSetMDImplicitDelete() 
            { 
                return isSetField(Tags.MDImplicitDelete);
            }
            public QuickFix.Fields.NoMDEntryTypes noMDEntryTypes
            { 
                get 
                {
                    QuickFix.Fields.NoMDEntryTypes val = new QuickFix.Fields.NoMDEntryTypes();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoMDEntryTypes val) 
            { 
                this.noMDEntryTypes = val;
            }
            
            public QuickFix.Fields.NoMDEntryTypes get(QuickFix.Fields.NoMDEntryTypes val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoMDEntryTypes val) 
            { 
                return isSetNoMDEntryTypes();
            }
            
            public bool isSetNoMDEntryTypes() 
            { 
                return isSetField(Tags.NoMDEntryTypes);
            }
            public QuickFix.Fields.NoRelatedSym noRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.NoRelatedSym val = new QuickFix.Fields.NoRelatedSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRelatedSym val) 
            { 
                this.noRelatedSym = val;
            }
            
            public QuickFix.Fields.NoRelatedSym get(QuickFix.Fields.NoRelatedSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRelatedSym val) 
            { 
                return isSetNoRelatedSym();
            }
            
            public bool isSetNoRelatedSym() 
            { 
                return isSetField(Tags.NoRelatedSym);
            }
            public QuickFix.Fields.NoTradingSessions noTradingSessions
            { 
                get 
                {
                    QuickFix.Fields.NoTradingSessions val = new QuickFix.Fields.NoTradingSessions();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoTradingSessions val) 
            { 
                this.noTradingSessions = val;
            }
            
            public QuickFix.Fields.NoTradingSessions get(QuickFix.Fields.NoTradingSessions val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoTradingSessions val) 
            { 
                return isSetNoTradingSessions();
            }
            
            public bool isSetNoTradingSessions() 
            { 
                return isSetField(Tags.NoTradingSessions);
            }
            public class NoMDEntryTypes : Group
            {
                public NoMDEntryTypes() 
                  :base( Tags.NoMDEntryTypes, Tags.MDEntryType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.MDEntryType, 0};
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
            
            }
            public class NoRelatedSym : Group
            {
                public NoRelatedSym() 
                  :base( Tags.NoRelatedSym, Tags.Symbol, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, 0};
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
            }
            public class NoTradingSessions : Group
            {
                public NoTradingSessions() 
                  :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, 0};
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
            
            }
        }
    }
}
