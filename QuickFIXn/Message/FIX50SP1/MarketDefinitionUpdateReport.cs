// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class MarketDefinitionUpdateReport : Message
        {
            public const string MsgType = "BV";

            public MarketDefinitionUpdateReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BV"));
            }

            public MarketDefinitionUpdateReport(
                    QuickFix.Fields.MarketReportID aMarketReportID,
                    QuickFix.Fields.MarketID aMarketID
                ) : this()
            {
                this.MarketReportID = aMarketReportID;
                this.MarketID = aMarketID;
            }

            public QuickFix.Fields.MarketReportID MarketReportID
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
                this.MarketReportID = val;
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
            public QuickFix.Fields.MarketReqID MarketReqID
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
                this.MarketReqID = val;
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
            public QuickFix.Fields.MarketUpdateAction MarketUpdateAction
            { 
                get 
                {
                    QuickFix.Fields.MarketUpdateAction val = new QuickFix.Fields.MarketUpdateAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarketUpdateAction val) 
            { 
                this.MarketUpdateAction = val;
            }
            
            public QuickFix.Fields.MarketUpdateAction Get(QuickFix.Fields.MarketUpdateAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarketUpdateAction val) 
            { 
                return IsSetMarketUpdateAction();
            }
            
            public bool IsSetMarketUpdateAction() 
            { 
                return IsSetField(Tags.MarketUpdateAction);
            }
            public QuickFix.Fields.MarketID MarketID
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
                this.MarketID = val;
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
            public QuickFix.Fields.MarketSegmentID MarketSegmentID
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
                this.MarketSegmentID = val;
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
            public QuickFix.Fields.MarketSegmentDesc MarketSegmentDesc
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
                this.MarketSegmentDesc = val;
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
            public QuickFix.Fields.EncodedMktSegmDescLen EncodedMktSegmDescLen
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
                this.EncodedMktSegmDescLen = val;
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
            public QuickFix.Fields.EncodedMktSegmDesc EncodedMktSegmDesc
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
                this.EncodedMktSegmDesc = val;
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
            public QuickFix.Fields.ParentMktSegmID ParentMktSegmID
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
                this.ParentMktSegmID = val;
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
            public QuickFix.Fields.Currency Currency
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
                this.Currency = val;
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
            public QuickFix.Fields.NoTickRules NoTickRules
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
                this.NoTickRules = val;
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
            public QuickFix.Fields.NoLotTypeRules NoLotTypeRules
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
                this.NoLotTypeRules = val;
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
            public QuickFix.Fields.PriceLimitType PriceLimitType
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
                this.PriceLimitType = val;
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
            public QuickFix.Fields.LowLimitPrice LowLimitPrice
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
                this.LowLimitPrice = val;
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
            public QuickFix.Fields.HighLimitPrice HighLimitPrice
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
                this.HighLimitPrice = val;
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
            public QuickFix.Fields.TradingReferencePrice TradingReferencePrice
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
                this.TradingReferencePrice = val;
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
            public QuickFix.Fields.ExpirationCycle ExpirationCycle
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
                this.ExpirationCycle = val;
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
            public QuickFix.Fields.MinTradeVol MinTradeVol
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
                this.MinTradeVol = val;
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
            public QuickFix.Fields.MaxTradeVol MaxTradeVol
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
                this.MaxTradeVol = val;
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
            public QuickFix.Fields.MaxPriceVariation MaxPriceVariation
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
                this.MaxPriceVariation = val;
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
            public QuickFix.Fields.ImpliedMarketIndicator ImpliedMarketIndicator
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
                this.ImpliedMarketIndicator = val;
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
            public QuickFix.Fields.TradingCurrency TradingCurrency
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
                this.TradingCurrency = val;
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
            public QuickFix.Fields.RoundLot RoundLot
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
                this.RoundLot = val;
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
            public QuickFix.Fields.MultilegModel MultilegModel
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
                this.MultilegModel = val;
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
            public QuickFix.Fields.MultilegPriceMethod MultilegPriceMethod
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
                this.MultilegPriceMethod = val;
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
            public QuickFix.Fields.PriceType PriceType
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
                this.PriceType = val;
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
            public QuickFix.Fields.NoOrdTypeRules NoOrdTypeRules
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
                this.NoOrdTypeRules = val;
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
            public QuickFix.Fields.NoTimeInForceRules NoTimeInForceRules
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
                this.NoTimeInForceRules = val;
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
            public QuickFix.Fields.NoExecInstRules NoExecInstRules
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
                this.NoExecInstRules = val;
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
            public QuickFix.Fields.TransactTime TransactTime
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
                this.TransactTime = val;
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
            public QuickFix.Fields.EncodedTextLen EncodedTextLen
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
                this.EncodedTextLen = val;
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
            public QuickFix.Fields.EncodedText EncodedText
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
                this.EncodedText = val;
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
            public QuickFix.Fields.ApplID ApplID
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
                this.ApplID = val;
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
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
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
                this.ApplSeqNum = val;
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
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
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
                this.ApplLastSeqNum = val;
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
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
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
                this.ApplResendFlag = val;
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
            public class NoTickRulesGroup : Group
            {
                public static int[] fieldOrder = {Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0};
            
                public NoTickRulesGroup() 
                  :base( Tags.NoTickRules, Tags.StartTickPriceRange, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTickRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.StartTickPriceRange StartTickPriceRange
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
                    this.StartTickPriceRange = val;
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
                public QuickFix.Fields.EndTickPriceRange EndTickPriceRange
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
                    this.EndTickPriceRange = val;
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
                public QuickFix.Fields.TickIncrement TickIncrement
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
                    this.TickIncrement = val;
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
                public QuickFix.Fields.TickRuleType TickRuleType
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
                    this.TickRuleType = val;
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
            public class NoLotTypeRulesGroup : Group
            {
                public static int[] fieldOrder = {Tags.LotType, Tags.MinLotSize, 0};
            
                public NoLotTypeRulesGroup() 
                  :base( Tags.NoLotTypeRules, Tags.LotType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLotTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LotType LotType
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
                    this.LotType = val;
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
                public QuickFix.Fields.MinLotSize MinLotSize
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
                    this.MinLotSize = val;
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
            public class NoOrdTypeRulesGroup : Group
            {
                public static int[] fieldOrder = {Tags.OrdType, 0};
            
                public NoOrdTypeRulesGroup() 
                  :base( Tags.NoOrdTypeRules, Tags.OrdType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoOrdTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.OrdType OrdType
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
                    this.OrdType = val;
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
            public class NoTimeInForceRulesGroup : Group
            {
                public static int[] fieldOrder = {Tags.TimeInForce, 0};
            
                public NoTimeInForceRulesGroup() 
                  :base( Tags.NoTimeInForceRules, Tags.TimeInForce, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTimeInForceRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.TimeInForce TimeInForce
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
                    this.TimeInForce = val;
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
            public class NoExecInstRulesGroup : Group
            {
                public static int[] fieldOrder = {Tags.ExecInstValue, 0};
            
                public NoExecInstRulesGroup() 
                  :base( Tags.NoExecInstRules, Tags.ExecInstValue, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoExecInstRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ExecInstValue ExecInstValue
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
                    this.ExecInstValue = val;
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
