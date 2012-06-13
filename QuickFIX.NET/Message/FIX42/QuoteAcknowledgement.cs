// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class QuoteAcknowledgement : Message
        {
            public const string MsgType = "b";

            public QuoteAcknowledgement() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("b"));
            }

            public QuoteAcknowledgement(
                    QuickFix.Fields.QuoteAckStatus aQuoteAckStatus
                ) : this()
            {
                this.QuoteAckStatus = aQuoteAckStatus;
            }

            public QuickFix.Fields.QuoteReqID QuoteReqID
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
                this.QuoteReqID = val;
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
            public QuickFix.Fields.QuoteID QuoteID
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
                this.QuoteID = val;
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
            public QuickFix.Fields.QuoteAckStatus QuoteAckStatus
            { 
                get 
                {
                    QuickFix.Fields.QuoteAckStatus val = new QuickFix.Fields.QuoteAckStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteAckStatus val) 
            { 
                this.QuoteAckStatus = val;
            }
            
            public QuickFix.Fields.QuoteAckStatus Get(QuickFix.Fields.QuoteAckStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteAckStatus val) 
            { 
                return IsSetQuoteAckStatus();
            }
            
            public bool IsSetQuoteAckStatus() 
            { 
                return IsSetField(Tags.QuoteAckStatus);
            }
            public QuickFix.Fields.QuoteRejectReason QuoteRejectReason
            { 
                get 
                {
                    QuickFix.Fields.QuoteRejectReason val = new QuickFix.Fields.QuoteRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteRejectReason val) 
            { 
                this.QuoteRejectReason = val;
            }
            
            public QuickFix.Fields.QuoteRejectReason Get(QuickFix.Fields.QuoteRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteRejectReason val) 
            { 
                return IsSetQuoteRejectReason();
            }
            
            public bool IsSetQuoteRejectReason() 
            { 
                return IsSetField(Tags.QuoteRejectReason);
            }
            public QuickFix.Fields.QuoteResponseLevel QuoteResponseLevel
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
                this.QuoteResponseLevel = val;
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
            public QuickFix.Fields.NoQuoteSets NoQuoteSets
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
                this.NoQuoteSets = val;
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
            public class NoQuoteSetsGroup : Group
            {
                public static int[] fieldOrder = {Tags.QuoteSetID, Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingIDSource, Tags.UnderlyingSecurityType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDay, Tags.UnderlyingPutOrCall, Tags.UnderlyingStrikePrice, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.TotQuoteEntries, Tags.NoQuoteEntries, 0};
            
                public NoQuoteSetsGroup() 
                  :base( Tags.NoQuoteSets, Tags.QuoteSetID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoQuoteSetsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.QuoteSetID QuoteSetID
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
                    this.QuoteSetID = val;
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
                public QuickFix.Fields.UnderlyingIDSource UnderlyingIDSource
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
                    this.UnderlyingIDSource = val;
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
                public QuickFix.Fields.UnderlyingMaturityDay UnderlyingMaturityDay
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
                    this.UnderlyingMaturityDay = val;
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
                public QuickFix.Fields.TotQuoteEntries TotQuoteEntries
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
                    this.TotQuoteEntries = val;
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
                public QuickFix.Fields.NoQuoteEntries NoQuoteEntries
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
                    this.NoQuoteEntries = val;
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
                            public class NoQuoteEntriesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.QuoteEntryID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.QuoteEntryRejectReason, 0};
                
                    public NoQuoteEntriesGroup() 
                      :base( Tags.NoQuoteEntries, Tags.QuoteEntryID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoQuoteEntriesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.QuoteEntryID QuoteEntryID
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
                        this.QuoteEntryID = val;
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
                    public QuickFix.Fields.IDSource IDSource
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
                        this.IDSource = val;
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
                    public QuickFix.Fields.MaturityDay MaturityDay
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
                        this.MaturityDay = val;
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
                    public QuickFix.Fields.QuoteEntryRejectReason QuoteEntryRejectReason
                    { 
                        get 
                        {
                            QuickFix.Fields.QuoteEntryRejectReason val = new QuickFix.Fields.QuoteEntryRejectReason();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.QuoteEntryRejectReason val) 
                    { 
                        this.QuoteEntryRejectReason = val;
                    }
                    
                    public QuickFix.Fields.QuoteEntryRejectReason Get(QuickFix.Fields.QuoteEntryRejectReason val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.QuoteEntryRejectReason val) 
                    { 
                        return IsSetQuoteEntryRejectReason();
                    }
                    
                    public bool IsSetQuoteEntryRejectReason() 
                    { 
                        return IsSetField(Tags.QuoteEntryRejectReason);
                    }
                
                }
            }
        }
    }
}
