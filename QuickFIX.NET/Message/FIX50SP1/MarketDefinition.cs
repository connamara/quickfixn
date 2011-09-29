// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class MarketDefinition : Message
        {
            public const string MsgType = "BU";

            public MarketDefinition() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BU"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketReportID val) 
            { 
                this.marketReportID = val;
            }
            
            public QuickFix.Fields.MarketReportID Get(QuickFix.Fields.MarketReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketReportID val) 
            { 
                return IsSetMarketReportID();
            }
            
            public bool IsSetMarketReportID() 
            { 
                return IsSetField(Tags.MarketReportID);
            }
            public QuickFix.Fields.MarketReqID marketReqID
            { 
                get 
                {
                    QuickFix.Fields.MarketReqID val = new QuickFix.Fields.MarketReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketReqID val) 
            { 
                this.marketReqID = val;
            }
            
            public QuickFix.Fields.MarketReqID Get(QuickFix.Fields.MarketReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketReqID val) 
            { 
                return IsSetMarketReqID();
            }
            
            public bool IsSetMarketReqID() 
            { 
                return IsSetField(Tags.MarketReqID);
            }
            public QuickFix.Fields.MarketID marketID
            { 
                get 
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketID val) 
            { 
                this.marketID = val;
            }
            
            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketID val) 
            { 
                return IsSetMarketID();
            }
            
            public bool IsSetMarketID() 
            { 
                return IsSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID marketSegmentID
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentID val) 
            { 
                this.marketSegmentID = val;
            }
            
            public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentID val) 
            { 
                return IsSetMarketSegmentID();
            }
            
            public bool IsSetMarketSegmentID() 
            { 
                return IsSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.MarketSegmentDesc marketSegmentDesc
            { 
                get 
                {
                    QuickFix.Fields.MarketSegmentDesc val = new QuickFix.Fields.MarketSegmentDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                this.marketSegmentDesc = val;
            }
            
            public QuickFix.Fields.MarketSegmentDesc Get(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketSegmentDesc val) 
            { 
                return IsSetMarketSegmentDesc();
            }
            
            public bool IsSetMarketSegmentDesc() 
            { 
                return IsSetField(Tags.MarketSegmentDesc);
            }
            public QuickFix.Fields.EncodedMktSegmDescLen encodedMktSegmDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedMktSegmDescLen val = new QuickFix.Fields.EncodedMktSegmDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                this.encodedMktSegmDescLen = val;
            }
            
            public QuickFix.Fields.EncodedMktSegmDescLen Get(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedMktSegmDescLen val) 
            { 
                return IsSetEncodedMktSegmDescLen();
            }
            
            public bool IsSetEncodedMktSegmDescLen() 
            { 
                return IsSetField(Tags.EncodedMktSegmDescLen);
            }
            public QuickFix.Fields.EncodedMktSegmDesc encodedMktSegmDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedMktSegmDesc val = new QuickFix.Fields.EncodedMktSegmDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                this.encodedMktSegmDesc = val;
            }
            
            public QuickFix.Fields.EncodedMktSegmDesc Get(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedMktSegmDesc val) 
            { 
                return IsSetEncodedMktSegmDesc();
            }
            
            public bool IsSetEncodedMktSegmDesc() 
            { 
                return IsSetField(Tags.EncodedMktSegmDesc);
            }
            public QuickFix.Fields.ParentMktSegmID parentMktSegmID
            { 
                get 
                {
                    QuickFix.Fields.ParentMktSegmID val = new QuickFix.Fields.ParentMktSegmID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ParentMktSegmID val) 
            { 
                this.parentMktSegmID = val;
            }
            
            public QuickFix.Fields.ParentMktSegmID Get(QuickFix.Fields.ParentMktSegmID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ParentMktSegmID val) 
            { 
                return IsSetParentMktSegmID();
            }
            
            public bool IsSetParentMktSegmID() 
            { 
                return IsSetField(Tags.ParentMktSegmID);
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
            public QuickFix.Fields.NoTickRules noTickRules
            { 
                get 
                {
                    QuickFix.Fields.NoTickRules val = new QuickFix.Fields.NoTickRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTickRules val) 
            { 
                this.noTickRules = val;
            }
            
            public QuickFix.Fields.NoTickRules Get(QuickFix.Fields.NoTickRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTickRules val) 
            { 
                return IsSetNoTickRules();
            }
            
            public bool IsSetNoTickRules() 
            { 
                return IsSetField(Tags.NoTickRules);
            }
            public QuickFix.Fields.NoLotTypeRules noLotTypeRules
            { 
                get 
                {
                    QuickFix.Fields.NoLotTypeRules val = new QuickFix.Fields.NoLotTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLotTypeRules val) 
            { 
                this.noLotTypeRules = val;
            }
            
            public QuickFix.Fields.NoLotTypeRules Get(QuickFix.Fields.NoLotTypeRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLotTypeRules val) 
            { 
                return IsSetNoLotTypeRules();
            }
            
            public bool IsSetNoLotTypeRules() 
            { 
                return IsSetField(Tags.NoLotTypeRules);
            }
            public QuickFix.Fields.PriceLimitType priceLimitType
            { 
                get 
                {
                    QuickFix.Fields.PriceLimitType val = new QuickFix.Fields.PriceLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceLimitType val) 
            { 
                this.priceLimitType = val;
            }
            
            public QuickFix.Fields.PriceLimitType Get(QuickFix.Fields.PriceLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceLimitType val) 
            { 
                return IsSetPriceLimitType();
            }
            
            public bool IsSetPriceLimitType() 
            { 
                return IsSetField(Tags.PriceLimitType);
            }
            public QuickFix.Fields.LowLimitPrice lowLimitPrice
            { 
                get 
                {
                    QuickFix.Fields.LowLimitPrice val = new QuickFix.Fields.LowLimitPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LowLimitPrice val) 
            { 
                this.lowLimitPrice = val;
            }
            
            public QuickFix.Fields.LowLimitPrice Get(QuickFix.Fields.LowLimitPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LowLimitPrice val) 
            { 
                return IsSetLowLimitPrice();
            }
            
            public bool IsSetLowLimitPrice() 
            { 
                return IsSetField(Tags.LowLimitPrice);
            }
            public QuickFix.Fields.HighLimitPrice highLimitPrice
            { 
                get 
                {
                    QuickFix.Fields.HighLimitPrice val = new QuickFix.Fields.HighLimitPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HighLimitPrice val) 
            { 
                this.highLimitPrice = val;
            }
            
            public QuickFix.Fields.HighLimitPrice Get(QuickFix.Fields.HighLimitPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HighLimitPrice val) 
            { 
                return IsSetHighLimitPrice();
            }
            
            public bool IsSetHighLimitPrice() 
            { 
                return IsSetField(Tags.HighLimitPrice);
            }
            public QuickFix.Fields.TradingReferencePrice tradingReferencePrice
            { 
                get 
                {
                    QuickFix.Fields.TradingReferencePrice val = new QuickFix.Fields.TradingReferencePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingReferencePrice val) 
            { 
                this.tradingReferencePrice = val;
            }
            
            public QuickFix.Fields.TradingReferencePrice Get(QuickFix.Fields.TradingReferencePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingReferencePrice val) 
            { 
                return IsSetTradingReferencePrice();
            }
            
            public bool IsSetTradingReferencePrice() 
            { 
                return IsSetField(Tags.TradingReferencePrice);
            }
            public QuickFix.Fields.ExpirationCycle expirationCycle
            { 
                get 
                {
                    QuickFix.Fields.ExpirationCycle val = new QuickFix.Fields.ExpirationCycle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExpirationCycle val) 
            { 
                this.expirationCycle = val;
            }
            
            public QuickFix.Fields.ExpirationCycle Get(QuickFix.Fields.ExpirationCycle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExpirationCycle val) 
            { 
                return IsSetExpirationCycle();
            }
            
            public bool IsSetExpirationCycle() 
            { 
                return IsSetField(Tags.ExpirationCycle);
            }
            public QuickFix.Fields.MinTradeVol minTradeVol
            { 
                get 
                {
                    QuickFix.Fields.MinTradeVol val = new QuickFix.Fields.MinTradeVol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinTradeVol val) 
            { 
                this.minTradeVol = val;
            }
            
            public QuickFix.Fields.MinTradeVol Get(QuickFix.Fields.MinTradeVol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinTradeVol val) 
            { 
                return IsSetMinTradeVol();
            }
            
            public bool IsSetMinTradeVol() 
            { 
                return IsSetField(Tags.MinTradeVol);
            }
            public QuickFix.Fields.MaxTradeVol maxTradeVol
            { 
                get 
                {
                    QuickFix.Fields.MaxTradeVol val = new QuickFix.Fields.MaxTradeVol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxTradeVol val) 
            { 
                this.maxTradeVol = val;
            }
            
            public QuickFix.Fields.MaxTradeVol Get(QuickFix.Fields.MaxTradeVol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxTradeVol val) 
            { 
                return IsSetMaxTradeVol();
            }
            
            public bool IsSetMaxTradeVol() 
            { 
                return IsSetField(Tags.MaxTradeVol);
            }
            public QuickFix.Fields.MaxPriceVariation maxPriceVariation
            { 
                get 
                {
                    QuickFix.Fields.MaxPriceVariation val = new QuickFix.Fields.MaxPriceVariation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxPriceVariation val) 
            { 
                this.maxPriceVariation = val;
            }
            
            public QuickFix.Fields.MaxPriceVariation Get(QuickFix.Fields.MaxPriceVariation val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxPriceVariation val) 
            { 
                return IsSetMaxPriceVariation();
            }
            
            public bool IsSetMaxPriceVariation() 
            { 
                return IsSetField(Tags.MaxPriceVariation);
            }
            public QuickFix.Fields.ImpliedMarketIndicator impliedMarketIndicator
            { 
                get 
                {
                    QuickFix.Fields.ImpliedMarketIndicator val = new QuickFix.Fields.ImpliedMarketIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                this.impliedMarketIndicator = val;
            }
            
            public QuickFix.Fields.ImpliedMarketIndicator Get(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ImpliedMarketIndicator val) 
            { 
                return IsSetImpliedMarketIndicator();
            }
            
            public bool IsSetImpliedMarketIndicator() 
            { 
                return IsSetField(Tags.ImpliedMarketIndicator);
            }
            public QuickFix.Fields.TradingCurrency tradingCurrency
            { 
                get 
                {
                    QuickFix.Fields.TradingCurrency val = new QuickFix.Fields.TradingCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradingCurrency val) 
            { 
                this.tradingCurrency = val;
            }
            
            public QuickFix.Fields.TradingCurrency Get(QuickFix.Fields.TradingCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradingCurrency val) 
            { 
                return IsSetTradingCurrency();
            }
            
            public bool IsSetTradingCurrency() 
            { 
                return IsSetField(Tags.TradingCurrency);
            }
            public QuickFix.Fields.RoundLot roundLot
            { 
                get 
                {
                    QuickFix.Fields.RoundLot val = new QuickFix.Fields.RoundLot();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RoundLot val) 
            { 
                this.roundLot = val;
            }
            
            public QuickFix.Fields.RoundLot Get(QuickFix.Fields.RoundLot val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RoundLot val) 
            { 
                return IsSetRoundLot();
            }
            
            public bool IsSetRoundLot() 
            { 
                return IsSetField(Tags.RoundLot);
            }
            public QuickFix.Fields.MultilegModel multilegModel
            { 
                get 
                {
                    QuickFix.Fields.MultilegModel val = new QuickFix.Fields.MultilegModel();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MultilegModel val) 
            { 
                this.multilegModel = val;
            }
            
            public QuickFix.Fields.MultilegModel Get(QuickFix.Fields.MultilegModel val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MultilegModel val) 
            { 
                return IsSetMultilegModel();
            }
            
            public bool IsSetMultilegModel() 
            { 
                return IsSetField(Tags.MultilegModel);
            }
            public QuickFix.Fields.MultilegPriceMethod multilegPriceMethod
            { 
                get 
                {
                    QuickFix.Fields.MultilegPriceMethod val = new QuickFix.Fields.MultilegPriceMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                this.multilegPriceMethod = val;
            }
            
            public QuickFix.Fields.MultilegPriceMethod Get(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MultilegPriceMethod val) 
            { 
                return IsSetMultilegPriceMethod();
            }
            
            public bool IsSetMultilegPriceMethod() 
            { 
                return IsSetField(Tags.MultilegPriceMethod);
            }
            public QuickFix.Fields.PriceType priceType
            { 
                get 
                {
                    QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceType val) 
            { 
                this.priceType = val;
            }
            
            public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceType val) 
            { 
                return IsSetPriceType();
            }
            
            public bool IsSetPriceType() 
            { 
                return IsSetField(Tags.PriceType);
            }
            public QuickFix.Fields.NoOrdTypeRules noOrdTypeRules
            { 
                get 
                {
                    QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                this.noOrdTypeRules = val;
            }
            
            public QuickFix.Fields.NoOrdTypeRules Get(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoOrdTypeRules val) 
            { 
                return IsSetNoOrdTypeRules();
            }
            
            public bool IsSetNoOrdTypeRules() 
            { 
                return IsSetField(Tags.NoOrdTypeRules);
            }
            public QuickFix.Fields.NoTimeInForceRules noTimeInForceRules
            { 
                get 
                {
                    QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                this.noTimeInForceRules = val;
            }
            
            public QuickFix.Fields.NoTimeInForceRules Get(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTimeInForceRules val) 
            { 
                return IsSetNoTimeInForceRules();
            }
            
            public bool IsSetNoTimeInForceRules() 
            { 
                return IsSetField(Tags.NoTimeInForceRules);
            }
            public QuickFix.Fields.NoExecInstRules noExecInstRules
            { 
                get 
                {
                    QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoExecInstRules val) 
            { 
                this.noExecInstRules = val;
            }
            
            public QuickFix.Fields.NoExecInstRules Get(QuickFix.Fields.NoExecInstRules val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoExecInstRules val) 
            { 
                return IsSetNoExecInstRules();
            }
            
            public bool IsSetNoExecInstRules() 
            { 
                return IsSetField(Tags.NoExecInstRules);
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
            public QuickFix.Fields.Text text
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
                this.text = val;
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
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(Tags.EncodedText);
            }
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(Tags.ApplResendFlag);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    this.startTickPriceRange = val;
                }
                
                public QuickFix.Fields.StartTickPriceRange Get(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StartTickPriceRange val) 
                { 
                    return IsSetStartTickPriceRange();
                }
                
                public bool IsSetStartTickPriceRange() 
                { 
                    return IsSetField(Tags.StartTickPriceRange);
                }
                public QuickFix.Fields.EndTickPriceRange endTickPriceRange
                { 
                    get 
                    {
                        QuickFix.Fields.EndTickPriceRange val = new QuickFix.Fields.EndTickPriceRange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    this.endTickPriceRange = val;
                }
                
                public QuickFix.Fields.EndTickPriceRange Get(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EndTickPriceRange val) 
                { 
                    return IsSetEndTickPriceRange();
                }
                
                public bool IsSetEndTickPriceRange() 
                { 
                    return IsSetField(Tags.EndTickPriceRange);
                }
                public QuickFix.Fields.TickIncrement tickIncrement
                { 
                    get 
                    {
                        QuickFix.Fields.TickIncrement val = new QuickFix.Fields.TickIncrement();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickIncrement val) 
                { 
                    this.tickIncrement = val;
                }
                
                public QuickFix.Fields.TickIncrement Get(QuickFix.Fields.TickIncrement val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickIncrement val) 
                { 
                    return IsSetTickIncrement();
                }
                
                public bool IsSetTickIncrement() 
                { 
                    return IsSetField(Tags.TickIncrement);
                }
                public QuickFix.Fields.TickRuleType tickRuleType
                { 
                    get 
                    {
                        QuickFix.Fields.TickRuleType val = new QuickFix.Fields.TickRuleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickRuleType val) 
                { 
                    this.tickRuleType = val;
                }
                
                public QuickFix.Fields.TickRuleType Get(QuickFix.Fields.TickRuleType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickRuleType val) 
                { 
                    return IsSetTickRuleType();
                }
                
                public bool IsSetTickRuleType() 
                { 
                    return IsSetField(Tags.TickRuleType);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LotType val) 
                { 
                    this.lotType = val;
                }
                
                public QuickFix.Fields.LotType Get(QuickFix.Fields.LotType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LotType val) 
                { 
                    return IsSetLotType();
                }
                
                public bool IsSetLotType() 
                { 
                    return IsSetField(Tags.LotType);
                }
                public QuickFix.Fields.MinLotSize minLotSize
                { 
                    get 
                    {
                        QuickFix.Fields.MinLotSize val = new QuickFix.Fields.MinLotSize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinLotSize val) 
                { 
                    this.minLotSize = val;
                }
                
                public QuickFix.Fields.MinLotSize Get(QuickFix.Fields.MinLotSize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinLotSize val) 
                { 
                    return IsSetMinLotSize();
                }
                
                public bool IsSetMinLotSize() 
                { 
                    return IsSetField(Tags.MinLotSize);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TimeInForce val) 
                { 
                    this.timeInForce = val;
                }
                
                public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TimeInForce val) 
                { 
                    return IsSetTimeInForce();
                }
                
                public bool IsSetTimeInForce() 
                { 
                    return IsSetField(Tags.TimeInForce);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecInstValue val) 
                { 
                    this.execInstValue = val;
                }
                
                public QuickFix.Fields.ExecInstValue Get(QuickFix.Fields.ExecInstValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecInstValue val) 
                { 
                    return IsSetExecInstValue();
                }
                
                public bool IsSetExecInstValue() 
                { 
                    return IsSetField(Tags.ExecInstValue);
                }
            
            }
        }
    }
}
