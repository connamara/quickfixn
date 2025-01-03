// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class MarketDefinition : Message
{
    public const string MsgType = "BU";

    public MarketDefinition() : base()
    {
        Header.SetField(new MsgType("BU"));
    }

    public MarketDefinition(
            MarketReportID aMarketReportID,
            MarketID aMarketID
        ) : this()
    {
        MarketReportID = aMarketReportID;
        MarketID = aMarketID;
    }

    public MarketReportID MarketReportID
    {
        get
        {
            MarketReportID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketReportID val) { MarketReportID = val; }
    public MarketReportID Get(MarketReportID val) { GetField(val); return val; }
    public bool IsSet(MarketReportID val) { return IsSetMarketReportID(); }
    public bool IsSetMarketReportID() { return IsSetField(Tags.MarketReportID); }

    public MarketReqID MarketReqID
    {
        get
        {
            MarketReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketReqID val) { MarketReqID = val; }
    public MarketReqID Get(MarketReqID val) { GetField(val); return val; }
    public bool IsSet(MarketReqID val) { return IsSetMarketReqID(); }
    public bool IsSetMarketReqID() { return IsSetField(Tags.MarketReqID); }

    public MarketID MarketID
    {
        get
        {
            MarketID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketID val) { MarketID = val; }
    public MarketID Get(MarketID val) { GetField(val); return val; }
    public bool IsSet(MarketID val) { return IsSetMarketID(); }
    public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

    public MarketSegmentID MarketSegmentID
    {
        get
        {
            MarketSegmentID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketSegmentID val) { MarketSegmentID = val; }
    public MarketSegmentID Get(MarketSegmentID val) { GetField(val); return val; }
    public bool IsSet(MarketSegmentID val) { return IsSetMarketSegmentID(); }
    public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

    public MarketSegmentDesc MarketSegmentDesc
    {
        get
        {
            MarketSegmentDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketSegmentDesc val) { MarketSegmentDesc = val; }
    public MarketSegmentDesc Get(MarketSegmentDesc val) { GetField(val); return val; }
    public bool IsSet(MarketSegmentDesc val) { return IsSetMarketSegmentDesc(); }
    public bool IsSetMarketSegmentDesc() { return IsSetField(Tags.MarketSegmentDesc); }

    public EncodedMktSegmDescLen EncodedMktSegmDescLen
    {
        get
        {
            EncodedMktSegmDescLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedMktSegmDescLen val) { EncodedMktSegmDescLen = val; }
    public EncodedMktSegmDescLen Get(EncodedMktSegmDescLen val) { GetField(val); return val; }
    public bool IsSet(EncodedMktSegmDescLen val) { return IsSetEncodedMktSegmDescLen(); }
    public bool IsSetEncodedMktSegmDescLen() { return IsSetField(Tags.EncodedMktSegmDescLen); }

    public EncodedMktSegmDesc EncodedMktSegmDesc
    {
        get
        {
            EncodedMktSegmDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedMktSegmDesc val) { EncodedMktSegmDesc = val; }
    public EncodedMktSegmDesc Get(EncodedMktSegmDesc val) { GetField(val); return val; }
    public bool IsSet(EncodedMktSegmDesc val) { return IsSetEncodedMktSegmDesc(); }
    public bool IsSetEncodedMktSegmDesc() { return IsSetField(Tags.EncodedMktSegmDesc); }

    public ParentMktSegmID ParentMktSegmID
    {
        get
        {
            ParentMktSegmID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ParentMktSegmID val) { ParentMktSegmID = val; }
    public ParentMktSegmID Get(ParentMktSegmID val) { GetField(val); return val; }
    public bool IsSet(ParentMktSegmID val) { return IsSetParentMktSegmID(); }
    public bool IsSetParentMktSegmID() { return IsSetField(Tags.ParentMktSegmID); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public NoTickRules NoTickRules
    {
        get
        {
            NoTickRules val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTickRules val) { NoTickRules = val; }
    public NoTickRules Get(NoTickRules val) { GetField(val); return val; }
    public bool IsSet(NoTickRules val) { return IsSetNoTickRules(); }
    public bool IsSetNoTickRules() { return IsSetField(Tags.NoTickRules); }

    public NoLotTypeRules NoLotTypeRules
    {
        get
        {
            NoLotTypeRules val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoLotTypeRules val) { NoLotTypeRules = val; }
    public NoLotTypeRules Get(NoLotTypeRules val) { GetField(val); return val; }
    public bool IsSet(NoLotTypeRules val) { return IsSetNoLotTypeRules(); }
    public bool IsSetNoLotTypeRules() { return IsSetField(Tags.NoLotTypeRules); }

    public PriceLimitType PriceLimitType
    {
        get
        {
            PriceLimitType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceLimitType val) { PriceLimitType = val; }
    public PriceLimitType Get(PriceLimitType val) { GetField(val); return val; }
    public bool IsSet(PriceLimitType val) { return IsSetPriceLimitType(); }
    public bool IsSetPriceLimitType() { return IsSetField(Tags.PriceLimitType); }

    public LowLimitPrice LowLimitPrice
    {
        get
        {
            LowLimitPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LowLimitPrice val) { LowLimitPrice = val; }
    public LowLimitPrice Get(LowLimitPrice val) { GetField(val); return val; }
    public bool IsSet(LowLimitPrice val) { return IsSetLowLimitPrice(); }
    public bool IsSetLowLimitPrice() { return IsSetField(Tags.LowLimitPrice); }

    public HighLimitPrice HighLimitPrice
    {
        get
        {
            HighLimitPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HighLimitPrice val) { HighLimitPrice = val; }
    public HighLimitPrice Get(HighLimitPrice val) { GetField(val); return val; }
    public bool IsSet(HighLimitPrice val) { return IsSetHighLimitPrice(); }
    public bool IsSetHighLimitPrice() { return IsSetField(Tags.HighLimitPrice); }

    public TradingReferencePrice TradingReferencePrice
    {
        get
        {
            TradingReferencePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingReferencePrice val) { TradingReferencePrice = val; }
    public TradingReferencePrice Get(TradingReferencePrice val) { GetField(val); return val; }
    public bool IsSet(TradingReferencePrice val) { return IsSetTradingReferencePrice(); }
    public bool IsSetTradingReferencePrice() { return IsSetField(Tags.TradingReferencePrice); }

    public ExpirationCycle ExpirationCycle
    {
        get
        {
            ExpirationCycle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExpirationCycle val) { ExpirationCycle = val; }
    public ExpirationCycle Get(ExpirationCycle val) { GetField(val); return val; }
    public bool IsSet(ExpirationCycle val) { return IsSetExpirationCycle(); }
    public bool IsSetExpirationCycle() { return IsSetField(Tags.ExpirationCycle); }

    public MinTradeVol MinTradeVol
    {
        get
        {
            MinTradeVol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MinTradeVol val) { MinTradeVol = val; }
    public MinTradeVol Get(MinTradeVol val) { GetField(val); return val; }
    public bool IsSet(MinTradeVol val) { return IsSetMinTradeVol(); }
    public bool IsSetMinTradeVol() { return IsSetField(Tags.MinTradeVol); }

    public MaxTradeVol MaxTradeVol
    {
        get
        {
            MaxTradeVol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxTradeVol val) { MaxTradeVol = val; }
    public MaxTradeVol Get(MaxTradeVol val) { GetField(val); return val; }
    public bool IsSet(MaxTradeVol val) { return IsSetMaxTradeVol(); }
    public bool IsSetMaxTradeVol() { return IsSetField(Tags.MaxTradeVol); }

    public MaxPriceVariation MaxPriceVariation
    {
        get
        {
            MaxPriceVariation val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxPriceVariation val) { MaxPriceVariation = val; }
    public MaxPriceVariation Get(MaxPriceVariation val) { GetField(val); return val; }
    public bool IsSet(MaxPriceVariation val) { return IsSetMaxPriceVariation(); }
    public bool IsSetMaxPriceVariation() { return IsSetField(Tags.MaxPriceVariation); }

    public ImpliedMarketIndicator ImpliedMarketIndicator
    {
        get
        {
            ImpliedMarketIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ImpliedMarketIndicator val) { ImpliedMarketIndicator = val; }
    public ImpliedMarketIndicator Get(ImpliedMarketIndicator val) { GetField(val); return val; }
    public bool IsSet(ImpliedMarketIndicator val) { return IsSetImpliedMarketIndicator(); }
    public bool IsSetImpliedMarketIndicator() { return IsSetField(Tags.ImpliedMarketIndicator); }

    public TradingCurrency TradingCurrency
    {
        get
        {
            TradingCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingCurrency val) { TradingCurrency = val; }
    public TradingCurrency Get(TradingCurrency val) { GetField(val); return val; }
    public bool IsSet(TradingCurrency val) { return IsSetTradingCurrency(); }
    public bool IsSetTradingCurrency() { return IsSetField(Tags.TradingCurrency); }

    public RoundLot RoundLot
    {
        get
        {
            RoundLot val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RoundLot val) { RoundLot = val; }
    public RoundLot Get(RoundLot val) { GetField(val); return val; }
    public bool IsSet(RoundLot val) { return IsSetRoundLot(); }
    public bool IsSetRoundLot() { return IsSetField(Tags.RoundLot); }

    public MultilegModel MultilegModel
    {
        get
        {
            MultilegModel val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MultilegModel val) { MultilegModel = val; }
    public MultilegModel Get(MultilegModel val) { GetField(val); return val; }
    public bool IsSet(MultilegModel val) { return IsSetMultilegModel(); }
    public bool IsSetMultilegModel() { return IsSetField(Tags.MultilegModel); }

    public MultilegPriceMethod MultilegPriceMethod
    {
        get
        {
            MultilegPriceMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MultilegPriceMethod val) { MultilegPriceMethod = val; }
    public MultilegPriceMethod Get(MultilegPriceMethod val) { GetField(val); return val; }
    public bool IsSet(MultilegPriceMethod val) { return IsSetMultilegPriceMethod(); }
    public bool IsSetMultilegPriceMethod() { return IsSetField(Tags.MultilegPriceMethod); }

    public PriceType PriceType
    {
        get
        {
            PriceType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(PriceType val) { PriceType = val; }
    public PriceType Get(PriceType val) { GetField(val); return val; }
    public bool IsSet(PriceType val) { return IsSetPriceType(); }
    public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

    public NoOrdTypeRules NoOrdTypeRules
    {
        get
        {
            NoOrdTypeRules val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoOrdTypeRules val) { NoOrdTypeRules = val; }
    public NoOrdTypeRules Get(NoOrdTypeRules val) { GetField(val); return val; }
    public bool IsSet(NoOrdTypeRules val) { return IsSetNoOrdTypeRules(); }
    public bool IsSetNoOrdTypeRules() { return IsSetField(Tags.NoOrdTypeRules); }

    public NoTimeInForceRules NoTimeInForceRules
    {
        get
        {
            NoTimeInForceRules val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoTimeInForceRules val) { NoTimeInForceRules = val; }
    public NoTimeInForceRules Get(NoTimeInForceRules val) { GetField(val); return val; }
    public bool IsSet(NoTimeInForceRules val) { return IsSetNoTimeInForceRules(); }
    public bool IsSetNoTimeInForceRules() { return IsSetField(Tags.NoTimeInForceRules); }

    public NoExecInstRules NoExecInstRules
    {
        get
        {
            NoExecInstRules val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoExecInstRules val) { NoExecInstRules = val; }
    public NoExecInstRules Get(NoExecInstRules val) { GetField(val); return val; }
    public bool IsSet(NoExecInstRules val) { return IsSetNoExecInstRules(); }
    public bool IsSetNoExecInstRules() { return IsSetField(Tags.NoExecInstRules); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

    public ApplID ApplID
    {
        get
        {
            ApplID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplID val) { ApplID = val; }
    public ApplID Get(ApplID val) { GetField(val); return val; }
    public bool IsSet(ApplID val) { return IsSetApplID(); }
    public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

    public ApplSeqNum ApplSeqNum
    {
        get
        {
            ApplSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplSeqNum val) { ApplSeqNum = val; }
    public ApplSeqNum Get(ApplSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplSeqNum val) { return IsSetApplSeqNum(); }
    public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

    public ApplLastSeqNum ApplLastSeqNum
    {
        get
        {
            ApplLastSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplLastSeqNum val) { ApplLastSeqNum = val; }
    public ApplLastSeqNum Get(ApplLastSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }
    public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

    public ApplResendFlag ApplResendFlag
    {
        get
        {
            ApplResendFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResendFlag val) { ApplResendFlag = val; }
    public ApplResendFlag Get(ApplResendFlag val) { GetField(val); return val; }
    public bool IsSet(ApplResendFlag val) { return IsSetApplResendFlag(); }
    public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

    public class NoTickRulesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0};

        public NoTickRulesGroup()
          : base(Tags.NoTickRules, Tags.StartTickPriceRange, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTickRulesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public StartTickPriceRange StartTickPriceRange
        {
            get
            {
                StartTickPriceRange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StartTickPriceRange val) { StartTickPriceRange = val; }
        public StartTickPriceRange Get(StartTickPriceRange val) { GetField(val); return val; }
        public bool IsSet(StartTickPriceRange val) { return IsSetStartTickPriceRange(); }
        public bool IsSetStartTickPriceRange() { return IsSetField(Tags.StartTickPriceRange); }

        public EndTickPriceRange EndTickPriceRange
        {
            get
            {
                EndTickPriceRange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EndTickPriceRange val) { EndTickPriceRange = val; }
        public EndTickPriceRange Get(EndTickPriceRange val) { GetField(val); return val; }
        public bool IsSet(EndTickPriceRange val) { return IsSetEndTickPriceRange(); }
        public bool IsSetEndTickPriceRange() { return IsSetField(Tags.EndTickPriceRange); }

        public TickIncrement TickIncrement
        {
            get
            {
                TickIncrement val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TickIncrement val) { TickIncrement = val; }
        public TickIncrement Get(TickIncrement val) { GetField(val); return val; }
        public bool IsSet(TickIncrement val) { return IsSetTickIncrement(); }
        public bool IsSetTickIncrement() { return IsSetField(Tags.TickIncrement); }

        public TickRuleType TickRuleType
        {
            get
            {
                TickRuleType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TickRuleType val) { TickRuleType = val; }
        public TickRuleType Get(TickRuleType val) { GetField(val); return val; }
        public bool IsSet(TickRuleType val) { return IsSetTickRuleType(); }
        public bool IsSetTickRuleType() { return IsSetField(Tags.TickRuleType); }
    }

    public class NoLotTypeRulesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.LotType, Tags.MinLotSize, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.LotType, Tags.MinLotSize, 0};

        public NoLotTypeRulesGroup()
          : base(Tags.NoLotTypeRules, Tags.LotType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoLotTypeRulesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public LotType LotType
        {
            get
            {
                LotType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LotType val) { LotType = val; }
        public LotType Get(LotType val) { GetField(val); return val; }
        public bool IsSet(LotType val) { return IsSetLotType(); }
        public bool IsSetLotType() { return IsSetField(Tags.LotType); }

        public MinLotSize MinLotSize
        {
            get
            {
                MinLotSize val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MinLotSize val) { MinLotSize = val; }
        public MinLotSize Get(MinLotSize val) { GetField(val); return val; }
        public bool IsSet(MinLotSize val) { return IsSetMinLotSize(); }
        public bool IsSetMinLotSize() { return IsSetField(Tags.MinLotSize); }
    }

    public class NoOrdTypeRulesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.OrdType, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.OrdType, 0};

        public NoOrdTypeRulesGroup()
          : base(Tags.NoOrdTypeRules, Tags.OrdType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoOrdTypeRulesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public OrdType OrdType
        {
            get
            {
                OrdType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrdType val) { OrdType = val; }
        public OrdType Get(OrdType val) { GetField(val); return val; }
        public bool IsSet(OrdType val) { return IsSetOrdType(); }
        public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }
    }

    public class NoTimeInForceRulesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.TimeInForce, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.TimeInForce, 0};

        public NoTimeInForceRulesGroup()
          : base(Tags.NoTimeInForceRules, Tags.TimeInForce, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoTimeInForceRulesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public TimeInForce TimeInForce
        {
            get
            {
                TimeInForce val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TimeInForce val) { TimeInForce = val; }
        public TimeInForce Get(TimeInForce val) { GetField(val); return val; }
        public bool IsSet(TimeInForce val) { return IsSetTimeInForce(); }
        public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }
    }

    public class NoExecInstRulesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ExecInstValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ExecInstValue, 0};

        public NoExecInstRulesGroup()
          : base(Tags.NoExecInstRules, Tags.ExecInstValue, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoExecInstRulesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ExecInstValue ExecInstValue
        {
            get
            {
                ExecInstValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExecInstValue val) { ExecInstValue = val; }
        public ExecInstValue Get(ExecInstValue val) { GetField(val); return val; }
        public bool IsSet(ExecInstValue val) { return IsSetExecInstValue(); }
        public bool IsSetExecInstValue() { return IsSetField(Tags.ExecInstValue); }
    }
}
