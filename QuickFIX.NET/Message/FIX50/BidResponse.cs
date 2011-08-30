// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class BidResponse : Message
        {
            public const string MsgType = "l";

            public BidResponse() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("l"));
            }


            public QuickFix.Fields.BidID bidID
            { 
                get 
                {
                    QuickFix.Fields.BidID val = new QuickFix.Fields.BidID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BidID val) 
            { 
                this.bidID = val;
            }
            
            public QuickFix.Fields.BidID get(QuickFix.Fields.BidID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BidID val) 
            { 
                return isSetBidID();
            }
            
            public bool isSetBidID() 
            { 
                return isSetField(Tags.BidID);
            }
            public QuickFix.Fields.ClientBidID clientBidID
            { 
                get 
                {
                    QuickFix.Fields.ClientBidID val = new QuickFix.Fields.ClientBidID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ClientBidID val) 
            { 
                this.clientBidID = val;
            }
            
            public QuickFix.Fields.ClientBidID get(QuickFix.Fields.ClientBidID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ClientBidID val) 
            { 
                return isSetClientBidID();
            }
            
            public bool isSetClientBidID() 
            { 
                return isSetField(Tags.ClientBidID);
            }
            public QuickFix.Fields.NoBidComponents noBidComponents
            { 
                get 
                {
                    QuickFix.Fields.NoBidComponents val = new QuickFix.Fields.NoBidComponents();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoBidComponents val) 
            { 
                this.noBidComponents = val;
            }
            
            public QuickFix.Fields.NoBidComponents get(QuickFix.Fields.NoBidComponents val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoBidComponents val) 
            { 
                return isSetNoBidComponents();
            }
            
            public bool isSetNoBidComponents() 
            { 
                return isSetField(Tags.NoBidComponents);
            }
            public class NoBidComponents : Group
            {
                public NoBidComponents() 
                  :base( Tags.NoBidComponents, Tags.Commission, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.ListID, Tags.Country, Tags.Side, Tags.Price, Tags.PriceType, Tags.FairValue, Tags.NetGrossInd, Tags.SettlType, Tags.SettlDate, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
                            public QuickFix.Fields.Commission commission
                { 
                    get 
                    {
                        QuickFix.Fields.Commission val = new QuickFix.Fields.Commission();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Commission val) 
                { 
                    this.commission = val;
                }
                
                public QuickFix.Fields.Commission get(QuickFix.Fields.Commission val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Commission val) 
                { 
                    return isSetCommission();
                }
                
                public bool isSetCommission() 
                { 
                    return isSetField(Tags.Commission);
                }
                public QuickFix.Fields.CommType commType
                { 
                    get 
                    {
                        QuickFix.Fields.CommType val = new QuickFix.Fields.CommType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CommType val) 
                { 
                    this.commType = val;
                }
                
                public QuickFix.Fields.CommType get(QuickFix.Fields.CommType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CommType val) 
                { 
                    return isSetCommType();
                }
                
                public bool isSetCommType() 
                { 
                    return isSetField(Tags.CommType);
                }
                public QuickFix.Fields.CommCurrency commCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.CommCurrency val = new QuickFix.Fields.CommCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CommCurrency val) 
                { 
                    this.commCurrency = val;
                }
                
                public QuickFix.Fields.CommCurrency get(QuickFix.Fields.CommCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CommCurrency val) 
                { 
                    return isSetCommCurrency();
                }
                
                public bool isSetCommCurrency() 
                { 
                    return isSetField(Tags.CommCurrency);
                }
                public QuickFix.Fields.FundRenewWaiv fundRenewWaiv
                { 
                    get 
                    {
                        QuickFix.Fields.FundRenewWaiv val = new QuickFix.Fields.FundRenewWaiv();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    this.fundRenewWaiv = val;
                }
                
                public QuickFix.Fields.FundRenewWaiv get(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FundRenewWaiv val) 
                { 
                    return isSetFundRenewWaiv();
                }
                
                public bool isSetFundRenewWaiv() 
                { 
                    return isSetField(Tags.FundRenewWaiv);
                }
                public QuickFix.Fields.ListID listID
                { 
                    get 
                    {
                        QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListID val) 
                { 
                    this.listID = val;
                }
                
                public QuickFix.Fields.ListID get(QuickFix.Fields.ListID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListID val) 
                { 
                    return isSetListID();
                }
                
                public bool isSetListID() 
                { 
                    return isSetField(Tags.ListID);
                }
                public QuickFix.Fields.Country country
                { 
                    get 
                    {
                        QuickFix.Fields.Country val = new QuickFix.Fields.Country();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Country val) 
                { 
                    this.country = val;
                }
                
                public QuickFix.Fields.Country get(QuickFix.Fields.Country val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Country val) 
                { 
                    return isSetCountry();
                }
                
                public bool isSetCountry() 
                { 
                    return isSetField(Tags.Country);
                }
                public QuickFix.Fields.Side side
                { 
                    get 
                    {
                        QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Side val) 
                { 
                    this.side = val;
                }
                
                public QuickFix.Fields.Side get(QuickFix.Fields.Side val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Side val) 
                { 
                    return isSetSide();
                }
                
                public bool isSetSide() 
                { 
                    return isSetField(Tags.Side);
                }
                public QuickFix.Fields.Price price
                { 
                    get 
                    {
                        QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Price val) 
                { 
                    this.price = val;
                }
                
                public QuickFix.Fields.Price get(QuickFix.Fields.Price val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Price val) 
                { 
                    return isSetPrice();
                }
                
                public bool isSetPrice() 
                { 
                    return isSetField(Tags.Price);
                }
                public QuickFix.Fields.PriceType priceType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceType val) 
                { 
                    this.priceType = val;
                }
                
                public QuickFix.Fields.PriceType get(QuickFix.Fields.PriceType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceType val) 
                { 
                    return isSetPriceType();
                }
                
                public bool isSetPriceType() 
                { 
                    return isSetField(Tags.PriceType);
                }
                public QuickFix.Fields.FairValue fairValue
                { 
                    get 
                    {
                        QuickFix.Fields.FairValue val = new QuickFix.Fields.FairValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FairValue val) 
                { 
                    this.fairValue = val;
                }
                
                public QuickFix.Fields.FairValue get(QuickFix.Fields.FairValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FairValue val) 
                { 
                    return isSetFairValue();
                }
                
                public bool isSetFairValue() 
                { 
                    return isSetField(Tags.FairValue);
                }
                public QuickFix.Fields.NetGrossInd netGrossInd
                { 
                    get 
                    {
                        QuickFix.Fields.NetGrossInd val = new QuickFix.Fields.NetGrossInd();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NetGrossInd val) 
                { 
                    this.netGrossInd = val;
                }
                
                public QuickFix.Fields.NetGrossInd get(QuickFix.Fields.NetGrossInd val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NetGrossInd val) 
                { 
                    return isSetNetGrossInd();
                }
                
                public bool isSetNetGrossInd() 
                { 
                    return isSetField(Tags.NetGrossInd);
                }
                public QuickFix.Fields.SettlType settlType
                { 
                    get 
                    {
                        QuickFix.Fields.SettlType val = new QuickFix.Fields.SettlType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlType val) 
                { 
                    this.settlType = val;
                }
                
                public QuickFix.Fields.SettlType get(QuickFix.Fields.SettlType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlType val) 
                { 
                    return isSetSettlType();
                }
                
                public bool isSetSettlType() 
                { 
                    return isSetField(Tags.SettlType);
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
