// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class BidRequest : Message
        {
            public const string MsgType = "k";

            public BidRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("k"));
            }

            public BidRequest(
                    QuickFix.Fields.ClientBidID aClientBidID,
                    QuickFix.Fields.BidRequestTransType aBidRequestTransType,
                    QuickFix.Fields.TotNoRelatedSym aTotNoRelatedSym,
                    QuickFix.Fields.BidType aBidType,
                    QuickFix.Fields.BidTradeType aBidTradeType,
                    QuickFix.Fields.BasisPxType aBasisPxType
                ) : this()
            {
                this.clientBidID = aClientBidID;
                this.bidRequestTransType = aBidRequestTransType;
                this.totNoRelatedSym = aTotNoRelatedSym;
                this.bidType = aBidType;
                this.bidTradeType = aBidTradeType;
                this.basisPxType = aBasisPxType;
            }

            public QuickFix.Fields.BidID bidID
            { 
                get 
                {
                    QuickFix.Fields.BidID val = new QuickFix.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidID val) 
            { 
                this.bidID = val;
            }
            
            public QuickFix.Fields.BidID Get(QuickFix.Fields.BidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidID val) 
            { 
                return IsSetBidID();
            }
            
            public bool IsSetBidID() 
            { 
                return IsSetField(Tags.BidID);
            }
            public QuickFix.Fields.ClientBidID clientBidID
            { 
                get 
                {
                    QuickFix.Fields.ClientBidID val = new QuickFix.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClientBidID val) 
            { 
                this.clientBidID = val;
            }
            
            public QuickFix.Fields.ClientBidID Get(QuickFix.Fields.ClientBidID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClientBidID val) 
            { 
                return IsSetClientBidID();
            }
            
            public bool IsSetClientBidID() 
            { 
                return IsSetField(Tags.ClientBidID);
            }
            public QuickFix.Fields.BidRequestTransType bidRequestTransType
            { 
                get 
                {
                    QuickFix.Fields.BidRequestTransType val = new QuickFix.Fields.BidRequestTransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidRequestTransType val) 
            { 
                this.bidRequestTransType = val;
            }
            
            public QuickFix.Fields.BidRequestTransType Get(QuickFix.Fields.BidRequestTransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidRequestTransType val) 
            { 
                return IsSetBidRequestTransType();
            }
            
            public bool IsSetBidRequestTransType() 
            { 
                return IsSetField(Tags.BidRequestTransType);
            }
            public QuickFix.Fields.ListName listName
            { 
                get 
                {
                    QuickFix.Fields.ListName val = new QuickFix.Fields.ListName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListName val) 
            { 
                this.listName = val;
            }
            
            public QuickFix.Fields.ListName Get(QuickFix.Fields.ListName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListName val) 
            { 
                return IsSetListName();
            }
            
            public bool IsSetListName() 
            { 
                return IsSetField(Tags.ListName);
            }
            public QuickFix.Fields.TotNoRelatedSym totNoRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.TotNoRelatedSym val = new QuickFix.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                this.totNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym Get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return IsSetTotNoRelatedSym();
            }
            
            public bool IsSetTotNoRelatedSym() 
            { 
                return IsSetField(Tags.TotNoRelatedSym);
            }
            public QuickFix.Fields.BidType bidType
            { 
                get 
                {
                    QuickFix.Fields.BidType val = new QuickFix.Fields.BidType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidType val) 
            { 
                this.bidType = val;
            }
            
            public QuickFix.Fields.BidType Get(QuickFix.Fields.BidType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidType val) 
            { 
                return IsSetBidType();
            }
            
            public bool IsSetBidType() 
            { 
                return IsSetField(Tags.BidType);
            }
            public QuickFix.Fields.NumTickets numTickets
            { 
                get 
                {
                    QuickFix.Fields.NumTickets val = new QuickFix.Fields.NumTickets();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumTickets val) 
            { 
                this.numTickets = val;
            }
            
            public QuickFix.Fields.NumTickets Get(QuickFix.Fields.NumTickets val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumTickets val) 
            { 
                return IsSetNumTickets();
            }
            
            public bool IsSetNumTickets() 
            { 
                return IsSetField(Tags.NumTickets);
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
            public QuickFix.Fields.SideValue1 sideValue1
            { 
                get 
                {
                    QuickFix.Fields.SideValue1 val = new QuickFix.Fields.SideValue1();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SideValue1 val) 
            { 
                this.sideValue1 = val;
            }
            
            public QuickFix.Fields.SideValue1 Get(QuickFix.Fields.SideValue1 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SideValue1 val) 
            { 
                return IsSetSideValue1();
            }
            
            public bool IsSetSideValue1() 
            { 
                return IsSetField(Tags.SideValue1);
            }
            public QuickFix.Fields.SideValue2 sideValue2
            { 
                get 
                {
                    QuickFix.Fields.SideValue2 val = new QuickFix.Fields.SideValue2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SideValue2 val) 
            { 
                this.sideValue2 = val;
            }
            
            public QuickFix.Fields.SideValue2 Get(QuickFix.Fields.SideValue2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SideValue2 val) 
            { 
                return IsSetSideValue2();
            }
            
            public bool IsSetSideValue2() 
            { 
                return IsSetField(Tags.SideValue2);
            }
            public QuickFix.Fields.NoBidDescriptors noBidDescriptors
            { 
                get 
                {
                    QuickFix.Fields.NoBidDescriptors val = new QuickFix.Fields.NoBidDescriptors();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoBidDescriptors val) 
            { 
                this.noBidDescriptors = val;
            }
            
            public QuickFix.Fields.NoBidDescriptors Get(QuickFix.Fields.NoBidDescriptors val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoBidDescriptors val) 
            { 
                return IsSetNoBidDescriptors();
            }
            
            public bool IsSetNoBidDescriptors() 
            { 
                return IsSetField(Tags.NoBidDescriptors);
            }
            public QuickFix.Fields.NoBidComponents noBidComponents
            { 
                get 
                {
                    QuickFix.Fields.NoBidComponents val = new QuickFix.Fields.NoBidComponents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoBidComponents val) 
            { 
                this.noBidComponents = val;
            }
            
            public QuickFix.Fields.NoBidComponents Get(QuickFix.Fields.NoBidComponents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoBidComponents val) 
            { 
                return IsSetNoBidComponents();
            }
            
            public bool IsSetNoBidComponents() 
            { 
                return IsSetField(Tags.NoBidComponents);
            }
            public QuickFix.Fields.LiquidityIndType liquidityIndType
            { 
                get 
                {
                    QuickFix.Fields.LiquidityIndType val = new QuickFix.Fields.LiquidityIndType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LiquidityIndType val) 
            { 
                this.liquidityIndType = val;
            }
            
            public QuickFix.Fields.LiquidityIndType Get(QuickFix.Fields.LiquidityIndType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LiquidityIndType val) 
            { 
                return IsSetLiquidityIndType();
            }
            
            public bool IsSetLiquidityIndType() 
            { 
                return IsSetField(Tags.LiquidityIndType);
            }
            public QuickFix.Fields.WtAverageLiquidity wtAverageLiquidity
            { 
                get 
                {
                    QuickFix.Fields.WtAverageLiquidity val = new QuickFix.Fields.WtAverageLiquidity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                this.wtAverageLiquidity = val;
            }
            
            public QuickFix.Fields.WtAverageLiquidity Get(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                return IsSetWtAverageLiquidity();
            }
            
            public bool IsSetWtAverageLiquidity() 
            { 
                return IsSetField(Tags.WtAverageLiquidity);
            }
            public QuickFix.Fields.ExchangeForPhysical exchangeForPhysical
            { 
                get 
                {
                    QuickFix.Fields.ExchangeForPhysical val = new QuickFix.Fields.ExchangeForPhysical();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                this.exchangeForPhysical = val;
            }
            
            public QuickFix.Fields.ExchangeForPhysical Get(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                return IsSetExchangeForPhysical();
            }
            
            public bool IsSetExchangeForPhysical() 
            { 
                return IsSetField(Tags.ExchangeForPhysical);
            }
            public QuickFix.Fields.OutMainCntryUIndex outMainCntryUIndex
            { 
                get 
                {
                    QuickFix.Fields.OutMainCntryUIndex val = new QuickFix.Fields.OutMainCntryUIndex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                this.outMainCntryUIndex = val;
            }
            
            public QuickFix.Fields.OutMainCntryUIndex Get(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                return IsSetOutMainCntryUIndex();
            }
            
            public bool IsSetOutMainCntryUIndex() 
            { 
                return IsSetField(Tags.OutMainCntryUIndex);
            }
            public QuickFix.Fields.CrossPercent crossPercent
            { 
                get 
                {
                    QuickFix.Fields.CrossPercent val = new QuickFix.Fields.CrossPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossPercent val) 
            { 
                this.crossPercent = val;
            }
            
            public QuickFix.Fields.CrossPercent Get(QuickFix.Fields.CrossPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossPercent val) 
            { 
                return IsSetCrossPercent();
            }
            
            public bool IsSetCrossPercent() 
            { 
                return IsSetField(Tags.CrossPercent);
            }
            public QuickFix.Fields.ProgRptReqs progRptReqs
            { 
                get 
                {
                    QuickFix.Fields.ProgRptReqs val = new QuickFix.Fields.ProgRptReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgRptReqs val) 
            { 
                this.progRptReqs = val;
            }
            
            public QuickFix.Fields.ProgRptReqs Get(QuickFix.Fields.ProgRptReqs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgRptReqs val) 
            { 
                return IsSetProgRptReqs();
            }
            
            public bool IsSetProgRptReqs() 
            { 
                return IsSetField(Tags.ProgRptReqs);
            }
            public QuickFix.Fields.ProgPeriodInterval progPeriodInterval
            { 
                get 
                {
                    QuickFix.Fields.ProgPeriodInterval val = new QuickFix.Fields.ProgPeriodInterval();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                this.progPeriodInterval = val;
            }
            
            public QuickFix.Fields.ProgPeriodInterval Get(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                return IsSetProgPeriodInterval();
            }
            
            public bool IsSetProgPeriodInterval() 
            { 
                return IsSetField(Tags.ProgPeriodInterval);
            }
            public QuickFix.Fields.IncTaxInd incTaxInd
            { 
                get 
                {
                    QuickFix.Fields.IncTaxInd val = new QuickFix.Fields.IncTaxInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IncTaxInd val) 
            { 
                this.incTaxInd = val;
            }
            
            public QuickFix.Fields.IncTaxInd Get(QuickFix.Fields.IncTaxInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IncTaxInd val) 
            { 
                return IsSetIncTaxInd();
            }
            
            public bool IsSetIncTaxInd() 
            { 
                return IsSetField(Tags.IncTaxInd);
            }
            public QuickFix.Fields.ForexReq forexReq
            { 
                get 
                {
                    QuickFix.Fields.ForexReq val = new QuickFix.Fields.ForexReq();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ForexReq val) 
            { 
                this.forexReq = val;
            }
            
            public QuickFix.Fields.ForexReq Get(QuickFix.Fields.ForexReq val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ForexReq val) 
            { 
                return IsSetForexReq();
            }
            
            public bool IsSetForexReq() 
            { 
                return IsSetField(Tags.ForexReq);
            }
            public QuickFix.Fields.NumBidders numBidders
            { 
                get 
                {
                    QuickFix.Fields.NumBidders val = new QuickFix.Fields.NumBidders();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumBidders val) 
            { 
                this.numBidders = val;
            }
            
            public QuickFix.Fields.NumBidders Get(QuickFix.Fields.NumBidders val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumBidders val) 
            { 
                return IsSetNumBidders();
            }
            
            public bool IsSetNumBidders() 
            { 
                return IsSetField(Tags.NumBidders);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.BidTradeType bidTradeType
            { 
                get 
                {
                    QuickFix.Fields.BidTradeType val = new QuickFix.Fields.BidTradeType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BidTradeType val) 
            { 
                this.bidTradeType = val;
            }
            
            public QuickFix.Fields.BidTradeType Get(QuickFix.Fields.BidTradeType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BidTradeType val) 
            { 
                return IsSetBidTradeType();
            }
            
            public bool IsSetBidTradeType() 
            { 
                return IsSetField(Tags.BidTradeType);
            }
            public QuickFix.Fields.BasisPxType basisPxType
            { 
                get 
                {
                    QuickFix.Fields.BasisPxType val = new QuickFix.Fields.BasisPxType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BasisPxType val) 
            { 
                this.basisPxType = val;
            }
            
            public QuickFix.Fields.BasisPxType Get(QuickFix.Fields.BasisPxType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BasisPxType val) 
            { 
                return IsSetBasisPxType();
            }
            
            public bool IsSetBasisPxType() 
            { 
                return IsSetField(Tags.BasisPxType);
            }
            public QuickFix.Fields.StrikeTime strikeTime
            { 
                get 
                {
                    QuickFix.Fields.StrikeTime val = new QuickFix.Fields.StrikeTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeTime val) 
            { 
                this.strikeTime = val;
            }
            
            public QuickFix.Fields.StrikeTime Get(QuickFix.Fields.StrikeTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeTime val) 
            { 
                return IsSetStrikeTime();
            }
            
            public bool IsSetStrikeTime() 
            { 
                return IsSetField(Tags.StrikeTime);
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
            public class NoBidDescriptors : Group
            {
                public NoBidDescriptors() 
                  :base( Tags.NoBidDescriptors, Tags.BidDescriptorType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.BidDescriptorType, Tags.BidDescriptor, Tags.SideValueInd, Tags.LiquidityValue, Tags.LiquidityNumSecurities, Tags.LiquidityPctLow, Tags.LiquidityPctHigh, Tags.EFPTrackingError, Tags.FairValue, Tags.OutsideIndexPct, Tags.ValueOfFutures, 0};
                            public QuickFix.Fields.BidDescriptorType bidDescriptorType
                { 
                    get 
                    {
                        QuickFix.Fields.BidDescriptorType val = new QuickFix.Fields.BidDescriptorType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BidDescriptorType val) 
                { 
                    this.bidDescriptorType = val;
                }
                
                public QuickFix.Fields.BidDescriptorType Get(QuickFix.Fields.BidDescriptorType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BidDescriptorType val) 
                { 
                    return IsSetBidDescriptorType();
                }
                
                public bool IsSetBidDescriptorType() 
                { 
                    return IsSetField(Tags.BidDescriptorType);
                }
                public QuickFix.Fields.BidDescriptor bidDescriptor
                { 
                    get 
                    {
                        QuickFix.Fields.BidDescriptor val = new QuickFix.Fields.BidDescriptor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BidDescriptor val) 
                { 
                    this.bidDescriptor = val;
                }
                
                public QuickFix.Fields.BidDescriptor Get(QuickFix.Fields.BidDescriptor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BidDescriptor val) 
                { 
                    return IsSetBidDescriptor();
                }
                
                public bool IsSetBidDescriptor() 
                { 
                    return IsSetField(Tags.BidDescriptor);
                }
                public QuickFix.Fields.SideValueInd sideValueInd
                { 
                    get 
                    {
                        QuickFix.Fields.SideValueInd val = new QuickFix.Fields.SideValueInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SideValueInd val) 
                { 
                    this.sideValueInd = val;
                }
                
                public QuickFix.Fields.SideValueInd Get(QuickFix.Fields.SideValueInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SideValueInd val) 
                { 
                    return IsSetSideValueInd();
                }
                
                public bool IsSetSideValueInd() 
                { 
                    return IsSetField(Tags.SideValueInd);
                }
                public QuickFix.Fields.LiquidityValue liquidityValue
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityValue val = new QuickFix.Fields.LiquidityValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityValue val) 
                { 
                    this.liquidityValue = val;
                }
                
                public QuickFix.Fields.LiquidityValue Get(QuickFix.Fields.LiquidityValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityValue val) 
                { 
                    return IsSetLiquidityValue();
                }
                
                public bool IsSetLiquidityValue() 
                { 
                    return IsSetField(Tags.LiquidityValue);
                }
                public QuickFix.Fields.LiquidityNumSecurities liquidityNumSecurities
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityNumSecurities val = new QuickFix.Fields.LiquidityNumSecurities();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    this.liquidityNumSecurities = val;
                }
                
                public QuickFix.Fields.LiquidityNumSecurities Get(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    return IsSetLiquidityNumSecurities();
                }
                
                public bool IsSetLiquidityNumSecurities() 
                { 
                    return IsSetField(Tags.LiquidityNumSecurities);
                }
                public QuickFix.Fields.LiquidityPctLow liquidityPctLow
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityPctLow val = new QuickFix.Fields.LiquidityPctLow();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    this.liquidityPctLow = val;
                }
                
                public QuickFix.Fields.LiquidityPctLow Get(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    return IsSetLiquidityPctLow();
                }
                
                public bool IsSetLiquidityPctLow() 
                { 
                    return IsSetField(Tags.LiquidityPctLow);
                }
                public QuickFix.Fields.LiquidityPctHigh liquidityPctHigh
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityPctHigh val = new QuickFix.Fields.LiquidityPctHigh();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    this.liquidityPctHigh = val;
                }
                
                public QuickFix.Fields.LiquidityPctHigh Get(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    return IsSetLiquidityPctHigh();
                }
                
                public bool IsSetLiquidityPctHigh() 
                { 
                    return IsSetField(Tags.LiquidityPctHigh);
                }
                public QuickFix.Fields.EFPTrackingError eFPTrackingError
                { 
                    get 
                    {
                        QuickFix.Fields.EFPTrackingError val = new QuickFix.Fields.EFPTrackingError();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EFPTrackingError val) 
                { 
                    this.eFPTrackingError = val;
                }
                
                public QuickFix.Fields.EFPTrackingError Get(QuickFix.Fields.EFPTrackingError val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EFPTrackingError val) 
                { 
                    return IsSetEFPTrackingError();
                }
                
                public bool IsSetEFPTrackingError() 
                { 
                    return IsSetField(Tags.EFPTrackingError);
                }
                public QuickFix.Fields.FairValue fairValue
                { 
                    get 
                    {
                        QuickFix.Fields.FairValue val = new QuickFix.Fields.FairValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FairValue val) 
                { 
                    this.fairValue = val;
                }
                
                public QuickFix.Fields.FairValue Get(QuickFix.Fields.FairValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FairValue val) 
                { 
                    return IsSetFairValue();
                }
                
                public bool IsSetFairValue() 
                { 
                    return IsSetField(Tags.FairValue);
                }
                public QuickFix.Fields.OutsideIndexPct outsideIndexPct
                { 
                    get 
                    {
                        QuickFix.Fields.OutsideIndexPct val = new QuickFix.Fields.OutsideIndexPct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    this.outsideIndexPct = val;
                }
                
                public QuickFix.Fields.OutsideIndexPct Get(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    return IsSetOutsideIndexPct();
                }
                
                public bool IsSetOutsideIndexPct() 
                { 
                    return IsSetField(Tags.OutsideIndexPct);
                }
                public QuickFix.Fields.ValueOfFutures valueOfFutures
                { 
                    get 
                    {
                        QuickFix.Fields.ValueOfFutures val = new QuickFix.Fields.ValueOfFutures();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ValueOfFutures val) 
                { 
                    this.valueOfFutures = val;
                }
                
                public QuickFix.Fields.ValueOfFutures Get(QuickFix.Fields.ValueOfFutures val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ValueOfFutures val) 
                { 
                    return IsSetValueOfFutures();
                }
                
                public bool IsSetValueOfFutures() 
                { 
                    return IsSetField(Tags.ValueOfFutures);
                }
            
            }
            public class NoBidComponents : Group
            {
                public NoBidComponents() 
                  :base( Tags.NoBidComponents, Tags.ListID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ListID, Tags.Side, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NetGrossInd, Tags.SettlType, Tags.SettlDate, Tags.Account, Tags.AcctIDSource, 0};
                            public QuickFix.Fields.ListID listID
                { 
                    get 
                    {
                        QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ListID val) 
                { 
                    this.listID = val;
                }
                
                public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ListID val) 
                { 
                    return IsSetListID();
                }
                
                public bool IsSetListID() 
                { 
                    return IsSetField(Tags.ListID);
                }
                public QuickFix.Fields.Side side
                { 
                    get 
                    {
                        QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Side val) 
                { 
                    this.side = val;
                }
                
                public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Side val) 
                { 
                    return IsSetSide();
                }
                
                public bool IsSetSide() 
                { 
                    return IsSetField(Tags.Side);
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
                public QuickFix.Fields.NetGrossInd netGrossInd
                { 
                    get 
                    {
                        QuickFix.Fields.NetGrossInd val = new QuickFix.Fields.NetGrossInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NetGrossInd val) 
                { 
                    this.netGrossInd = val;
                }
                
                public QuickFix.Fields.NetGrossInd Get(QuickFix.Fields.NetGrossInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NetGrossInd val) 
                { 
                    return IsSetNetGrossInd();
                }
                
                public bool IsSetNetGrossInd() 
                { 
                    return IsSetField(Tags.NetGrossInd);
                }
                public QuickFix.Fields.SettlType settlType
                { 
                    get 
                    {
                        QuickFix.Fields.SettlType val = new QuickFix.Fields.SettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlType val) 
                { 
                    this.settlType = val;
                }
                
                public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlType val) 
                { 
                    return IsSetSettlType();
                }
                
                public bool IsSetSettlType() 
                { 
                    return IsSetField(Tags.SettlType);
                }
                public QuickFix.Fields.SettlDate settlDate
                { 
                    get 
                    {
                        QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlDate val) 
                { 
                    this.settlDate = val;
                }
                
                public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlDate val) 
                { 
                    return IsSetSettlDate();
                }
                
                public bool IsSetSettlDate() 
                { 
                    return IsSetField(Tags.SettlDate);
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
                public QuickFix.Fields.AcctIDSource acctIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AcctIDSource val) 
                { 
                    this.acctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return IsSetAcctIDSource();
                }
                
                public bool IsSetAcctIDSource() 
                { 
                    return IsSetField(Tags.AcctIDSource);
                }
            
            }
        }
    }
}
