// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class MassQuote : Message
        {
            public const string MsgType = "i";

            public MassQuote() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("i"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteReqID val) 
            { 
                this.quoteReqID = val;
            }
            
            public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteReqID val) 
            { 
                return IsSetQuoteReqID();
            }
            
            public bool IsSetQuoteReqID() 
            { 
                return IsSetField(Tags.QuoteReqID);
            }
            public QuickFix.Fields.QuoteID quoteID
            { 
                get 
                {
                    QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteID val) 
            { 
                this.quoteID = val;
            }
            
            public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteID val) 
            { 
                return IsSetQuoteID();
            }
            
            public bool IsSetQuoteID() 
            { 
                return IsSetField(Tags.QuoteID);
            }
            public QuickFix.Fields.QuoteType quoteType
            { 
                get 
                {
                    QuickFix.Fields.QuoteType val = new QuickFix.Fields.QuoteType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteType val) 
            { 
                this.quoteType = val;
            }
            
            public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteType val) 
            { 
                return IsSetQuoteType();
            }
            
            public bool IsSetQuoteType() 
            { 
                return IsSetField(Tags.QuoteType);
            }
            public QuickFix.Fields.QuoteResponseLevel quoteResponseLevel
            { 
                get 
                {
                    QuickFix.Fields.QuoteResponseLevel val = new QuickFix.Fields.QuoteResponseLevel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                this.quoteResponseLevel = val;
            }
            
            public QuickFix.Fields.QuoteResponseLevel Get(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteResponseLevel val) 
            { 
                return IsSetQuoteResponseLevel();
            }
            
            public bool IsSetQuoteResponseLevel() 
            { 
                return IsSetField(Tags.QuoteResponseLevel);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
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
                this.noPartyIDs = val;
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
            public QuickFix.Fields.Account account
            { 
                get 
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Account val) 
            { 
                this.account = val;
            }
            
            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Account val) 
            { 
                return IsSetAccount();
            }
            
            public bool IsSetAccount() 
            { 
                return IsSetField(Tags.Account);
            }
            public QuickFix.Fields.AccountType accountType
            { 
                get 
                {
                    QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccountType val) 
            { 
                this.accountType = val;
            }
            
            public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(Tags.AccountType);
            }
            public QuickFix.Fields.DefBidSize defBidSize
            { 
                get 
                {
                    QuickFix.Fields.DefBidSize val = new QuickFix.Fields.DefBidSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DefBidSize val) 
            { 
                this.defBidSize = val;
            }
            
            public QuickFix.Fields.DefBidSize Get(QuickFix.Fields.DefBidSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DefBidSize val) 
            { 
                return IsSetDefBidSize();
            }
            
            public bool IsSetDefBidSize() 
            { 
                return IsSetField(Tags.DefBidSize);
            }
            public QuickFix.Fields.DefOfferSize defOfferSize
            { 
                get 
                {
                    QuickFix.Fields.DefOfferSize val = new QuickFix.Fields.DefOfferSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DefOfferSize val) 
            { 
                this.defOfferSize = val;
            }
            
            public QuickFix.Fields.DefOfferSize Get(QuickFix.Fields.DefOfferSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DefOfferSize val) 
            { 
                return IsSetDefOfferSize();
            }
            
            public bool IsSetDefOfferSize() 
            { 
                return IsSetField(Tags.DefOfferSize);
            }
            public QuickFix.Fields.NoQuoteSets noQuoteSets
            { 
                get 
                {
                    QuickFix.Fields.NoQuoteSets val = new QuickFix.Fields.NoQuoteSets();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoQuoteSets val) 
            { 
                this.noQuoteSets = val;
            }
            
            public QuickFix.Fields.NoQuoteSets Get(QuickFix.Fields.NoQuoteSets val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoQuoteSets val) 
            { 
                return IsSetNoQuoteSets();
            }
            
            public bool IsSetNoQuoteSets() 
            { 
                return IsSetField(Tags.NoQuoteSets);
            }
            public class NoPartyIDs : Group
            {
                public NoPartyIDs() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};
                            public QuickFix.Fields.PartyID partyID
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
                    this.partyID = val;
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
                public QuickFix.Fields.PartyIDSource partyIDSource
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
                    this.partyIDSource = val;
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
                public QuickFix.Fields.PartyRole partyRole
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
                    this.partyRole = val;
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
                public QuickFix.Fields.PartySubID partySubID
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
                    this.partySubID = val;
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
            
            }
            public class NoQuoteSets : Group
            {
                public NoQuoteSets() 
                  :base( Tags.NoQuoteSets, Tags.QuoteSetID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.QuoteSetValidUntilTime, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0};
                            public QuickFix.Fields.QuoteSetID quoteSetID
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteSetID val = new QuickFix.Fields.QuoteSetID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteSetID val) 
                { 
                    this.quoteSetID = val;
                }
                
                public QuickFix.Fields.QuoteSetID Get(QuickFix.Fields.QuoteSetID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteSetID val) 
                { 
                    return IsSetQuoteSetID();
                }
                
                public bool IsSetQuoteSetID() 
                { 
                    return IsSetField(Tags.QuoteSetID);
                }
                public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
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
                    this.underlyingSymbol = val;
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
                public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
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
                    this.underlyingSymbolSfx = val;
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
                public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
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
                    this.underlyingSecurityID = val;
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
                public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
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
                    this.underlyingSecurityIDSource = val;
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
                public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
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
                    this.noUnderlyingSecurityAltID = val;
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
                public QuickFix.Fields.UnderlyingProduct underlyingProduct
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
                    this.underlyingProduct = val;
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
                public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
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
                    this.underlyingCFICode = val;
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
                public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
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
                    this.underlyingSecurityType = val;
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
                public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
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
                    this.underlyingMaturityMonthYear = val;
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
                public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
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
                    this.underlyingMaturityDate = val;
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
                public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
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
                    this.underlyingCouponPaymentDate = val;
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
                public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
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
                    this.underlyingIssueDate = val;
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
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
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
                    this.underlyingRepoCollateralSecurityType = val;
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
                public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
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
                    this.underlyingRepurchaseTerm = val;
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
                public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
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
                    this.underlyingRepurchaseRate = val;
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
                public QuickFix.Fields.UnderlyingFactor underlyingFactor
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
                    this.underlyingFactor = val;
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
                public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
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
                    this.underlyingCreditRating = val;
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
                public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
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
                    this.underlyingInstrRegistry = val;
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
                public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
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
                    this.underlyingCountryOfIssue = val;
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
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
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
                    this.underlyingStateOrProvinceOfIssue = val;
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
                public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
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
                    this.underlyingLocaleOfIssue = val;
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
                public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
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
                    this.underlyingRedemptionDate = val;
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
                public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
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
                    this.underlyingPutOrCall = val;
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
                public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
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
                    this.underlyingStrikePrice = val;
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
                public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
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
                    this.underlyingOptAttribute = val;
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
                public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
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
                    this.underlyingContractMultiplier = val;
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
                public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
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
                    this.underlyingCouponRate = val;
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
                public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
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
                    this.underlyingSecurityExchange = val;
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
                public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
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
                    this.underlyingIssuer = val;
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
                public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
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
                    this.encodedUnderlyingIssuerLen = val;
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
                public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
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
                    this.encodedUnderlyingIssuer = val;
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
                public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
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
                    this.underlyingSecurityDesc = val;
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
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
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
                    this.encodedUnderlyingSecurityDescLen = val;
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
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
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
                    this.encodedUnderlyingSecurityDesc = val;
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
                public QuickFix.Fields.QuoteSetValidUntilTime quoteSetValidUntilTime
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteSetValidUntilTime val = new QuickFix.Fields.QuoteSetValidUntilTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    this.quoteSetValidUntilTime = val;
                }
                
                public QuickFix.Fields.QuoteSetValidUntilTime Get(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteSetValidUntilTime val) 
                { 
                    return IsSetQuoteSetValidUntilTime();
                }
                
                public bool IsSetQuoteSetValidUntilTime() 
                { 
                    return IsSetField(Tags.QuoteSetValidUntilTime);
                }
                public QuickFix.Fields.TotQuoteEntries totQuoteEntries
                { 
                    get 
                    {
                        QuickFix.Fields.TotQuoteEntries val = new QuickFix.Fields.TotQuoteEntries();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    this.totQuoteEntries = val;
                }
                
                public QuickFix.Fields.TotQuoteEntries Get(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    return IsSetTotQuoteEntries();
                }
                
                public bool IsSetTotQuoteEntries() 
                { 
                    return IsSetField(Tags.TotQuoteEntries);
                }
                public QuickFix.Fields.NoQuoteEntries noQuoteEntries
                { 
                    get 
                    {
                        QuickFix.Fields.NoQuoteEntries val = new QuickFix.Fields.NoQuoteEntries();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoQuoteEntries val) 
                { 
                    this.noQuoteEntries = val;
                }
                
                public QuickFix.Fields.NoQuoteEntries Get(QuickFix.Fields.NoQuoteEntries val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoQuoteEntries val) 
                { 
                    return IsSetNoQuoteEntries();
                }
                
                public bool IsSetNoQuoteEntries() 
                { 
                    return IsSetField(Tags.NoQuoteEntries);
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        this.underlyingSecurityAltID = val;
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
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
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
                        this.underlyingSecurityAltIDSource = val;
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
                public class NoQuoteEntries : Group
                {
                    public NoQuoteEntries() 
                      :base( Tags.NoQuoteEntries, Tags.QuoteEntryID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.MidPx, Tags.BidYield, Tags.MidYield, Tags.OfferYield, Tags.TransactTime, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.BidForwardPoints2, Tags.OfferForwardPoints2, Tags.Currency, 0};
                                    public QuickFix.Fields.QuoteEntryID quoteEntryID
                    { 
                        get 
                        {
                            QuickFix.Fields.QuoteEntryID val = new QuickFix.Fields.QuoteEntryID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.QuoteEntryID val) 
                    { 
                        this.quoteEntryID = val;
                    }
                    
                    public QuickFix.Fields.QuoteEntryID Get(QuickFix.Fields.QuoteEntryID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.QuoteEntryID val) 
                    { 
                        return IsSetQuoteEntryID();
                    }
                    
                    public bool IsSetQuoteEntryID() 
                    { 
                        return IsSetField(Tags.QuoteEntryID);
                    }
                    public QuickFix.Fields.Symbol symbol
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
                        this.symbol = val;
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
                    public QuickFix.Fields.SymbolSfx symbolSfx
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
                        this.symbolSfx = val;
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
                    public QuickFix.Fields.SecurityID securityID
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
                        this.securityID = val;
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
                    public QuickFix.Fields.SecurityIDSource securityIDSource
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
                        this.securityIDSource = val;
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
                    public QuickFix.Fields.NoSecurityAltID noSecurityAltID
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
                        this.noSecurityAltID = val;
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
                    public QuickFix.Fields.Product product
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
                        this.product = val;
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
                    public QuickFix.Fields.CFICode cFICode
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
                        this.cFICode = val;
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
                    public QuickFix.Fields.SecurityType securityType
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
                        this.securityType = val;
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
                    public QuickFix.Fields.MaturityMonthYear maturityMonthYear
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
                        this.maturityMonthYear = val;
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
                    public QuickFix.Fields.MaturityDate maturityDate
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
                        this.maturityDate = val;
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
                    public QuickFix.Fields.CouponPaymentDate couponPaymentDate
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
                        this.couponPaymentDate = val;
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
                    public QuickFix.Fields.IssueDate issueDate
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
                        this.issueDate = val;
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
                    public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
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
                        this.repoCollateralSecurityType = val;
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
                    public QuickFix.Fields.RepurchaseTerm repurchaseTerm
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
                        this.repurchaseTerm = val;
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
                    public QuickFix.Fields.RepurchaseRate repurchaseRate
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
                        this.repurchaseRate = val;
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
                    public QuickFix.Fields.Factor factor
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
                        this.factor = val;
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
                    public QuickFix.Fields.CreditRating creditRating
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
                        this.creditRating = val;
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
                    public QuickFix.Fields.InstrRegistry instrRegistry
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
                        this.instrRegistry = val;
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
                    public QuickFix.Fields.CountryOfIssue countryOfIssue
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
                        this.countryOfIssue = val;
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
                    public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
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
                        this.stateOrProvinceOfIssue = val;
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
                    public QuickFix.Fields.LocaleOfIssue localeOfIssue
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
                        this.localeOfIssue = val;
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
                    public QuickFix.Fields.RedemptionDate redemptionDate
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
                        this.redemptionDate = val;
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
                    public QuickFix.Fields.StrikePrice strikePrice
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
                        this.strikePrice = val;
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
                    public QuickFix.Fields.OptAttribute optAttribute
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
                        this.optAttribute = val;
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
                    public QuickFix.Fields.ContractMultiplier contractMultiplier
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
                        this.contractMultiplier = val;
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
                    public QuickFix.Fields.CouponRate couponRate
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
                        this.couponRate = val;
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
                    public QuickFix.Fields.SecurityExchange securityExchange
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
                        this.securityExchange = val;
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
                    public QuickFix.Fields.Issuer issuer
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
                        this.issuer = val;
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
                    public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
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
                        this.encodedIssuerLen = val;
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
                    public QuickFix.Fields.EncodedIssuer encodedIssuer
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
                        this.encodedIssuer = val;
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
                    public QuickFix.Fields.SecurityDesc securityDesc
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
                        this.securityDesc = val;
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
                    public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
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
                        this.encodedSecurityDescLen = val;
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
                    public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
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
                        this.encodedSecurityDesc = val;
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
                    public QuickFix.Fields.BidPx bidPx
                    { 
                        get 
                        {
                            QuickFix.Fields.BidPx val = new QuickFix.Fields.BidPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidPx val) 
                    { 
                        this.bidPx = val;
                    }
                    
                    public QuickFix.Fields.BidPx Get(QuickFix.Fields.BidPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidPx val) 
                    { 
                        return IsSetBidPx();
                    }
                    
                    public bool IsSetBidPx() 
                    { 
                        return IsSetField(Tags.BidPx);
                    }
                    public QuickFix.Fields.OfferPx offerPx
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferPx val = new QuickFix.Fields.OfferPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferPx val) 
                    { 
                        this.offerPx = val;
                    }
                    
                    public QuickFix.Fields.OfferPx Get(QuickFix.Fields.OfferPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferPx val) 
                    { 
                        return IsSetOfferPx();
                    }
                    
                    public bool IsSetOfferPx() 
                    { 
                        return IsSetField(Tags.OfferPx);
                    }
                    public QuickFix.Fields.BidSize bidSize
                    { 
                        get 
                        {
                            QuickFix.Fields.BidSize val = new QuickFix.Fields.BidSize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidSize val) 
                    { 
                        this.bidSize = val;
                    }
                    
                    public QuickFix.Fields.BidSize Get(QuickFix.Fields.BidSize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidSize val) 
                    { 
                        return IsSetBidSize();
                    }
                    
                    public bool IsSetBidSize() 
                    { 
                        return IsSetField(Tags.BidSize);
                    }
                    public QuickFix.Fields.OfferSize offerSize
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferSize val = new QuickFix.Fields.OfferSize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferSize val) 
                    { 
                        this.offerSize = val;
                    }
                    
                    public QuickFix.Fields.OfferSize Get(QuickFix.Fields.OfferSize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferSize val) 
                    { 
                        return IsSetOfferSize();
                    }
                    
                    public bool IsSetOfferSize() 
                    { 
                        return IsSetField(Tags.OfferSize);
                    }
                    public QuickFix.Fields.ValidUntilTime validUntilTime
                    { 
                        get 
                        {
                            QuickFix.Fields.ValidUntilTime val = new QuickFix.Fields.ValidUntilTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        this.validUntilTime = val;
                    }
                    
                    public QuickFix.Fields.ValidUntilTime Get(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ValidUntilTime val) 
                    { 
                        return IsSetValidUntilTime();
                    }
                    
                    public bool IsSetValidUntilTime() 
                    { 
                        return IsSetField(Tags.ValidUntilTime);
                    }
                    public QuickFix.Fields.BidSpotRate bidSpotRate
                    { 
                        get 
                        {
                            QuickFix.Fields.BidSpotRate val = new QuickFix.Fields.BidSpotRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidSpotRate val) 
                    { 
                        this.bidSpotRate = val;
                    }
                    
                    public QuickFix.Fields.BidSpotRate Get(QuickFix.Fields.BidSpotRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidSpotRate val) 
                    { 
                        return IsSetBidSpotRate();
                    }
                    
                    public bool IsSetBidSpotRate() 
                    { 
                        return IsSetField(Tags.BidSpotRate);
                    }
                    public QuickFix.Fields.OfferSpotRate offerSpotRate
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferSpotRate val = new QuickFix.Fields.OfferSpotRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        this.offerSpotRate = val;
                    }
                    
                    public QuickFix.Fields.OfferSpotRate Get(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferSpotRate val) 
                    { 
                        return IsSetOfferSpotRate();
                    }
                    
                    public bool IsSetOfferSpotRate() 
                    { 
                        return IsSetField(Tags.OfferSpotRate);
                    }
                    public QuickFix.Fields.BidForwardPoints bidForwardPoints
                    { 
                        get 
                        {
                            QuickFix.Fields.BidForwardPoints val = new QuickFix.Fields.BidForwardPoints();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        this.bidForwardPoints = val;
                    }
                    
                    public QuickFix.Fields.BidForwardPoints Get(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidForwardPoints val) 
                    { 
                        return IsSetBidForwardPoints();
                    }
                    
                    public bool IsSetBidForwardPoints() 
                    { 
                        return IsSetField(Tags.BidForwardPoints);
                    }
                    public QuickFix.Fields.OfferForwardPoints offerForwardPoints
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferForwardPoints val = new QuickFix.Fields.OfferForwardPoints();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        this.offerForwardPoints = val;
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints Get(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferForwardPoints val) 
                    { 
                        return IsSetOfferForwardPoints();
                    }
                    
                    public bool IsSetOfferForwardPoints() 
                    { 
                        return IsSetField(Tags.OfferForwardPoints);
                    }
                    public QuickFix.Fields.MidPx midPx
                    { 
                        get 
                        {
                            QuickFix.Fields.MidPx val = new QuickFix.Fields.MidPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MidPx val) 
                    { 
                        this.midPx = val;
                    }
                    
                    public QuickFix.Fields.MidPx Get(QuickFix.Fields.MidPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MidPx val) 
                    { 
                        return IsSetMidPx();
                    }
                    
                    public bool IsSetMidPx() 
                    { 
                        return IsSetField(Tags.MidPx);
                    }
                    public QuickFix.Fields.BidYield bidYield
                    { 
                        get 
                        {
                            QuickFix.Fields.BidYield val = new QuickFix.Fields.BidYield();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidYield val) 
                    { 
                        this.bidYield = val;
                    }
                    
                    public QuickFix.Fields.BidYield Get(QuickFix.Fields.BidYield val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidYield val) 
                    { 
                        return IsSetBidYield();
                    }
                    
                    public bool IsSetBidYield() 
                    { 
                        return IsSetField(Tags.BidYield);
                    }
                    public QuickFix.Fields.MidYield midYield
                    { 
                        get 
                        {
                            QuickFix.Fields.MidYield val = new QuickFix.Fields.MidYield();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MidYield val) 
                    { 
                        this.midYield = val;
                    }
                    
                    public QuickFix.Fields.MidYield Get(QuickFix.Fields.MidYield val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MidYield val) 
                    { 
                        return IsSetMidYield();
                    }
                    
                    public bool IsSetMidYield() 
                    { 
                        return IsSetField(Tags.MidYield);
                    }
                    public QuickFix.Fields.OfferYield offerYield
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferYield val = new QuickFix.Fields.OfferYield();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferYield val) 
                    { 
                        this.offerYield = val;
                    }
                    
                    public QuickFix.Fields.OfferYield Get(QuickFix.Fields.OfferYield val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferYield val) 
                    { 
                        return IsSetOfferYield();
                    }
                    
                    public bool IsSetOfferYield() 
                    { 
                        return IsSetField(Tags.OfferYield);
                    }
                    public QuickFix.Fields.TransactTime transactTime
                    { 
                        get 
                        {
                            QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TransactTime val) 
                    { 
                        this.transactTime = val;
                    }
                    
                    public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TransactTime val) 
                    { 
                        return IsSetTransactTime();
                    }
                    
                    public bool IsSetTransactTime() 
                    { 
                        return IsSetField(Tags.TransactTime);
                    }
                    public QuickFix.Fields.TradingSessionID tradingSessionID
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
                        this.tradingSessionID = val;
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
                    public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
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
                        this.tradingSessionSubID = val;
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
                    public QuickFix.Fields.FutSettDate futSettDate
                    { 
                        get 
                        {
                            QuickFix.Fields.FutSettDate val = new QuickFix.Fields.FutSettDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.FutSettDate val) 
                    { 
                        this.futSettDate = val;
                    }
                    
                    public QuickFix.Fields.FutSettDate Get(QuickFix.Fields.FutSettDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.FutSettDate val) 
                    { 
                        return IsSetFutSettDate();
                    }
                    
                    public bool IsSetFutSettDate() 
                    { 
                        return IsSetField(Tags.FutSettDate);
                    }
                    public QuickFix.Fields.OrdType ordType
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
                        this.ordType = val;
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
                    public QuickFix.Fields.FutSettDate2 futSettDate2
                    { 
                        get 
                        {
                            QuickFix.Fields.FutSettDate2 val = new QuickFix.Fields.FutSettDate2();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.FutSettDate2 val) 
                    { 
                        this.futSettDate2 = val;
                    }
                    
                    public QuickFix.Fields.FutSettDate2 Get(QuickFix.Fields.FutSettDate2 val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.FutSettDate2 val) 
                    { 
                        return IsSetFutSettDate2();
                    }
                    
                    public bool IsSetFutSettDate2() 
                    { 
                        return IsSetField(Tags.FutSettDate2);
                    }
                    public QuickFix.Fields.OrderQty2 orderQty2
                    { 
                        get 
                        {
                            QuickFix.Fields.OrderQty2 val = new QuickFix.Fields.OrderQty2();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OrderQty2 val) 
                    { 
                        this.orderQty2 = val;
                    }
                    
                    public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OrderQty2 val) 
                    { 
                        return IsSetOrderQty2();
                    }
                    
                    public bool IsSetOrderQty2() 
                    { 
                        return IsSetField(Tags.OrderQty2);
                    }
                    public QuickFix.Fields.BidForwardPoints2 bidForwardPoints2
                    { 
                        get 
                        {
                            QuickFix.Fields.BidForwardPoints2 val = new QuickFix.Fields.BidForwardPoints2();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        this.bidForwardPoints2 = val;
                    }
                    
                    public QuickFix.Fields.BidForwardPoints2 Get(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.BidForwardPoints2 val) 
                    { 
                        return IsSetBidForwardPoints2();
                    }
                    
                    public bool IsSetBidForwardPoints2() 
                    { 
                        return IsSetField(Tags.BidForwardPoints2);
                    }
                    public QuickFix.Fields.OfferForwardPoints2 offerForwardPoints2
                    { 
                        get 
                        {
                            QuickFix.Fields.OfferForwardPoints2 val = new QuickFix.Fields.OfferForwardPoints2();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        this.offerForwardPoints2 = val;
                    }
                    
                    public QuickFix.Fields.OfferForwardPoints2 Get(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OfferForwardPoints2 val) 
                    { 
                        return IsSetOfferForwardPoints2();
                    }
                    
                    public bool IsSetOfferForwardPoints2() 
                    { 
                        return IsSetField(Tags.OfferForwardPoints2);
                    }
                    public QuickFix.Fields.Currency currency
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
                        this.currency = val;
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.SecurityAltID val) 
                        { 
                            this.securityAltID = val;
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
                        public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
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
                            this.securityAltIDSource = val;
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
                }
            }
        }
    }
}
