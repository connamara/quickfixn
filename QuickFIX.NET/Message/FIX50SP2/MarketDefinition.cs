// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class MarketDefinition : Message
        {
            public const string MsgType = "BU";

            public MarketDefinition() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BU"));
            }

            public MarketDefinition(
                    QuickFix.Fields.MarketReportID aMarketReportID,
                    QuickFix.Fields.MarketID aMarketID
                ) : this()
            {
                this.marketReportID = aMarketReportID;
                this.marketID = aMarketID;
            }

            public QuickFix.Fields.MarketReportID marketReportID
            { 
                get 
                {
                    QuickFix.Fields.MarketReportID val = new QuickFix.Fields.MarketReportID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketReportID val) 
            { 
                this.marketReportID = val;
            }
            
            public QuickFix.Fields.MarketReportID get(QuickFix.Fields.MarketReportID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketReportID val) 
            { 
                return isSetMarketReportID();
            }
            
            public bool isSetMarketReportID() 
            { 
                return isSetField(Tags.MarketReportID);
            }
            public QuickFix.Fields.MarketReqID marketReqID
            { 
                get 
                {
                    QuickFix.Fields.MarketReqID val = new QuickFix.Fields.MarketReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketReqID val) 
            { 
                this.marketReqID = val;
            }
            
            public QuickFix.Fields.MarketReqID get(QuickFix.Fields.MarketReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketReqID val) 
            { 
                return isSetMarketReqID();
            }
            
            public bool isSetMarketReqID() 
            { 
                return isSetField(Tags.MarketReqID);
            }
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID get(QuickFix.Fields.MarketID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketID val) 
            { 
                return isSetMarketID();
            }
            
            public bool isSetMarketID() 
            { 
                return isSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID get(QuickFix.Fields.MarketSegmentID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return isSetMarketSegmentID();
            }
            
            public bool isSetMarketSegmentID() 
            { 
                return isSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.MarketSegmentDesc marketSegmentDesc
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentDesc val = new QuickFix.Fields.MarketSegmentDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                this.marketSegmentDesc = val;
            }
            
            public QuickFix.Fields.MarketSegmentDesc get(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                return isSetMarketSegmentDesc();
            }
            
            public bool isSetMarketSegmentDesc() 
            { 
                return isSetField(Tags.MarketSegmentDesc);
            }
            public QuickFix.Fields.EncodedMktSegmDescLen encodedMktSegmDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedMktSegmDescLen val = new QuickFix.Fields.EncodedMktSegmDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                this.encodedMktSegmDescLen = val;
            }
            
            public QuickFix.Fields.EncodedMktSegmDescLen get(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                return isSetEncodedMktSegmDescLen();
            }
            
            public bool isSetEncodedMktSegmDescLen() 
            { 
                return isSetField(Tags.EncodedMktSegmDescLen);
            }
            public QuickFix.Fields.EncodedMktSegmDesc encodedMktSegmDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedMktSegmDesc val = new QuickFix.Fields.EncodedMktSegmDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                this.encodedMktSegmDesc = val;
            }
            
            public QuickFix.Fields.EncodedMktSegmDesc get(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                return isSetEncodedMktSegmDesc();
            }
            
            public bool isSetEncodedMktSegmDesc() 
            { 
                return isSetField(Tags.EncodedMktSegmDesc);
            }
            public QuickFix.Fields.ParentMktSegmID parentMktSegmID
            { 
                get 
                {
                    QuickFix.Fields.ParentMktSegmID val = new QuickFix.Fields.ParentMktSegmID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ParentMktSegmID val) 
            { 
                this.parentMktSegmID = val;
            }
            
            public QuickFix.Fields.ParentMktSegmID get(QuickFix.Fields.ParentMktSegmID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ParentMktSegmID val) 
            { 
                return isSetParentMktSegmID();
            }
            
            public bool isSetParentMktSegmID() 
            { 
                return isSetField(Tags.ParentMktSegmID);
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
            public QuickFix.Fields.NoTickRules noTickRules
            { 
                get 
                {
                    QuickFix.Fields.NoTickRules val = new QuickFix.Fields.NoTickRules();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoTickRules val) 
            { 
                this.noTickRules = val;
            }
            
            public QuickFix.Fields.NoTickRules get(QuickFix.Fields.NoTickRules val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoTickRules val) 
            { 
                return isSetNoTickRules();
            }
            
            public bool isSetNoTickRules() 
            { 
                return isSetField(Tags.NoTickRules);
            }
            public QuickFix.Fields.NoLotTypeRules noLotTypeRules
            { 
                get 
                {
                    QuickFix.Fields.NoLotTypeRules val = new QuickFix.Fields.NoLotTypeRules();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoLotTypeRules val) 
            { 
                this.noLotTypeRules = val;
            }
            
            public QuickFix.Fields.NoLotTypeRules get(QuickFix.Fields.NoLotTypeRules val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoLotTypeRules val) 
            { 
                return isSetNoLotTypeRules();
            }
            
            public bool isSetNoLotTypeRules() 
            { 
                return isSetField(Tags.NoLotTypeRules);
            }
            public QuickFix.Fields.PriceLimitType priceLimitType
            { 
                get 
                {
                    QuickFix.Fields.PriceLimitType val = new QuickFix.Fields.PriceLimitType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceLimitType val) 
            { 
                this.priceLimitType = val;
            }
            
            public QuickFix.Fields.PriceLimitType get(QuickFix.Fields.PriceLimitType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceLimitType val) 
            { 
                return isSetPriceLimitType();
            }
            
            public bool isSetPriceLimitType() 
            { 
                return isSetField(Tags.PriceLimitType);
            }
            public QuickFix.Fields.LowLimitPrice lowLimitPrice
            { 
                get 
                {
                    QuickFix.Fields.LowLimitPrice val = new QuickFix.Fields.LowLimitPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LowLimitPrice val) 
            { 
                this.lowLimitPrice = val;
            }
            
            public QuickFix.Fields.LowLimitPrice get(QuickFix.Fields.LowLimitPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LowLimitPrice val) 
            { 
                return isSetLowLimitPrice();
            }
            
            public bool isSetLowLimitPrice() 
            { 
                return isSetField(Tags.LowLimitPrice);
            }
            public QuickFix.Fields.HighLimitPrice highLimitPrice
            { 
                get 
                {
                    QuickFix.Fields.HighLimitPrice val = new QuickFix.Fields.HighLimitPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.HighLimitPrice val) 
            { 
                this.highLimitPrice = val;
            }
            
            public QuickFix.Fields.HighLimitPrice get(QuickFix.Fields.HighLimitPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.HighLimitPrice val) 
            { 
                return isSetHighLimitPrice();
            }
            
            public bool isSetHighLimitPrice() 
            { 
                return isSetField(Tags.HighLimitPrice);
            }
            public QuickFix.Fields.TradingReferencePrice tradingReferencePrice
            { 
                get 
                {
                    QuickFix.Fields.TradingReferencePrice val = new QuickFix.Fields.TradingReferencePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingReferencePrice val) 
            { 
                this.tradingReferencePrice = val;
            }
            
            public QuickFix.Fields.TradingReferencePrice get(QuickFix.Fields.TradingReferencePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingReferencePrice val) 
            { 
                return isSetTradingReferencePrice();
            }
            
            public bool isSetTradingReferencePrice() 
            { 
                return isSetField(Tags.TradingReferencePrice);
            }
            public QuickFix.Fields.ExpirationCycle expirationCycle
            { 
                get 
                {
                    QuickFix.Fields.ExpirationCycle val = new QuickFix.Fields.ExpirationCycle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExpirationCycle val) 
            { 
                this.expirationCycle = val;
            }
            
            public QuickFix.Fields.ExpirationCycle get(QuickFix.Fields.ExpirationCycle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExpirationCycle val) 
            { 
                return isSetExpirationCycle();
            }
            
            public bool isSetExpirationCycle() 
            { 
                return isSetField(Tags.ExpirationCycle);
            }
            public QuickFix.Fields.MinTradeVol minTradeVol
            { 
                get 
                {
                    QuickFix.Fields.MinTradeVol val = new QuickFix.Fields.MinTradeVol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MinTradeVol val) 
            { 
                this.minTradeVol = val;
            }
            
            public QuickFix.Fields.MinTradeVol get(QuickFix.Fields.MinTradeVol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MinTradeVol val) 
            { 
                return isSetMinTradeVol();
            }
            
            public bool isSetMinTradeVol() 
            { 
                return isSetField(Tags.MinTradeVol);
            }
            public QuickFix.Fields.MaxTradeVol maxTradeVol
            { 
                get 
                {
                    QuickFix.Fields.MaxTradeVol val = new QuickFix.Fields.MaxTradeVol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaxTradeVol val) 
            { 
                this.maxTradeVol = val;
            }
            
            public QuickFix.Fields.MaxTradeVol get(QuickFix.Fields.MaxTradeVol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaxTradeVol val) 
            { 
                return isSetMaxTradeVol();
            }
            
            public bool isSetMaxTradeVol() 
            { 
                return isSetField(Tags.MaxTradeVol);
            }
            public QuickFix.Fields.MaxPriceVariation maxPriceVariation
            { 
                get 
                {
                    QuickFix.Fields.MaxPriceVariation val = new QuickFix.Fields.MaxPriceVariation();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaxPriceVariation val) 
            { 
                this.maxPriceVariation = val;
            }
            
            public QuickFix.Fields.MaxPriceVariation get(QuickFix.Fields.MaxPriceVariation val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaxPriceVariation val) 
            { 
                return isSetMaxPriceVariation();
            }
            
            public bool isSetMaxPriceVariation() 
            { 
                return isSetField(Tags.MaxPriceVariation);
            }
            public QuickFix.Fields.ImpliedMarketIndicator impliedMarketIndicator
            { 
                get 
                {
                    QuickFix.Fields.ImpliedMarketIndicator val = new QuickFix.Fields.ImpliedMarketIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                this.impliedMarketIndicator = val;
            }
            
            public QuickFix.Fields.ImpliedMarketIndicator get(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                return isSetImpliedMarketIndicator();
            }
            
            public bool isSetImpliedMarketIndicator() 
            { 
                return isSetField(Tags.ImpliedMarketIndicator);
            }
            public QuickFix.Fields.TradingCurrency tradingCurrency
            { 
                get 
                {
                    QuickFix.Fields.TradingCurrency val = new QuickFix.Fields.TradingCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingCurrency val) 
            { 
                this.tradingCurrency = val;
            }
            
            public QuickFix.Fields.TradingCurrency get(QuickFix.Fields.TradingCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingCurrency val) 
            { 
                return isSetTradingCurrency();
            }
            
            public bool isSetTradingCurrency() 
            { 
                return isSetField(Tags.TradingCurrency);
            }
            public QuickFix.Fields.RoundLot roundLot
            { 
                get 
                {
                    QuickFix.Fields.RoundLot val = new QuickFix.Fields.RoundLot();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RoundLot val) 
            { 
                this.roundLot = val;
            }
            
            public QuickFix.Fields.RoundLot get(QuickFix.Fields.RoundLot val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RoundLot val) 
            { 
                return isSetRoundLot();
            }
            
            public bool isSetRoundLot() 
            { 
                return isSetField(Tags.RoundLot);
            }
            public QuickFix.Fields.MultilegModel multilegModel
            { 
                get 
                {
                    QuickFix.Fields.MultilegModel val = new QuickFix.Fields.MultilegModel();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MultilegModel val) 
            { 
                this.multilegModel = val;
            }
            
            public QuickFix.Fields.MultilegModel get(QuickFix.Fields.MultilegModel val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MultilegModel val) 
            { 
                return isSetMultilegModel();
            }
            
            public bool isSetMultilegModel() 
            { 
                return isSetField(Tags.MultilegModel);
            }
            public QuickFix.Fields.MultilegPriceMethod multilegPriceMethod
            { 
                get 
                {
                    QuickFix.Fields.MultilegPriceMethod val = new QuickFix.Fields.MultilegPriceMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                this.multilegPriceMethod = val;
            }
            
            public QuickFix.Fields.MultilegPriceMethod get(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                return isSetMultilegPriceMethod();
            }
            
            public bool isSetMultilegPriceMethod() 
            { 
                return isSetField(Tags.MultilegPriceMethod);
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
            public QuickFix.Fields.NoOrdTypeRules noOrdTypeRules
            { 
                get 
                {
                    QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                this.noOrdTypeRules = val;
            }
            
            public QuickFix.Fields.NoOrdTypeRules get(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                return isSetNoOrdTypeRules();
            }
            
            public bool isSetNoOrdTypeRules() 
            { 
                return isSetField(Tags.NoOrdTypeRules);
            }
            public QuickFix.Fields.NoTimeInForceRules noTimeInForceRules
            { 
                get 
                {
                    QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                this.noTimeInForceRules = val;
            }
            
            public QuickFix.Fields.NoTimeInForceRules get(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                return isSetNoTimeInForceRules();
            }
            
            public bool isSetNoTimeInForceRules() 
            { 
                return isSetField(Tags.NoTimeInForceRules);
            }
            public QuickFix.Fields.NoExecInstRules noExecInstRules
            { 
                get 
                {
                    QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoExecInstRules val) 
            { 
                this.noExecInstRules = val;
            }
            
            public QuickFix.Fields.NoExecInstRules get(QuickFix.Fields.NoExecInstRules val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoExecInstRules val) 
            { 
                return isSetNoExecInstRules();
            }
            
            public bool isSetNoExecInstRules() 
            { 
                return isSetField(Tags.NoExecInstRules);
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
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID get(QuickFix.Fields.ApplID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplID val) 
            { 
                return isSetApplID();
            }
            
            public bool isSetApplID() 
            { 
                return isSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum get(QuickFix.Fields.ApplSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return isSetApplSeqNum();
            }
            
            public bool isSetApplSeqNum() 
            { 
                return isSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return isSetApplLastSeqNum();
            }
            
            public bool isSetApplLastSeqNum() 
            { 
                return isSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag get(QuickFix.Fields.ApplResendFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return isSetApplResendFlag();
            }
            
            public bool isSetApplResendFlag() 
            { 
                return isSetField(Tags.ApplResendFlag);
            }
            public class NoTickRules : Group
            {
                public NoTickRules() 
                  :base( Tags.NoTickRules, Tags.StartTickPriceRange, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0};
                            public QuickFix.Fields.StartTickPriceRange startTickPriceRange
                { 
                    get 
                    {
                        QuickFix.Fields.StartTickPriceRange val = new QuickFix.Fields.StartTickPriceRange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    this.startTickPriceRange = val;
                }
                
                public QuickFix.Fields.StartTickPriceRange get(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    return isSetStartTickPriceRange();
                }
                
                public bool isSetStartTickPriceRange() 
                { 
                    return isSetField(Tags.StartTickPriceRange);
                }
                public QuickFix.Fields.EndTickPriceRange endTickPriceRange
                { 
                    get 
                    {
                        QuickFix.Fields.EndTickPriceRange val = new QuickFix.Fields.EndTickPriceRange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    this.endTickPriceRange = val;
                }
                
                public QuickFix.Fields.EndTickPriceRange get(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    return isSetEndTickPriceRange();
                }
                
                public bool isSetEndTickPriceRange() 
                { 
                    return isSetField(Tags.EndTickPriceRange);
                }
                public QuickFix.Fields.TickIncrement tickIncrement
                { 
                    get 
                    {
                        QuickFix.Fields.TickIncrement val = new QuickFix.Fields.TickIncrement();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TickIncrement val) 
                { 
                    this.tickIncrement = val;
                }
                
                public QuickFix.Fields.TickIncrement get(QuickFix.Fields.TickIncrement val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TickIncrement val) 
                { 
                    return isSetTickIncrement();
                }
                
                public bool isSetTickIncrement() 
                { 
                    return isSetField(Tags.TickIncrement);
                }
                public QuickFix.Fields.TickRuleType tickRuleType
                { 
                    get 
                    {
                        QuickFix.Fields.TickRuleType val = new QuickFix.Fields.TickRuleType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TickRuleType val) 
                { 
                    this.tickRuleType = val;
                }
                
                public QuickFix.Fields.TickRuleType get(QuickFix.Fields.TickRuleType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TickRuleType val) 
                { 
                    return isSetTickRuleType();
                }
                
                public bool isSetTickRuleType() 
                { 
                    return isSetField(Tags.TickRuleType);
                }
            
            }
            public class NoLotTypeRules : Group
            {
                public NoLotTypeRules() 
                  :base( Tags.NoLotTypeRules, Tags.LotType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.LotType, Tags.MinLotSize, 0};
                            public QuickFix.Fields.LotType lotType
                { 
                    get 
                    {
                        QuickFix.Fields.LotType val = new QuickFix.Fields.LotType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LotType val) 
                { 
                    this.lotType = val;
                }
                
                public QuickFix.Fields.LotType get(QuickFix.Fields.LotType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LotType val) 
                { 
                    return isSetLotType();
                }
                
                public bool isSetLotType() 
                { 
                    return isSetField(Tags.LotType);
                }
                public QuickFix.Fields.MinLotSize minLotSize
                { 
                    get 
                    {
                        QuickFix.Fields.MinLotSize val = new QuickFix.Fields.MinLotSize();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinLotSize val) 
                { 
                    this.minLotSize = val;
                }
                
                public QuickFix.Fields.MinLotSize get(QuickFix.Fields.MinLotSize val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinLotSize val) 
                { 
                    return isSetMinLotSize();
                }
                
                public bool isSetMinLotSize() 
                { 
                    return isSetField(Tags.MinLotSize);
                }
            
            }
            public class NoOrdTypeRules : Group
            {
                public NoOrdTypeRules() 
                  :base( Tags.NoOrdTypeRules, Tags.OrdType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.OrdType, 0};
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
            
            }
            public class NoTimeInForceRules : Group
            {
                public NoTimeInForceRules() 
                  :base( Tags.NoTimeInForceRules, Tags.TimeInForce, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.TimeInForce, 0};
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
            
            }
            public class NoExecInstRules : Group
            {
                public NoExecInstRules() 
                  :base( Tags.NoExecInstRules, Tags.ExecInstValue, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ExecInstValue, 0};
                            public QuickFix.Fields.ExecInstValue execInstValue
                { 
                    get 
                    {
                        QuickFix.Fields.ExecInstValue val = new QuickFix.Fields.ExecInstValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExecInstValue val) 
                { 
                    this.execInstValue = val;
                }
                
                public QuickFix.Fields.ExecInstValue get(QuickFix.Fields.ExecInstValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExecInstValue val) 
                { 
                    return isSetExecInstValue();
                }
                
                public bool isSetExecInstValue() 
                { 
                    return isSetField(Tags.ExecInstValue);
                }
            
            }
        }
    }
}
