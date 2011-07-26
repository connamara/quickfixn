using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class BidRequest : Message
        {
            public BidRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("k"));
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
            public QuickFix.Fields.BidRequestTransType bidRequestTransType
            { 
                get 
                {
                    QuickFix.Fields.BidRequestTransType val = new QuickFix.Fields.BidRequestTransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BidRequestTransType val) 
            { 
                this.bidRequestTransType = val;
            }
            
            public QuickFix.Fields.BidRequestTransType get(QuickFix.Fields.BidRequestTransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BidRequestTransType val) 
            { 
                return isSetBidRequestTransType();
            }
            
            public bool isSetBidRequestTransType() 
            { 
                return isSetField(Tags.BidRequestTransType);
            }
            public QuickFix.Fields.ListName listName
            { 
                get 
                {
                    QuickFix.Fields.ListName val = new QuickFix.Fields.ListName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListName val) 
            { 
                this.listName = val;
            }
            
            public QuickFix.Fields.ListName get(QuickFix.Fields.ListName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListName val) 
            { 
                return isSetListName();
            }
            
            public bool isSetListName() 
            { 
                return isSetField(Tags.ListName);
            }
            public QuickFix.Fields.TotNoRelatedSym totNoRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.TotNoRelatedSym val = new QuickFix.Fields.TotNoRelatedSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                this.totNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return isSetTotNoRelatedSym();
            }
            
            public bool isSetTotNoRelatedSym() 
            { 
                return isSetField(Tags.TotNoRelatedSym);
            }
            public QuickFix.Fields.BidType bidType
            { 
                get 
                {
                    QuickFix.Fields.BidType val = new QuickFix.Fields.BidType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BidType val) 
            { 
                this.bidType = val;
            }
            
            public QuickFix.Fields.BidType get(QuickFix.Fields.BidType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BidType val) 
            { 
                return isSetBidType();
            }
            
            public bool isSetBidType() 
            { 
                return isSetField(Tags.BidType);
            }
            public QuickFix.Fields.NumTickets numTickets
            { 
                get 
                {
                    QuickFix.Fields.NumTickets val = new QuickFix.Fields.NumTickets();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NumTickets val) 
            { 
                this.numTickets = val;
            }
            
            public QuickFix.Fields.NumTickets get(QuickFix.Fields.NumTickets val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NumTickets val) 
            { 
                return isSetNumTickets();
            }
            
            public bool isSetNumTickets() 
            { 
                return isSetField(Tags.NumTickets);
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
            public QuickFix.Fields.SideValue1 sideValue1
            { 
                get 
                {
                    QuickFix.Fields.SideValue1 val = new QuickFix.Fields.SideValue1();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SideValue1 val) 
            { 
                this.sideValue1 = val;
            }
            
            public QuickFix.Fields.SideValue1 get(QuickFix.Fields.SideValue1 val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SideValue1 val) 
            { 
                return isSetSideValue1();
            }
            
            public bool isSetSideValue1() 
            { 
                return isSetField(Tags.SideValue1);
            }
            public QuickFix.Fields.SideValue2 sideValue2
            { 
                get 
                {
                    QuickFix.Fields.SideValue2 val = new QuickFix.Fields.SideValue2();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SideValue2 val) 
            { 
                this.sideValue2 = val;
            }
            
            public QuickFix.Fields.SideValue2 get(QuickFix.Fields.SideValue2 val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SideValue2 val) 
            { 
                return isSetSideValue2();
            }
            
            public bool isSetSideValue2() 
            { 
                return isSetField(Tags.SideValue2);
            }
            public QuickFix.Fields.NoBidDescriptors noBidDescriptors
            { 
                get 
                {
                    QuickFix.Fields.NoBidDescriptors val = new QuickFix.Fields.NoBidDescriptors();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoBidDescriptors val) 
            { 
                this.noBidDescriptors = val;
            }
            
            public QuickFix.Fields.NoBidDescriptors get(QuickFix.Fields.NoBidDescriptors val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoBidDescriptors val) 
            { 
                return isSetNoBidDescriptors();
            }
            
            public bool isSetNoBidDescriptors() 
            { 
                return isSetField(Tags.NoBidDescriptors);
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
            public QuickFix.Fields.LiquidityIndType liquidityIndType
            { 
                get 
                {
                    QuickFix.Fields.LiquidityIndType val = new QuickFix.Fields.LiquidityIndType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LiquidityIndType val) 
            { 
                this.liquidityIndType = val;
            }
            
            public QuickFix.Fields.LiquidityIndType get(QuickFix.Fields.LiquidityIndType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LiquidityIndType val) 
            { 
                return isSetLiquidityIndType();
            }
            
            public bool isSetLiquidityIndType() 
            { 
                return isSetField(Tags.LiquidityIndType);
            }
            public QuickFix.Fields.WtAverageLiquidity wtAverageLiquidity
            { 
                get 
                {
                    QuickFix.Fields.WtAverageLiquidity val = new QuickFix.Fields.WtAverageLiquidity();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                this.wtAverageLiquidity = val;
            }
            
            public QuickFix.Fields.WtAverageLiquidity get(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.WtAverageLiquidity val) 
            { 
                return isSetWtAverageLiquidity();
            }
            
            public bool isSetWtAverageLiquidity() 
            { 
                return isSetField(Tags.WtAverageLiquidity);
            }
            public QuickFix.Fields.ExchangeForPhysical exchangeForPhysical
            { 
                get 
                {
                    QuickFix.Fields.ExchangeForPhysical val = new QuickFix.Fields.ExchangeForPhysical();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                this.exchangeForPhysical = val;
            }
            
            public QuickFix.Fields.ExchangeForPhysical get(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExchangeForPhysical val) 
            { 
                return isSetExchangeForPhysical();
            }
            
            public bool isSetExchangeForPhysical() 
            { 
                return isSetField(Tags.ExchangeForPhysical);
            }
            public QuickFix.Fields.OutMainCntryUIndex outMainCntryUIndex
            { 
                get 
                {
                    QuickFix.Fields.OutMainCntryUIndex val = new QuickFix.Fields.OutMainCntryUIndex();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                this.outMainCntryUIndex = val;
            }
            
            public QuickFix.Fields.OutMainCntryUIndex get(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OutMainCntryUIndex val) 
            { 
                return isSetOutMainCntryUIndex();
            }
            
            public bool isSetOutMainCntryUIndex() 
            { 
                return isSetField(Tags.OutMainCntryUIndex);
            }
            public QuickFix.Fields.CrossPercent crossPercent
            { 
                get 
                {
                    QuickFix.Fields.CrossPercent val = new QuickFix.Fields.CrossPercent();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CrossPercent val) 
            { 
                this.crossPercent = val;
            }
            
            public QuickFix.Fields.CrossPercent get(QuickFix.Fields.CrossPercent val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CrossPercent val) 
            { 
                return isSetCrossPercent();
            }
            
            public bool isSetCrossPercent() 
            { 
                return isSetField(Tags.CrossPercent);
            }
            public QuickFix.Fields.ProgRptReqs progRptReqs
            { 
                get 
                {
                    QuickFix.Fields.ProgRptReqs val = new QuickFix.Fields.ProgRptReqs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ProgRptReqs val) 
            { 
                this.progRptReqs = val;
            }
            
            public QuickFix.Fields.ProgRptReqs get(QuickFix.Fields.ProgRptReqs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ProgRptReqs val) 
            { 
                return isSetProgRptReqs();
            }
            
            public bool isSetProgRptReqs() 
            { 
                return isSetField(Tags.ProgRptReqs);
            }
            public QuickFix.Fields.ProgPeriodInterval progPeriodInterval
            { 
                get 
                {
                    QuickFix.Fields.ProgPeriodInterval val = new QuickFix.Fields.ProgPeriodInterval();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                this.progPeriodInterval = val;
            }
            
            public QuickFix.Fields.ProgPeriodInterval get(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ProgPeriodInterval val) 
            { 
                return isSetProgPeriodInterval();
            }
            
            public bool isSetProgPeriodInterval() 
            { 
                return isSetField(Tags.ProgPeriodInterval);
            }
            public QuickFix.Fields.IncTaxInd incTaxInd
            { 
                get 
                {
                    QuickFix.Fields.IncTaxInd val = new QuickFix.Fields.IncTaxInd();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IncTaxInd val) 
            { 
                this.incTaxInd = val;
            }
            
            public QuickFix.Fields.IncTaxInd get(QuickFix.Fields.IncTaxInd val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IncTaxInd val) 
            { 
                return isSetIncTaxInd();
            }
            
            public bool isSetIncTaxInd() 
            { 
                return isSetField(Tags.IncTaxInd);
            }
            public QuickFix.Fields.ForexReq forexReq
            { 
                get 
                {
                    QuickFix.Fields.ForexReq val = new QuickFix.Fields.ForexReq();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ForexReq val) 
            { 
                this.forexReq = val;
            }
            
            public QuickFix.Fields.ForexReq get(QuickFix.Fields.ForexReq val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ForexReq val) 
            { 
                return isSetForexReq();
            }
            
            public bool isSetForexReq() 
            { 
                return isSetField(Tags.ForexReq);
            }
            public QuickFix.Fields.NumBidders numBidders
            { 
                get 
                {
                    QuickFix.Fields.NumBidders val = new QuickFix.Fields.NumBidders();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NumBidders val) 
            { 
                this.numBidders = val;
            }
            
            public QuickFix.Fields.NumBidders get(QuickFix.Fields.NumBidders val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NumBidders val) 
            { 
                return isSetNumBidders();
            }
            
            public bool isSetNumBidders() 
            { 
                return isSetField(Tags.NumBidders);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate get(QuickFix.Fields.TradeDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeDate val) 
            { 
                return isSetTradeDate();
            }
            
            public bool isSetTradeDate() 
            { 
                return isSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.BidTradeType bidTradeType
            { 
                get 
                {
                    QuickFix.Fields.BidTradeType val = new QuickFix.Fields.BidTradeType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BidTradeType val) 
            { 
                this.bidTradeType = val;
            }
            
            public QuickFix.Fields.BidTradeType get(QuickFix.Fields.BidTradeType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BidTradeType val) 
            { 
                return isSetBidTradeType();
            }
            
            public bool isSetBidTradeType() 
            { 
                return isSetField(Tags.BidTradeType);
            }
            public QuickFix.Fields.BasisPxType basisPxType
            { 
                get 
                {
                    QuickFix.Fields.BasisPxType val = new QuickFix.Fields.BasisPxType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BasisPxType val) 
            { 
                this.basisPxType = val;
            }
            
            public QuickFix.Fields.BasisPxType get(QuickFix.Fields.BasisPxType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BasisPxType val) 
            { 
                return isSetBasisPxType();
            }
            
            public bool isSetBasisPxType() 
            { 
                return isSetField(Tags.BasisPxType);
            }
            public QuickFix.Fields.StrikeTime strikeTime
            { 
                get 
                {
                    QuickFix.Fields.StrikeTime val = new QuickFix.Fields.StrikeTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StrikeTime val) 
            { 
                this.strikeTime = val;
            }
            
            public QuickFix.Fields.StrikeTime get(QuickFix.Fields.StrikeTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StrikeTime val) 
            { 
                return isSetStrikeTime();
            }
            
            public bool isSetStrikeTime() 
            { 
                return isSetField(Tags.StrikeTime);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BidDescriptorType val) 
                { 
                    this.bidDescriptorType = val;
                }
                
                public QuickFix.Fields.BidDescriptorType get(QuickFix.Fields.BidDescriptorType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BidDescriptorType val) 
                { 
                    return isSetBidDescriptorType();
                }
                
                public bool isSetBidDescriptorType() 
                { 
                    return isSetField(Tags.BidDescriptorType);
                }
                public QuickFix.Fields.BidDescriptor bidDescriptor
                { 
                    get 
                    {
                        QuickFix.Fields.BidDescriptor val = new QuickFix.Fields.BidDescriptor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BidDescriptor val) 
                { 
                    this.bidDescriptor = val;
                }
                
                public QuickFix.Fields.BidDescriptor get(QuickFix.Fields.BidDescriptor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BidDescriptor val) 
                { 
                    return isSetBidDescriptor();
                }
                
                public bool isSetBidDescriptor() 
                { 
                    return isSetField(Tags.BidDescriptor);
                }
                public QuickFix.Fields.SideValueInd sideValueInd
                { 
                    get 
                    {
                        QuickFix.Fields.SideValueInd val = new QuickFix.Fields.SideValueInd();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SideValueInd val) 
                { 
                    this.sideValueInd = val;
                }
                
                public QuickFix.Fields.SideValueInd get(QuickFix.Fields.SideValueInd val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SideValueInd val) 
                { 
                    return isSetSideValueInd();
                }
                
                public bool isSetSideValueInd() 
                { 
                    return isSetField(Tags.SideValueInd);
                }
                public QuickFix.Fields.LiquidityValue liquidityValue
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityValue val = new QuickFix.Fields.LiquidityValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LiquidityValue val) 
                { 
                    this.liquidityValue = val;
                }
                
                public QuickFix.Fields.LiquidityValue get(QuickFix.Fields.LiquidityValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LiquidityValue val) 
                { 
                    return isSetLiquidityValue();
                }
                
                public bool isSetLiquidityValue() 
                { 
                    return isSetField(Tags.LiquidityValue);
                }
                public QuickFix.Fields.LiquidityNumSecurities liquidityNumSecurities
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityNumSecurities val = new QuickFix.Fields.LiquidityNumSecurities();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    this.liquidityNumSecurities = val;
                }
                
                public QuickFix.Fields.LiquidityNumSecurities get(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LiquidityNumSecurities val) 
                { 
                    return isSetLiquidityNumSecurities();
                }
                
                public bool isSetLiquidityNumSecurities() 
                { 
                    return isSetField(Tags.LiquidityNumSecurities);
                }
                public QuickFix.Fields.LiquidityPctLow liquidityPctLow
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityPctLow val = new QuickFix.Fields.LiquidityPctLow();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    this.liquidityPctLow = val;
                }
                
                public QuickFix.Fields.LiquidityPctLow get(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LiquidityPctLow val) 
                { 
                    return isSetLiquidityPctLow();
                }
                
                public bool isSetLiquidityPctLow() 
                { 
                    return isSetField(Tags.LiquidityPctLow);
                }
                public QuickFix.Fields.LiquidityPctHigh liquidityPctHigh
                { 
                    get 
                    {
                        QuickFix.Fields.LiquidityPctHigh val = new QuickFix.Fields.LiquidityPctHigh();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    this.liquidityPctHigh = val;
                }
                
                public QuickFix.Fields.LiquidityPctHigh get(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LiquidityPctHigh val) 
                { 
                    return isSetLiquidityPctHigh();
                }
                
                public bool isSetLiquidityPctHigh() 
                { 
                    return isSetField(Tags.LiquidityPctHigh);
                }
                public QuickFix.Fields.EFPTrackingError eFPTrackingError
                { 
                    get 
                    {
                        QuickFix.Fields.EFPTrackingError val = new QuickFix.Fields.EFPTrackingError();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EFPTrackingError val) 
                { 
                    this.eFPTrackingError = val;
                }
                
                public QuickFix.Fields.EFPTrackingError get(QuickFix.Fields.EFPTrackingError val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EFPTrackingError val) 
                { 
                    return isSetEFPTrackingError();
                }
                
                public bool isSetEFPTrackingError() 
                { 
                    return isSetField(Tags.EFPTrackingError);
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
                public QuickFix.Fields.OutsideIndexPct outsideIndexPct
                { 
                    get 
                    {
                        QuickFix.Fields.OutsideIndexPct val = new QuickFix.Fields.OutsideIndexPct();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    this.outsideIndexPct = val;
                }
                
                public QuickFix.Fields.OutsideIndexPct get(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OutsideIndexPct val) 
                { 
                    return isSetOutsideIndexPct();
                }
                
                public bool isSetOutsideIndexPct() 
                { 
                    return isSetField(Tags.OutsideIndexPct);
                }
                public QuickFix.Fields.ValueOfFutures valueOfFutures
                { 
                    get 
                    {
                        QuickFix.Fields.ValueOfFutures val = new QuickFix.Fields.ValueOfFutures();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ValueOfFutures val) 
                { 
                    this.valueOfFutures = val;
                }
                
                public QuickFix.Fields.ValueOfFutures get(QuickFix.Fields.ValueOfFutures val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ValueOfFutures val) 
                { 
                    return isSetValueOfFutures();
                }
                
                public bool isSetValueOfFutures() 
                { 
                    return isSetField(Tags.ValueOfFutures);
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
                public QuickFix.Fields.Account account
                { 
                    get 
                    {
                        QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Account val) 
                { 
                    this.account = val;
                }
                
                public QuickFix.Fields.Account get(QuickFix.Fields.Account val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Account val) 
                { 
                    return isSetAccount();
                }
                
                public bool isSetAccount() 
                { 
                    return isSetField(Tags.Account);
                }
                public QuickFix.Fields.AcctIDSource acctIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AcctIDSource val) 
                { 
                    this.acctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource get(QuickFix.Fields.AcctIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return isSetAcctIDSource();
                }
                
                public bool isSetAcctIDSource() 
                { 
                    return isSetField(Tags.AcctIDSource);
                }
            
            }
        }
    }
}
