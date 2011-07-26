using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class ExecutionReport : Message
        {
            public ExecutionReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("8"));
            }

            public ExecutionReport(
                    QuickFix.Fields.OrderID aOrderID,
                    QuickFix.Fields.ExecID aExecID,
                    QuickFix.Fields.ExecType aExecType,
                    QuickFix.Fields.OrdStatus aOrdStatus,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.LeavesQty aLeavesQty,
                    QuickFix.Fields.CumQty aCumQty,
                    QuickFix.Fields.AvgPx aAvgPx
                ) : this()
            {
                this.orderID = aOrderID;
                this.execID = aExecID;
                this.execType = aExecType;
                this.ordStatus = aOrdStatus;
                this.symbol = aSymbol;
                this.side = aSide;
                this.leavesQty = aLeavesQty;
                this.cumQty = aCumQty;
                this.avgPx = aAvgPx;
            }

            public QuickFix.Fields.OrderID orderID
            { 
                get 
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrderID val) 
            { 
                this.orderID = val;
            }
            
            public QuickFix.Fields.OrderID get(QuickFix.Fields.OrderID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrderID val) 
            { 
                return isSetOrderID();
            }
            
            public bool isSetOrderID() 
            { 
                return isSetField(Tags.OrderID);
            }
            public QuickFix.Fields.SecondaryOrderID secondaryOrderID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryOrderID val) 
            { 
                this.secondaryOrderID = val;
            }
            
            public QuickFix.Fields.SecondaryOrderID get(QuickFix.Fields.SecondaryOrderID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryOrderID val) 
            { 
                return isSetSecondaryOrderID();
            }
            
            public bool isSetSecondaryOrderID() 
            { 
                return isSetField(Tags.SecondaryOrderID);
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
            public QuickFix.Fields.SecondaryExecID secondaryExecID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryExecID val = new QuickFix.Fields.SecondaryExecID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecondaryExecID val) 
            { 
                this.secondaryExecID = val;
            }
            
            public QuickFix.Fields.SecondaryExecID get(QuickFix.Fields.SecondaryExecID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecondaryExecID val) 
            { 
                return isSetSecondaryExecID();
            }
            
            public bool isSetSecondaryExecID() 
            { 
                return isSetField(Tags.SecondaryExecID);
            }
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
            public QuickFix.Fields.OrigClOrdID origClOrdID
            { 
                get 
                {
                    QuickFix.Fields.OrigClOrdID val = new QuickFix.Fields.OrigClOrdID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigClOrdID val) 
            { 
                this.origClOrdID = val;
            }
            
            public QuickFix.Fields.OrigClOrdID get(QuickFix.Fields.OrigClOrdID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigClOrdID val) 
            { 
                return isSetOrigClOrdID();
            }
            
            public bool isSetOrigClOrdID() 
            { 
                return isSetField(Tags.OrigClOrdID);
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
            public QuickFix.Fields.NoContraBrokers noContraBrokers
            { 
                get 
                {
                    QuickFix.Fields.NoContraBrokers val = new QuickFix.Fields.NoContraBrokers();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoContraBrokers val) 
            { 
                this.noContraBrokers = val;
            }
            
            public QuickFix.Fields.NoContraBrokers get(QuickFix.Fields.NoContraBrokers val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoContraBrokers val) 
            { 
                return isSetNoContraBrokers();
            }
            
            public bool isSetNoContraBrokers() 
            { 
                return isSetField(Tags.NoContraBrokers);
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
            public QuickFix.Fields.CrossID crossID
            { 
                get 
                {
                    QuickFix.Fields.CrossID val = new QuickFix.Fields.CrossID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CrossID val) 
            { 
                this.crossID = val;
            }
            
            public QuickFix.Fields.CrossID get(QuickFix.Fields.CrossID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CrossID val) 
            { 
                return isSetCrossID();
            }
            
            public bool isSetCrossID() 
            { 
                return isSetField(Tags.CrossID);
            }
            public QuickFix.Fields.OrigCrossID origCrossID
            { 
                get 
                {
                    QuickFix.Fields.OrigCrossID val = new QuickFix.Fields.OrigCrossID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigCrossID val) 
            { 
                this.origCrossID = val;
            }
            
            public QuickFix.Fields.OrigCrossID get(QuickFix.Fields.OrigCrossID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigCrossID val) 
            { 
                return isSetOrigCrossID();
            }
            
            public bool isSetOrigCrossID() 
            { 
                return isSetField(Tags.OrigCrossID);
            }
            public QuickFix.Fields.CrossType crossType
            { 
                get 
                {
                    QuickFix.Fields.CrossType val = new QuickFix.Fields.CrossType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CrossType val) 
            { 
                this.crossType = val;
            }
            
            public QuickFix.Fields.CrossType get(QuickFix.Fields.CrossType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CrossType val) 
            { 
                return isSetCrossType();
            }
            
            public bool isSetCrossType() 
            { 
                return isSetField(Tags.CrossType);
            }
            public QuickFix.Fields.ExecID execID
            { 
                get 
                {
                    QuickFix.Fields.ExecID val = new QuickFix.Fields.ExecID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecID val) 
            { 
                this.execID = val;
            }
            
            public QuickFix.Fields.ExecID get(QuickFix.Fields.ExecID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecID val) 
            { 
                return isSetExecID();
            }
            
            public bool isSetExecID() 
            { 
                return isSetField(Tags.ExecID);
            }
            public QuickFix.Fields.ExecRefID execRefID
            { 
                get 
                {
                    QuickFix.Fields.ExecRefID val = new QuickFix.Fields.ExecRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecRefID val) 
            { 
                this.execRefID = val;
            }
            
            public QuickFix.Fields.ExecRefID get(QuickFix.Fields.ExecRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecRefID val) 
            { 
                return isSetExecRefID();
            }
            
            public bool isSetExecRefID() 
            { 
                return isSetField(Tags.ExecRefID);
            }
            public QuickFix.Fields.ExecType execType
            { 
                get 
                {
                    QuickFix.Fields.ExecType val = new QuickFix.Fields.ExecType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecType val) 
            { 
                this.execType = val;
            }
            
            public QuickFix.Fields.ExecType get(QuickFix.Fields.ExecType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecType val) 
            { 
                return isSetExecType();
            }
            
            public bool isSetExecType() 
            { 
                return isSetField(Tags.ExecType);
            }
            public QuickFix.Fields.OrdStatus ordStatus
            { 
                get 
                {
                    QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrdStatus val) 
            { 
                this.ordStatus = val;
            }
            
            public QuickFix.Fields.OrdStatus get(QuickFix.Fields.OrdStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrdStatus val) 
            { 
                return isSetOrdStatus();
            }
            
            public bool isSetOrdStatus() 
            { 
                return isSetField(Tags.OrdStatus);
            }
            public QuickFix.Fields.WorkingIndicator workingIndicator
            { 
                get 
                {
                    QuickFix.Fields.WorkingIndicator val = new QuickFix.Fields.WorkingIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.WorkingIndicator val) 
            { 
                this.workingIndicator = val;
            }
            
            public QuickFix.Fields.WorkingIndicator get(QuickFix.Fields.WorkingIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.WorkingIndicator val) 
            { 
                return isSetWorkingIndicator();
            }
            
            public bool isSetWorkingIndicator() 
            { 
                return isSetField(Tags.WorkingIndicator);
            }
            public QuickFix.Fields.OrdRejReason ordRejReason
            { 
                get 
                {
                    QuickFix.Fields.OrdRejReason val = new QuickFix.Fields.OrdRejReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrdRejReason val) 
            { 
                this.ordRejReason = val;
            }
            
            public QuickFix.Fields.OrdRejReason get(QuickFix.Fields.OrdRejReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrdRejReason val) 
            { 
                return isSetOrdRejReason();
            }
            
            public bool isSetOrdRejReason() 
            { 
                return isSetField(Tags.OrdRejReason);
            }
            public QuickFix.Fields.ExecRestatementReason execRestatementReason
            { 
                get 
                {
                    QuickFix.Fields.ExecRestatementReason val = new QuickFix.Fields.ExecRestatementReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecRestatementReason val) 
            { 
                this.execRestatementReason = val;
            }
            
            public QuickFix.Fields.ExecRestatementReason get(QuickFix.Fields.ExecRestatementReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecRestatementReason val) 
            { 
                return isSetExecRestatementReason();
            }
            
            public bool isSetExecRestatementReason() 
            { 
                return isSetField(Tags.ExecRestatementReason);
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
            public QuickFix.Fields.SettlmntTyp settlmntTyp
            { 
                get 
                {
                    QuickFix.Fields.SettlmntTyp val = new QuickFix.Fields.SettlmntTyp();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlmntTyp val) 
            { 
                this.settlmntTyp = val;
            }
            
            public QuickFix.Fields.SettlmntTyp get(QuickFix.Fields.SettlmntTyp val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlmntTyp val) 
            { 
                return isSetSettlmntTyp();
            }
            
            public bool isSetSettlmntTyp() 
            { 
                return isSetField(Tags.SettlmntTyp);
            }
            public QuickFix.Fields.FutSettDate futSettDate
            { 
                get 
                {
                    QuickFix.Fields.FutSettDate val = new QuickFix.Fields.FutSettDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FutSettDate val) 
            { 
                this.futSettDate = val;
            }
            
            public QuickFix.Fields.FutSettDate get(QuickFix.Fields.FutSettDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FutSettDate val) 
            { 
                return isSetFutSettDate();
            }
            
            public bool isSetFutSettDate() 
            { 
                return isSetField(Tags.FutSettDate);
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
            public QuickFix.Fields.QuantityType quantityType
            { 
                get 
                {
                    QuickFix.Fields.QuantityType val = new QuickFix.Fields.QuantityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.QuantityType val) 
            { 
                this.quantityType = val;
            }
            
            public QuickFix.Fields.QuantityType get(QuickFix.Fields.QuantityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.QuantityType val) 
            { 
                return isSetQuantityType();
            }
            
            public bool isSetQuantityType() 
            { 
                return isSetField(Tags.QuantityType);
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
            public QuickFix.Fields.PegDifference pegDifference
            { 
                get 
                {
                    QuickFix.Fields.PegDifference val = new QuickFix.Fields.PegDifference();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PegDifference val) 
            { 
                this.pegDifference = val;
            }
            
            public QuickFix.Fields.PegDifference get(QuickFix.Fields.PegDifference val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PegDifference val) 
            { 
                return isSetPegDifference();
            }
            
            public bool isSetPegDifference() 
            { 
                return isSetField(Tags.PegDifference);
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
            public QuickFix.Fields.DiscretionOffset discretionOffset
            { 
                get 
                {
                    QuickFix.Fields.DiscretionOffset val = new QuickFix.Fields.DiscretionOffset();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DiscretionOffset val) 
            { 
                this.discretionOffset = val;
            }
            
            public QuickFix.Fields.DiscretionOffset get(QuickFix.Fields.DiscretionOffset val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DiscretionOffset val) 
            { 
                return isSetDiscretionOffset();
            }
            
            public bool isSetDiscretionOffset() 
            { 
                return isSetField(Tags.DiscretionOffset);
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
            public QuickFix.Fields.Rule80A rule80A
            { 
                get 
                {
                    QuickFix.Fields.Rule80A val = new QuickFix.Fields.Rule80A();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Rule80A val) 
            { 
                this.rule80A = val;
            }
            
            public QuickFix.Fields.Rule80A get(QuickFix.Fields.Rule80A val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Rule80A val) 
            { 
                return isSetRule80A();
            }
            
            public bool isSetRule80A() 
            { 
                return isSetField(Tags.Rule80A);
            }
            public QuickFix.Fields.LastQty lastQty
            { 
                get 
                {
                    QuickFix.Fields.LastQty val = new QuickFix.Fields.LastQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastQty val) 
            { 
                this.lastQty = val;
            }
            
            public QuickFix.Fields.LastQty get(QuickFix.Fields.LastQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastQty val) 
            { 
                return isSetLastQty();
            }
            
            public bool isSetLastQty() 
            { 
                return isSetField(Tags.LastQty);
            }
            public QuickFix.Fields.UnderlyingLastQty underlyingLastQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLastQty val = new QuickFix.Fields.UnderlyingLastQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingLastQty val) 
            { 
                this.underlyingLastQty = val;
            }
            
            public QuickFix.Fields.UnderlyingLastQty get(QuickFix.Fields.UnderlyingLastQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingLastQty val) 
            { 
                return isSetUnderlyingLastQty();
            }
            
            public bool isSetUnderlyingLastQty() 
            { 
                return isSetField(Tags.UnderlyingLastQty);
            }
            public QuickFix.Fields.LastPx lastPx
            { 
                get 
                {
                    QuickFix.Fields.LastPx val = new QuickFix.Fields.LastPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastPx val) 
            { 
                this.lastPx = val;
            }
            
            public QuickFix.Fields.LastPx get(QuickFix.Fields.LastPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastPx val) 
            { 
                return isSetLastPx();
            }
            
            public bool isSetLastPx() 
            { 
                return isSetField(Tags.LastPx);
            }
            public QuickFix.Fields.UnderlyingLastPx underlyingLastPx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLastPx val = new QuickFix.Fields.UnderlyingLastPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingLastPx val) 
            { 
                this.underlyingLastPx = val;
            }
            
            public QuickFix.Fields.UnderlyingLastPx get(QuickFix.Fields.UnderlyingLastPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingLastPx val) 
            { 
                return isSetUnderlyingLastPx();
            }
            
            public bool isSetUnderlyingLastPx() 
            { 
                return isSetField(Tags.UnderlyingLastPx);
            }
            public QuickFix.Fields.LastSpotRate lastSpotRate
            { 
                get 
                {
                    QuickFix.Fields.LastSpotRate val = new QuickFix.Fields.LastSpotRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastSpotRate val) 
            { 
                this.lastSpotRate = val;
            }
            
            public QuickFix.Fields.LastSpotRate get(QuickFix.Fields.LastSpotRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastSpotRate val) 
            { 
                return isSetLastSpotRate();
            }
            
            public bool isSetLastSpotRate() 
            { 
                return isSetField(Tags.LastSpotRate);
            }
            public QuickFix.Fields.LastForwardPoints lastForwardPoints
            { 
                get 
                {
                    QuickFix.Fields.LastForwardPoints val = new QuickFix.Fields.LastForwardPoints();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastForwardPoints val) 
            { 
                this.lastForwardPoints = val;
            }
            
            public QuickFix.Fields.LastForwardPoints get(QuickFix.Fields.LastForwardPoints val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastForwardPoints val) 
            { 
                return isSetLastForwardPoints();
            }
            
            public bool isSetLastForwardPoints() 
            { 
                return isSetField(Tags.LastForwardPoints);
            }
            public QuickFix.Fields.LastMkt lastMkt
            { 
                get 
                {
                    QuickFix.Fields.LastMkt val = new QuickFix.Fields.LastMkt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastMkt val) 
            { 
                this.lastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt get(QuickFix.Fields.LastMkt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastMkt val) 
            { 
                return isSetLastMkt();
            }
            
            public bool isSetLastMkt() 
            { 
                return isSetField(Tags.LastMkt);
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
            public QuickFix.Fields.LastCapacity lastCapacity
            { 
                get 
                {
                    QuickFix.Fields.LastCapacity val = new QuickFix.Fields.LastCapacity();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastCapacity val) 
            { 
                this.lastCapacity = val;
            }
            
            public QuickFix.Fields.LastCapacity get(QuickFix.Fields.LastCapacity val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastCapacity val) 
            { 
                return isSetLastCapacity();
            }
            
            public bool isSetLastCapacity() 
            { 
                return isSetField(Tags.LastCapacity);
            }
            public QuickFix.Fields.LeavesQty leavesQty
            { 
                get 
                {
                    QuickFix.Fields.LeavesQty val = new QuickFix.Fields.LeavesQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LeavesQty val) 
            { 
                this.leavesQty = val;
            }
            
            public QuickFix.Fields.LeavesQty get(QuickFix.Fields.LeavesQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LeavesQty val) 
            { 
                return isSetLeavesQty();
            }
            
            public bool isSetLeavesQty() 
            { 
                return isSetField(Tags.LeavesQty);
            }
            public QuickFix.Fields.CumQty cumQty
            { 
                get 
                {
                    QuickFix.Fields.CumQty val = new QuickFix.Fields.CumQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CumQty val) 
            { 
                this.cumQty = val;
            }
            
            public QuickFix.Fields.CumQty get(QuickFix.Fields.CumQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CumQty val) 
            { 
                return isSetCumQty();
            }
            
            public bool isSetCumQty() 
            { 
                return isSetField(Tags.CumQty);
            }
            public QuickFix.Fields.AvgPx avgPx
            { 
                get 
                {
                    QuickFix.Fields.AvgPx val = new QuickFix.Fields.AvgPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AvgPx val) 
            { 
                this.avgPx = val;
            }
            
            public QuickFix.Fields.AvgPx get(QuickFix.Fields.AvgPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AvgPx val) 
            { 
                return isSetAvgPx();
            }
            
            public bool isSetAvgPx() 
            { 
                return isSetField(Tags.AvgPx);
            }
            public QuickFix.Fields.DayOrderQty dayOrderQty
            { 
                get 
                {
                    QuickFix.Fields.DayOrderQty val = new QuickFix.Fields.DayOrderQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DayOrderQty val) 
            { 
                this.dayOrderQty = val;
            }
            
            public QuickFix.Fields.DayOrderQty get(QuickFix.Fields.DayOrderQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DayOrderQty val) 
            { 
                return isSetDayOrderQty();
            }
            
            public bool isSetDayOrderQty() 
            { 
                return isSetField(Tags.DayOrderQty);
            }
            public QuickFix.Fields.DayCumQty dayCumQty
            { 
                get 
                {
                    QuickFix.Fields.DayCumQty val = new QuickFix.Fields.DayCumQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DayCumQty val) 
            { 
                this.dayCumQty = val;
            }
            
            public QuickFix.Fields.DayCumQty get(QuickFix.Fields.DayCumQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DayCumQty val) 
            { 
                return isSetDayCumQty();
            }
            
            public bool isSetDayCumQty() 
            { 
                return isSetField(Tags.DayCumQty);
            }
            public QuickFix.Fields.DayAvgPx dayAvgPx
            { 
                get 
                {
                    QuickFix.Fields.DayAvgPx val = new QuickFix.Fields.DayAvgPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DayAvgPx val) 
            { 
                this.dayAvgPx = val;
            }
            
            public QuickFix.Fields.DayAvgPx get(QuickFix.Fields.DayAvgPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DayAvgPx val) 
            { 
                return isSetDayAvgPx();
            }
            
            public bool isSetDayAvgPx() 
            { 
                return isSetField(Tags.DayAvgPx);
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
            public QuickFix.Fields.ReportToExch reportToExch
            { 
                get 
                {
                    QuickFix.Fields.ReportToExch val = new QuickFix.Fields.ReportToExch();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ReportToExch val) 
            { 
                this.reportToExch = val;
            }
            
            public QuickFix.Fields.ReportToExch get(QuickFix.Fields.ReportToExch val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ReportToExch val) 
            { 
                return isSetReportToExch();
            }
            
            public bool isSetReportToExch() 
            { 
                return isSetField(Tags.ReportToExch);
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
            public QuickFix.Fields.GrossTradeAmt grossTradeAmt
            { 
                get 
                {
                    QuickFix.Fields.GrossTradeAmt val = new QuickFix.Fields.GrossTradeAmt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.GrossTradeAmt val) 
            { 
                this.grossTradeAmt = val;
            }
            
            public QuickFix.Fields.GrossTradeAmt get(QuickFix.Fields.GrossTradeAmt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.GrossTradeAmt val) 
            { 
                return isSetGrossTradeAmt();
            }
            
            public bool isSetGrossTradeAmt() 
            { 
                return isSetField(Tags.GrossTradeAmt);
            }
            public QuickFix.Fields.NumDaysInterest numDaysInterest
            { 
                get 
                {
                    QuickFix.Fields.NumDaysInterest val = new QuickFix.Fields.NumDaysInterest();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NumDaysInterest val) 
            { 
                this.numDaysInterest = val;
            }
            
            public QuickFix.Fields.NumDaysInterest get(QuickFix.Fields.NumDaysInterest val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NumDaysInterest val) 
            { 
                return isSetNumDaysInterest();
            }
            
            public bool isSetNumDaysInterest() 
            { 
                return isSetField(Tags.NumDaysInterest);
            }
            public QuickFix.Fields.ExDate exDate
            { 
                get 
                {
                    QuickFix.Fields.ExDate val = new QuickFix.Fields.ExDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExDate val) 
            { 
                this.exDate = val;
            }
            
            public QuickFix.Fields.ExDate get(QuickFix.Fields.ExDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExDate val) 
            { 
                return isSetExDate();
            }
            
            public bool isSetExDate() 
            { 
                return isSetField(Tags.ExDate);
            }
            public QuickFix.Fields.AccruedInterestRate accruedInterestRate
            { 
                get 
                {
                    QuickFix.Fields.AccruedInterestRate val = new QuickFix.Fields.AccruedInterestRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AccruedInterestRate val) 
            { 
                this.accruedInterestRate = val;
            }
            
            public QuickFix.Fields.AccruedInterestRate get(QuickFix.Fields.AccruedInterestRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AccruedInterestRate val) 
            { 
                return isSetAccruedInterestRate();
            }
            
            public bool isSetAccruedInterestRate() 
            { 
                return isSetField(Tags.AccruedInterestRate);
            }
            public QuickFix.Fields.AccruedInterestAmt accruedInterestAmt
            { 
                get 
                {
                    QuickFix.Fields.AccruedInterestAmt val = new QuickFix.Fields.AccruedInterestAmt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                this.accruedInterestAmt = val;
            }
            
            public QuickFix.Fields.AccruedInterestAmt get(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                return isSetAccruedInterestAmt();
            }
            
            public bool isSetAccruedInterestAmt() 
            { 
                return isSetField(Tags.AccruedInterestAmt);
            }
            public QuickFix.Fields.TradedFlatSwitch tradedFlatSwitch
            { 
                get 
                {
                    QuickFix.Fields.TradedFlatSwitch val = new QuickFix.Fields.TradedFlatSwitch();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradedFlatSwitch val) 
            { 
                this.tradedFlatSwitch = val;
            }
            
            public QuickFix.Fields.TradedFlatSwitch get(QuickFix.Fields.TradedFlatSwitch val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradedFlatSwitch val) 
            { 
                return isSetTradedFlatSwitch();
            }
            
            public bool isSetTradedFlatSwitch() 
            { 
                return isSetField(Tags.TradedFlatSwitch);
            }
            public QuickFix.Fields.BasisFeatureDate basisFeatureDate
            { 
                get 
                {
                    QuickFix.Fields.BasisFeatureDate val = new QuickFix.Fields.BasisFeatureDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BasisFeatureDate val) 
            { 
                this.basisFeatureDate = val;
            }
            
            public QuickFix.Fields.BasisFeatureDate get(QuickFix.Fields.BasisFeatureDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BasisFeatureDate val) 
            { 
                return isSetBasisFeatureDate();
            }
            
            public bool isSetBasisFeatureDate() 
            { 
                return isSetField(Tags.BasisFeatureDate);
            }
            public QuickFix.Fields.BasisFeaturePrice basisFeaturePrice
            { 
                get 
                {
                    QuickFix.Fields.BasisFeaturePrice val = new QuickFix.Fields.BasisFeaturePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BasisFeaturePrice val) 
            { 
                this.basisFeaturePrice = val;
            }
            
            public QuickFix.Fields.BasisFeaturePrice get(QuickFix.Fields.BasisFeaturePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BasisFeaturePrice val) 
            { 
                return isSetBasisFeaturePrice();
            }
            
            public bool isSetBasisFeaturePrice() 
            { 
                return isSetField(Tags.BasisFeaturePrice);
            }
            public QuickFix.Fields.Concession concession
            { 
                get 
                {
                    QuickFix.Fields.Concession val = new QuickFix.Fields.Concession();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Concession val) 
            { 
                this.concession = val;
            }
            
            public QuickFix.Fields.Concession get(QuickFix.Fields.Concession val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Concession val) 
            { 
                return isSetConcession();
            }
            
            public bool isSetConcession() 
            { 
                return isSetField(Tags.Concession);
            }
            public QuickFix.Fields.TotalTakedown totalTakedown
            { 
                get 
                {
                    QuickFix.Fields.TotalTakedown val = new QuickFix.Fields.TotalTakedown();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotalTakedown val) 
            { 
                this.totalTakedown = val;
            }
            
            public QuickFix.Fields.TotalTakedown get(QuickFix.Fields.TotalTakedown val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotalTakedown val) 
            { 
                return isSetTotalTakedown();
            }
            
            public bool isSetTotalTakedown() 
            { 
                return isSetField(Tags.TotalTakedown);
            }
            public QuickFix.Fields.NetMoney netMoney
            { 
                get 
                {
                    QuickFix.Fields.NetMoney val = new QuickFix.Fields.NetMoney();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NetMoney val) 
            { 
                this.netMoney = val;
            }
            
            public QuickFix.Fields.NetMoney get(QuickFix.Fields.NetMoney val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NetMoney val) 
            { 
                return isSetNetMoney();
            }
            
            public bool isSetNetMoney() 
            { 
                return isSetField(Tags.NetMoney);
            }
            public QuickFix.Fields.SettlCurrAmt settlCurrAmt
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrAmt val = new QuickFix.Fields.SettlCurrAmt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlCurrAmt val) 
            { 
                this.settlCurrAmt = val;
            }
            
            public QuickFix.Fields.SettlCurrAmt get(QuickFix.Fields.SettlCurrAmt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlCurrAmt val) 
            { 
                return isSetSettlCurrAmt();
            }
            
            public bool isSetSettlCurrAmt() 
            { 
                return isSetField(Tags.SettlCurrAmt);
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
            public QuickFix.Fields.SettlCurrFxRate settlCurrFxRate
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrFxRate val = new QuickFix.Fields.SettlCurrFxRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlCurrFxRate val) 
            { 
                this.settlCurrFxRate = val;
            }
            
            public QuickFix.Fields.SettlCurrFxRate get(QuickFix.Fields.SettlCurrFxRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlCurrFxRate val) 
            { 
                return isSetSettlCurrFxRate();
            }
            
            public bool isSetSettlCurrFxRate() 
            { 
                return isSetField(Tags.SettlCurrFxRate);
            }
            public QuickFix.Fields.SettlCurrFxRateCalc settlCurrFxRateCalc
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrFxRateCalc val = new QuickFix.Fields.SettlCurrFxRateCalc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlCurrFxRateCalc val) 
            { 
                this.settlCurrFxRateCalc = val;
            }
            
            public QuickFix.Fields.SettlCurrFxRateCalc get(QuickFix.Fields.SettlCurrFxRateCalc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlCurrFxRateCalc val) 
            { 
                return isSetSettlCurrFxRateCalc();
            }
            
            public bool isSetSettlCurrFxRateCalc() 
            { 
                return isSetField(Tags.SettlCurrFxRateCalc);
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
            public QuickFix.Fields.FutSettDate2 futSettDate2
            { 
                get 
                {
                    QuickFix.Fields.FutSettDate2 val = new QuickFix.Fields.FutSettDate2();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FutSettDate2 val) 
            { 
                this.futSettDate2 = val;
            }
            
            public QuickFix.Fields.FutSettDate2 get(QuickFix.Fields.FutSettDate2 val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FutSettDate2 val) 
            { 
                return isSetFutSettDate2();
            }
            
            public bool isSetFutSettDate2() 
            { 
                return isSetField(Tags.FutSettDate2);
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
            public QuickFix.Fields.LastForwardPoints2 lastForwardPoints2
            { 
                get 
                {
                    QuickFix.Fields.LastForwardPoints2 val = new QuickFix.Fields.LastForwardPoints2();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastForwardPoints2 val) 
            { 
                this.lastForwardPoints2 = val;
            }
            
            public QuickFix.Fields.LastForwardPoints2 get(QuickFix.Fields.LastForwardPoints2 val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastForwardPoints2 val) 
            { 
                return isSetLastForwardPoints2();
            }
            
            public bool isSetLastForwardPoints2() 
            { 
                return isSetField(Tags.LastForwardPoints2);
            }
            public QuickFix.Fields.MultiLegReportingType multiLegReportingType
            { 
                get 
                {
                    QuickFix.Fields.MultiLegReportingType val = new QuickFix.Fields.MultiLegReportingType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MultiLegReportingType val) 
            { 
                this.multiLegReportingType = val;
            }
            
            public QuickFix.Fields.MultiLegReportingType get(QuickFix.Fields.MultiLegReportingType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MultiLegReportingType val) 
            { 
                return isSetMultiLegReportingType();
            }
            
            public bool isSetMultiLegReportingType() 
            { 
                return isSetField(Tags.MultiLegReportingType);
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
            public QuickFix.Fields.TransBkdTime transBkdTime
            { 
                get 
                {
                    QuickFix.Fields.TransBkdTime val = new QuickFix.Fields.TransBkdTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TransBkdTime val) 
            { 
                this.transBkdTime = val;
            }
            
            public QuickFix.Fields.TransBkdTime get(QuickFix.Fields.TransBkdTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TransBkdTime val) 
            { 
                return isSetTransBkdTime();
            }
            
            public bool isSetTransBkdTime() 
            { 
                return isSetField(Tags.TransBkdTime);
            }
            public QuickFix.Fields.ExecValuationPoint execValuationPoint
            { 
                get 
                {
                    QuickFix.Fields.ExecValuationPoint val = new QuickFix.Fields.ExecValuationPoint();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecValuationPoint val) 
            { 
                this.execValuationPoint = val;
            }
            
            public QuickFix.Fields.ExecValuationPoint get(QuickFix.Fields.ExecValuationPoint val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecValuationPoint val) 
            { 
                return isSetExecValuationPoint();
            }
            
            public bool isSetExecValuationPoint() 
            { 
                return isSetField(Tags.ExecValuationPoint);
            }
            public QuickFix.Fields.ExecPriceType execPriceType
            { 
                get 
                {
                    QuickFix.Fields.ExecPriceType val = new QuickFix.Fields.ExecPriceType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecPriceType val) 
            { 
                this.execPriceType = val;
            }
            
            public QuickFix.Fields.ExecPriceType get(QuickFix.Fields.ExecPriceType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecPriceType val) 
            { 
                return isSetExecPriceType();
            }
            
            public bool isSetExecPriceType() 
            { 
                return isSetField(Tags.ExecPriceType);
            }
            public QuickFix.Fields.ExecPriceAdjustment execPriceAdjustment
            { 
                get 
                {
                    QuickFix.Fields.ExecPriceAdjustment val = new QuickFix.Fields.ExecPriceAdjustment();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExecPriceAdjustment val) 
            { 
                this.execPriceAdjustment = val;
            }
            
            public QuickFix.Fields.ExecPriceAdjustment get(QuickFix.Fields.ExecPriceAdjustment val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExecPriceAdjustment val) 
            { 
                return isSetExecPriceAdjustment();
            }
            
            public bool isSetExecPriceAdjustment() 
            { 
                return isSetField(Tags.ExecPriceAdjustment);
            }
            public QuickFix.Fields.PriorityIndicator priorityIndicator
            { 
                get 
                {
                    QuickFix.Fields.PriorityIndicator val = new QuickFix.Fields.PriorityIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriorityIndicator val) 
            { 
                this.priorityIndicator = val;
            }
            
            public QuickFix.Fields.PriorityIndicator get(QuickFix.Fields.PriorityIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriorityIndicator val) 
            { 
                return isSetPriorityIndicator();
            }
            
            public bool isSetPriorityIndicator() 
            { 
                return isSetField(Tags.PriorityIndicator);
            }
            public QuickFix.Fields.PriceImprovement priceImprovement
            { 
                get 
                {
                    QuickFix.Fields.PriceImprovement val = new QuickFix.Fields.PriceImprovement();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PriceImprovement val) 
            { 
                this.priceImprovement = val;
            }
            
            public QuickFix.Fields.PriceImprovement get(QuickFix.Fields.PriceImprovement val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PriceImprovement val) 
            { 
                return isSetPriceImprovement();
            }
            
            public bool isSetPriceImprovement() 
            { 
                return isSetField(Tags.PriceImprovement);
            }
            public QuickFix.Fields.NoContAmts noContAmts
            { 
                get 
                {
                    QuickFix.Fields.NoContAmts val = new QuickFix.Fields.NoContAmts();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoContAmts val) 
            { 
                this.noContAmts = val;
            }
            
            public QuickFix.Fields.NoContAmts get(QuickFix.Fields.NoContAmts val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoContAmts val) 
            { 
                return isSetNoContAmts();
            }
            
            public bool isSetNoContAmts() 
            { 
                return isSetField(Tags.NoContAmts);
            }
            public QuickFix.Fields.NoLegs noLegs
            { 
                get 
                {
                    QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoLegs val) 
            { 
                this.noLegs = val;
            }
            
            public QuickFix.Fields.NoLegs get(QuickFix.Fields.NoLegs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoLegs val) 
            { 
                return isSetNoLegs();
            }
            
            public bool isSetNoLegs() 
            { 
                return isSetField(Tags.NoLegs);
            }
            public class NoPartyIDs : Group
            {
                public NoPartyIDs() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.PartySubID, 0};
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
            
            }
            public class NoContraBrokers : Group
            {
                public NoContraBrokers() 
                  :base( Tags.NoContraBrokers, Tags.ContraBroker, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, Tags.ContraLegRefID, 0};
                            public QuickFix.Fields.ContraBroker contraBroker
                { 
                    get 
                    {
                        QuickFix.Fields.ContraBroker val = new QuickFix.Fields.ContraBroker();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContraBroker val) 
                { 
                    this.contraBroker = val;
                }
                
                public QuickFix.Fields.ContraBroker get(QuickFix.Fields.ContraBroker val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContraBroker val) 
                { 
                    return isSetContraBroker();
                }
                
                public bool isSetContraBroker() 
                { 
                    return isSetField(Tags.ContraBroker);
                }
                public QuickFix.Fields.ContraTrader contraTrader
                { 
                    get 
                    {
                        QuickFix.Fields.ContraTrader val = new QuickFix.Fields.ContraTrader();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContraTrader val) 
                { 
                    this.contraTrader = val;
                }
                
                public QuickFix.Fields.ContraTrader get(QuickFix.Fields.ContraTrader val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContraTrader val) 
                { 
                    return isSetContraTrader();
                }
                
                public bool isSetContraTrader() 
                { 
                    return isSetField(Tags.ContraTrader);
                }
                public QuickFix.Fields.ContraTradeQty contraTradeQty
                { 
                    get 
                    {
                        QuickFix.Fields.ContraTradeQty val = new QuickFix.Fields.ContraTradeQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContraTradeQty val) 
                { 
                    this.contraTradeQty = val;
                }
                
                public QuickFix.Fields.ContraTradeQty get(QuickFix.Fields.ContraTradeQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContraTradeQty val) 
                { 
                    return isSetContraTradeQty();
                }
                
                public bool isSetContraTradeQty() 
                { 
                    return isSetField(Tags.ContraTradeQty);
                }
                public QuickFix.Fields.ContraTradeTime contraTradeTime
                { 
                    get 
                    {
                        QuickFix.Fields.ContraTradeTime val = new QuickFix.Fields.ContraTradeTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContraTradeTime val) 
                { 
                    this.contraTradeTime = val;
                }
                
                public QuickFix.Fields.ContraTradeTime get(QuickFix.Fields.ContraTradeTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContraTradeTime val) 
                { 
                    return isSetContraTradeTime();
                }
                
                public bool isSetContraTradeTime() 
                { 
                    return isSetField(Tags.ContraTradeTime);
                }
                public QuickFix.Fields.ContraLegRefID contraLegRefID
                { 
                    get 
                    {
                        QuickFix.Fields.ContraLegRefID val = new QuickFix.Fields.ContraLegRefID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContraLegRefID val) 
                { 
                    this.contraLegRefID = val;
                }
                
                public QuickFix.Fields.ContraLegRefID get(QuickFix.Fields.ContraLegRefID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContraLegRefID val) 
                { 
                    return isSetContraLegRefID();
                }
                
                public bool isSetContraLegRefID() 
                { 
                    return isSetField(Tags.ContraLegRefID);
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
            public class NoContAmts : Group
            {
                public NoContAmts() 
                  :base( Tags.NoContAmts, Tags.ContAmtType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};
                            public QuickFix.Fields.ContAmtType contAmtType
                { 
                    get 
                    {
                        QuickFix.Fields.ContAmtType val = new QuickFix.Fields.ContAmtType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContAmtType val) 
                { 
                    this.contAmtType = val;
                }
                
                public QuickFix.Fields.ContAmtType get(QuickFix.Fields.ContAmtType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContAmtType val) 
                { 
                    return isSetContAmtType();
                }
                
                public bool isSetContAmtType() 
                { 
                    return isSetField(Tags.ContAmtType);
                }
                public QuickFix.Fields.ContAmtValue contAmtValue
                { 
                    get 
                    {
                        QuickFix.Fields.ContAmtValue val = new QuickFix.Fields.ContAmtValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContAmtValue val) 
                { 
                    this.contAmtValue = val;
                }
                
                public QuickFix.Fields.ContAmtValue get(QuickFix.Fields.ContAmtValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContAmtValue val) 
                { 
                    return isSetContAmtValue();
                }
                
                public bool isSetContAmtValue() 
                { 
                    return isSetField(Tags.ContAmtValue);
                }
                public QuickFix.Fields.ContAmtCurr contAmtCurr
                { 
                    get 
                    {
                        QuickFix.Fields.ContAmtCurr val = new QuickFix.Fields.ContAmtCurr();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContAmtCurr val) 
                { 
                    this.contAmtCurr = val;
                }
                
                public QuickFix.Fields.ContAmtCurr get(QuickFix.Fields.ContAmtCurr val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContAmtCurr val) 
                { 
                    return isSetContAmtCurr();
                }
                
                public bool isSetContAmtCurr() 
                { 
                    return isSetField(Tags.ContAmtCurr);
                }
            
            }
            public class NoLegs : Group
            {
                public NoLegs() 
                  :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.NoNestedPartyIDs, Tags.LegRefID, Tags.LegPrice, Tags.LegSettlmntTyp, Tags.LegFutSettDate, Tags.LegLastPx, 0};
                            public QuickFix.Fields.LegSymbol legSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSymbol val) 
                { 
                    this.legSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol get(QuickFix.Fields.LegSymbol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return isSetLegSymbol();
                }
                
                public bool isSetLegSymbol() 
                { 
                    return isSetField(Tags.LegSymbol);
                }
                public QuickFix.Fields.LegSymbolSfx legSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    this.legSymbolSfx = val;
                }
                
                public QuickFix.Fields.LegSymbolSfx get(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    return isSetLegSymbolSfx();
                }
                
                public bool isSetLegSymbolSfx() 
                { 
                    return isSetField(Tags.LegSymbolSfx);
                }
                public QuickFix.Fields.LegSecurityID legSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityID val) 
                { 
                    this.legSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID get(QuickFix.Fields.LegSecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return isSetLegSecurityID();
                }
                
                public bool isSetLegSecurityID() 
                { 
                    return isSetField(Tags.LegSecurityID);
                }
                public QuickFix.Fields.LegSecurityIDSource legSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    this.legSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return isSetLegSecurityIDSource();
                }
                
                public bool isSetLegSecurityIDSource() 
                { 
                    return isSetField(Tags.LegSecurityIDSource);
                }
                public QuickFix.Fields.NoLegSecurityAltID noLegSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    this.noLegSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoLegSecurityAltID get(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    return isSetNoLegSecurityAltID();
                }
                
                public bool isSetNoLegSecurityAltID() 
                { 
                    return isSetField(Tags.NoLegSecurityAltID);
                }
                public QuickFix.Fields.LegProduct legProduct
                { 
                    get 
                    {
                        QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegProduct val) 
                { 
                    this.legProduct = val;
                }
                
                public QuickFix.Fields.LegProduct get(QuickFix.Fields.LegProduct val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegProduct val) 
                { 
                    return isSetLegProduct();
                }
                
                public bool isSetLegProduct() 
                { 
                    return isSetField(Tags.LegProduct);
                }
                public QuickFix.Fields.LegCFICode legCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCFICode val) 
                { 
                    this.legCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode get(QuickFix.Fields.LegCFICode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return isSetLegCFICode();
                }
                
                public bool isSetLegCFICode() 
                { 
                    return isSetField(Tags.LegCFICode);
                }
                public QuickFix.Fields.LegSecurityType legSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityType val) 
                { 
                    this.legSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType get(QuickFix.Fields.LegSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return isSetLegSecurityType();
                }
                
                public bool isSetLegSecurityType() 
                { 
                    return isSetField(Tags.LegSecurityType);
                }
                public QuickFix.Fields.LegMaturityMonthYear legMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    this.legMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.LegMaturityMonthYear get(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    return isSetLegMaturityMonthYear();
                }
                
                public bool isSetLegMaturityMonthYear() 
                { 
                    return isSetField(Tags.LegMaturityMonthYear);
                }
                public QuickFix.Fields.LegMaturityDate legMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegMaturityDate val) 
                { 
                    this.legMaturityDate = val;
                }
                
                public QuickFix.Fields.LegMaturityDate get(QuickFix.Fields.LegMaturityDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegMaturityDate val) 
                { 
                    return isSetLegMaturityDate();
                }
                
                public bool isSetLegMaturityDate() 
                { 
                    return isSetField(Tags.LegMaturityDate);
                }
                public QuickFix.Fields.LegCouponPaymentDate legCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    this.legCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.LegCouponPaymentDate get(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    return isSetLegCouponPaymentDate();
                }
                
                public bool isSetLegCouponPaymentDate() 
                { 
                    return isSetField(Tags.LegCouponPaymentDate);
                }
                public QuickFix.Fields.LegIssueDate legIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegIssueDate val) 
                { 
                    this.legIssueDate = val;
                }
                
                public QuickFix.Fields.LegIssueDate get(QuickFix.Fields.LegIssueDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegIssueDate val) 
                { 
                    return isSetLegIssueDate();
                }
                
                public bool isSetLegIssueDate() 
                { 
                    return isSetField(Tags.LegIssueDate);
                }
                public QuickFix.Fields.LegRepoCollateralSecurityType legRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    this.legRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return isSetLegRepoCollateralSecurityType();
                }
                
                public bool isSetLegRepoCollateralSecurityType() 
                { 
                    return isSetField(Tags.LegRepoCollateralSecurityType);
                }
                public QuickFix.Fields.LegRepurchaseTerm legRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    this.legRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.LegRepurchaseTerm get(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    return isSetLegRepurchaseTerm();
                }
                
                public bool isSetLegRepurchaseTerm() 
                { 
                    return isSetField(Tags.LegRepurchaseTerm);
                }
                public QuickFix.Fields.LegRepurchaseRate legRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    this.legRepurchaseRate = val;
                }
                
                public QuickFix.Fields.LegRepurchaseRate get(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    return isSetLegRepurchaseRate();
                }
                
                public bool isSetLegRepurchaseRate() 
                { 
                    return isSetField(Tags.LegRepurchaseRate);
                }
                public QuickFix.Fields.LegFactor legFactor
                { 
                    get 
                    {
                        QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegFactor val) 
                { 
                    this.legFactor = val;
                }
                
                public QuickFix.Fields.LegFactor get(QuickFix.Fields.LegFactor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegFactor val) 
                { 
                    return isSetLegFactor();
                }
                
                public bool isSetLegFactor() 
                { 
                    return isSetField(Tags.LegFactor);
                }
                public QuickFix.Fields.LegCreditRating legCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCreditRating val) 
                { 
                    this.legCreditRating = val;
                }
                
                public QuickFix.Fields.LegCreditRating get(QuickFix.Fields.LegCreditRating val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCreditRating val) 
                { 
                    return isSetLegCreditRating();
                }
                
                public bool isSetLegCreditRating() 
                { 
                    return isSetField(Tags.LegCreditRating);
                }
                public QuickFix.Fields.LegInstrRegistry legInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    this.legInstrRegistry = val;
                }
                
                public QuickFix.Fields.LegInstrRegistry get(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    return isSetLegInstrRegistry();
                }
                
                public bool isSetLegInstrRegistry() 
                { 
                    return isSetField(Tags.LegInstrRegistry);
                }
                public QuickFix.Fields.LegCountryOfIssue legCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    this.legCountryOfIssue = val;
                }
                
                public QuickFix.Fields.LegCountryOfIssue get(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    return isSetLegCountryOfIssue();
                }
                
                public bool isSetLegCountryOfIssue() 
                { 
                    return isSetField(Tags.LegCountryOfIssue);
                }
                public QuickFix.Fields.LegStateOrProvinceOfIssue legStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    this.legStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return isSetLegStateOrProvinceOfIssue();
                }
                
                public bool isSetLegStateOrProvinceOfIssue() 
                { 
                    return isSetField(Tags.LegStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.LegLocaleOfIssue legLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    this.legLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.LegLocaleOfIssue get(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    return isSetLegLocaleOfIssue();
                }
                
                public bool isSetLegLocaleOfIssue() 
                { 
                    return isSetField(Tags.LegLocaleOfIssue);
                }
                public QuickFix.Fields.LegRedemptionDate legRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    this.legRedemptionDate = val;
                }
                
                public QuickFix.Fields.LegRedemptionDate get(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    return isSetLegRedemptionDate();
                }
                
                public bool isSetLegRedemptionDate() 
                { 
                    return isSetField(Tags.LegRedemptionDate);
                }
                public QuickFix.Fields.LegStrikePrice legStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    this.legStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return isSetLegStrikePrice();
                }
                
                public bool isSetLegStrikePrice() 
                { 
                    return isSetField(Tags.LegStrikePrice);
                }
                public QuickFix.Fields.LegOptAttribute legOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegOptAttribute val) 
                { 
                    this.legOptAttribute = val;
                }
                
                public QuickFix.Fields.LegOptAttribute get(QuickFix.Fields.LegOptAttribute val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegOptAttribute val) 
                { 
                    return isSetLegOptAttribute();
                }
                
                public bool isSetLegOptAttribute() 
                { 
                    return isSetField(Tags.LegOptAttribute);
                }
                public QuickFix.Fields.LegContractMultiplier legContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    this.legContractMultiplier = val;
                }
                
                public QuickFix.Fields.LegContractMultiplier get(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    return isSetLegContractMultiplier();
                }
                
                public bool isSetLegContractMultiplier() 
                { 
                    return isSetField(Tags.LegContractMultiplier);
                }
                public QuickFix.Fields.LegCouponRate legCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCouponRate val) 
                { 
                    this.legCouponRate = val;
                }
                
                public QuickFix.Fields.LegCouponRate get(QuickFix.Fields.LegCouponRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCouponRate val) 
                { 
                    return isSetLegCouponRate();
                }
                
                public bool isSetLegCouponRate() 
                { 
                    return isSetField(Tags.LegCouponRate);
                }
                public QuickFix.Fields.LegSecurityExchange legSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    this.legSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return isSetLegSecurityExchange();
                }
                
                public bool isSetLegSecurityExchange() 
                { 
                    return isSetField(Tags.LegSecurityExchange);
                }
                public QuickFix.Fields.LegIssuer legIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegIssuer val) 
                { 
                    this.legIssuer = val;
                }
                
                public QuickFix.Fields.LegIssuer get(QuickFix.Fields.LegIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegIssuer val) 
                { 
                    return isSetLegIssuer();
                }
                
                public bool isSetLegIssuer() 
                { 
                    return isSetField(Tags.LegIssuer);
                }
                public QuickFix.Fields.EncodedLegIssuerLen encodedLegIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    this.encodedLegIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen get(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    return isSetEncodedLegIssuerLen();
                }
                
                public bool isSetEncodedLegIssuerLen() 
                { 
                    return isSetField(Tags.EncodedLegIssuerLen);
                }
                public QuickFix.Fields.EncodedLegIssuer encodedLegIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    this.encodedLegIssuer = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuer get(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    return isSetEncodedLegIssuer();
                }
                
                public bool isSetEncodedLegIssuer() 
                { 
                    return isSetField(Tags.EncodedLegIssuer);
                }
                public QuickFix.Fields.LegSecurityDesc legSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    this.legSecurityDesc = val;
                }
                
                public QuickFix.Fields.LegSecurityDesc get(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    return isSetLegSecurityDesc();
                }
                
                public bool isSetLegSecurityDesc() 
                { 
                    return isSetField(Tags.LegSecurityDesc);
                }
                public QuickFix.Fields.EncodedLegSecurityDescLen encodedLegSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    this.encodedLegSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return isSetEncodedLegSecurityDescLen();
                }
                
                public bool isSetEncodedLegSecurityDescLen() 
                { 
                    return isSetField(Tags.EncodedLegSecurityDescLen);
                }
                public QuickFix.Fields.EncodedLegSecurityDesc encodedLegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    this.encodedLegSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    return isSetEncodedLegSecurityDesc();
                }
                
                public bool isSetEncodedLegSecurityDesc() 
                { 
                    return isSetField(Tags.EncodedLegSecurityDesc);
                }
                public QuickFix.Fields.LegRatioQty legRatioQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRatioQty val) 
                { 
                    this.legRatioQty = val;
                }
                
                public QuickFix.Fields.LegRatioQty get(QuickFix.Fields.LegRatioQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRatioQty val) 
                { 
                    return isSetLegRatioQty();
                }
                
                public bool isSetLegRatioQty() 
                { 
                    return isSetField(Tags.LegRatioQty);
                }
                public QuickFix.Fields.LegSide legSide
                { 
                    get 
                    {
                        QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSide val) 
                { 
                    this.legSide = val;
                }
                
                public QuickFix.Fields.LegSide get(QuickFix.Fields.LegSide val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSide val) 
                { 
                    return isSetLegSide();
                }
                
                public bool isSetLegSide() 
                { 
                    return isSetField(Tags.LegSide);
                }
                public QuickFix.Fields.LegPositionEffect legPositionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.LegPositionEffect val = new QuickFix.Fields.LegPositionEffect();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPositionEffect val) 
                { 
                    this.legPositionEffect = val;
                }
                
                public QuickFix.Fields.LegPositionEffect get(QuickFix.Fields.LegPositionEffect val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPositionEffect val) 
                { 
                    return isSetLegPositionEffect();
                }
                
                public bool isSetLegPositionEffect() 
                { 
                    return isSetField(Tags.LegPositionEffect);
                }
                public QuickFix.Fields.LegCoveredOrUncovered legCoveredOrUncovered
                { 
                    get 
                    {
                        QuickFix.Fields.LegCoveredOrUncovered val = new QuickFix.Fields.LegCoveredOrUncovered();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    this.legCoveredOrUncovered = val;
                }
                
                public QuickFix.Fields.LegCoveredOrUncovered get(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    return isSetLegCoveredOrUncovered();
                }
                
                public bool isSetLegCoveredOrUncovered() 
                { 
                    return isSetField(Tags.LegCoveredOrUncovered);
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
                public QuickFix.Fields.LegRefID legRefID
                { 
                    get 
                    {
                        QuickFix.Fields.LegRefID val = new QuickFix.Fields.LegRefID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegRefID val) 
                { 
                    this.legRefID = val;
                }
                
                public QuickFix.Fields.LegRefID get(QuickFix.Fields.LegRefID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegRefID val) 
                { 
                    return isSetLegRefID();
                }
                
                public bool isSetLegRefID() 
                { 
                    return isSetField(Tags.LegRefID);
                }
                public QuickFix.Fields.LegPrice legPrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegPrice val) 
                { 
                    this.legPrice = val;
                }
                
                public QuickFix.Fields.LegPrice get(QuickFix.Fields.LegPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegPrice val) 
                { 
                    return isSetLegPrice();
                }
                
                public bool isSetLegPrice() 
                { 
                    return isSetField(Tags.LegPrice);
                }
                public QuickFix.Fields.LegSettlmntTyp legSettlmntTyp
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlmntTyp val = new QuickFix.Fields.LegSettlmntTyp();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegSettlmntTyp val) 
                { 
                    this.legSettlmntTyp = val;
                }
                
                public QuickFix.Fields.LegSettlmntTyp get(QuickFix.Fields.LegSettlmntTyp val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegSettlmntTyp val) 
                { 
                    return isSetLegSettlmntTyp();
                }
                
                public bool isSetLegSettlmntTyp() 
                { 
                    return isSetField(Tags.LegSettlmntTyp);
                }
                public QuickFix.Fields.LegFutSettDate legFutSettDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegFutSettDate val = new QuickFix.Fields.LegFutSettDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegFutSettDate val) 
                { 
                    this.legFutSettDate = val;
                }
                
                public QuickFix.Fields.LegFutSettDate get(QuickFix.Fields.LegFutSettDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegFutSettDate val) 
                { 
                    return isSetLegFutSettDate();
                }
                
                public bool isSetLegFutSettDate() 
                { 
                    return isSetField(Tags.LegFutSettDate);
                }
                public QuickFix.Fields.LegLastPx legLastPx
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastPx val = new QuickFix.Fields.LegLastPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LegLastPx val) 
                { 
                    this.legLastPx = val;
                }
                
                public QuickFix.Fields.LegLastPx get(QuickFix.Fields.LegLastPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LegLastPx val) 
                { 
                    return isSetLegLastPx();
                }
                
                public bool isSetLegLastPx() 
                { 
                    return isSetField(Tags.LegLastPx);
                }
                            public class NoLegSecurityAltID : Group
                {
                    public NoLegSecurityAltID() 
                      :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                                    public QuickFix.Fields.LegSecurityAltID legSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        this.legSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltID get(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        return isSetLegSecurityAltID();
                    }
                    
                    public bool isSetLegSecurityAltID() 
                    { 
                        return isSetField(Tags.LegSecurityAltID);
                    }
                    public QuickFix.Fields.LegSecurityAltIDSource legSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        this.legSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource get(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        return isSetLegSecurityAltIDSource();
                    }
                    
                    public bool isSetLegSecurityAltIDSource() 
                    { 
                        return isSetField(Tags.LegSecurityAltIDSource);
                    }
                
                }
                public class NoNestedPartyIDs : Group
                {
                    public NoNestedPartyIDs() 
                      :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NestedPartySubID, 0};
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
                
                }
            }
        }
    }
}
