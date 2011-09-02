// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class NewOrderList : Message
        {
            public const string MsgType = "E";

            public NewOrderList() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("E"));
            }

            public NewOrderList(
                    QuickFix.Fields.ListID aListID,
                    QuickFix.Fields.BidType aBidType,
                    QuickFix.Fields.TotNoOrders aTotNoOrders
                ) : this()
            {
                this.listID = aListID;
                this.bidType = aBidType;
                this.totNoOrders = aTotNoOrders;
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
            public QuickFix.Fields.CancellationRights cancellationRights
            { 
                get 
                {
                    QuickFix.Fields.CancellationRights val = new QuickFix.Fields.CancellationRights();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CancellationRights val) 
            { 
                this.cancellationRights = val;
            }
            
            public QuickFix.Fields.CancellationRights get(QuickFix.Fields.CancellationRights val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CancellationRights val) 
            { 
                return isSetCancellationRights();
            }
            
            public bool isSetCancellationRights() 
            { 
                return isSetField(Tags.CancellationRights);
            }
            public QuickFix.Fields.MoneyLaunderingStatus moneyLaunderingStatus
            { 
                get 
                {
                    QuickFix.Fields.MoneyLaunderingStatus val = new QuickFix.Fields.MoneyLaunderingStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                this.moneyLaunderingStatus = val;
            }
            
            public QuickFix.Fields.MoneyLaunderingStatus get(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                return isSetMoneyLaunderingStatus();
            }
            
            public bool isSetMoneyLaunderingStatus() 
            { 
                return isSetField(Tags.MoneyLaunderingStatus);
            }
            public QuickFix.Fields.RegistID registID
            { 
                get 
                {
                    QuickFix.Fields.RegistID val = new QuickFix.Fields.RegistID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RegistID val) 
            { 
                this.registID = val;
            }
            
            public QuickFix.Fields.RegistID get(QuickFix.Fields.RegistID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RegistID val) 
            { 
                return isSetRegistID();
            }
            
            public bool isSetRegistID() 
            { 
                return isSetField(Tags.RegistID);
            }
            public QuickFix.Fields.ListExecInstType listExecInstType
            { 
                get 
                {
                    QuickFix.Fields.ListExecInstType val = new QuickFix.Fields.ListExecInstType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListExecInstType val) 
            { 
                this.listExecInstType = val;
            }
            
            public QuickFix.Fields.ListExecInstType get(QuickFix.Fields.ListExecInstType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListExecInstType val) 
            { 
                return isSetListExecInstType();
            }
            
            public bool isSetListExecInstType() 
            { 
                return isSetField(Tags.ListExecInstType);
            }
            public QuickFix.Fields.ListExecInst listExecInst
            { 
                get 
                {
                    QuickFix.Fields.ListExecInst val = new QuickFix.Fields.ListExecInst();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ListExecInst val) 
            { 
                this.listExecInst = val;
            }
            
            public QuickFix.Fields.ListExecInst get(QuickFix.Fields.ListExecInst val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ListExecInst val) 
            { 
                return isSetListExecInst();
            }
            
            public bool isSetListExecInst() 
            { 
                return isSetField(Tags.ListExecInst);
            }
            public QuickFix.Fields.EncodedListExecInstLen encodedListExecInstLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedListExecInstLen val = new QuickFix.Fields.EncodedListExecInstLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                this.encodedListExecInstLen = val;
            }
            
            public QuickFix.Fields.EncodedListExecInstLen get(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedListExecInstLen val) 
            { 
                return isSetEncodedListExecInstLen();
            }
            
            public bool isSetEncodedListExecInstLen() 
            { 
                return isSetField(Tags.EncodedListExecInstLen);
            }
            public QuickFix.Fields.EncodedListExecInst encodedListExecInst
            { 
                get 
                {
                    QuickFix.Fields.EncodedListExecInst val = new QuickFix.Fields.EncodedListExecInst();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedListExecInst val) 
            { 
                this.encodedListExecInst = val;
            }
            
            public QuickFix.Fields.EncodedListExecInst get(QuickFix.Fields.EncodedListExecInst val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedListExecInst val) 
            { 
                return isSetEncodedListExecInst();
            }
            
            public bool isSetEncodedListExecInst() 
            { 
                return isSetField(Tags.EncodedListExecInst);
            }
            public QuickFix.Fields.AllowableOneSidednessPct allowableOneSidednessPct
            { 
                get 
                {
                    QuickFix.Fields.AllowableOneSidednessPct val = new QuickFix.Fields.AllowableOneSidednessPct();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllowableOneSidednessPct val) 
            { 
                this.allowableOneSidednessPct = val;
            }
            
            public QuickFix.Fields.AllowableOneSidednessPct get(QuickFix.Fields.AllowableOneSidednessPct val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllowableOneSidednessPct val) 
            { 
                return isSetAllowableOneSidednessPct();
            }
            
            public bool isSetAllowableOneSidednessPct() 
            { 
                return isSetField(Tags.AllowableOneSidednessPct);
            }
            public QuickFix.Fields.AllowableOneSidednessValue allowableOneSidednessValue
            { 
                get 
                {
                    QuickFix.Fields.AllowableOneSidednessValue val = new QuickFix.Fields.AllowableOneSidednessValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllowableOneSidednessValue val) 
            { 
                this.allowableOneSidednessValue = val;
            }
            
            public QuickFix.Fields.AllowableOneSidednessValue get(QuickFix.Fields.AllowableOneSidednessValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllowableOneSidednessValue val) 
            { 
                return isSetAllowableOneSidednessValue();
            }
            
            public bool isSetAllowableOneSidednessValue() 
            { 
                return isSetField(Tags.AllowableOneSidednessValue);
            }
            public QuickFix.Fields.AllowableOneSidednessCurr allowableOneSidednessCurr
            { 
                get 
                {
                    QuickFix.Fields.AllowableOneSidednessCurr val = new QuickFix.Fields.AllowableOneSidednessCurr();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllowableOneSidednessCurr val) 
            { 
                this.allowableOneSidednessCurr = val;
            }
            
            public QuickFix.Fields.AllowableOneSidednessCurr get(QuickFix.Fields.AllowableOneSidednessCurr val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllowableOneSidednessCurr val) 
            { 
                return isSetAllowableOneSidednessCurr();
            }
            
            public bool isSetAllowableOneSidednessCurr() 
            { 
                return isSetField(Tags.AllowableOneSidednessCurr);
            }
            public QuickFix.Fields.TotNoOrders totNoOrders
            { 
                get 
                {
                    QuickFix.Fields.TotNoOrders val = new QuickFix.Fields.TotNoOrders();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotNoOrders val) 
            { 
                this.totNoOrders = val;
            }
            
            public QuickFix.Fields.TotNoOrders get(QuickFix.Fields.TotNoOrders val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotNoOrders val) 
            { 
                return isSetTotNoOrders();
            }
            
            public bool isSetTotNoOrders() 
            { 
                return isSetField(Tags.TotNoOrders);
            }
            public QuickFix.Fields.LastFragment lastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastFragment val) 
            { 
                this.lastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment get(QuickFix.Fields.LastFragment val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastFragment val) 
            { 
                return isSetLastFragment();
            }
            
            public bool isSetLastFragment() 
            { 
                return isSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoOrders noOrders
            { 
                get 
                {
                    QuickFix.Fields.NoOrders val = new QuickFix.Fields.NoOrders();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoOrders val) 
            { 
                this.noOrders = val;
            }
            
            public QuickFix.Fields.NoOrders get(QuickFix.Fields.NoOrders val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoOrders val) 
            { 
                return isSetNoOrders();
            }
            
            public bool isSetNoOrders() 
            { 
                return isSetField(Tags.NoOrders);
            }
            public QuickFix.Fields.NoRootPartyIDs noRootPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoRootPartyIDs val = new QuickFix.Fields.NoRootPartyIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                this.noRootPartyIDs = val;
            }
            
            public QuickFix.Fields.NoRootPartyIDs get(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                return isSetNoRootPartyIDs();
            }
            
            public bool isSetNoRootPartyIDs() 
            { 
                return isSetField(Tags.NoRootPartyIDs);
            }
            public QuickFix.Fields.ContingencyType contingencyType
            { 
                get 
                {
                    QuickFix.Fields.ContingencyType val = new QuickFix.Fields.ContingencyType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ContingencyType val) 
            { 
                this.contingencyType = val;
            }
            
            public QuickFix.Fields.ContingencyType get(QuickFix.Fields.ContingencyType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ContingencyType val) 
            { 
                return isSetContingencyType();
            }
            
            public bool isSetContingencyType() 
            { 
                return isSetField(Tags.ContingencyType);
            }
            public class NoOrders : Group
            {
                public NoOrders() 
                  :base( Tags.NoOrders, Tags.ClOrdID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ClOrdID, Tags.SecondaryClOrdID, Tags.ListSeqNo, Tags.ClOrdLinkID, Tags.SettlInstMode, Tags.NoPartyIDs, Tags.TradeOriginationDate, Tags.TradeDate, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.DayBookingInst, Tags.BookingUnit, Tags.AllocID, Tags.PreallocMethod, Tags.NoAllocs, Tags.SettlType, Tags.SettlDate, Tags.CashMargin, Tags.ClearingFeeIndicator, Tags.HandlInst, Tags.ExecInst, Tags.MinQty, Tags.MaxFloor, Tags.ExDestination, Tags.NoTradingSessions, Tags.ProcessCode, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayoutAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.ValuationMethod, Tags.ContractMultiplierUnit, Tags.FlowScheduleType, Tags.RestructuringType, Tags.Seniority, Tags.NotionalPercentageOutstanding, Tags.OriginalNotionalPercentageOutstanding, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.StrikePriceDeterminationMethod, Tags.StrikePriceBoundaryMethod, Tags.StrikePriceBoundaryPrecision, Tags.UnderlyingPriceDeterminationMethod, Tags.OptPayoutType, Tags.NoComplexEvents, Tags.NoUnderlyings, Tags.PrevClosePx, Tags.Side, Tags.SideValueInd, Tags.LocateReqd, Tags.TransactTime, Tags.NoStipulations, Tags.QtyType, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.OrdType, Tags.PriceType, Tags.Price, Tags.StopPx, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.BenchmarkPrice, Tags.BenchmarkPriceType, Tags.BenchmarkSecurityID, Tags.BenchmarkSecurityIDSource, Tags.YieldType, Tags.Yield, Tags.YieldCalcDate, Tags.YieldRedemptionDate, Tags.YieldRedemptionPrice, Tags.YieldRedemptionPriceType, Tags.Currency, Tags.ComplianceID, Tags.SolicitedFlag, Tags.IOIID, Tags.QuoteID, Tags.TimeInForce, Tags.EffectiveTime, Tags.ExpireDate, Tags.ExpireTime, Tags.GTBookingInst, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.OrderCapacity, Tags.OrderRestrictions, Tags.CustOrderCapacity, Tags.ForexReq, Tags.SettlCurrency, Tags.BookingType, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SettlDate2, Tags.OrderQty2, Tags.Price2, Tags.PositionEffect, Tags.CoveredOrUncovered, Tags.MaxShow, Tags.PegOffsetValue, Tags.PegMoveType, Tags.PegOffsetType, Tags.PegLimitType, Tags.PegRoundDirection, Tags.PegScope, Tags.PegPriceType, Tags.PegSecurityIDSource, Tags.PegSecurityID, Tags.PegSymbol, Tags.PegSecurityDesc, Tags.DiscretionInst, Tags.DiscretionOffsetValue, Tags.DiscretionMoveType, Tags.DiscretionOffsetType, Tags.DiscretionLimitType, Tags.DiscretionRoundDirection, Tags.DiscretionScope, Tags.TargetStrategy, Tags.TargetStrategyParameters, Tags.ParticipationRate, Tags.Designation, Tags.NoStrategyParameters, Tags.MatchIncrement, Tags.MaxPriceLevels, Tags.SecondaryDisplayQty, Tags.DisplayWhen, Tags.DisplayMethod, Tags.DisplayLowQty, Tags.DisplayHighQty, Tags.DisplayMinIncr, Tags.RefreshQty, Tags.DisplayQty, Tags.PriceProtectionScope, Tags.TriggerType, Tags.TriggerAction, Tags.TriggerPrice, Tags.TriggerSymbol, Tags.TriggerSecurityID, Tags.TriggerSecurityIDSource, Tags.TriggerSecurityDesc, Tags.TriggerPriceType, Tags.TriggerPriceTypeScope, Tags.TriggerPriceDirection, Tags.TriggerNewPrice, Tags.TriggerOrderType, Tags.TriggerNewQty, Tags.TriggerTradingSessionID, Tags.TriggerTradingSessionSubID, Tags.RefOrderID, Tags.RefOrderIDSource, Tags.PreTradeAnonymity, Tags.ExDestinationIDSource, 0};
                            public QuickFix.Fields.ClOrdID clOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClOrdID val) 
                { 
                    this.clOrdID = val;
                }
                
                public QuickFix.Fields.ClOrdID get(QuickFix.Fields.ClOrdID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClOrdID val) 
                { 
                    return isSetClOrdID();
                }
                
                public bool isSetClOrdID() 
                { 
                    return isSetField(Tags.ClOrdID);
                }
                public QuickFix.Fields.SecondaryClOrdID secondaryClOrdID
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    this.secondaryClOrdID = val;
                }
                
                public QuickFix.Fields.SecondaryClOrdID get(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryClOrdID val) 
                { 
                    return isSetSecondaryClOrdID();
                }
                
                public bool isSetSecondaryClOrdID() 
                { 
                    return isSetField(Tags.SecondaryClOrdID);
                }
                public QuickFix.Fields.ListSeqNo listSeqNo
                { 
                    get 
                    {
                        QuickFix.Fields.ListSeqNo val = new QuickFix.Fields.ListSeqNo();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListSeqNo val) 
                { 
                    this.listSeqNo = val;
                }
                
                public QuickFix.Fields.ListSeqNo get(QuickFix.Fields.ListSeqNo val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListSeqNo val) 
                { 
                    return isSetListSeqNo();
                }
                
                public bool isSetListSeqNo() 
                { 
                    return isSetField(Tags.ListSeqNo);
                }
                public QuickFix.Fields.ClOrdLinkID clOrdLinkID
                { 
                    get 
                    {
                        QuickFix.Fields.ClOrdLinkID val = new QuickFix.Fields.ClOrdLinkID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClOrdLinkID val) 
                { 
                    this.clOrdLinkID = val;
                }
                
                public QuickFix.Fields.ClOrdLinkID get(QuickFix.Fields.ClOrdLinkID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClOrdLinkID val) 
                { 
                    return isSetClOrdLinkID();
                }
                
                public bool isSetClOrdLinkID() 
                { 
                    return isSetField(Tags.ClOrdLinkID);
                }
                public QuickFix.Fields.SettlInstMode settlInstMode
                { 
                    get 
                    {
                        QuickFix.Fields.SettlInstMode val = new QuickFix.Fields.SettlInstMode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlInstMode val) 
                { 
                    this.settlInstMode = val;
                }
                
                public QuickFix.Fields.SettlInstMode get(QuickFix.Fields.SettlInstMode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlInstMode val) 
                { 
                    return isSetSettlInstMode();
                }
                
                public bool isSetSettlInstMode() 
                { 
                    return isSetField(Tags.SettlInstMode);
                }
                public QuickFix.Fields.NoPartyIDs noPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoPartyIDs val) 
                { 
                    this.noPartyIDs = val;
                }
                
                public QuickFix.Fields.NoPartyIDs get(QuickFix.Fields.NoPartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoPartyIDs val) 
                { 
                    return isSetNoPartyIDs();
                }
                
                public bool isSetNoPartyIDs() 
                { 
                    return isSetField(Tags.NoPartyIDs);
                }
                public QuickFix.Fields.TradeOriginationDate tradeOriginationDate
                { 
                    get 
                    {
                        QuickFix.Fields.TradeOriginationDate val = new QuickFix.Fields.TradeOriginationDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    this.tradeOriginationDate = val;
                }
                
                public QuickFix.Fields.TradeOriginationDate get(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    return isSetTradeOriginationDate();
                }
                
                public bool isSetTradeOriginationDate() 
                { 
                    return isSetField(Tags.TradeOriginationDate);
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
                public QuickFix.Fields.AccountType accountType
                { 
                    get 
                    {
                        QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AccountType val) 
                { 
                    this.accountType = val;
                }
                
                public QuickFix.Fields.AccountType get(QuickFix.Fields.AccountType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AccountType val) 
                { 
                    return isSetAccountType();
                }
                
                public bool isSetAccountType() 
                { 
                    return isSetField(Tags.AccountType);
                }
                public QuickFix.Fields.DayBookingInst dayBookingInst
                { 
                    get 
                    {
                        QuickFix.Fields.DayBookingInst val = new QuickFix.Fields.DayBookingInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DayBookingInst val) 
                { 
                    this.dayBookingInst = val;
                }
                
                public QuickFix.Fields.DayBookingInst get(QuickFix.Fields.DayBookingInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DayBookingInst val) 
                { 
                    return isSetDayBookingInst();
                }
                
                public bool isSetDayBookingInst() 
                { 
                    return isSetField(Tags.DayBookingInst);
                }
                public QuickFix.Fields.BookingUnit bookingUnit
                { 
                    get 
                    {
                        QuickFix.Fields.BookingUnit val = new QuickFix.Fields.BookingUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BookingUnit val) 
                { 
                    this.bookingUnit = val;
                }
                
                public QuickFix.Fields.BookingUnit get(QuickFix.Fields.BookingUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BookingUnit val) 
                { 
                    return isSetBookingUnit();
                }
                
                public bool isSetBookingUnit() 
                { 
                    return isSetField(Tags.BookingUnit);
                }
                public QuickFix.Fields.AllocID allocID
                { 
                    get 
                    {
                        QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AllocID val) 
                { 
                    this.allocID = val;
                }
                
                public QuickFix.Fields.AllocID get(QuickFix.Fields.AllocID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AllocID val) 
                { 
                    return isSetAllocID();
                }
                
                public bool isSetAllocID() 
                { 
                    return isSetField(Tags.AllocID);
                }
                public QuickFix.Fields.PreallocMethod preallocMethod
                { 
                    get 
                    {
                        QuickFix.Fields.PreallocMethod val = new QuickFix.Fields.PreallocMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PreallocMethod val) 
                { 
                    this.preallocMethod = val;
                }
                
                public QuickFix.Fields.PreallocMethod get(QuickFix.Fields.PreallocMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PreallocMethod val) 
                { 
                    return isSetPreallocMethod();
                }
                
                public bool isSetPreallocMethod() 
                { 
                    return isSetField(Tags.PreallocMethod);
                }
                public QuickFix.Fields.NoAllocs noAllocs
                { 
                    get 
                    {
                        QuickFix.Fields.NoAllocs val = new QuickFix.Fields.NoAllocs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoAllocs val) 
                { 
                    this.noAllocs = val;
                }
                
                public QuickFix.Fields.NoAllocs get(QuickFix.Fields.NoAllocs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoAllocs val) 
                { 
                    return isSetNoAllocs();
                }
                
                public bool isSetNoAllocs() 
                { 
                    return isSetField(Tags.NoAllocs);
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
                public QuickFix.Fields.CashMargin cashMargin
                { 
                    get 
                    {
                        QuickFix.Fields.CashMargin val = new QuickFix.Fields.CashMargin();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashMargin val) 
                { 
                    this.cashMargin = val;
                }
                
                public QuickFix.Fields.CashMargin get(QuickFix.Fields.CashMargin val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashMargin val) 
                { 
                    return isSetCashMargin();
                }
                
                public bool isSetCashMargin() 
                { 
                    return isSetField(Tags.CashMargin);
                }
                public QuickFix.Fields.ClearingFeeIndicator clearingFeeIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.ClearingFeeIndicator val = new QuickFix.Fields.ClearingFeeIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    this.clearingFeeIndicator = val;
                }
                
                public QuickFix.Fields.ClearingFeeIndicator get(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ClearingFeeIndicator val) 
                { 
                    return isSetClearingFeeIndicator();
                }
                
                public bool isSetClearingFeeIndicator() 
                { 
                    return isSetField(Tags.ClearingFeeIndicator);
                }
                public QuickFix.Fields.HandlInst handlInst
                { 
                    get 
                    {
                        QuickFix.Fields.HandlInst val = new QuickFix.Fields.HandlInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.HandlInst val) 
                { 
                    this.handlInst = val;
                }
                
                public QuickFix.Fields.HandlInst get(QuickFix.Fields.HandlInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.HandlInst val) 
                { 
                    return isSetHandlInst();
                }
                
                public bool isSetHandlInst() 
                { 
                    return isSetField(Tags.HandlInst);
                }
                public QuickFix.Fields.ExecInst execInst
                { 
                    get 
                    {
                        QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExecInst val) 
                { 
                    this.execInst = val;
                }
                
                public QuickFix.Fields.ExecInst get(QuickFix.Fields.ExecInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExecInst val) 
                { 
                    return isSetExecInst();
                }
                
                public bool isSetExecInst() 
                { 
                    return isSetField(Tags.ExecInst);
                }
                public QuickFix.Fields.MinQty minQty
                { 
                    get 
                    {
                        QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinQty val) 
                { 
                    this.minQty = val;
                }
                
                public QuickFix.Fields.MinQty get(QuickFix.Fields.MinQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinQty val) 
                { 
                    return isSetMinQty();
                }
                
                public bool isSetMinQty() 
                { 
                    return isSetField(Tags.MinQty);
                }
                public QuickFix.Fields.MaxFloor maxFloor
                { 
                    get 
                    {
                        QuickFix.Fields.MaxFloor val = new QuickFix.Fields.MaxFloor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaxFloor val) 
                { 
                    this.maxFloor = val;
                }
                
                public QuickFix.Fields.MaxFloor get(QuickFix.Fields.MaxFloor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaxFloor val) 
                { 
                    return isSetMaxFloor();
                }
                
                public bool isSetMaxFloor() 
                { 
                    return isSetField(Tags.MaxFloor);
                }
                public QuickFix.Fields.ExDestination exDestination
                { 
                    get 
                    {
                        QuickFix.Fields.ExDestination val = new QuickFix.Fields.ExDestination();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExDestination val) 
                { 
                    this.exDestination = val;
                }
                
                public QuickFix.Fields.ExDestination get(QuickFix.Fields.ExDestination val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExDestination val) 
                { 
                    return isSetExDestination();
                }
                
                public bool isSetExDestination() 
                { 
                    return isSetField(Tags.ExDestination);
                }
                public QuickFix.Fields.NoTradingSessions noTradingSessions
                { 
                    get 
                    {
                        QuickFix.Fields.NoTradingSessions val = new QuickFix.Fields.NoTradingSessions();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoTradingSessions val) 
                { 
                    this.noTradingSessions = val;
                }
                
                public QuickFix.Fields.NoTradingSessions get(QuickFix.Fields.NoTradingSessions val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoTradingSessions val) 
                { 
                    return isSetNoTradingSessions();
                }
                
                public bool isSetNoTradingSessions() 
                { 
                    return isSetField(Tags.NoTradingSessions);
                }
                public QuickFix.Fields.ProcessCode processCode
                { 
                    get 
                    {
                        QuickFix.Fields.ProcessCode val = new QuickFix.Fields.ProcessCode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ProcessCode val) 
                { 
                    this.processCode = val;
                }
                
                public QuickFix.Fields.ProcessCode get(QuickFix.Fields.ProcessCode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ProcessCode val) 
                { 
                    return isSetProcessCode();
                }
                
                public bool isSetProcessCode() 
                { 
                    return isSetField(Tags.ProcessCode);
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
                public QuickFix.Fields.SecurityIDSource securityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityIDSource val) 
                { 
                    this.securityIDSource = val;
                }
                
                public QuickFix.Fields.SecurityIDSource get(QuickFix.Fields.SecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityIDSource val) 
                { 
                    return isSetSecurityIDSource();
                }
                
                public bool isSetSecurityIDSource() 
                { 
                    return isSetField(Tags.SecurityIDSource);
                }
                public QuickFix.Fields.NoSecurityAltID noSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoSecurityAltID val) 
                { 
                    this.noSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoSecurityAltID get(QuickFix.Fields.NoSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoSecurityAltID val) 
                { 
                    return isSetNoSecurityAltID();
                }
                
                public bool isSetNoSecurityAltID() 
                { 
                    return isSetField(Tags.NoSecurityAltID);
                }
                public QuickFix.Fields.Product product
                { 
                    get 
                    {
                        QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Product val) 
                { 
                    this.product = val;
                }
                
                public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Product val) 
                { 
                    return isSetProduct();
                }
                
                public bool isSetProduct() 
                { 
                    return isSetField(Tags.Product);
                }
                public QuickFix.Fields.CFICode cFICode
                { 
                    get 
                    {
                        QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CFICode val) 
                { 
                    this.cFICode = val;
                }
                
                public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CFICode val) 
                { 
                    return isSetCFICode();
                }
                
                public bool isSetCFICode() 
                { 
                    return isSetField(Tags.CFICode);
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
                public QuickFix.Fields.SecuritySubType securitySubType
                { 
                    get 
                    {
                        QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecuritySubType val) 
                { 
                    this.securitySubType = val;
                }
                
                public QuickFix.Fields.SecuritySubType get(QuickFix.Fields.SecuritySubType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecuritySubType val) 
                { 
                    return isSetSecuritySubType();
                }
                
                public bool isSetSecuritySubType() 
                { 
                    return isSetField(Tags.SecuritySubType);
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
                public QuickFix.Fields.MaturityDate maturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityDate val) 
                { 
                    this.maturityDate = val;
                }
                
                public QuickFix.Fields.MaturityDate get(QuickFix.Fields.MaturityDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityDate val) 
                { 
                    return isSetMaturityDate();
                }
                
                public bool isSetMaturityDate() 
                { 
                    return isSetField(Tags.MaturityDate);
                }
                public QuickFix.Fields.CouponPaymentDate couponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CouponPaymentDate val) 
                { 
                    this.couponPaymentDate = val;
                }
                
                public QuickFix.Fields.CouponPaymentDate get(QuickFix.Fields.CouponPaymentDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CouponPaymentDate val) 
                { 
                    return isSetCouponPaymentDate();
                }
                
                public bool isSetCouponPaymentDate() 
                { 
                    return isSetField(Tags.CouponPaymentDate);
                }
                public QuickFix.Fields.IssueDate issueDate
                { 
                    get 
                    {
                        QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.IssueDate val) 
                { 
                    this.issueDate = val;
                }
                
                public QuickFix.Fields.IssueDate get(QuickFix.Fields.IssueDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.IssueDate val) 
                { 
                    return isSetIssueDate();
                }
                
                public bool isSetIssueDate() 
                { 
                    return isSetField(Tags.IssueDate);
                }
                public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RepoCollateralSecurityType val) 
                { 
                    this.repoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.RepoCollateralSecurityType get(QuickFix.Fields.RepoCollateralSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RepoCollateralSecurityType val) 
                { 
                    return isSetRepoCollateralSecurityType();
                }
                
                public bool isSetRepoCollateralSecurityType() 
                { 
                    return isSetField(Tags.RepoCollateralSecurityType);
                }
                public QuickFix.Fields.RepurchaseTerm repurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RepurchaseTerm val) 
                { 
                    this.repurchaseTerm = val;
                }
                
                public QuickFix.Fields.RepurchaseTerm get(QuickFix.Fields.RepurchaseTerm val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RepurchaseTerm val) 
                { 
                    return isSetRepurchaseTerm();
                }
                
                public bool isSetRepurchaseTerm() 
                { 
                    return isSetField(Tags.RepurchaseTerm);
                }
                public QuickFix.Fields.RepurchaseRate repurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RepurchaseRate val) 
                { 
                    this.repurchaseRate = val;
                }
                
                public QuickFix.Fields.RepurchaseRate get(QuickFix.Fields.RepurchaseRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RepurchaseRate val) 
                { 
                    return isSetRepurchaseRate();
                }
                
                public bool isSetRepurchaseRate() 
                { 
                    return isSetField(Tags.RepurchaseRate);
                }
                public QuickFix.Fields.Factor factor
                { 
                    get 
                    {
                        QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Factor val) 
                { 
                    this.factor = val;
                }
                
                public QuickFix.Fields.Factor get(QuickFix.Fields.Factor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Factor val) 
                { 
                    return isSetFactor();
                }
                
                public bool isSetFactor() 
                { 
                    return isSetField(Tags.Factor);
                }
                public QuickFix.Fields.CreditRating creditRating
                { 
                    get 
                    {
                        QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CreditRating val) 
                { 
                    this.creditRating = val;
                }
                
                public QuickFix.Fields.CreditRating get(QuickFix.Fields.CreditRating val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CreditRating val) 
                { 
                    return isSetCreditRating();
                }
                
                public bool isSetCreditRating() 
                { 
                    return isSetField(Tags.CreditRating);
                }
                public QuickFix.Fields.InstrRegistry instrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrRegistry val) 
                { 
                    this.instrRegistry = val;
                }
                
                public QuickFix.Fields.InstrRegistry get(QuickFix.Fields.InstrRegistry val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrRegistry val) 
                { 
                    return isSetInstrRegistry();
                }
                
                public bool isSetInstrRegistry() 
                { 
                    return isSetField(Tags.InstrRegistry);
                }
                public QuickFix.Fields.CountryOfIssue countryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CountryOfIssue val) 
                { 
                    this.countryOfIssue = val;
                }
                
                public QuickFix.Fields.CountryOfIssue get(QuickFix.Fields.CountryOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CountryOfIssue val) 
                { 
                    return isSetCountryOfIssue();
                }
                
                public bool isSetCountryOfIssue() 
                { 
                    return isSetField(Tags.CountryOfIssue);
                }
                public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StateOrProvinceOfIssue val) 
                { 
                    this.stateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.StateOrProvinceOfIssue get(QuickFix.Fields.StateOrProvinceOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
                { 
                    return isSetStateOrProvinceOfIssue();
                }
                
                public bool isSetStateOrProvinceOfIssue() 
                { 
                    return isSetField(Tags.StateOrProvinceOfIssue);
                }
                public QuickFix.Fields.LocaleOfIssue localeOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LocaleOfIssue val) 
                { 
                    this.localeOfIssue = val;
                }
                
                public QuickFix.Fields.LocaleOfIssue get(QuickFix.Fields.LocaleOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LocaleOfIssue val) 
                { 
                    return isSetLocaleOfIssue();
                }
                
                public bool isSetLocaleOfIssue() 
                { 
                    return isSetField(Tags.LocaleOfIssue);
                }
                public QuickFix.Fields.RedemptionDate redemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RedemptionDate val) 
                { 
                    this.redemptionDate = val;
                }
                
                public QuickFix.Fields.RedemptionDate get(QuickFix.Fields.RedemptionDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RedemptionDate val) 
                { 
                    return isSetRedemptionDate();
                }
                
                public bool isSetRedemptionDate() 
                { 
                    return isSetField(Tags.RedemptionDate);
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
                public QuickFix.Fields.StrikeCurrency strikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeCurrency val) 
                { 
                    this.strikeCurrency = val;
                }
                
                public QuickFix.Fields.StrikeCurrency get(QuickFix.Fields.StrikeCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeCurrency val) 
                { 
                    return isSetStrikeCurrency();
                }
                
                public bool isSetStrikeCurrency() 
                { 
                    return isSetField(Tags.StrikeCurrency);
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
                public QuickFix.Fields.Pool pool
                { 
                    get 
                    {
                        QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Pool val) 
                { 
                    this.pool = val;
                }
                
                public QuickFix.Fields.Pool get(QuickFix.Fields.Pool val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Pool val) 
                { 
                    return isSetPool();
                }
                
                public bool isSetPool() 
                { 
                    return isSetField(Tags.Pool);
                }
                public QuickFix.Fields.ContractSettlMonth contractSettlMonth
                { 
                    get 
                    {
                        QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    this.contractSettlMonth = val;
                }
                
                public QuickFix.Fields.ContractSettlMonth get(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    return isSetContractSettlMonth();
                }
                
                public bool isSetContractSettlMonth() 
                { 
                    return isSetField(Tags.ContractSettlMonth);
                }
                public QuickFix.Fields.CPProgram cPProgram
                { 
                    get 
                    {
                        QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CPProgram val) 
                { 
                    this.cPProgram = val;
                }
                
                public QuickFix.Fields.CPProgram get(QuickFix.Fields.CPProgram val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CPProgram val) 
                { 
                    return isSetCPProgram();
                }
                
                public bool isSetCPProgram() 
                { 
                    return isSetField(Tags.CPProgram);
                }
                public QuickFix.Fields.CPRegType cPRegType
                { 
                    get 
                    {
                        QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CPRegType val) 
                { 
                    this.cPRegType = val;
                }
                
                public QuickFix.Fields.CPRegType get(QuickFix.Fields.CPRegType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CPRegType val) 
                { 
                    return isSetCPRegType();
                }
                
                public bool isSetCPRegType() 
                { 
                    return isSetField(Tags.CPRegType);
                }
                public QuickFix.Fields.NoEvents noEvents
                { 
                    get 
                    {
                        QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoEvents val) 
                { 
                    this.noEvents = val;
                }
                
                public QuickFix.Fields.NoEvents get(QuickFix.Fields.NoEvents val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoEvents val) 
                { 
                    return isSetNoEvents();
                }
                
                public bool isSetNoEvents() 
                { 
                    return isSetField(Tags.NoEvents);
                }
                public QuickFix.Fields.DatedDate datedDate
                { 
                    get 
                    {
                        QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DatedDate val) 
                { 
                    this.datedDate = val;
                }
                
                public QuickFix.Fields.DatedDate get(QuickFix.Fields.DatedDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DatedDate val) 
                { 
                    return isSetDatedDate();
                }
                
                public bool isSetDatedDate() 
                { 
                    return isSetField(Tags.DatedDate);
                }
                public QuickFix.Fields.InterestAccrualDate interestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    this.interestAccrualDate = val;
                }
                
                public QuickFix.Fields.InterestAccrualDate get(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    return isSetInterestAccrualDate();
                }
                
                public bool isSetInterestAccrualDate() 
                { 
                    return isSetField(Tags.InterestAccrualDate);
                }
                public QuickFix.Fields.SecurityStatus securityStatus
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityStatus val) 
                { 
                    this.securityStatus = val;
                }
                
                public QuickFix.Fields.SecurityStatus get(QuickFix.Fields.SecurityStatus val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityStatus val) 
                { 
                    return isSetSecurityStatus();
                }
                
                public bool isSetSecurityStatus() 
                { 
                    return isSetField(Tags.SecurityStatus);
                }
                public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
                { 
                    get 
                    {
                        QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    this.settleOnOpenFlag = val;
                }
                
                public QuickFix.Fields.SettleOnOpenFlag get(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    return isSetSettleOnOpenFlag();
                }
                
                public bool isSetSettleOnOpenFlag() 
                { 
                    return isSetField(Tags.SettleOnOpenFlag);
                }
                public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
                { 
                    get 
                    {
                        QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    this.instrmtAssignmentMethod = val;
                }
                
                public QuickFix.Fields.InstrmtAssignmentMethod get(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    return isSetInstrmtAssignmentMethod();
                }
                
                public bool isSetInstrmtAssignmentMethod() 
                { 
                    return isSetField(Tags.InstrmtAssignmentMethod);
                }
                public QuickFix.Fields.StrikeMultiplier strikeMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    this.strikeMultiplier = val;
                }
                
                public QuickFix.Fields.StrikeMultiplier get(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    return isSetStrikeMultiplier();
                }
                
                public bool isSetStrikeMultiplier() 
                { 
                    return isSetField(Tags.StrikeMultiplier);
                }
                public QuickFix.Fields.StrikeValue strikeValue
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeValue val) 
                { 
                    this.strikeValue = val;
                }
                
                public QuickFix.Fields.StrikeValue get(QuickFix.Fields.StrikeValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeValue val) 
                { 
                    return isSetStrikeValue();
                }
                
                public bool isSetStrikeValue() 
                { 
                    return isSetField(Tags.StrikeValue);
                }
                public QuickFix.Fields.MinPriceIncrement minPriceIncrement
                { 
                    get 
                    {
                        QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    this.minPriceIncrement = val;
                }
                
                public QuickFix.Fields.MinPriceIncrement get(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    return isSetMinPriceIncrement();
                }
                
                public bool isSetMinPriceIncrement() 
                { 
                    return isSetField(Tags.MinPriceIncrement);
                }
                public QuickFix.Fields.PositionLimit positionLimit
                { 
                    get 
                    {
                        QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PositionLimit val) 
                { 
                    this.positionLimit = val;
                }
                
                public QuickFix.Fields.PositionLimit get(QuickFix.Fields.PositionLimit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PositionLimit val) 
                { 
                    return isSetPositionLimit();
                }
                
                public bool isSetPositionLimit() 
                { 
                    return isSetField(Tags.PositionLimit);
                }
                public QuickFix.Fields.NTPositionLimit nTPositionLimit
                { 
                    get 
                    {
                        QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NTPositionLimit val) 
                { 
                    this.nTPositionLimit = val;
                }
                
                public QuickFix.Fields.NTPositionLimit get(QuickFix.Fields.NTPositionLimit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NTPositionLimit val) 
                { 
                    return isSetNTPositionLimit();
                }
                
                public bool isSetNTPositionLimit() 
                { 
                    return isSetField(Tags.NTPositionLimit);
                }
                public QuickFix.Fields.NoInstrumentParties noInstrumentParties
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    this.noInstrumentParties = val;
                }
                
                public QuickFix.Fields.NoInstrumentParties get(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    return isSetNoInstrumentParties();
                }
                
                public bool isSetNoInstrumentParties() 
                { 
                    return isSetField(Tags.NoInstrumentParties);
                }
                public QuickFix.Fields.UnitOfMeasure unitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    this.unitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnitOfMeasure get(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    return isSetUnitOfMeasure();
                }
                
                public bool isSetUnitOfMeasure() 
                { 
                    return isSetField(Tags.UnitOfMeasure);
                }
                public QuickFix.Fields.TimeUnit timeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TimeUnit val) 
                { 
                    this.timeUnit = val;
                }
                
                public QuickFix.Fields.TimeUnit get(QuickFix.Fields.TimeUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TimeUnit val) 
                { 
                    return isSetTimeUnit();
                }
                
                public bool isSetTimeUnit() 
                { 
                    return isSetField(Tags.TimeUnit);
                }
                public QuickFix.Fields.MaturityTime maturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityTime val) 
                { 
                    this.maturityTime = val;
                }
                
                public QuickFix.Fields.MaturityTime get(QuickFix.Fields.MaturityTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityTime val) 
                { 
                    return isSetMaturityTime();
                }
                
                public bool isSetMaturityTime() 
                { 
                    return isSetField(Tags.MaturityTime);
                }
                public QuickFix.Fields.SecurityGroup securityGroup
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityGroup val) 
                { 
                    this.securityGroup = val;
                }
                
                public QuickFix.Fields.SecurityGroup get(QuickFix.Fields.SecurityGroup val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityGroup val) 
                { 
                    return isSetSecurityGroup();
                }
                
                public bool isSetSecurityGroup() 
                { 
                    return isSetField(Tags.SecurityGroup);
                }
                public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
                { 
                    get 
                    {
                        QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    this.minPriceIncrementAmount = val;
                }
                
                public QuickFix.Fields.MinPriceIncrementAmount get(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    return isSetMinPriceIncrementAmount();
                }
                
                public bool isSetMinPriceIncrementAmount() 
                { 
                    return isSetField(Tags.MinPriceIncrementAmount);
                }
                public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    this.unitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnitOfMeasureQty get(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    return isSetUnitOfMeasureQty();
                }
                
                public bool isSetUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.UnitOfMeasureQty);
                }
                public QuickFix.Fields.SecurityXMLLen securityXMLLen
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    this.securityXMLLen = val;
                }
                
                public QuickFix.Fields.SecurityXMLLen get(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    return isSetSecurityXMLLen();
                }
                
                public bool isSetSecurityXMLLen() 
                { 
                    return isSetField(Tags.SecurityXMLLen);
                }
                public QuickFix.Fields.SecurityXML securityXML
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXML val) 
                { 
                    this.securityXML = val;
                }
                
                public QuickFix.Fields.SecurityXML get(QuickFix.Fields.SecurityXML val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXML val) 
                { 
                    return isSetSecurityXML();
                }
                
                public bool isSetSecurityXML() 
                { 
                    return isSetField(Tags.SecurityXML);
                }
                public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    this.securityXMLSchema = val;
                }
                
                public QuickFix.Fields.SecurityXMLSchema get(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    return isSetSecurityXMLSchema();
                }
                
                public bool isSetSecurityXMLSchema() 
                { 
                    return isSetField(Tags.SecurityXMLSchema);
                }
                public QuickFix.Fields.ProductComplex productComplex
                { 
                    get 
                    {
                        QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ProductComplex val) 
                { 
                    this.productComplex = val;
                }
                
                public QuickFix.Fields.ProductComplex get(QuickFix.Fields.ProductComplex val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ProductComplex val) 
                { 
                    return isSetProductComplex();
                }
                
                public bool isSetProductComplex() 
                { 
                    return isSetField(Tags.ProductComplex);
                }
                public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    this.priceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasure get(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    return isSetPriceUnitOfMeasure();
                }
                
                public bool isSetPriceUnitOfMeasure() 
                { 
                    return isSetField(Tags.PriceUnitOfMeasure);
                }
                public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    this.priceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasureQty get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    return isSetPriceUnitOfMeasureQty();
                }
                
                public bool isSetPriceUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.PriceUnitOfMeasureQty);
                }
                public QuickFix.Fields.SettlMethod settlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlMethod val) 
                { 
                    this.settlMethod = val;
                }
                
                public QuickFix.Fields.SettlMethod get(QuickFix.Fields.SettlMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlMethod val) 
                { 
                    return isSetSettlMethod();
                }
                
                public bool isSetSettlMethod() 
                { 
                    return isSetField(Tags.SettlMethod);
                }
                public QuickFix.Fields.ExerciseStyle exerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExerciseStyle val) 
                { 
                    this.exerciseStyle = val;
                }
                
                public QuickFix.Fields.ExerciseStyle get(QuickFix.Fields.ExerciseStyle val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExerciseStyle val) 
                { 
                    return isSetExerciseStyle();
                }
                
                public bool isSetExerciseStyle() 
                { 
                    return isSetField(Tags.ExerciseStyle);
                }
                public QuickFix.Fields.OptPayoutAmount optPayoutAmount
                { 
                    get 
                    {
                        QuickFix.Fields.OptPayoutAmount val = new QuickFix.Fields.OptPayoutAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptPayoutAmount val) 
                { 
                    this.optPayoutAmount = val;
                }
                
                public QuickFix.Fields.OptPayoutAmount get(QuickFix.Fields.OptPayoutAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptPayoutAmount val) 
                { 
                    return isSetOptPayoutAmount();
                }
                
                public bool isSetOptPayoutAmount() 
                { 
                    return isSetField(Tags.OptPayoutAmount);
                }
                public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
                { 
                    get 
                    {
                        QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    this.priceQuoteMethod = val;
                }
                
                public QuickFix.Fields.PriceQuoteMethod get(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    return isSetPriceQuoteMethod();
                }
                
                public bool isSetPriceQuoteMethod() 
                { 
                    return isSetField(Tags.PriceQuoteMethod);
                }
                public QuickFix.Fields.ListMethod listMethod
                { 
                    get 
                    {
                        QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListMethod val) 
                { 
                    this.listMethod = val;
                }
                
                public QuickFix.Fields.ListMethod get(QuickFix.Fields.ListMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListMethod val) 
                { 
                    return isSetListMethod();
                }
                
                public bool isSetListMethod() 
                { 
                    return isSetField(Tags.ListMethod);
                }
                public QuickFix.Fields.CapPrice capPrice
                { 
                    get 
                    {
                        QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CapPrice val) 
                { 
                    this.capPrice = val;
                }
                
                public QuickFix.Fields.CapPrice get(QuickFix.Fields.CapPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CapPrice val) 
                { 
                    return isSetCapPrice();
                }
                
                public bool isSetCapPrice() 
                { 
                    return isSetField(Tags.CapPrice);
                }
                public QuickFix.Fields.FloorPrice floorPrice
                { 
                    get 
                    {
                        QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FloorPrice val) 
                { 
                    this.floorPrice = val;
                }
                
                public QuickFix.Fields.FloorPrice get(QuickFix.Fields.FloorPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FloorPrice val) 
                { 
                    return isSetFloorPrice();
                }
                
                public bool isSetFloorPrice() 
                { 
                    return isSetField(Tags.FloorPrice);
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
                public QuickFix.Fields.FlexibleIndicator flexibleIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    this.flexibleIndicator = val;
                }
                
                public QuickFix.Fields.FlexibleIndicator get(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    return isSetFlexibleIndicator();
                }
                
                public bool isSetFlexibleIndicator() 
                { 
                    return isSetField(Tags.FlexibleIndicator);
                }
                public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    this.flexProductEligibilityIndicator = val;
                }
                
                public QuickFix.Fields.FlexProductEligibilityIndicator get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    return isSetFlexProductEligibilityIndicator();
                }
                
                public bool isSetFlexProductEligibilityIndicator() 
                { 
                    return isSetField(Tags.FlexProductEligibilityIndicator);
                }
                public QuickFix.Fields.ValuationMethod valuationMethod
                { 
                    get 
                    {
                        QuickFix.Fields.ValuationMethod val = new QuickFix.Fields.ValuationMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ValuationMethod val) 
                { 
                    this.valuationMethod = val;
                }
                
                public QuickFix.Fields.ValuationMethod get(QuickFix.Fields.ValuationMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ValuationMethod val) 
                { 
                    return isSetValuationMethod();
                }
                
                public bool isSetValuationMethod() 
                { 
                    return isSetField(Tags.ValuationMethod);
                }
                public QuickFix.Fields.ContractMultiplierUnit contractMultiplierUnit
                { 
                    get 
                    {
                        QuickFix.Fields.ContractMultiplierUnit val = new QuickFix.Fields.ContractMultiplierUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContractMultiplierUnit val) 
                { 
                    this.contractMultiplierUnit = val;
                }
                
                public QuickFix.Fields.ContractMultiplierUnit get(QuickFix.Fields.ContractMultiplierUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContractMultiplierUnit val) 
                { 
                    return isSetContractMultiplierUnit();
                }
                
                public bool isSetContractMultiplierUnit() 
                { 
                    return isSetField(Tags.ContractMultiplierUnit);
                }
                public QuickFix.Fields.FlowScheduleType flowScheduleType
                { 
                    get 
                    {
                        QuickFix.Fields.FlowScheduleType val = new QuickFix.Fields.FlowScheduleType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlowScheduleType val) 
                { 
                    this.flowScheduleType = val;
                }
                
                public QuickFix.Fields.FlowScheduleType get(QuickFix.Fields.FlowScheduleType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlowScheduleType val) 
                { 
                    return isSetFlowScheduleType();
                }
                
                public bool isSetFlowScheduleType() 
                { 
                    return isSetField(Tags.FlowScheduleType);
                }
                public QuickFix.Fields.RestructuringType restructuringType
                { 
                    get 
                    {
                        QuickFix.Fields.RestructuringType val = new QuickFix.Fields.RestructuringType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RestructuringType val) 
                { 
                    this.restructuringType = val;
                }
                
                public QuickFix.Fields.RestructuringType get(QuickFix.Fields.RestructuringType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RestructuringType val) 
                { 
                    return isSetRestructuringType();
                }
                
                public bool isSetRestructuringType() 
                { 
                    return isSetField(Tags.RestructuringType);
                }
                public QuickFix.Fields.Seniority seniority
                { 
                    get 
                    {
                        QuickFix.Fields.Seniority val = new QuickFix.Fields.Seniority();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Seniority val) 
                { 
                    this.seniority = val;
                }
                
                public QuickFix.Fields.Seniority get(QuickFix.Fields.Seniority val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Seniority val) 
                { 
                    return isSetSeniority();
                }
                
                public bool isSetSeniority() 
                { 
                    return isSetField(Tags.Seniority);
                }
                public QuickFix.Fields.NotionalPercentageOutstanding notionalPercentageOutstanding
                { 
                    get 
                    {
                        QuickFix.Fields.NotionalPercentageOutstanding val = new QuickFix.Fields.NotionalPercentageOutstanding();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NotionalPercentageOutstanding val) 
                { 
                    this.notionalPercentageOutstanding = val;
                }
                
                public QuickFix.Fields.NotionalPercentageOutstanding get(QuickFix.Fields.NotionalPercentageOutstanding val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NotionalPercentageOutstanding val) 
                { 
                    return isSetNotionalPercentageOutstanding();
                }
                
                public bool isSetNotionalPercentageOutstanding() 
                { 
                    return isSetField(Tags.NotionalPercentageOutstanding);
                }
                public QuickFix.Fields.OriginalNotionalPercentageOutstanding originalNotionalPercentageOutstanding
                { 
                    get 
                    {
                        QuickFix.Fields.OriginalNotionalPercentageOutstanding val = new QuickFix.Fields.OriginalNotionalPercentageOutstanding();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                { 
                    this.originalNotionalPercentageOutstanding = val;
                }
                
                public QuickFix.Fields.OriginalNotionalPercentageOutstanding get(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                { 
                    return isSetOriginalNotionalPercentageOutstanding();
                }
                
                public bool isSetOriginalNotionalPercentageOutstanding() 
                { 
                    return isSetField(Tags.OriginalNotionalPercentageOutstanding);
                }
                public QuickFix.Fields.AttachmentPoint attachmentPoint
                { 
                    get 
                    {
                        QuickFix.Fields.AttachmentPoint val = new QuickFix.Fields.AttachmentPoint();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AttachmentPoint val) 
                { 
                    this.attachmentPoint = val;
                }
                
                public QuickFix.Fields.AttachmentPoint get(QuickFix.Fields.AttachmentPoint val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AttachmentPoint val) 
                { 
                    return isSetAttachmentPoint();
                }
                
                public bool isSetAttachmentPoint() 
                { 
                    return isSetField(Tags.AttachmentPoint);
                }
                public QuickFix.Fields.DetachmentPoint detachmentPoint
                { 
                    get 
                    {
                        QuickFix.Fields.DetachmentPoint val = new QuickFix.Fields.DetachmentPoint();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DetachmentPoint val) 
                { 
                    this.detachmentPoint = val;
                }
                
                public QuickFix.Fields.DetachmentPoint get(QuickFix.Fields.DetachmentPoint val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DetachmentPoint val) 
                { 
                    return isSetDetachmentPoint();
                }
                
                public bool isSetDetachmentPoint() 
                { 
                    return isSetField(Tags.DetachmentPoint);
                }
                public QuickFix.Fields.StrikePriceDeterminationMethod strikePriceDeterminationMethod
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePriceDeterminationMethod val = new QuickFix.Fields.StrikePriceDeterminationMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                { 
                    this.strikePriceDeterminationMethod = val;
                }
                
                public QuickFix.Fields.StrikePriceDeterminationMethod get(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                { 
                    return isSetStrikePriceDeterminationMethod();
                }
                
                public bool isSetStrikePriceDeterminationMethod() 
                { 
                    return isSetField(Tags.StrikePriceDeterminationMethod);
                }
                public QuickFix.Fields.StrikePriceBoundaryMethod strikePriceBoundaryMethod
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePriceBoundaryMethod val = new QuickFix.Fields.StrikePriceBoundaryMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                { 
                    this.strikePriceBoundaryMethod = val;
                }
                
                public QuickFix.Fields.StrikePriceBoundaryMethod get(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                { 
                    return isSetStrikePriceBoundaryMethod();
                }
                
                public bool isSetStrikePriceBoundaryMethod() 
                { 
                    return isSetField(Tags.StrikePriceBoundaryMethod);
                }
                public QuickFix.Fields.StrikePriceBoundaryPrecision strikePriceBoundaryPrecision
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePriceBoundaryPrecision val = new QuickFix.Fields.StrikePriceBoundaryPrecision();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                { 
                    this.strikePriceBoundaryPrecision = val;
                }
                
                public QuickFix.Fields.StrikePriceBoundaryPrecision get(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                { 
                    return isSetStrikePriceBoundaryPrecision();
                }
                
                public bool isSetStrikePriceBoundaryPrecision() 
                { 
                    return isSetField(Tags.StrikePriceBoundaryPrecision);
                }
                public QuickFix.Fields.UnderlyingPriceDeterminationMethod underlyingPriceDeterminationMethod
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPriceDeterminationMethod val = new QuickFix.Fields.UnderlyingPriceDeterminationMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                { 
                    this.underlyingPriceDeterminationMethod = val;
                }
                
                public QuickFix.Fields.UnderlyingPriceDeterminationMethod get(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                { 
                    return isSetUnderlyingPriceDeterminationMethod();
                }
                
                public bool isSetUnderlyingPriceDeterminationMethod() 
                { 
                    return isSetField(Tags.UnderlyingPriceDeterminationMethod);
                }
                public QuickFix.Fields.OptPayoutType optPayoutType
                { 
                    get 
                    {
                        QuickFix.Fields.OptPayoutType val = new QuickFix.Fields.OptPayoutType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptPayoutType val) 
                { 
                    this.optPayoutType = val;
                }
                
                public QuickFix.Fields.OptPayoutType get(QuickFix.Fields.OptPayoutType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptPayoutType val) 
                { 
                    return isSetOptPayoutType();
                }
                
                public bool isSetOptPayoutType() 
                { 
                    return isSetField(Tags.OptPayoutType);
                }
                public QuickFix.Fields.NoComplexEvents noComplexEvents
                { 
                    get 
                    {
                        QuickFix.Fields.NoComplexEvents val = new QuickFix.Fields.NoComplexEvents();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoComplexEvents val) 
                { 
                    this.noComplexEvents = val;
                }
                
                public QuickFix.Fields.NoComplexEvents get(QuickFix.Fields.NoComplexEvents val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoComplexEvents val) 
                { 
                    return isSetNoComplexEvents();
                }
                
                public bool isSetNoComplexEvents() 
                { 
                    return isSetField(Tags.NoComplexEvents);
                }
                public QuickFix.Fields.NoUnderlyings noUnderlyings
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUnderlyings val) 
                { 
                    this.noUnderlyings = val;
                }
                
                public QuickFix.Fields.NoUnderlyings get(QuickFix.Fields.NoUnderlyings val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUnderlyings val) 
                { 
                    return isSetNoUnderlyings();
                }
                
                public bool isSetNoUnderlyings() 
                { 
                    return isSetField(Tags.NoUnderlyings);
                }
                public QuickFix.Fields.PrevClosePx prevClosePx
                { 
                    get 
                    {
                        QuickFix.Fields.PrevClosePx val = new QuickFix.Fields.PrevClosePx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PrevClosePx val) 
                { 
                    this.prevClosePx = val;
                }
                
                public QuickFix.Fields.PrevClosePx get(QuickFix.Fields.PrevClosePx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PrevClosePx val) 
                { 
                    return isSetPrevClosePx();
                }
                
                public bool isSetPrevClosePx() 
                { 
                    return isSetField(Tags.PrevClosePx);
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
                public QuickFix.Fields.LocateReqd locateReqd
                { 
                    get 
                    {
                        QuickFix.Fields.LocateReqd val = new QuickFix.Fields.LocateReqd();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LocateReqd val) 
                { 
                    this.locateReqd = val;
                }
                
                public QuickFix.Fields.LocateReqd get(QuickFix.Fields.LocateReqd val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LocateReqd val) 
                { 
                    return isSetLocateReqd();
                }
                
                public bool isSetLocateReqd() 
                { 
                    return isSetField(Tags.LocateReqd);
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
                public QuickFix.Fields.NoStipulations noStipulations
                { 
                    get 
                    {
                        QuickFix.Fields.NoStipulations val = new QuickFix.Fields.NoStipulations();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoStipulations val) 
                { 
                    this.noStipulations = val;
                }
                
                public QuickFix.Fields.NoStipulations get(QuickFix.Fields.NoStipulations val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoStipulations val) 
                { 
                    return isSetNoStipulations();
                }
                
                public bool isSetNoStipulations() 
                { 
                    return isSetField(Tags.NoStipulations);
                }
                public QuickFix.Fields.QtyType qtyType
                { 
                    get 
                    {
                        QuickFix.Fields.QtyType val = new QuickFix.Fields.QtyType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.QtyType val) 
                { 
                    this.qtyType = val;
                }
                
                public QuickFix.Fields.QtyType get(QuickFix.Fields.QtyType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.QtyType val) 
                { 
                    return isSetQtyType();
                }
                
                public bool isSetQtyType() 
                { 
                    return isSetField(Tags.QtyType);
                }
                public QuickFix.Fields.OrderQty orderQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderQty val) 
                { 
                    this.orderQty = val;
                }
                
                public QuickFix.Fields.OrderQty get(QuickFix.Fields.OrderQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderQty val) 
                { 
                    return isSetOrderQty();
                }
                
                public bool isSetOrderQty() 
                { 
                    return isSetField(Tags.OrderQty);
                }
                public QuickFix.Fields.CashOrderQty cashOrderQty
                { 
                    get 
                    {
                        QuickFix.Fields.CashOrderQty val = new QuickFix.Fields.CashOrderQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashOrderQty val) 
                { 
                    this.cashOrderQty = val;
                }
                
                public QuickFix.Fields.CashOrderQty get(QuickFix.Fields.CashOrderQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashOrderQty val) 
                { 
                    return isSetCashOrderQty();
                }
                
                public bool isSetCashOrderQty() 
                { 
                    return isSetField(Tags.CashOrderQty);
                }
                public QuickFix.Fields.OrderPercent orderPercent
                { 
                    get 
                    {
                        QuickFix.Fields.OrderPercent val = new QuickFix.Fields.OrderPercent();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderPercent val) 
                { 
                    this.orderPercent = val;
                }
                
                public QuickFix.Fields.OrderPercent get(QuickFix.Fields.OrderPercent val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderPercent val) 
                { 
                    return isSetOrderPercent();
                }
                
                public bool isSetOrderPercent() 
                { 
                    return isSetField(Tags.OrderPercent);
                }
                public QuickFix.Fields.RoundingDirection roundingDirection
                { 
                    get 
                    {
                        QuickFix.Fields.RoundingDirection val = new QuickFix.Fields.RoundingDirection();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RoundingDirection val) 
                { 
                    this.roundingDirection = val;
                }
                
                public QuickFix.Fields.RoundingDirection get(QuickFix.Fields.RoundingDirection val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RoundingDirection val) 
                { 
                    return isSetRoundingDirection();
                }
                
                public bool isSetRoundingDirection() 
                { 
                    return isSetField(Tags.RoundingDirection);
                }
                public QuickFix.Fields.RoundingModulus roundingModulus
                { 
                    get 
                    {
                        QuickFix.Fields.RoundingModulus val = new QuickFix.Fields.RoundingModulus();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RoundingModulus val) 
                { 
                    this.roundingModulus = val;
                }
                
                public QuickFix.Fields.RoundingModulus get(QuickFix.Fields.RoundingModulus val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RoundingModulus val) 
                { 
                    return isSetRoundingModulus();
                }
                
                public bool isSetRoundingModulus() 
                { 
                    return isSetField(Tags.RoundingModulus);
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
                public QuickFix.Fields.StopPx stopPx
                { 
                    get 
                    {
                        QuickFix.Fields.StopPx val = new QuickFix.Fields.StopPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StopPx val) 
                { 
                    this.stopPx = val;
                }
                
                public QuickFix.Fields.StopPx get(QuickFix.Fields.StopPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StopPx val) 
                { 
                    return isSetStopPx();
                }
                
                public bool isSetStopPx() 
                { 
                    return isSetField(Tags.StopPx);
                }
                public QuickFix.Fields.Spread spread
                { 
                    get 
                    {
                        QuickFix.Fields.Spread val = new QuickFix.Fields.Spread();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Spread val) 
                { 
                    this.spread = val;
                }
                
                public QuickFix.Fields.Spread get(QuickFix.Fields.Spread val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Spread val) 
                { 
                    return isSetSpread();
                }
                
                public bool isSetSpread() 
                { 
                    return isSetField(Tags.Spread);
                }
                public QuickFix.Fields.BenchmarkCurveCurrency benchmarkCurveCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurveCurrency val = new QuickFix.Fields.BenchmarkCurveCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    this.benchmarkCurveCurrency = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveCurrency get(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    return isSetBenchmarkCurveCurrency();
                }
                
                public bool isSetBenchmarkCurveCurrency() 
                { 
                    return isSetField(Tags.BenchmarkCurveCurrency);
                }
                public QuickFix.Fields.BenchmarkCurveName benchmarkCurveName
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurveName val = new QuickFix.Fields.BenchmarkCurveName();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    this.benchmarkCurveName = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveName get(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    return isSetBenchmarkCurveName();
                }
                
                public bool isSetBenchmarkCurveName() 
                { 
                    return isSetField(Tags.BenchmarkCurveName);
                }
                public QuickFix.Fields.BenchmarkCurvePoint benchmarkCurvePoint
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurvePoint val = new QuickFix.Fields.BenchmarkCurvePoint();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    this.benchmarkCurvePoint = val;
                }
                
                public QuickFix.Fields.BenchmarkCurvePoint get(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    return isSetBenchmarkCurvePoint();
                }
                
                public bool isSetBenchmarkCurvePoint() 
                { 
                    return isSetField(Tags.BenchmarkCurvePoint);
                }
                public QuickFix.Fields.BenchmarkPrice benchmarkPrice
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    this.benchmarkPrice = val;
                }
                
                public QuickFix.Fields.BenchmarkPrice get(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    return isSetBenchmarkPrice();
                }
                
                public bool isSetBenchmarkPrice() 
                { 
                    return isSetField(Tags.BenchmarkPrice);
                }
                public QuickFix.Fields.BenchmarkPriceType benchmarkPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    this.benchmarkPriceType = val;
                }
                
                public QuickFix.Fields.BenchmarkPriceType get(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    return isSetBenchmarkPriceType();
                }
                
                public bool isSetBenchmarkPriceType() 
                { 
                    return isSetField(Tags.BenchmarkPriceType);
                }
                public QuickFix.Fields.BenchmarkSecurityID benchmarkSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkSecurityID val = new QuickFix.Fields.BenchmarkSecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    this.benchmarkSecurityID = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityID get(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    return isSetBenchmarkSecurityID();
                }
                
                public bool isSetBenchmarkSecurityID() 
                { 
                    return isSetField(Tags.BenchmarkSecurityID);
                }
                public QuickFix.Fields.BenchmarkSecurityIDSource benchmarkSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkSecurityIDSource val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    this.benchmarkSecurityIDSource = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityIDSource get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    return isSetBenchmarkSecurityIDSource();
                }
                
                public bool isSetBenchmarkSecurityIDSource() 
                { 
                    return isSetField(Tags.BenchmarkSecurityIDSource);
                }
                public QuickFix.Fields.YieldType yieldType
                { 
                    get 
                    {
                        QuickFix.Fields.YieldType val = new QuickFix.Fields.YieldType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.YieldType val) 
                { 
                    this.yieldType = val;
                }
                
                public QuickFix.Fields.YieldType get(QuickFix.Fields.YieldType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.YieldType val) 
                { 
                    return isSetYieldType();
                }
                
                public bool isSetYieldType() 
                { 
                    return isSetField(Tags.YieldType);
                }
                public QuickFix.Fields.Yield yield
                { 
                    get 
                    {
                        QuickFix.Fields.Yield val = new QuickFix.Fields.Yield();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Yield val) 
                { 
                    this.yield = val;
                }
                
                public QuickFix.Fields.Yield get(QuickFix.Fields.Yield val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Yield val) 
                { 
                    return isSetYield();
                }
                
                public bool isSetYield() 
                { 
                    return isSetField(Tags.Yield);
                }
                public QuickFix.Fields.YieldCalcDate yieldCalcDate
                { 
                    get 
                    {
                        QuickFix.Fields.YieldCalcDate val = new QuickFix.Fields.YieldCalcDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.YieldCalcDate val) 
                { 
                    this.yieldCalcDate = val;
                }
                
                public QuickFix.Fields.YieldCalcDate get(QuickFix.Fields.YieldCalcDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.YieldCalcDate val) 
                { 
                    return isSetYieldCalcDate();
                }
                
                public bool isSetYieldCalcDate() 
                { 
                    return isSetField(Tags.YieldCalcDate);
                }
                public QuickFix.Fields.YieldRedemptionDate yieldRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionDate val = new QuickFix.Fields.YieldRedemptionDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    this.yieldRedemptionDate = val;
                }
                
                public QuickFix.Fields.YieldRedemptionDate get(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    return isSetYieldRedemptionDate();
                }
                
                public bool isSetYieldRedemptionDate() 
                { 
                    return isSetField(Tags.YieldRedemptionDate);
                }
                public QuickFix.Fields.YieldRedemptionPrice yieldRedemptionPrice
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionPrice val = new QuickFix.Fields.YieldRedemptionPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    this.yieldRedemptionPrice = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPrice get(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    return isSetYieldRedemptionPrice();
                }
                
                public bool isSetYieldRedemptionPrice() 
                { 
                    return isSetField(Tags.YieldRedemptionPrice);
                }
                public QuickFix.Fields.YieldRedemptionPriceType yieldRedemptionPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionPriceType val = new QuickFix.Fields.YieldRedemptionPriceType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    this.yieldRedemptionPriceType = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPriceType get(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    return isSetYieldRedemptionPriceType();
                }
                
                public bool isSetYieldRedemptionPriceType() 
                { 
                    return isSetField(Tags.YieldRedemptionPriceType);
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
                public QuickFix.Fields.ComplianceID complianceID
                { 
                    get 
                    {
                        QuickFix.Fields.ComplianceID val = new QuickFix.Fields.ComplianceID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ComplianceID val) 
                { 
                    this.complianceID = val;
                }
                
                public QuickFix.Fields.ComplianceID get(QuickFix.Fields.ComplianceID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ComplianceID val) 
                { 
                    return isSetComplianceID();
                }
                
                public bool isSetComplianceID() 
                { 
                    return isSetField(Tags.ComplianceID);
                }
                public QuickFix.Fields.SolicitedFlag solicitedFlag
                { 
                    get 
                    {
                        QuickFix.Fields.SolicitedFlag val = new QuickFix.Fields.SolicitedFlag();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SolicitedFlag val) 
                { 
                    this.solicitedFlag = val;
                }
                
                public QuickFix.Fields.SolicitedFlag get(QuickFix.Fields.SolicitedFlag val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SolicitedFlag val) 
                { 
                    return isSetSolicitedFlag();
                }
                
                public bool isSetSolicitedFlag() 
                { 
                    return isSetField(Tags.SolicitedFlag);
                }
                public QuickFix.Fields.IOIID iOIID
                { 
                    get 
                    {
                        QuickFix.Fields.IOIID val = new QuickFix.Fields.IOIID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.IOIID val) 
                { 
                    this.iOIID = val;
                }
                
                public QuickFix.Fields.IOIID get(QuickFix.Fields.IOIID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.IOIID val) 
                { 
                    return isSetIOIID();
                }
                
                public bool isSetIOIID() 
                { 
                    return isSetField(Tags.IOIID);
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
                public QuickFix.Fields.EffectiveTime effectiveTime
                { 
                    get 
                    {
                        QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EffectiveTime val) 
                { 
                    this.effectiveTime = val;
                }
                
                public QuickFix.Fields.EffectiveTime get(QuickFix.Fields.EffectiveTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EffectiveTime val) 
                { 
                    return isSetEffectiveTime();
                }
                
                public bool isSetEffectiveTime() 
                { 
                    return isSetField(Tags.EffectiveTime);
                }
                public QuickFix.Fields.ExpireDate expireDate
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExpireDate val) 
                { 
                    this.expireDate = val;
                }
                
                public QuickFix.Fields.ExpireDate get(QuickFix.Fields.ExpireDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExpireDate val) 
                { 
                    return isSetExpireDate();
                }
                
                public bool isSetExpireDate() 
                { 
                    return isSetField(Tags.ExpireDate);
                }
                public QuickFix.Fields.ExpireTime expireTime
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExpireTime val) 
                { 
                    this.expireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime get(QuickFix.Fields.ExpireTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return isSetExpireTime();
                }
                
                public bool isSetExpireTime() 
                { 
                    return isSetField(Tags.ExpireTime);
                }
                public QuickFix.Fields.GTBookingInst gTBookingInst
                { 
                    get 
                    {
                        QuickFix.Fields.GTBookingInst val = new QuickFix.Fields.GTBookingInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.GTBookingInst val) 
                { 
                    this.gTBookingInst = val;
                }
                
                public QuickFix.Fields.GTBookingInst get(QuickFix.Fields.GTBookingInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.GTBookingInst val) 
                { 
                    return isSetGTBookingInst();
                }
                
                public bool isSetGTBookingInst() 
                { 
                    return isSetField(Tags.GTBookingInst);
                }
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
                public QuickFix.Fields.OrderCapacity orderCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.OrderCapacity val = new QuickFix.Fields.OrderCapacity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderCapacity val) 
                { 
                    this.orderCapacity = val;
                }
                
                public QuickFix.Fields.OrderCapacity get(QuickFix.Fields.OrderCapacity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderCapacity val) 
                { 
                    return isSetOrderCapacity();
                }
                
                public bool isSetOrderCapacity() 
                { 
                    return isSetField(Tags.OrderCapacity);
                }
                public QuickFix.Fields.OrderRestrictions orderRestrictions
                { 
                    get 
                    {
                        QuickFix.Fields.OrderRestrictions val = new QuickFix.Fields.OrderRestrictions();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OrderRestrictions val) 
                { 
                    this.orderRestrictions = val;
                }
                
                public QuickFix.Fields.OrderRestrictions get(QuickFix.Fields.OrderRestrictions val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OrderRestrictions val) 
                { 
                    return isSetOrderRestrictions();
                }
                
                public bool isSetOrderRestrictions() 
                { 
                    return isSetField(Tags.OrderRestrictions);
                }
                public QuickFix.Fields.CustOrderCapacity custOrderCapacity
                { 
                    get 
                    {
                        QuickFix.Fields.CustOrderCapacity val = new QuickFix.Fields.CustOrderCapacity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    this.custOrderCapacity = val;
                }
                
                public QuickFix.Fields.CustOrderCapacity get(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CustOrderCapacity val) 
                { 
                    return isSetCustOrderCapacity();
                }
                
                public bool isSetCustOrderCapacity() 
                { 
                    return isSetField(Tags.CustOrderCapacity);
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
                public QuickFix.Fields.SettlCurrency settlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrency val = new QuickFix.Fields.SettlCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlCurrency val) 
                { 
                    this.settlCurrency = val;
                }
                
                public QuickFix.Fields.SettlCurrency get(QuickFix.Fields.SettlCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlCurrency val) 
                { 
                    return isSetSettlCurrency();
                }
                
                public bool isSetSettlCurrency() 
                { 
                    return isSetField(Tags.SettlCurrency);
                }
                public QuickFix.Fields.BookingType bookingType
                { 
                    get 
                    {
                        QuickFix.Fields.BookingType val = new QuickFix.Fields.BookingType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.BookingType val) 
                { 
                    this.bookingType = val;
                }
                
                public QuickFix.Fields.BookingType get(QuickFix.Fields.BookingType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.BookingType val) 
                { 
                    return isSetBookingType();
                }
                
                public bool isSetBookingType() 
                { 
                    return isSetField(Tags.BookingType);
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
                public QuickFix.Fields.SettlDate2 settlDate2
                { 
                    get 
                    {
                        QuickFix.Fields.SettlDate2 val = new QuickFix.Fields.SettlDate2();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlDate2 val) 
                { 
                    this.settlDate2 = val;
                }
                
                public QuickFix.Fields.SettlDate2 get(QuickFix.Fields.SettlDate2 val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlDate2 val) 
                { 
                    return isSetSettlDate2();
                }
                
                public bool isSetSettlDate2() 
                { 
                    return isSetField(Tags.SettlDate2);
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
                public QuickFix.Fields.Price2 price2
                { 
                    get 
                    {
                        QuickFix.Fields.Price2 val = new QuickFix.Fields.Price2();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Price2 val) 
                { 
                    this.price2 = val;
                }
                
                public QuickFix.Fields.Price2 get(QuickFix.Fields.Price2 val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Price2 val) 
                { 
                    return isSetPrice2();
                }
                
                public bool isSetPrice2() 
                { 
                    return isSetField(Tags.Price2);
                }
                public QuickFix.Fields.PositionEffect positionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.PositionEffect val = new QuickFix.Fields.PositionEffect();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PositionEffect val) 
                { 
                    this.positionEffect = val;
                }
                
                public QuickFix.Fields.PositionEffect get(QuickFix.Fields.PositionEffect val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PositionEffect val) 
                { 
                    return isSetPositionEffect();
                }
                
                public bool isSetPositionEffect() 
                { 
                    return isSetField(Tags.PositionEffect);
                }
                public QuickFix.Fields.CoveredOrUncovered coveredOrUncovered
                { 
                    get 
                    {
                        QuickFix.Fields.CoveredOrUncovered val = new QuickFix.Fields.CoveredOrUncovered();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    this.coveredOrUncovered = val;
                }
                
                public QuickFix.Fields.CoveredOrUncovered get(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CoveredOrUncovered val) 
                { 
                    return isSetCoveredOrUncovered();
                }
                
                public bool isSetCoveredOrUncovered() 
                { 
                    return isSetField(Tags.CoveredOrUncovered);
                }
                public QuickFix.Fields.MaxShow maxShow
                { 
                    get 
                    {
                        QuickFix.Fields.MaxShow val = new QuickFix.Fields.MaxShow();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaxShow val) 
                { 
                    this.maxShow = val;
                }
                
                public QuickFix.Fields.MaxShow get(QuickFix.Fields.MaxShow val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaxShow val) 
                { 
                    return isSetMaxShow();
                }
                
                public bool isSetMaxShow() 
                { 
                    return isSetField(Tags.MaxShow);
                }
                public QuickFix.Fields.PegOffsetValue pegOffsetValue
                { 
                    get 
                    {
                        QuickFix.Fields.PegOffsetValue val = new QuickFix.Fields.PegOffsetValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegOffsetValue val) 
                { 
                    this.pegOffsetValue = val;
                }
                
                public QuickFix.Fields.PegOffsetValue get(QuickFix.Fields.PegOffsetValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegOffsetValue val) 
                { 
                    return isSetPegOffsetValue();
                }
                
                public bool isSetPegOffsetValue() 
                { 
                    return isSetField(Tags.PegOffsetValue);
                }
                public QuickFix.Fields.PegMoveType pegMoveType
                { 
                    get 
                    {
                        QuickFix.Fields.PegMoveType val = new QuickFix.Fields.PegMoveType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegMoveType val) 
                { 
                    this.pegMoveType = val;
                }
                
                public QuickFix.Fields.PegMoveType get(QuickFix.Fields.PegMoveType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegMoveType val) 
                { 
                    return isSetPegMoveType();
                }
                
                public bool isSetPegMoveType() 
                { 
                    return isSetField(Tags.PegMoveType);
                }
                public QuickFix.Fields.PegOffsetType pegOffsetType
                { 
                    get 
                    {
                        QuickFix.Fields.PegOffsetType val = new QuickFix.Fields.PegOffsetType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegOffsetType val) 
                { 
                    this.pegOffsetType = val;
                }
                
                public QuickFix.Fields.PegOffsetType get(QuickFix.Fields.PegOffsetType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegOffsetType val) 
                { 
                    return isSetPegOffsetType();
                }
                
                public bool isSetPegOffsetType() 
                { 
                    return isSetField(Tags.PegOffsetType);
                }
                public QuickFix.Fields.PegLimitType pegLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.PegLimitType val = new QuickFix.Fields.PegLimitType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegLimitType val) 
                { 
                    this.pegLimitType = val;
                }
                
                public QuickFix.Fields.PegLimitType get(QuickFix.Fields.PegLimitType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegLimitType val) 
                { 
                    return isSetPegLimitType();
                }
                
                public bool isSetPegLimitType() 
                { 
                    return isSetField(Tags.PegLimitType);
                }
                public QuickFix.Fields.PegRoundDirection pegRoundDirection
                { 
                    get 
                    {
                        QuickFix.Fields.PegRoundDirection val = new QuickFix.Fields.PegRoundDirection();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegRoundDirection val) 
                { 
                    this.pegRoundDirection = val;
                }
                
                public QuickFix.Fields.PegRoundDirection get(QuickFix.Fields.PegRoundDirection val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegRoundDirection val) 
                { 
                    return isSetPegRoundDirection();
                }
                
                public bool isSetPegRoundDirection() 
                { 
                    return isSetField(Tags.PegRoundDirection);
                }
                public QuickFix.Fields.PegScope pegScope
                { 
                    get 
                    {
                        QuickFix.Fields.PegScope val = new QuickFix.Fields.PegScope();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegScope val) 
                { 
                    this.pegScope = val;
                }
                
                public QuickFix.Fields.PegScope get(QuickFix.Fields.PegScope val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegScope val) 
                { 
                    return isSetPegScope();
                }
                
                public bool isSetPegScope() 
                { 
                    return isSetField(Tags.PegScope);
                }
                public QuickFix.Fields.PegPriceType pegPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.PegPriceType val = new QuickFix.Fields.PegPriceType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegPriceType val) 
                { 
                    this.pegPriceType = val;
                }
                
                public QuickFix.Fields.PegPriceType get(QuickFix.Fields.PegPriceType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegPriceType val) 
                { 
                    return isSetPegPriceType();
                }
                
                public bool isSetPegPriceType() 
                { 
                    return isSetField(Tags.PegPriceType);
                }
                public QuickFix.Fields.PegSecurityIDSource pegSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PegSecurityIDSource val = new QuickFix.Fields.PegSecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegSecurityIDSource val) 
                { 
                    this.pegSecurityIDSource = val;
                }
                
                public QuickFix.Fields.PegSecurityIDSource get(QuickFix.Fields.PegSecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegSecurityIDSource val) 
                { 
                    return isSetPegSecurityIDSource();
                }
                
                public bool isSetPegSecurityIDSource() 
                { 
                    return isSetField(Tags.PegSecurityIDSource);
                }
                public QuickFix.Fields.PegSecurityID pegSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.PegSecurityID val = new QuickFix.Fields.PegSecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegSecurityID val) 
                { 
                    this.pegSecurityID = val;
                }
                
                public QuickFix.Fields.PegSecurityID get(QuickFix.Fields.PegSecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegSecurityID val) 
                { 
                    return isSetPegSecurityID();
                }
                
                public bool isSetPegSecurityID() 
                { 
                    return isSetField(Tags.PegSecurityID);
                }
                public QuickFix.Fields.PegSymbol pegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.PegSymbol val = new QuickFix.Fields.PegSymbol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegSymbol val) 
                { 
                    this.pegSymbol = val;
                }
                
                public QuickFix.Fields.PegSymbol get(QuickFix.Fields.PegSymbol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegSymbol val) 
                { 
                    return isSetPegSymbol();
                }
                
                public bool isSetPegSymbol() 
                { 
                    return isSetField(Tags.PegSymbol);
                }
                public QuickFix.Fields.PegSecurityDesc pegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.PegSecurityDesc val = new QuickFix.Fields.PegSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PegSecurityDesc val) 
                { 
                    this.pegSecurityDesc = val;
                }
                
                public QuickFix.Fields.PegSecurityDesc get(QuickFix.Fields.PegSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PegSecurityDesc val) 
                { 
                    return isSetPegSecurityDesc();
                }
                
                public bool isSetPegSecurityDesc() 
                { 
                    return isSetField(Tags.PegSecurityDesc);
                }
                public QuickFix.Fields.DiscretionInst discretionInst
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionInst val = new QuickFix.Fields.DiscretionInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionInst val) 
                { 
                    this.discretionInst = val;
                }
                
                public QuickFix.Fields.DiscretionInst get(QuickFix.Fields.DiscretionInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionInst val) 
                { 
                    return isSetDiscretionInst();
                }
                
                public bool isSetDiscretionInst() 
                { 
                    return isSetField(Tags.DiscretionInst);
                }
                public QuickFix.Fields.DiscretionOffsetValue discretionOffsetValue
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionOffsetValue val = new QuickFix.Fields.DiscretionOffsetValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionOffsetValue val) 
                { 
                    this.discretionOffsetValue = val;
                }
                
                public QuickFix.Fields.DiscretionOffsetValue get(QuickFix.Fields.DiscretionOffsetValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionOffsetValue val) 
                { 
                    return isSetDiscretionOffsetValue();
                }
                
                public bool isSetDiscretionOffsetValue() 
                { 
                    return isSetField(Tags.DiscretionOffsetValue);
                }
                public QuickFix.Fields.DiscretionMoveType discretionMoveType
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionMoveType val = new QuickFix.Fields.DiscretionMoveType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionMoveType val) 
                { 
                    this.discretionMoveType = val;
                }
                
                public QuickFix.Fields.DiscretionMoveType get(QuickFix.Fields.DiscretionMoveType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionMoveType val) 
                { 
                    return isSetDiscretionMoveType();
                }
                
                public bool isSetDiscretionMoveType() 
                { 
                    return isSetField(Tags.DiscretionMoveType);
                }
                public QuickFix.Fields.DiscretionOffsetType discretionOffsetType
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionOffsetType val = new QuickFix.Fields.DiscretionOffsetType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionOffsetType val) 
                { 
                    this.discretionOffsetType = val;
                }
                
                public QuickFix.Fields.DiscretionOffsetType get(QuickFix.Fields.DiscretionOffsetType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionOffsetType val) 
                { 
                    return isSetDiscretionOffsetType();
                }
                
                public bool isSetDiscretionOffsetType() 
                { 
                    return isSetField(Tags.DiscretionOffsetType);
                }
                public QuickFix.Fields.DiscretionLimitType discretionLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionLimitType val = new QuickFix.Fields.DiscretionLimitType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionLimitType val) 
                { 
                    this.discretionLimitType = val;
                }
                
                public QuickFix.Fields.DiscretionLimitType get(QuickFix.Fields.DiscretionLimitType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionLimitType val) 
                { 
                    return isSetDiscretionLimitType();
                }
                
                public bool isSetDiscretionLimitType() 
                { 
                    return isSetField(Tags.DiscretionLimitType);
                }
                public QuickFix.Fields.DiscretionRoundDirection discretionRoundDirection
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionRoundDirection val = new QuickFix.Fields.DiscretionRoundDirection();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionRoundDirection val) 
                { 
                    this.discretionRoundDirection = val;
                }
                
                public QuickFix.Fields.DiscretionRoundDirection get(QuickFix.Fields.DiscretionRoundDirection val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionRoundDirection val) 
                { 
                    return isSetDiscretionRoundDirection();
                }
                
                public bool isSetDiscretionRoundDirection() 
                { 
                    return isSetField(Tags.DiscretionRoundDirection);
                }
                public QuickFix.Fields.DiscretionScope discretionScope
                { 
                    get 
                    {
                        QuickFix.Fields.DiscretionScope val = new QuickFix.Fields.DiscretionScope();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DiscretionScope val) 
                { 
                    this.discretionScope = val;
                }
                
                public QuickFix.Fields.DiscretionScope get(QuickFix.Fields.DiscretionScope val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DiscretionScope val) 
                { 
                    return isSetDiscretionScope();
                }
                
                public bool isSetDiscretionScope() 
                { 
                    return isSetField(Tags.DiscretionScope);
                }
                public QuickFix.Fields.TargetStrategy targetStrategy
                { 
                    get 
                    {
                        QuickFix.Fields.TargetStrategy val = new QuickFix.Fields.TargetStrategy();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TargetStrategy val) 
                { 
                    this.targetStrategy = val;
                }
                
                public QuickFix.Fields.TargetStrategy get(QuickFix.Fields.TargetStrategy val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TargetStrategy val) 
                { 
                    return isSetTargetStrategy();
                }
                
                public bool isSetTargetStrategy() 
                { 
                    return isSetField(Tags.TargetStrategy);
                }
                public QuickFix.Fields.TargetStrategyParameters targetStrategyParameters
                { 
                    get 
                    {
                        QuickFix.Fields.TargetStrategyParameters val = new QuickFix.Fields.TargetStrategyParameters();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TargetStrategyParameters val) 
                { 
                    this.targetStrategyParameters = val;
                }
                
                public QuickFix.Fields.TargetStrategyParameters get(QuickFix.Fields.TargetStrategyParameters val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TargetStrategyParameters val) 
                { 
                    return isSetTargetStrategyParameters();
                }
                
                public bool isSetTargetStrategyParameters() 
                { 
                    return isSetField(Tags.TargetStrategyParameters);
                }
                public QuickFix.Fields.ParticipationRate participationRate
                { 
                    get 
                    {
                        QuickFix.Fields.ParticipationRate val = new QuickFix.Fields.ParticipationRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ParticipationRate val) 
                { 
                    this.participationRate = val;
                }
                
                public QuickFix.Fields.ParticipationRate get(QuickFix.Fields.ParticipationRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ParticipationRate val) 
                { 
                    return isSetParticipationRate();
                }
                
                public bool isSetParticipationRate() 
                { 
                    return isSetField(Tags.ParticipationRate);
                }
                public QuickFix.Fields.Designation designation
                { 
                    get 
                    {
                        QuickFix.Fields.Designation val = new QuickFix.Fields.Designation();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Designation val) 
                { 
                    this.designation = val;
                }
                
                public QuickFix.Fields.Designation get(QuickFix.Fields.Designation val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Designation val) 
                { 
                    return isSetDesignation();
                }
                
                public bool isSetDesignation() 
                { 
                    return isSetField(Tags.Designation);
                }
                public QuickFix.Fields.NoStrategyParameters noStrategyParameters
                { 
                    get 
                    {
                        QuickFix.Fields.NoStrategyParameters val = new QuickFix.Fields.NoStrategyParameters();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoStrategyParameters val) 
                { 
                    this.noStrategyParameters = val;
                }
                
                public QuickFix.Fields.NoStrategyParameters get(QuickFix.Fields.NoStrategyParameters val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoStrategyParameters val) 
                { 
                    return isSetNoStrategyParameters();
                }
                
                public bool isSetNoStrategyParameters() 
                { 
                    return isSetField(Tags.NoStrategyParameters);
                }
                public QuickFix.Fields.MatchIncrement matchIncrement
                { 
                    get 
                    {
                        QuickFix.Fields.MatchIncrement val = new QuickFix.Fields.MatchIncrement();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MatchIncrement val) 
                { 
                    this.matchIncrement = val;
                }
                
                public QuickFix.Fields.MatchIncrement get(QuickFix.Fields.MatchIncrement val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MatchIncrement val) 
                { 
                    return isSetMatchIncrement();
                }
                
                public bool isSetMatchIncrement() 
                { 
                    return isSetField(Tags.MatchIncrement);
                }
                public QuickFix.Fields.MaxPriceLevels maxPriceLevels
                { 
                    get 
                    {
                        QuickFix.Fields.MaxPriceLevels val = new QuickFix.Fields.MaxPriceLevels();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaxPriceLevels val) 
                { 
                    this.maxPriceLevels = val;
                }
                
                public QuickFix.Fields.MaxPriceLevels get(QuickFix.Fields.MaxPriceLevels val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaxPriceLevels val) 
                { 
                    return isSetMaxPriceLevels();
                }
                
                public bool isSetMaxPriceLevels() 
                { 
                    return isSetField(Tags.MaxPriceLevels);
                }
                public QuickFix.Fields.SecondaryDisplayQty secondaryDisplayQty
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryDisplayQty val = new QuickFix.Fields.SecondaryDisplayQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryDisplayQty val) 
                { 
                    this.secondaryDisplayQty = val;
                }
                
                public QuickFix.Fields.SecondaryDisplayQty get(QuickFix.Fields.SecondaryDisplayQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryDisplayQty val) 
                { 
                    return isSetSecondaryDisplayQty();
                }
                
                public bool isSetSecondaryDisplayQty() 
                { 
                    return isSetField(Tags.SecondaryDisplayQty);
                }
                public QuickFix.Fields.DisplayWhen displayWhen
                { 
                    get 
                    {
                        QuickFix.Fields.DisplayWhen val = new QuickFix.Fields.DisplayWhen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DisplayWhen val) 
                { 
                    this.displayWhen = val;
                }
                
                public QuickFix.Fields.DisplayWhen get(QuickFix.Fields.DisplayWhen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DisplayWhen val) 
                { 
                    return isSetDisplayWhen();
                }
                
                public bool isSetDisplayWhen() 
                { 
                    return isSetField(Tags.DisplayWhen);
                }
                public QuickFix.Fields.DisplayMethod displayMethod
                { 
                    get 
                    {
                        QuickFix.Fields.DisplayMethod val = new QuickFix.Fields.DisplayMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DisplayMethod val) 
                { 
                    this.displayMethod = val;
                }
                
                public QuickFix.Fields.DisplayMethod get(QuickFix.Fields.DisplayMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DisplayMethod val) 
                { 
                    return isSetDisplayMethod();
                }
                
                public bool isSetDisplayMethod() 
                { 
                    return isSetField(Tags.DisplayMethod);
                }
                public QuickFix.Fields.DisplayLowQty displayLowQty
                { 
                    get 
                    {
                        QuickFix.Fields.DisplayLowQty val = new QuickFix.Fields.DisplayLowQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DisplayLowQty val) 
                { 
                    this.displayLowQty = val;
                }
                
                public QuickFix.Fields.DisplayLowQty get(QuickFix.Fields.DisplayLowQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DisplayLowQty val) 
                { 
                    return isSetDisplayLowQty();
                }
                
                public bool isSetDisplayLowQty() 
                { 
                    return isSetField(Tags.DisplayLowQty);
                }
                public QuickFix.Fields.DisplayHighQty displayHighQty
                { 
                    get 
                    {
                        QuickFix.Fields.DisplayHighQty val = new QuickFix.Fields.DisplayHighQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DisplayHighQty val) 
                { 
                    this.displayHighQty = val;
                }
                
                public QuickFix.Fields.DisplayHighQty get(QuickFix.Fields.DisplayHighQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DisplayHighQty val) 
                { 
                    return isSetDisplayHighQty();
                }
                
                public bool isSetDisplayHighQty() 
                { 
                    return isSetField(Tags.DisplayHighQty);
                }
                public QuickFix.Fields.DisplayMinIncr displayMinIncr
                { 
                    get 
                    {
                        QuickFix.Fields.DisplayMinIncr val = new QuickFix.Fields.DisplayMinIncr();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DisplayMinIncr val) 
                { 
                    this.displayMinIncr = val;
                }
                
                public QuickFix.Fields.DisplayMinIncr get(QuickFix.Fields.DisplayMinIncr val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DisplayMinIncr val) 
                { 
                    return isSetDisplayMinIncr();
                }
                
                public bool isSetDisplayMinIncr() 
                { 
                    return isSetField(Tags.DisplayMinIncr);
                }
                public QuickFix.Fields.RefreshQty refreshQty
                { 
                    get 
                    {
                        QuickFix.Fields.RefreshQty val = new QuickFix.Fields.RefreshQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefreshQty val) 
                { 
                    this.refreshQty = val;
                }
                
                public QuickFix.Fields.RefreshQty get(QuickFix.Fields.RefreshQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefreshQty val) 
                { 
                    return isSetRefreshQty();
                }
                
                public bool isSetRefreshQty() 
                { 
                    return isSetField(Tags.RefreshQty);
                }
                public QuickFix.Fields.DisplayQty displayQty
                { 
                    get 
                    {
                        QuickFix.Fields.DisplayQty val = new QuickFix.Fields.DisplayQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DisplayQty val) 
                { 
                    this.displayQty = val;
                }
                
                public QuickFix.Fields.DisplayQty get(QuickFix.Fields.DisplayQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DisplayQty val) 
                { 
                    return isSetDisplayQty();
                }
                
                public bool isSetDisplayQty() 
                { 
                    return isSetField(Tags.DisplayQty);
                }
                public QuickFix.Fields.PriceProtectionScope priceProtectionScope
                { 
                    get 
                    {
                        QuickFix.Fields.PriceProtectionScope val = new QuickFix.Fields.PriceProtectionScope();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceProtectionScope val) 
                { 
                    this.priceProtectionScope = val;
                }
                
                public QuickFix.Fields.PriceProtectionScope get(QuickFix.Fields.PriceProtectionScope val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceProtectionScope val) 
                { 
                    return isSetPriceProtectionScope();
                }
                
                public bool isSetPriceProtectionScope() 
                { 
                    return isSetField(Tags.PriceProtectionScope);
                }
                public QuickFix.Fields.TriggerType triggerType
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerType val = new QuickFix.Fields.TriggerType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerType val) 
                { 
                    this.triggerType = val;
                }
                
                public QuickFix.Fields.TriggerType get(QuickFix.Fields.TriggerType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerType val) 
                { 
                    return isSetTriggerType();
                }
                
                public bool isSetTriggerType() 
                { 
                    return isSetField(Tags.TriggerType);
                }
                public QuickFix.Fields.TriggerAction triggerAction
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerAction val = new QuickFix.Fields.TriggerAction();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerAction val) 
                { 
                    this.triggerAction = val;
                }
                
                public QuickFix.Fields.TriggerAction get(QuickFix.Fields.TriggerAction val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerAction val) 
                { 
                    return isSetTriggerAction();
                }
                
                public bool isSetTriggerAction() 
                { 
                    return isSetField(Tags.TriggerAction);
                }
                public QuickFix.Fields.TriggerPrice triggerPrice
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerPrice val = new QuickFix.Fields.TriggerPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerPrice val) 
                { 
                    this.triggerPrice = val;
                }
                
                public QuickFix.Fields.TriggerPrice get(QuickFix.Fields.TriggerPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerPrice val) 
                { 
                    return isSetTriggerPrice();
                }
                
                public bool isSetTriggerPrice() 
                { 
                    return isSetField(Tags.TriggerPrice);
                }
                public QuickFix.Fields.TriggerSymbol triggerSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerSymbol val = new QuickFix.Fields.TriggerSymbol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerSymbol val) 
                { 
                    this.triggerSymbol = val;
                }
                
                public QuickFix.Fields.TriggerSymbol get(QuickFix.Fields.TriggerSymbol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerSymbol val) 
                { 
                    return isSetTriggerSymbol();
                }
                
                public bool isSetTriggerSymbol() 
                { 
                    return isSetField(Tags.TriggerSymbol);
                }
                public QuickFix.Fields.TriggerSecurityID triggerSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerSecurityID val = new QuickFix.Fields.TriggerSecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerSecurityID val) 
                { 
                    this.triggerSecurityID = val;
                }
                
                public QuickFix.Fields.TriggerSecurityID get(QuickFix.Fields.TriggerSecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerSecurityID val) 
                { 
                    return isSetTriggerSecurityID();
                }
                
                public bool isSetTriggerSecurityID() 
                { 
                    return isSetField(Tags.TriggerSecurityID);
                }
                public QuickFix.Fields.TriggerSecurityIDSource triggerSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerSecurityIDSource val = new QuickFix.Fields.TriggerSecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerSecurityIDSource val) 
                { 
                    this.triggerSecurityIDSource = val;
                }
                
                public QuickFix.Fields.TriggerSecurityIDSource get(QuickFix.Fields.TriggerSecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerSecurityIDSource val) 
                { 
                    return isSetTriggerSecurityIDSource();
                }
                
                public bool isSetTriggerSecurityIDSource() 
                { 
                    return isSetField(Tags.TriggerSecurityIDSource);
                }
                public QuickFix.Fields.TriggerSecurityDesc triggerSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerSecurityDesc val = new QuickFix.Fields.TriggerSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerSecurityDesc val) 
                { 
                    this.triggerSecurityDesc = val;
                }
                
                public QuickFix.Fields.TriggerSecurityDesc get(QuickFix.Fields.TriggerSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerSecurityDesc val) 
                { 
                    return isSetTriggerSecurityDesc();
                }
                
                public bool isSetTriggerSecurityDesc() 
                { 
                    return isSetField(Tags.TriggerSecurityDesc);
                }
                public QuickFix.Fields.TriggerPriceType triggerPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerPriceType val = new QuickFix.Fields.TriggerPriceType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerPriceType val) 
                { 
                    this.triggerPriceType = val;
                }
                
                public QuickFix.Fields.TriggerPriceType get(QuickFix.Fields.TriggerPriceType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerPriceType val) 
                { 
                    return isSetTriggerPriceType();
                }
                
                public bool isSetTriggerPriceType() 
                { 
                    return isSetField(Tags.TriggerPriceType);
                }
                public QuickFix.Fields.TriggerPriceTypeScope triggerPriceTypeScope
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerPriceTypeScope val = new QuickFix.Fields.TriggerPriceTypeScope();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerPriceTypeScope val) 
                { 
                    this.triggerPriceTypeScope = val;
                }
                
                public QuickFix.Fields.TriggerPriceTypeScope get(QuickFix.Fields.TriggerPriceTypeScope val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerPriceTypeScope val) 
                { 
                    return isSetTriggerPriceTypeScope();
                }
                
                public bool isSetTriggerPriceTypeScope() 
                { 
                    return isSetField(Tags.TriggerPriceTypeScope);
                }
                public QuickFix.Fields.TriggerPriceDirection triggerPriceDirection
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerPriceDirection val = new QuickFix.Fields.TriggerPriceDirection();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerPriceDirection val) 
                { 
                    this.triggerPriceDirection = val;
                }
                
                public QuickFix.Fields.TriggerPriceDirection get(QuickFix.Fields.TriggerPriceDirection val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerPriceDirection val) 
                { 
                    return isSetTriggerPriceDirection();
                }
                
                public bool isSetTriggerPriceDirection() 
                { 
                    return isSetField(Tags.TriggerPriceDirection);
                }
                public QuickFix.Fields.TriggerNewPrice triggerNewPrice
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerNewPrice val = new QuickFix.Fields.TriggerNewPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerNewPrice val) 
                { 
                    this.triggerNewPrice = val;
                }
                
                public QuickFix.Fields.TriggerNewPrice get(QuickFix.Fields.TriggerNewPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerNewPrice val) 
                { 
                    return isSetTriggerNewPrice();
                }
                
                public bool isSetTriggerNewPrice() 
                { 
                    return isSetField(Tags.TriggerNewPrice);
                }
                public QuickFix.Fields.TriggerOrderType triggerOrderType
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerOrderType val = new QuickFix.Fields.TriggerOrderType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerOrderType val) 
                { 
                    this.triggerOrderType = val;
                }
                
                public QuickFix.Fields.TriggerOrderType get(QuickFix.Fields.TriggerOrderType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerOrderType val) 
                { 
                    return isSetTriggerOrderType();
                }
                
                public bool isSetTriggerOrderType() 
                { 
                    return isSetField(Tags.TriggerOrderType);
                }
                public QuickFix.Fields.TriggerNewQty triggerNewQty
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerNewQty val = new QuickFix.Fields.TriggerNewQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerNewQty val) 
                { 
                    this.triggerNewQty = val;
                }
                
                public QuickFix.Fields.TriggerNewQty get(QuickFix.Fields.TriggerNewQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerNewQty val) 
                { 
                    return isSetTriggerNewQty();
                }
                
                public bool isSetTriggerNewQty() 
                { 
                    return isSetField(Tags.TriggerNewQty);
                }
                public QuickFix.Fields.TriggerTradingSessionID triggerTradingSessionID
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerTradingSessionID val = new QuickFix.Fields.TriggerTradingSessionID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerTradingSessionID val) 
                { 
                    this.triggerTradingSessionID = val;
                }
                
                public QuickFix.Fields.TriggerTradingSessionID get(QuickFix.Fields.TriggerTradingSessionID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerTradingSessionID val) 
                { 
                    return isSetTriggerTradingSessionID();
                }
                
                public bool isSetTriggerTradingSessionID() 
                { 
                    return isSetField(Tags.TriggerTradingSessionID);
                }
                public QuickFix.Fields.TriggerTradingSessionSubID triggerTradingSessionSubID
                { 
                    get 
                    {
                        QuickFix.Fields.TriggerTradingSessionSubID val = new QuickFix.Fields.TriggerTradingSessionSubID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TriggerTradingSessionSubID val) 
                { 
                    this.triggerTradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TriggerTradingSessionSubID get(QuickFix.Fields.TriggerTradingSessionSubID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TriggerTradingSessionSubID val) 
                { 
                    return isSetTriggerTradingSessionSubID();
                }
                
                public bool isSetTriggerTradingSessionSubID() 
                { 
                    return isSetField(Tags.TriggerTradingSessionSubID);
                }
                public QuickFix.Fields.RefOrderID refOrderID
                { 
                    get 
                    {
                        QuickFix.Fields.RefOrderID val = new QuickFix.Fields.RefOrderID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefOrderID val) 
                { 
                    this.refOrderID = val;
                }
                
                public QuickFix.Fields.RefOrderID get(QuickFix.Fields.RefOrderID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefOrderID val) 
                { 
                    return isSetRefOrderID();
                }
                
                public bool isSetRefOrderID() 
                { 
                    return isSetField(Tags.RefOrderID);
                }
                public QuickFix.Fields.RefOrderIDSource refOrderIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.RefOrderIDSource val = new QuickFix.Fields.RefOrderIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefOrderIDSource val) 
                { 
                    this.refOrderIDSource = val;
                }
                
                public QuickFix.Fields.RefOrderIDSource get(QuickFix.Fields.RefOrderIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefOrderIDSource val) 
                { 
                    return isSetRefOrderIDSource();
                }
                
                public bool isSetRefOrderIDSource() 
                { 
                    return isSetField(Tags.RefOrderIDSource);
                }
                public QuickFix.Fields.PreTradeAnonymity preTradeAnonymity
                { 
                    get 
                    {
                        QuickFix.Fields.PreTradeAnonymity val = new QuickFix.Fields.PreTradeAnonymity();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PreTradeAnonymity val) 
                { 
                    this.preTradeAnonymity = val;
                }
                
                public QuickFix.Fields.PreTradeAnonymity get(QuickFix.Fields.PreTradeAnonymity val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PreTradeAnonymity val) 
                { 
                    return isSetPreTradeAnonymity();
                }
                
                public bool isSetPreTradeAnonymity() 
                { 
                    return isSetField(Tags.PreTradeAnonymity);
                }
                public QuickFix.Fields.ExDestinationIDSource exDestinationIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.ExDestinationIDSource val = new QuickFix.Fields.ExDestinationIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExDestinationIDSource val) 
                { 
                    this.exDestinationIDSource = val;
                }
                
                public QuickFix.Fields.ExDestinationIDSource get(QuickFix.Fields.ExDestinationIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExDestinationIDSource val) 
                { 
                    return isSetExDestinationIDSource();
                }
                
                public bool isSetExDestinationIDSource() 
                { 
                    return isSetField(Tags.ExDestinationIDSource);
                }
                            public class NoPartyIDs : Group
                {
                    public NoPartyIDs() 
                      :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                                    public QuickFix.Fields.PartyID partyID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyID val) 
                    { 
                        this.partyID = val;
                    }
                    
                    public QuickFix.Fields.PartyID get(QuickFix.Fields.PartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyID val) 
                    { 
                        return isSetPartyID();
                    }
                    
                    public bool isSetPartyID() 
                    { 
                        return isSetField(Tags.PartyID);
                    }
                    public QuickFix.Fields.PartyIDSource partyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyIDSource val) 
                    { 
                        this.partyIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyIDSource get(QuickFix.Fields.PartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyIDSource val) 
                    { 
                        return isSetPartyIDSource();
                    }
                    
                    public bool isSetPartyIDSource() 
                    { 
                        return isSetField(Tags.PartyIDSource);
                    }
                    public QuickFix.Fields.PartyRole partyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyRole val) 
                    { 
                        this.partyRole = val;
                    }
                    
                    public QuickFix.Fields.PartyRole get(QuickFix.Fields.PartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyRole val) 
                    { 
                        return isSetPartyRole();
                    }
                    
                    public bool isSetPartyRole() 
                    { 
                        return isSetField(Tags.PartyRole);
                    }
                    public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        this.noPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartySubIDs get(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoPartySubIDs val) 
                    { 
                        return isSetNoPartySubIDs();
                    }
                    
                    public bool isSetNoPartySubIDs() 
                    { 
                        return isSetField(Tags.NoPartySubIDs);
                    }
                                    public class NoPartySubIDs : Group
                    {
                        public NoPartySubIDs() 
                          :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                                            public QuickFix.Fields.PartySubID partySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartySubID val) 
                        { 
                            this.partySubID = val;
                        }
                        
                        public QuickFix.Fields.PartySubID get(QuickFix.Fields.PartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartySubID val) 
                        { 
                            return isSetPartySubID();
                        }
                        
                        public bool isSetPartySubID() 
                        { 
                            return isSetField(Tags.PartySubID);
                        }
                        public QuickFix.Fields.PartySubIDType partySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartySubIDType val) 
                        { 
                            this.partySubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartySubIDType get(QuickFix.Fields.PartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartySubIDType val) 
                        { 
                            return isSetPartySubIDType();
                        }
                        
                        public bool isSetPartySubIDType() 
                        { 
                            return isSetField(Tags.PartySubIDType);
                        }
                    
                    }
                }
                public class NoAllocs : Group
                {
                    public NoAllocs() 
                      :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0};
                                    public QuickFix.Fields.AllocAccount allocAccount
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocAccount val) 
                    { 
                        this.allocAccount = val;
                    }
                    
                    public QuickFix.Fields.AllocAccount get(QuickFix.Fields.AllocAccount val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocAccount val) 
                    { 
                        return isSetAllocAccount();
                    }
                    
                    public bool isSetAllocAccount() 
                    { 
                        return isSetField(Tags.AllocAccount);
                    }
                    public QuickFix.Fields.AllocAcctIDSource allocAcctIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        this.allocAcctIDSource = val;
                    }
                    
                    public QuickFix.Fields.AllocAcctIDSource get(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocAcctIDSource val) 
                    { 
                        return isSetAllocAcctIDSource();
                    }
                    
                    public bool isSetAllocAcctIDSource() 
                    { 
                        return isSetField(Tags.AllocAcctIDSource);
                    }
                    public QuickFix.Fields.AllocSettlCurrency allocSettlCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocSettlCurrency val = new QuickFix.Fields.AllocSettlCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        this.allocSettlCurrency = val;
                    }
                    
                    public QuickFix.Fields.AllocSettlCurrency get(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocSettlCurrency val) 
                    { 
                        return isSetAllocSettlCurrency();
                    }
                    
                    public bool isSetAllocSettlCurrency() 
                    { 
                        return isSetField(Tags.AllocSettlCurrency);
                    }
                    public QuickFix.Fields.IndividualAllocID individualAllocID
                    { 
                        get 
                        {
                            QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        this.individualAllocID = val;
                    }
                    
                    public QuickFix.Fields.IndividualAllocID get(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.IndividualAllocID val) 
                    { 
                        return isSetIndividualAllocID();
                    }
                    
                    public bool isSetIndividualAllocID() 
                    { 
                        return isSetField(Tags.IndividualAllocID);
                    }
                    public QuickFix.Fields.NoNestedPartyIDs noNestedPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        this.noNestedPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartyIDs get(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        return isSetNoNestedPartyIDs();
                    }
                    
                    public bool isSetNoNestedPartyIDs() 
                    { 
                        return isSetField(Tags.NoNestedPartyIDs);
                    }
                    public QuickFix.Fields.AllocQty allocQty
                    { 
                        get 
                        {
                            QuickFix.Fields.AllocQty val = new QuickFix.Fields.AllocQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.AllocQty val) 
                    { 
                        this.allocQty = val;
                    }
                    
                    public QuickFix.Fields.AllocQty get(QuickFix.Fields.AllocQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.AllocQty val) 
                    { 
                        return isSetAllocQty();
                    }
                    
                    public bool isSetAllocQty() 
                    { 
                        return isSetField(Tags.AllocQty);
                    }
                                    public class NoNestedPartyIDs : Group
                    {
                        public NoNestedPartyIDs() 
                          :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};
                                            public QuickFix.Fields.NestedPartyID nestedPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartyID val) 
                        { 
                            this.nestedPartyID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyID get(QuickFix.Fields.NestedPartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartyID val) 
                        { 
                            return isSetNestedPartyID();
                        }
                        
                        public bool isSetNestedPartyID() 
                        { 
                            return isSetField(Tags.NestedPartyID);
                        }
                        public QuickFix.Fields.NestedPartyIDSource nestedPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            this.nestedPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyIDSource get(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            return isSetNestedPartyIDSource();
                        }
                        
                        public bool isSetNestedPartyIDSource() 
                        { 
                            return isSetField(Tags.NestedPartyIDSource);
                        }
                        public QuickFix.Fields.NestedPartyRole nestedPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            this.nestedPartyRole = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyRole get(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            return isSetNestedPartyRole();
                        }
                        
                        public bool isSetNestedPartyRole() 
                        { 
                            return isSetField(Tags.NestedPartyRole);
                        }
                        public QuickFix.Fields.NoNestedPartySubIDs noNestedPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            this.noNestedPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoNestedPartySubIDs get(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            return isSetNoNestedPartySubIDs();
                        }
                        
                        public bool isSetNoNestedPartySubIDs() 
                        { 
                            return isSetField(Tags.NoNestedPartySubIDs);
                        }
                                            public class NoNestedPartySubIDs : Group
                        {
                            public NoNestedPartySubIDs() 
                              :base( Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};
                                                    public QuickFix.Fields.NestedPartySubID nestedPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.NestedPartySubID val = new QuickFix.Fields.NestedPartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                this.nestedPartySubID = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubID get(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                return isSetNestedPartySubID();
                            }
                            
                            public bool isSetNestedPartySubID() 
                            { 
                                return isSetField(Tags.NestedPartySubID);
                            }
                            public QuickFix.Fields.NestedPartySubIDType nestedPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                this.nestedPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubIDType get(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                return isSetNestedPartySubIDType();
                            }
                            
                            public bool isSetNestedPartySubIDType() 
                            { 
                                return isSetField(Tags.NestedPartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoTradingSessions : Group
                {
                    public NoTradingSessions() 
                      :base( Tags.NoTradingSessions, Tags.TradingSessionID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, 0};
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
                
                }
                public class NoSecurityAltID : Group
                {
                    public NoSecurityAltID() 
                      :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                                    public QuickFix.Fields.SecurityAltID securityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SecurityAltID val) 
                    { 
                        this.securityAltID = val;
                    }
                    
                    public QuickFix.Fields.SecurityAltID get(QuickFix.Fields.SecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SecurityAltID val) 
                    { 
                        return isSetSecurityAltID();
                    }
                    
                    public bool isSetSecurityAltID() 
                    { 
                        return isSetField(Tags.SecurityAltID);
                    }
                    public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SecurityAltIDSource val) 
                    { 
                        this.securityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.SecurityAltIDSource get(QuickFix.Fields.SecurityAltIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SecurityAltIDSource val) 
                    { 
                        return isSetSecurityAltIDSource();
                    }
                    
                    public bool isSetSecurityAltIDSource() 
                    { 
                        return isSetField(Tags.SecurityAltIDSource);
                    }
                
                }
                public class NoEvents : Group
                {
                    public NoEvents() 
                      :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                                    public QuickFix.Fields.EventType eventType
                    { 
                        get 
                        {
                            QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventType val) 
                    { 
                        this.eventType = val;
                    }
                    
                    public QuickFix.Fields.EventType get(QuickFix.Fields.EventType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventType val) 
                    { 
                        return isSetEventType();
                    }
                    
                    public bool isSetEventType() 
                    { 
                        return isSetField(Tags.EventType);
                    }
                    public QuickFix.Fields.EventDate eventDate
                    { 
                        get 
                        {
                            QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventDate val) 
                    { 
                        this.eventDate = val;
                    }
                    
                    public QuickFix.Fields.EventDate get(QuickFix.Fields.EventDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventDate val) 
                    { 
                        return isSetEventDate();
                    }
                    
                    public bool isSetEventDate() 
                    { 
                        return isSetField(Tags.EventDate);
                    }
                    public QuickFix.Fields.EventPx eventPx
                    { 
                        get 
                        {
                            QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventPx val) 
                    { 
                        this.eventPx = val;
                    }
                    
                    public QuickFix.Fields.EventPx get(QuickFix.Fields.EventPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventPx val) 
                    { 
                        return isSetEventPx();
                    }
                    
                    public bool isSetEventPx() 
                    { 
                        return isSetField(Tags.EventPx);
                    }
                    public QuickFix.Fields.EventText eventText
                    { 
                        get 
                        {
                            QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventText val) 
                    { 
                        this.eventText = val;
                    }
                    
                    public QuickFix.Fields.EventText get(QuickFix.Fields.EventText val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventText val) 
                    { 
                        return isSetEventText();
                    }
                    
                    public bool isSetEventText() 
                    { 
                        return isSetField(Tags.EventText);
                    }
                    public QuickFix.Fields.EventTime eventTime
                    { 
                        get 
                        {
                            QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventTime val) 
                    { 
                        this.eventTime = val;
                    }
                    
                    public QuickFix.Fields.EventTime get(QuickFix.Fields.EventTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventTime val) 
                    { 
                        return isSetEventTime();
                    }
                    
                    public bool isSetEventTime() 
                    { 
                        return isSetField(Tags.EventTime);
                    }
                
                }
                public class NoInstrumentParties : Group
                {
                    public NoInstrumentParties() 
                      :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                                    public QuickFix.Fields.InstrumentPartyID instrumentPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        this.instrumentPartyID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyID get(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        return isSetInstrumentPartyID();
                    }
                    
                    public bool isSetInstrumentPartyID() 
                    { 
                        return isSetField(Tags.InstrumentPartyID);
                    }
                    public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        this.instrumentPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyIDSource get(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        return isSetInstrumentPartyIDSource();
                    }
                    
                    public bool isSetInstrumentPartyIDSource() 
                    { 
                        return isSetField(Tags.InstrumentPartyIDSource);
                    }
                    public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        this.instrumentPartyRole = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyRole get(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        return isSetInstrumentPartyRole();
                    }
                    
                    public bool isSetInstrumentPartyRole() 
                    { 
                        return isSetField(Tags.InstrumentPartyRole);
                    }
                    public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        this.noInstrumentPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoInstrumentPartySubIDs get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        return isSetNoInstrumentPartySubIDs();
                    }
                    
                    public bool isSetNoInstrumentPartySubIDs() 
                    { 
                        return isSetField(Tags.NoInstrumentPartySubIDs);
                    }
                                    public class NoInstrumentPartySubIDs : Group
                    {
                        public NoInstrumentPartySubIDs() 
                          :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                            public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            this.instrumentPartySubID = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubID get(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            return isSetInstrumentPartySubID();
                        }
                        
                        public bool isSetInstrumentPartySubID() 
                        { 
                            return isSetField(Tags.InstrumentPartySubID);
                        }
                        public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            this.instrumentPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubIDType get(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            return isSetInstrumentPartySubIDType();
                        }
                        
                        public bool isSetInstrumentPartySubIDType() 
                        { 
                            return isSetField(Tags.InstrumentPartySubIDType);
                        }
                    
                    }
                }
                public class NoComplexEvents : Group
                {
                    public NoComplexEvents() 
                      :base( Tags.NoComplexEvents, Tags.ComplexEventType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};
                                    public QuickFix.Fields.ComplexEventType complexEventType
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventType val = new QuickFix.Fields.ComplexEventType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexEventType val) 
                    { 
                        this.complexEventType = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventType get(QuickFix.Fields.ComplexEventType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexEventType val) 
                    { 
                        return isSetComplexEventType();
                    }
                    
                    public bool isSetComplexEventType() 
                    { 
                        return isSetField(Tags.ComplexEventType);
                    }
                    public QuickFix.Fields.ComplexOptPayoutAmount complexOptPayoutAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexOptPayoutAmount val = new QuickFix.Fields.ComplexOptPayoutAmount();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexOptPayoutAmount val) 
                    { 
                        this.complexOptPayoutAmount = val;
                    }
                    
                    public QuickFix.Fields.ComplexOptPayoutAmount get(QuickFix.Fields.ComplexOptPayoutAmount val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexOptPayoutAmount val) 
                    { 
                        return isSetComplexOptPayoutAmount();
                    }
                    
                    public bool isSetComplexOptPayoutAmount() 
                    { 
                        return isSetField(Tags.ComplexOptPayoutAmount);
                    }
                    public QuickFix.Fields.ComplexEventPrice complexEventPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventPrice val = new QuickFix.Fields.ComplexEventPrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexEventPrice val) 
                    { 
                        this.complexEventPrice = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPrice get(QuickFix.Fields.ComplexEventPrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexEventPrice val) 
                    { 
                        return isSetComplexEventPrice();
                    }
                    
                    public bool isSetComplexEventPrice() 
                    { 
                        return isSetField(Tags.ComplexEventPrice);
                    }
                    public QuickFix.Fields.ComplexEventPriceBoundaryMethod complexEventPriceBoundaryMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventPriceBoundaryMethod val = new QuickFix.Fields.ComplexEventPriceBoundaryMethod();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                    { 
                        this.complexEventPriceBoundaryMethod = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceBoundaryMethod get(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                    { 
                        return isSetComplexEventPriceBoundaryMethod();
                    }
                    
                    public bool isSetComplexEventPriceBoundaryMethod() 
                    { 
                        return isSetField(Tags.ComplexEventPriceBoundaryMethod);
                    }
                    public QuickFix.Fields.ComplexEventPriceBoundaryPrecision complexEventPriceBoundaryPrecision
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventPriceBoundaryPrecision val = new QuickFix.Fields.ComplexEventPriceBoundaryPrecision();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                    { 
                        this.complexEventPriceBoundaryPrecision = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceBoundaryPrecision get(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                    { 
                        return isSetComplexEventPriceBoundaryPrecision();
                    }
                    
                    public bool isSetComplexEventPriceBoundaryPrecision() 
                    { 
                        return isSetField(Tags.ComplexEventPriceBoundaryPrecision);
                    }
                    public QuickFix.Fields.ComplexEventPriceTimeType complexEventPriceTimeType
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventPriceTimeType val = new QuickFix.Fields.ComplexEventPriceTimeType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexEventPriceTimeType val) 
                    { 
                        this.complexEventPriceTimeType = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventPriceTimeType get(QuickFix.Fields.ComplexEventPriceTimeType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexEventPriceTimeType val) 
                    { 
                        return isSetComplexEventPriceTimeType();
                    }
                    
                    public bool isSetComplexEventPriceTimeType() 
                    { 
                        return isSetField(Tags.ComplexEventPriceTimeType);
                    }
                    public QuickFix.Fields.ComplexEventCondition complexEventCondition
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventCondition val = new QuickFix.Fields.ComplexEventCondition();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ComplexEventCondition val) 
                    { 
                        this.complexEventCondition = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventCondition get(QuickFix.Fields.ComplexEventCondition val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ComplexEventCondition val) 
                    { 
                        return isSetComplexEventCondition();
                    }
                    
                    public bool isSetComplexEventCondition() 
                    { 
                        return isSetField(Tags.ComplexEventCondition);
                    }
                    public QuickFix.Fields.NoComplexEventDates noComplexEventDates
                    { 
                        get 
                        {
                            QuickFix.Fields.NoComplexEventDates val = new QuickFix.Fields.NoComplexEventDates();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoComplexEventDates val) 
                    { 
                        this.noComplexEventDates = val;
                    }
                    
                    public QuickFix.Fields.NoComplexEventDates get(QuickFix.Fields.NoComplexEventDates val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoComplexEventDates val) 
                    { 
                        return isSetNoComplexEventDates();
                    }
                    
                    public bool isSetNoComplexEventDates() 
                    { 
                        return isSetField(Tags.NoComplexEventDates);
                    }
                                    public class NoComplexEventDates : Group
                    {
                        public NoComplexEventDates() 
                          :base( Tags.NoComplexEventDates, Tags.ComplexEventStartDate, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};
                                            public QuickFix.Fields.ComplexEventStartDate complexEventStartDate
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventStartDate val = new QuickFix.Fields.ComplexEventStartDate();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.ComplexEventStartDate val) 
                        { 
                            this.complexEventStartDate = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventStartDate get(QuickFix.Fields.ComplexEventStartDate val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.ComplexEventStartDate val) 
                        { 
                            return isSetComplexEventStartDate();
                        }
                        
                        public bool isSetComplexEventStartDate() 
                        { 
                            return isSetField(Tags.ComplexEventStartDate);
                        }
                        public QuickFix.Fields.ComplexEventEndDate complexEventEndDate
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventEndDate val = new QuickFix.Fields.ComplexEventEndDate();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.ComplexEventEndDate val) 
                        { 
                            this.complexEventEndDate = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventEndDate get(QuickFix.Fields.ComplexEventEndDate val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.ComplexEventEndDate val) 
                        { 
                            return isSetComplexEventEndDate();
                        }
                        
                        public bool isSetComplexEventEndDate() 
                        { 
                            return isSetField(Tags.ComplexEventEndDate);
                        }
                        public QuickFix.Fields.NoComplexEventTimes noComplexEventTimes
                        { 
                            get 
                            {
                                QuickFix.Fields.NoComplexEventTimes val = new QuickFix.Fields.NoComplexEventTimes();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoComplexEventTimes val) 
                        { 
                            this.noComplexEventTimes = val;
                        }
                        
                        public QuickFix.Fields.NoComplexEventTimes get(QuickFix.Fields.NoComplexEventTimes val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoComplexEventTimes val) 
                        { 
                            return isSetNoComplexEventTimes();
                        }
                        
                        public bool isSetNoComplexEventTimes() 
                        { 
                            return isSetField(Tags.NoComplexEventTimes);
                        }
                                            public class NoComplexEventTimes : Group
                        {
                            public NoComplexEventTimes() 
                              :base( Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};
                                                    public QuickFix.Fields.ComplexEventStartTime complexEventStartTime
                            { 
                                get 
                                {
                                    QuickFix.Fields.ComplexEventStartTime val = new QuickFix.Fields.ComplexEventStartTime();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.ComplexEventStartTime val) 
                            { 
                                this.complexEventStartTime = val;
                            }
                            
                            public QuickFix.Fields.ComplexEventStartTime get(QuickFix.Fields.ComplexEventStartTime val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.ComplexEventStartTime val) 
                            { 
                                return isSetComplexEventStartTime();
                            }
                            
                            public bool isSetComplexEventStartTime() 
                            { 
                                return isSetField(Tags.ComplexEventStartTime);
                            }
                            public QuickFix.Fields.ComplexEventEndTime complexEventEndTime
                            { 
                                get 
                                {
                                    QuickFix.Fields.ComplexEventEndTime val = new QuickFix.Fields.ComplexEventEndTime();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.ComplexEventEndTime val) 
                            { 
                                this.complexEventEndTime = val;
                            }
                            
                            public QuickFix.Fields.ComplexEventEndTime get(QuickFix.Fields.ComplexEventEndTime val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.ComplexEventEndTime val) 
                            { 
                                return isSetComplexEventEndTime();
                            }
                            
                            public bool isSetComplexEventEndTime() 
                            { 
                                return isSetField(Tags.ComplexEventEndTime);
                            }
                        
                        }
                    }
                }
                public class NoUnderlyings : Group
                {
                    public NoUnderlyings() 
                      :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, 0};
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
                    public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        this.underlyingSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityIDSource get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        return isSetUnderlyingSecurityIDSource();
                    }
                    
                    public bool isSetUnderlyingSecurityIDSource() 
                    { 
                        return isSetField(Tags.UnderlyingSecurityIDSource);
                    }
                    public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        this.noUnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingSecurityAltID get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        return isSetNoUnderlyingSecurityAltID();
                    }
                    
                    public bool isSetNoUnderlyingSecurityAltID() 
                    { 
                        return isSetField(Tags.NoUnderlyingSecurityAltID);
                    }
                    public QuickFix.Fields.UnderlyingProduct underlyingProduct
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        this.underlyingProduct = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingProduct get(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        return isSetUnderlyingProduct();
                    }
                    
                    public bool isSetUnderlyingProduct() 
                    { 
                        return isSetField(Tags.UnderlyingProduct);
                    }
                    public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        this.underlyingCFICode = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCFICode get(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        return isSetUnderlyingCFICode();
                    }
                    
                    public bool isSetUnderlyingCFICode() 
                    { 
                        return isSetField(Tags.UnderlyingCFICode);
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
                    public QuickFix.Fields.UnderlyingSecuritySubType underlyingSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        this.underlyingSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecuritySubType get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        return isSetUnderlyingSecuritySubType();
                    }
                    
                    public bool isSetUnderlyingSecuritySubType() 
                    { 
                        return isSetField(Tags.UnderlyingSecuritySubType);
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
                    public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        this.underlyingMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityDate get(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        return isSetUnderlyingMaturityDate();
                    }
                    
                    public bool isSetUnderlyingMaturityDate() 
                    { 
                        return isSetField(Tags.UnderlyingMaturityDate);
                    }
                    public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        this.underlyingCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponPaymentDate get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        return isSetUnderlyingCouponPaymentDate();
                    }
                    
                    public bool isSetUnderlyingCouponPaymentDate() 
                    { 
                        return isSetField(Tags.UnderlyingCouponPaymentDate);
                    }
                    public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        this.underlyingIssueDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingIssueDate get(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        return isSetUnderlyingIssueDate();
                    }
                    
                    public bool isSetUnderlyingIssueDate() 
                    { 
                        return isSetField(Tags.UnderlyingIssueDate);
                    }
                    public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        this.underlyingRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepoCollateralSecurityType get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        return isSetUnderlyingRepoCollateralSecurityType();
                    }
                    
                    public bool isSetUnderlyingRepoCollateralSecurityType() 
                    { 
                        return isSetField(Tags.UnderlyingRepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        this.underlyingRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseTerm get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        return isSetUnderlyingRepurchaseTerm();
                    }
                    
                    public bool isSetUnderlyingRepurchaseTerm() 
                    { 
                        return isSetField(Tags.UnderlyingRepurchaseTerm);
                    }
                    public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        this.underlyingRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseRate get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        return isSetUnderlyingRepurchaseRate();
                    }
                    
                    public bool isSetUnderlyingRepurchaseRate() 
                    { 
                        return isSetField(Tags.UnderlyingRepurchaseRate);
                    }
                    public QuickFix.Fields.UnderlyingFactor underlyingFactor
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        this.underlyingFactor = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFactor get(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        return isSetUnderlyingFactor();
                    }
                    
                    public bool isSetUnderlyingFactor() 
                    { 
                        return isSetField(Tags.UnderlyingFactor);
                    }
                    public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        this.underlyingCreditRating = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCreditRating get(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        return isSetUnderlyingCreditRating();
                    }
                    
                    public bool isSetUnderlyingCreditRating() 
                    { 
                        return isSetField(Tags.UnderlyingCreditRating);
                    }
                    public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        this.underlyingInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrRegistry get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        return isSetUnderlyingInstrRegistry();
                    }
                    
                    public bool isSetUnderlyingInstrRegistry() 
                    { 
                        return isSetField(Tags.UnderlyingInstrRegistry);
                    }
                    public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        this.underlyingCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCountryOfIssue get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        return isSetUnderlyingCountryOfIssue();
                    }
                    
                    public bool isSetUnderlyingCountryOfIssue() 
                    { 
                        return isSetField(Tags.UnderlyingCountryOfIssue);
                    }
                    public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        this.underlyingStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        return isSetUnderlyingStateOrProvinceOfIssue();
                    }
                    
                    public bool isSetUnderlyingStateOrProvinceOfIssue() 
                    { 
                        return isSetField(Tags.UnderlyingStateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        this.underlyingLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLocaleOfIssue get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        return isSetUnderlyingLocaleOfIssue();
                    }
                    
                    public bool isSetUnderlyingLocaleOfIssue() 
                    { 
                        return isSetField(Tags.UnderlyingLocaleOfIssue);
                    }
                    public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        this.underlyingRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRedemptionDate get(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        return isSetUnderlyingRedemptionDate();
                    }
                    
                    public bool isSetUnderlyingRedemptionDate() 
                    { 
                        return isSetField(Tags.UnderlyingRedemptionDate);
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
                    public QuickFix.Fields.UnderlyingStrikeCurrency underlyingStrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        this.underlyingStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikeCurrency get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        return isSetUnderlyingStrikeCurrency();
                    }
                    
                    public bool isSetUnderlyingStrikeCurrency() 
                    { 
                        return isSetField(Tags.UnderlyingStrikeCurrency);
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
                    public QuickFix.Fields.UnderlyingCPProgram underlyingCPProgram
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        this.underlyingCPProgram = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCPProgram get(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        return isSetUnderlyingCPProgram();
                    }
                    
                    public bool isSetUnderlyingCPProgram() 
                    { 
                        return isSetField(Tags.UnderlyingCPProgram);
                    }
                    public QuickFix.Fields.UnderlyingCPRegType underlyingCPRegType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        this.underlyingCPRegType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCPRegType get(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        return isSetUnderlyingCPRegType();
                    }
                    
                    public bool isSetUnderlyingCPRegType() 
                    { 
                        return isSetField(Tags.UnderlyingCPRegType);
                    }
                    public QuickFix.Fields.UnderlyingCurrency underlyingCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        this.underlyingCurrency = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrency get(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        return isSetUnderlyingCurrency();
                    }
                    
                    public bool isSetUnderlyingCurrency() 
                    { 
                        return isSetField(Tags.UnderlyingCurrency);
                    }
                    public QuickFix.Fields.UnderlyingQty underlyingQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        this.underlyingQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingQty get(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        return isSetUnderlyingQty();
                    }
                    
                    public bool isSetUnderlyingQty() 
                    { 
                        return isSetField(Tags.UnderlyingQty);
                    }
                    public QuickFix.Fields.UnderlyingPx underlyingPx
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        this.underlyingPx = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPx get(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        return isSetUnderlyingPx();
                    }
                    
                    public bool isSetUnderlyingPx() 
                    { 
                        return isSetField(Tags.UnderlyingPx);
                    }
                    public QuickFix.Fields.UnderlyingDirtyPrice underlyingDirtyPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        this.underlyingDirtyPrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingDirtyPrice get(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        return isSetUnderlyingDirtyPrice();
                    }
                    
                    public bool isSetUnderlyingDirtyPrice() 
                    { 
                        return isSetField(Tags.UnderlyingDirtyPrice);
                    }
                    public QuickFix.Fields.UnderlyingEndPrice underlyingEndPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        this.underlyingEndPrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingEndPrice get(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        return isSetUnderlyingEndPrice();
                    }
                    
                    public bool isSetUnderlyingEndPrice() 
                    { 
                        return isSetField(Tags.UnderlyingEndPrice);
                    }
                    public QuickFix.Fields.UnderlyingStartValue underlyingStartValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        this.underlyingStartValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStartValue get(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        return isSetUnderlyingStartValue();
                    }
                    
                    public bool isSetUnderlyingStartValue() 
                    { 
                        return isSetField(Tags.UnderlyingStartValue);
                    }
                    public QuickFix.Fields.UnderlyingCurrentValue underlyingCurrentValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        this.underlyingCurrentValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrentValue get(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        return isSetUnderlyingCurrentValue();
                    }
                    
                    public bool isSetUnderlyingCurrentValue() 
                    { 
                        return isSetField(Tags.UnderlyingCurrentValue);
                    }
                    public QuickFix.Fields.UnderlyingEndValue underlyingEndValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        this.underlyingEndValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingEndValue get(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        return isSetUnderlyingEndValue();
                    }
                    
                    public bool isSetUnderlyingEndValue() 
                    { 
                        return isSetField(Tags.UnderlyingEndValue);
                    }
                    public QuickFix.Fields.NoUnderlyingStips noUnderlyingStips
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        this.noUnderlyingStips = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingStips get(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        return isSetNoUnderlyingStips();
                    }
                    
                    public bool isSetNoUnderlyingStips() 
                    { 
                        return isSetField(Tags.NoUnderlyingStips);
                    }
                    public QuickFix.Fields.UnderlyingAllocationPercent underlyingAllocationPercent
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        this.underlyingAllocationPercent = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAllocationPercent get(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        return isSetUnderlyingAllocationPercent();
                    }
                    
                    public bool isSetUnderlyingAllocationPercent() 
                    { 
                        return isSetField(Tags.UnderlyingAllocationPercent);
                    }
                    public QuickFix.Fields.UnderlyingSettlementType underlyingSettlementType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        this.underlyingSettlementType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlementType get(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        return isSetUnderlyingSettlementType();
                    }
                    
                    public bool isSetUnderlyingSettlementType() 
                    { 
                        return isSetField(Tags.UnderlyingSettlementType);
                    }
                    public QuickFix.Fields.UnderlyingCashAmount underlyingCashAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        this.underlyingCashAmount = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCashAmount get(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        return isSetUnderlyingCashAmount();
                    }
                    
                    public bool isSetUnderlyingCashAmount() 
                    { 
                        return isSetField(Tags.UnderlyingCashAmount);
                    }
                    public QuickFix.Fields.UnderlyingCashType underlyingCashType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        this.underlyingCashType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCashType get(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        return isSetUnderlyingCashType();
                    }
                    
                    public bool isSetUnderlyingCashType() 
                    { 
                        return isSetField(Tags.UnderlyingCashType);
                    }
                    public QuickFix.Fields.UnderlyingUnitOfMeasure underlyingUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        this.underlyingUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasure get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        return isSetUnderlyingUnitOfMeasure();
                    }
                    
                    public bool isSetUnderlyingUnitOfMeasure() 
                    { 
                        return isSetField(Tags.UnderlyingUnitOfMeasure);
                    }
                    public QuickFix.Fields.UnderlyingTimeUnit underlyingTimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        this.underlyingTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingTimeUnit get(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        return isSetUnderlyingTimeUnit();
                    }
                    
                    public bool isSetUnderlyingTimeUnit() 
                    { 
                        return isSetField(Tags.UnderlyingTimeUnit);
                    }
                    public QuickFix.Fields.UnderlyingCapValue underlyingCapValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        this.underlyingCapValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCapValue get(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        return isSetUnderlyingCapValue();
                    }
                    
                    public bool isSetUnderlyingCapValue() 
                    { 
                        return isSetField(Tags.UnderlyingCapValue);
                    }
                    public QuickFix.Fields.NoUndlyInstrumentParties noUndlyInstrumentParties
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        this.noUndlyInstrumentParties = val;
                    }
                    
                    public QuickFix.Fields.NoUndlyInstrumentParties get(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        return isSetNoUndlyInstrumentParties();
                    }
                    
                    public bool isSetNoUndlyInstrumentParties() 
                    { 
                        return isSetField(Tags.NoUndlyInstrumentParties);
                    }
                    public QuickFix.Fields.UnderlyingSettlMethod underlyingSettlMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        this.underlyingSettlMethod = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlMethod get(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        return isSetUnderlyingSettlMethod();
                    }
                    
                    public bool isSetUnderlyingSettlMethod() 
                    { 
                        return isSetField(Tags.UnderlyingSettlMethod);
                    }
                    public QuickFix.Fields.UnderlyingAdjustedQuantity underlyingAdjustedQuantity
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        this.underlyingAdjustedQuantity = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAdjustedQuantity get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        return isSetUnderlyingAdjustedQuantity();
                    }
                    
                    public bool isSetUnderlyingAdjustedQuantity() 
                    { 
                        return isSetField(Tags.UnderlyingAdjustedQuantity);
                    }
                    public QuickFix.Fields.UnderlyingFXRate underlyingFXRate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        this.underlyingFXRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRate get(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        return isSetUnderlyingFXRate();
                    }
                    
                    public bool isSetUnderlyingFXRate() 
                    { 
                        return isSetField(Tags.UnderlyingFXRate);
                    }
                    public QuickFix.Fields.UnderlyingFXRateCalc underlyingFXRateCalc
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        this.underlyingFXRateCalc = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRateCalc get(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        return isSetUnderlyingFXRateCalc();
                    }
                    
                    public bool isSetUnderlyingFXRateCalc() 
                    { 
                        return isSetField(Tags.UnderlyingFXRateCalc);
                    }
                    public QuickFix.Fields.UnderlyingMaturityTime underlyingMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        this.underlyingMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityTime get(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        return isSetUnderlyingMaturityTime();
                    }
                    
                    public bool isSetUnderlyingMaturityTime() 
                    { 
                        return isSetField(Tags.UnderlyingMaturityTime);
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
                    public QuickFix.Fields.UnderlyingExerciseStyle underlyingExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        this.underlyingExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingExerciseStyle get(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        return isSetUnderlyingExerciseStyle();
                    }
                    
                    public bool isSetUnderlyingExerciseStyle() 
                    { 
                        return isSetField(Tags.UnderlyingExerciseStyle);
                    }
                    public QuickFix.Fields.UnderlyingUnitOfMeasureQty underlyingUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        this.underlyingUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasureQty get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        return isSetUnderlyingUnitOfMeasureQty();
                    }
                    
                    public bool isSetUnderlyingUnitOfMeasureQty() 
                    { 
                        return isSetField(Tags.UnderlyingUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasure underlyingPriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        this.underlyingPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasure get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        return isSetUnderlyingPriceUnitOfMeasure();
                    }
                    
                    public bool isSetUnderlyingPriceUnitOfMeasure() 
                    { 
                        return isSetField(Tags.UnderlyingPriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty underlyingPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        this.underlyingPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        return isSetUnderlyingPriceUnitOfMeasureQty();
                    }
                    
                    public bool isSetUnderlyingPriceUnitOfMeasureQty() 
                    { 
                        return isSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.UnderlyingContractMultiplierUnit underlyingContractMultiplierUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingContractMultiplierUnit val = new QuickFix.Fields.UnderlyingContractMultiplierUnit();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        this.underlyingContractMultiplierUnit = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplierUnit get(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        return isSetUnderlyingContractMultiplierUnit();
                    }
                    
                    public bool isSetUnderlyingContractMultiplierUnit() 
                    { 
                        return isSetField(Tags.UnderlyingContractMultiplierUnit);
                    }
                    public QuickFix.Fields.UnderlyingFlowScheduleType underlyingFlowScheduleType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFlowScheduleType val = new QuickFix.Fields.UnderlyingFlowScheduleType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        this.underlyingFlowScheduleType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFlowScheduleType get(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        return isSetUnderlyingFlowScheduleType();
                    }
                    
                    public bool isSetUnderlyingFlowScheduleType() 
                    { 
                        return isSetField(Tags.UnderlyingFlowScheduleType);
                    }
                    public QuickFix.Fields.UnderlyingRestructuringType underlyingRestructuringType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRestructuringType val = new QuickFix.Fields.UnderlyingRestructuringType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        this.underlyingRestructuringType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRestructuringType get(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        return isSetUnderlyingRestructuringType();
                    }
                    
                    public bool isSetUnderlyingRestructuringType() 
                    { 
                        return isSetField(Tags.UnderlyingRestructuringType);
                    }
                    public QuickFix.Fields.UnderlyingSeniority underlyingSeniority
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSeniority val = new QuickFix.Fields.UnderlyingSeniority();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        this.underlyingSeniority = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSeniority get(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        return isSetUnderlyingSeniority();
                    }
                    
                    public bool isSetUnderlyingSeniority() 
                    { 
                        return isSetField(Tags.UnderlyingSeniority);
                    }
                    public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding underlyingNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingNotionalPercentageOutstanding();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        this.underlyingNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding get(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        return isSetUnderlyingNotionalPercentageOutstanding();
                    }
                    
                    public bool isSetUnderlyingNotionalPercentageOutstanding() 
                    { 
                        return isSetField(Tags.UnderlyingNotionalPercentageOutstanding);
                    }
                    public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding underlyingOriginalNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        this.underlyingOriginalNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding get(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        return isSetUnderlyingOriginalNotionalPercentageOutstanding();
                    }
                    
                    public bool isSetUnderlyingOriginalNotionalPercentageOutstanding() 
                    { 
                        return isSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding);
                    }
                    public QuickFix.Fields.UnderlyingAttachmentPoint underlyingAttachmentPoint
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingAttachmentPoint val = new QuickFix.Fields.UnderlyingAttachmentPoint();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        this.underlyingAttachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAttachmentPoint get(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        return isSetUnderlyingAttachmentPoint();
                    }
                    
                    public bool isSetUnderlyingAttachmentPoint() 
                    { 
                        return isSetField(Tags.UnderlyingAttachmentPoint);
                    }
                    public QuickFix.Fields.UnderlyingDetachmentPoint underlyingDetachmentPoint
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingDetachmentPoint val = new QuickFix.Fields.UnderlyingDetachmentPoint();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        this.underlyingDetachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingDetachmentPoint get(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        return isSetUnderlyingDetachmentPoint();
                    }
                    
                    public bool isSetUnderlyingDetachmentPoint() 
                    { 
                        return isSetField(Tags.UnderlyingDetachmentPoint);
                    }
                                    public class NoUnderlyingSecurityAltID : Group
                    {
                        public NoUnderlyingSecurityAltID() 
                          :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                                            public QuickFix.Fields.UnderlyingSecurityAltID underlyingSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            this.underlyingSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltID get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            return isSetUnderlyingSecurityAltID();
                        }
                        
                        public bool isSetUnderlyingSecurityAltID() 
                        { 
                            return isSetField(Tags.UnderlyingSecurityAltID);
                        }
                        public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            this.underlyingSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltIDSource get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            return isSetUnderlyingSecurityAltIDSource();
                        }
                        
                        public bool isSetUnderlyingSecurityAltIDSource() 
                        { 
                            return isSetField(Tags.UnderlyingSecurityAltIDSource);
                        }
                    
                    }
                    public class NoUnderlyingStips : Group
                    {
                        public NoUnderlyingStips() 
                          :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                                            public QuickFix.Fields.UnderlyingStipType underlyingStipType
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            this.underlyingStipType = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingStipType get(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            return isSetUnderlyingStipType();
                        }
                        
                        public bool isSetUnderlyingStipType() 
                        { 
                            return isSetField(Tags.UnderlyingStipType);
                        }
                        public QuickFix.Fields.UnderlyingStipValue underlyingStipValue
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            this.underlyingStipValue = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingStipValue get(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            return isSetUnderlyingStipValue();
                        }
                        
                        public bool isSetUnderlyingStipValue() 
                        { 
                            return isSetField(Tags.UnderlyingStipValue);
                        }
                    
                    }
                    public class NoUndlyInstrumentParties : Group
                    {
                        public NoUndlyInstrumentParties() 
                          :base( Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                                            public QuickFix.Fields.UnderlyingInstrumentPartyID underlyingInstrumentPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartyID val = new QuickFix.Fields.UnderlyingInstrumentPartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            this.underlyingInstrumentPartyID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyID get(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            return isSetUnderlyingInstrumentPartyID();
                        }
                        
                        public bool isSetUnderlyingInstrumentPartyID() 
                        { 
                            return isSetField(Tags.UnderlyingInstrumentPartyID);
                        }
                        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource underlyingInstrumentPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartyIDSource val = new QuickFix.Fields.UnderlyingInstrumentPartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            this.underlyingInstrumentPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource get(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            return isSetUnderlyingInstrumentPartyIDSource();
                        }
                        
                        public bool isSetUnderlyingInstrumentPartyIDSource() 
                        { 
                            return isSetField(Tags.UnderlyingInstrumentPartyIDSource);
                        }
                        public QuickFix.Fields.UnderlyingInstrumentPartyRole underlyingInstrumentPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartyRole val = new QuickFix.Fields.UnderlyingInstrumentPartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            this.underlyingInstrumentPartyRole = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyRole get(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            return isSetUnderlyingInstrumentPartyRole();
                        }
                        
                        public bool isSetUnderlyingInstrumentPartyRole() 
                        { 
                            return isSetField(Tags.UnderlyingInstrumentPartyRole);
                        }
                        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs noUndlyInstrumentPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            this.noUndlyInstrumentPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            return isSetNoUndlyInstrumentPartySubIDs();
                        }
                        
                        public bool isSetNoUndlyInstrumentPartySubIDs() 
                        { 
                            return isSetField(Tags.NoUndlyInstrumentPartySubIDs);
                        }
                                            public class NoUndlyInstrumentPartySubIDs : Group
                        {
                            public NoUndlyInstrumentPartySubIDs() 
                              :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};
                                                    public QuickFix.Fields.UnderlyingInstrumentPartySubID underlyingInstrumentPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.UnderlyingInstrumentPartySubID val = new QuickFix.Fields.UnderlyingInstrumentPartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                this.underlyingInstrumentPartySubID = val;
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubID get(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                return isSetUnderlyingInstrumentPartySubID();
                            }
                            
                            public bool isSetUnderlyingInstrumentPartySubID() 
                            { 
                                return isSetField(Tags.UnderlyingInstrumentPartySubID);
                            }
                            public QuickFix.Fields.UnderlyingInstrumentPartySubIDType underlyingInstrumentPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.UnderlyingInstrumentPartySubIDType val = new QuickFix.Fields.UnderlyingInstrumentPartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                this.underlyingInstrumentPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubIDType get(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                return isSetUnderlyingInstrumentPartySubIDType();
                            }
                            
                            public bool isSetUnderlyingInstrumentPartySubIDType() 
                            { 
                                return isSetField(Tags.UnderlyingInstrumentPartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoStipulations : Group
                {
                    public NoStipulations() 
                      :base( Tags.NoStipulations, Tags.StipulationType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};
                                    public QuickFix.Fields.StipulationType stipulationType
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationType val = new QuickFix.Fields.StipulationType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StipulationType val) 
                    { 
                        this.stipulationType = val;
                    }
                    
                    public QuickFix.Fields.StipulationType get(QuickFix.Fields.StipulationType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StipulationType val) 
                    { 
                        return isSetStipulationType();
                    }
                    
                    public bool isSetStipulationType() 
                    { 
                        return isSetField(Tags.StipulationType);
                    }
                    public QuickFix.Fields.StipulationValue stipulationValue
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationValue val = new QuickFix.Fields.StipulationValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StipulationValue val) 
                    { 
                        this.stipulationValue = val;
                    }
                    
                    public QuickFix.Fields.StipulationValue get(QuickFix.Fields.StipulationValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StipulationValue val) 
                    { 
                        return isSetStipulationValue();
                    }
                    
                    public bool isSetStipulationValue() 
                    { 
                        return isSetField(Tags.StipulationValue);
                    }
                
                }
                public class NoStrategyParameters : Group
                {
                    public NoStrategyParameters() 
                      :base( Tags.NoStrategyParameters, Tags.StrategyParameterName, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0};
                                    public QuickFix.Fields.StrategyParameterName strategyParameterName
                    { 
                        get 
                        {
                            QuickFix.Fields.StrategyParameterName val = new QuickFix.Fields.StrategyParameterName();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StrategyParameterName val) 
                    { 
                        this.strategyParameterName = val;
                    }
                    
                    public QuickFix.Fields.StrategyParameterName get(QuickFix.Fields.StrategyParameterName val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StrategyParameterName val) 
                    { 
                        return isSetStrategyParameterName();
                    }
                    
                    public bool isSetStrategyParameterName() 
                    { 
                        return isSetField(Tags.StrategyParameterName);
                    }
                    public QuickFix.Fields.StrategyParameterType strategyParameterType
                    { 
                        get 
                        {
                            QuickFix.Fields.StrategyParameterType val = new QuickFix.Fields.StrategyParameterType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StrategyParameterType val) 
                    { 
                        this.strategyParameterType = val;
                    }
                    
                    public QuickFix.Fields.StrategyParameterType get(QuickFix.Fields.StrategyParameterType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StrategyParameterType val) 
                    { 
                        return isSetStrategyParameterType();
                    }
                    
                    public bool isSetStrategyParameterType() 
                    { 
                        return isSetField(Tags.StrategyParameterType);
                    }
                    public QuickFix.Fields.StrategyParameterValue strategyParameterValue
                    { 
                        get 
                        {
                            QuickFix.Fields.StrategyParameterValue val = new QuickFix.Fields.StrategyParameterValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StrategyParameterValue val) 
                    { 
                        this.strategyParameterValue = val;
                    }
                    
                    public QuickFix.Fields.StrategyParameterValue get(QuickFix.Fields.StrategyParameterValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StrategyParameterValue val) 
                    { 
                        return isSetStrategyParameterValue();
                    }
                    
                    public bool isSetStrategyParameterValue() 
                    { 
                        return isSetField(Tags.StrategyParameterValue);
                    }
                
                }
            }
            public class NoRootPartyIDs : Group
            {
                public NoRootPartyIDs() 
                  :base( Tags.NoRootPartyIDs, Tags.RootPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RootPartyID, Tags.RootPartyIDSource, Tags.RootPartyRole, Tags.NoRootPartySubIDs, 0};
                            public QuickFix.Fields.RootPartyID rootPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyID val = new QuickFix.Fields.RootPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RootPartyID val) 
                { 
                    this.rootPartyID = val;
                }
                
                public QuickFix.Fields.RootPartyID get(QuickFix.Fields.RootPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RootPartyID val) 
                { 
                    return isSetRootPartyID();
                }
                
                public bool isSetRootPartyID() 
                { 
                    return isSetField(Tags.RootPartyID);
                }
                public QuickFix.Fields.RootPartyIDSource rootPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyIDSource val = new QuickFix.Fields.RootPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    this.rootPartyIDSource = val;
                }
                
                public QuickFix.Fields.RootPartyIDSource get(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    return isSetRootPartyIDSource();
                }
                
                public bool isSetRootPartyIDSource() 
                { 
                    return isSetField(Tags.RootPartyIDSource);
                }
                public QuickFix.Fields.RootPartyRole rootPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyRole val = new QuickFix.Fields.RootPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RootPartyRole val) 
                { 
                    this.rootPartyRole = val;
                }
                
                public QuickFix.Fields.RootPartyRole get(QuickFix.Fields.RootPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RootPartyRole val) 
                { 
                    return isSetRootPartyRole();
                }
                
                public bool isSetRootPartyRole() 
                { 
                    return isSetField(Tags.RootPartyRole);
                }
                public QuickFix.Fields.NoRootPartySubIDs noRootPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoRootPartySubIDs val = new QuickFix.Fields.NoRootPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    this.noRootPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoRootPartySubIDs get(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    return isSetNoRootPartySubIDs();
                }
                
                public bool isSetNoRootPartySubIDs() 
                { 
                    return isSetField(Tags.NoRootPartySubIDs);
                }
                            public class NoRootPartySubIDs : Group
                {
                    public NoRootPartySubIDs() 
                      :base( Tags.NoRootPartySubIDs, Tags.RootPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.RootPartySubID, Tags.RootPartySubIDType, 0};
                                    public QuickFix.Fields.RootPartySubID rootPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.RootPartySubID val = new QuickFix.Fields.RootPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RootPartySubID val) 
                    { 
                        this.rootPartySubID = val;
                    }
                    
                    public QuickFix.Fields.RootPartySubID get(QuickFix.Fields.RootPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RootPartySubID val) 
                    { 
                        return isSetRootPartySubID();
                    }
                    
                    public bool isSetRootPartySubID() 
                    { 
                        return isSetField(Tags.RootPartySubID);
                    }
                    public QuickFix.Fields.RootPartySubIDType rootPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.RootPartySubIDType val = new QuickFix.Fields.RootPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        this.rootPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.RootPartySubIDType get(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        return isSetRootPartySubIDType();
                    }
                    
                    public bool isSetRootPartySubIDType() 
                    { 
                        return isSetField(Tags.RootPartySubIDType);
                    }
                
                }
            }
        }
    }
}
