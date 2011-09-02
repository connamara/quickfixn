// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class QuoteCancel : Message
        {
            public const string MsgType = "Z";

            public QuoteCancel() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("Z"));
            }

            public QuoteCancel(
                    QuickFix.Fields.QuoteCancelType aQuoteCancelType
                ) : this()
            {
                this.quoteCancelType = aQuoteCancelType;
            }

            public QuickFix.Fields.QuoteReqID quoteReqID
            { 
                get 
                {
                    QuickFix.Fields.QuoteReqID val = new QuickFix.Fields.QuoteReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuoteReqID val) 
            { 
                this.quoteReqID = val;
            }
            
            public QuickFix.Fields.QuoteReqID get(QuickFix.Fields.QuoteReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuoteReqID val) 
            { 
                return isSetQuoteReqID();
            }
            
            public bool isSetQuoteReqID() 
            { 
                return isSetField(Tags.QuoteReqID);
            }
            public QuickFix.Fields.QuoteID quoteID
            { 
                get 
                {
                    QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuoteID val) 
            { 
                this.quoteID = val;
            }
            
            public QuickFix.Fields.QuoteID get(QuickFix.Fields.QuoteID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuoteID val) 
            { 
                return isSetQuoteID();
            }
            
            public bool isSetQuoteID() 
            { 
                return isSetField(Tags.QuoteID);
            }
            public QuickFix.Fields.QuoteCancelType quoteCancelType
            { 
                get 
                {
                    QuickFix.Fields.QuoteCancelType val = new QuickFix.Fields.QuoteCancelType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuoteCancelType val) 
            { 
                this.quoteCancelType = val;
            }
            
            public QuickFix.Fields.QuoteCancelType get(QuickFix.Fields.QuoteCancelType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuoteCancelType val) 
            { 
                return isSetQuoteCancelType();
            }
            
            public bool isSetQuoteCancelType() 
            { 
                return isSetField(Tags.QuoteCancelType);
            }
            public QuickFix.Fields.QuoteResponseLevel quoteResponseLevel
            { 
                get 
                {
                    QuickFix.Fields.QuoteResponseLevel val = new QuickFix.Fields.QuoteResponseLevel();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                this.quoteResponseLevel = val;
            }
            
            public QuickFix.Fields.QuoteResponseLevel get(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                return isSetQuoteResponseLevel();
            }
            
            public bool isSetQuoteResponseLevel() 
            { 
                return isSetField(Tags.QuoteResponseLevel);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs get(QuickFix.Fields.NoPartyIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return isSetNoPartyIDs();
            }
            
            public bool isSetNoPartyIDs() 
            { 
                return isSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.Account account
            { 
                get 
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Account val) 
            { 
                this.account = val;
            }
            
            public QuickFix.Fields.Account get(QuickFix.Fields.Account val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Account val) 
            { 
                return isSetAccount();
            }
            
            public bool isSetAccount() 
            { 
                return isSetField(Tags.Account);
            }
            public QuickFix.Fields.AcctIDSource acctIDSource
            { 
                get 
                {
                    QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AcctIDSource val) 
            { 
                this.acctIDSource = val;
            }
            
            public QuickFix.Fields.AcctIDSource get(QuickFix.Fields.AcctIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AcctIDSource val) 
            { 
                return isSetAcctIDSource();
            }
            
            public bool isSetAcctIDSource() 
            { 
                return isSetField(Tags.AcctIDSource);
            }
            public QuickFix.Fields.AccountType accountType
            { 
                get 
                {
                    QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AccountType val) 
            { 
                this.accountType = val;
            }
            
            public QuickFix.Fields.AccountType get(QuickFix.Fields.AccountType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AccountType val) 
            { 
                return isSetAccountType();
            }
            
            public bool isSetAccountType() 
            { 
                return isSetField(Tags.AccountType);
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
            public QuickFix.Fields.NoQuoteEntries noQuoteEntries
            { 
                get 
                {
                    QuickFix.Fields.NoQuoteEntries val = new QuickFix.Fields.NoQuoteEntries();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoQuoteEntries val) 
            { 
                this.noQuoteEntries = val;
            }
            
            public QuickFix.Fields.NoQuoteEntries get(QuickFix.Fields.NoQuoteEntries val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoQuoteEntries val) 
            { 
                return isSetNoQuoteEntries();
            }
            
            public bool isSetNoQuoteEntries() 
            { 
                return isSetField(Tags.NoQuoteEntries);
            }
            public QuickFix.Fields.QuoteMsgID quoteMsgID
            { 
                get 
                {
                    QuickFix.Fields.QuoteMsgID val = new QuickFix.Fields.QuoteMsgID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuoteMsgID val) 
            { 
                this.quoteMsgID = val;
            }
            
            public QuickFix.Fields.QuoteMsgID get(QuickFix.Fields.QuoteMsgID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuoteMsgID val) 
            { 
                return isSetQuoteMsgID();
            }
            
            public bool isSetQuoteMsgID() 
            { 
                return isSetField(Tags.QuoteMsgID);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID get(QuickFix.Fields.PartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyID val) 
                { 
                    return isSetPartyID();
                }
                
                public bool isSetPartyID() 
                { 
                    return isSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource get(QuickFix.Fields.PartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return isSetPartyIDSource();
                }
                
                public bool isSetPartyIDSource() 
                { 
                    return isSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole get(QuickFix.Fields.PartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyRole val) 
                { 
                    return isSetPartyRole();
                }
                
                public bool isSetPartyRole() 
                { 
                    return isSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    this.noPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return isSetNoPartySubIDs();
                }
                
                public bool isSetNoPartySubIDs() 
                { 
                    return isSetField(Tags.NoPartySubIDs);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.partySubID = val;
                    }
                    
                    public QuickFix.Fields.PartySubID get(QuickFix.Fields.PartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartySubID val) 
                    { 
                        return isSetPartySubID();
                    }
                    
                    public bool isSetPartySubID() 
                    { 
                        return isSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType partySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        this.partySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return isSetPartySubIDType();
                    }
                    
                    public bool isSetPartySubIDType() 
                    { 
                        return isSetField(Tags.PartySubIDType);
                    }
                
                }
            }
            public class NoQuoteEntries : Group
            {
                public NoQuoteEntries() 
                  :base( Tags.NoQuoteEntries, Tags.Symbol, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.AgreementDesc, Tags.AgreementID, Tags.AgreementDate, Tags.AgreementCurrency, Tags.TerminationType, Tags.StartDate, Tags.EndDate, Tags.DeliveryType, Tags.MarginRatio, Tags.NoUnderlyings, Tags.NoLegs, 0};
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
                public QuickFix.Fields.StrikeCurrency strikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeCurrency val) 
                { 
                    this.strikeCurrency = val;
                }
                
                public QuickFix.Fields.StrikeCurrency get(QuickFix.Fields.StrikeCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeCurrency val) 
                { 
                    return isSetStrikeCurrency();
                }
                
                public bool isSetStrikeCurrency() 
                { 
                    return isSetField(Tags.StrikeCurrency);
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
                public QuickFix.Fields.Pool pool
                { 
                    get 
                    {
                        QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Pool val) 
                { 
                    this.pool = val;
                }
                
                public QuickFix.Fields.Pool get(QuickFix.Fields.Pool val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Pool val) 
                { 
                    return isSetPool();
                }
                
                public bool isSetPool() 
                { 
                    return isSetField(Tags.Pool);
                }
                public QuickFix.Fields.ContractSettlMonth contractSettlMonth
                { 
                    get 
                    {
                        QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    this.contractSettlMonth = val;
                }
                
                public QuickFix.Fields.ContractSettlMonth get(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    return isSetContractSettlMonth();
                }
                
                public bool isSetContractSettlMonth() 
                { 
                    return isSetField(Tags.ContractSettlMonth);
                }
                public QuickFix.Fields.CPProgram cPProgram
                { 
                    get 
                    {
                        QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CPProgram val) 
                { 
                    this.cPProgram = val;
                }
                
                public QuickFix.Fields.CPProgram get(QuickFix.Fields.CPProgram val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CPProgram val) 
                { 
                    return isSetCPProgram();
                }
                
                public bool isSetCPProgram() 
                { 
                    return isSetField(Tags.CPProgram);
                }
                public QuickFix.Fields.CPRegType cPRegType
                { 
                    get 
                    {
                        QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CPRegType val) 
                { 
                    this.cPRegType = val;
                }
                
                public QuickFix.Fields.CPRegType get(QuickFix.Fields.CPRegType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CPRegType val) 
                { 
                    return isSetCPRegType();
                }
                
                public bool isSetCPRegType() 
                { 
                    return isSetField(Tags.CPRegType);
                }
                public QuickFix.Fields.NoEvents noEvents
                { 
                    get 
                    {
                        QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoEvents val) 
                { 
                    this.noEvents = val;
                }
                
                public QuickFix.Fields.NoEvents get(QuickFix.Fields.NoEvents val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoEvents val) 
                { 
                    return isSetNoEvents();
                }
                
                public bool isSetNoEvents() 
                { 
                    return isSetField(Tags.NoEvents);
                }
                public QuickFix.Fields.DatedDate datedDate
                { 
                    get 
                    {
                        QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DatedDate val) 
                { 
                    this.datedDate = val;
                }
                
                public QuickFix.Fields.DatedDate get(QuickFix.Fields.DatedDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DatedDate val) 
                { 
                    return isSetDatedDate();
                }
                
                public bool isSetDatedDate() 
                { 
                    return isSetField(Tags.DatedDate);
                }
                public QuickFix.Fields.InterestAccrualDate interestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    this.interestAccrualDate = val;
                }
                
                public QuickFix.Fields.InterestAccrualDate get(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    return isSetInterestAccrualDate();
                }
                
                public bool isSetInterestAccrualDate() 
                { 
                    return isSetField(Tags.InterestAccrualDate);
                }
                public QuickFix.Fields.SecurityStatus securityStatus
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityStatus val) 
                { 
                    this.securityStatus = val;
                }
                
                public QuickFix.Fields.SecurityStatus get(QuickFix.Fields.SecurityStatus val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityStatus val) 
                { 
                    return isSetSecurityStatus();
                }
                
                public bool isSetSecurityStatus() 
                { 
                    return isSetField(Tags.SecurityStatus);
                }
                public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
                { 
                    get 
                    {
                        QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    this.settleOnOpenFlag = val;
                }
                
                public QuickFix.Fields.SettleOnOpenFlag get(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    return isSetSettleOnOpenFlag();
                }
                
                public bool isSetSettleOnOpenFlag() 
                { 
                    return isSetField(Tags.SettleOnOpenFlag);
                }
                public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
                { 
                    get 
                    {
                        QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    this.instrmtAssignmentMethod = val;
                }
                
                public QuickFix.Fields.InstrmtAssignmentMethod get(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    return isSetInstrmtAssignmentMethod();
                }
                
                public bool isSetInstrmtAssignmentMethod() 
                { 
                    return isSetField(Tags.InstrmtAssignmentMethod);
                }
                public QuickFix.Fields.StrikeMultiplier strikeMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    this.strikeMultiplier = val;
                }
                
                public QuickFix.Fields.StrikeMultiplier get(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    return isSetStrikeMultiplier();
                }
                
                public bool isSetStrikeMultiplier() 
                { 
                    return isSetField(Tags.StrikeMultiplier);
                }
                public QuickFix.Fields.StrikeValue strikeValue
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeValue val) 
                { 
                    this.strikeValue = val;
                }
                
                public QuickFix.Fields.StrikeValue get(QuickFix.Fields.StrikeValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeValue val) 
                { 
                    return isSetStrikeValue();
                }
                
                public bool isSetStrikeValue() 
                { 
                    return isSetField(Tags.StrikeValue);
                }
                public QuickFix.Fields.MinPriceIncrement minPriceIncrement
                { 
                    get 
                    {
                        QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    this.minPriceIncrement = val;
                }
                
                public QuickFix.Fields.MinPriceIncrement get(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    return isSetMinPriceIncrement();
                }
                
                public bool isSetMinPriceIncrement() 
                { 
                    return isSetField(Tags.MinPriceIncrement);
                }
                public QuickFix.Fields.PositionLimit positionLimit
                { 
                    get 
                    {
                        QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PositionLimit val) 
                { 
                    this.positionLimit = val;
                }
                
                public QuickFix.Fields.PositionLimit get(QuickFix.Fields.PositionLimit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PositionLimit val) 
                { 
                    return isSetPositionLimit();
                }
                
                public bool isSetPositionLimit() 
                { 
                    return isSetField(Tags.PositionLimit);
                }
                public QuickFix.Fields.NTPositionLimit nTPositionLimit
                { 
                    get 
                    {
                        QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NTPositionLimit val) 
                { 
                    this.nTPositionLimit = val;
                }
                
                public QuickFix.Fields.NTPositionLimit get(QuickFix.Fields.NTPositionLimit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NTPositionLimit val) 
                { 
                    return isSetNTPositionLimit();
                }
                
                public bool isSetNTPositionLimit() 
                { 
                    return isSetField(Tags.NTPositionLimit);
                }
                public QuickFix.Fields.NoInstrumentParties noInstrumentParties
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    this.noInstrumentParties = val;
                }
                
                public QuickFix.Fields.NoInstrumentParties get(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    return isSetNoInstrumentParties();
                }
                
                public bool isSetNoInstrumentParties() 
                { 
                    return isSetField(Tags.NoInstrumentParties);
                }
                public QuickFix.Fields.UnitOfMeasure unitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    this.unitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnitOfMeasure get(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    return isSetUnitOfMeasure();
                }
                
                public bool isSetUnitOfMeasure() 
                { 
                    return isSetField(Tags.UnitOfMeasure);
                }
                public QuickFix.Fields.TimeUnit timeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TimeUnit val) 
                { 
                    this.timeUnit = val;
                }
                
                public QuickFix.Fields.TimeUnit get(QuickFix.Fields.TimeUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TimeUnit val) 
                { 
                    return isSetTimeUnit();
                }
                
                public bool isSetTimeUnit() 
                { 
                    return isSetField(Tags.TimeUnit);
                }
                public QuickFix.Fields.MaturityTime maturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityTime val) 
                { 
                    this.maturityTime = val;
                }
                
                public QuickFix.Fields.MaturityTime get(QuickFix.Fields.MaturityTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityTime val) 
                { 
                    return isSetMaturityTime();
                }
                
                public bool isSetMaturityTime() 
                { 
                    return isSetField(Tags.MaturityTime);
                }
                public QuickFix.Fields.SecurityGroup securityGroup
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityGroup val) 
                { 
                    this.securityGroup = val;
                }
                
                public QuickFix.Fields.SecurityGroup get(QuickFix.Fields.SecurityGroup val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityGroup val) 
                { 
                    return isSetSecurityGroup();
                }
                
                public bool isSetSecurityGroup() 
                { 
                    return isSetField(Tags.SecurityGroup);
                }
                public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
                { 
                    get 
                    {
                        QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    this.minPriceIncrementAmount = val;
                }
                
                public QuickFix.Fields.MinPriceIncrementAmount get(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    return isSetMinPriceIncrementAmount();
                }
                
                public bool isSetMinPriceIncrementAmount() 
                { 
                    return isSetField(Tags.MinPriceIncrementAmount);
                }
                public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    this.unitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnitOfMeasureQty get(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    return isSetUnitOfMeasureQty();
                }
                
                public bool isSetUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.UnitOfMeasureQty);
                }
                public QuickFix.Fields.SecurityXMLLen securityXMLLen
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    this.securityXMLLen = val;
                }
                
                public QuickFix.Fields.SecurityXMLLen get(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    return isSetSecurityXMLLen();
                }
                
                public bool isSetSecurityXMLLen() 
                { 
                    return isSetField(Tags.SecurityXMLLen);
                }
                public QuickFix.Fields.SecurityXML securityXML
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXML val) 
                { 
                    this.securityXML = val;
                }
                
                public QuickFix.Fields.SecurityXML get(QuickFix.Fields.SecurityXML val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXML val) 
                { 
                    return isSetSecurityXML();
                }
                
                public bool isSetSecurityXML() 
                { 
                    return isSetField(Tags.SecurityXML);
                }
                public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    this.securityXMLSchema = val;
                }
                
                public QuickFix.Fields.SecurityXMLSchema get(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    return isSetSecurityXMLSchema();
                }
                
                public bool isSetSecurityXMLSchema() 
                { 
                    return isSetField(Tags.SecurityXMLSchema);
                }
                public QuickFix.Fields.ProductComplex productComplex
                { 
                    get 
                    {
                        QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ProductComplex val) 
                { 
                    this.productComplex = val;
                }
                
                public QuickFix.Fields.ProductComplex get(QuickFix.Fields.ProductComplex val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ProductComplex val) 
                { 
                    return isSetProductComplex();
                }
                
                public bool isSetProductComplex() 
                { 
                    return isSetField(Tags.ProductComplex);
                }
                public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    this.priceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasure get(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    return isSetPriceUnitOfMeasure();
                }
                
                public bool isSetPriceUnitOfMeasure() 
                { 
                    return isSetField(Tags.PriceUnitOfMeasure);
                }
                public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    this.priceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasureQty get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    return isSetPriceUnitOfMeasureQty();
                }
                
                public bool isSetPriceUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.PriceUnitOfMeasureQty);
                }
                public QuickFix.Fields.SettlMethod settlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlMethod val) 
                { 
                    this.settlMethod = val;
                }
                
                public QuickFix.Fields.SettlMethod get(QuickFix.Fields.SettlMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlMethod val) 
                { 
                    return isSetSettlMethod();
                }
                
                public bool isSetSettlMethod() 
                { 
                    return isSetField(Tags.SettlMethod);
                }
                public QuickFix.Fields.ExerciseStyle exerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExerciseStyle val) 
                { 
                    this.exerciseStyle = val;
                }
                
                public QuickFix.Fields.ExerciseStyle get(QuickFix.Fields.ExerciseStyle val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExerciseStyle val) 
                { 
                    return isSetExerciseStyle();
                }
                
                public bool isSetExerciseStyle() 
                { 
                    return isSetField(Tags.ExerciseStyle);
                }
                public QuickFix.Fields.OptPayAmount optPayAmount
                { 
                    get 
                    {
                        QuickFix.Fields.OptPayAmount val = new QuickFix.Fields.OptPayAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptPayAmount val) 
                { 
                    this.optPayAmount = val;
                }
                
                public QuickFix.Fields.OptPayAmount get(QuickFix.Fields.OptPayAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptPayAmount val) 
                { 
                    return isSetOptPayAmount();
                }
                
                public bool isSetOptPayAmount() 
                { 
                    return isSetField(Tags.OptPayAmount);
                }
                public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
                { 
                    get 
                    {
                        QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    this.priceQuoteMethod = val;
                }
                
                public QuickFix.Fields.PriceQuoteMethod get(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    return isSetPriceQuoteMethod();
                }
                
                public bool isSetPriceQuoteMethod() 
                { 
                    return isSetField(Tags.PriceQuoteMethod);
                }
                public QuickFix.Fields.ListMethod listMethod
                { 
                    get 
                    {
                        QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListMethod val) 
                { 
                    this.listMethod = val;
                }
                
                public QuickFix.Fields.ListMethod get(QuickFix.Fields.ListMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListMethod val) 
                { 
                    return isSetListMethod();
                }
                
                public bool isSetListMethod() 
                { 
                    return isSetField(Tags.ListMethod);
                }
                public QuickFix.Fields.CapPrice capPrice
                { 
                    get 
                    {
                        QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CapPrice val) 
                { 
                    this.capPrice = val;
                }
                
                public QuickFix.Fields.CapPrice get(QuickFix.Fields.CapPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CapPrice val) 
                { 
                    return isSetCapPrice();
                }
                
                public bool isSetCapPrice() 
                { 
                    return isSetField(Tags.CapPrice);
                }
                public QuickFix.Fields.FloorPrice floorPrice
                { 
                    get 
                    {
                        QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FloorPrice val) 
                { 
                    this.floorPrice = val;
                }
                
                public QuickFix.Fields.FloorPrice get(QuickFix.Fields.FloorPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FloorPrice val) 
                { 
                    return isSetFloorPrice();
                }
                
                public bool isSetFloorPrice() 
                { 
                    return isSetField(Tags.FloorPrice);
                }
                public QuickFix.Fields.PutOrCall putOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PutOrCall val) 
                { 
                    this.putOrCall = val;
                }
                
                public QuickFix.Fields.PutOrCall get(QuickFix.Fields.PutOrCall val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PutOrCall val) 
                { 
                    return isSetPutOrCall();
                }
                
                public bool isSetPutOrCall() 
                { 
                    return isSetField(Tags.PutOrCall);
                }
                public QuickFix.Fields.FlexibleIndicator flexibleIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    this.flexibleIndicator = val;
                }
                
                public QuickFix.Fields.FlexibleIndicator get(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    return isSetFlexibleIndicator();
                }
                
                public bool isSetFlexibleIndicator() 
                { 
                    return isSetField(Tags.FlexibleIndicator);
                }
                public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    this.flexProductEligibilityIndicator = val;
                }
                
                public QuickFix.Fields.FlexProductEligibilityIndicator get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    return isSetFlexProductEligibilityIndicator();
                }
                
                public bool isSetFlexProductEligibilityIndicator() 
                { 
                    return isSetField(Tags.FlexProductEligibilityIndicator);
                }
                public QuickFix.Fields.FuturesValuationMethod futuresValuationMethod
                { 
                    get 
                    {
                        QuickFix.Fields.FuturesValuationMethod val = new QuickFix.Fields.FuturesValuationMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    this.futuresValuationMethod = val;
                }
                
                public QuickFix.Fields.FuturesValuationMethod get(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    return isSetFuturesValuationMethod();
                }
                
                public bool isSetFuturesValuationMethod() 
                { 
                    return isSetField(Tags.FuturesValuationMethod);
                }
                public QuickFix.Fields.AgreementDesc agreementDesc
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementDesc val = new QuickFix.Fields.AgreementDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AgreementDesc val) 
                { 
                    this.agreementDesc = val;
                }
                
                public QuickFix.Fields.AgreementDesc get(QuickFix.Fields.AgreementDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AgreementDesc val) 
                { 
                    return isSetAgreementDesc();
                }
                
                public bool isSetAgreementDesc() 
                { 
                    return isSetField(Tags.AgreementDesc);
                }
                public QuickFix.Fields.AgreementID agreementID
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementID val = new QuickFix.Fields.AgreementID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AgreementID val) 
                { 
                    this.agreementID = val;
                }
                
                public QuickFix.Fields.AgreementID get(QuickFix.Fields.AgreementID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AgreementID val) 
                { 
                    return isSetAgreementID();
                }
                
                public bool isSetAgreementID() 
                { 
                    return isSetField(Tags.AgreementID);
                }
                public QuickFix.Fields.AgreementDate agreementDate
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementDate val = new QuickFix.Fields.AgreementDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AgreementDate val) 
                { 
                    this.agreementDate = val;
                }
                
                public QuickFix.Fields.AgreementDate get(QuickFix.Fields.AgreementDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AgreementDate val) 
                { 
                    return isSetAgreementDate();
                }
                
                public bool isSetAgreementDate() 
                { 
                    return isSetField(Tags.AgreementDate);
                }
                public QuickFix.Fields.AgreementCurrency agreementCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementCurrency val = new QuickFix.Fields.AgreementCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AgreementCurrency val) 
                { 
                    this.agreementCurrency = val;
                }
                
                public QuickFix.Fields.AgreementCurrency get(QuickFix.Fields.AgreementCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AgreementCurrency val) 
                { 
                    return isSetAgreementCurrency();
                }
                
                public bool isSetAgreementCurrency() 
                { 
                    return isSetField(Tags.AgreementCurrency);
                }
                public QuickFix.Fields.TerminationType terminationType
                { 
                    get 
                    {
                        QuickFix.Fields.TerminationType val = new QuickFix.Fields.TerminationType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TerminationType val) 
                { 
                    this.terminationType = val;
                }
                
                public QuickFix.Fields.TerminationType get(QuickFix.Fields.TerminationType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TerminationType val) 
                { 
                    return isSetTerminationType();
                }
                
                public bool isSetTerminationType() 
                { 
                    return isSetField(Tags.TerminationType);
                }
                public QuickFix.Fields.StartDate startDate
                { 
                    get 
                    {
                        QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StartDate val) 
                { 
                    this.startDate = val;
                }
                
                public QuickFix.Fields.StartDate get(QuickFix.Fields.StartDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StartDate val) 
                { 
                    return isSetStartDate();
                }
                
                public bool isSetStartDate() 
                { 
                    return isSetField(Tags.StartDate);
                }
                public QuickFix.Fields.EndDate endDate
                { 
                    get 
                    {
                        QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EndDate val) 
                { 
                    this.endDate = val;
                }
                
                public QuickFix.Fields.EndDate get(QuickFix.Fields.EndDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EndDate val) 
                { 
                    return isSetEndDate();
                }
                
                public bool isSetEndDate() 
                { 
                    return isSetField(Tags.EndDate);
                }
                public QuickFix.Fields.DeliveryType deliveryType
                { 
                    get 
                    {
                        QuickFix.Fields.DeliveryType val = new QuickFix.Fields.DeliveryType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeliveryType val) 
                { 
                    this.deliveryType = val;
                }
                
                public QuickFix.Fields.DeliveryType get(QuickFix.Fields.DeliveryType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeliveryType val) 
                { 
                    return isSetDeliveryType();
                }
                
                public bool isSetDeliveryType() 
                { 
                    return isSetField(Tags.DeliveryType);
                }
                public QuickFix.Fields.MarginRatio marginRatio
                { 
                    get 
                    {
                        QuickFix.Fields.MarginRatio val = new QuickFix.Fields.MarginRatio();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MarginRatio val) 
                { 
                    this.marginRatio = val;
                }
                
                public QuickFix.Fields.MarginRatio get(QuickFix.Fields.MarginRatio val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MarginRatio val) 
                { 
                    return isSetMarginRatio();
                }
                
                public bool isSetMarginRatio() 
                { 
                    return isSetField(Tags.MarginRatio);
                }
                public QuickFix.Fields.NoUnderlyings noUnderlyings
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUnderlyings val) 
                { 
                    this.noUnderlyings = val;
                }
                
                public QuickFix.Fields.NoUnderlyings get(QuickFix.Fields.NoUnderlyings val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUnderlyings val) 
                { 
                    return isSetNoUnderlyings();
                }
                
                public bool isSetNoUnderlyings() 
                { 
                    return isSetField(Tags.NoUnderlyings);
                }
                public QuickFix.Fields.NoLegs noLegs
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoLegs val) 
                { 
                    this.noLegs = val;
                }
                
                public QuickFix.Fields.NoLegs get(QuickFix.Fields.NoLegs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoLegs val) 
                { 
                    return isSetNoLegs();
                }
                
                public bool isSetNoLegs() 
                { 
                    return isSetField(Tags.NoLegs);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventType val) 
                    { 
                        this.eventType = val;
                    }
                    
                    public QuickFix.Fields.EventType get(QuickFix.Fields.EventType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventType val) 
                    { 
                        return isSetEventType();
                    }
                    
                    public bool isSetEventType() 
                    { 
                        return isSetField(Tags.EventType);
                    }
                    public QuickFix.Fields.EventDate eventDate
                    { 
                        get 
                        {
                            QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventDate val) 
                    { 
                        this.eventDate = val;
                    }
                    
                    public QuickFix.Fields.EventDate get(QuickFix.Fields.EventDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventDate val) 
                    { 
                        return isSetEventDate();
                    }
                    
                    public bool isSetEventDate() 
                    { 
                        return isSetField(Tags.EventDate);
                    }
                    public QuickFix.Fields.EventPx eventPx
                    { 
                        get 
                        {
                            QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventPx val) 
                    { 
                        this.eventPx = val;
                    }
                    
                    public QuickFix.Fields.EventPx get(QuickFix.Fields.EventPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventPx val) 
                    { 
                        return isSetEventPx();
                    }
                    
                    public bool isSetEventPx() 
                    { 
                        return isSetField(Tags.EventPx);
                    }
                    public QuickFix.Fields.EventText eventText
                    { 
                        get 
                        {
                            QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventText val) 
                    { 
                        this.eventText = val;
                    }
                    
                    public QuickFix.Fields.EventText get(QuickFix.Fields.EventText val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventText val) 
                    { 
                        return isSetEventText();
                    }
                    
                    public bool isSetEventText() 
                    { 
                        return isSetField(Tags.EventText);
                    }
                    public QuickFix.Fields.EventTime eventTime
                    { 
                        get 
                        {
                            QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventTime val) 
                    { 
                        this.eventTime = val;
                    }
                    
                    public QuickFix.Fields.EventTime get(QuickFix.Fields.EventTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventTime val) 
                    { 
                        return isSetEventTime();
                    }
                    
                    public bool isSetEventTime() 
                    { 
                        return isSetField(Tags.EventTime);
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
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        this.instrumentPartyID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyID get(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        return isSetInstrumentPartyID();
                    }
                    
                    public bool isSetInstrumentPartyID() 
                    { 
                        return isSetField(Tags.InstrumentPartyID);
                    }
                    public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        this.instrumentPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyIDSource get(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        return isSetInstrumentPartyIDSource();
                    }
                    
                    public bool isSetInstrumentPartyIDSource() 
                    { 
                        return isSetField(Tags.InstrumentPartyIDSource);
                    }
                    public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        this.instrumentPartyRole = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyRole get(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        return isSetInstrumentPartyRole();
                    }
                    
                    public bool isSetInstrumentPartyRole() 
                    { 
                        return isSetField(Tags.InstrumentPartyRole);
                    }
                    public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        this.noInstrumentPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoInstrumentPartySubIDs get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        return isSetNoInstrumentPartySubIDs();
                    }
                    
                    public bool isSetNoInstrumentPartySubIDs() 
                    { 
                        return isSetField(Tags.NoInstrumentPartySubIDs);
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
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            this.instrumentPartySubID = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubID get(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            return isSetInstrumentPartySubID();
                        }
                        
                        public bool isSetInstrumentPartySubID() 
                        { 
                            return isSetField(Tags.InstrumentPartySubID);
                        }
                        public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            this.instrumentPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubIDType get(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            return isSetInstrumentPartySubIDType();
                        }
                        
                        public bool isSetInstrumentPartySubIDType() 
                        { 
                            return isSetField(Tags.InstrumentPartySubIDType);
                        }
                    
                    }
                }
                public class NoUnderlyings : Group
                {
                    public NoUnderlyings() 
                      :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, 0};
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
                          :base( Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                                            public QuickFix.Fields.UndlyInstrumentPartyID undlyInstrumentPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.UndlyInstrumentPartyID val = new QuickFix.Fields.UndlyInstrumentPartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UndlyInstrumentPartyID val) 
                        { 
                            this.undlyInstrumentPartyID = val;
                        }
                        
                        public QuickFix.Fields.UndlyInstrumentPartyID get(QuickFix.Fields.UndlyInstrumentPartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UndlyInstrumentPartyID val) 
                        { 
                            return isSetUndlyInstrumentPartyID();
                        }
                        
                        public bool isSetUndlyInstrumentPartyID() 
                        { 
                            return isSetField(Tags.UndlyInstrumentPartyID);
                        }
                        public QuickFix.Fields.UndlyInstrumentPartyIDSource undlyInstrumentPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.UndlyInstrumentPartyIDSource val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                        { 
                            this.undlyInstrumentPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.UndlyInstrumentPartyIDSource get(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                        { 
                            return isSetUndlyInstrumentPartyIDSource();
                        }
                        
                        public bool isSetUndlyInstrumentPartyIDSource() 
                        { 
                            return isSetField(Tags.UndlyInstrumentPartyIDSource);
                        }
                        public QuickFix.Fields.UndlyInstrumentPartyRole undlyInstrumentPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.UndlyInstrumentPartyRole val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                        { 
                            this.undlyInstrumentPartyRole = val;
                        }
                        
                        public QuickFix.Fields.UndlyInstrumentPartyRole get(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                        { 
                            return isSetUndlyInstrumentPartyRole();
                        }
                        
                        public bool isSetUndlyInstrumentPartyRole() 
                        { 
                            return isSetField(Tags.UndlyInstrumentPartyRole);
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
                              :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};
                                                    public QuickFix.Fields.UndlyInstrumentPartySubID undlyInstrumentPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.UndlyInstrumentPartySubID val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                            { 
                                this.undlyInstrumentPartySubID = val;
                            }
                            
                            public QuickFix.Fields.UndlyInstrumentPartySubID get(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                            { 
                                return isSetUndlyInstrumentPartySubID();
                            }
                            
                            public bool isSetUndlyInstrumentPartySubID() 
                            { 
                                return isSetField(Tags.UndlyInstrumentPartySubID);
                            }
                            public QuickFix.Fields.UndlyInstrumentPartySubIDType undlyInstrumentPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.UndlyInstrumentPartySubIDType val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                            { 
                                this.undlyInstrumentPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.UndlyInstrumentPartySubIDType get(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                            { 
                                return isSetUndlyInstrumentPartySubIDType();
                            }
                            
                            public bool isSetUndlyInstrumentPartySubIDType() 
                            { 
                                return isSetField(Tags.UndlyInstrumentPartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoLegs : Group
                {
                    public NoLegs() 
                      :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, 0};
                                    public QuickFix.Fields.LegSymbol legSymbol
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSymbol val) 
                    { 
                        this.legSymbol = val;
                    }
                    
                    public QuickFix.Fields.LegSymbol get(QuickFix.Fields.LegSymbol val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSymbol val) 
                    { 
                        return isSetLegSymbol();
                    }
                    
                    public bool isSetLegSymbol() 
                    { 
                        return isSetField(Tags.LegSymbol);
                    }
                    public QuickFix.Fields.LegSymbolSfx legSymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        this.legSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.LegSymbolSfx get(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        return isSetLegSymbolSfx();
                    }
                    
                    public bool isSetLegSymbolSfx() 
                    { 
                        return isSetField(Tags.LegSymbolSfx);
                    }
                    public QuickFix.Fields.LegSecurityID legSecurityID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityID val) 
                    { 
                        this.legSecurityID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityID get(QuickFix.Fields.LegSecurityID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityID val) 
                    { 
                        return isSetLegSecurityID();
                    }
                    
                    public bool isSetLegSecurityID() 
                    { 
                        return isSetField(Tags.LegSecurityID);
                    }
                    public QuickFix.Fields.LegSecurityIDSource legSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        this.legSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityIDSource get(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        return isSetLegSecurityIDSource();
                    }
                    
                    public bool isSetLegSecurityIDSource() 
                    { 
                        return isSetField(Tags.LegSecurityIDSource);
                    }
                    public QuickFix.Fields.NoLegSecurityAltID noLegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        this.noLegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoLegSecurityAltID get(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        return isSetNoLegSecurityAltID();
                    }
                    
                    public bool isSetNoLegSecurityAltID() 
                    { 
                        return isSetField(Tags.NoLegSecurityAltID);
                    }
                    public QuickFix.Fields.LegProduct legProduct
                    { 
                        get 
                        {
                            QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegProduct val) 
                    { 
                        this.legProduct = val;
                    }
                    
                    public QuickFix.Fields.LegProduct get(QuickFix.Fields.LegProduct val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegProduct val) 
                    { 
                        return isSetLegProduct();
                    }
                    
                    public bool isSetLegProduct() 
                    { 
                        return isSetField(Tags.LegProduct);
                    }
                    public QuickFix.Fields.LegCFICode legCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCFICode val) 
                    { 
                        this.legCFICode = val;
                    }
                    
                    public QuickFix.Fields.LegCFICode get(QuickFix.Fields.LegCFICode val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCFICode val) 
                    { 
                        return isSetLegCFICode();
                    }
                    
                    public bool isSetLegCFICode() 
                    { 
                        return isSetField(Tags.LegCFICode);
                    }
                    public QuickFix.Fields.LegSecurityType legSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityType val) 
                    { 
                        this.legSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityType get(QuickFix.Fields.LegSecurityType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityType val) 
                    { 
                        return isSetLegSecurityType();
                    }
                    
                    public bool isSetLegSecurityType() 
                    { 
                        return isSetField(Tags.LegSecurityType);
                    }
                    public QuickFix.Fields.LegSecuritySubType legSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        this.legSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.LegSecuritySubType get(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        return isSetLegSecuritySubType();
                    }
                    
                    public bool isSetLegSecuritySubType() 
                    { 
                        return isSetField(Tags.LegSecuritySubType);
                    }
                    public QuickFix.Fields.LegMaturityMonthYear legMaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        this.legMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityMonthYear get(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        return isSetLegMaturityMonthYear();
                    }
                    
                    public bool isSetLegMaturityMonthYear() 
                    { 
                        return isSetField(Tags.LegMaturityMonthYear);
                    }
                    public QuickFix.Fields.LegMaturityDate legMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        this.legMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityDate get(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        return isSetLegMaturityDate();
                    }
                    
                    public bool isSetLegMaturityDate() 
                    { 
                        return isSetField(Tags.LegMaturityDate);
                    }
                    public QuickFix.Fields.LegCouponPaymentDate legCouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        this.legCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponPaymentDate get(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        return isSetLegCouponPaymentDate();
                    }
                    
                    public bool isSetLegCouponPaymentDate() 
                    { 
                        return isSetField(Tags.LegCouponPaymentDate);
                    }
                    public QuickFix.Fields.LegIssueDate legIssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegIssueDate val) 
                    { 
                        this.legIssueDate = val;
                    }
                    
                    public QuickFix.Fields.LegIssueDate get(QuickFix.Fields.LegIssueDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegIssueDate val) 
                    { 
                        return isSetLegIssueDate();
                    }
                    
                    public bool isSetLegIssueDate() 
                    { 
                        return isSetField(Tags.LegIssueDate);
                    }
                    public QuickFix.Fields.LegRepoCollateralSecurityType legRepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        this.legRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegRepoCollateralSecurityType get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        return isSetLegRepoCollateralSecurityType();
                    }
                    
                    public bool isSetLegRepoCollateralSecurityType() 
                    { 
                        return isSetField(Tags.LegRepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.LegRepurchaseTerm legRepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        this.legRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseTerm get(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        return isSetLegRepurchaseTerm();
                    }
                    
                    public bool isSetLegRepurchaseTerm() 
                    { 
                        return isSetField(Tags.LegRepurchaseTerm);
                    }
                    public QuickFix.Fields.LegRepurchaseRate legRepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        this.legRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseRate get(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        return isSetLegRepurchaseRate();
                    }
                    
                    public bool isSetLegRepurchaseRate() 
                    { 
                        return isSetField(Tags.LegRepurchaseRate);
                    }
                    public QuickFix.Fields.LegFactor legFactor
                    { 
                        get 
                        {
                            QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegFactor val) 
                    { 
                        this.legFactor = val;
                    }
                    
                    public QuickFix.Fields.LegFactor get(QuickFix.Fields.LegFactor val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegFactor val) 
                    { 
                        return isSetLegFactor();
                    }
                    
                    public bool isSetLegFactor() 
                    { 
                        return isSetField(Tags.LegFactor);
                    }
                    public QuickFix.Fields.LegCreditRating legCreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCreditRating val) 
                    { 
                        this.legCreditRating = val;
                    }
                    
                    public QuickFix.Fields.LegCreditRating get(QuickFix.Fields.LegCreditRating val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCreditRating val) 
                    { 
                        return isSetLegCreditRating();
                    }
                    
                    public bool isSetLegCreditRating() 
                    { 
                        return isSetField(Tags.LegCreditRating);
                    }
                    public QuickFix.Fields.LegInstrRegistry legInstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        this.legInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.LegInstrRegistry get(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        return isSetLegInstrRegistry();
                    }
                    
                    public bool isSetLegInstrRegistry() 
                    { 
                        return isSetField(Tags.LegInstrRegistry);
                    }
                    public QuickFix.Fields.LegCountryOfIssue legCountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        this.legCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegCountryOfIssue get(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        return isSetLegCountryOfIssue();
                    }
                    
                    public bool isSetLegCountryOfIssue() 
                    { 
                        return isSetField(Tags.LegCountryOfIssue);
                    }
                    public QuickFix.Fields.LegStateOrProvinceOfIssue legStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        this.legStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegStateOrProvinceOfIssue get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        return isSetLegStateOrProvinceOfIssue();
                    }
                    
                    public bool isSetLegStateOrProvinceOfIssue() 
                    { 
                        return isSetField(Tags.LegStateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.LegLocaleOfIssue legLocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        this.legLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegLocaleOfIssue get(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        return isSetLegLocaleOfIssue();
                    }
                    
                    public bool isSetLegLocaleOfIssue() 
                    { 
                        return isSetField(Tags.LegLocaleOfIssue);
                    }
                    public QuickFix.Fields.LegRedemptionDate legRedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        this.legRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.LegRedemptionDate get(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        return isSetLegRedemptionDate();
                    }
                    
                    public bool isSetLegRedemptionDate() 
                    { 
                        return isSetField(Tags.LegRedemptionDate);
                    }
                    public QuickFix.Fields.LegStrikePrice legStrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        this.legStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.LegStrikePrice get(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        return isSetLegStrikePrice();
                    }
                    
                    public bool isSetLegStrikePrice() 
                    { 
                        return isSetField(Tags.LegStrikePrice);
                    }
                    public QuickFix.Fields.LegStrikeCurrency legStrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        this.legStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegStrikeCurrency get(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        return isSetLegStrikeCurrency();
                    }
                    
                    public bool isSetLegStrikeCurrency() 
                    { 
                        return isSetField(Tags.LegStrikeCurrency);
                    }
                    public QuickFix.Fields.LegOptAttribute legOptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        this.legOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.LegOptAttribute get(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        return isSetLegOptAttribute();
                    }
                    
                    public bool isSetLegOptAttribute() 
                    { 
                        return isSetField(Tags.LegOptAttribute);
                    }
                    public QuickFix.Fields.LegContractMultiplier legContractMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        this.legContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplier get(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        return isSetLegContractMultiplier();
                    }
                    
                    public bool isSetLegContractMultiplier() 
                    { 
                        return isSetField(Tags.LegContractMultiplier);
                    }
                    public QuickFix.Fields.LegCouponRate legCouponRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCouponRate val) 
                    { 
                        this.legCouponRate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponRate get(QuickFix.Fields.LegCouponRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCouponRate val) 
                    { 
                        return isSetLegCouponRate();
                    }
                    
                    public bool isSetLegCouponRate() 
                    { 
                        return isSetField(Tags.LegCouponRate);
                    }
                    public QuickFix.Fields.LegSecurityExchange legSecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        this.legSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityExchange get(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        return isSetLegSecurityExchange();
                    }
                    
                    public bool isSetLegSecurityExchange() 
                    { 
                        return isSetField(Tags.LegSecurityExchange);
                    }
                    public QuickFix.Fields.LegIssuer legIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegIssuer val) 
                    { 
                        this.legIssuer = val;
                    }
                    
                    public QuickFix.Fields.LegIssuer get(QuickFix.Fields.LegIssuer val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegIssuer val) 
                    { 
                        return isSetLegIssuer();
                    }
                    
                    public bool isSetLegIssuer() 
                    { 
                        return isSetField(Tags.LegIssuer);
                    }
                    public QuickFix.Fields.EncodedLegIssuerLen encodedLegIssuerLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        this.encodedLegIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuerLen get(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        return isSetEncodedLegIssuerLen();
                    }
                    
                    public bool isSetEncodedLegIssuerLen() 
                    { 
                        return isSetField(Tags.EncodedLegIssuerLen);
                    }
                    public QuickFix.Fields.EncodedLegIssuer encodedLegIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        this.encodedLegIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuer get(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        return isSetEncodedLegIssuer();
                    }
                    
                    public bool isSetEncodedLegIssuer() 
                    { 
                        return isSetField(Tags.EncodedLegIssuer);
                    }
                    public QuickFix.Fields.LegSecurityDesc legSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        this.legSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityDesc get(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        return isSetLegSecurityDesc();
                    }
                    
                    public bool isSetLegSecurityDesc() 
                    { 
                        return isSetField(Tags.LegSecurityDesc);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDescLen encodedLegSecurityDescLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        this.encodedLegSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDescLen get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        return isSetEncodedLegSecurityDescLen();
                    }
                    
                    public bool isSetEncodedLegSecurityDescLen() 
                    { 
                        return isSetField(Tags.EncodedLegSecurityDescLen);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDesc encodedLegSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        this.encodedLegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDesc get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        return isSetEncodedLegSecurityDesc();
                    }
                    
                    public bool isSetEncodedLegSecurityDesc() 
                    { 
                        return isSetField(Tags.EncodedLegSecurityDesc);
                    }
                    public QuickFix.Fields.LegRatioQty legRatioQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRatioQty val) 
                    { 
                        this.legRatioQty = val;
                    }
                    
                    public QuickFix.Fields.LegRatioQty get(QuickFix.Fields.LegRatioQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRatioQty val) 
                    { 
                        return isSetLegRatioQty();
                    }
                    
                    public bool isSetLegRatioQty() 
                    { 
                        return isSetField(Tags.LegRatioQty);
                    }
                    public QuickFix.Fields.LegSide legSide
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSide val) 
                    { 
                        this.legSide = val;
                    }
                    
                    public QuickFix.Fields.LegSide get(QuickFix.Fields.LegSide val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSide val) 
                    { 
                        return isSetLegSide();
                    }
                    
                    public bool isSetLegSide() 
                    { 
                        return isSetField(Tags.LegSide);
                    }
                    public QuickFix.Fields.LegCurrency legCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCurrency val) 
                    { 
                        this.legCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegCurrency get(QuickFix.Fields.LegCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCurrency val) 
                    { 
                        return isSetLegCurrency();
                    }
                    
                    public bool isSetLegCurrency() 
                    { 
                        return isSetField(Tags.LegCurrency);
                    }
                    public QuickFix.Fields.LegPool legPool
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPool val) 
                    { 
                        this.legPool = val;
                    }
                    
                    public QuickFix.Fields.LegPool get(QuickFix.Fields.LegPool val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPool val) 
                    { 
                        return isSetLegPool();
                    }
                    
                    public bool isSetLegPool() 
                    { 
                        return isSetField(Tags.LegPool);
                    }
                    public QuickFix.Fields.LegDatedDate legDatedDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegDatedDate val) 
                    { 
                        this.legDatedDate = val;
                    }
                    
                    public QuickFix.Fields.LegDatedDate get(QuickFix.Fields.LegDatedDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegDatedDate val) 
                    { 
                        return isSetLegDatedDate();
                    }
                    
                    public bool isSetLegDatedDate() 
                    { 
                        return isSetField(Tags.LegDatedDate);
                    }
                    public QuickFix.Fields.LegContractSettlMonth legContractSettlMonth
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        this.legContractSettlMonth = val;
                    }
                    
                    public QuickFix.Fields.LegContractSettlMonth get(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        return isSetLegContractSettlMonth();
                    }
                    
                    public bool isSetLegContractSettlMonth() 
                    { 
                        return isSetField(Tags.LegContractSettlMonth);
                    }
                    public QuickFix.Fields.LegInterestAccrualDate legInterestAccrualDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        this.legInterestAccrualDate = val;
                    }
                    
                    public QuickFix.Fields.LegInterestAccrualDate get(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        return isSetLegInterestAccrualDate();
                    }
                    
                    public bool isSetLegInterestAccrualDate() 
                    { 
                        return isSetField(Tags.LegInterestAccrualDate);
                    }
                    public QuickFix.Fields.LegUnitOfMeasure legUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        this.legUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure get(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        return isSetLegUnitOfMeasure();
                    }
                    
                    public bool isSetLegUnitOfMeasure() 
                    { 
                        return isSetField(Tags.LegUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegTimeUnit legTimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        this.legTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.LegTimeUnit get(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        return isSetLegTimeUnit();
                    }
                    
                    public bool isSetLegTimeUnit() 
                    { 
                        return isSetField(Tags.LegTimeUnit);
                    }
                    public QuickFix.Fields.LegOptionRatio legOptionRatio
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptionRatio val = new QuickFix.Fields.LegOptionRatio();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        this.legOptionRatio = val;
                    }
                    
                    public QuickFix.Fields.LegOptionRatio get(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        return isSetLegOptionRatio();
                    }
                    
                    public bool isSetLegOptionRatio() 
                    { 
                        return isSetField(Tags.LegOptionRatio);
                    }
                    public QuickFix.Fields.LegPrice legPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPrice val) 
                    { 
                        this.legPrice = val;
                    }
                    
                    public QuickFix.Fields.LegPrice get(QuickFix.Fields.LegPrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPrice val) 
                    { 
                        return isSetLegPrice();
                    }
                    
                    public bool isSetLegPrice() 
                    { 
                        return isSetField(Tags.LegPrice);
                    }
                    public QuickFix.Fields.LegMaturityTime legMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityTime val = new QuickFix.Fields.LegMaturityTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        this.legMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityTime get(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        return isSetLegMaturityTime();
                    }
                    
                    public bool isSetLegMaturityTime() 
                    { 
                        return isSetField(Tags.LegMaturityTime);
                    }
                    public QuickFix.Fields.LegPutOrCall legPutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPutOrCall val = new QuickFix.Fields.LegPutOrCall();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        this.legPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.LegPutOrCall get(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        return isSetLegPutOrCall();
                    }
                    
                    public bool isSetLegPutOrCall() 
                    { 
                        return isSetField(Tags.LegPutOrCall);
                    }
                    public QuickFix.Fields.LegExerciseStyle legExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.LegExerciseStyle val = new QuickFix.Fields.LegExerciseStyle();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        this.legExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle get(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        return isSetLegExerciseStyle();
                    }
                    
                    public bool isSetLegExerciseStyle() 
                    { 
                        return isSetField(Tags.LegExerciseStyle);
                    }
                    public QuickFix.Fields.LegUnitOfMeasureQty legUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasureQty val = new QuickFix.Fields.LegUnitOfMeasureQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        this.legUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        return isSetLegUnitOfMeasureQty();
                    }
                    
                    public bool isSetLegUnitOfMeasureQty() 
                    { 
                        return isSetField(Tags.LegUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasure legPriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasure val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        this.legPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        return isSetLegPriceUnitOfMeasure();
                    }
                    
                    public bool isSetLegPriceUnitOfMeasure() 
                    { 
                        return isSetField(Tags.LegPriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty legPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasureQty val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        this.legPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        return isSetLegPriceUnitOfMeasureQty();
                    }
                    
                    public bool isSetLegPriceUnitOfMeasureQty() 
                    { 
                        return isSetField(Tags.LegPriceUnitOfMeasureQty);
                    }
                                    public class NoLegSecurityAltID : Group
                    {
                        public NoLegSecurityAltID() 
                          :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                                            public QuickFix.Fields.LegSecurityAltID legSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            this.legSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltID get(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            return isSetLegSecurityAltID();
                        }
                        
                        public bool isSetLegSecurityAltID() 
                        { 
                            return isSetField(Tags.LegSecurityAltID);
                        }
                        public QuickFix.Fields.LegSecurityAltIDSource legSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            this.legSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltIDSource get(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            return isSetLegSecurityAltIDSource();
                        }
                        
                        public bool isSetLegSecurityAltIDSource() 
                        { 
                            return isSetField(Tags.LegSecurityAltIDSource);
                        }
                    
                    }
                }
            }
        }
    }
}
