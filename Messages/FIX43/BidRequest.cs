// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class BidRequest : Message
{
    public const string MsgType = "k";

    public BidRequest() : base()
    {
        Header.SetField(new MsgType("k"));
    }

    public BidRequest(
            ClientBidID aClientBidID,
            BidRequestTransType aBidRequestTransType,
            TotalNumSecurities aTotalNumSecurities,
            BidType aBidType,
            TradeType aTradeType,
            BasisPxType aBasisPxType
        ) : this()
    {
        ClientBidID = aClientBidID;
        BidRequestTransType = aBidRequestTransType;
        TotalNumSecurities = aTotalNumSecurities;
        BidType = aBidType;
        TradeType = aTradeType;
        BasisPxType = aBasisPxType;
    }

    public BidID BidID
    {
        get
        {
            BidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidID val) { BidID = val; }
    public BidID Get(BidID val) { GetField(val); return val; }
    public bool IsSet(BidID val) { return IsSetBidID(); }
    public bool IsSetBidID() { return IsSetField(Tags.BidID); }

    public ClientBidID ClientBidID
    {
        get
        {
            ClientBidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientBidID val) { ClientBidID = val; }
    public ClientBidID Get(ClientBidID val) { GetField(val); return val; }
    public bool IsSet(ClientBidID val) { return IsSetClientBidID(); }
    public bool IsSetClientBidID() { return IsSetField(Tags.ClientBidID); }

    public BidRequestTransType BidRequestTransType
    {
        get
        {
            BidRequestTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidRequestTransType val) { BidRequestTransType = val; }
    public BidRequestTransType Get(BidRequestTransType val) { GetField(val); return val; }
    public bool IsSet(BidRequestTransType val) { return IsSetBidRequestTransType(); }
    public bool IsSetBidRequestTransType() { return IsSetField(Tags.BidRequestTransType); }

    public ListName ListName
    {
        get
        {
            ListName val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListName val) { ListName = val; }
    public ListName Get(ListName val) { GetField(val); return val; }
    public bool IsSet(ListName val) { return IsSetListName(); }
    public bool IsSetListName() { return IsSetField(Tags.ListName); }

    public TotalNumSecurities TotalNumSecurities
    {
        get
        {
            TotalNumSecurities val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotalNumSecurities val) { TotalNumSecurities = val; }
    public TotalNumSecurities Get(TotalNumSecurities val) { GetField(val); return val; }
    public bool IsSet(TotalNumSecurities val) { return IsSetTotalNumSecurities(); }
    public bool IsSetTotalNumSecurities() { return IsSetField(Tags.TotalNumSecurities); }

    public BidType BidType
    {
        get
        {
            BidType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidType val) { BidType = val; }
    public BidType Get(BidType val) { GetField(val); return val; }
    public bool IsSet(BidType val) { return IsSetBidType(); }
    public bool IsSetBidType() { return IsSetField(Tags.BidType); }

    public NumTickets NumTickets
    {
        get
        {
            NumTickets val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NumTickets val) { NumTickets = val; }
    public NumTickets Get(NumTickets val) { GetField(val); return val; }
    public bool IsSet(NumTickets val) { return IsSetNumTickets(); }
    public bool IsSetNumTickets() { return IsSetField(Tags.NumTickets); }

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

    public SideValue1 SideValue1
    {
        get
        {
            SideValue1 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SideValue1 val) { SideValue1 = val; }
    public SideValue1 Get(SideValue1 val) { GetField(val); return val; }
    public bool IsSet(SideValue1 val) { return IsSetSideValue1(); }
    public bool IsSetSideValue1() { return IsSetField(Tags.SideValue1); }

    public SideValue2 SideValue2
    {
        get
        {
            SideValue2 val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SideValue2 val) { SideValue2 = val; }
    public SideValue2 Get(SideValue2 val) { GetField(val); return val; }
    public bool IsSet(SideValue2 val) { return IsSetSideValue2(); }
    public bool IsSetSideValue2() { return IsSetField(Tags.SideValue2); }

    public NoBidDescriptors NoBidDescriptors
    {
        get
        {
            NoBidDescriptors val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoBidDescriptors val) { NoBidDescriptors = val; }
    public NoBidDescriptors Get(NoBidDescriptors val) { GetField(val); return val; }
    public bool IsSet(NoBidDescriptors val) { return IsSetNoBidDescriptors(); }
    public bool IsSetNoBidDescriptors() { return IsSetField(Tags.NoBidDescriptors); }

    public NoBidComponents NoBidComponents
    {
        get
        {
            NoBidComponents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoBidComponents val) { NoBidComponents = val; }
    public NoBidComponents Get(NoBidComponents val) { GetField(val); return val; }
    public bool IsSet(NoBidComponents val) { return IsSetNoBidComponents(); }
    public bool IsSetNoBidComponents() { return IsSetField(Tags.NoBidComponents); }

    public LiquidityIndType LiquidityIndType
    {
        get
        {
            LiquidityIndType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LiquidityIndType val) { LiquidityIndType = val; }
    public LiquidityIndType Get(LiquidityIndType val) { GetField(val); return val; }
    public bool IsSet(LiquidityIndType val) { return IsSetLiquidityIndType(); }
    public bool IsSetLiquidityIndType() { return IsSetField(Tags.LiquidityIndType); }

    public WtAverageLiquidity WtAverageLiquidity
    {
        get
        {
            WtAverageLiquidity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WtAverageLiquidity val) { WtAverageLiquidity = val; }
    public WtAverageLiquidity Get(WtAverageLiquidity val) { GetField(val); return val; }
    public bool IsSet(WtAverageLiquidity val) { return IsSetWtAverageLiquidity(); }
    public bool IsSetWtAverageLiquidity() { return IsSetField(Tags.WtAverageLiquidity); }

    public ExchangeForPhysical ExchangeForPhysical
    {
        get
        {
            ExchangeForPhysical val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ExchangeForPhysical val) { ExchangeForPhysical = val; }
    public ExchangeForPhysical Get(ExchangeForPhysical val) { GetField(val); return val; }
    public bool IsSet(ExchangeForPhysical val) { return IsSetExchangeForPhysical(); }
    public bool IsSetExchangeForPhysical() { return IsSetField(Tags.ExchangeForPhysical); }

    public OutMainCntryUIndex OutMainCntryUIndex
    {
        get
        {
            OutMainCntryUIndex val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OutMainCntryUIndex val) { OutMainCntryUIndex = val; }
    public OutMainCntryUIndex Get(OutMainCntryUIndex val) { GetField(val); return val; }
    public bool IsSet(OutMainCntryUIndex val) { return IsSetOutMainCntryUIndex(); }
    public bool IsSetOutMainCntryUIndex() { return IsSetField(Tags.OutMainCntryUIndex); }

    public CrossPercent CrossPercent
    {
        get
        {
            CrossPercent val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CrossPercent val) { CrossPercent = val; }
    public CrossPercent Get(CrossPercent val) { GetField(val); return val; }
    public bool IsSet(CrossPercent val) { return IsSetCrossPercent(); }
    public bool IsSetCrossPercent() { return IsSetField(Tags.CrossPercent); }

    public ProgRptReqs ProgRptReqs
    {
        get
        {
            ProgRptReqs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProgRptReqs val) { ProgRptReqs = val; }
    public ProgRptReqs Get(ProgRptReqs val) { GetField(val); return val; }
    public bool IsSet(ProgRptReqs val) { return IsSetProgRptReqs(); }
    public bool IsSetProgRptReqs() { return IsSetField(Tags.ProgRptReqs); }

    public ProgPeriodInterval ProgPeriodInterval
    {
        get
        {
            ProgPeriodInterval val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ProgPeriodInterval val) { ProgPeriodInterval = val; }
    public ProgPeriodInterval Get(ProgPeriodInterval val) { GetField(val); return val; }
    public bool IsSet(ProgPeriodInterval val) { return IsSetProgPeriodInterval(); }
    public bool IsSetProgPeriodInterval() { return IsSetField(Tags.ProgPeriodInterval); }

    public IncTaxInd IncTaxInd
    {
        get
        {
            IncTaxInd val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IncTaxInd val) { IncTaxInd = val; }
    public IncTaxInd Get(IncTaxInd val) { GetField(val); return val; }
    public bool IsSet(IncTaxInd val) { return IsSetIncTaxInd(); }
    public bool IsSetIncTaxInd() { return IsSetField(Tags.IncTaxInd); }

    public ForexReq ForexReq
    {
        get
        {
            ForexReq val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ForexReq val) { ForexReq = val; }
    public ForexReq Get(ForexReq val) { GetField(val); return val; }
    public bool IsSet(ForexReq val) { return IsSetForexReq(); }
    public bool IsSetForexReq() { return IsSetField(Tags.ForexReq); }

    public NumBidders NumBidders
    {
        get
        {
            NumBidders val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NumBidders val) { NumBidders = val; }
    public NumBidders Get(NumBidders val) { GetField(val); return val; }
    public bool IsSet(NumBidders val) { return IsSetNumBidders(); }
    public bool IsSetNumBidders() { return IsSetField(Tags.NumBidders); }

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

    public TradeType TradeType
    {
        get
        {
            TradeType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeType val) { TradeType = val; }
    public TradeType Get(TradeType val) { GetField(val); return val; }
    public bool IsSet(TradeType val) { return IsSetTradeType(); }
    public bool IsSetTradeType() { return IsSetField(Tags.TradeType); }

    public BasisPxType BasisPxType
    {
        get
        {
            BasisPxType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BasisPxType val) { BasisPxType = val; }
    public BasisPxType Get(BasisPxType val) { GetField(val); return val; }
    public bool IsSet(BasisPxType val) { return IsSetBasisPxType(); }
    public bool IsSetBasisPxType() { return IsSetField(Tags.BasisPxType); }

    public StrikeTime StrikeTime
    {
        get
        {
            StrikeTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StrikeTime val) { StrikeTime = val; }
    public StrikeTime Get(StrikeTime val) { GetField(val); return val; }
    public bool IsSet(StrikeTime val) { return IsSetStrikeTime(); }
    public bool IsSetStrikeTime() { return IsSetField(Tags.StrikeTime); }

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

    public class NoBidDescriptorsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.BidDescriptorType, Tags.BidDescriptor, Tags.SideValueInd, Tags.LiquidityValue, Tags.LiquidityNumSecurities, Tags.LiquidityPctLow, Tags.LiquidityPctHigh, Tags.EFPTrackingError, Tags.FairValue, Tags.OutsideIndexPct, Tags.ValueOfFutures, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.BidDescriptorType, Tags.BidDescriptor, Tags.SideValueInd, Tags.LiquidityValue, Tags.LiquidityNumSecurities, Tags.LiquidityPctLow, Tags.LiquidityPctHigh, Tags.EFPTrackingError, Tags.FairValue, Tags.OutsideIndexPct, Tags.ValueOfFutures, 0};

        public NoBidDescriptorsGroup()
          : base(Tags.NoBidDescriptors, Tags.BidDescriptorType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoBidDescriptorsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public BidDescriptorType BidDescriptorType
        {
            get
            {
                BidDescriptorType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(BidDescriptorType val) { BidDescriptorType = val; }
        public BidDescriptorType Get(BidDescriptorType val) { GetField(val); return val; }
        public bool IsSet(BidDescriptorType val) { return IsSetBidDescriptorType(); }
        public bool IsSetBidDescriptorType() { return IsSetField(Tags.BidDescriptorType); }

        public BidDescriptor BidDescriptor
        {
            get
            {
                BidDescriptor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(BidDescriptor val) { BidDescriptor = val; }
        public BidDescriptor Get(BidDescriptor val) { GetField(val); return val; }
        public bool IsSet(BidDescriptor val) { return IsSetBidDescriptor(); }
        public bool IsSetBidDescriptor() { return IsSetField(Tags.BidDescriptor); }

        public SideValueInd SideValueInd
        {
            get
            {
                SideValueInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SideValueInd val) { SideValueInd = val; }
        public SideValueInd Get(SideValueInd val) { GetField(val); return val; }
        public bool IsSet(SideValueInd val) { return IsSetSideValueInd(); }
        public bool IsSetSideValueInd() { return IsSetField(Tags.SideValueInd); }

        public LiquidityValue LiquidityValue
        {
            get
            {
                LiquidityValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LiquidityValue val) { LiquidityValue = val; }
        public LiquidityValue Get(LiquidityValue val) { GetField(val); return val; }
        public bool IsSet(LiquidityValue val) { return IsSetLiquidityValue(); }
        public bool IsSetLiquidityValue() { return IsSetField(Tags.LiquidityValue); }

        public LiquidityNumSecurities LiquidityNumSecurities
        {
            get
            {
                LiquidityNumSecurities val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LiquidityNumSecurities val) { LiquidityNumSecurities = val; }
        public LiquidityNumSecurities Get(LiquidityNumSecurities val) { GetField(val); return val; }
        public bool IsSet(LiquidityNumSecurities val) { return IsSetLiquidityNumSecurities(); }
        public bool IsSetLiquidityNumSecurities() { return IsSetField(Tags.LiquidityNumSecurities); }

        public LiquidityPctLow LiquidityPctLow
        {
            get
            {
                LiquidityPctLow val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LiquidityPctLow val) { LiquidityPctLow = val; }
        public LiquidityPctLow Get(LiquidityPctLow val) { GetField(val); return val; }
        public bool IsSet(LiquidityPctLow val) { return IsSetLiquidityPctLow(); }
        public bool IsSetLiquidityPctLow() { return IsSetField(Tags.LiquidityPctLow); }

        public LiquidityPctHigh LiquidityPctHigh
        {
            get
            {
                LiquidityPctHigh val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LiquidityPctHigh val) { LiquidityPctHigh = val; }
        public LiquidityPctHigh Get(LiquidityPctHigh val) { GetField(val); return val; }
        public bool IsSet(LiquidityPctHigh val) { return IsSetLiquidityPctHigh(); }
        public bool IsSetLiquidityPctHigh() { return IsSetField(Tags.LiquidityPctHigh); }

        public EFPTrackingError EFPTrackingError
        {
            get
            {
                EFPTrackingError val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EFPTrackingError val) { EFPTrackingError = val; }
        public EFPTrackingError Get(EFPTrackingError val) { GetField(val); return val; }
        public bool IsSet(EFPTrackingError val) { return IsSetEFPTrackingError(); }
        public bool IsSetEFPTrackingError() { return IsSetField(Tags.EFPTrackingError); }

        public FairValue FairValue
        {
            get
            {
                FairValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FairValue val) { FairValue = val; }
        public FairValue Get(FairValue val) { GetField(val); return val; }
        public bool IsSet(FairValue val) { return IsSetFairValue(); }
        public bool IsSetFairValue() { return IsSetField(Tags.FairValue); }

        public OutsideIndexPct OutsideIndexPct
        {
            get
            {
                OutsideIndexPct val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OutsideIndexPct val) { OutsideIndexPct = val; }
        public OutsideIndexPct Get(OutsideIndexPct val) { GetField(val); return val; }
        public bool IsSet(OutsideIndexPct val) { return IsSetOutsideIndexPct(); }
        public bool IsSetOutsideIndexPct() { return IsSetField(Tags.OutsideIndexPct); }

        public ValueOfFutures ValueOfFutures
        {
            get
            {
                ValueOfFutures val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ValueOfFutures val) { ValueOfFutures = val; }
        public ValueOfFutures Get(ValueOfFutures val) { GetField(val); return val; }
        public bool IsSet(ValueOfFutures val) { return IsSetValueOfFutures(); }
        public bool IsSetValueOfFutures() { return IsSetField(Tags.ValueOfFutures); }
    }

    public class NoBidComponentsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.ListID, Tags.Side, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NetGrossInd, Tags.SettlmntTyp, Tags.FutSettDate, Tags.Account, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.ListID, Tags.Side, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NetGrossInd, Tags.SettlmntTyp, Tags.FutSettDate, Tags.Account, 0};

        public NoBidComponentsGroup()
          : base(Tags.NoBidComponents, Tags.ListID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoBidComponentsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public ListID ListID
        {
            get
            {
                ListID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ListID val) { ListID = val; }
        public ListID Get(ListID val) { GetField(val); return val; }
        public bool IsSet(ListID val) { return IsSetListID(); }
        public bool IsSetListID() { return IsSetField(Tags.ListID); }

        public Side Side
        {
            get
            {
                Side val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Side val) { Side = val; }
        public Side Get(Side val) { GetField(val); return val; }
        public bool IsSet(Side val) { return IsSetSide(); }
        public bool IsSetSide() { return IsSetField(Tags.Side); }

        public TradingSessionID TradingSessionID
        {
            get
            {
                TradingSessionID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionID val) { TradingSessionID = val; }
        public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

        public TradingSessionSubID TradingSessionSubID
        {
            get
            {
                TradingSessionSubID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
        public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
        public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

        public NetGrossInd NetGrossInd
        {
            get
            {
                NetGrossInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NetGrossInd val) { NetGrossInd = val; }
        public NetGrossInd Get(NetGrossInd val) { GetField(val); return val; }
        public bool IsSet(NetGrossInd val) { return IsSetNetGrossInd(); }
        public bool IsSetNetGrossInd() { return IsSetField(Tags.NetGrossInd); }

        public SettlmntTyp SettlmntTyp
        {
            get
            {
                SettlmntTyp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlmntTyp val) { SettlmntTyp = val; }
        public SettlmntTyp Get(SettlmntTyp val) { GetField(val); return val; }
        public bool IsSet(SettlmntTyp val) { return IsSetSettlmntTyp(); }
        public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

        public FutSettDate FutSettDate
        {
            get
            {
                FutSettDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FutSettDate val) { FutSettDate = val; }
        public FutSettDate Get(FutSettDate val) { GetField(val); return val; }
        public bool IsSet(FutSettDate val) { return IsSetFutSettDate(); }
        public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

        public Account Account
        {
            get
            {
                Account val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Account val) { Account = val; }
        public Account Get(Account val) { GetField(val); return val; }
        public bool IsSet(Account val) { return IsSetAccount(); }
        public bool IsSetAccount() { return IsSetField(Tags.Account); }
    }
}
