// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
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
                public QuickFix.Fields.UnderlyingIDSource underlyingIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIDSource val = new QuickFix.Fields.UnderlyingIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    this.underlyingIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingIDSource get(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingIDSource val) 
                { 
                    return isSetUnderlyingIDSource();
                }
                
                public bool isSetUnderlyingIDSource() 
                { 
                    return isSetField(Tags.UnderlyingIDSource);
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
                public QuickFix.Fields.UnderlyingMaturityDay underlyingMaturityDay
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityDay val = new QuickFix.Fields.UnderlyingMaturityDay();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    this.underlyingMaturityDay = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDay get(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingMaturityDay val) 
                { 
                    return isSetUnderlyingMaturityDay();
                }
                
                public bool isSetUnderlyingMaturityDay() 
                { 
                    return isSetField(Tags.UnderlyingMaturityDay);
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
                public QuickFix.Fields.TotQuoteEntries totQuoteEntries
                { 
                    get 
                    {
                        QuickFix.Fields.TotQuoteEntries val = new QuickFix.Fields.TotQuoteEntries();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    this.totQuoteEntries = val;
                }
                
                public QuickFix.Fields.TotQuoteEntries get(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TotQuoteEntries val) 
                { 
                    return isSetTotQuoteEntries();
                }
                
                public bool isSetTotQuoteEntries() 
                { 
                    return isSetField(Tags.TotQuoteEntries);
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
                    public QuickFix.Fields.IDSource iDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.IDSource val) 
                    { 
                        this.iDSource = val;
                    }
                    
                    public QuickFix.Fields.IDSource get(QuickFix.Fields.IDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.IDSource val) 
                    { 
                        return isSetIDSource();
                    }
                    
                    public bool isSetIDSource() 
                    { 
                        return isSetField(Tags.IDSource);
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
                    public QuickFix.Fields.MaturityDay maturityDay
                    { 
                        get 
                        {
                            QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MaturityDay val) 
                    { 
                        this.maturityDay = val;
                    }
                    
                    public QuickFix.Fields.MaturityDay get(QuickFix.Fields.MaturityDay val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MaturityDay val) 
                    { 
                        return isSetMaturityDay();
                    }
                    
                    public bool isSetMaturityDay() 
                    { 
                        return isSetField(Tags.MaturityDay);
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
                    public QuickFix.Fields.FutSettDate futSettDate
                    { 
                        get 
                        {
                            QuickFix.Fields.FutSettDate val = new QuickFix.Fields.FutSettDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.FutSettDate val) 
                    { 
                        this.futSettDate = val;
                    }
                    
                    public QuickFix.Fields.FutSettDate get(QuickFix.Fields.FutSettDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.FutSettDate val) 
                    { 
                        return isSetFutSettDate();
                    }
                    
                    public bool isSetFutSettDate() 
                    { 
                        return isSetField(Tags.FutSettDate);
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
                    public QuickFix.Fields.FutSettDate2 futSettDate2
                    { 
                        get 
                        {
                            QuickFix.Fields.FutSettDate2 val = new QuickFix.Fields.FutSettDate2();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.FutSettDate2 val) 
                    { 
                        this.futSettDate2 = val;
                    }
                    
                    public QuickFix.Fields.FutSettDate2 get(QuickFix.Fields.FutSettDate2 val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.FutSettDate2 val) 
                    { 
                        return isSetFutSettDate2();
                    }
                    
                    public bool isSetFutSettDate2() 
                    { 
                        return isSetField(Tags.FutSettDate2);
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
                
                }
            }
        }
    }
}
