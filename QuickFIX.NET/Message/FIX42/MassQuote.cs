// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
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
            public class NoQuoteSets : Group
            {
                public NoQuoteSets() 
                  :base( Tags.NoQuoteSets, Tags.QuoteSetID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingIDSource, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDay, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.QuoteSetValidUntilTime, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0};
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
                public QuickFix.Fields.UnderlyingIDSource underlyingIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIDSource val = new QuickFix.Fields.UnderlyingIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    this.underlyingIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingIDSource Get(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    return IsSetUnderlyingIDSource();
                }
                
                public bool IsSetUnderlyingIDSource() 
                { 
                    return IsSetField(Tags.UnderlyingIDSource);
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
                public QuickFix.Fields.UnderlyingMaturityDay underlyingMaturityDay
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityDay val = new QuickFix.Fields.UnderlyingMaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    this.underlyingMaturityDay = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDay Get(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    return IsSetUnderlyingMaturityDay();
                }
                
                public bool IsSetUnderlyingMaturityDay() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityDay);
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
                            public class NoQuoteEntries : Group
                {
                    public NoQuoteEntries() 
                      :base( Tags.NoQuoteEntries, Tags.QuoteEntryID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.BidPx, Tags.OfferPx, Tags.BidSize, Tags.OfferSize, Tags.ValidUntilTime, Tags.BidSpotRate, Tags.OfferSpotRate, Tags.BidForwardPoints, Tags.OfferForwardPoints, Tags.TransactTime, Tags.TradingSessionID, Tags.FutSettDate, Tags.OrdType, Tags.FutSettDate2, Tags.OrderQty2, Tags.Currency, 0};
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
                    public QuickFix.Fields.IDSource iDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.IDSource val) 
                    { 
                        this.iDSource = val;
                    }
                    
                    public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.IDSource val) 
                    { 
                        return IsSetIDSource();
                    }
                    
                    public bool IsSetIDSource() 
                    { 
                        return IsSetField(Tags.IDSource);
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
                    public QuickFix.Fields.MaturityDay maturityDay
                    { 
                        get 
                        {
                            QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MaturityDay val) 
                    { 
                        this.maturityDay = val;
                    }
                    
                    public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MaturityDay val) 
                    { 
                        return IsSetMaturityDay();
                    }
                    
                    public bool IsSetMaturityDay() 
                    { 
                        return IsSetField(Tags.MaturityDay);
                    }
                    public QuickFix.Fields.PutOrCall putOrCall
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
                        this.putOrCall = val;
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
                
                }
            }
        }
    }
}
