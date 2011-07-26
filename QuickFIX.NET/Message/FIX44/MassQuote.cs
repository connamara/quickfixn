using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class MassQuote : Message
        {
            public MassQuote() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("i"));
            }

            public MassQuote(
                    QuickFix.Fields.QuoteID aQuoteID
                ) : this()
            {
                this.quoteID = aQuoteID;
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
            public QuickFix.Fields.QuoteType quoteType
            { 
                get 
                {
                    QuickFix.Fields.QuoteType val = new QuickFix.Fields.QuoteType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuoteType val) 
            { 
                this.quoteType = val;
            }
            
            public QuickFix.Fields.QuoteType get(QuickFix.Fields.QuoteType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuoteType val) 
            { 
                return isSetQuoteType();
            }
            
            public bool isSetQuoteType() 
            { 
                return isSetField(Tags.QuoteType);
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
            public QuickFix.Fields.DefBidSize defBidSize
            { 
                get 
                {
                    QuickFix.Fields.DefBidSize val = new QuickFix.Fields.DefBidSize();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DefBidSize val) 
            { 
                this.defBidSize = val;
            }
            
            public QuickFix.Fields.DefBidSize get(QuickFix.Fields.DefBidSize val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DefBidSize val) 
            { 
                return isSetDefBidSize();
            }
            
            public bool isSetDefBidSize() 
            { 
                return isSetField(Tags.DefBidSize);
            }
            public QuickFix.Fields.DefOfferSize defOfferSize
            { 
                get 
                {
                    QuickFix.Fields.DefOfferSize val = new QuickFix.Fields.DefOfferSize();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DefOfferSize val) 
            { 
                this.defOfferSize = val;
            }
            
            public QuickFix.Fields.DefOfferSize get(QuickFix.Fields.DefOfferSize val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DefOfferSize val) 
            { 
                return isSetDefOfferSize();
            }
            
            public bool isSetDefOfferSize() 
            { 
                return isSetField(Tags.DefOfferSize);
            }
            public QuickFix.Fields.NoQuoteSets noQuoteSets
            { 
                get 
                {
                    QuickFix.Fields.NoQuoteSets val = new QuickFix.Fields.NoQuoteSets();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoQuoteSets val) 
            { 
                this.noQuoteSets = val;
            }
            
            public QuickFix.Fields.NoQuoteSets get(QuickFix.Fields.NoQuoteSets val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoQuoteSets val) 
            { 
                return isSetNoQuoteSets();
            }
            
            public bool isSetNoQuoteSets() 
            { 
                return isSetField(Tags.NoQuoteSets);
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
            public class NoQuoteSets : Group
            {
                public NoQuoteSets() 
                  :base( Tags.NoQuoteSets, Tags.QuoteSetID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.QuoteSetValidUntilTime, Tags.TotNoQuoteEntries, Tags.LastFragment, Tags.NoQuoteEntries, 0};
                            public QuickFix.Fields.QuoteSetID quoteSetID
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteSetID val = new QuickFix.Fields.QuoteSetID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.QuoteSetID val) 
                { 
                    this.quoteSetID = val;
                }
                
                public QuickFix.Fields.QuoteSetID get(QuickFix.Fields.QuoteSetID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.QuoteSetID val) 
                { 
                    return isSetQuoteSetID();
                }
                
                public bool isSetQuoteSetID() 
                { 
                    return isSetField(Tags.QuoteSetID);
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
                public QuickFix.Fields.QuoteSetValidUntilTime quoteSetValidUntilTime
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteSetValidUntilTime val = new QuickFix.Fields.QuoteSetValidUntilTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    this.quoteSetValidUntilTime = val;
                }
                
                public QuickFix.Fields.QuoteSetValidUntilTime get(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    return isSetQuoteSetValidUntilTime();
                }
                
                public bool isSetQuoteSetValidUntilTime() 
                { 
                    return isSetField(Tags.QuoteSetValidUntilTime);
                }
                public QuickFix.Fields.TotNoQuoteEntries totNoQuoteEntries
                { 
                    get 
                    {
                        QuickFix.Fields.TotNoQuoteEntries val = new QuickFix.Fields.TotNoQuoteEntries();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TotNoQuoteEntries val) 
                { 
                    this.totNoQuoteEntries = val;
                }
                
                public QuickFix.Fields.TotNoQuoteEntries get(QuickFix.Fields.TotNoQuoteEntries val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TotNoQuoteEntries val) 
                { 
                    return isSetTotNoQuoteEntries();
                }
                
                public bool isSetTotNoQuoteEntries() 
                { 
                    return isSetField(Tags.TotNoQuoteEntries);
                }
                public QuickFix.Fields.LastFragment lastFragment
                { 
                    get 
                    {
                        QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LastFragment val) 
                { 
                    this.lastFragment = val;
                }
                
                public QuickFix.Fields.LastFragment get(QuickFix.Fields.LastFragment val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LastFragment val) 
                { 
                    return isSetLastFragment();
                }
                
                public bool isSetLastFragment() 
                { 
                    return isSetField(Tags.LastFragment);
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
                public class NoQuoteEntries : Group
                {
                    public NoQuoteEntries() 
                      :base( Tags.NoQuoteEntries, Tags.QuoteEntryID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.NoLegs, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.SettlDate, Tags.OrdType, Tags.SettlDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, 0};
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
                    public QuickFix.Fields.BidPx bidPx
                    { 
                        get 
                        {
                            QuickFix.Fields.BidPx val = new QuickFix.Fields.BidPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.BidPx val) 
                    { 
                        this.bidPx = val;
                    }
                    
                    public QuickFix.Fields.BidPx get(QuickFix.Fields.BidPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.BidPx val) 
                    { 
                        return isSetBidPx();
                    }
                    
                    public bool isSetBidPx() 
                    { 
                        return isSetField(Tags.BidPx);
                    }
                    public QuickFix.Fields.OfferPx offerPx
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferPx val = new QuickFix.Fields.OfferPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OfferPx val) 
                    { 
                        this.offerPx = val;
                    }
                    
                    public QuickFix.Fields.OfferPx get(QuickFix.Fields.OfferPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OfferPx val) 
                    { 
                        return isSetOfferPx();
                    }
                    
                    public bool isSetOfferPx() 
                    { 
                        return isSetField(Tags.OfferPx);
                    }
                    public QuickFix.Fields.BidSize bidSize
                    { 
                        get 
                        {
                            QuickFix.Fields.BidSize val = new QuickFix.Fields.BidSize();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.BidSize val) 
                    { 
                        this.bidSize = val;
                    }
                    
                    public QuickFix.Fields.BidSize get(QuickFix.Fields.BidSize val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.BidSize val) 
                    { 
                        return isSetBidSize();
                    }
                    
                    public bool isSetBidSize() 
                    { 
                        return isSetField(Tags.BidSize);
                    }
                    public QuickFix.Fields.OfferSize offerSize
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferSize val = new QuickFix.Fields.OfferSize();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OfferSize val) 
                    { 
                        this.offerSize = val;
                    }
                    
                    public QuickFix.Fields.OfferSize get(QuickFix.Fields.OfferSize val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OfferSize val) 
                    { 
                        return isSetOfferSize();
                    }
                    
                    public bool isSetOfferSize() 
                    { 
                        return isSetField(Tags.OfferSize);
                    }
                    public QuickFix.Fields.ValidUntilTime validUntilTime
                    { 
                        get 
                        {
                            QuickFix.Fields.ValidUntilTime val = new QuickFix.Fields.ValidUntilTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        this.validUntilTime = val;
                    }
                    
                    public QuickFix.Fields.ValidUntilTime get(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        return isSetValidUntilTime();
                    }
                    
                    public bool isSetValidUntilTime() 
                    { 
                        return isSetField(Tags.ValidUntilTime);
                    }
                    public QuickFix.Fields.BidSpotRate bidSpotRate
                    { 
                        get 
                        {
                            QuickFix.Fields.BidSpotRate val = new QuickFix.Fields.BidSpotRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.BidSpotRate val) 
                    { 
                        this.bidSpotRate = val;
                    }
                    
                    public QuickFix.Fields.BidSpotRate get(QuickFix.Fields.BidSpotRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.BidSpotRate val) 
                    { 
                        return isSetBidSpotRate();
                    }
                    
                    public bool isSetBidSpotRate() 
                    { 
                        return isSetField(Tags.BidSpotRate);
                    }
                    public QuickFix.Fields.OfferSpotRate offerSpotRate
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferSpotRate val = new QuickFix.Fields.OfferSpotRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        this.offerSpotRate = val;
                    }
                    
                    public QuickFix.Fields.OfferSpotRate get(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        return isSetOfferSpotRate();
                    }
                    
                    public bool isSetOfferSpotRate() 
                    { 
                        return isSetField(Tags.OfferSpotRate);
                    }
                    public QuickFix.Fields.BidForwardPoints bidForwardPoints
                    { 
                        get 
                        {
                            QuickFix.Fields.BidForwardPoints val = new QuickFix.Fields.BidForwardPoints();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        this.bidForwardPoints = val;
                    }
                    
                    public QuickFix.Fields.BidForwardPoints get(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        return isSetBidForwardPoints();
                    }
                    
                    public bool isSetBidForwardPoints() 
                    { 
                        return isSetField(Tags.BidForwardPoints);
                    }
                    public QuickFix.Fields.OfferForwardPoints offerForwardPoints
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferForwardPoints val = new QuickFix.Fields.OfferForwardPoints();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        this.offerForwardPoints = val;
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints get(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        return isSetOfferForwardPoints();
                    }
                    
                    public bool isSetOfferForwardPoints() 
                    { 
                        return isSetField(Tags.OfferForwardPoints);
                    }
                    public QuickFix.Fields.MidPx midPx
                    { 
                        get 
                        {
                            QuickFix.Fields.MidPx val = new QuickFix.Fields.MidPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MidPx val) 
                    { 
                        this.midPx = val;
                    }
                    
                    public QuickFix.Fields.MidPx get(QuickFix.Fields.MidPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MidPx val) 
                    { 
                        return isSetMidPx();
                    }
                    
                    public bool isSetMidPx() 
                    { 
                        return isSetField(Tags.MidPx);
                    }
                    public QuickFix.Fields.BidYield bidYield
                    { 
                        get 
                        {
                            QuickFix.Fields.BidYield val = new QuickFix.Fields.BidYield();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.BidYield val) 
                    { 
                        this.bidYield = val;
                    }
                    
                    public QuickFix.Fields.BidYield get(QuickFix.Fields.BidYield val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.BidYield val) 
                    { 
                        return isSetBidYield();
                    }
                    
                    public bool isSetBidYield() 
                    { 
                        return isSetField(Tags.BidYield);
                    }
                    public QuickFix.Fields.MidYield midYield
                    { 
                        get 
                        {
                            QuickFix.Fields.MidYield val = new QuickFix.Fields.MidYield();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MidYield val) 
                    { 
                        this.midYield = val;
                    }
                    
                    public QuickFix.Fields.MidYield get(QuickFix.Fields.MidYield val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MidYield val) 
                    { 
                        return isSetMidYield();
                    }
                    
                    public bool isSetMidYield() 
                    { 
                        return isSetField(Tags.MidYield);
                    }
                    public QuickFix.Fields.OfferYield offerYield
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferYield val = new QuickFix.Fields.OfferYield();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OfferYield val) 
                    { 
                        this.offerYield = val;
                    }
                    
                    public QuickFix.Fields.OfferYield get(QuickFix.Fields.OfferYield val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OfferYield val) 
                    { 
                        return isSetOfferYield();
                    }
                    
                    public bool isSetOfferYield() 
                    { 
                        return isSetField(Tags.OfferYield);
                    }
                    public QuickFix.Fields.TransactTime transactTime
                    { 
                        get 
                        {
                            QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.TransactTime val) 
                    { 
                        this.transactTime = val;
                    }
                    
                    public QuickFix.Fields.TransactTime get(QuickFix.Fields.TransactTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.TransactTime val) 
                    { 
                        return isSetTransactTime();
                    }
                    
                    public bool isSetTransactTime() 
                    { 
                        return isSetField(Tags.TransactTime);
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
                    public QuickFix.Fields.SettlDate settlDate
                    { 
                        get 
                        {
                            QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SettlDate val) 
                    { 
                        this.settlDate = val;
                    }
                    
                    public QuickFix.Fields.SettlDate get(QuickFix.Fields.SettlDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SettlDate val) 
                    { 
                        return isSetSettlDate();
                    }
                    
                    public bool isSetSettlDate() 
                    { 
                        return isSetField(Tags.SettlDate);
                    }
                    public QuickFix.Fields.OrdType ordType
                    { 
                        get 
                        {
                            QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OrdType val) 
                    { 
                        this.ordType = val;
                    }
                    
                    public QuickFix.Fields.OrdType get(QuickFix.Fields.OrdType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OrdType val) 
                    { 
                        return isSetOrdType();
                    }
                    
                    public bool isSetOrdType() 
                    { 
                        return isSetField(Tags.OrdType);
                    }
                    public QuickFix.Fields.SettlDate2 settlDate2
                    { 
                        get 
                        {
                            QuickFix.Fields.SettlDate2 val = new QuickFix.Fields.SettlDate2();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SettlDate2 val) 
                    { 
                        this.settlDate2 = val;
                    }
                    
                    public QuickFix.Fields.SettlDate2 get(QuickFix.Fields.SettlDate2 val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SettlDate2 val) 
                    { 
                        return isSetSettlDate2();
                    }
                    
                    public bool isSetSettlDate2() 
                    { 
                        return isSetField(Tags.SettlDate2);
                    }
                    public QuickFix.Fields.OrderQty2 orderQty2
                    { 
                        get 
                        {
                            QuickFix.Fields.OrderQty2 val = new QuickFix.Fields.OrderQty2();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OrderQty2 val) 
                    { 
                        this.orderQty2 = val;
                    }
                    
                    public QuickFix.Fields.OrderQty2 get(QuickFix.Fields.OrderQty2 val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OrderQty2 val) 
                    { 
                        return isSetOrderQty2();
                    }
                    
                    public bool isSetOrderQty2() 
                    { 
                        return isSetField(Tags.OrderQty2);
                    }
                    public QuickFix.Fields.BidForwardPoints2 bidForwardPoints2
                    { 
                        get 
                        {
                            QuickFix.Fields.BidForwardPoints2 val = new QuickFix.Fields.BidForwardPoints2();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        this.bidForwardPoints2 = val;
                    }
                    
                    public QuickFix.Fields.BidForwardPoints2 get(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        return isSetBidForwardPoints2();
                    }
                    
                    public bool isSetBidForwardPoints2() 
                    { 
                        return isSetField(Tags.BidForwardPoints2);
                    }
                    public QuickFix.Fields.OfferForwardPoints2 offerForwardPoints2
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferForwardPoints2 val = new QuickFix.Fields.OfferForwardPoints2();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        this.offerForwardPoints2 = val;
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints2 get(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        return isSetOfferForwardPoints2();
                    }
                    
                    public bool isSetOfferForwardPoints2() 
                    { 
                        return isSetField(Tags.OfferForwardPoints2);
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
                        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};
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
                    
                    }
                    public class NoLegs : Group
                    {
                        public NoLegs() 
                          :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, 0};
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
}
