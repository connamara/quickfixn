// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class ExecutionReport : Message
        {
            public const string MsgType = "8";

            public ExecutionReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("8"));
            }

            public ExecutionReport(
                    QuickFix.Fields.OrderID aOrderID,
                    QuickFix.Fields.ExecID aExecID,
                    QuickFix.Fields.ExecType aExecType,
                    QuickFix.Fields.OrdStatus aOrdStatus,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.LeavesQty aLeavesQty,
                    QuickFix.Fields.CumQty aCumQty
                ) : this()
            {
                this.OrderID = aOrderID;
                this.ExecID = aExecID;
                this.ExecType = aExecType;
                this.OrdStatus = aOrdStatus;
                this.Side = aSide;
                this.LeavesQty = aLeavesQty;
                this.CumQty = aCumQty;
            }

            public QuickFix.Fields.OrderID OrderID
            { 
                get 
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Tags.OrderID);
            }
            public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryOrderID val) 
            { 
                this.SecondaryOrderID = val;
            }
            
            public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryOrderID val) 
            { 
                return IsSetSecondaryOrderID();
            }
            
            public bool IsSetSecondaryOrderID() 
            { 
                return IsSetField(Tags.SecondaryOrderID);
            }
            public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                this.SecondaryClOrdID = val;
            }
            
            public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) 
            { 
                return IsSetSecondaryClOrdID();
            }
            
            public bool IsSetSecondaryClOrdID() 
            { 
                return IsSetField(Tags.SecondaryClOrdID);
            }
            public QuickFix.Fields.SecondaryExecID SecondaryExecID
            { 
                get 
                {
                    QuickFix.Fields.SecondaryExecID val = new QuickFix.Fields.SecondaryExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryExecID val) 
            { 
                this.SecondaryExecID = val;
            }
            
            public QuickFix.Fields.SecondaryExecID Get(QuickFix.Fields.SecondaryExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryExecID val) 
            { 
                return IsSetSecondaryExecID();
            }
            
            public bool IsSetSecondaryExecID() 
            { 
                return IsSetField(Tags.SecondaryExecID);
            }
            public QuickFix.Fields.ClOrdID ClOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdID val) 
            { 
                this.ClOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.OrigClOrdID OrigClOrdID
            { 
                get 
                {
                    QuickFix.Fields.OrigClOrdID val = new QuickFix.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigClOrdID val) 
            { 
                this.OrigClOrdID = val;
            }
            
            public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigClOrdID val) 
            { 
                return IsSetOrigClOrdID();
            }
            
            public bool IsSetOrigClOrdID() 
            { 
                return IsSetField(Tags.OrigClOrdID);
            }
            public QuickFix.Fields.ClOrdLinkID ClOrdLinkID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdLinkID val = new QuickFix.Fields.ClOrdLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdLinkID val) 
            { 
                this.ClOrdLinkID = val;
            }
            
            public QuickFix.Fields.ClOrdLinkID Get(QuickFix.Fields.ClOrdLinkID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdLinkID val) 
            { 
                return IsSetClOrdLinkID();
            }
            
            public bool IsSetClOrdLinkID() 
            { 
                return IsSetField(Tags.ClOrdLinkID);
            }
            public QuickFix.Fields.QuoteRespID QuoteRespID
            { 
                get 
                {
                    QuickFix.Fields.QuoteRespID val = new QuickFix.Fields.QuoteRespID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteRespID val) 
            { 
                this.QuoteRespID = val;
            }
            
            public QuickFix.Fields.QuoteRespID Get(QuickFix.Fields.QuoteRespID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteRespID val) 
            { 
                return IsSetQuoteRespID();
            }
            
            public bool IsSetQuoteRespID() 
            { 
                return IsSetField(Tags.QuoteRespID);
            }
            public QuickFix.Fields.OrdStatusReqID OrdStatusReqID
            { 
                get 
                {
                    QuickFix.Fields.OrdStatusReqID val = new QuickFix.Fields.OrdStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrdStatusReqID val) 
            { 
                this.OrdStatusReqID = val;
            }
            
            public QuickFix.Fields.OrdStatusReqID Get(QuickFix.Fields.OrdStatusReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrdStatusReqID val) 
            { 
                return IsSetOrdStatusReqID();
            }
            
            public bool IsSetOrdStatusReqID() 
            { 
                return IsSetField(Tags.OrdStatusReqID);
            }
            public QuickFix.Fields.MassStatusReqID MassStatusReqID
            { 
                get 
                {
                    QuickFix.Fields.MassStatusReqID val = new QuickFix.Fields.MassStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassStatusReqID val) 
            { 
                this.MassStatusReqID = val;
            }
            
            public QuickFix.Fields.MassStatusReqID Get(QuickFix.Fields.MassStatusReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassStatusReqID val) 
            { 
                return IsSetMassStatusReqID();
            }
            
            public bool IsSetMassStatusReqID() 
            { 
                return IsSetField(Tags.MassStatusReqID);
            }
            public QuickFix.Fields.TotNumReports TotNumReports
            { 
                get 
                {
                    QuickFix.Fields.TotNumReports val = new QuickFix.Fields.TotNumReports();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNumReports val) 
            { 
                this.TotNumReports = val;
            }
            
            public QuickFix.Fields.TotNumReports Get(QuickFix.Fields.TotNumReports val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNumReports val) 
            { 
                return IsSetTotNumReports();
            }
            
            public bool IsSetTotNumReports() 
            { 
                return IsSetField(Tags.TotNumReports);
            }
            public QuickFix.Fields.LastRptRequested LastRptRequested
            { 
                get 
                {
                    QuickFix.Fields.LastRptRequested val = new QuickFix.Fields.LastRptRequested();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastRptRequested val) 
            { 
                this.LastRptRequested = val;
            }
            
            public QuickFix.Fields.LastRptRequested Get(QuickFix.Fields.LastRptRequested val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastRptRequested val) 
            { 
                return IsSetLastRptRequested();
            }
            
            public bool IsSetLastRptRequested() 
            { 
                return IsSetField(Tags.LastRptRequested);
            }
            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.NoPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return IsSetNoPartyIDs();
            }
            
            public bool IsSetNoPartyIDs() 
            { 
                return IsSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
            { 
                get 
                {
                    QuickFix.Fields.TradeOriginationDate val = new QuickFix.Fields.TradeOriginationDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeOriginationDate val) 
            { 
                this.TradeOriginationDate = val;
            }
            
            public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeOriginationDate val) 
            { 
                return IsSetTradeOriginationDate();
            }
            
            public bool IsSetTradeOriginationDate() 
            { 
                return IsSetField(Tags.TradeOriginationDate);
            }
            public QuickFix.Fields.NoContraBrokers NoContraBrokers
            { 
                get 
                {
                    QuickFix.Fields.NoContraBrokers val = new QuickFix.Fields.NoContraBrokers();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoContraBrokers val) 
            { 
                this.NoContraBrokers = val;
            }
            
            public QuickFix.Fields.NoContraBrokers Get(QuickFix.Fields.NoContraBrokers val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoContraBrokers val) 
            { 
                return IsSetNoContraBrokers();
            }
            
            public bool IsSetNoContraBrokers() 
            { 
                return IsSetField(Tags.NoContraBrokers);
            }
            public QuickFix.Fields.ListID ListID
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
                this.ListID = val;
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
            public QuickFix.Fields.CrossID CrossID
            { 
                get 
                {
                    QuickFix.Fields.CrossID val = new QuickFix.Fields.CrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossID val) 
            { 
                this.CrossID = val;
            }
            
            public QuickFix.Fields.CrossID Get(QuickFix.Fields.CrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossID val) 
            { 
                return IsSetCrossID();
            }
            
            public bool IsSetCrossID() 
            { 
                return IsSetField(Tags.CrossID);
            }
            public QuickFix.Fields.OrigCrossID OrigCrossID
            { 
                get 
                {
                    QuickFix.Fields.OrigCrossID val = new QuickFix.Fields.OrigCrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrigCrossID val) 
            { 
                this.OrigCrossID = val;
            }
            
            public QuickFix.Fields.OrigCrossID Get(QuickFix.Fields.OrigCrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrigCrossID val) 
            { 
                return IsSetOrigCrossID();
            }
            
            public bool IsSetOrigCrossID() 
            { 
                return IsSetField(Tags.OrigCrossID);
            }
            public QuickFix.Fields.CrossType CrossType
            { 
                get 
                {
                    QuickFix.Fields.CrossType val = new QuickFix.Fields.CrossType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CrossType val) 
            { 
                this.CrossType = val;
            }
            
            public QuickFix.Fields.CrossType Get(QuickFix.Fields.CrossType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CrossType val) 
            { 
                return IsSetCrossType();
            }
            
            public bool IsSetCrossType() 
            { 
                return IsSetField(Tags.CrossType);
            }
            public QuickFix.Fields.ExecID ExecID
            { 
                get 
                {
                    QuickFix.Fields.ExecID val = new QuickFix.Fields.ExecID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecID val) 
            { 
                this.ExecID = val;
            }
            
            public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecID val) 
            { 
                return IsSetExecID();
            }
            
            public bool IsSetExecID() 
            { 
                return IsSetField(Tags.ExecID);
            }
            public QuickFix.Fields.ExecRefID ExecRefID
            { 
                get 
                {
                    QuickFix.Fields.ExecRefID val = new QuickFix.Fields.ExecRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecRefID val) 
            { 
                this.ExecRefID = val;
            }
            
            public QuickFix.Fields.ExecRefID Get(QuickFix.Fields.ExecRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecRefID val) 
            { 
                return IsSetExecRefID();
            }
            
            public bool IsSetExecRefID() 
            { 
                return IsSetField(Tags.ExecRefID);
            }
            public QuickFix.Fields.ExecType ExecType
            { 
                get 
                {
                    QuickFix.Fields.ExecType val = new QuickFix.Fields.ExecType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecType val) 
            { 
                this.ExecType = val;
            }
            
            public QuickFix.Fields.ExecType Get(QuickFix.Fields.ExecType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecType val) 
            { 
                return IsSetExecType();
            }
            
            public bool IsSetExecType() 
            { 
                return IsSetField(Tags.ExecType);
            }
            public QuickFix.Fields.OrdStatus OrdStatus
            { 
                get 
                {
                    QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrdStatus val) 
            { 
                this.OrdStatus = val;
            }
            
            public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrdStatus val) 
            { 
                return IsSetOrdStatus();
            }
            
            public bool IsSetOrdStatus() 
            { 
                return IsSetField(Tags.OrdStatus);
            }
            public QuickFix.Fields.WorkingIndicator WorkingIndicator
            { 
                get 
                {
                    QuickFix.Fields.WorkingIndicator val = new QuickFix.Fields.WorkingIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.WorkingIndicator val) 
            { 
                this.WorkingIndicator = val;
            }
            
            public QuickFix.Fields.WorkingIndicator Get(QuickFix.Fields.WorkingIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.WorkingIndicator val) 
            { 
                return IsSetWorkingIndicator();
            }
            
            public bool IsSetWorkingIndicator() 
            { 
                return IsSetField(Tags.WorkingIndicator);
            }
            public QuickFix.Fields.OrdRejReason OrdRejReason
            { 
                get 
                {
                    QuickFix.Fields.OrdRejReason val = new QuickFix.Fields.OrdRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrdRejReason val) 
            { 
                this.OrdRejReason = val;
            }
            
            public QuickFix.Fields.OrdRejReason Get(QuickFix.Fields.OrdRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrdRejReason val) 
            { 
                return IsSetOrdRejReason();
            }
            
            public bool IsSetOrdRejReason() 
            { 
                return IsSetField(Tags.OrdRejReason);
            }
            public QuickFix.Fields.ExecRestatementReason ExecRestatementReason
            { 
                get 
                {
                    QuickFix.Fields.ExecRestatementReason val = new QuickFix.Fields.ExecRestatementReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecRestatementReason val) 
            { 
                this.ExecRestatementReason = val;
            }
            
            public QuickFix.Fields.ExecRestatementReason Get(QuickFix.Fields.ExecRestatementReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecRestatementReason val) 
            { 
                return IsSetExecRestatementReason();
            }
            
            public bool IsSetExecRestatementReason() 
            { 
                return IsSetField(Tags.ExecRestatementReason);
            }
            public QuickFix.Fields.Account Account
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
                this.Account = val;
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
            public QuickFix.Fields.AcctIDSource AcctIDSource
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
                this.AcctIDSource = val;
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
            public QuickFix.Fields.AccountType AccountType
            { 
                get 
                {
                    QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccountType val) 
            { 
                this.AccountType = val;
            }
            
            public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccountType val) 
            { 
                return IsSetAccountType();
            }
            
            public bool IsSetAccountType() 
            { 
                return IsSetField(Tags.AccountType);
            }
            public QuickFix.Fields.DayBookingInst DayBookingInst
            { 
                get 
                {
                    QuickFix.Fields.DayBookingInst val = new QuickFix.Fields.DayBookingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DayBookingInst val) 
            { 
                this.DayBookingInst = val;
            }
            
            public QuickFix.Fields.DayBookingInst Get(QuickFix.Fields.DayBookingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DayBookingInst val) 
            { 
                return IsSetDayBookingInst();
            }
            
            public bool IsSetDayBookingInst() 
            { 
                return IsSetField(Tags.DayBookingInst);
            }
            public QuickFix.Fields.BookingUnit BookingUnit
            { 
                get 
                {
                    QuickFix.Fields.BookingUnit val = new QuickFix.Fields.BookingUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BookingUnit val) 
            { 
                this.BookingUnit = val;
            }
            
            public QuickFix.Fields.BookingUnit Get(QuickFix.Fields.BookingUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BookingUnit val) 
            { 
                return IsSetBookingUnit();
            }
            
            public bool IsSetBookingUnit() 
            { 
                return IsSetField(Tags.BookingUnit);
            }
            public QuickFix.Fields.PreallocMethod PreallocMethod
            { 
                get 
                {
                    QuickFix.Fields.PreallocMethod val = new QuickFix.Fields.PreallocMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PreallocMethod val) 
            { 
                this.PreallocMethod = val;
            }
            
            public QuickFix.Fields.PreallocMethod Get(QuickFix.Fields.PreallocMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PreallocMethod val) 
            { 
                return IsSetPreallocMethod();
            }
            
            public bool IsSetPreallocMethod() 
            { 
                return IsSetField(Tags.PreallocMethod);
            }
            public QuickFix.Fields.SettlType SettlType
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
                this.SettlType = val;
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
            public QuickFix.Fields.SettlDate SettlDate
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
                this.SettlDate = val;
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
            public QuickFix.Fields.CashMargin CashMargin
            { 
                get 
                {
                    QuickFix.Fields.CashMargin val = new QuickFix.Fields.CashMargin();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashMargin val) 
            { 
                this.CashMargin = val;
            }
            
            public QuickFix.Fields.CashMargin Get(QuickFix.Fields.CashMargin val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashMargin val) 
            { 
                return IsSetCashMargin();
            }
            
            public bool IsSetCashMargin() 
            { 
                return IsSetField(Tags.CashMargin);
            }
            public QuickFix.Fields.ClearingFeeIndicator ClearingFeeIndicator
            { 
                get 
                {
                    QuickFix.Fields.ClearingFeeIndicator val = new QuickFix.Fields.ClearingFeeIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                this.ClearingFeeIndicator = val;
            }
            
            public QuickFix.Fields.ClearingFeeIndicator Get(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingFeeIndicator val) 
            { 
                return IsSetClearingFeeIndicator();
            }
            
            public bool IsSetClearingFeeIndicator() 
            { 
                return IsSetField(Tags.ClearingFeeIndicator);
            }
            public QuickFix.Fields.Symbol Symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Symbol val) 
            { 
                this.Symbol = val;
            }
            
            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Symbol val) 
            { 
                return IsSetSymbol();
            }
            
            public bool IsSetSymbol() 
            { 
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx SymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SymbolSfx val) 
            { 
                this.SymbolSfx = val;
            }
            
            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SymbolSfx val) 
            { 
                return IsSetSymbolSfx();
            }
            
            public bool IsSetSymbolSfx() 
            { 
                return IsSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID SecurityID
            { 
                get 
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityID val) 
            { 
                this.SecurityID = val;
            }
            
            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityID val) 
            { 
                return IsSetSecurityID();
            }
            
            public bool IsSetSecurityID() 
            { 
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityIDSource val) 
            { 
                this.SecurityIDSource = val;
            }
            
            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityIDSource val) 
            { 
                return IsSetSecurityIDSource();
            }
            
            public bool IsSetSecurityIDSource() 
            { 
                return IsSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSecurityAltID val) 
            { 
                this.NoSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
            { 
                return IsSetNoSecurityAltID();
            }
            
            public bool IsSetNoSecurityAltID() 
            { 
                return IsSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product Product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Product val) 
            { 
                this.Product = val;
            }
            
            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Product val) 
            { 
                return IsSetProduct();
            }
            
            public bool IsSetProduct() 
            { 
                return IsSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode CFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CFICode val) 
            { 
                this.CFICode = val;
            }
            
            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CFICode val) 
            { 
                return IsSetCFICode();
            }
            
            public bool IsSetCFICode() 
            { 
                return IsSetField(Tags.CFICode);
            }
            public QuickFix.Fields.SecurityType SecurityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityType val) 
            { 
                this.SecurityType = val;
            }
            
            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityType val) 
            { 
                return IsSetSecurityType();
            }
            
            public bool IsSetSecurityType() 
            { 
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.SecuritySubType SecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecuritySubType val) 
            { 
                this.SecuritySubType = val;
            }
            
            public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecuritySubType val) 
            { 
                return IsSetSecuritySubType();
            }
            
            public bool IsSetSecuritySubType() 
            { 
                return IsSetField(Tags.SecuritySubType);
            }
            public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityMonthYear val) 
            { 
                this.MaturityMonthYear = val;
            }
            
            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
            { 
                return IsSetMaturityMonthYear();
            }
            
            public bool IsSetMaturityMonthYear() 
            { 
                return IsSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDate MaturityDate
            { 
                get 
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityDate val) 
            { 
                this.MaturityDate = val;
            }
            
            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityDate val) 
            { 
                return IsSetMaturityDate();
            }
            
            public bool IsSetMaturityDate() 
            { 
                return IsSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponPaymentDate val) 
            { 
                this.CouponPaymentDate = val;
            }
            
            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
            { 
                return IsSetCouponPaymentDate();
            }
            
            public bool IsSetCouponPaymentDate() 
            { 
                return IsSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate IssueDate
            { 
                get 
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IssueDate val) 
            { 
                this.IssueDate = val;
            }
            
            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IssueDate val) 
            { 
                return IsSetIssueDate();
            }
            
            public bool IsSetIssueDate() 
            { 
                return IsSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                this.RepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
            { 
                return IsSetRepoCollateralSecurityType();
            }
            
            public bool IsSetRepoCollateralSecurityType() 
            { 
                return IsSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseTerm val) 
            { 
                this.RepurchaseTerm = val;
            }
            
            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
            { 
                return IsSetRepurchaseTerm();
            }
            
            public bool IsSetRepurchaseTerm() 
            { 
                return IsSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RepurchaseRate val) 
            { 
                this.RepurchaseRate = val;
            }
            
            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
            { 
                return IsSetRepurchaseRate();
            }
            
            public bool IsSetRepurchaseRate() 
            { 
                return IsSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor Factor
            { 
                get 
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Factor val) 
            { 
                this.Factor = val;
            }
            
            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Factor val) 
            { 
                return IsSetFactor();
            }
            
            public bool IsSetFactor() 
            { 
                return IsSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating CreditRating
            { 
                get 
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CreditRating val) 
            { 
                this.CreditRating = val;
            }
            
            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CreditRating val) 
            { 
                return IsSetCreditRating();
            }
            
            public bool IsSetCreditRating() 
            { 
                return IsSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry InstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrRegistry val) 
            { 
                this.InstrRegistry = val;
            }
            
            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrRegistry val) 
            { 
                return IsSetInstrRegistry();
            }
            
            public bool IsSetInstrRegistry() 
            { 
                return IsSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CountryOfIssue val) 
            { 
                this.CountryOfIssue = val;
            }
            
            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
            { 
                return IsSetCountryOfIssue();
            }
            
            public bool IsSetCountryOfIssue() 
            { 
                return IsSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                this.StateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
            { 
                return IsSetStateOrProvinceOfIssue();
            }
            
            public bool IsSetStateOrProvinceOfIssue() 
            { 
                return IsSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LocaleOfIssue val) 
            { 
                this.LocaleOfIssue = val;
            }
            
            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
            { 
                return IsSetLocaleOfIssue();
            }
            
            public bool IsSetLocaleOfIssue() 
            { 
                return IsSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate RedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RedemptionDate val) 
            { 
                this.RedemptionDate = val;
            }
            
            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RedemptionDate val) 
            { 
                return IsSetRedemptionDate();
            }
            
            public bool IsSetRedemptionDate() 
            { 
                return IsSetField(Tags.RedemptionDate);
            }
            public QuickFix.Fields.StrikePrice StrikePrice
            { 
                get 
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePrice val) 
            { 
                this.StrikePrice = val;
            }
            
            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePrice val) 
            { 
                return IsSetStrikePrice();
            }
            
            public bool IsSetStrikePrice() 
            { 
                return IsSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.StrikeCurrency StrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeCurrency val) 
            { 
                this.StrikeCurrency = val;
            }
            
            public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
            { 
                return IsSetStrikeCurrency();
            }
            
            public bool IsSetStrikeCurrency() 
            { 
                return IsSetField(Tags.StrikeCurrency);
            }
            public QuickFix.Fields.OptAttribute OptAttribute
            { 
                get 
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptAttribute val) 
            { 
                this.OptAttribute = val;
            }
            
            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptAttribute val) 
            { 
                return IsSetOptAttribute();
            }
            
            public bool IsSetOptAttribute() 
            { 
                return IsSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier ContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplier val) 
            { 
                this.ContractMultiplier = val;
            }
            
            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
            { 
                return IsSetContractMultiplier();
            }
            
            public bool IsSetContractMultiplier() 
            { 
                return IsSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate CouponRate
            { 
                get 
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CouponRate val) 
            { 
                this.CouponRate = val;
            }
            
            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CouponRate val) 
            { 
                return IsSetCouponRate();
            }
            
            public bool IsSetCouponRate() 
            { 
                return IsSetField(Tags.CouponRate);
            }
            public QuickFix.Fields.SecurityExchange SecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityExchange val) 
            { 
                this.SecurityExchange = val;
            }
            
            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityExchange val) 
            { 
                return IsSetSecurityExchange();
            }
            
            public bool IsSetSecurityExchange() 
            { 
                return IsSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer Issuer
            { 
                get 
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Issuer val) 
            { 
                this.Issuer = val;
            }
            
            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Issuer val) 
            { 
                return IsSetIssuer();
            }
            
            public bool IsSetIssuer() 
            { 
                return IsSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                this.EncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
            { 
                return IsSetEncodedIssuerLen();
            }
            
            public bool IsSetEncodedIssuerLen() 
            { 
                return IsSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer EncodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedIssuer val) 
            { 
                this.EncodedIssuer = val;
            }
            
            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
            { 
                return IsSetEncodedIssuer();
            }
            
            public bool IsSetEncodedIssuer() 
            { 
                return IsSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc SecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityDesc val) 
            { 
                this.SecurityDesc = val;
            }
            
            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityDesc val) 
            { 
                return IsSetSecurityDesc();
            }
            
            public bool IsSetSecurityDesc() 
            { 
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                this.EncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
            { 
                return IsSetEncodedSecurityDescLen();
            }
            
            public bool IsSetEncodedSecurityDescLen() 
            { 
                return IsSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                this.EncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
            { 
                return IsSetEncodedSecurityDesc();
            }
            
            public bool IsSetEncodedSecurityDesc() 
            { 
                return IsSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Pool Pool
            { 
                get 
                {
                    QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Pool val) 
            { 
                this.Pool = val;
            }
            
            public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Pool val) 
            { 
                return IsSetPool();
            }
            
            public bool IsSetPool() 
            { 
                return IsSetField(Tags.Pool);
            }
            public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractSettlMonth val) 
            { 
                this.ContractSettlMonth = val;
            }
            
            public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
            { 
                return IsSetContractSettlMonth();
            }
            
            public bool IsSetContractSettlMonth() 
            { 
                return IsSetField(Tags.ContractSettlMonth);
            }
            public QuickFix.Fields.CPProgram CPProgram
            { 
                get 
                {
                    QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPProgram val) 
            { 
                this.CPProgram = val;
            }
            
            public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPProgram val) 
            { 
                return IsSetCPProgram();
            }
            
            public bool IsSetCPProgram() 
            { 
                return IsSetField(Tags.CPProgram);
            }
            public QuickFix.Fields.CPRegType CPRegType
            { 
                get 
                {
                    QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CPRegType val) 
            { 
                this.CPRegType = val;
            }
            
            public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CPRegType val) 
            { 
                return IsSetCPRegType();
            }
            
            public bool IsSetCPRegType() 
            { 
                return IsSetField(Tags.CPRegType);
            }
            public QuickFix.Fields.NoEvents NoEvents
            { 
                get 
                {
                    QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoEvents val) 
            { 
                this.NoEvents = val;
            }
            
            public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoEvents val) 
            { 
                return IsSetNoEvents();
            }
            
            public bool IsSetNoEvents() 
            { 
                return IsSetField(Tags.NoEvents);
            }
            public QuickFix.Fields.DatedDate DatedDate
            { 
                get 
                {
                    QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DatedDate val) 
            { 
                this.DatedDate = val;
            }
            
            public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DatedDate val) 
            { 
                return IsSetDatedDate();
            }
            
            public bool IsSetDatedDate() 
            { 
                return IsSetField(Tags.DatedDate);
            }
            public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
            { 
                get 
                {
                    QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAccrualDate val) 
            { 
                this.InterestAccrualDate = val;
            }
            
            public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
            { 
                return IsSetInterestAccrualDate();
            }
            
            public bool IsSetInterestAccrualDate() 
            { 
                return IsSetField(Tags.InterestAccrualDate);
            }
            public QuickFix.Fields.SecurityStatus SecurityStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityStatus val) 
            { 
                this.SecurityStatus = val;
            }
            
            public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityStatus val) 
            { 
                return IsSetSecurityStatus();
            }
            
            public bool IsSetSecurityStatus() 
            { 
                return IsSetField(Tags.SecurityStatus);
            }
            public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                this.SettleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) 
            { 
                return IsSetSettleOnOpenFlag();
            }
            
            public bool IsSetSettleOnOpenFlag() 
            { 
                return IsSetField(Tags.SettleOnOpenFlag);
            }
            public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                this.InstrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
            { 
                return IsSetInstrmtAssignmentMethod();
            }
            
            public bool IsSetInstrmtAssignmentMethod() 
            { 
                return IsSetField(Tags.InstrmtAssignmentMethod);
            }
            public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeMultiplier val) 
            { 
                this.StrikeMultiplier = val;
            }
            
            public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeMultiplier val) 
            { 
                return IsSetStrikeMultiplier();
            }
            
            public bool IsSetStrikeMultiplier() 
            { 
                return IsSetField(Tags.StrikeMultiplier);
            }
            public QuickFix.Fields.StrikeValue StrikeValue
            { 
                get 
                {
                    QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikeValue val) 
            { 
                this.StrikeValue = val;
            }
            
            public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikeValue val) 
            { 
                return IsSetStrikeValue();
            }
            
            public bool IsSetStrikeValue() 
            { 
                return IsSetField(Tags.StrikeValue);
            }
            public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrement val) 
            { 
                this.MinPriceIncrement = val;
            }
            
            public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrement val) 
            { 
                return IsSetMinPriceIncrement();
            }
            
            public bool IsSetMinPriceIncrement() 
            { 
                return IsSetField(Tags.MinPriceIncrement);
            }
            public QuickFix.Fields.PositionLimit PositionLimit
            { 
                get 
                {
                    QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionLimit val) 
            { 
                this.PositionLimit = val;
            }
            
            public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionLimit val) 
            { 
                return IsSetPositionLimit();
            }
            
            public bool IsSetPositionLimit() 
            { 
                return IsSetField(Tags.PositionLimit);
            }
            public QuickFix.Fields.NTPositionLimit NTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NTPositionLimit val) 
            { 
                this.NTPositionLimit = val;
            }
            
            public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NTPositionLimit val) 
            { 
                return IsSetNTPositionLimit();
            }
            
            public bool IsSetNTPositionLimit() 
            { 
                return IsSetField(Tags.NTPositionLimit);
            }
            public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoInstrumentParties val) 
            { 
                this.NoInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoInstrumentParties val) 
            { 
                return IsSetNoInstrumentParties();
            }
            
            public bool IsSetNoInstrumentParties() 
            { 
                return IsSetField(Tags.NoInstrumentParties);
            }
            public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasure val) 
            { 
                this.UnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
            { 
                return IsSetUnitOfMeasure();
            }
            
            public bool IsSetUnitOfMeasure() 
            { 
                return IsSetField(Tags.UnitOfMeasure);
            }
            public QuickFix.Fields.TimeUnit TimeUnit
            { 
                get 
                {
                    QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeUnit val) 
            { 
                this.TimeUnit = val;
            }
            
            public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeUnit val) 
            { 
                return IsSetTimeUnit();
            }
            
            public bool IsSetTimeUnit() 
            { 
                return IsSetField(Tags.TimeUnit);
            }
            public QuickFix.Fields.MaturityTime MaturityTime
            { 
                get 
                {
                    QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaturityTime val) 
            { 
                this.MaturityTime = val;
            }
            
            public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaturityTime val) 
            { 
                return IsSetMaturityTime();
            }
            
            public bool IsSetMaturityTime() 
            { 
                return IsSetField(Tags.MaturityTime);
            }
            public QuickFix.Fields.SecurityGroup SecurityGroup
            { 
                get 
                {
                    QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityGroup val) 
            { 
                this.SecurityGroup = val;
            }
            
            public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityGroup val) 
            { 
                return IsSetSecurityGroup();
            }
            
            public bool IsSetSecurityGroup() 
            { 
                return IsSetField(Tags.SecurityGroup);
            }
            public QuickFix.Fields.MinPriceIncrementAmount MinPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                this.MinPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) 
            { 
                return IsSetMinPriceIncrementAmount();
            }
            
            public bool IsSetMinPriceIncrementAmount() 
            { 
                return IsSetField(Tags.MinPriceIncrementAmount);
            }
            public QuickFix.Fields.UnitOfMeasureQty UnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                this.UnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) 
            { 
                return IsSetUnitOfMeasureQty();
            }
            
            public bool IsSetUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.UnitOfMeasureQty);
            }
            public QuickFix.Fields.SecurityXMLLen SecurityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLLen val) 
            { 
                this.SecurityXMLLen = val;
            }
            
            public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLLen val) 
            { 
                return IsSetSecurityXMLLen();
            }
            
            public bool IsSetSecurityXMLLen() 
            { 
                return IsSetField(Tags.SecurityXMLLen);
            }
            public QuickFix.Fields.SecurityXML SecurityXML
            { 
                get 
                {
                    QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXML val) 
            { 
                this.SecurityXML = val;
            }
            
            public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXML val) 
            { 
                return IsSetSecurityXML();
            }
            
            public bool IsSetSecurityXML() 
            { 
                return IsSetField(Tags.SecurityXML);
            }
            public QuickFix.Fields.SecurityXMLSchema SecurityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                this.SecurityXMLSchema = val;
            }
            
            public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) 
            { 
                return IsSetSecurityXMLSchema();
            }
            
            public bool IsSetSecurityXMLSchema() 
            { 
                return IsSetField(Tags.SecurityXMLSchema);
            }
            public QuickFix.Fields.ProductComplex ProductComplex
            { 
                get 
                {
                    QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ProductComplex val) 
            { 
                this.ProductComplex = val;
            }
            
            public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ProductComplex val) 
            { 
                return IsSetProductComplex();
            }
            
            public bool IsSetProductComplex() 
            { 
                return IsSetField(Tags.ProductComplex);
            }
            public QuickFix.Fields.PriceUnitOfMeasure PriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                this.PriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) 
            { 
                return IsSetPriceUnitOfMeasure();
            }
            
            public bool IsSetPriceUnitOfMeasure() 
            { 
                return IsSetField(Tags.PriceUnitOfMeasure);
            }
            public QuickFix.Fields.PriceUnitOfMeasureQty PriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                this.PriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
            { 
                return IsSetPriceUnitOfMeasureQty();
            }
            
            public bool IsSetPriceUnitOfMeasureQty() 
            { 
                return IsSetField(Tags.PriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.SettlMethod SettlMethod
            { 
                get 
                {
                    QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlMethod val) 
            { 
                this.SettlMethod = val;
            }
            
            public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlMethod val) 
            { 
                return IsSetSettlMethod();
            }
            
            public bool IsSetSettlMethod() 
            { 
                return IsSetField(Tags.SettlMethod);
            }
            public QuickFix.Fields.ExerciseStyle ExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExerciseStyle val) 
            { 
                this.ExerciseStyle = val;
            }
            
            public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExerciseStyle val) 
            { 
                return IsSetExerciseStyle();
            }
            
            public bool IsSetExerciseStyle() 
            { 
                return IsSetField(Tags.ExerciseStyle);
            }
            public QuickFix.Fields.OptPayoutAmount OptPayoutAmount
            { 
                get 
                {
                    QuickFix.Fields.OptPayoutAmount val = new QuickFix.Fields.OptPayoutAmount();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptPayoutAmount val) 
            { 
                this.OptPayoutAmount = val;
            }
            
            public QuickFix.Fields.OptPayoutAmount Get(QuickFix.Fields.OptPayoutAmount val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptPayoutAmount val) 
            { 
                return IsSetOptPayoutAmount();
            }
            
            public bool IsSetOptPayoutAmount() 
            { 
                return IsSetField(Tags.OptPayoutAmount);
            }
            public QuickFix.Fields.PriceQuoteMethod PriceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                this.PriceQuoteMethod = val;
            }
            
            public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) 
            { 
                return IsSetPriceQuoteMethod();
            }
            
            public bool IsSetPriceQuoteMethod() 
            { 
                return IsSetField(Tags.PriceQuoteMethod);
            }
            public QuickFix.Fields.ListMethod ListMethod
            { 
                get 
                {
                    QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ListMethod val) 
            { 
                this.ListMethod = val;
            }
            
            public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ListMethod val) 
            { 
                return IsSetListMethod();
            }
            
            public bool IsSetListMethod() 
            { 
                return IsSetField(Tags.ListMethod);
            }
            public QuickFix.Fields.CapPrice CapPrice
            { 
                get 
                {
                    QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CapPrice val) 
            { 
                this.CapPrice = val;
            }
            
            public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CapPrice val) 
            { 
                return IsSetCapPrice();
            }
            
            public bool IsSetCapPrice() 
            { 
                return IsSetField(Tags.CapPrice);
            }
            public QuickFix.Fields.FloorPrice FloorPrice
            { 
                get 
                {
                    QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FloorPrice val) 
            { 
                this.FloorPrice = val;
            }
            
            public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FloorPrice val) 
            { 
                return IsSetFloorPrice();
            }
            
            public bool IsSetFloorPrice() 
            { 
                return IsSetField(Tags.FloorPrice);
            }
            public QuickFix.Fields.PutOrCall PutOrCall
            { 
                get 
                {
                    QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PutOrCall val) 
            { 
                this.PutOrCall = val;
            }
            
            public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PutOrCall val) 
            { 
                return IsSetPutOrCall();
            }
            
            public bool IsSetPutOrCall() 
            { 
                return IsSetField(Tags.PutOrCall);
            }
            public QuickFix.Fields.FlexibleIndicator FlexibleIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexibleIndicator val) 
            { 
                this.FlexibleIndicator = val;
            }
            
            public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexibleIndicator val) 
            { 
                return IsSetFlexibleIndicator();
            }
            
            public bool IsSetFlexibleIndicator() 
            { 
                return IsSetField(Tags.FlexibleIndicator);
            }
            public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                this.FlexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
            { 
                return IsSetFlexProductEligibilityIndicator();
            }
            
            public bool IsSetFlexProductEligibilityIndicator() 
            { 
                return IsSetField(Tags.FlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.ValuationMethod ValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.ValuationMethod val = new QuickFix.Fields.ValuationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ValuationMethod val) 
            { 
                this.ValuationMethod = val;
            }
            
            public QuickFix.Fields.ValuationMethod Get(QuickFix.Fields.ValuationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ValuationMethod val) 
            { 
                return IsSetValuationMethod();
            }
            
            public bool IsSetValuationMethod() 
            { 
                return IsSetField(Tags.ValuationMethod);
            }
            public QuickFix.Fields.ContractMultiplierUnit ContractMultiplierUnit
            { 
                get 
                {
                    QuickFix.Fields.ContractMultiplierUnit val = new QuickFix.Fields.ContractMultiplierUnit();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ContractMultiplierUnit val) 
            { 
                this.ContractMultiplierUnit = val;
            }
            
            public QuickFix.Fields.ContractMultiplierUnit Get(QuickFix.Fields.ContractMultiplierUnit val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ContractMultiplierUnit val) 
            { 
                return IsSetContractMultiplierUnit();
            }
            
            public bool IsSetContractMultiplierUnit() 
            { 
                return IsSetField(Tags.ContractMultiplierUnit);
            }
            public QuickFix.Fields.FlowScheduleType FlowScheduleType
            { 
                get 
                {
                    QuickFix.Fields.FlowScheduleType val = new QuickFix.Fields.FlowScheduleType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FlowScheduleType val) 
            { 
                this.FlowScheduleType = val;
            }
            
            public QuickFix.Fields.FlowScheduleType Get(QuickFix.Fields.FlowScheduleType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FlowScheduleType val) 
            { 
                return IsSetFlowScheduleType();
            }
            
            public bool IsSetFlowScheduleType() 
            { 
                return IsSetField(Tags.FlowScheduleType);
            }
            public QuickFix.Fields.RestructuringType RestructuringType
            { 
                get 
                {
                    QuickFix.Fields.RestructuringType val = new QuickFix.Fields.RestructuringType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RestructuringType val) 
            { 
                this.RestructuringType = val;
            }
            
            public QuickFix.Fields.RestructuringType Get(QuickFix.Fields.RestructuringType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RestructuringType val) 
            { 
                return IsSetRestructuringType();
            }
            
            public bool IsSetRestructuringType() 
            { 
                return IsSetField(Tags.RestructuringType);
            }
            public QuickFix.Fields.Seniority Seniority
            { 
                get 
                {
                    QuickFix.Fields.Seniority val = new QuickFix.Fields.Seniority();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Seniority val) 
            { 
                this.Seniority = val;
            }
            
            public QuickFix.Fields.Seniority Get(QuickFix.Fields.Seniority val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Seniority val) 
            { 
                return IsSetSeniority();
            }
            
            public bool IsSetSeniority() 
            { 
                return IsSetField(Tags.Seniority);
            }
            public QuickFix.Fields.NotionalPercentageOutstanding NotionalPercentageOutstanding
            { 
                get 
                {
                    QuickFix.Fields.NotionalPercentageOutstanding val = new QuickFix.Fields.NotionalPercentageOutstanding();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NotionalPercentageOutstanding val) 
            { 
                this.NotionalPercentageOutstanding = val;
            }
            
            public QuickFix.Fields.NotionalPercentageOutstanding Get(QuickFix.Fields.NotionalPercentageOutstanding val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NotionalPercentageOutstanding val) 
            { 
                return IsSetNotionalPercentageOutstanding();
            }
            
            public bool IsSetNotionalPercentageOutstanding() 
            { 
                return IsSetField(Tags.NotionalPercentageOutstanding);
            }
            public QuickFix.Fields.OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
            { 
                get 
                {
                    QuickFix.Fields.OriginalNotionalPercentageOutstanding val = new QuickFix.Fields.OriginalNotionalPercentageOutstanding();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
            { 
                this.OriginalNotionalPercentageOutstanding = val;
            }
            
            public QuickFix.Fields.OriginalNotionalPercentageOutstanding Get(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
            { 
                return IsSetOriginalNotionalPercentageOutstanding();
            }
            
            public bool IsSetOriginalNotionalPercentageOutstanding() 
            { 
                return IsSetField(Tags.OriginalNotionalPercentageOutstanding);
            }
            public QuickFix.Fields.AttachmentPoint AttachmentPoint
            { 
                get 
                {
                    QuickFix.Fields.AttachmentPoint val = new QuickFix.Fields.AttachmentPoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AttachmentPoint val) 
            { 
                this.AttachmentPoint = val;
            }
            
            public QuickFix.Fields.AttachmentPoint Get(QuickFix.Fields.AttachmentPoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AttachmentPoint val) 
            { 
                return IsSetAttachmentPoint();
            }
            
            public bool IsSetAttachmentPoint() 
            { 
                return IsSetField(Tags.AttachmentPoint);
            }
            public QuickFix.Fields.DetachmentPoint DetachmentPoint
            { 
                get 
                {
                    QuickFix.Fields.DetachmentPoint val = new QuickFix.Fields.DetachmentPoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DetachmentPoint val) 
            { 
                this.DetachmentPoint = val;
            }
            
            public QuickFix.Fields.DetachmentPoint Get(QuickFix.Fields.DetachmentPoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DetachmentPoint val) 
            { 
                return IsSetDetachmentPoint();
            }
            
            public bool IsSetDetachmentPoint() 
            { 
                return IsSetField(Tags.DetachmentPoint);
            }
            public QuickFix.Fields.StrikePriceDeterminationMethod StrikePriceDeterminationMethod
            { 
                get 
                {
                    QuickFix.Fields.StrikePriceDeterminationMethod val = new QuickFix.Fields.StrikePriceDeterminationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePriceDeterminationMethod val) 
            { 
                this.StrikePriceDeterminationMethod = val;
            }
            
            public QuickFix.Fields.StrikePriceDeterminationMethod Get(QuickFix.Fields.StrikePriceDeterminationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePriceDeterminationMethod val) 
            { 
                return IsSetStrikePriceDeterminationMethod();
            }
            
            public bool IsSetStrikePriceDeterminationMethod() 
            { 
                return IsSetField(Tags.StrikePriceDeterminationMethod);
            }
            public QuickFix.Fields.StrikePriceBoundaryMethod StrikePriceBoundaryMethod
            { 
                get 
                {
                    QuickFix.Fields.StrikePriceBoundaryMethod val = new QuickFix.Fields.StrikePriceBoundaryMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePriceBoundaryMethod val) 
            { 
                this.StrikePriceBoundaryMethod = val;
            }
            
            public QuickFix.Fields.StrikePriceBoundaryMethod Get(QuickFix.Fields.StrikePriceBoundaryMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePriceBoundaryMethod val) 
            { 
                return IsSetStrikePriceBoundaryMethod();
            }
            
            public bool IsSetStrikePriceBoundaryMethod() 
            { 
                return IsSetField(Tags.StrikePriceBoundaryMethod);
            }
            public QuickFix.Fields.StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
            { 
                get 
                {
                    QuickFix.Fields.StrikePriceBoundaryPrecision val = new QuickFix.Fields.StrikePriceBoundaryPrecision();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
            { 
                this.StrikePriceBoundaryPrecision = val;
            }
            
            public QuickFix.Fields.StrikePriceBoundaryPrecision Get(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
            { 
                return IsSetStrikePriceBoundaryPrecision();
            }
            
            public bool IsSetStrikePriceBoundaryPrecision() 
            { 
                return IsSetField(Tags.StrikePriceBoundaryPrecision);
            }
            public QuickFix.Fields.UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceDeterminationMethod val = new QuickFix.Fields.UnderlyingPriceDeterminationMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
            { 
                this.UnderlyingPriceDeterminationMethod = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceDeterminationMethod Get(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
            { 
                return IsSetUnderlyingPriceDeterminationMethod();
            }
            
            public bool IsSetUnderlyingPriceDeterminationMethod() 
            { 
                return IsSetField(Tags.UnderlyingPriceDeterminationMethod);
            }
            public QuickFix.Fields.OptPayoutType OptPayoutType
            { 
                get 
                {
                    QuickFix.Fields.OptPayoutType val = new QuickFix.Fields.OptPayoutType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OptPayoutType val) 
            { 
                this.OptPayoutType = val;
            }
            
            public QuickFix.Fields.OptPayoutType Get(QuickFix.Fields.OptPayoutType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OptPayoutType val) 
            { 
                return IsSetOptPayoutType();
            }
            
            public bool IsSetOptPayoutType() 
            { 
                return IsSetField(Tags.OptPayoutType);
            }
            public QuickFix.Fields.NoComplexEvents NoComplexEvents
            { 
                get 
                {
                    QuickFix.Fields.NoComplexEvents val = new QuickFix.Fields.NoComplexEvents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoComplexEvents val) 
            { 
                this.NoComplexEvents = val;
            }
            
            public QuickFix.Fields.NoComplexEvents Get(QuickFix.Fields.NoComplexEvents val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoComplexEvents val) 
            { 
                return IsSetNoComplexEvents();
            }
            
            public bool IsSetNoComplexEvents() 
            { 
                return IsSetField(Tags.NoComplexEvents);
            }
            public QuickFix.Fields.AgreementDesc AgreementDesc
            { 
                get 
                {
                    QuickFix.Fields.AgreementDesc val = new QuickFix.Fields.AgreementDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AgreementDesc val) 
            { 
                this.AgreementDesc = val;
            }
            
            public QuickFix.Fields.AgreementDesc Get(QuickFix.Fields.AgreementDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AgreementDesc val) 
            { 
                return IsSetAgreementDesc();
            }
            
            public bool IsSetAgreementDesc() 
            { 
                return IsSetField(Tags.AgreementDesc);
            }
            public QuickFix.Fields.AgreementID AgreementID
            { 
                get 
                {
                    QuickFix.Fields.AgreementID val = new QuickFix.Fields.AgreementID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AgreementID val) 
            { 
                this.AgreementID = val;
            }
            
            public QuickFix.Fields.AgreementID Get(QuickFix.Fields.AgreementID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AgreementID val) 
            { 
                return IsSetAgreementID();
            }
            
            public bool IsSetAgreementID() 
            { 
                return IsSetField(Tags.AgreementID);
            }
            public QuickFix.Fields.AgreementDate AgreementDate
            { 
                get 
                {
                    QuickFix.Fields.AgreementDate val = new QuickFix.Fields.AgreementDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AgreementDate val) 
            { 
                this.AgreementDate = val;
            }
            
            public QuickFix.Fields.AgreementDate Get(QuickFix.Fields.AgreementDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AgreementDate val) 
            { 
                return IsSetAgreementDate();
            }
            
            public bool IsSetAgreementDate() 
            { 
                return IsSetField(Tags.AgreementDate);
            }
            public QuickFix.Fields.AgreementCurrency AgreementCurrency
            { 
                get 
                {
                    QuickFix.Fields.AgreementCurrency val = new QuickFix.Fields.AgreementCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AgreementCurrency val) 
            { 
                this.AgreementCurrency = val;
            }
            
            public QuickFix.Fields.AgreementCurrency Get(QuickFix.Fields.AgreementCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AgreementCurrency val) 
            { 
                return IsSetAgreementCurrency();
            }
            
            public bool IsSetAgreementCurrency() 
            { 
                return IsSetField(Tags.AgreementCurrency);
            }
            public QuickFix.Fields.TerminationType TerminationType
            { 
                get 
                {
                    QuickFix.Fields.TerminationType val = new QuickFix.Fields.TerminationType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TerminationType val) 
            { 
                this.TerminationType = val;
            }
            
            public QuickFix.Fields.TerminationType Get(QuickFix.Fields.TerminationType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TerminationType val) 
            { 
                return IsSetTerminationType();
            }
            
            public bool IsSetTerminationType() 
            { 
                return IsSetField(Tags.TerminationType);
            }
            public QuickFix.Fields.StartDate StartDate
            { 
                get 
                {
                    QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StartDate val) 
            { 
                this.StartDate = val;
            }
            
            public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StartDate val) 
            { 
                return IsSetStartDate();
            }
            
            public bool IsSetStartDate() 
            { 
                return IsSetField(Tags.StartDate);
            }
            public QuickFix.Fields.EndDate EndDate
            { 
                get 
                {
                    QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EndDate val) 
            { 
                this.EndDate = val;
            }
            
            public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EndDate val) 
            { 
                return IsSetEndDate();
            }
            
            public bool IsSetEndDate() 
            { 
                return IsSetField(Tags.EndDate);
            }
            public QuickFix.Fields.DeliveryType DeliveryType
            { 
                get 
                {
                    QuickFix.Fields.DeliveryType val = new QuickFix.Fields.DeliveryType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DeliveryType val) 
            { 
                this.DeliveryType = val;
            }
            
            public QuickFix.Fields.DeliveryType Get(QuickFix.Fields.DeliveryType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DeliveryType val) 
            { 
                return IsSetDeliveryType();
            }
            
            public bool IsSetDeliveryType() 
            { 
                return IsSetField(Tags.DeliveryType);
            }
            public QuickFix.Fields.MarginRatio MarginRatio
            { 
                get 
                {
                    QuickFix.Fields.MarginRatio val = new QuickFix.Fields.MarginRatio();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MarginRatio val) 
            { 
                this.MarginRatio = val;
            }
            
            public QuickFix.Fields.MarginRatio Get(QuickFix.Fields.MarginRatio val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MarginRatio val) 
            { 
                return IsSetMarginRatio();
            }
            
            public bool IsSetMarginRatio() 
            { 
                return IsSetField(Tags.MarginRatio);
            }
            public QuickFix.Fields.NoUnderlyings NoUnderlyings
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoUnderlyings val) 
            { 
                this.NoUnderlyings = val;
            }
            
            public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoUnderlyings val) 
            { 
                return IsSetNoUnderlyings();
            }
            
            public bool IsSetNoUnderlyings() 
            { 
                return IsSetField(Tags.NoUnderlyings);
            }
            public QuickFix.Fields.Side Side
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
                this.Side = val;
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
            public QuickFix.Fields.NoStipulations NoStipulations
            { 
                get 
                {
                    QuickFix.Fields.NoStipulations val = new QuickFix.Fields.NoStipulations();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoStipulations val) 
            { 
                this.NoStipulations = val;
            }
            
            public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoStipulations val) 
            { 
                return IsSetNoStipulations();
            }
            
            public bool IsSetNoStipulations() 
            { 
                return IsSetField(Tags.NoStipulations);
            }
            public QuickFix.Fields.QtyType QtyType
            { 
                get 
                {
                    QuickFix.Fields.QtyType val = new QuickFix.Fields.QtyType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QtyType val) 
            { 
                this.QtyType = val;
            }
            
            public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QtyType val) 
            { 
                return IsSetQtyType();
            }
            
            public bool IsSetQtyType() 
            { 
                return IsSetField(Tags.QtyType);
            }
            public QuickFix.Fields.OrderQty OrderQty
            { 
                get 
                {
                    QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderQty val) 
            { 
                this.OrderQty = val;
            }
            
            public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderQty val) 
            { 
                return IsSetOrderQty();
            }
            
            public bool IsSetOrderQty() 
            { 
                return IsSetField(Tags.OrderQty);
            }
            public QuickFix.Fields.CashOrderQty CashOrderQty
            { 
                get 
                {
                    QuickFix.Fields.CashOrderQty val = new QuickFix.Fields.CashOrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CashOrderQty val) 
            { 
                this.CashOrderQty = val;
            }
            
            public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CashOrderQty val) 
            { 
                return IsSetCashOrderQty();
            }
            
            public bool IsSetCashOrderQty() 
            { 
                return IsSetField(Tags.CashOrderQty);
            }
            public QuickFix.Fields.OrderPercent OrderPercent
            { 
                get 
                {
                    QuickFix.Fields.OrderPercent val = new QuickFix.Fields.OrderPercent();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderPercent val) 
            { 
                this.OrderPercent = val;
            }
            
            public QuickFix.Fields.OrderPercent Get(QuickFix.Fields.OrderPercent val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderPercent val) 
            { 
                return IsSetOrderPercent();
            }
            
            public bool IsSetOrderPercent() 
            { 
                return IsSetField(Tags.OrderPercent);
            }
            public QuickFix.Fields.RoundingDirection RoundingDirection
            { 
                get 
                {
                    QuickFix.Fields.RoundingDirection val = new QuickFix.Fields.RoundingDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RoundingDirection val) 
            { 
                this.RoundingDirection = val;
            }
            
            public QuickFix.Fields.RoundingDirection Get(QuickFix.Fields.RoundingDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RoundingDirection val) 
            { 
                return IsSetRoundingDirection();
            }
            
            public bool IsSetRoundingDirection() 
            { 
                return IsSetField(Tags.RoundingDirection);
            }
            public QuickFix.Fields.RoundingModulus RoundingModulus
            { 
                get 
                {
                    QuickFix.Fields.RoundingModulus val = new QuickFix.Fields.RoundingModulus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RoundingModulus val) 
            { 
                this.RoundingModulus = val;
            }
            
            public QuickFix.Fields.RoundingModulus Get(QuickFix.Fields.RoundingModulus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RoundingModulus val) 
            { 
                return IsSetRoundingModulus();
            }
            
            public bool IsSetRoundingModulus() 
            { 
                return IsSetField(Tags.RoundingModulus);
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
            public QuickFix.Fields.Price Price
            { 
                get 
                {
                    QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Price val) 
            { 
                this.Price = val;
            }
            
            public QuickFix.Fields.Price Get(QuickFix.Fields.Price val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Price val) 
            { 
                return IsSetPrice();
            }
            
            public bool IsSetPrice() 
            { 
                return IsSetField(Tags.Price);
            }
            public QuickFix.Fields.StopPx StopPx
            { 
                get 
                {
                    QuickFix.Fields.StopPx val = new QuickFix.Fields.StopPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StopPx val) 
            { 
                this.StopPx = val;
            }
            
            public QuickFix.Fields.StopPx Get(QuickFix.Fields.StopPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StopPx val) 
            { 
                return IsSetStopPx();
            }
            
            public bool IsSetStopPx() 
            { 
                return IsSetField(Tags.StopPx);
            }
            public QuickFix.Fields.PegOffsetValue PegOffsetValue
            { 
                get 
                {
                    QuickFix.Fields.PegOffsetValue val = new QuickFix.Fields.PegOffsetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegOffsetValue val) 
            { 
                this.PegOffsetValue = val;
            }
            
            public QuickFix.Fields.PegOffsetValue Get(QuickFix.Fields.PegOffsetValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegOffsetValue val) 
            { 
                return IsSetPegOffsetValue();
            }
            
            public bool IsSetPegOffsetValue() 
            { 
                return IsSetField(Tags.PegOffsetValue);
            }
            public QuickFix.Fields.PegMoveType PegMoveType
            { 
                get 
                {
                    QuickFix.Fields.PegMoveType val = new QuickFix.Fields.PegMoveType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegMoveType val) 
            { 
                this.PegMoveType = val;
            }
            
            public QuickFix.Fields.PegMoveType Get(QuickFix.Fields.PegMoveType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegMoveType val) 
            { 
                return IsSetPegMoveType();
            }
            
            public bool IsSetPegMoveType() 
            { 
                return IsSetField(Tags.PegMoveType);
            }
            public QuickFix.Fields.PegOffsetType PegOffsetType
            { 
                get 
                {
                    QuickFix.Fields.PegOffsetType val = new QuickFix.Fields.PegOffsetType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegOffsetType val) 
            { 
                this.PegOffsetType = val;
            }
            
            public QuickFix.Fields.PegOffsetType Get(QuickFix.Fields.PegOffsetType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegOffsetType val) 
            { 
                return IsSetPegOffsetType();
            }
            
            public bool IsSetPegOffsetType() 
            { 
                return IsSetField(Tags.PegOffsetType);
            }
            public QuickFix.Fields.PegLimitType PegLimitType
            { 
                get 
                {
                    QuickFix.Fields.PegLimitType val = new QuickFix.Fields.PegLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegLimitType val) 
            { 
                this.PegLimitType = val;
            }
            
            public QuickFix.Fields.PegLimitType Get(QuickFix.Fields.PegLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegLimitType val) 
            { 
                return IsSetPegLimitType();
            }
            
            public bool IsSetPegLimitType() 
            { 
                return IsSetField(Tags.PegLimitType);
            }
            public QuickFix.Fields.PegRoundDirection PegRoundDirection
            { 
                get 
                {
                    QuickFix.Fields.PegRoundDirection val = new QuickFix.Fields.PegRoundDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegRoundDirection val) 
            { 
                this.PegRoundDirection = val;
            }
            
            public QuickFix.Fields.PegRoundDirection Get(QuickFix.Fields.PegRoundDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegRoundDirection val) 
            { 
                return IsSetPegRoundDirection();
            }
            
            public bool IsSetPegRoundDirection() 
            { 
                return IsSetField(Tags.PegRoundDirection);
            }
            public QuickFix.Fields.PegScope PegScope
            { 
                get 
                {
                    QuickFix.Fields.PegScope val = new QuickFix.Fields.PegScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegScope val) 
            { 
                this.PegScope = val;
            }
            
            public QuickFix.Fields.PegScope Get(QuickFix.Fields.PegScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegScope val) 
            { 
                return IsSetPegScope();
            }
            
            public bool IsSetPegScope() 
            { 
                return IsSetField(Tags.PegScope);
            }
            public QuickFix.Fields.PegPriceType PegPriceType
            { 
                get 
                {
                    QuickFix.Fields.PegPriceType val = new QuickFix.Fields.PegPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegPriceType val) 
            { 
                this.PegPriceType = val;
            }
            
            public QuickFix.Fields.PegPriceType Get(QuickFix.Fields.PegPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegPriceType val) 
            { 
                return IsSetPegPriceType();
            }
            
            public bool IsSetPegPriceType() 
            { 
                return IsSetField(Tags.PegPriceType);
            }
            public QuickFix.Fields.PegSecurityIDSource PegSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.PegSecurityIDSource val = new QuickFix.Fields.PegSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegSecurityIDSource val) 
            { 
                this.PegSecurityIDSource = val;
            }
            
            public QuickFix.Fields.PegSecurityIDSource Get(QuickFix.Fields.PegSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegSecurityIDSource val) 
            { 
                return IsSetPegSecurityIDSource();
            }
            
            public bool IsSetPegSecurityIDSource() 
            { 
                return IsSetField(Tags.PegSecurityIDSource);
            }
            public QuickFix.Fields.PegSecurityID PegSecurityID
            { 
                get 
                {
                    QuickFix.Fields.PegSecurityID val = new QuickFix.Fields.PegSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegSecurityID val) 
            { 
                this.PegSecurityID = val;
            }
            
            public QuickFix.Fields.PegSecurityID Get(QuickFix.Fields.PegSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegSecurityID val) 
            { 
                return IsSetPegSecurityID();
            }
            
            public bool IsSetPegSecurityID() 
            { 
                return IsSetField(Tags.PegSecurityID);
            }
            public QuickFix.Fields.PegSymbol PegSymbol
            { 
                get 
                {
                    QuickFix.Fields.PegSymbol val = new QuickFix.Fields.PegSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegSymbol val) 
            { 
                this.PegSymbol = val;
            }
            
            public QuickFix.Fields.PegSymbol Get(QuickFix.Fields.PegSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegSymbol val) 
            { 
                return IsSetPegSymbol();
            }
            
            public bool IsSetPegSymbol() 
            { 
                return IsSetField(Tags.PegSymbol);
            }
            public QuickFix.Fields.PegSecurityDesc PegSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.PegSecurityDesc val = new QuickFix.Fields.PegSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PegSecurityDesc val) 
            { 
                this.PegSecurityDesc = val;
            }
            
            public QuickFix.Fields.PegSecurityDesc Get(QuickFix.Fields.PegSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PegSecurityDesc val) 
            { 
                return IsSetPegSecurityDesc();
            }
            
            public bool IsSetPegSecurityDesc() 
            { 
                return IsSetField(Tags.PegSecurityDesc);
            }
            public QuickFix.Fields.DiscretionInst DiscretionInst
            { 
                get 
                {
                    QuickFix.Fields.DiscretionInst val = new QuickFix.Fields.DiscretionInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionInst val) 
            { 
                this.DiscretionInst = val;
            }
            
            public QuickFix.Fields.DiscretionInst Get(QuickFix.Fields.DiscretionInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionInst val) 
            { 
                return IsSetDiscretionInst();
            }
            
            public bool IsSetDiscretionInst() 
            { 
                return IsSetField(Tags.DiscretionInst);
            }
            public QuickFix.Fields.DiscretionOffsetValue DiscretionOffsetValue
            { 
                get 
                {
                    QuickFix.Fields.DiscretionOffsetValue val = new QuickFix.Fields.DiscretionOffsetValue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionOffsetValue val) 
            { 
                this.DiscretionOffsetValue = val;
            }
            
            public QuickFix.Fields.DiscretionOffsetValue Get(QuickFix.Fields.DiscretionOffsetValue val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionOffsetValue val) 
            { 
                return IsSetDiscretionOffsetValue();
            }
            
            public bool IsSetDiscretionOffsetValue() 
            { 
                return IsSetField(Tags.DiscretionOffsetValue);
            }
            public QuickFix.Fields.DiscretionMoveType DiscretionMoveType
            { 
                get 
                {
                    QuickFix.Fields.DiscretionMoveType val = new QuickFix.Fields.DiscretionMoveType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionMoveType val) 
            { 
                this.DiscretionMoveType = val;
            }
            
            public QuickFix.Fields.DiscretionMoveType Get(QuickFix.Fields.DiscretionMoveType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionMoveType val) 
            { 
                return IsSetDiscretionMoveType();
            }
            
            public bool IsSetDiscretionMoveType() 
            { 
                return IsSetField(Tags.DiscretionMoveType);
            }
            public QuickFix.Fields.DiscretionOffsetType DiscretionOffsetType
            { 
                get 
                {
                    QuickFix.Fields.DiscretionOffsetType val = new QuickFix.Fields.DiscretionOffsetType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionOffsetType val) 
            { 
                this.DiscretionOffsetType = val;
            }
            
            public QuickFix.Fields.DiscretionOffsetType Get(QuickFix.Fields.DiscretionOffsetType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionOffsetType val) 
            { 
                return IsSetDiscretionOffsetType();
            }
            
            public bool IsSetDiscretionOffsetType() 
            { 
                return IsSetField(Tags.DiscretionOffsetType);
            }
            public QuickFix.Fields.DiscretionLimitType DiscretionLimitType
            { 
                get 
                {
                    QuickFix.Fields.DiscretionLimitType val = new QuickFix.Fields.DiscretionLimitType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionLimitType val) 
            { 
                this.DiscretionLimitType = val;
            }
            
            public QuickFix.Fields.DiscretionLimitType Get(QuickFix.Fields.DiscretionLimitType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionLimitType val) 
            { 
                return IsSetDiscretionLimitType();
            }
            
            public bool IsSetDiscretionLimitType() 
            { 
                return IsSetField(Tags.DiscretionLimitType);
            }
            public QuickFix.Fields.DiscretionRoundDirection DiscretionRoundDirection
            { 
                get 
                {
                    QuickFix.Fields.DiscretionRoundDirection val = new QuickFix.Fields.DiscretionRoundDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionRoundDirection val) 
            { 
                this.DiscretionRoundDirection = val;
            }
            
            public QuickFix.Fields.DiscretionRoundDirection Get(QuickFix.Fields.DiscretionRoundDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionRoundDirection val) 
            { 
                return IsSetDiscretionRoundDirection();
            }
            
            public bool IsSetDiscretionRoundDirection() 
            { 
                return IsSetField(Tags.DiscretionRoundDirection);
            }
            public QuickFix.Fields.DiscretionScope DiscretionScope
            { 
                get 
                {
                    QuickFix.Fields.DiscretionScope val = new QuickFix.Fields.DiscretionScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionScope val) 
            { 
                this.DiscretionScope = val;
            }
            
            public QuickFix.Fields.DiscretionScope Get(QuickFix.Fields.DiscretionScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionScope val) 
            { 
                return IsSetDiscretionScope();
            }
            
            public bool IsSetDiscretionScope() 
            { 
                return IsSetField(Tags.DiscretionScope);
            }
            public QuickFix.Fields.PeggedPrice PeggedPrice
            { 
                get 
                {
                    QuickFix.Fields.PeggedPrice val = new QuickFix.Fields.PeggedPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PeggedPrice val) 
            { 
                this.PeggedPrice = val;
            }
            
            public QuickFix.Fields.PeggedPrice Get(QuickFix.Fields.PeggedPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PeggedPrice val) 
            { 
                return IsSetPeggedPrice();
            }
            
            public bool IsSetPeggedPrice() 
            { 
                return IsSetField(Tags.PeggedPrice);
            }
            public QuickFix.Fields.DiscretionPrice DiscretionPrice
            { 
                get 
                {
                    QuickFix.Fields.DiscretionPrice val = new QuickFix.Fields.DiscretionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DiscretionPrice val) 
            { 
                this.DiscretionPrice = val;
            }
            
            public QuickFix.Fields.DiscretionPrice Get(QuickFix.Fields.DiscretionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DiscretionPrice val) 
            { 
                return IsSetDiscretionPrice();
            }
            
            public bool IsSetDiscretionPrice() 
            { 
                return IsSetField(Tags.DiscretionPrice);
            }
            public QuickFix.Fields.TargetStrategy TargetStrategy
            { 
                get 
                {
                    QuickFix.Fields.TargetStrategy val = new QuickFix.Fields.TargetStrategy();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TargetStrategy val) 
            { 
                this.TargetStrategy = val;
            }
            
            public QuickFix.Fields.TargetStrategy Get(QuickFix.Fields.TargetStrategy val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TargetStrategy val) 
            { 
                return IsSetTargetStrategy();
            }
            
            public bool IsSetTargetStrategy() 
            { 
                return IsSetField(Tags.TargetStrategy);
            }
            public QuickFix.Fields.TargetStrategyParameters TargetStrategyParameters
            { 
                get 
                {
                    QuickFix.Fields.TargetStrategyParameters val = new QuickFix.Fields.TargetStrategyParameters();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TargetStrategyParameters val) 
            { 
                this.TargetStrategyParameters = val;
            }
            
            public QuickFix.Fields.TargetStrategyParameters Get(QuickFix.Fields.TargetStrategyParameters val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TargetStrategyParameters val) 
            { 
                return IsSetTargetStrategyParameters();
            }
            
            public bool IsSetTargetStrategyParameters() 
            { 
                return IsSetField(Tags.TargetStrategyParameters);
            }
            public QuickFix.Fields.ParticipationRate ParticipationRate
            { 
                get 
                {
                    QuickFix.Fields.ParticipationRate val = new QuickFix.Fields.ParticipationRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ParticipationRate val) 
            { 
                this.ParticipationRate = val;
            }
            
            public QuickFix.Fields.ParticipationRate Get(QuickFix.Fields.ParticipationRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ParticipationRate val) 
            { 
                return IsSetParticipationRate();
            }
            
            public bool IsSetParticipationRate() 
            { 
                return IsSetField(Tags.ParticipationRate);
            }
            public QuickFix.Fields.TargetStrategyPerformance TargetStrategyPerformance
            { 
                get 
                {
                    QuickFix.Fields.TargetStrategyPerformance val = new QuickFix.Fields.TargetStrategyPerformance();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TargetStrategyPerformance val) 
            { 
                this.TargetStrategyPerformance = val;
            }
            
            public QuickFix.Fields.TargetStrategyPerformance Get(QuickFix.Fields.TargetStrategyPerformance val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TargetStrategyPerformance val) 
            { 
                return IsSetTargetStrategyPerformance();
            }
            
            public bool IsSetTargetStrategyPerformance() 
            { 
                return IsSetField(Tags.TargetStrategyPerformance);
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
            public QuickFix.Fields.ComplianceID ComplianceID
            { 
                get 
                {
                    QuickFix.Fields.ComplianceID val = new QuickFix.Fields.ComplianceID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ComplianceID val) 
            { 
                this.ComplianceID = val;
            }
            
            public QuickFix.Fields.ComplianceID Get(QuickFix.Fields.ComplianceID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ComplianceID val) 
            { 
                return IsSetComplianceID();
            }
            
            public bool IsSetComplianceID() 
            { 
                return IsSetField(Tags.ComplianceID);
            }
            public QuickFix.Fields.SolicitedFlag SolicitedFlag
            { 
                get 
                {
                    QuickFix.Fields.SolicitedFlag val = new QuickFix.Fields.SolicitedFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SolicitedFlag val) 
            { 
                this.SolicitedFlag = val;
            }
            
            public QuickFix.Fields.SolicitedFlag Get(QuickFix.Fields.SolicitedFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SolicitedFlag val) 
            { 
                return IsSetSolicitedFlag();
            }
            
            public bool IsSetSolicitedFlag() 
            { 
                return IsSetField(Tags.SolicitedFlag);
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
            public QuickFix.Fields.EffectiveTime EffectiveTime
            { 
                get 
                {
                    QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EffectiveTime val) 
            { 
                this.EffectiveTime = val;
            }
            
            public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EffectiveTime val) 
            { 
                return IsSetEffectiveTime();
            }
            
            public bool IsSetEffectiveTime() 
            { 
                return IsSetField(Tags.EffectiveTime);
            }
            public QuickFix.Fields.ExpireDate ExpireDate
            { 
                get 
                {
                    QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExpireDate val) 
            { 
                this.ExpireDate = val;
            }
            
            public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExpireDate val) 
            { 
                return IsSetExpireDate();
            }
            
            public bool IsSetExpireDate() 
            { 
                return IsSetField(Tags.ExpireDate);
            }
            public QuickFix.Fields.ExpireTime ExpireTime
            { 
                get 
                {
                    QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExpireTime val) 
            { 
                this.ExpireTime = val;
            }
            
            public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExpireTime val) 
            { 
                return IsSetExpireTime();
            }
            
            public bool IsSetExpireTime() 
            { 
                return IsSetField(Tags.ExpireTime);
            }
            public QuickFix.Fields.ExecInst ExecInst
            { 
                get 
                {
                    QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecInst val) 
            { 
                this.ExecInst = val;
            }
            
            public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecInst val) 
            { 
                return IsSetExecInst();
            }
            
            public bool IsSetExecInst() 
            { 
                return IsSetField(Tags.ExecInst);
            }
            public QuickFix.Fields.OrderCapacity OrderCapacity
            { 
                get 
                {
                    QuickFix.Fields.OrderCapacity val = new QuickFix.Fields.OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderCapacity val) 
            { 
                this.OrderCapacity = val;
            }
            
            public QuickFix.Fields.OrderCapacity Get(QuickFix.Fields.OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(Tags.OrderCapacity);
            }
            public QuickFix.Fields.OrderRestrictions OrderRestrictions
            { 
                get 
                {
                    QuickFix.Fields.OrderRestrictions val = new QuickFix.Fields.OrderRestrictions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderRestrictions val) 
            { 
                this.OrderRestrictions = val;
            }
            
            public QuickFix.Fields.OrderRestrictions Get(QuickFix.Fields.OrderRestrictions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderRestrictions val) 
            { 
                return IsSetOrderRestrictions();
            }
            
            public bool IsSetOrderRestrictions() 
            { 
                return IsSetField(Tags.OrderRestrictions);
            }
            public QuickFix.Fields.CustOrderCapacity CustOrderCapacity
            { 
                get 
                {
                    QuickFix.Fields.CustOrderCapacity val = new QuickFix.Fields.CustOrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CustOrderCapacity val) 
            { 
                this.CustOrderCapacity = val;
            }
            
            public QuickFix.Fields.CustOrderCapacity Get(QuickFix.Fields.CustOrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CustOrderCapacity val) 
            { 
                return IsSetCustOrderCapacity();
            }
            
            public bool IsSetCustOrderCapacity() 
            { 
                return IsSetField(Tags.CustOrderCapacity);
            }
            public QuickFix.Fields.LastQty LastQty
            { 
                get 
                {
                    QuickFix.Fields.LastQty val = new QuickFix.Fields.LastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastQty val) 
            { 
                this.LastQty = val;
            }
            
            public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastQty val) 
            { 
                return IsSetLastQty();
            }
            
            public bool IsSetLastQty() 
            { 
                return IsSetField(Tags.LastQty);
            }
            public QuickFix.Fields.UnderlyingLastQty UnderlyingLastQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLastQty val = new QuickFix.Fields.UnderlyingLastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingLastQty val) 
            { 
                this.UnderlyingLastQty = val;
            }
            
            public QuickFix.Fields.UnderlyingLastQty Get(QuickFix.Fields.UnderlyingLastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingLastQty val) 
            { 
                return IsSetUnderlyingLastQty();
            }
            
            public bool IsSetUnderlyingLastQty() 
            { 
                return IsSetField(Tags.UnderlyingLastQty);
            }
            public QuickFix.Fields.LastPx LastPx
            { 
                get 
                {
                    QuickFix.Fields.LastPx val = new QuickFix.Fields.LastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastPx val) 
            { 
                this.LastPx = val;
            }
            
            public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastPx val) 
            { 
                return IsSetLastPx();
            }
            
            public bool IsSetLastPx() 
            { 
                return IsSetField(Tags.LastPx);
            }
            public QuickFix.Fields.UnderlyingLastPx UnderlyingLastPx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLastPx val = new QuickFix.Fields.UnderlyingLastPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UnderlyingLastPx val) 
            { 
                this.UnderlyingLastPx = val;
            }
            
            public QuickFix.Fields.UnderlyingLastPx Get(QuickFix.Fields.UnderlyingLastPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UnderlyingLastPx val) 
            { 
                return IsSetUnderlyingLastPx();
            }
            
            public bool IsSetUnderlyingLastPx() 
            { 
                return IsSetField(Tags.UnderlyingLastPx);
            }
            public QuickFix.Fields.LastParPx LastParPx
            { 
                get 
                {
                    QuickFix.Fields.LastParPx val = new QuickFix.Fields.LastParPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastParPx val) 
            { 
                this.LastParPx = val;
            }
            
            public QuickFix.Fields.LastParPx Get(QuickFix.Fields.LastParPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastParPx val) 
            { 
                return IsSetLastParPx();
            }
            
            public bool IsSetLastParPx() 
            { 
                return IsSetField(Tags.LastParPx);
            }
            public QuickFix.Fields.LastSpotRate LastSpotRate
            { 
                get 
                {
                    QuickFix.Fields.LastSpotRate val = new QuickFix.Fields.LastSpotRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastSpotRate val) 
            { 
                this.LastSpotRate = val;
            }
            
            public QuickFix.Fields.LastSpotRate Get(QuickFix.Fields.LastSpotRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastSpotRate val) 
            { 
                return IsSetLastSpotRate();
            }
            
            public bool IsSetLastSpotRate() 
            { 
                return IsSetField(Tags.LastSpotRate);
            }
            public QuickFix.Fields.LastForwardPoints LastForwardPoints
            { 
                get 
                {
                    QuickFix.Fields.LastForwardPoints val = new QuickFix.Fields.LastForwardPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastForwardPoints val) 
            { 
                this.LastForwardPoints = val;
            }
            
            public QuickFix.Fields.LastForwardPoints Get(QuickFix.Fields.LastForwardPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastForwardPoints val) 
            { 
                return IsSetLastForwardPoints();
            }
            
            public bool IsSetLastForwardPoints() 
            { 
                return IsSetField(Tags.LastForwardPoints);
            }
            public QuickFix.Fields.LastMkt LastMkt
            { 
                get 
                {
                    QuickFix.Fields.LastMkt val = new QuickFix.Fields.LastMkt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastMkt val) 
            { 
                this.LastMkt = val;
            }
            
            public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastMkt val) 
            { 
                return IsSetLastMkt();
            }
            
            public bool IsSetLastMkt() 
            { 
                return IsSetField(Tags.LastMkt);
            }
            public QuickFix.Fields.TradingSessionID TradingSessionID
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
                this.TradingSessionID = val;
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
            public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
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
                this.TradingSessionSubID = val;
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
            public QuickFix.Fields.TimeBracket TimeBracket
            { 
                get 
                {
                    QuickFix.Fields.TimeBracket val = new QuickFix.Fields.TimeBracket();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeBracket val) 
            { 
                this.TimeBracket = val;
            }
            
            public QuickFix.Fields.TimeBracket Get(QuickFix.Fields.TimeBracket val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeBracket val) 
            { 
                return IsSetTimeBracket();
            }
            
            public bool IsSetTimeBracket() 
            { 
                return IsSetField(Tags.TimeBracket);
            }
            public QuickFix.Fields.LastCapacity LastCapacity
            { 
                get 
                {
                    QuickFix.Fields.LastCapacity val = new QuickFix.Fields.LastCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastCapacity val) 
            { 
                this.LastCapacity = val;
            }
            
            public QuickFix.Fields.LastCapacity Get(QuickFix.Fields.LastCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastCapacity val) 
            { 
                return IsSetLastCapacity();
            }
            
            public bool IsSetLastCapacity() 
            { 
                return IsSetField(Tags.LastCapacity);
            }
            public QuickFix.Fields.LeavesQty LeavesQty
            { 
                get 
                {
                    QuickFix.Fields.LeavesQty val = new QuickFix.Fields.LeavesQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LeavesQty val) 
            { 
                this.LeavesQty = val;
            }
            
            public QuickFix.Fields.LeavesQty Get(QuickFix.Fields.LeavesQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LeavesQty val) 
            { 
                return IsSetLeavesQty();
            }
            
            public bool IsSetLeavesQty() 
            { 
                return IsSetField(Tags.LeavesQty);
            }
            public QuickFix.Fields.CumQty CumQty
            { 
                get 
                {
                    QuickFix.Fields.CumQty val = new QuickFix.Fields.CumQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CumQty val) 
            { 
                this.CumQty = val;
            }
            
            public QuickFix.Fields.CumQty Get(QuickFix.Fields.CumQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CumQty val) 
            { 
                return IsSetCumQty();
            }
            
            public bool IsSetCumQty() 
            { 
                return IsSetField(Tags.CumQty);
            }
            public QuickFix.Fields.AvgPx AvgPx
            { 
                get 
                {
                    QuickFix.Fields.AvgPx val = new QuickFix.Fields.AvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AvgPx val) 
            { 
                this.AvgPx = val;
            }
            
            public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AvgPx val) 
            { 
                return IsSetAvgPx();
            }
            
            public bool IsSetAvgPx() 
            { 
                return IsSetField(Tags.AvgPx);
            }
            public QuickFix.Fields.DayOrderQty DayOrderQty
            { 
                get 
                {
                    QuickFix.Fields.DayOrderQty val = new QuickFix.Fields.DayOrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DayOrderQty val) 
            { 
                this.DayOrderQty = val;
            }
            
            public QuickFix.Fields.DayOrderQty Get(QuickFix.Fields.DayOrderQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DayOrderQty val) 
            { 
                return IsSetDayOrderQty();
            }
            
            public bool IsSetDayOrderQty() 
            { 
                return IsSetField(Tags.DayOrderQty);
            }
            public QuickFix.Fields.DayCumQty DayCumQty
            { 
                get 
                {
                    QuickFix.Fields.DayCumQty val = new QuickFix.Fields.DayCumQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DayCumQty val) 
            { 
                this.DayCumQty = val;
            }
            
            public QuickFix.Fields.DayCumQty Get(QuickFix.Fields.DayCumQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DayCumQty val) 
            { 
                return IsSetDayCumQty();
            }
            
            public bool IsSetDayCumQty() 
            { 
                return IsSetField(Tags.DayCumQty);
            }
            public QuickFix.Fields.DayAvgPx DayAvgPx
            { 
                get 
                {
                    QuickFix.Fields.DayAvgPx val = new QuickFix.Fields.DayAvgPx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DayAvgPx val) 
            { 
                this.DayAvgPx = val;
            }
            
            public QuickFix.Fields.DayAvgPx Get(QuickFix.Fields.DayAvgPx val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DayAvgPx val) 
            { 
                return IsSetDayAvgPx();
            }
            
            public bool IsSetDayAvgPx() 
            { 
                return IsSetField(Tags.DayAvgPx);
            }
            public QuickFix.Fields.GTBookingInst GTBookingInst
            { 
                get 
                {
                    QuickFix.Fields.GTBookingInst val = new QuickFix.Fields.GTBookingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GTBookingInst val) 
            { 
                this.GTBookingInst = val;
            }
            
            public QuickFix.Fields.GTBookingInst Get(QuickFix.Fields.GTBookingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GTBookingInst val) 
            { 
                return IsSetGTBookingInst();
            }
            
            public bool IsSetGTBookingInst() 
            { 
                return IsSetField(Tags.GTBookingInst);
            }
            public QuickFix.Fields.TradeDate TradeDate
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
                this.TradeDate = val;
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
            public QuickFix.Fields.ReportToExch ReportToExch
            { 
                get 
                {
                    QuickFix.Fields.ReportToExch val = new QuickFix.Fields.ReportToExch();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ReportToExch val) 
            { 
                this.ReportToExch = val;
            }
            
            public QuickFix.Fields.ReportToExch Get(QuickFix.Fields.ReportToExch val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ReportToExch val) 
            { 
                return IsSetReportToExch();
            }
            
            public bool IsSetReportToExch() 
            { 
                return IsSetField(Tags.ReportToExch);
            }
            public QuickFix.Fields.Commission Commission
            { 
                get 
                {
                    QuickFix.Fields.Commission val = new QuickFix.Fields.Commission();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Commission val) 
            { 
                this.Commission = val;
            }
            
            public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Commission val) 
            { 
                return IsSetCommission();
            }
            
            public bool IsSetCommission() 
            { 
                return IsSetField(Tags.Commission);
            }
            public QuickFix.Fields.CommType CommType
            { 
                get 
                {
                    QuickFix.Fields.CommType val = new QuickFix.Fields.CommType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CommType val) 
            { 
                this.CommType = val;
            }
            
            public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CommType val) 
            { 
                return IsSetCommType();
            }
            
            public bool IsSetCommType() 
            { 
                return IsSetField(Tags.CommType);
            }
            public QuickFix.Fields.CommCurrency CommCurrency
            { 
                get 
                {
                    QuickFix.Fields.CommCurrency val = new QuickFix.Fields.CommCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CommCurrency val) 
            { 
                this.CommCurrency = val;
            }
            
            public QuickFix.Fields.CommCurrency Get(QuickFix.Fields.CommCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CommCurrency val) 
            { 
                return IsSetCommCurrency();
            }
            
            public bool IsSetCommCurrency() 
            { 
                return IsSetField(Tags.CommCurrency);
            }
            public QuickFix.Fields.FundRenewWaiv FundRenewWaiv
            { 
                get 
                {
                    QuickFix.Fields.FundRenewWaiv val = new QuickFix.Fields.FundRenewWaiv();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.FundRenewWaiv val) 
            { 
                this.FundRenewWaiv = val;
            }
            
            public QuickFix.Fields.FundRenewWaiv Get(QuickFix.Fields.FundRenewWaiv val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.FundRenewWaiv val) 
            { 
                return IsSetFundRenewWaiv();
            }
            
            public bool IsSetFundRenewWaiv() 
            { 
                return IsSetField(Tags.FundRenewWaiv);
            }
            public QuickFix.Fields.Spread Spread
            { 
                get 
                {
                    QuickFix.Fields.Spread val = new QuickFix.Fields.Spread();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Spread val) 
            { 
                this.Spread = val;
            }
            
            public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Spread val) 
            { 
                return IsSetSpread();
            }
            
            public bool IsSetSpread() 
            { 
                return IsSetField(Tags.Spread);
            }
            public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkCurveCurrency val = new QuickFix.Fields.BenchmarkCurveCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                this.BenchmarkCurveCurrency = val;
            }
            
            public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
            { 
                return IsSetBenchmarkCurveCurrency();
            }
            
            public bool IsSetBenchmarkCurveCurrency() 
            { 
                return IsSetField(Tags.BenchmarkCurveCurrency);
            }
            public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkCurveName val = new QuickFix.Fields.BenchmarkCurveName();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                this.BenchmarkCurveName = val;
            }
            
            public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) 
            { 
                return IsSetBenchmarkCurveName();
            }
            
            public bool IsSetBenchmarkCurveName() 
            { 
                return IsSetField(Tags.BenchmarkCurveName);
            }
            public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkCurvePoint val = new QuickFix.Fields.BenchmarkCurvePoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                this.BenchmarkCurvePoint = val;
            }
            
            public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) 
            { 
                return IsSetBenchmarkCurvePoint();
            }
            
            public bool IsSetBenchmarkCurvePoint() 
            { 
                return IsSetField(Tags.BenchmarkCurvePoint);
            }
            public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkPrice val) 
            { 
                this.BenchmarkPrice = val;
            }
            
            public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkPrice val) 
            { 
                return IsSetBenchmarkPrice();
            }
            
            public bool IsSetBenchmarkPrice() 
            { 
                return IsSetField(Tags.BenchmarkPrice);
            }
            public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                this.BenchmarkPriceType = val;
            }
            
            public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) 
            { 
                return IsSetBenchmarkPriceType();
            }
            
            public bool IsSetBenchmarkPriceType() 
            { 
                return IsSetField(Tags.BenchmarkPriceType);
            }
            public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkSecurityID val = new QuickFix.Fields.BenchmarkSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                this.BenchmarkSecurityID = val;
            }
            
            public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) 
            { 
                return IsSetBenchmarkSecurityID();
            }
            
            public bool IsSetBenchmarkSecurityID() 
            { 
                return IsSetField(Tags.BenchmarkSecurityID);
            }
            public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.BenchmarkSecurityIDSource val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                this.BenchmarkSecurityIDSource = val;
            }
            
            public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
            { 
                return IsSetBenchmarkSecurityIDSource();
            }
            
            public bool IsSetBenchmarkSecurityIDSource() 
            { 
                return IsSetField(Tags.BenchmarkSecurityIDSource);
            }
            public QuickFix.Fields.YieldType YieldType
            { 
                get 
                {
                    QuickFix.Fields.YieldType val = new QuickFix.Fields.YieldType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldType val) 
            { 
                this.YieldType = val;
            }
            
            public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldType val) 
            { 
                return IsSetYieldType();
            }
            
            public bool IsSetYieldType() 
            { 
                return IsSetField(Tags.YieldType);
            }
            public QuickFix.Fields.Yield Yield
            { 
                get 
                {
                    QuickFix.Fields.Yield val = new QuickFix.Fields.Yield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Yield val) 
            { 
                this.Yield = val;
            }
            
            public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Yield val) 
            { 
                return IsSetYield();
            }
            
            public bool IsSetYield() 
            { 
                return IsSetField(Tags.Yield);
            }
            public QuickFix.Fields.YieldCalcDate YieldCalcDate
            { 
                get 
                {
                    QuickFix.Fields.YieldCalcDate val = new QuickFix.Fields.YieldCalcDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldCalcDate val) 
            { 
                this.YieldCalcDate = val;
            }
            
            public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldCalcDate val) 
            { 
                return IsSetYieldCalcDate();
            }
            
            public bool IsSetYieldCalcDate() 
            { 
                return IsSetField(Tags.YieldCalcDate);
            }
            public QuickFix.Fields.YieldRedemptionDate YieldRedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.YieldRedemptionDate val = new QuickFix.Fields.YieldRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                this.YieldRedemptionDate = val;
            }
            
            public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) 
            { 
                return IsSetYieldRedemptionDate();
            }
            
            public bool IsSetYieldRedemptionDate() 
            { 
                return IsSetField(Tags.YieldRedemptionDate);
            }
            public QuickFix.Fields.YieldRedemptionPrice YieldRedemptionPrice
            { 
                get 
                {
                    QuickFix.Fields.YieldRedemptionPrice val = new QuickFix.Fields.YieldRedemptionPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                this.YieldRedemptionPrice = val;
            }
            
            public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) 
            { 
                return IsSetYieldRedemptionPrice();
            }
            
            public bool IsSetYieldRedemptionPrice() 
            { 
                return IsSetField(Tags.YieldRedemptionPrice);
            }
            public QuickFix.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
            { 
                get 
                {
                    QuickFix.Fields.YieldRedemptionPriceType val = new QuickFix.Fields.YieldRedemptionPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                this.YieldRedemptionPriceType = val;
            }
            
            public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) 
            { 
                return IsSetYieldRedemptionPriceType();
            }
            
            public bool IsSetYieldRedemptionPriceType() 
            { 
                return IsSetField(Tags.YieldRedemptionPriceType);
            }
            public QuickFix.Fields.GrossTradeAmt GrossTradeAmt
            { 
                get 
                {
                    QuickFix.Fields.GrossTradeAmt val = new QuickFix.Fields.GrossTradeAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GrossTradeAmt val) 
            { 
                this.GrossTradeAmt = val;
            }
            
            public QuickFix.Fields.GrossTradeAmt Get(QuickFix.Fields.GrossTradeAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GrossTradeAmt val) 
            { 
                return IsSetGrossTradeAmt();
            }
            
            public bool IsSetGrossTradeAmt() 
            { 
                return IsSetField(Tags.GrossTradeAmt);
            }
            public QuickFix.Fields.NumDaysInterest NumDaysInterest
            { 
                get 
                {
                    QuickFix.Fields.NumDaysInterest val = new QuickFix.Fields.NumDaysInterest();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NumDaysInterest val) 
            { 
                this.NumDaysInterest = val;
            }
            
            public QuickFix.Fields.NumDaysInterest Get(QuickFix.Fields.NumDaysInterest val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NumDaysInterest val) 
            { 
                return IsSetNumDaysInterest();
            }
            
            public bool IsSetNumDaysInterest() 
            { 
                return IsSetField(Tags.NumDaysInterest);
            }
            public QuickFix.Fields.ExDate ExDate
            { 
                get 
                {
                    QuickFix.Fields.ExDate val = new QuickFix.Fields.ExDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExDate val) 
            { 
                this.ExDate = val;
            }
            
            public QuickFix.Fields.ExDate Get(QuickFix.Fields.ExDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExDate val) 
            { 
                return IsSetExDate();
            }
            
            public bool IsSetExDate() 
            { 
                return IsSetField(Tags.ExDate);
            }
            public QuickFix.Fields.AccruedInterestRate AccruedInterestRate
            { 
                get 
                {
                    QuickFix.Fields.AccruedInterestRate val = new QuickFix.Fields.AccruedInterestRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccruedInterestRate val) 
            { 
                this.AccruedInterestRate = val;
            }
            
            public QuickFix.Fields.AccruedInterestRate Get(QuickFix.Fields.AccruedInterestRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccruedInterestRate val) 
            { 
                return IsSetAccruedInterestRate();
            }
            
            public bool IsSetAccruedInterestRate() 
            { 
                return IsSetField(Tags.AccruedInterestRate);
            }
            public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
            { 
                get 
                {
                    QuickFix.Fields.AccruedInterestAmt val = new QuickFix.Fields.AccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                this.AccruedInterestAmt = val;
            }
            
            public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AccruedInterestAmt val) 
            { 
                return IsSetAccruedInterestAmt();
            }
            
            public bool IsSetAccruedInterestAmt() 
            { 
                return IsSetField(Tags.AccruedInterestAmt);
            }
            public QuickFix.Fields.InterestAtMaturity InterestAtMaturity
            { 
                get 
                {
                    QuickFix.Fields.InterestAtMaturity val = new QuickFix.Fields.InterestAtMaturity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.InterestAtMaturity val) 
            { 
                this.InterestAtMaturity = val;
            }
            
            public QuickFix.Fields.InterestAtMaturity Get(QuickFix.Fields.InterestAtMaturity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.InterestAtMaturity val) 
            { 
                return IsSetInterestAtMaturity();
            }
            
            public bool IsSetInterestAtMaturity() 
            { 
                return IsSetField(Tags.InterestAtMaturity);
            }
            public QuickFix.Fields.EndAccruedInterestAmt EndAccruedInterestAmt
            { 
                get 
                {
                    QuickFix.Fields.EndAccruedInterestAmt val = new QuickFix.Fields.EndAccruedInterestAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EndAccruedInterestAmt val) 
            { 
                this.EndAccruedInterestAmt = val;
            }
            
            public QuickFix.Fields.EndAccruedInterestAmt Get(QuickFix.Fields.EndAccruedInterestAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EndAccruedInterestAmt val) 
            { 
                return IsSetEndAccruedInterestAmt();
            }
            
            public bool IsSetEndAccruedInterestAmt() 
            { 
                return IsSetField(Tags.EndAccruedInterestAmt);
            }
            public QuickFix.Fields.StartCash StartCash
            { 
                get 
                {
                    QuickFix.Fields.StartCash val = new QuickFix.Fields.StartCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StartCash val) 
            { 
                this.StartCash = val;
            }
            
            public QuickFix.Fields.StartCash Get(QuickFix.Fields.StartCash val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StartCash val) 
            { 
                return IsSetStartCash();
            }
            
            public bool IsSetStartCash() 
            { 
                return IsSetField(Tags.StartCash);
            }
            public QuickFix.Fields.EndCash EndCash
            { 
                get 
                {
                    QuickFix.Fields.EndCash val = new QuickFix.Fields.EndCash();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EndCash val) 
            { 
                this.EndCash = val;
            }
            
            public QuickFix.Fields.EndCash Get(QuickFix.Fields.EndCash val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EndCash val) 
            { 
                return IsSetEndCash();
            }
            
            public bool IsSetEndCash() 
            { 
                return IsSetField(Tags.EndCash);
            }
            public QuickFix.Fields.TradedFlatSwitch TradedFlatSwitch
            { 
                get 
                {
                    QuickFix.Fields.TradedFlatSwitch val = new QuickFix.Fields.TradedFlatSwitch();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradedFlatSwitch val) 
            { 
                this.TradedFlatSwitch = val;
            }
            
            public QuickFix.Fields.TradedFlatSwitch Get(QuickFix.Fields.TradedFlatSwitch val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradedFlatSwitch val) 
            { 
                return IsSetTradedFlatSwitch();
            }
            
            public bool IsSetTradedFlatSwitch() 
            { 
                return IsSetField(Tags.TradedFlatSwitch);
            }
            public QuickFix.Fields.BasisFeatureDate BasisFeatureDate
            { 
                get 
                {
                    QuickFix.Fields.BasisFeatureDate val = new QuickFix.Fields.BasisFeatureDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BasisFeatureDate val) 
            { 
                this.BasisFeatureDate = val;
            }
            
            public QuickFix.Fields.BasisFeatureDate Get(QuickFix.Fields.BasisFeatureDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BasisFeatureDate val) 
            { 
                return IsSetBasisFeatureDate();
            }
            
            public bool IsSetBasisFeatureDate() 
            { 
                return IsSetField(Tags.BasisFeatureDate);
            }
            public QuickFix.Fields.BasisFeaturePrice BasisFeaturePrice
            { 
                get 
                {
                    QuickFix.Fields.BasisFeaturePrice val = new QuickFix.Fields.BasisFeaturePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BasisFeaturePrice val) 
            { 
                this.BasisFeaturePrice = val;
            }
            
            public QuickFix.Fields.BasisFeaturePrice Get(QuickFix.Fields.BasisFeaturePrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BasisFeaturePrice val) 
            { 
                return IsSetBasisFeaturePrice();
            }
            
            public bool IsSetBasisFeaturePrice() 
            { 
                return IsSetField(Tags.BasisFeaturePrice);
            }
            public QuickFix.Fields.Concession Concession
            { 
                get 
                {
                    QuickFix.Fields.Concession val = new QuickFix.Fields.Concession();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Concession val) 
            { 
                this.Concession = val;
            }
            
            public QuickFix.Fields.Concession Get(QuickFix.Fields.Concession val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Concession val) 
            { 
                return IsSetConcession();
            }
            
            public bool IsSetConcession() 
            { 
                return IsSetField(Tags.Concession);
            }
            public QuickFix.Fields.TotalTakedown TotalTakedown
            { 
                get 
                {
                    QuickFix.Fields.TotalTakedown val = new QuickFix.Fields.TotalTakedown();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotalTakedown val) 
            { 
                this.TotalTakedown = val;
            }
            
            public QuickFix.Fields.TotalTakedown Get(QuickFix.Fields.TotalTakedown val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotalTakedown val) 
            { 
                return IsSetTotalTakedown();
            }
            
            public bool IsSetTotalTakedown() 
            { 
                return IsSetField(Tags.TotalTakedown);
            }
            public QuickFix.Fields.NetMoney NetMoney
            { 
                get 
                {
                    QuickFix.Fields.NetMoney val = new QuickFix.Fields.NetMoney();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetMoney val) 
            { 
                this.NetMoney = val;
            }
            
            public QuickFix.Fields.NetMoney Get(QuickFix.Fields.NetMoney val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetMoney val) 
            { 
                return IsSetNetMoney();
            }
            
            public bool IsSetNetMoney() 
            { 
                return IsSetField(Tags.NetMoney);
            }
            public QuickFix.Fields.SettlCurrAmt SettlCurrAmt
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrAmt val = new QuickFix.Fields.SettlCurrAmt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlCurrAmt val) 
            { 
                this.SettlCurrAmt = val;
            }
            
            public QuickFix.Fields.SettlCurrAmt Get(QuickFix.Fields.SettlCurrAmt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlCurrAmt val) 
            { 
                return IsSetSettlCurrAmt();
            }
            
            public bool IsSetSettlCurrAmt() 
            { 
                return IsSetField(Tags.SettlCurrAmt);
            }
            public QuickFix.Fields.SettlCurrency SettlCurrency
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrency val = new QuickFix.Fields.SettlCurrency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlCurrency val) 
            { 
                this.SettlCurrency = val;
            }
            
            public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlCurrency val) 
            { 
                return IsSetSettlCurrency();
            }
            
            public bool IsSetSettlCurrency() 
            { 
                return IsSetField(Tags.SettlCurrency);
            }
            public QuickFix.Fields.SettlCurrFxRate SettlCurrFxRate
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrFxRate val = new QuickFix.Fields.SettlCurrFxRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlCurrFxRate val) 
            { 
                this.SettlCurrFxRate = val;
            }
            
            public QuickFix.Fields.SettlCurrFxRate Get(QuickFix.Fields.SettlCurrFxRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlCurrFxRate val) 
            { 
                return IsSetSettlCurrFxRate();
            }
            
            public bool IsSetSettlCurrFxRate() 
            { 
                return IsSetField(Tags.SettlCurrFxRate);
            }
            public QuickFix.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
            { 
                get 
                {
                    QuickFix.Fields.SettlCurrFxRateCalc val = new QuickFix.Fields.SettlCurrFxRateCalc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlCurrFxRateCalc val) 
            { 
                this.SettlCurrFxRateCalc = val;
            }
            
            public QuickFix.Fields.SettlCurrFxRateCalc Get(QuickFix.Fields.SettlCurrFxRateCalc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlCurrFxRateCalc val) 
            { 
                return IsSetSettlCurrFxRateCalc();
            }
            
            public bool IsSetSettlCurrFxRateCalc() 
            { 
                return IsSetField(Tags.SettlCurrFxRateCalc);
            }
            public QuickFix.Fields.HandlInst HandlInst
            { 
                get 
                {
                    QuickFix.Fields.HandlInst val = new QuickFix.Fields.HandlInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HandlInst val) 
            { 
                this.HandlInst = val;
            }
            
            public QuickFix.Fields.HandlInst Get(QuickFix.Fields.HandlInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HandlInst val) 
            { 
                return IsSetHandlInst();
            }
            
            public bool IsSetHandlInst() 
            { 
                return IsSetField(Tags.HandlInst);
            }
            public QuickFix.Fields.MinQty MinQty
            { 
                get 
                {
                    QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MinQty val) 
            { 
                this.MinQty = val;
            }
            
            public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MinQty val) 
            { 
                return IsSetMinQty();
            }
            
            public bool IsSetMinQty() 
            { 
                return IsSetField(Tags.MinQty);
            }
            public QuickFix.Fields.MaxFloor MaxFloor
            { 
                get 
                {
                    QuickFix.Fields.MaxFloor val = new QuickFix.Fields.MaxFloor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxFloor val) 
            { 
                this.MaxFloor = val;
            }
            
            public QuickFix.Fields.MaxFloor Get(QuickFix.Fields.MaxFloor val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxFloor val) 
            { 
                return IsSetMaxFloor();
            }
            
            public bool IsSetMaxFloor() 
            { 
                return IsSetField(Tags.MaxFloor);
            }
            public QuickFix.Fields.PositionEffect PositionEffect
            { 
                get 
                {
                    QuickFix.Fields.PositionEffect val = new QuickFix.Fields.PositionEffect();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PositionEffect val) 
            { 
                this.PositionEffect = val;
            }
            
            public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PositionEffect val) 
            { 
                return IsSetPositionEffect();
            }
            
            public bool IsSetPositionEffect() 
            { 
                return IsSetField(Tags.PositionEffect);
            }
            public QuickFix.Fields.MaxShow MaxShow
            { 
                get 
                {
                    QuickFix.Fields.MaxShow val = new QuickFix.Fields.MaxShow();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxShow val) 
            { 
                this.MaxShow = val;
            }
            
            public QuickFix.Fields.MaxShow Get(QuickFix.Fields.MaxShow val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxShow val) 
            { 
                return IsSetMaxShow();
            }
            
            public bool IsSetMaxShow() 
            { 
                return IsSetField(Tags.MaxShow);
            }
            public QuickFix.Fields.BookingType BookingType
            { 
                get 
                {
                    QuickFix.Fields.BookingType val = new QuickFix.Fields.BookingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BookingType val) 
            { 
                this.BookingType = val;
            }
            
            public QuickFix.Fields.BookingType Get(QuickFix.Fields.BookingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BookingType val) 
            { 
                return IsSetBookingType();
            }
            
            public bool IsSetBookingType() 
            { 
                return IsSetField(Tags.BookingType);
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
            public QuickFix.Fields.SettlDate2 SettlDate2
            { 
                get 
                {
                    QuickFix.Fields.SettlDate2 val = new QuickFix.Fields.SettlDate2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlDate2 val) 
            { 
                this.SettlDate2 = val;
            }
            
            public QuickFix.Fields.SettlDate2 Get(QuickFix.Fields.SettlDate2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlDate2 val) 
            { 
                return IsSetSettlDate2();
            }
            
            public bool IsSetSettlDate2() 
            { 
                return IsSetField(Tags.SettlDate2);
            }
            public QuickFix.Fields.OrderQty2 OrderQty2
            { 
                get 
                {
                    QuickFix.Fields.OrderQty2 val = new QuickFix.Fields.OrderQty2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderQty2 val) 
            { 
                this.OrderQty2 = val;
            }
            
            public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderQty2 val) 
            { 
                return IsSetOrderQty2();
            }
            
            public bool IsSetOrderQty2() 
            { 
                return IsSetField(Tags.OrderQty2);
            }
            public QuickFix.Fields.LastForwardPoints2 LastForwardPoints2
            { 
                get 
                {
                    QuickFix.Fields.LastForwardPoints2 val = new QuickFix.Fields.LastForwardPoints2();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastForwardPoints2 val) 
            { 
                this.LastForwardPoints2 = val;
            }
            
            public QuickFix.Fields.LastForwardPoints2 Get(QuickFix.Fields.LastForwardPoints2 val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastForwardPoints2 val) 
            { 
                return IsSetLastForwardPoints2();
            }
            
            public bool IsSetLastForwardPoints2() 
            { 
                return IsSetField(Tags.LastForwardPoints2);
            }
            public QuickFix.Fields.MultiLegReportingType MultiLegReportingType
            { 
                get 
                {
                    QuickFix.Fields.MultiLegReportingType val = new QuickFix.Fields.MultiLegReportingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MultiLegReportingType val) 
            { 
                this.MultiLegReportingType = val;
            }
            
            public QuickFix.Fields.MultiLegReportingType Get(QuickFix.Fields.MultiLegReportingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MultiLegReportingType val) 
            { 
                return IsSetMultiLegReportingType();
            }
            
            public bool IsSetMultiLegReportingType() 
            { 
                return IsSetField(Tags.MultiLegReportingType);
            }
            public QuickFix.Fields.CancellationRights CancellationRights
            { 
                get 
                {
                    QuickFix.Fields.CancellationRights val = new QuickFix.Fields.CancellationRights();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CancellationRights val) 
            { 
                this.CancellationRights = val;
            }
            
            public QuickFix.Fields.CancellationRights Get(QuickFix.Fields.CancellationRights val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CancellationRights val) 
            { 
                return IsSetCancellationRights();
            }
            
            public bool IsSetCancellationRights() 
            { 
                return IsSetField(Tags.CancellationRights);
            }
            public QuickFix.Fields.MoneyLaunderingStatus MoneyLaunderingStatus
            { 
                get 
                {
                    QuickFix.Fields.MoneyLaunderingStatus val = new QuickFix.Fields.MoneyLaunderingStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                this.MoneyLaunderingStatus = val;
            }
            
            public QuickFix.Fields.MoneyLaunderingStatus Get(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MoneyLaunderingStatus val) 
            { 
                return IsSetMoneyLaunderingStatus();
            }
            
            public bool IsSetMoneyLaunderingStatus() 
            { 
                return IsSetField(Tags.MoneyLaunderingStatus);
            }
            public QuickFix.Fields.RegistID RegistID
            { 
                get 
                {
                    QuickFix.Fields.RegistID val = new QuickFix.Fields.RegistID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RegistID val) 
            { 
                this.RegistID = val;
            }
            
            public QuickFix.Fields.RegistID Get(QuickFix.Fields.RegistID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RegistID val) 
            { 
                return IsSetRegistID();
            }
            
            public bool IsSetRegistID() 
            { 
                return IsSetField(Tags.RegistID);
            }
            public QuickFix.Fields.Designation Designation
            { 
                get 
                {
                    QuickFix.Fields.Designation val = new QuickFix.Fields.Designation();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Designation val) 
            { 
                this.Designation = val;
            }
            
            public QuickFix.Fields.Designation Get(QuickFix.Fields.Designation val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Designation val) 
            { 
                return IsSetDesignation();
            }
            
            public bool IsSetDesignation() 
            { 
                return IsSetField(Tags.Designation);
            }
            public QuickFix.Fields.TransBkdTime TransBkdTime
            { 
                get 
                {
                    QuickFix.Fields.TransBkdTime val = new QuickFix.Fields.TransBkdTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransBkdTime val) 
            { 
                this.TransBkdTime = val;
            }
            
            public QuickFix.Fields.TransBkdTime Get(QuickFix.Fields.TransBkdTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransBkdTime val) 
            { 
                return IsSetTransBkdTime();
            }
            
            public bool IsSetTransBkdTime() 
            { 
                return IsSetField(Tags.TransBkdTime);
            }
            public QuickFix.Fields.ExecValuationPoint ExecValuationPoint
            { 
                get 
                {
                    QuickFix.Fields.ExecValuationPoint val = new QuickFix.Fields.ExecValuationPoint();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecValuationPoint val) 
            { 
                this.ExecValuationPoint = val;
            }
            
            public QuickFix.Fields.ExecValuationPoint Get(QuickFix.Fields.ExecValuationPoint val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecValuationPoint val) 
            { 
                return IsSetExecValuationPoint();
            }
            
            public bool IsSetExecValuationPoint() 
            { 
                return IsSetField(Tags.ExecValuationPoint);
            }
            public QuickFix.Fields.ExecPriceType ExecPriceType
            { 
                get 
                {
                    QuickFix.Fields.ExecPriceType val = new QuickFix.Fields.ExecPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecPriceType val) 
            { 
                this.ExecPriceType = val;
            }
            
            public QuickFix.Fields.ExecPriceType Get(QuickFix.Fields.ExecPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecPriceType val) 
            { 
                return IsSetExecPriceType();
            }
            
            public bool IsSetExecPriceType() 
            { 
                return IsSetField(Tags.ExecPriceType);
            }
            public QuickFix.Fields.ExecPriceAdjustment ExecPriceAdjustment
            { 
                get 
                {
                    QuickFix.Fields.ExecPriceAdjustment val = new QuickFix.Fields.ExecPriceAdjustment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ExecPriceAdjustment val) 
            { 
                this.ExecPriceAdjustment = val;
            }
            
            public QuickFix.Fields.ExecPriceAdjustment Get(QuickFix.Fields.ExecPriceAdjustment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ExecPriceAdjustment val) 
            { 
                return IsSetExecPriceAdjustment();
            }
            
            public bool IsSetExecPriceAdjustment() 
            { 
                return IsSetField(Tags.ExecPriceAdjustment);
            }
            public QuickFix.Fields.PriorityIndicator PriorityIndicator
            { 
                get 
                {
                    QuickFix.Fields.PriorityIndicator val = new QuickFix.Fields.PriorityIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriorityIndicator val) 
            { 
                this.PriorityIndicator = val;
            }
            
            public QuickFix.Fields.PriorityIndicator Get(QuickFix.Fields.PriorityIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriorityIndicator val) 
            { 
                return IsSetPriorityIndicator();
            }
            
            public bool IsSetPriorityIndicator() 
            { 
                return IsSetField(Tags.PriorityIndicator);
            }
            public QuickFix.Fields.PriceImprovement PriceImprovement
            { 
                get 
                {
                    QuickFix.Fields.PriceImprovement val = new QuickFix.Fields.PriceImprovement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceImprovement val) 
            { 
                this.PriceImprovement = val;
            }
            
            public QuickFix.Fields.PriceImprovement Get(QuickFix.Fields.PriceImprovement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceImprovement val) 
            { 
                return IsSetPriceImprovement();
            }
            
            public bool IsSetPriceImprovement() 
            { 
                return IsSetField(Tags.PriceImprovement);
            }
            public QuickFix.Fields.LastLiquidityInd LastLiquidityInd
            { 
                get 
                {
                    QuickFix.Fields.LastLiquidityInd val = new QuickFix.Fields.LastLiquidityInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastLiquidityInd val) 
            { 
                this.LastLiquidityInd = val;
            }
            
            public QuickFix.Fields.LastLiquidityInd Get(QuickFix.Fields.LastLiquidityInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastLiquidityInd val) 
            { 
                return IsSetLastLiquidityInd();
            }
            
            public bool IsSetLastLiquidityInd() 
            { 
                return IsSetField(Tags.LastLiquidityInd);
            }
            public QuickFix.Fields.NoContAmts NoContAmts
            { 
                get 
                {
                    QuickFix.Fields.NoContAmts val = new QuickFix.Fields.NoContAmts();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoContAmts val) 
            { 
                this.NoContAmts = val;
            }
            
            public QuickFix.Fields.NoContAmts Get(QuickFix.Fields.NoContAmts val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoContAmts val) 
            { 
                return IsSetNoContAmts();
            }
            
            public bool IsSetNoContAmts() 
            { 
                return IsSetField(Tags.NoContAmts);
            }
            public QuickFix.Fields.NoLegs NoLegs
            { 
                get 
                {
                    QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoLegs val) 
            { 
                this.NoLegs = val;
            }
            
            public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoLegs val) 
            { 
                return IsSetNoLegs();
            }
            
            public bool IsSetNoLegs() 
            { 
                return IsSetField(Tags.NoLegs);
            }
            public QuickFix.Fields.CopyMsgIndicator CopyMsgIndicator
            { 
                get 
                {
                    QuickFix.Fields.CopyMsgIndicator val = new QuickFix.Fields.CopyMsgIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CopyMsgIndicator val) 
            { 
                this.CopyMsgIndicator = val;
            }
            
            public QuickFix.Fields.CopyMsgIndicator Get(QuickFix.Fields.CopyMsgIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CopyMsgIndicator val) 
            { 
                return IsSetCopyMsgIndicator();
            }
            
            public bool IsSetCopyMsgIndicator() 
            { 
                return IsSetField(Tags.CopyMsgIndicator);
            }
            public QuickFix.Fields.NoMiscFees NoMiscFees
            { 
                get 
                {
                    QuickFix.Fields.NoMiscFees val = new QuickFix.Fields.NoMiscFees();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMiscFees val) 
            { 
                this.NoMiscFees = val;
            }
            
            public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMiscFees val) 
            { 
                return IsSetNoMiscFees();
            }
            
            public bool IsSetNoMiscFees() 
            { 
                return IsSetField(Tags.NoMiscFees);
            }
            public QuickFix.Fields.NoStrategyParameters NoStrategyParameters
            { 
                get 
                {
                    QuickFix.Fields.NoStrategyParameters val = new QuickFix.Fields.NoStrategyParameters();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoStrategyParameters val) 
            { 
                this.NoStrategyParameters = val;
            }
            
            public QuickFix.Fields.NoStrategyParameters Get(QuickFix.Fields.NoStrategyParameters val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoStrategyParameters val) 
            { 
                return IsSetNoStrategyParameters();
            }
            
            public bool IsSetNoStrategyParameters() 
            { 
                return IsSetField(Tags.NoStrategyParameters);
            }
            public QuickFix.Fields.HostCrossID HostCrossID
            { 
                get 
                {
                    QuickFix.Fields.HostCrossID val = new QuickFix.Fields.HostCrossID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HostCrossID val) 
            { 
                this.HostCrossID = val;
            }
            
            public QuickFix.Fields.HostCrossID Get(QuickFix.Fields.HostCrossID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HostCrossID val) 
            { 
                return IsSetHostCrossID();
            }
            
            public bool IsSetHostCrossID() 
            { 
                return IsSetField(Tags.HostCrossID);
            }
            public QuickFix.Fields.ManualOrderIndicator ManualOrderIndicator
            { 
                get 
                {
                    QuickFix.Fields.ManualOrderIndicator val = new QuickFix.Fields.ManualOrderIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ManualOrderIndicator val) 
            { 
                this.ManualOrderIndicator = val;
            }
            
            public QuickFix.Fields.ManualOrderIndicator Get(QuickFix.Fields.ManualOrderIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ManualOrderIndicator val) 
            { 
                return IsSetManualOrderIndicator();
            }
            
            public bool IsSetManualOrderIndicator() 
            { 
                return IsSetField(Tags.ManualOrderIndicator);
            }
            public QuickFix.Fields.CustDirectedOrder CustDirectedOrder
            { 
                get 
                {
                    QuickFix.Fields.CustDirectedOrder val = new QuickFix.Fields.CustDirectedOrder();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CustDirectedOrder val) 
            { 
                this.CustDirectedOrder = val;
            }
            
            public QuickFix.Fields.CustDirectedOrder Get(QuickFix.Fields.CustDirectedOrder val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CustDirectedOrder val) 
            { 
                return IsSetCustDirectedOrder();
            }
            
            public bool IsSetCustDirectedOrder() 
            { 
                return IsSetField(Tags.CustDirectedOrder);
            }
            public QuickFix.Fields.ReceivedDeptID ReceivedDeptID
            { 
                get 
                {
                    QuickFix.Fields.ReceivedDeptID val = new QuickFix.Fields.ReceivedDeptID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ReceivedDeptID val) 
            { 
                this.ReceivedDeptID = val;
            }
            
            public QuickFix.Fields.ReceivedDeptID Get(QuickFix.Fields.ReceivedDeptID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ReceivedDeptID val) 
            { 
                return IsSetReceivedDeptID();
            }
            
            public bool IsSetReceivedDeptID() 
            { 
                return IsSetField(Tags.ReceivedDeptID);
            }
            public QuickFix.Fields.CustOrderHandlingInst CustOrderHandlingInst
            { 
                get 
                {
                    QuickFix.Fields.CustOrderHandlingInst val = new QuickFix.Fields.CustOrderHandlingInst();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CustOrderHandlingInst val) 
            { 
                this.CustOrderHandlingInst = val;
            }
            
            public QuickFix.Fields.CustOrderHandlingInst Get(QuickFix.Fields.CustOrderHandlingInst val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CustOrderHandlingInst val) 
            { 
                return IsSetCustOrderHandlingInst();
            }
            
            public bool IsSetCustOrderHandlingInst() 
            { 
                return IsSetField(Tags.CustOrderHandlingInst);
            }
            public QuickFix.Fields.OrderHandlingInstSource OrderHandlingInstSource
            { 
                get 
                {
                    QuickFix.Fields.OrderHandlingInstSource val = new QuickFix.Fields.OrderHandlingInstSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderHandlingInstSource val) 
            { 
                this.OrderHandlingInstSource = val;
            }
            
            public QuickFix.Fields.OrderHandlingInstSource Get(QuickFix.Fields.OrderHandlingInstSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderHandlingInstSource val) 
            { 
                return IsSetOrderHandlingInstSource();
            }
            
            public bool IsSetOrderHandlingInstSource() 
            { 
                return IsSetField(Tags.OrderHandlingInstSource);
            }
            public QuickFix.Fields.NoTrdRegTimestamps NoTrdRegTimestamps
            { 
                get 
                {
                    QuickFix.Fields.NoTrdRegTimestamps val = new QuickFix.Fields.NoTrdRegTimestamps();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                this.NoTrdRegTimestamps = val;
            }
            
            public QuickFix.Fields.NoTrdRegTimestamps Get(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoTrdRegTimestamps val) 
            { 
                return IsSetNoTrdRegTimestamps();
            }
            
            public bool IsSetNoTrdRegTimestamps() 
            { 
                return IsSetField(Tags.NoTrdRegTimestamps);
            }
            public QuickFix.Fields.AggressorIndicator AggressorIndicator
            { 
                get 
                {
                    QuickFix.Fields.AggressorIndicator val = new QuickFix.Fields.AggressorIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AggressorIndicator val) 
            { 
                this.AggressorIndicator = val;
            }
            
            public QuickFix.Fields.AggressorIndicator Get(QuickFix.Fields.AggressorIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AggressorIndicator val) 
            { 
                return IsSetAggressorIndicator();
            }
            
            public bool IsSetAggressorIndicator() 
            { 
                return IsSetField(Tags.AggressorIndicator);
            }
            public QuickFix.Fields.CalculatedCcyLastQty CalculatedCcyLastQty
            { 
                get 
                {
                    QuickFix.Fields.CalculatedCcyLastQty val = new QuickFix.Fields.CalculatedCcyLastQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.CalculatedCcyLastQty val) 
            { 
                this.CalculatedCcyLastQty = val;
            }
            
            public QuickFix.Fields.CalculatedCcyLastQty Get(QuickFix.Fields.CalculatedCcyLastQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.CalculatedCcyLastQty val) 
            { 
                return IsSetCalculatedCcyLastQty();
            }
            
            public bool IsSetCalculatedCcyLastQty() 
            { 
                return IsSetField(Tags.CalculatedCcyLastQty);
            }
            public QuickFix.Fields.LastSwapPoints LastSwapPoints
            { 
                get 
                {
                    QuickFix.Fields.LastSwapPoints val = new QuickFix.Fields.LastSwapPoints();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastSwapPoints val) 
            { 
                this.LastSwapPoints = val;
            }
            
            public QuickFix.Fields.LastSwapPoints Get(QuickFix.Fields.LastSwapPoints val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastSwapPoints val) 
            { 
                return IsSetLastSwapPoints();
            }
            
            public bool IsSetLastSwapPoints() 
            { 
                return IsSetField(Tags.LastSwapPoints);
            }
            public QuickFix.Fields.MatchType MatchType
            { 
                get 
                {
                    QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MatchType val) 
            { 
                this.MatchType = val;
            }
            
            public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MatchType val) 
            { 
                return IsSetMatchType();
            }
            
            public bool IsSetMatchType() 
            { 
                return IsSetField(Tags.MatchType);
            }
            public QuickFix.Fields.OrderCategory OrderCategory
            { 
                get 
                {
                    QuickFix.Fields.OrderCategory val = new QuickFix.Fields.OrderCategory();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderCategory val) 
            { 
                this.OrderCategory = val;
            }
            
            public QuickFix.Fields.OrderCategory Get(QuickFix.Fields.OrderCategory val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderCategory val) 
            { 
                return IsSetOrderCategory();
            }
            
            public bool IsSetOrderCategory() 
            { 
                return IsSetField(Tags.OrderCategory);
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
            public QuickFix.Fields.PriceProtectionScope PriceProtectionScope
            { 
                get 
                {
                    QuickFix.Fields.PriceProtectionScope val = new QuickFix.Fields.PriceProtectionScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceProtectionScope val) 
            { 
                this.PriceProtectionScope = val;
            }
            
            public QuickFix.Fields.PriceProtectionScope Get(QuickFix.Fields.PriceProtectionScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceProtectionScope val) 
            { 
                return IsSetPriceProtectionScope();
            }
            
            public bool IsSetPriceProtectionScope() 
            { 
                return IsSetField(Tags.PriceProtectionScope);
            }
            public QuickFix.Fields.TriggerType TriggerType
            { 
                get 
                {
                    QuickFix.Fields.TriggerType val = new QuickFix.Fields.TriggerType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerType val) 
            { 
                this.TriggerType = val;
            }
            
            public QuickFix.Fields.TriggerType Get(QuickFix.Fields.TriggerType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerType val) 
            { 
                return IsSetTriggerType();
            }
            
            public bool IsSetTriggerType() 
            { 
                return IsSetField(Tags.TriggerType);
            }
            public QuickFix.Fields.TriggerAction TriggerAction
            { 
                get 
                {
                    QuickFix.Fields.TriggerAction val = new QuickFix.Fields.TriggerAction();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerAction val) 
            { 
                this.TriggerAction = val;
            }
            
            public QuickFix.Fields.TriggerAction Get(QuickFix.Fields.TriggerAction val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerAction val) 
            { 
                return IsSetTriggerAction();
            }
            
            public bool IsSetTriggerAction() 
            { 
                return IsSetField(Tags.TriggerAction);
            }
            public QuickFix.Fields.TriggerPrice TriggerPrice
            { 
                get 
                {
                    QuickFix.Fields.TriggerPrice val = new QuickFix.Fields.TriggerPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerPrice val) 
            { 
                this.TriggerPrice = val;
            }
            
            public QuickFix.Fields.TriggerPrice Get(QuickFix.Fields.TriggerPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerPrice val) 
            { 
                return IsSetTriggerPrice();
            }
            
            public bool IsSetTriggerPrice() 
            { 
                return IsSetField(Tags.TriggerPrice);
            }
            public QuickFix.Fields.TriggerSymbol TriggerSymbol
            { 
                get 
                {
                    QuickFix.Fields.TriggerSymbol val = new QuickFix.Fields.TriggerSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerSymbol val) 
            { 
                this.TriggerSymbol = val;
            }
            
            public QuickFix.Fields.TriggerSymbol Get(QuickFix.Fields.TriggerSymbol val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerSymbol val) 
            { 
                return IsSetTriggerSymbol();
            }
            
            public bool IsSetTriggerSymbol() 
            { 
                return IsSetField(Tags.TriggerSymbol);
            }
            public QuickFix.Fields.TriggerSecurityID TriggerSecurityID
            { 
                get 
                {
                    QuickFix.Fields.TriggerSecurityID val = new QuickFix.Fields.TriggerSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerSecurityID val) 
            { 
                this.TriggerSecurityID = val;
            }
            
            public QuickFix.Fields.TriggerSecurityID Get(QuickFix.Fields.TriggerSecurityID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerSecurityID val) 
            { 
                return IsSetTriggerSecurityID();
            }
            
            public bool IsSetTriggerSecurityID() 
            { 
                return IsSetField(Tags.TriggerSecurityID);
            }
            public QuickFix.Fields.TriggerSecurityIDSource TriggerSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.TriggerSecurityIDSource val = new QuickFix.Fields.TriggerSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerSecurityIDSource val) 
            { 
                this.TriggerSecurityIDSource = val;
            }
            
            public QuickFix.Fields.TriggerSecurityIDSource Get(QuickFix.Fields.TriggerSecurityIDSource val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerSecurityIDSource val) 
            { 
                return IsSetTriggerSecurityIDSource();
            }
            
            public bool IsSetTriggerSecurityIDSource() 
            { 
                return IsSetField(Tags.TriggerSecurityIDSource);
            }
            public QuickFix.Fields.TriggerSecurityDesc TriggerSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.TriggerSecurityDesc val = new QuickFix.Fields.TriggerSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerSecurityDesc val) 
            { 
                this.TriggerSecurityDesc = val;
            }
            
            public QuickFix.Fields.TriggerSecurityDesc Get(QuickFix.Fields.TriggerSecurityDesc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerSecurityDesc val) 
            { 
                return IsSetTriggerSecurityDesc();
            }
            
            public bool IsSetTriggerSecurityDesc() 
            { 
                return IsSetField(Tags.TriggerSecurityDesc);
            }
            public QuickFix.Fields.TriggerPriceType TriggerPriceType
            { 
                get 
                {
                    QuickFix.Fields.TriggerPriceType val = new QuickFix.Fields.TriggerPriceType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerPriceType val) 
            { 
                this.TriggerPriceType = val;
            }
            
            public QuickFix.Fields.TriggerPriceType Get(QuickFix.Fields.TriggerPriceType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerPriceType val) 
            { 
                return IsSetTriggerPriceType();
            }
            
            public bool IsSetTriggerPriceType() 
            { 
                return IsSetField(Tags.TriggerPriceType);
            }
            public QuickFix.Fields.TriggerPriceTypeScope TriggerPriceTypeScope
            { 
                get 
                {
                    QuickFix.Fields.TriggerPriceTypeScope val = new QuickFix.Fields.TriggerPriceTypeScope();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerPriceTypeScope val) 
            { 
                this.TriggerPriceTypeScope = val;
            }
            
            public QuickFix.Fields.TriggerPriceTypeScope Get(QuickFix.Fields.TriggerPriceTypeScope val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerPriceTypeScope val) 
            { 
                return IsSetTriggerPriceTypeScope();
            }
            
            public bool IsSetTriggerPriceTypeScope() 
            { 
                return IsSetField(Tags.TriggerPriceTypeScope);
            }
            public QuickFix.Fields.TriggerPriceDirection TriggerPriceDirection
            { 
                get 
                {
                    QuickFix.Fields.TriggerPriceDirection val = new QuickFix.Fields.TriggerPriceDirection();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerPriceDirection val) 
            { 
                this.TriggerPriceDirection = val;
            }
            
            public QuickFix.Fields.TriggerPriceDirection Get(QuickFix.Fields.TriggerPriceDirection val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerPriceDirection val) 
            { 
                return IsSetTriggerPriceDirection();
            }
            
            public bool IsSetTriggerPriceDirection() 
            { 
                return IsSetField(Tags.TriggerPriceDirection);
            }
            public QuickFix.Fields.TriggerNewPrice TriggerNewPrice
            { 
                get 
                {
                    QuickFix.Fields.TriggerNewPrice val = new QuickFix.Fields.TriggerNewPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerNewPrice val) 
            { 
                this.TriggerNewPrice = val;
            }
            
            public QuickFix.Fields.TriggerNewPrice Get(QuickFix.Fields.TriggerNewPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerNewPrice val) 
            { 
                return IsSetTriggerNewPrice();
            }
            
            public bool IsSetTriggerNewPrice() 
            { 
                return IsSetField(Tags.TriggerNewPrice);
            }
            public QuickFix.Fields.TriggerOrderType TriggerOrderType
            { 
                get 
                {
                    QuickFix.Fields.TriggerOrderType val = new QuickFix.Fields.TriggerOrderType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerOrderType val) 
            { 
                this.TriggerOrderType = val;
            }
            
            public QuickFix.Fields.TriggerOrderType Get(QuickFix.Fields.TriggerOrderType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerOrderType val) 
            { 
                return IsSetTriggerOrderType();
            }
            
            public bool IsSetTriggerOrderType() 
            { 
                return IsSetField(Tags.TriggerOrderType);
            }
            public QuickFix.Fields.TriggerNewQty TriggerNewQty
            { 
                get 
                {
                    QuickFix.Fields.TriggerNewQty val = new QuickFix.Fields.TriggerNewQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerNewQty val) 
            { 
                this.TriggerNewQty = val;
            }
            
            public QuickFix.Fields.TriggerNewQty Get(QuickFix.Fields.TriggerNewQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerNewQty val) 
            { 
                return IsSetTriggerNewQty();
            }
            
            public bool IsSetTriggerNewQty() 
            { 
                return IsSetField(Tags.TriggerNewQty);
            }
            public QuickFix.Fields.TriggerTradingSessionID TriggerTradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TriggerTradingSessionID val = new QuickFix.Fields.TriggerTradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerTradingSessionID val) 
            { 
                this.TriggerTradingSessionID = val;
            }
            
            public QuickFix.Fields.TriggerTradingSessionID Get(QuickFix.Fields.TriggerTradingSessionID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerTradingSessionID val) 
            { 
                return IsSetTriggerTradingSessionID();
            }
            
            public bool IsSetTriggerTradingSessionID() 
            { 
                return IsSetField(Tags.TriggerTradingSessionID);
            }
            public QuickFix.Fields.TriggerTradingSessionSubID TriggerTradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TriggerTradingSessionSubID val = new QuickFix.Fields.TriggerTradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TriggerTradingSessionSubID val) 
            { 
                this.TriggerTradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TriggerTradingSessionSubID Get(QuickFix.Fields.TriggerTradingSessionSubID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TriggerTradingSessionSubID val) 
            { 
                return IsSetTriggerTradingSessionSubID();
            }
            
            public bool IsSetTriggerTradingSessionSubID() 
            { 
                return IsSetField(Tags.TriggerTradingSessionSubID);
            }
            public QuickFix.Fields.PeggedRefPrice PeggedRefPrice
            { 
                get 
                {
                    QuickFix.Fields.PeggedRefPrice val = new QuickFix.Fields.PeggedRefPrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PeggedRefPrice val) 
            { 
                this.PeggedRefPrice = val;
            }
            
            public QuickFix.Fields.PeggedRefPrice Get(QuickFix.Fields.PeggedRefPrice val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PeggedRefPrice val) 
            { 
                return IsSetPeggedRefPrice();
            }
            
            public bool IsSetPeggedRefPrice() 
            { 
                return IsSetField(Tags.PeggedRefPrice);
            }
            public QuickFix.Fields.PreTradeAnonymity PreTradeAnonymity
            { 
                get 
                {
                    QuickFix.Fields.PreTradeAnonymity val = new QuickFix.Fields.PreTradeAnonymity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PreTradeAnonymity val) 
            { 
                this.PreTradeAnonymity = val;
            }
            
            public QuickFix.Fields.PreTradeAnonymity Get(QuickFix.Fields.PreTradeAnonymity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PreTradeAnonymity val) 
            { 
                return IsSetPreTradeAnonymity();
            }
            
            public bool IsSetPreTradeAnonymity() 
            { 
                return IsSetField(Tags.PreTradeAnonymity);
            }
            public QuickFix.Fields.MatchIncrement MatchIncrement
            { 
                get 
                {
                    QuickFix.Fields.MatchIncrement val = new QuickFix.Fields.MatchIncrement();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MatchIncrement val) 
            { 
                this.MatchIncrement = val;
            }
            
            public QuickFix.Fields.MatchIncrement Get(QuickFix.Fields.MatchIncrement val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MatchIncrement val) 
            { 
                return IsSetMatchIncrement();
            }
            
            public bool IsSetMatchIncrement() 
            { 
                return IsSetField(Tags.MatchIncrement);
            }
            public QuickFix.Fields.MaxPriceLevels MaxPriceLevels
            { 
                get 
                {
                    QuickFix.Fields.MaxPriceLevels val = new QuickFix.Fields.MaxPriceLevels();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxPriceLevels val) 
            { 
                this.MaxPriceLevels = val;
            }
            
            public QuickFix.Fields.MaxPriceLevels Get(QuickFix.Fields.MaxPriceLevels val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxPriceLevels val) 
            { 
                return IsSetMaxPriceLevels();
            }
            
            public bool IsSetMaxPriceLevels() 
            { 
                return IsSetField(Tags.MaxPriceLevels);
            }
            public QuickFix.Fields.SecondaryDisplayQty SecondaryDisplayQty
            { 
                get 
                {
                    QuickFix.Fields.SecondaryDisplayQty val = new QuickFix.Fields.SecondaryDisplayQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SecondaryDisplayQty val) 
            { 
                this.SecondaryDisplayQty = val;
            }
            
            public QuickFix.Fields.SecondaryDisplayQty Get(QuickFix.Fields.SecondaryDisplayQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SecondaryDisplayQty val) 
            { 
                return IsSetSecondaryDisplayQty();
            }
            
            public bool IsSetSecondaryDisplayQty() 
            { 
                return IsSetField(Tags.SecondaryDisplayQty);
            }
            public QuickFix.Fields.DisplayWhen DisplayWhen
            { 
                get 
                {
                    QuickFix.Fields.DisplayWhen val = new QuickFix.Fields.DisplayWhen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DisplayWhen val) 
            { 
                this.DisplayWhen = val;
            }
            
            public QuickFix.Fields.DisplayWhen Get(QuickFix.Fields.DisplayWhen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DisplayWhen val) 
            { 
                return IsSetDisplayWhen();
            }
            
            public bool IsSetDisplayWhen() 
            { 
                return IsSetField(Tags.DisplayWhen);
            }
            public QuickFix.Fields.DisplayMethod DisplayMethod
            { 
                get 
                {
                    QuickFix.Fields.DisplayMethod val = new QuickFix.Fields.DisplayMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DisplayMethod val) 
            { 
                this.DisplayMethod = val;
            }
            
            public QuickFix.Fields.DisplayMethod Get(QuickFix.Fields.DisplayMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DisplayMethod val) 
            { 
                return IsSetDisplayMethod();
            }
            
            public bool IsSetDisplayMethod() 
            { 
                return IsSetField(Tags.DisplayMethod);
            }
            public QuickFix.Fields.DisplayLowQty DisplayLowQty
            { 
                get 
                {
                    QuickFix.Fields.DisplayLowQty val = new QuickFix.Fields.DisplayLowQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DisplayLowQty val) 
            { 
                this.DisplayLowQty = val;
            }
            
            public QuickFix.Fields.DisplayLowQty Get(QuickFix.Fields.DisplayLowQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DisplayLowQty val) 
            { 
                return IsSetDisplayLowQty();
            }
            
            public bool IsSetDisplayLowQty() 
            { 
                return IsSetField(Tags.DisplayLowQty);
            }
            public QuickFix.Fields.DisplayHighQty DisplayHighQty
            { 
                get 
                {
                    QuickFix.Fields.DisplayHighQty val = new QuickFix.Fields.DisplayHighQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DisplayHighQty val) 
            { 
                this.DisplayHighQty = val;
            }
            
            public QuickFix.Fields.DisplayHighQty Get(QuickFix.Fields.DisplayHighQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DisplayHighQty val) 
            { 
                return IsSetDisplayHighQty();
            }
            
            public bool IsSetDisplayHighQty() 
            { 
                return IsSetField(Tags.DisplayHighQty);
            }
            public QuickFix.Fields.DisplayMinIncr DisplayMinIncr
            { 
                get 
                {
                    QuickFix.Fields.DisplayMinIncr val = new QuickFix.Fields.DisplayMinIncr();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DisplayMinIncr val) 
            { 
                this.DisplayMinIncr = val;
            }
            
            public QuickFix.Fields.DisplayMinIncr Get(QuickFix.Fields.DisplayMinIncr val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DisplayMinIncr val) 
            { 
                return IsSetDisplayMinIncr();
            }
            
            public bool IsSetDisplayMinIncr() 
            { 
                return IsSetField(Tags.DisplayMinIncr);
            }
            public QuickFix.Fields.RefreshQty RefreshQty
            { 
                get 
                {
                    QuickFix.Fields.RefreshQty val = new QuickFix.Fields.RefreshQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefreshQty val) 
            { 
                this.RefreshQty = val;
            }
            
            public QuickFix.Fields.RefreshQty Get(QuickFix.Fields.RefreshQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefreshQty val) 
            { 
                return IsSetRefreshQty();
            }
            
            public bool IsSetRefreshQty() 
            { 
                return IsSetField(Tags.RefreshQty);
            }
            public QuickFix.Fields.DisplayQty DisplayQty
            { 
                get 
                {
                    QuickFix.Fields.DisplayQty val = new QuickFix.Fields.DisplayQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DisplayQty val) 
            { 
                this.DisplayQty = val;
            }
            
            public QuickFix.Fields.DisplayQty Get(QuickFix.Fields.DisplayQty val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DisplayQty val) 
            { 
                return IsSetDisplayQty();
            }
            
            public bool IsSetDisplayQty() 
            { 
                return IsSetField(Tags.DisplayQty);
            }
            public QuickFix.Fields.Volatility Volatility
            { 
                get 
                {
                    QuickFix.Fields.Volatility val = new QuickFix.Fields.Volatility();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Volatility val) 
            { 
                this.Volatility = val;
            }
            
            public QuickFix.Fields.Volatility Get(QuickFix.Fields.Volatility val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Volatility val) 
            { 
                return IsSetVolatility();
            }
            
            public bool IsSetVolatility() 
            { 
                return IsSetField(Tags.Volatility);
            }
            public QuickFix.Fields.TimeToExpiration TimeToExpiration
            { 
                get 
                {
                    QuickFix.Fields.TimeToExpiration val = new QuickFix.Fields.TimeToExpiration();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TimeToExpiration val) 
            { 
                this.TimeToExpiration = val;
            }
            
            public QuickFix.Fields.TimeToExpiration Get(QuickFix.Fields.TimeToExpiration val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TimeToExpiration val) 
            { 
                return IsSetTimeToExpiration();
            }
            
            public bool IsSetTimeToExpiration() 
            { 
                return IsSetField(Tags.TimeToExpiration);
            }
            public QuickFix.Fields.RiskFreeRate RiskFreeRate
            { 
                get 
                {
                    QuickFix.Fields.RiskFreeRate val = new QuickFix.Fields.RiskFreeRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RiskFreeRate val) 
            { 
                this.RiskFreeRate = val;
            }
            
            public QuickFix.Fields.RiskFreeRate Get(QuickFix.Fields.RiskFreeRate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RiskFreeRate val) 
            { 
                return IsSetRiskFreeRate();
            }
            
            public bool IsSetRiskFreeRate() 
            { 
                return IsSetField(Tags.RiskFreeRate);
            }
            public QuickFix.Fields.PriceDelta PriceDelta
            { 
                get 
                {
                    QuickFix.Fields.PriceDelta val = new QuickFix.Fields.PriceDelta();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PriceDelta val) 
            { 
                this.PriceDelta = val;
            }
            
            public QuickFix.Fields.PriceDelta Get(QuickFix.Fields.PriceDelta val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PriceDelta val) 
            { 
                return IsSetPriceDelta();
            }
            
            public bool IsSetPriceDelta() 
            { 
                return IsSetField(Tags.PriceDelta);
            }
            public QuickFix.Fields.TrdMatchID TrdMatchID
            { 
                get 
                {
                    QuickFix.Fields.TrdMatchID val = new QuickFix.Fields.TrdMatchID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TrdMatchID val) 
            { 
                this.TrdMatchID = val;
            }
            
            public QuickFix.Fields.TrdMatchID Get(QuickFix.Fields.TrdMatchID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TrdMatchID val) 
            { 
                return IsSetTrdMatchID();
            }
            
            public bool IsSetTrdMatchID() 
            { 
                return IsSetField(Tags.TrdMatchID);
            }
            public QuickFix.Fields.AllocID AllocID
            { 
                get 
                {
                    QuickFix.Fields.AllocID val = new QuickFix.Fields.AllocID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AllocID val) 
            { 
                this.AllocID = val;
            }
            
            public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AllocID val) 
            { 
                return IsSetAllocID();
            }
            
            public bool IsSetAllocID() 
            { 
                return IsSetField(Tags.AllocID);
            }
            public QuickFix.Fields.NoAllocs NoAllocs
            { 
                get 
                {
                    QuickFix.Fields.NoAllocs val = new QuickFix.Fields.NoAllocs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoAllocs val) 
            { 
                this.NoAllocs = val;
            }
            
            public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoAllocs val) 
            { 
                return IsSetNoAllocs();
            }
            
            public bool IsSetNoAllocs() 
            { 
                return IsSetField(Tags.NoAllocs);
            }
            public QuickFix.Fields.TotNoFills TotNoFills
            { 
                get 
                {
                    QuickFix.Fields.TotNoFills val = new QuickFix.Fields.TotNoFills();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoFills val) 
            { 
                this.TotNoFills = val;
            }
            
            public QuickFix.Fields.TotNoFills Get(QuickFix.Fields.TotNoFills val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoFills val) 
            { 
                return IsSetTotNoFills();
            }
            
            public bool IsSetTotNoFills() 
            { 
                return IsSetField(Tags.TotNoFills);
            }
            public QuickFix.Fields.LastFragment LastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastFragment val) 
            { 
                this.LastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastFragment val) 
            { 
                return IsSetLastFragment();
            }
            
            public bool IsSetLastFragment() 
            { 
                return IsSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoFills NoFills
            { 
                get 
                {
                    QuickFix.Fields.NoFills val = new QuickFix.Fields.NoFills();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoFills val) 
            { 
                this.NoFills = val;
            }
            
            public QuickFix.Fields.NoFills Get(QuickFix.Fields.NoFills val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoFills val) 
            { 
                return IsSetNoFills();
            }
            
            public bool IsSetNoFills() 
            { 
                return IsSetField(Tags.NoFills);
            }
            public QuickFix.Fields.DividendYield DividendYield
            { 
                get 
                {
                    QuickFix.Fields.DividendYield val = new QuickFix.Fields.DividendYield();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.DividendYield val) 
            { 
                this.DividendYield = val;
            }
            
            public QuickFix.Fields.DividendYield Get(QuickFix.Fields.DividendYield val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.DividendYield val) 
            { 
                return IsSetDividendYield();
            }
            
            public bool IsSetDividendYield() 
            { 
                return IsSetField(Tags.DividendYield);
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
            public QuickFix.Fields.NoRateSources NoRateSources
            { 
                get 
                {
                    QuickFix.Fields.NoRateSources val = new QuickFix.Fields.NoRateSources();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRateSources val) 
            { 
                this.NoRateSources = val;
            }
            
            public QuickFix.Fields.NoRateSources Get(QuickFix.Fields.NoRateSources val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRateSources val) 
            { 
                return IsSetNoRateSources();
            }
            
            public bool IsSetNoRateSources() 
            { 
                return IsSetField(Tags.NoRateSources);
            }
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
            
                public NoPartyIDsGroup() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.PartyID PartyID
                { 
                    get 
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    this.PartyID = val;
                }
                
                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyID val) 
                { 
                    return IsSetPartyID();
                }
                
                public bool IsSetPartyID() 
                { 
                    return IsSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource PartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.PartyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return IsSetPartyIDSource();
                }
                
                public bool IsSetPartyIDSource() 
                { 
                    return IsSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole PartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyRole val) 
                { 
                    this.PartyRole = val;
                }
                
                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PartyRole val) 
                { 
                    return IsSetPartyRole();
                }
                
                public bool IsSetPartyRole() 
                { 
                    return IsSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    this.NoPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return IsSetNoPartySubIDs();
                }
                
                public bool IsSetNoPartySubIDs() 
                { 
                    return IsSetField(Tags.NoPartySubIDs);
                }
                            public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                
                    public NoPartySubIDsGroup() 
                      :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.PartySubID PartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.PartySubID = val;
                    }
                    
                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubID val) 
                    { 
                        return IsSetPartySubID();
                    }
                    
                    public bool IsSetPartySubID() 
                    { 
                        return IsSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        this.PartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return IsSetPartySubIDType();
                    }
                    
                    public bool IsSetPartySubIDType() 
                    { 
                        return IsSetField(Tags.PartySubIDType);
                    }
                
                }
            }
            public class NoContraBrokersGroup : Group
            {
                public static int[] fieldOrder = {Tags.ContraBroker, Tags.ContraTrader, Tags.ContraTradeQty, Tags.ContraTradeTime, Tags.ContraLegRefID, 0};
            
                public NoContraBrokersGroup() 
                  :base( Tags.NoContraBrokers, Tags.ContraBroker, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoContraBrokersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ContraBroker ContraBroker
                { 
                    get 
                    {
                        QuickFix.Fields.ContraBroker val = new QuickFix.Fields.ContraBroker();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContraBroker val) 
                { 
                    this.ContraBroker = val;
                }
                
                public QuickFix.Fields.ContraBroker Get(QuickFix.Fields.ContraBroker val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContraBroker val) 
                { 
                    return IsSetContraBroker();
                }
                
                public bool IsSetContraBroker() 
                { 
                    return IsSetField(Tags.ContraBroker);
                }
                public QuickFix.Fields.ContraTrader ContraTrader
                { 
                    get 
                    {
                        QuickFix.Fields.ContraTrader val = new QuickFix.Fields.ContraTrader();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContraTrader val) 
                { 
                    this.ContraTrader = val;
                }
                
                public QuickFix.Fields.ContraTrader Get(QuickFix.Fields.ContraTrader val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContraTrader val) 
                { 
                    return IsSetContraTrader();
                }
                
                public bool IsSetContraTrader() 
                { 
                    return IsSetField(Tags.ContraTrader);
                }
                public QuickFix.Fields.ContraTradeQty ContraTradeQty
                { 
                    get 
                    {
                        QuickFix.Fields.ContraTradeQty val = new QuickFix.Fields.ContraTradeQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContraTradeQty val) 
                { 
                    this.ContraTradeQty = val;
                }
                
                public QuickFix.Fields.ContraTradeQty Get(QuickFix.Fields.ContraTradeQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContraTradeQty val) 
                { 
                    return IsSetContraTradeQty();
                }
                
                public bool IsSetContraTradeQty() 
                { 
                    return IsSetField(Tags.ContraTradeQty);
                }
                public QuickFix.Fields.ContraTradeTime ContraTradeTime
                { 
                    get 
                    {
                        QuickFix.Fields.ContraTradeTime val = new QuickFix.Fields.ContraTradeTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContraTradeTime val) 
                { 
                    this.ContraTradeTime = val;
                }
                
                public QuickFix.Fields.ContraTradeTime Get(QuickFix.Fields.ContraTradeTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContraTradeTime val) 
                { 
                    return IsSetContraTradeTime();
                }
                
                public bool IsSetContraTradeTime() 
                { 
                    return IsSetField(Tags.ContraTradeTime);
                }
                public QuickFix.Fields.ContraLegRefID ContraLegRefID
                { 
                    get 
                    {
                        QuickFix.Fields.ContraLegRefID val = new QuickFix.Fields.ContraLegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContraLegRefID val) 
                { 
                    this.ContraLegRefID = val;
                }
                
                public QuickFix.Fields.ContraLegRefID Get(QuickFix.Fields.ContraLegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContraLegRefID val) 
                { 
                    return IsSetContraLegRefID();
                }
                
                public bool IsSetContraLegRefID() 
                { 
                    return IsSetField(Tags.ContraLegRefID);
                }
            
            }
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
            
                public NoSecurityAltIDGroup() 
                  :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.SecurityAltID SecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltID val) 
                { 
                    this.SecurityAltID = val;
                }
                
                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                { 
                    return IsSetSecurityAltID();
                }
                
                public bool IsSetSecurityAltID() 
                { 
                    return IsSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    this.SecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                { 
                    return IsSetSecurityAltIDSource();
                }
                
                public bool IsSetSecurityAltIDSource() 
                { 
                    return IsSetField(Tags.SecurityAltIDSource);
                }
            
            }
            public class NoEventsGroup : Group
            {
                public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
            
                public NoEventsGroup() 
                  :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.EventType EventType
                { 
                    get 
                    {
                        QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventType val) 
                { 
                    this.EventType = val;
                }
                
                public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventType val) 
                { 
                    return IsSetEventType();
                }
                
                public bool IsSetEventType() 
                { 
                    return IsSetField(Tags.EventType);
                }
                public QuickFix.Fields.EventDate EventDate
                { 
                    get 
                    {
                        QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventDate val) 
                { 
                    this.EventDate = val;
                }
                
                public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventDate val) 
                { 
                    return IsSetEventDate();
                }
                
                public bool IsSetEventDate() 
                { 
                    return IsSetField(Tags.EventDate);
                }
                public QuickFix.Fields.EventPx EventPx
                { 
                    get 
                    {
                        QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventPx val) 
                { 
                    this.EventPx = val;
                }
                
                public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventPx val) 
                { 
                    return IsSetEventPx();
                }
                
                public bool IsSetEventPx() 
                { 
                    return IsSetField(Tags.EventPx);
                }
                public QuickFix.Fields.EventText EventText
                { 
                    get 
                    {
                        QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventText val) 
                { 
                    this.EventText = val;
                }
                
                public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventText val) 
                { 
                    return IsSetEventText();
                }
                
                public bool IsSetEventText() 
                { 
                    return IsSetField(Tags.EventText);
                }
                public QuickFix.Fields.EventTime EventTime
                { 
                    get 
                    {
                        QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EventTime val) 
                { 
                    this.EventTime = val;
                }
                
                public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EventTime val) 
                { 
                    return IsSetEventTime();
                }
                
                public bool IsSetEventTime() 
                { 
                    return IsSetField(Tags.EventTime);
                }
            
            }
            public class NoInstrumentPartiesGroup : Group
            {
                public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
            
                public NoInstrumentPartiesGroup() 
                  :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoInstrumentPartiesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    this.InstrumentPartyID = val;
                }
                
                public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyID val) 
                { 
                    return IsSetInstrumentPartyID();
                }
                
                public bool IsSetInstrumentPartyID() 
                { 
                    return IsSetField(Tags.InstrumentPartyID);
                }
                public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    this.InstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                { 
                    return IsSetInstrumentPartyIDSource();
                }
                
                public bool IsSetInstrumentPartyIDSource() 
                { 
                    return IsSetField(Tags.InstrumentPartyIDSource);
                }
                public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    this.InstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) 
                { 
                    return IsSetInstrumentPartyRole();
                }
                
                public bool IsSetInstrumentPartyRole() 
                { 
                    return IsSetField(Tags.InstrumentPartyRole);
                }
                public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    this.NoInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                { 
                    return IsSetNoInstrumentPartySubIDs();
                }
                
                public bool IsSetNoInstrumentPartySubIDs() 
                { 
                    return IsSetField(Tags.NoInstrumentPartySubIDs);
                }
                            public class NoInstrumentPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                
                    public NoInstrumentPartySubIDsGroup() 
                      :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoInstrumentPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        this.InstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) 
                    { 
                        return IsSetInstrumentPartySubID();
                    }
                    
                    public bool IsSetInstrumentPartySubID() 
                    { 
                        return IsSetField(Tags.InstrumentPartySubID);
                    }
                    public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        this.InstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                    { 
                        return IsSetInstrumentPartySubIDType();
                    }
                    
                    public bool IsSetInstrumentPartySubIDType() 
                    { 
                        return IsSetField(Tags.InstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoComplexEventsGroup : Group
            {
                public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};
            
                public NoComplexEventsGroup() 
                  :base( Tags.NoComplexEvents, Tags.ComplexEventType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoComplexEventsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ComplexEventType ComplexEventType
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventType val = new QuickFix.Fields.ComplexEventType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventType val) 
                { 
                    this.ComplexEventType = val;
                }
                
                public QuickFix.Fields.ComplexEventType Get(QuickFix.Fields.ComplexEventType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventType val) 
                { 
                    return IsSetComplexEventType();
                }
                
                public bool IsSetComplexEventType() 
                { 
                    return IsSetField(Tags.ComplexEventType);
                }
                public QuickFix.Fields.ComplexOptPayoutAmount ComplexOptPayoutAmount
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexOptPayoutAmount val = new QuickFix.Fields.ComplexOptPayoutAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexOptPayoutAmount val) 
                { 
                    this.ComplexOptPayoutAmount = val;
                }
                
                public QuickFix.Fields.ComplexOptPayoutAmount Get(QuickFix.Fields.ComplexOptPayoutAmount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexOptPayoutAmount val) 
                { 
                    return IsSetComplexOptPayoutAmount();
                }
                
                public bool IsSetComplexOptPayoutAmount() 
                { 
                    return IsSetField(Tags.ComplexOptPayoutAmount);
                }
                public QuickFix.Fields.ComplexEventPrice ComplexEventPrice
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPrice val = new QuickFix.Fields.ComplexEventPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPrice val) 
                { 
                    this.ComplexEventPrice = val;
                }
                
                public QuickFix.Fields.ComplexEventPrice Get(QuickFix.Fields.ComplexEventPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPrice val) 
                { 
                    return IsSetComplexEventPrice();
                }
                
                public bool IsSetComplexEventPrice() 
                { 
                    return IsSetField(Tags.ComplexEventPrice);
                }
                public QuickFix.Fields.ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPriceBoundaryMethod val = new QuickFix.Fields.ComplexEventPriceBoundaryMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                { 
                    this.ComplexEventPriceBoundaryMethod = val;
                }
                
                public QuickFix.Fields.ComplexEventPriceBoundaryMethod Get(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                { 
                    return IsSetComplexEventPriceBoundaryMethod();
                }
                
                public bool IsSetComplexEventPriceBoundaryMethod() 
                { 
                    return IsSetField(Tags.ComplexEventPriceBoundaryMethod);
                }
                public QuickFix.Fields.ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPriceBoundaryPrecision val = new QuickFix.Fields.ComplexEventPriceBoundaryPrecision();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                { 
                    this.ComplexEventPriceBoundaryPrecision = val;
                }
                
                public QuickFix.Fields.ComplexEventPriceBoundaryPrecision Get(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                { 
                    return IsSetComplexEventPriceBoundaryPrecision();
                }
                
                public bool IsSetComplexEventPriceBoundaryPrecision() 
                { 
                    return IsSetField(Tags.ComplexEventPriceBoundaryPrecision);
                }
                public QuickFix.Fields.ComplexEventPriceTimeType ComplexEventPriceTimeType
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventPriceTimeType val = new QuickFix.Fields.ComplexEventPriceTimeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventPriceTimeType val) 
                { 
                    this.ComplexEventPriceTimeType = val;
                }
                
                public QuickFix.Fields.ComplexEventPriceTimeType Get(QuickFix.Fields.ComplexEventPriceTimeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventPriceTimeType val) 
                { 
                    return IsSetComplexEventPriceTimeType();
                }
                
                public bool IsSetComplexEventPriceTimeType() 
                { 
                    return IsSetField(Tags.ComplexEventPriceTimeType);
                }
                public QuickFix.Fields.ComplexEventCondition ComplexEventCondition
                { 
                    get 
                    {
                        QuickFix.Fields.ComplexEventCondition val = new QuickFix.Fields.ComplexEventCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ComplexEventCondition val) 
                { 
                    this.ComplexEventCondition = val;
                }
                
                public QuickFix.Fields.ComplexEventCondition Get(QuickFix.Fields.ComplexEventCondition val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ComplexEventCondition val) 
                { 
                    return IsSetComplexEventCondition();
                }
                
                public bool IsSetComplexEventCondition() 
                { 
                    return IsSetField(Tags.ComplexEventCondition);
                }
                public QuickFix.Fields.NoComplexEventDates NoComplexEventDates
                { 
                    get 
                    {
                        QuickFix.Fields.NoComplexEventDates val = new QuickFix.Fields.NoComplexEventDates();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoComplexEventDates val) 
                { 
                    this.NoComplexEventDates = val;
                }
                
                public QuickFix.Fields.NoComplexEventDates Get(QuickFix.Fields.NoComplexEventDates val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoComplexEventDates val) 
                { 
                    return IsSetNoComplexEventDates();
                }
                
                public bool IsSetNoComplexEventDates() 
                { 
                    return IsSetField(Tags.NoComplexEventDates);
                }
                            public class NoComplexEventDatesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};
                
                    public NoComplexEventDatesGroup() 
                      :base( Tags.NoComplexEventDates, Tags.ComplexEventStartDate, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoComplexEventDatesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.ComplexEventStartDate ComplexEventStartDate
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventStartDate val = new QuickFix.Fields.ComplexEventStartDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventStartDate val) 
                    { 
                        this.ComplexEventStartDate = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventStartDate Get(QuickFix.Fields.ComplexEventStartDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventStartDate val) 
                    { 
                        return IsSetComplexEventStartDate();
                    }
                    
                    public bool IsSetComplexEventStartDate() 
                    { 
                        return IsSetField(Tags.ComplexEventStartDate);
                    }
                    public QuickFix.Fields.ComplexEventEndDate ComplexEventEndDate
                    { 
                        get 
                        {
                            QuickFix.Fields.ComplexEventEndDate val = new QuickFix.Fields.ComplexEventEndDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ComplexEventEndDate val) 
                    { 
                        this.ComplexEventEndDate = val;
                    }
                    
                    public QuickFix.Fields.ComplexEventEndDate Get(QuickFix.Fields.ComplexEventEndDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ComplexEventEndDate val) 
                    { 
                        return IsSetComplexEventEndDate();
                    }
                    
                    public bool IsSetComplexEventEndDate() 
                    { 
                        return IsSetField(Tags.ComplexEventEndDate);
                    }
                    public QuickFix.Fields.NoComplexEventTimes NoComplexEventTimes
                    { 
                        get 
                        {
                            QuickFix.Fields.NoComplexEventTimes val = new QuickFix.Fields.NoComplexEventTimes();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoComplexEventTimes val) 
                    { 
                        this.NoComplexEventTimes = val;
                    }
                    
                    public QuickFix.Fields.NoComplexEventTimes Get(QuickFix.Fields.NoComplexEventTimes val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoComplexEventTimes val) 
                    { 
                        return IsSetNoComplexEventTimes();
                    }
                    
                    public bool IsSetNoComplexEventTimes() 
                    { 
                        return IsSetField(Tags.NoComplexEventTimes);
                    }
                                    public class NoComplexEventTimesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};
                    
                        public NoComplexEventTimesGroup() 
                          :base( Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoComplexEventTimesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.ComplexEventStartTime ComplexEventStartTime
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventStartTime val = new QuickFix.Fields.ComplexEventStartTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventStartTime val) 
                        { 
                            this.ComplexEventStartTime = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventStartTime Get(QuickFix.Fields.ComplexEventStartTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventStartTime val) 
                        { 
                            return IsSetComplexEventStartTime();
                        }
                        
                        public bool IsSetComplexEventStartTime() 
                        { 
                            return IsSetField(Tags.ComplexEventStartTime);
                        }
                        public QuickFix.Fields.ComplexEventEndTime ComplexEventEndTime
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventEndTime val = new QuickFix.Fields.ComplexEventEndTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventEndTime val) 
                        { 
                            this.ComplexEventEndTime = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventEndTime Get(QuickFix.Fields.ComplexEventEndTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventEndTime val) 
                        { 
                            return IsSetComplexEventEndTime();
                        }
                        
                        public bool IsSetComplexEventEndTime() 
                        { 
                            return IsSetField(Tags.ComplexEventEndTime);
                        }
                    
                    }
                }
            }
            public class NoUnderlyingsGroup : Group
            {
                public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, 0};
            
                public NoUnderlyingsGroup() 
                  :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoUnderlyingsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    this.UnderlyingSymbol = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
                { 
                    return IsSetUnderlyingSymbol();
                }
                
                public bool IsSetUnderlyingSymbol() 
                { 
                    return IsSetField(Tags.UnderlyingSymbol);
                }
                public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    this.UnderlyingSymbolSfx = val;
                }
                
                public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
                { 
                    return IsSetUnderlyingSymbolSfx();
                }
                
                public bool IsSetUnderlyingSymbolSfx() 
                { 
                    return IsSetField(Tags.UnderlyingSymbolSfx);
                }
                public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    this.UnderlyingSecurityID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
                { 
                    return IsSetUnderlyingSecurityID();
                }
                
                public bool IsSetUnderlyingSecurityID() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityID);
                }
                public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    this.UnderlyingSecurityIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                { 
                    return IsSetUnderlyingSecurityIDSource();
                }
                
                public bool IsSetUnderlyingSecurityIDSource() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityIDSource);
                }
                public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    this.NoUnderlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                { 
                    return IsSetNoUnderlyingSecurityAltID();
                }
                
                public bool IsSetNoUnderlyingSecurityAltID() 
                { 
                    return IsSetField(Tags.NoUnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    this.UnderlyingProduct = val;
                }
                
                public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingProduct val) 
                { 
                    return IsSetUnderlyingProduct();
                }
                
                public bool IsSetUnderlyingProduct() 
                { 
                    return IsSetField(Tags.UnderlyingProduct);
                }
                public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    this.UnderlyingCFICode = val;
                }
                
                public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
                { 
                    return IsSetUnderlyingCFICode();
                }
                
                public bool IsSetUnderlyingCFICode() 
                { 
                    return IsSetField(Tags.UnderlyingCFICode);
                }
                public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    this.UnderlyingSecurityType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) 
                { 
                    return IsSetUnderlyingSecurityType();
                }
                
                public bool IsSetUnderlyingSecurityType() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityType);
                }
                public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    this.UnderlyingSecuritySubType = val;
                }
                
                public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                { 
                    return IsSetUnderlyingSecuritySubType();
                }
                
                public bool IsSetUnderlyingSecuritySubType() 
                { 
                    return IsSetField(Tags.UnderlyingSecuritySubType);
                }
                public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    this.UnderlyingMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                { 
                    return IsSetUnderlyingMaturityMonthYear();
                }
                
                public bool IsSetUnderlyingMaturityMonthYear() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityMonthYear);
                }
                public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    this.UnderlyingMaturityDate = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                { 
                    return IsSetUnderlyingMaturityDate();
                }
                
                public bool IsSetUnderlyingMaturityDate() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityDate);
                }
                public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    this.UnderlyingCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                { 
                    return IsSetUnderlyingCouponPaymentDate();
                }
                
                public bool IsSetUnderlyingCouponPaymentDate() 
                { 
                    return IsSetField(Tags.UnderlyingCouponPaymentDate);
                }
                public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    this.UnderlyingIssueDate = val;
                }
                
                public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
                { 
                    return IsSetUnderlyingIssueDate();
                }
                
                public bool IsSetUnderlyingIssueDate() 
                { 
                    return IsSetField(Tags.UnderlyingIssueDate);
                }
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    this.UnderlyingRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                { 
                    return IsSetUnderlyingRepoCollateralSecurityType();
                }
                
                public bool IsSetUnderlyingRepoCollateralSecurityType() 
                { 
                    return IsSetField(Tags.UnderlyingRepoCollateralSecurityType);
                }
                public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    this.UnderlyingRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                { 
                    return IsSetUnderlyingRepurchaseTerm();
                }
                
                public bool IsSetUnderlyingRepurchaseTerm() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseTerm);
                }
                public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    this.UnderlyingRepurchaseRate = val;
                }
                
                public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                { 
                    return IsSetUnderlyingRepurchaseRate();
                }
                
                public bool IsSetUnderlyingRepurchaseRate() 
                { 
                    return IsSetField(Tags.UnderlyingRepurchaseRate);
                }
                public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    this.UnderlyingFactor = val;
                }
                
                public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
                { 
                    return IsSetUnderlyingFactor();
                }
                
                public bool IsSetUnderlyingFactor() 
                { 
                    return IsSetField(Tags.UnderlyingFactor);
                }
                public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    this.UnderlyingCreditRating = val;
                }
                
                public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
                { 
                    return IsSetUnderlyingCreditRating();
                }
                
                public bool IsSetUnderlyingCreditRating() 
                { 
                    return IsSetField(Tags.UnderlyingCreditRating);
                }
                public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    this.UnderlyingInstrRegistry = val;
                }
                
                public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                { 
                    return IsSetUnderlyingInstrRegistry();
                }
                
                public bool IsSetUnderlyingInstrRegistry() 
                { 
                    return IsSetField(Tags.UnderlyingInstrRegistry);
                }
                public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    this.UnderlyingCountryOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                { 
                    return IsSetUnderlyingCountryOfIssue();
                }
                
                public bool IsSetUnderlyingCountryOfIssue() 
                { 
                    return IsSetField(Tags.UnderlyingCountryOfIssue);
                }
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    this.UnderlyingStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                { 
                    return IsSetUnderlyingStateOrProvinceOfIssue();
                }
                
                public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                { 
                    return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    this.UnderlyingLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                { 
                    return IsSetUnderlyingLocaleOfIssue();
                }
                
                public bool IsSetUnderlyingLocaleOfIssue() 
                { 
                    return IsSetField(Tags.UnderlyingLocaleOfIssue);
                }
                public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    this.UnderlyingRedemptionDate = val;
                }
                
                public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
                { 
                    return IsSetUnderlyingRedemptionDate();
                }
                
                public bool IsSetUnderlyingRedemptionDate() 
                { 
                    return IsSetField(Tags.UnderlyingRedemptionDate);
                }
                public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    this.UnderlyingStrikePrice = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
                { 
                    return IsSetUnderlyingStrikePrice();
                }
                
                public bool IsSetUnderlyingStrikePrice() 
                { 
                    return IsSetField(Tags.UnderlyingStrikePrice);
                }
                public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    this.UnderlyingStrikeCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                { 
                    return IsSetUnderlyingStrikeCurrency();
                }
                
                public bool IsSetUnderlyingStrikeCurrency() 
                { 
                    return IsSetField(Tags.UnderlyingStrikeCurrency);
                }
                public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    this.UnderlyingOptAttribute = val;
                }
                
                public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) 
                { 
                    return IsSetUnderlyingOptAttribute();
                }
                
                public bool IsSetUnderlyingOptAttribute() 
                { 
                    return IsSetField(Tags.UnderlyingOptAttribute);
                }
                public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    this.UnderlyingContractMultiplier = val;
                }
                
                public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
                { 
                    return IsSetUnderlyingContractMultiplier();
                }
                
                public bool IsSetUnderlyingContractMultiplier() 
                { 
                    return IsSetField(Tags.UnderlyingContractMultiplier);
                }
                public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    this.UnderlyingCouponRate = val;
                }
                
                public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
                { 
                    return IsSetUnderlyingCouponRate();
                }
                
                public bool IsSetUnderlyingCouponRate() 
                { 
                    return IsSetField(Tags.UnderlyingCouponRate);
                }
                public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    this.UnderlyingSecurityExchange = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
                { 
                    return IsSetUnderlyingSecurityExchange();
                }
                
                public bool IsSetUnderlyingSecurityExchange() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityExchange);
                }
                public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    this.UnderlyingIssuer = val;
                }
                
                public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) 
                { 
                    return IsSetUnderlyingIssuer();
                }
                
                public bool IsSetUnderlyingIssuer() 
                { 
                    return IsSetField(Tags.UnderlyingIssuer);
                }
                public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    this.EncodedUnderlyingIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                { 
                    return IsSetEncodedUnderlyingIssuerLen();
                }
                
                public bool IsSetEncodedUnderlyingIssuerLen() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingIssuerLen);
                }
                public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    this.EncodedUnderlyingIssuer = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                { 
                    return IsSetEncodedUnderlyingIssuer();
                }
                
                public bool IsSetEncodedUnderlyingIssuer() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingIssuer);
                }
                public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    this.UnderlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
                { 
                    return IsSetUnderlyingSecurityDesc();
                }
                
                public bool IsSetUnderlyingSecurityDesc() 
                { 
                    return IsSetField(Tags.UnderlyingSecurityDesc);
                }
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    this.EncodedUnderlyingSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDescLen();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDescLen() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingSecurityDescLen);
                }
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    this.EncodedUnderlyingSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                { 
                    return IsSetEncodedUnderlyingSecurityDesc();
                }
                
                public bool IsSetEncodedUnderlyingSecurityDesc() 
                { 
                    return IsSetField(Tags.EncodedUnderlyingSecurityDesc);
                }
                public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    this.UnderlyingCPProgram = val;
                }
                
                public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) 
                { 
                    return IsSetUnderlyingCPProgram();
                }
                
                public bool IsSetUnderlyingCPProgram() 
                { 
                    return IsSetField(Tags.UnderlyingCPProgram);
                }
                public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    this.UnderlyingCPRegType = val;
                }
                
                public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) 
                { 
                    return IsSetUnderlyingCPRegType();
                }
                
                public bool IsSetUnderlyingCPRegType() 
                { 
                    return IsSetField(Tags.UnderlyingCPRegType);
                }
                public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    this.UnderlyingCurrency = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
                { 
                    return IsSetUnderlyingCurrency();
                }
                
                public bool IsSetUnderlyingCurrency() 
                { 
                    return IsSetField(Tags.UnderlyingCurrency);
                }
                public QuickFix.Fields.UnderlyingQty UnderlyingQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingQty val) 
                { 
                    this.UnderlyingQty = val;
                }
                
                public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingQty val) 
                { 
                    return IsSetUnderlyingQty();
                }
                
                public bool IsSetUnderlyingQty() 
                { 
                    return IsSetField(Tags.UnderlyingQty);
                }
                public QuickFix.Fields.UnderlyingPx UnderlyingPx
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPx val) 
                { 
                    this.UnderlyingPx = val;
                }
                
                public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPx val) 
                { 
                    return IsSetUnderlyingPx();
                }
                
                public bool IsSetUnderlyingPx() 
                { 
                    return IsSetField(Tags.UnderlyingPx);
                }
                public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    this.UnderlyingDirtyPrice = val;
                }
                
                public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
                { 
                    return IsSetUnderlyingDirtyPrice();
                }
                
                public bool IsSetUnderlyingDirtyPrice() 
                { 
                    return IsSetField(Tags.UnderlyingDirtyPrice);
                }
                public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    this.UnderlyingEndPrice = val;
                }
                
                public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) 
                { 
                    return IsSetUnderlyingEndPrice();
                }
                
                public bool IsSetUnderlyingEndPrice() 
                { 
                    return IsSetField(Tags.UnderlyingEndPrice);
                }
                public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    this.UnderlyingStartValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) 
                { 
                    return IsSetUnderlyingStartValue();
                }
                
                public bool IsSetUnderlyingStartValue() 
                { 
                    return IsSetField(Tags.UnderlyingStartValue);
                }
                public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    this.UnderlyingCurrentValue = val;
                }
                
                public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) 
                { 
                    return IsSetUnderlyingCurrentValue();
                }
                
                public bool IsSetUnderlyingCurrentValue() 
                { 
                    return IsSetField(Tags.UnderlyingCurrentValue);
                }
                public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    this.UnderlyingEndValue = val;
                }
                
                public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) 
                { 
                    return IsSetUnderlyingEndValue();
                }
                
                public bool IsSetUnderlyingEndValue() 
                { 
                    return IsSetField(Tags.UnderlyingEndValue);
                }
                public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    this.NoUnderlyingStips = val;
                }
                
                public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) 
                { 
                    return IsSetNoUnderlyingStips();
                }
                
                public bool IsSetNoUnderlyingStips() 
                { 
                    return IsSetField(Tags.NoUnderlyingStips);
                }
                public QuickFix.Fields.UnderlyingAllocationPercent UnderlyingAllocationPercent
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) 
                { 
                    this.UnderlyingAllocationPercent = val;
                }
                
                public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
                { 
                    return IsSetUnderlyingAllocationPercent();
                }
                
                public bool IsSetUnderlyingAllocationPercent() 
                { 
                    return IsSetField(Tags.UnderlyingAllocationPercent);
                }
                public QuickFix.Fields.UnderlyingSettlementType UnderlyingSettlementType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSettlementType val) 
                { 
                    this.UnderlyingSettlementType = val;
                }
                
                public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) 
                { 
                    return IsSetUnderlyingSettlementType();
                }
                
                public bool IsSetUnderlyingSettlementType() 
                { 
                    return IsSetField(Tags.UnderlyingSettlementType);
                }
                public QuickFix.Fields.UnderlyingCashAmount UnderlyingCashAmount
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCashAmount val) 
                { 
                    this.UnderlyingCashAmount = val;
                }
                
                public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) 
                { 
                    return IsSetUnderlyingCashAmount();
                }
                
                public bool IsSetUnderlyingCashAmount() 
                { 
                    return IsSetField(Tags.UnderlyingCashAmount);
                }
                public QuickFix.Fields.UnderlyingCashType UnderlyingCashType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCashType val) 
                { 
                    this.UnderlyingCashType = val;
                }
                
                public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCashType val) 
                { 
                    return IsSetUnderlyingCashType();
                }
                
                public bool IsSetUnderlyingCashType() 
                { 
                    return IsSetField(Tags.UnderlyingCashType);
                }
                public QuickFix.Fields.UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    this.UnderlyingUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                { 
                    return IsSetUnderlyingUnitOfMeasure();
                }
                
                public bool IsSetUnderlyingUnitOfMeasure() 
                { 
                    return IsSetField(Tags.UnderlyingUnitOfMeasure);
                }
                public QuickFix.Fields.UnderlyingTimeUnit UnderlyingTimeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingTimeUnit val) 
                { 
                    this.UnderlyingTimeUnit = val;
                }
                
                public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) 
                { 
                    return IsSetUnderlyingTimeUnit();
                }
                
                public bool IsSetUnderlyingTimeUnit() 
                { 
                    return IsSetField(Tags.UnderlyingTimeUnit);
                }
                public QuickFix.Fields.UnderlyingCapValue UnderlyingCapValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingCapValue val) 
                { 
                    this.UnderlyingCapValue = val;
                }
                
                public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) 
                { 
                    return IsSetUnderlyingCapValue();
                }
                
                public bool IsSetUnderlyingCapValue() 
                { 
                    return IsSetField(Tags.UnderlyingCapValue);
                }
                public QuickFix.Fields.NoUndlyInstrumentParties NoUndlyInstrumentParties
                { 
                    get 
                    {
                        QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) 
                { 
                    this.NoUndlyInstrumentParties = val;
                }
                
                public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
                { 
                    return IsSetNoUndlyInstrumentParties();
                }
                
                public bool IsSetNoUndlyInstrumentParties() 
                { 
                    return IsSetField(Tags.NoUndlyInstrumentParties);
                }
                public QuickFix.Fields.UnderlyingSettlMethod UnderlyingSettlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    this.UnderlyingSettlMethod = val;
                }
                
                public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                { 
                    return IsSetUnderlyingSettlMethod();
                }
                
                public bool IsSetUnderlyingSettlMethod() 
                { 
                    return IsSetField(Tags.UnderlyingSettlMethod);
                }
                public QuickFix.Fields.UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                { 
                    this.UnderlyingAdjustedQuantity = val;
                }
                
                public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                { 
                    return IsSetUnderlyingAdjustedQuantity();
                }
                
                public bool IsSetUnderlyingAdjustedQuantity() 
                { 
                    return IsSetField(Tags.UnderlyingAdjustedQuantity);
                }
                public QuickFix.Fields.UnderlyingFXRate UnderlyingFXRate
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingFXRate val) 
                { 
                    this.UnderlyingFXRate = val;
                }
                
                public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) 
                { 
                    return IsSetUnderlyingFXRate();
                }
                
                public bool IsSetUnderlyingFXRate() 
                { 
                    return IsSetField(Tags.UnderlyingFXRate);
                }
                public QuickFix.Fields.UnderlyingFXRateCalc UnderlyingFXRateCalc
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) 
                { 
                    this.UnderlyingFXRateCalc = val;
                }
                
                public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
                { 
                    return IsSetUnderlyingFXRateCalc();
                }
                
                public bool IsSetUnderlyingFXRateCalc() 
                { 
                    return IsSetField(Tags.UnderlyingFXRateCalc);
                }
                public QuickFix.Fields.UnderlyingMaturityTime UnderlyingMaturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingMaturityTime val) 
                { 
                    this.UnderlyingMaturityTime = val;
                }
                
                public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) 
                { 
                    return IsSetUnderlyingMaturityTime();
                }
                
                public bool IsSetUnderlyingMaturityTime() 
                { 
                    return IsSetField(Tags.UnderlyingMaturityTime);
                }
                public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    this.UnderlyingPutOrCall = val;
                }
                
                public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) 
                { 
                    return IsSetUnderlyingPutOrCall();
                }
                
                public bool IsSetUnderlyingPutOrCall() 
                { 
                    return IsSetField(Tags.UnderlyingPutOrCall);
                }
                public QuickFix.Fields.UnderlyingExerciseStyle UnderlyingExerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) 
                { 
                    this.UnderlyingExerciseStyle = val;
                }
                
                public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
                { 
                    return IsSetUnderlyingExerciseStyle();
                }
                
                public bool IsSetUnderlyingExerciseStyle() 
                { 
                    return IsSetField(Tags.UnderlyingExerciseStyle);
                }
                public QuickFix.Fields.UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                { 
                    this.UnderlyingUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                { 
                    return IsSetUnderlyingUnitOfMeasureQty();
                }
                
                public bool IsSetUnderlyingUnitOfMeasureQty() 
                { 
                    return IsSetField(Tags.UnderlyingUnitOfMeasureQty);
                }
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                { 
                    this.UnderlyingPriceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                { 
                    return IsSetUnderlyingPriceUnitOfMeasure();
                }
                
                public bool IsSetUnderlyingPriceUnitOfMeasure() 
                { 
                    return IsSetField(Tags.UnderlyingPriceUnitOfMeasure);
                }
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                { 
                    this.UnderlyingPriceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                { 
                    return IsSetUnderlyingPriceUnitOfMeasureQty();
                }
                
                public bool IsSetUnderlyingPriceUnitOfMeasureQty() 
                { 
                    return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
                }
                public QuickFix.Fields.UnderlyingContractMultiplierUnit UnderlyingContractMultiplierUnit
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingContractMultiplierUnit val = new QuickFix.Fields.UnderlyingContractMultiplierUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                { 
                    this.UnderlyingContractMultiplierUnit = val;
                }
                
                public QuickFix.Fields.UnderlyingContractMultiplierUnit Get(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                { 
                    return IsSetUnderlyingContractMultiplierUnit();
                }
                
                public bool IsSetUnderlyingContractMultiplierUnit() 
                { 
                    return IsSetField(Tags.UnderlyingContractMultiplierUnit);
                }
                public QuickFix.Fields.UnderlyingFlowScheduleType UnderlyingFlowScheduleType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingFlowScheduleType val = new QuickFix.Fields.UnderlyingFlowScheduleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                { 
                    this.UnderlyingFlowScheduleType = val;
                }
                
                public QuickFix.Fields.UnderlyingFlowScheduleType Get(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                { 
                    return IsSetUnderlyingFlowScheduleType();
                }
                
                public bool IsSetUnderlyingFlowScheduleType() 
                { 
                    return IsSetField(Tags.UnderlyingFlowScheduleType);
                }
                public QuickFix.Fields.UnderlyingRestructuringType UnderlyingRestructuringType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingRestructuringType val = new QuickFix.Fields.UnderlyingRestructuringType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingRestructuringType val) 
                { 
                    this.UnderlyingRestructuringType = val;
                }
                
                public QuickFix.Fields.UnderlyingRestructuringType Get(QuickFix.Fields.UnderlyingRestructuringType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingRestructuringType val) 
                { 
                    return IsSetUnderlyingRestructuringType();
                }
                
                public bool IsSetUnderlyingRestructuringType() 
                { 
                    return IsSetField(Tags.UnderlyingRestructuringType);
                }
                public QuickFix.Fields.UnderlyingSeniority UnderlyingSeniority
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSeniority val = new QuickFix.Fields.UnderlyingSeniority();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingSeniority val) 
                { 
                    this.UnderlyingSeniority = val;
                }
                
                public QuickFix.Fields.UnderlyingSeniority Get(QuickFix.Fields.UnderlyingSeniority val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingSeniority val) 
                { 
                    return IsSetUnderlyingSeniority();
                }
                
                public bool IsSetUnderlyingSeniority() 
                { 
                    return IsSetField(Tags.UnderlyingSeniority);
                }
                public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding UnderlyingNotionalPercentageOutstanding
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingNotionalPercentageOutstanding();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                { 
                    this.UnderlyingNotionalPercentageOutstanding = val;
                }
                
                public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                { 
                    return IsSetUnderlyingNotionalPercentageOutstanding();
                }
                
                public bool IsSetUnderlyingNotionalPercentageOutstanding() 
                { 
                    return IsSetField(Tags.UnderlyingNotionalPercentageOutstanding);
                }
                public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding UnderlyingOriginalNotionalPercentageOutstanding
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                { 
                    this.UnderlyingOriginalNotionalPercentageOutstanding = val;
                }
                
                public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                { 
                    return IsSetUnderlyingOriginalNotionalPercentageOutstanding();
                }
                
                public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() 
                { 
                    return IsSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding);
                }
                public QuickFix.Fields.UnderlyingAttachmentPoint UnderlyingAttachmentPoint
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingAttachmentPoint val = new QuickFix.Fields.UnderlyingAttachmentPoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                { 
                    this.UnderlyingAttachmentPoint = val;
                }
                
                public QuickFix.Fields.UnderlyingAttachmentPoint Get(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                { 
                    return IsSetUnderlyingAttachmentPoint();
                }
                
                public bool IsSetUnderlyingAttachmentPoint() 
                { 
                    return IsSetField(Tags.UnderlyingAttachmentPoint);
                }
                public QuickFix.Fields.UnderlyingDetachmentPoint UnderlyingDetachmentPoint
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingDetachmentPoint val = new QuickFix.Fields.UnderlyingDetachmentPoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                { 
                    this.UnderlyingDetachmentPoint = val;
                }
                
                public QuickFix.Fields.UnderlyingDetachmentPoint Get(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                { 
                    return IsSetUnderlyingDetachmentPoint();
                }
                
                public bool IsSetUnderlyingDetachmentPoint() 
                { 
                    return IsSetField(Tags.UnderlyingDetachmentPoint);
                }
                            public class NoUnderlyingSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                
                    public NoUnderlyingSecurityAltIDGroup() 
                      :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        this.UnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                    { 
                        return IsSetUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityAltID);
                    }
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        this.UnderlyingSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityAltIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityAltIDSource() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                    }
                
                }
                public class NoUnderlyingStipsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                
                    public NoUnderlyingStipsGroup() 
                      :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUnderlyingStipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        this.UnderlyingStipType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStipType val) 
                    { 
                        return IsSetUnderlyingStipType();
                    }
                    
                    public bool IsSetUnderlyingStipType() 
                    { 
                        return IsSetField(Tags.UnderlyingStipType);
                    }
                    public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        this.UnderlyingStipValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) 
                    { 
                        return IsSetUnderlyingStipValue();
                    }
                    
                    public bool IsSetUnderlyingStipValue() 
                    { 
                        return IsSetField(Tags.UnderlyingStipValue);
                    }
                
                }
                public class NoUndlyInstrumentPartiesGroup : Group
                {
                    public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                
                    public NoUndlyInstrumentPartiesGroup() 
                      :base( Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoUndlyInstrumentPartiesGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.UnderlyingInstrumentPartyID UnderlyingInstrumentPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrumentPartyID val = new QuickFix.Fields.UnderlyingInstrumentPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                    { 
                        this.UnderlyingInstrumentPartyID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrumentPartyID Get(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                    { 
                        return IsSetUnderlyingInstrumentPartyID();
                    }
                    
                    public bool IsSetUnderlyingInstrumentPartyID() 
                    { 
                        return IsSetField(Tags.UnderlyingInstrumentPartyID);
                    }
                    public QuickFix.Fields.UnderlyingInstrumentPartyIDSource UnderlyingInstrumentPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrumentPartyIDSource val = new QuickFix.Fields.UnderlyingInstrumentPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                    { 
                        this.UnderlyingInstrumentPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrumentPartyIDSource Get(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                    { 
                        return IsSetUnderlyingInstrumentPartyIDSource();
                    }
                    
                    public bool IsSetUnderlyingInstrumentPartyIDSource() 
                    { 
                        return IsSetField(Tags.UnderlyingInstrumentPartyIDSource);
                    }
                    public QuickFix.Fields.UnderlyingInstrumentPartyRole UnderlyingInstrumentPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrumentPartyRole val = new QuickFix.Fields.UnderlyingInstrumentPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                    { 
                        this.UnderlyingInstrumentPartyRole = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrumentPartyRole Get(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                    { 
                        return IsSetUnderlyingInstrumentPartyRole();
                    }
                    
                    public bool IsSetUnderlyingInstrumentPartyRole() 
                    { 
                        return IsSetField(Tags.UnderlyingInstrumentPartyRole);
                    }
                    public QuickFix.Fields.NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                    { 
                        this.NoUndlyInstrumentPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                    { 
                        return IsSetNoUndlyInstrumentPartySubIDs();
                    }
                    
                    public bool IsSetNoUndlyInstrumentPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoUndlyInstrumentPartySubIDs);
                    }
                                    public class NoUndlyInstrumentPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};
                    
                        public NoUndlyInstrumentPartySubIDsGroup() 
                          :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoUndlyInstrumentPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.UnderlyingInstrumentPartySubID UnderlyingInstrumentPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartySubID val = new QuickFix.Fields.UnderlyingInstrumentPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                        { 
                            this.UnderlyingInstrumentPartySubID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartySubID Get(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                        { 
                            return IsSetUnderlyingInstrumentPartySubID();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartySubID() 
                        { 
                            return IsSetField(Tags.UnderlyingInstrumentPartySubID);
                        }
                        public QuickFix.Fields.UnderlyingInstrumentPartySubIDType UnderlyingInstrumentPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartySubIDType val = new QuickFix.Fields.UnderlyingInstrumentPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                        { 
                            this.UnderlyingInstrumentPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartySubIDType Get(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                        { 
                            return IsSetUnderlyingInstrumentPartySubIDType();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartySubIDType() 
                        { 
                            return IsSetField(Tags.UnderlyingInstrumentPartySubIDType);
                        }
                    
                    }
                }
            }
            public class NoStipulationsGroup : Group
            {
                public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};
            
                public NoStipulationsGroup() 
                  :base( Tags.NoStipulations, Tags.StipulationType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStipulationsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.StipulationType StipulationType
                { 
                    get 
                    {
                        QuickFix.Fields.StipulationType val = new QuickFix.Fields.StipulationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StipulationType val) 
                { 
                    this.StipulationType = val;
                }
                
                public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StipulationType val) 
                { 
                    return IsSetStipulationType();
                }
                
                public bool IsSetStipulationType() 
                { 
                    return IsSetField(Tags.StipulationType);
                }
                public QuickFix.Fields.StipulationValue StipulationValue
                { 
                    get 
                    {
                        QuickFix.Fields.StipulationValue val = new QuickFix.Fields.StipulationValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StipulationValue val) 
                { 
                    this.StipulationValue = val;
                }
                
                public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StipulationValue val) 
                { 
                    return IsSetStipulationValue();
                }
                
                public bool IsSetStipulationValue() 
                { 
                    return IsSetField(Tags.StipulationValue);
                }
            
            }
            public class NoContAmtsGroup : Group
            {
                public static int[] fieldOrder = {Tags.ContAmtType, Tags.ContAmtValue, Tags.ContAmtCurr, 0};
            
                public NoContAmtsGroup() 
                  :base( Tags.NoContAmts, Tags.ContAmtType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoContAmtsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.ContAmtType ContAmtType
                { 
                    get 
                    {
                        QuickFix.Fields.ContAmtType val = new QuickFix.Fields.ContAmtType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContAmtType val) 
                { 
                    this.ContAmtType = val;
                }
                
                public QuickFix.Fields.ContAmtType Get(QuickFix.Fields.ContAmtType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContAmtType val) 
                { 
                    return IsSetContAmtType();
                }
                
                public bool IsSetContAmtType() 
                { 
                    return IsSetField(Tags.ContAmtType);
                }
                public QuickFix.Fields.ContAmtValue ContAmtValue
                { 
                    get 
                    {
                        QuickFix.Fields.ContAmtValue val = new QuickFix.Fields.ContAmtValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContAmtValue val) 
                { 
                    this.ContAmtValue = val;
                }
                
                public QuickFix.Fields.ContAmtValue Get(QuickFix.Fields.ContAmtValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContAmtValue val) 
                { 
                    return IsSetContAmtValue();
                }
                
                public bool IsSetContAmtValue() 
                { 
                    return IsSetField(Tags.ContAmtValue);
                }
                public QuickFix.Fields.ContAmtCurr ContAmtCurr
                { 
                    get 
                    {
                        QuickFix.Fields.ContAmtCurr val = new QuickFix.Fields.ContAmtCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContAmtCurr val) 
                { 
                    this.ContAmtCurr = val;
                }
                
                public QuickFix.Fields.ContAmtCurr Get(QuickFix.Fields.ContAmtCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContAmtCurr val) 
                { 
                    return IsSetContAmtCurr();
                }
                
                public bool IsSetContAmtCurr() 
                { 
                    return IsSetField(Tags.ContAmtCurr);
                }
            
            }
            public class NoLegsGroup : Group
            {
                public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegQty, Tags.LegSwapType, Tags.NoLegStipulations, Tags.LegPositionEffect, Tags.LegCoveredOrUncovered, Tags.LegRefID, Tags.LegSettlType, Tags.LegSettlDate, Tags.LegLastPx, Tags.LegOrderQty, Tags.LegSettlCurrency, Tags.LegLastForwardPoints, Tags.LegCalculatedCcyLastQty, Tags.LegGrossTradeAmt, Tags.NoNested3PartyIDs, Tags.LegAllocID, Tags.NoLegAllocs, Tags.LegVolatility, Tags.LegDividendYield, Tags.LegCurrencyRatio, Tags.LegExecInst, Tags.LegLastQty, 0};
            
                public NoLegsGroup() 
                  :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoLegsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.LegSymbol LegSymbol
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbol val) 
                { 
                    this.LegSymbol = val;
                }
                
                public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbol val) 
                { 
                    return IsSetLegSymbol();
                }
                
                public bool IsSetLegSymbol() 
                { 
                    return IsSetField(Tags.LegSymbol);
                }
                public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    this.LegSymbolSfx = val;
                }
                
                public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                { 
                    return IsSetLegSymbolSfx();
                }
                
                public bool IsSetLegSymbolSfx() 
                { 
                    return IsSetField(Tags.LegSymbolSfx);
                }
                public QuickFix.Fields.LegSecurityID LegSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityID val) 
                { 
                    this.LegSecurityID = val;
                }
                
                public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                { 
                    return IsSetLegSecurityID();
                }
                
                public bool IsSetLegSecurityID() 
                { 
                    return IsSetField(Tags.LegSecurityID);
                }
                public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    this.LegSecurityIDSource = val;
                }
                
                public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                { 
                    return IsSetLegSecurityIDSource();
                }
                
                public bool IsSetLegSecurityIDSource() 
                { 
                    return IsSetField(Tags.LegSecurityIDSource);
                }
                public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    this.NoLegSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                { 
                    return IsSetNoLegSecurityAltID();
                }
                
                public bool IsSetNoLegSecurityAltID() 
                { 
                    return IsSetField(Tags.NoLegSecurityAltID);
                }
                public QuickFix.Fields.LegProduct LegProduct
                { 
                    get 
                    {
                        QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegProduct val) 
                { 
                    this.LegProduct = val;
                }
                
                public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegProduct val) 
                { 
                    return IsSetLegProduct();
                }
                
                public bool IsSetLegProduct() 
                { 
                    return IsSetField(Tags.LegProduct);
                }
                public QuickFix.Fields.LegCFICode LegCFICode
                { 
                    get 
                    {
                        QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCFICode val) 
                { 
                    this.LegCFICode = val;
                }
                
                public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCFICode val) 
                { 
                    return IsSetLegCFICode();
                }
                
                public bool IsSetLegCFICode() 
                { 
                    return IsSetField(Tags.LegCFICode);
                }
                public QuickFix.Fields.LegSecurityType LegSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityType val) 
                { 
                    this.LegSecurityType = val;
                }
                
                public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                { 
                    return IsSetLegSecurityType();
                }
                
                public bool IsSetLegSecurityType() 
                { 
                    return IsSetField(Tags.LegSecurityType);
                }
                public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    this.LegSecuritySubType = val;
                }
                
                public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                { 
                    return IsSetLegSecuritySubType();
                }
                
                public bool IsSetLegSecuritySubType() 
                { 
                    return IsSetField(Tags.LegSecuritySubType);
                }
                public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    this.LegMaturityMonthYear = val;
                }
                
                public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                { 
                    return IsSetLegMaturityMonthYear();
                }
                
                public bool IsSetLegMaturityMonthYear() 
                { 
                    return IsSetField(Tags.LegMaturityMonthYear);
                }
                public QuickFix.Fields.LegMaturityDate LegMaturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityDate val) 
                { 
                    this.LegMaturityDate = val;
                }
                
                public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                { 
                    return IsSetLegMaturityDate();
                }
                
                public bool IsSetLegMaturityDate() 
                { 
                    return IsSetField(Tags.LegMaturityDate);
                }
                public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    this.LegCouponPaymentDate = val;
                }
                
                public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                { 
                    return IsSetLegCouponPaymentDate();
                }
                
                public bool IsSetLegCouponPaymentDate() 
                { 
                    return IsSetField(Tags.LegCouponPaymentDate);
                }
                public QuickFix.Fields.LegIssueDate LegIssueDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssueDate val) 
                { 
                    this.LegIssueDate = val;
                }
                
                public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                { 
                    return IsSetLegIssueDate();
                }
                
                public bool IsSetLegIssueDate() 
                { 
                    return IsSetField(Tags.LegIssueDate);
                }
                public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    this.LegRepoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                { 
                    return IsSetLegRepoCollateralSecurityType();
                }
                
                public bool IsSetLegRepoCollateralSecurityType() 
                { 
                    return IsSetField(Tags.LegRepoCollateralSecurityType);
                }
                public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    this.LegRepurchaseTerm = val;
                }
                
                public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                { 
                    return IsSetLegRepurchaseTerm();
                }
                
                public bool IsSetLegRepurchaseTerm() 
                { 
                    return IsSetField(Tags.LegRepurchaseTerm);
                }
                public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    this.LegRepurchaseRate = val;
                }
                
                public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                { 
                    return IsSetLegRepurchaseRate();
                }
                
                public bool IsSetLegRepurchaseRate() 
                { 
                    return IsSetField(Tags.LegRepurchaseRate);
                }
                public QuickFix.Fields.LegFactor LegFactor
                { 
                    get 
                    {
                        QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegFactor val) 
                { 
                    this.LegFactor = val;
                }
                
                public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegFactor val) 
                { 
                    return IsSetLegFactor();
                }
                
                public bool IsSetLegFactor() 
                { 
                    return IsSetField(Tags.LegFactor);
                }
                public QuickFix.Fields.LegCreditRating LegCreditRating
                { 
                    get 
                    {
                        QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCreditRating val) 
                { 
                    this.LegCreditRating = val;
                }
                
                public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                { 
                    return IsSetLegCreditRating();
                }
                
                public bool IsSetLegCreditRating() 
                { 
                    return IsSetField(Tags.LegCreditRating);
                }
                public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    this.LegInstrRegistry = val;
                }
                
                public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                { 
                    return IsSetLegInstrRegistry();
                }
                
                public bool IsSetLegInstrRegistry() 
                { 
                    return IsSetField(Tags.LegInstrRegistry);
                }
                public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    this.LegCountryOfIssue = val;
                }
                
                public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                { 
                    return IsSetLegCountryOfIssue();
                }
                
                public bool IsSetLegCountryOfIssue() 
                { 
                    return IsSetField(Tags.LegCountryOfIssue);
                }
                public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    this.LegStateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                { 
                    return IsSetLegStateOrProvinceOfIssue();
                }
                
                public bool IsSetLegStateOrProvinceOfIssue() 
                { 
                    return IsSetField(Tags.LegStateOrProvinceOfIssue);
                }
                public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    this.LegLocaleOfIssue = val;
                }
                
                public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                { 
                    return IsSetLegLocaleOfIssue();
                }
                
                public bool IsSetLegLocaleOfIssue() 
                { 
                    return IsSetField(Tags.LegLocaleOfIssue);
                }
                public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    this.LegRedemptionDate = val;
                }
                
                public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                { 
                    return IsSetLegRedemptionDate();
                }
                
                public bool IsSetLegRedemptionDate() 
                { 
                    return IsSetField(Tags.LegRedemptionDate);
                }
                public QuickFix.Fields.LegStrikePrice LegStrikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikePrice val) 
                { 
                    this.LegStrikePrice = val;
                }
                
                public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                { 
                    return IsSetLegStrikePrice();
                }
                
                public bool IsSetLegStrikePrice() 
                { 
                    return IsSetField(Tags.LegStrikePrice);
                }
                public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    this.LegStrikeCurrency = val;
                }
                
                public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                { 
                    return IsSetLegStrikeCurrency();
                }
                
                public bool IsSetLegStrikeCurrency() 
                { 
                    return IsSetField(Tags.LegStrikeCurrency);
                }
                public QuickFix.Fields.LegOptAttribute LegOptAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptAttribute val) 
                { 
                    this.LegOptAttribute = val;
                }
                
                public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                { 
                    return IsSetLegOptAttribute();
                }
                
                public bool IsSetLegOptAttribute() 
                { 
                    return IsSetField(Tags.LegOptAttribute);
                }
                public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    this.LegContractMultiplier = val;
                }
                
                public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                { 
                    return IsSetLegContractMultiplier();
                }
                
                public bool IsSetLegContractMultiplier() 
                { 
                    return IsSetField(Tags.LegContractMultiplier);
                }
                public QuickFix.Fields.LegCouponRate LegCouponRate
                { 
                    get 
                    {
                        QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCouponRate val) 
                { 
                    this.LegCouponRate = val;
                }
                
                public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                { 
                    return IsSetLegCouponRate();
                }
                
                public bool IsSetLegCouponRate() 
                { 
                    return IsSetField(Tags.LegCouponRate);
                }
                public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    this.LegSecurityExchange = val;
                }
                
                public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                { 
                    return IsSetLegSecurityExchange();
                }
                
                public bool IsSetLegSecurityExchange() 
                { 
                    return IsSetField(Tags.LegSecurityExchange);
                }
                public QuickFix.Fields.LegIssuer LegIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegIssuer val) 
                { 
                    this.LegIssuer = val;
                }
                
                public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegIssuer val) 
                { 
                    return IsSetLegIssuer();
                }
                
                public bool IsSetLegIssuer() 
                { 
                    return IsSetField(Tags.LegIssuer);
                }
                public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    this.EncodedLegIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                { 
                    return IsSetEncodedLegIssuerLen();
                }
                
                public bool IsSetEncodedLegIssuerLen() 
                { 
                    return IsSetField(Tags.EncodedLegIssuerLen);
                }
                public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    this.EncodedLegIssuer = val;
                }
                
                public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                { 
                    return IsSetEncodedLegIssuer();
                }
                
                public bool IsSetEncodedLegIssuer() 
                { 
                    return IsSetField(Tags.EncodedLegIssuer);
                }
                public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    this.LegSecurityDesc = val;
                }
                
                public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                { 
                    return IsSetLegSecurityDesc();
                }
                
                public bool IsSetLegSecurityDesc() 
                { 
                    return IsSetField(Tags.LegSecurityDesc);
                }
                public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    this.EncodedLegSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                { 
                    return IsSetEncodedLegSecurityDescLen();
                }
                
                public bool IsSetEncodedLegSecurityDescLen() 
                { 
                    return IsSetField(Tags.EncodedLegSecurityDescLen);
                }
                public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    this.EncodedLegSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                { 
                    return IsSetEncodedLegSecurityDesc();
                }
                
                public bool IsSetEncodedLegSecurityDesc() 
                { 
                    return IsSetField(Tags.EncodedLegSecurityDesc);
                }
                public QuickFix.Fields.LegRatioQty LegRatioQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRatioQty val) 
                { 
                    this.LegRatioQty = val;
                }
                
                public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                { 
                    return IsSetLegRatioQty();
                }
                
                public bool IsSetLegRatioQty() 
                { 
                    return IsSetField(Tags.LegRatioQty);
                }
                public QuickFix.Fields.LegSide LegSide
                { 
                    get 
                    {
                        QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSide val) 
                { 
                    this.LegSide = val;
                }
                
                public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSide val) 
                { 
                    return IsSetLegSide();
                }
                
                public bool IsSetLegSide() 
                { 
                    return IsSetField(Tags.LegSide);
                }
                public QuickFix.Fields.LegCurrency LegCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCurrency val) 
                { 
                    this.LegCurrency = val;
                }
                
                public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCurrency val) 
                { 
                    return IsSetLegCurrency();
                }
                
                public bool IsSetLegCurrency() 
                { 
                    return IsSetField(Tags.LegCurrency);
                }
                public QuickFix.Fields.LegPool LegPool
                { 
                    get 
                    {
                        QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPool val) 
                { 
                    this.LegPool = val;
                }
                
                public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPool val) 
                { 
                    return IsSetLegPool();
                }
                
                public bool IsSetLegPool() 
                { 
                    return IsSetField(Tags.LegPool);
                }
                public QuickFix.Fields.LegDatedDate LegDatedDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegDatedDate val) 
                { 
                    this.LegDatedDate = val;
                }
                
                public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                { 
                    return IsSetLegDatedDate();
                }
                
                public bool IsSetLegDatedDate() 
                { 
                    return IsSetField(Tags.LegDatedDate);
                }
                public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    this.LegContractSettlMonth = val;
                }
                
                public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                { 
                    return IsSetLegContractSettlMonth();
                }
                
                public bool IsSetLegContractSettlMonth() 
                { 
                    return IsSetField(Tags.LegContractSettlMonth);
                }
                public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    this.LegInterestAccrualDate = val;
                }
                
                public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                { 
                    return IsSetLegInterestAccrualDate();
                }
                
                public bool IsSetLegInterestAccrualDate() 
                { 
                    return IsSetField(Tags.LegInterestAccrualDate);
                }
                public QuickFix.Fields.LegUnitOfMeasure LegUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegUnitOfMeasure val) 
                { 
                    this.LegUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val) 
                { 
                    return IsSetLegUnitOfMeasure();
                }
                
                public bool IsSetLegUnitOfMeasure() 
                { 
                    return IsSetField(Tags.LegUnitOfMeasure);
                }
                public QuickFix.Fields.LegTimeUnit LegTimeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegTimeUnit val) 
                { 
                    this.LegTimeUnit = val;
                }
                
                public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegTimeUnit val) 
                { 
                    return IsSetLegTimeUnit();
                }
                
                public bool IsSetLegTimeUnit() 
                { 
                    return IsSetField(Tags.LegTimeUnit);
                }
                public QuickFix.Fields.LegOptionRatio LegOptionRatio
                { 
                    get 
                    {
                        QuickFix.Fields.LegOptionRatio val = new QuickFix.Fields.LegOptionRatio();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOptionRatio val) 
                { 
                    this.LegOptionRatio = val;
                }
                
                public QuickFix.Fields.LegOptionRatio Get(QuickFix.Fields.LegOptionRatio val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOptionRatio val) 
                { 
                    return IsSetLegOptionRatio();
                }
                
                public bool IsSetLegOptionRatio() 
                { 
                    return IsSetField(Tags.LegOptionRatio);
                }
                public QuickFix.Fields.LegPrice LegPrice
                { 
                    get 
                    {
                        QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPrice val) 
                { 
                    this.LegPrice = val;
                }
                
                public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPrice val) 
                { 
                    return IsSetLegPrice();
                }
                
                public bool IsSetLegPrice() 
                { 
                    return IsSetField(Tags.LegPrice);
                }
                public QuickFix.Fields.LegMaturityTime LegMaturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.LegMaturityTime val = new QuickFix.Fields.LegMaturityTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegMaturityTime val) 
                { 
                    this.LegMaturityTime = val;
                }
                
                public QuickFix.Fields.LegMaturityTime Get(QuickFix.Fields.LegMaturityTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegMaturityTime val) 
                { 
                    return IsSetLegMaturityTime();
                }
                
                public bool IsSetLegMaturityTime() 
                { 
                    return IsSetField(Tags.LegMaturityTime);
                }
                public QuickFix.Fields.LegPutOrCall LegPutOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.LegPutOrCall val = new QuickFix.Fields.LegPutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPutOrCall val) 
                { 
                    this.LegPutOrCall = val;
                }
                
                public QuickFix.Fields.LegPutOrCall Get(QuickFix.Fields.LegPutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPutOrCall val) 
                { 
                    return IsSetLegPutOrCall();
                }
                
                public bool IsSetLegPutOrCall() 
                { 
                    return IsSetField(Tags.LegPutOrCall);
                }
                public QuickFix.Fields.LegExerciseStyle LegExerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.LegExerciseStyle val = new QuickFix.Fields.LegExerciseStyle();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegExerciseStyle val) 
                { 
                    this.LegExerciseStyle = val;
                }
                
                public QuickFix.Fields.LegExerciseStyle Get(QuickFix.Fields.LegExerciseStyle val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegExerciseStyle val) 
                { 
                    return IsSetLegExerciseStyle();
                }
                
                public bool IsSetLegExerciseStyle() 
                { 
                    return IsSetField(Tags.LegExerciseStyle);
                }
                public QuickFix.Fields.LegUnitOfMeasureQty LegUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegUnitOfMeasureQty val = new QuickFix.Fields.LegUnitOfMeasureQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                { 
                    this.LegUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.LegUnitOfMeasureQty Get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                { 
                    return IsSetLegUnitOfMeasureQty();
                }
                
                public bool IsSetLegUnitOfMeasureQty() 
                { 
                    return IsSetField(Tags.LegUnitOfMeasureQty);
                }
                public QuickFix.Fields.LegPriceUnitOfMeasure LegPriceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.LegPriceUnitOfMeasure val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                { 
                    this.LegPriceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.LegPriceUnitOfMeasure Get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                { 
                    return IsSetLegPriceUnitOfMeasure();
                }
                
                public bool IsSetLegPriceUnitOfMeasure() 
                { 
                    return IsSetField(Tags.LegPriceUnitOfMeasure);
                }
                public QuickFix.Fields.LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegPriceUnitOfMeasureQty val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                { 
                    this.LegPriceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.LegPriceUnitOfMeasureQty Get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                { 
                    return IsSetLegPriceUnitOfMeasureQty();
                }
                
                public bool IsSetLegPriceUnitOfMeasureQty() 
                { 
                    return IsSetField(Tags.LegPriceUnitOfMeasureQty);
                }
                public QuickFix.Fields.LegContractMultiplierUnit LegContractMultiplierUnit
                { 
                    get 
                    {
                        QuickFix.Fields.LegContractMultiplierUnit val = new QuickFix.Fields.LegContractMultiplierUnit();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegContractMultiplierUnit val) 
                { 
                    this.LegContractMultiplierUnit = val;
                }
                
                public QuickFix.Fields.LegContractMultiplierUnit Get(QuickFix.Fields.LegContractMultiplierUnit val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegContractMultiplierUnit val) 
                { 
                    return IsSetLegContractMultiplierUnit();
                }
                
                public bool IsSetLegContractMultiplierUnit() 
                { 
                    return IsSetField(Tags.LegContractMultiplierUnit);
                }
                public QuickFix.Fields.LegFlowScheduleType LegFlowScheduleType
                { 
                    get 
                    {
                        QuickFix.Fields.LegFlowScheduleType val = new QuickFix.Fields.LegFlowScheduleType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegFlowScheduleType val) 
                { 
                    this.LegFlowScheduleType = val;
                }
                
                public QuickFix.Fields.LegFlowScheduleType Get(QuickFix.Fields.LegFlowScheduleType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegFlowScheduleType val) 
                { 
                    return IsSetLegFlowScheduleType();
                }
                
                public bool IsSetLegFlowScheduleType() 
                { 
                    return IsSetField(Tags.LegFlowScheduleType);
                }
                public QuickFix.Fields.LegQty LegQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegQty val = new QuickFix.Fields.LegQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegQty val) 
                { 
                    this.LegQty = val;
                }
                
                public QuickFix.Fields.LegQty Get(QuickFix.Fields.LegQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegQty val) 
                { 
                    return IsSetLegQty();
                }
                
                public bool IsSetLegQty() 
                { 
                    return IsSetField(Tags.LegQty);
                }
                public QuickFix.Fields.LegSwapType LegSwapType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSwapType val = new QuickFix.Fields.LegSwapType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSwapType val) 
                { 
                    this.LegSwapType = val;
                }
                
                public QuickFix.Fields.LegSwapType Get(QuickFix.Fields.LegSwapType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSwapType val) 
                { 
                    return IsSetLegSwapType();
                }
                
                public bool IsSetLegSwapType() 
                { 
                    return IsSetField(Tags.LegSwapType);
                }
                public QuickFix.Fields.NoLegStipulations NoLegStipulations
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegStipulations val = new QuickFix.Fields.NoLegStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegStipulations val) 
                { 
                    this.NoLegStipulations = val;
                }
                
                public QuickFix.Fields.NoLegStipulations Get(QuickFix.Fields.NoLegStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegStipulations val) 
                { 
                    return IsSetNoLegStipulations();
                }
                
                public bool IsSetNoLegStipulations() 
                { 
                    return IsSetField(Tags.NoLegStipulations);
                }
                public QuickFix.Fields.LegPositionEffect LegPositionEffect
                { 
                    get 
                    {
                        QuickFix.Fields.LegPositionEffect val = new QuickFix.Fields.LegPositionEffect();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegPositionEffect val) 
                { 
                    this.LegPositionEffect = val;
                }
                
                public QuickFix.Fields.LegPositionEffect Get(QuickFix.Fields.LegPositionEffect val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegPositionEffect val) 
                { 
                    return IsSetLegPositionEffect();
                }
                
                public bool IsSetLegPositionEffect() 
                { 
                    return IsSetField(Tags.LegPositionEffect);
                }
                public QuickFix.Fields.LegCoveredOrUncovered LegCoveredOrUncovered
                { 
                    get 
                    {
                        QuickFix.Fields.LegCoveredOrUncovered val = new QuickFix.Fields.LegCoveredOrUncovered();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    this.LegCoveredOrUncovered = val;
                }
                
                public QuickFix.Fields.LegCoveredOrUncovered Get(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCoveredOrUncovered val) 
                { 
                    return IsSetLegCoveredOrUncovered();
                }
                
                public bool IsSetLegCoveredOrUncovered() 
                { 
                    return IsSetField(Tags.LegCoveredOrUncovered);
                }
                public QuickFix.Fields.LegRefID LegRefID
                { 
                    get 
                    {
                        QuickFix.Fields.LegRefID val = new QuickFix.Fields.LegRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegRefID val) 
                { 
                    this.LegRefID = val;
                }
                
                public QuickFix.Fields.LegRefID Get(QuickFix.Fields.LegRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegRefID val) 
                { 
                    return IsSetLegRefID();
                }
                
                public bool IsSetLegRefID() 
                { 
                    return IsSetField(Tags.LegRefID);
                }
                public QuickFix.Fields.LegSettlType LegSettlType
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlType val = new QuickFix.Fields.LegSettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSettlType val) 
                { 
                    this.LegSettlType = val;
                }
                
                public QuickFix.Fields.LegSettlType Get(QuickFix.Fields.LegSettlType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSettlType val) 
                { 
                    return IsSetLegSettlType();
                }
                
                public bool IsSetLegSettlType() 
                { 
                    return IsSetField(Tags.LegSettlType);
                }
                public QuickFix.Fields.LegSettlDate LegSettlDate
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlDate val = new QuickFix.Fields.LegSettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSettlDate val) 
                { 
                    this.LegSettlDate = val;
                }
                
                public QuickFix.Fields.LegSettlDate Get(QuickFix.Fields.LegSettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSettlDate val) 
                { 
                    return IsSetLegSettlDate();
                }
                
                public bool IsSetLegSettlDate() 
                { 
                    return IsSetField(Tags.LegSettlDate);
                }
                public QuickFix.Fields.LegLastPx LegLastPx
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastPx val = new QuickFix.Fields.LegLastPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLastPx val) 
                { 
                    this.LegLastPx = val;
                }
                
                public QuickFix.Fields.LegLastPx Get(QuickFix.Fields.LegLastPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLastPx val) 
                { 
                    return IsSetLegLastPx();
                }
                
                public bool IsSetLegLastPx() 
                { 
                    return IsSetField(Tags.LegLastPx);
                }
                public QuickFix.Fields.LegOrderQty LegOrderQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegOrderQty val = new QuickFix.Fields.LegOrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegOrderQty val) 
                { 
                    this.LegOrderQty = val;
                }
                
                public QuickFix.Fields.LegOrderQty Get(QuickFix.Fields.LegOrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegOrderQty val) 
                { 
                    return IsSetLegOrderQty();
                }
                
                public bool IsSetLegOrderQty() 
                { 
                    return IsSetField(Tags.LegOrderQty);
                }
                public QuickFix.Fields.LegSettlCurrency LegSettlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.LegSettlCurrency val = new QuickFix.Fields.LegSettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegSettlCurrency val) 
                { 
                    this.LegSettlCurrency = val;
                }
                
                public QuickFix.Fields.LegSettlCurrency Get(QuickFix.Fields.LegSettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegSettlCurrency val) 
                { 
                    return IsSetLegSettlCurrency();
                }
                
                public bool IsSetLegSettlCurrency() 
                { 
                    return IsSetField(Tags.LegSettlCurrency);
                }
                public QuickFix.Fields.LegLastForwardPoints LegLastForwardPoints
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastForwardPoints val = new QuickFix.Fields.LegLastForwardPoints();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLastForwardPoints val) 
                { 
                    this.LegLastForwardPoints = val;
                }
                
                public QuickFix.Fields.LegLastForwardPoints Get(QuickFix.Fields.LegLastForwardPoints val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLastForwardPoints val) 
                { 
                    return IsSetLegLastForwardPoints();
                }
                
                public bool IsSetLegLastForwardPoints() 
                { 
                    return IsSetField(Tags.LegLastForwardPoints);
                }
                public QuickFix.Fields.LegCalculatedCcyLastQty LegCalculatedCcyLastQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegCalculatedCcyLastQty val = new QuickFix.Fields.LegCalculatedCcyLastQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCalculatedCcyLastQty val) 
                { 
                    this.LegCalculatedCcyLastQty = val;
                }
                
                public QuickFix.Fields.LegCalculatedCcyLastQty Get(QuickFix.Fields.LegCalculatedCcyLastQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCalculatedCcyLastQty val) 
                { 
                    return IsSetLegCalculatedCcyLastQty();
                }
                
                public bool IsSetLegCalculatedCcyLastQty() 
                { 
                    return IsSetField(Tags.LegCalculatedCcyLastQty);
                }
                public QuickFix.Fields.LegGrossTradeAmt LegGrossTradeAmt
                { 
                    get 
                    {
                        QuickFix.Fields.LegGrossTradeAmt val = new QuickFix.Fields.LegGrossTradeAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegGrossTradeAmt val) 
                { 
                    this.LegGrossTradeAmt = val;
                }
                
                public QuickFix.Fields.LegGrossTradeAmt Get(QuickFix.Fields.LegGrossTradeAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegGrossTradeAmt val) 
                { 
                    return IsSetLegGrossTradeAmt();
                }
                
                public bool IsSetLegGrossTradeAmt() 
                { 
                    return IsSetField(Tags.LegGrossTradeAmt);
                }
                public QuickFix.Fields.NoNested3PartyIDs NoNested3PartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNested3PartyIDs val = new QuickFix.Fields.NoNested3PartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNested3PartyIDs val) 
                { 
                    this.NoNested3PartyIDs = val;
                }
                
                public QuickFix.Fields.NoNested3PartyIDs Get(QuickFix.Fields.NoNested3PartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNested3PartyIDs val) 
                { 
                    return IsSetNoNested3PartyIDs();
                }
                
                public bool IsSetNoNested3PartyIDs() 
                { 
                    return IsSetField(Tags.NoNested3PartyIDs);
                }
                public QuickFix.Fields.LegAllocID LegAllocID
                { 
                    get 
                    {
                        QuickFix.Fields.LegAllocID val = new QuickFix.Fields.LegAllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegAllocID val) 
                { 
                    this.LegAllocID = val;
                }
                
                public QuickFix.Fields.LegAllocID Get(QuickFix.Fields.LegAllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegAllocID val) 
                { 
                    return IsSetLegAllocID();
                }
                
                public bool IsSetLegAllocID() 
                { 
                    return IsSetField(Tags.LegAllocID);
                }
                public QuickFix.Fields.NoLegAllocs NoLegAllocs
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegAllocs val = new QuickFix.Fields.NoLegAllocs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegAllocs val) 
                { 
                    this.NoLegAllocs = val;
                }
                
                public QuickFix.Fields.NoLegAllocs Get(QuickFix.Fields.NoLegAllocs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegAllocs val) 
                { 
                    return IsSetNoLegAllocs();
                }
                
                public bool IsSetNoLegAllocs() 
                { 
                    return IsSetField(Tags.NoLegAllocs);
                }
                public QuickFix.Fields.LegVolatility LegVolatility
                { 
                    get 
                    {
                        QuickFix.Fields.LegVolatility val = new QuickFix.Fields.LegVolatility();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegVolatility val) 
                { 
                    this.LegVolatility = val;
                }
                
                public QuickFix.Fields.LegVolatility Get(QuickFix.Fields.LegVolatility val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegVolatility val) 
                { 
                    return IsSetLegVolatility();
                }
                
                public bool IsSetLegVolatility() 
                { 
                    return IsSetField(Tags.LegVolatility);
                }
                public QuickFix.Fields.LegDividendYield LegDividendYield
                { 
                    get 
                    {
                        QuickFix.Fields.LegDividendYield val = new QuickFix.Fields.LegDividendYield();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegDividendYield val) 
                { 
                    this.LegDividendYield = val;
                }
                
                public QuickFix.Fields.LegDividendYield Get(QuickFix.Fields.LegDividendYield val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegDividendYield val) 
                { 
                    return IsSetLegDividendYield();
                }
                
                public bool IsSetLegDividendYield() 
                { 
                    return IsSetField(Tags.LegDividendYield);
                }
                public QuickFix.Fields.LegCurrencyRatio LegCurrencyRatio
                { 
                    get 
                    {
                        QuickFix.Fields.LegCurrencyRatio val = new QuickFix.Fields.LegCurrencyRatio();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegCurrencyRatio val) 
                { 
                    this.LegCurrencyRatio = val;
                }
                
                public QuickFix.Fields.LegCurrencyRatio Get(QuickFix.Fields.LegCurrencyRatio val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegCurrencyRatio val) 
                { 
                    return IsSetLegCurrencyRatio();
                }
                
                public bool IsSetLegCurrencyRatio() 
                { 
                    return IsSetField(Tags.LegCurrencyRatio);
                }
                public QuickFix.Fields.LegExecInst LegExecInst
                { 
                    get 
                    {
                        QuickFix.Fields.LegExecInst val = new QuickFix.Fields.LegExecInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegExecInst val) 
                { 
                    this.LegExecInst = val;
                }
                
                public QuickFix.Fields.LegExecInst Get(QuickFix.Fields.LegExecInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegExecInst val) 
                { 
                    return IsSetLegExecInst();
                }
                
                public bool IsSetLegExecInst() 
                { 
                    return IsSetField(Tags.LegExecInst);
                }
                public QuickFix.Fields.LegLastQty LegLastQty
                { 
                    get 
                    {
                        QuickFix.Fields.LegLastQty val = new QuickFix.Fields.LegLastQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LegLastQty val) 
                { 
                    this.LegLastQty = val;
                }
                
                public QuickFix.Fields.LegLastQty Get(QuickFix.Fields.LegLastQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LegLastQty val) 
                { 
                    return IsSetLegLastQty();
                }
                
                public bool IsSetLegLastQty() 
                { 
                    return IsSetField(Tags.LegLastQty);
                }
                            public class NoLegSecurityAltIDGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                
                    public NoLegSecurityAltIDGroup() 
                      :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegSecurityAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        this.LegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                    { 
                        return IsSetLegSecurityAltID();
                    }
                    
                    public bool IsSetLegSecurityAltID() 
                    { 
                        return IsSetField(Tags.LegSecurityAltID);
                    }
                    public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        this.LegSecurityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                    { 
                        return IsSetLegSecurityAltIDSource();
                    }
                    
                    public bool IsSetLegSecurityAltIDSource() 
                    { 
                        return IsSetField(Tags.LegSecurityAltIDSource);
                    }
                
                }
                public class NoLegStipulationsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};
                
                    public NoLegStipulationsGroup() 
                      :base( Tags.NoLegStipulations, Tags.LegStipulationType, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegStipulationsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegStipulationType LegStipulationType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStipulationType val = new QuickFix.Fields.LegStipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStipulationType val) 
                    { 
                        this.LegStipulationType = val;
                    }
                    
                    public QuickFix.Fields.LegStipulationType Get(QuickFix.Fields.LegStipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStipulationType val) 
                    { 
                        return IsSetLegStipulationType();
                    }
                    
                    public bool IsSetLegStipulationType() 
                    { 
                        return IsSetField(Tags.LegStipulationType);
                    }
                    public QuickFix.Fields.LegStipulationValue LegStipulationValue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStipulationValue val = new QuickFix.Fields.LegStipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        this.LegStipulationValue = val;
                    }
                    
                    public QuickFix.Fields.LegStipulationValue Get(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStipulationValue val) 
                    { 
                        return IsSetLegStipulationValue();
                    }
                    
                    public bool IsSetLegStipulationValue() 
                    { 
                        return IsSetField(Tags.LegStipulationValue);
                    }
                
                }
                public class NoNested3PartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.Nested3PartyID, Tags.Nested3PartyIDSource, Tags.Nested3PartyRole, Tags.NoNested3PartySubIDs, 0};
                
                    public NoNested3PartyIDsGroup() 
                      :base( Tags.NoNested3PartyIDs, Tags.Nested3PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNested3PartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.Nested3PartyID Nested3PartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested3PartyID val = new QuickFix.Fields.Nested3PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested3PartyID val) 
                    { 
                        this.Nested3PartyID = val;
                    }
                    
                    public QuickFix.Fields.Nested3PartyID Get(QuickFix.Fields.Nested3PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested3PartyID val) 
                    { 
                        return IsSetNested3PartyID();
                    }
                    
                    public bool IsSetNested3PartyID() 
                    { 
                        return IsSetField(Tags.Nested3PartyID);
                    }
                    public QuickFix.Fields.Nested3PartyIDSource Nested3PartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested3PartyIDSource val = new QuickFix.Fields.Nested3PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested3PartyIDSource val) 
                    { 
                        this.Nested3PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.Nested3PartyIDSource Get(QuickFix.Fields.Nested3PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested3PartyIDSource val) 
                    { 
                        return IsSetNested3PartyIDSource();
                    }
                    
                    public bool IsSetNested3PartyIDSource() 
                    { 
                        return IsSetField(Tags.Nested3PartyIDSource);
                    }
                    public QuickFix.Fields.Nested3PartyRole Nested3PartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested3PartyRole val = new QuickFix.Fields.Nested3PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested3PartyRole val) 
                    { 
                        this.Nested3PartyRole = val;
                    }
                    
                    public QuickFix.Fields.Nested3PartyRole Get(QuickFix.Fields.Nested3PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested3PartyRole val) 
                    { 
                        return IsSetNested3PartyRole();
                    }
                    
                    public bool IsSetNested3PartyRole() 
                    { 
                        return IsSetField(Tags.Nested3PartyRole);
                    }
                    public QuickFix.Fields.NoNested3PartySubIDs NoNested3PartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested3PartySubIDs val = new QuickFix.Fields.NoNested3PartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNested3PartySubIDs val) 
                    { 
                        this.NoNested3PartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested3PartySubIDs Get(QuickFix.Fields.NoNested3PartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNested3PartySubIDs val) 
                    { 
                        return IsSetNoNested3PartySubIDs();
                    }
                    
                    public bool IsSetNoNested3PartySubIDs() 
                    { 
                        return IsSetField(Tags.NoNested3PartySubIDs);
                    }
                                    public class NoNested3PartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.Nested3PartySubID, Tags.Nested3PartySubIDType, 0};
                    
                        public NoNested3PartySubIDsGroup() 
                          :base( Tags.NoNested3PartySubIDs, Tags.Nested3PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested3PartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.Nested3PartySubID Nested3PartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested3PartySubID val = new QuickFix.Fields.Nested3PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested3PartySubID val) 
                        { 
                            this.Nested3PartySubID = val;
                        }
                        
                        public QuickFix.Fields.Nested3PartySubID Get(QuickFix.Fields.Nested3PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested3PartySubID val) 
                        { 
                            return IsSetNested3PartySubID();
                        }
                        
                        public bool IsSetNested3PartySubID() 
                        { 
                            return IsSetField(Tags.Nested3PartySubID);
                        }
                        public QuickFix.Fields.Nested3PartySubIDType Nested3PartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested3PartySubIDType val = new QuickFix.Fields.Nested3PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested3PartySubIDType val) 
                        { 
                            this.Nested3PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.Nested3PartySubIDType Get(QuickFix.Fields.Nested3PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested3PartySubIDType val) 
                        { 
                            return IsSetNested3PartySubIDType();
                        }
                        
                        public bool IsSetNested3PartySubIDType() 
                        { 
                            return IsSetField(Tags.Nested3PartySubIDType);
                        }
                    
                    }
                }
                public class NoLegAllocsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.LegAllocAccount, Tags.LegIndividualAllocID, Tags.LegAllocQty, Tags.LegAllocAcctIDSource, Tags.LegAllocSettlCurrency, Tags.NoNested2PartyIDs, 0};
                
                    public NoLegAllocsGroup() 
                      :base( Tags.NoLegAllocs, Tags.LegAllocAccount, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoLegAllocsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.LegAllocAccount LegAllocAccount
                    { 
                        get 
                        {
                            QuickFix.Fields.LegAllocAccount val = new QuickFix.Fields.LegAllocAccount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegAllocAccount val) 
                    { 
                        this.LegAllocAccount = val;
                    }
                    
                    public QuickFix.Fields.LegAllocAccount Get(QuickFix.Fields.LegAllocAccount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegAllocAccount val) 
                    { 
                        return IsSetLegAllocAccount();
                    }
                    
                    public bool IsSetLegAllocAccount() 
                    { 
                        return IsSetField(Tags.LegAllocAccount);
                    }
                    public QuickFix.Fields.LegIndividualAllocID LegIndividualAllocID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIndividualAllocID val = new QuickFix.Fields.LegIndividualAllocID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIndividualAllocID val) 
                    { 
                        this.LegIndividualAllocID = val;
                    }
                    
                    public QuickFix.Fields.LegIndividualAllocID Get(QuickFix.Fields.LegIndividualAllocID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIndividualAllocID val) 
                    { 
                        return IsSetLegIndividualAllocID();
                    }
                    
                    public bool IsSetLegIndividualAllocID() 
                    { 
                        return IsSetField(Tags.LegIndividualAllocID);
                    }
                    public QuickFix.Fields.LegAllocQty LegAllocQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegAllocQty val = new QuickFix.Fields.LegAllocQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegAllocQty val) 
                    { 
                        this.LegAllocQty = val;
                    }
                    
                    public QuickFix.Fields.LegAllocQty Get(QuickFix.Fields.LegAllocQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegAllocQty val) 
                    { 
                        return IsSetLegAllocQty();
                    }
                    
                    public bool IsSetLegAllocQty() 
                    { 
                        return IsSetField(Tags.LegAllocQty);
                    }
                    public QuickFix.Fields.LegAllocAcctIDSource LegAllocAcctIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegAllocAcctIDSource val = new QuickFix.Fields.LegAllocAcctIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegAllocAcctIDSource val) 
                    { 
                        this.LegAllocAcctIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegAllocAcctIDSource Get(QuickFix.Fields.LegAllocAcctIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegAllocAcctIDSource val) 
                    { 
                        return IsSetLegAllocAcctIDSource();
                    }
                    
                    public bool IsSetLegAllocAcctIDSource() 
                    { 
                        return IsSetField(Tags.LegAllocAcctIDSource);
                    }
                    public QuickFix.Fields.LegAllocSettlCurrency LegAllocSettlCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegAllocSettlCurrency val = new QuickFix.Fields.LegAllocSettlCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegAllocSettlCurrency val) 
                    { 
                        this.LegAllocSettlCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegAllocSettlCurrency Get(QuickFix.Fields.LegAllocSettlCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegAllocSettlCurrency val) 
                    { 
                        return IsSetLegAllocSettlCurrency();
                    }
                    
                    public bool IsSetLegAllocSettlCurrency() 
                    { 
                        return IsSetField(Tags.LegAllocSettlCurrency);
                    }
                    public QuickFix.Fields.NoNested2PartyIDs NoNested2PartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested2PartyIDs val = new QuickFix.Fields.NoNested2PartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        this.NoNested2PartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) 
                    { 
                        return IsSetNoNested2PartyIDs();
                    }
                    
                    public bool IsSetNoNested2PartyIDs() 
                    { 
                        return IsSetField(Tags.NoNested2PartyIDs);
                    }
                                    public class NoNested2PartyIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};
                    
                        public NoNested2PartyIDsGroup() 
                          :base( Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested2PartyIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.Nested2PartyID Nested2PartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyID val = new QuickFix.Fields.Nested2PartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            this.Nested2PartyID = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartyID val) 
                        { 
                            return IsSetNested2PartyID();
                        }
                        
                        public bool IsSetNested2PartyID() 
                        { 
                            return IsSetField(Tags.Nested2PartyID);
                        }
                        public QuickFix.Fields.Nested2PartyIDSource Nested2PartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyIDSource val = new QuickFix.Fields.Nested2PartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            this.Nested2PartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) 
                        { 
                            return IsSetNested2PartyIDSource();
                        }
                        
                        public bool IsSetNested2PartyIDSource() 
                        { 
                            return IsSetField(Tags.Nested2PartyIDSource);
                        }
                        public QuickFix.Fields.Nested2PartyRole Nested2PartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested2PartyRole val = new QuickFix.Fields.Nested2PartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            this.Nested2PartyRole = val;
                        }
                        
                        public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested2PartyRole val) 
                        { 
                            return IsSetNested2PartyRole();
                        }
                        
                        public bool IsSetNested2PartyRole() 
                        { 
                            return IsSetField(Tags.Nested2PartyRole);
                        }
                        public QuickFix.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoNested2PartySubIDs val = new QuickFix.Fields.NoNested2PartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoNested2PartySubIDs val) 
                        { 
                            this.NoNested2PartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoNested2PartySubIDs Get(QuickFix.Fields.NoNested2PartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoNested2PartySubIDs val) 
                        { 
                            return IsSetNoNested2PartySubIDs();
                        }
                        
                        public bool IsSetNoNested2PartySubIDs() 
                        { 
                            return IsSetField(Tags.NoNested2PartySubIDs);
                        }
                                            public class NoNested2PartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};
                        
                            public NoNested2PartySubIDsGroup() 
                              :base( Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoNested2PartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.Nested2PartySubID Nested2PartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.Nested2PartySubID val = new QuickFix.Fields.Nested2PartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.Nested2PartySubID val) 
                            { 
                                this.Nested2PartySubID = val;
                            }
                            
                            public QuickFix.Fields.Nested2PartySubID Get(QuickFix.Fields.Nested2PartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.Nested2PartySubID val) 
                            { 
                                return IsSetNested2PartySubID();
                            }
                            
                            public bool IsSetNested2PartySubID() 
                            { 
                                return IsSetField(Tags.Nested2PartySubID);
                            }
                            public QuickFix.Fields.Nested2PartySubIDType Nested2PartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.Nested2PartySubIDType val = new QuickFix.Fields.Nested2PartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.Nested2PartySubIDType val) 
                            { 
                                this.Nested2PartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.Nested2PartySubIDType Get(QuickFix.Fields.Nested2PartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.Nested2PartySubIDType val) 
                            { 
                                return IsSetNested2PartySubIDType();
                            }
                            
                            public bool IsSetNested2PartySubIDType() 
                            { 
                                return IsSetField(Tags.Nested2PartySubIDType);
                            }
                        
                        }
                    }
                }
            }
            public class NoMiscFeesGroup : Group
            {
                public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};
            
                public NoMiscFeesGroup() 
                  :base( Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoMiscFeesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
                { 
                    get 
                    {
                        QuickFix.Fields.MiscFeeAmt val = new QuickFix.Fields.MiscFeeAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MiscFeeAmt val) 
                { 
                    this.MiscFeeAmt = val;
                }
                
                public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MiscFeeAmt val) 
                { 
                    return IsSetMiscFeeAmt();
                }
                
                public bool IsSetMiscFeeAmt() 
                { 
                    return IsSetField(Tags.MiscFeeAmt);
                }
                public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
                { 
                    get 
                    {
                        QuickFix.Fields.MiscFeeCurr val = new QuickFix.Fields.MiscFeeCurr();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MiscFeeCurr val) 
                { 
                    this.MiscFeeCurr = val;
                }
                
                public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MiscFeeCurr val) 
                { 
                    return IsSetMiscFeeCurr();
                }
                
                public bool IsSetMiscFeeCurr() 
                { 
                    return IsSetField(Tags.MiscFeeCurr);
                }
                public QuickFix.Fields.MiscFeeType MiscFeeType
                { 
                    get 
                    {
                        QuickFix.Fields.MiscFeeType val = new QuickFix.Fields.MiscFeeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MiscFeeType val) 
                { 
                    this.MiscFeeType = val;
                }
                
                public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MiscFeeType val) 
                { 
                    return IsSetMiscFeeType();
                }
                
                public bool IsSetMiscFeeType() 
                { 
                    return IsSetField(Tags.MiscFeeType);
                }
                public QuickFix.Fields.MiscFeeBasis MiscFeeBasis
                { 
                    get 
                    {
                        QuickFix.Fields.MiscFeeBasis val = new QuickFix.Fields.MiscFeeBasis();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MiscFeeBasis val) 
                { 
                    this.MiscFeeBasis = val;
                }
                
                public QuickFix.Fields.MiscFeeBasis Get(QuickFix.Fields.MiscFeeBasis val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MiscFeeBasis val) 
                { 
                    return IsSetMiscFeeBasis();
                }
                
                public bool IsSetMiscFeeBasis() 
                { 
                    return IsSetField(Tags.MiscFeeBasis);
                }
            
            }
            public class NoStrategyParametersGroup : Group
            {
                public static int[] fieldOrder = {Tags.StrategyParameterName, Tags.StrategyParameterType, Tags.StrategyParameterValue, 0};
            
                public NoStrategyParametersGroup() 
                  :base( Tags.NoStrategyParameters, Tags.StrategyParameterName, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoStrategyParametersGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.StrategyParameterName StrategyParameterName
                { 
                    get 
                    {
                        QuickFix.Fields.StrategyParameterName val = new QuickFix.Fields.StrategyParameterName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrategyParameterName val) 
                { 
                    this.StrategyParameterName = val;
                }
                
                public QuickFix.Fields.StrategyParameterName Get(QuickFix.Fields.StrategyParameterName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrategyParameterName val) 
                { 
                    return IsSetStrategyParameterName();
                }
                
                public bool IsSetStrategyParameterName() 
                { 
                    return IsSetField(Tags.StrategyParameterName);
                }
                public QuickFix.Fields.StrategyParameterType StrategyParameterType
                { 
                    get 
                    {
                        QuickFix.Fields.StrategyParameterType val = new QuickFix.Fields.StrategyParameterType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrategyParameterType val) 
                { 
                    this.StrategyParameterType = val;
                }
                
                public QuickFix.Fields.StrategyParameterType Get(QuickFix.Fields.StrategyParameterType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrategyParameterType val) 
                { 
                    return IsSetStrategyParameterType();
                }
                
                public bool IsSetStrategyParameterType() 
                { 
                    return IsSetField(Tags.StrategyParameterType);
                }
                public QuickFix.Fields.StrategyParameterValue StrategyParameterValue
                { 
                    get 
                    {
                        QuickFix.Fields.StrategyParameterValue val = new QuickFix.Fields.StrategyParameterValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrategyParameterValue val) 
                { 
                    this.StrategyParameterValue = val;
                }
                
                public QuickFix.Fields.StrategyParameterValue Get(QuickFix.Fields.StrategyParameterValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrategyParameterValue val) 
                { 
                    return IsSetStrategyParameterValue();
                }
                
                public bool IsSetStrategyParameterValue() 
                { 
                    return IsSetField(Tags.StrategyParameterValue);
                }
            
            }
            public class NoTrdRegTimestampsGroup : Group
            {
                public static int[] fieldOrder = {Tags.TrdRegTimestamp, Tags.TrdRegTimestampType, Tags.TrdRegTimestampOrigin, Tags.DeskType, Tags.DeskTypeSource, Tags.DeskOrderHandlingInst, 0};
            
                public NoTrdRegTimestampsGroup() 
                  :base( Tags.NoTrdRegTimestamps, Tags.TrdRegTimestamp, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoTrdRegTimestampsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.TrdRegTimestamp TrdRegTimestamp
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRegTimestamp val = new QuickFix.Fields.TrdRegTimestamp();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    this.TrdRegTimestamp = val;
                }
                
                public QuickFix.Fields.TrdRegTimestamp Get(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TrdRegTimestamp val) 
                { 
                    return IsSetTrdRegTimestamp();
                }
                
                public bool IsSetTrdRegTimestamp() 
                { 
                    return IsSetField(Tags.TrdRegTimestamp);
                }
                public QuickFix.Fields.TrdRegTimestampType TrdRegTimestampType
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRegTimestampType val = new QuickFix.Fields.TrdRegTimestampType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    this.TrdRegTimestampType = val;
                }
                
                public QuickFix.Fields.TrdRegTimestampType Get(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TrdRegTimestampType val) 
                { 
                    return IsSetTrdRegTimestampType();
                }
                
                public bool IsSetTrdRegTimestampType() 
                { 
                    return IsSetField(Tags.TrdRegTimestampType);
                }
                public QuickFix.Fields.TrdRegTimestampOrigin TrdRegTimestampOrigin
                { 
                    get 
                    {
                        QuickFix.Fields.TrdRegTimestampOrigin val = new QuickFix.Fields.TrdRegTimestampOrigin();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    this.TrdRegTimestampOrigin = val;
                }
                
                public QuickFix.Fields.TrdRegTimestampOrigin Get(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TrdRegTimestampOrigin val) 
                { 
                    return IsSetTrdRegTimestampOrigin();
                }
                
                public bool IsSetTrdRegTimestampOrigin() 
                { 
                    return IsSetField(Tags.TrdRegTimestampOrigin);
                }
                public QuickFix.Fields.DeskType DeskType
                { 
                    get 
                    {
                        QuickFix.Fields.DeskType val = new QuickFix.Fields.DeskType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskType val) 
                { 
                    this.DeskType = val;
                }
                
                public QuickFix.Fields.DeskType Get(QuickFix.Fields.DeskType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskType val) 
                { 
                    return IsSetDeskType();
                }
                
                public bool IsSetDeskType() 
                { 
                    return IsSetField(Tags.DeskType);
                }
                public QuickFix.Fields.DeskTypeSource DeskTypeSource
                { 
                    get 
                    {
                        QuickFix.Fields.DeskTypeSource val = new QuickFix.Fields.DeskTypeSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskTypeSource val) 
                { 
                    this.DeskTypeSource = val;
                }
                
                public QuickFix.Fields.DeskTypeSource Get(QuickFix.Fields.DeskTypeSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskTypeSource val) 
                { 
                    return IsSetDeskTypeSource();
                }
                
                public bool IsSetDeskTypeSource() 
                { 
                    return IsSetField(Tags.DeskTypeSource);
                }
                public QuickFix.Fields.DeskOrderHandlingInst DeskOrderHandlingInst
                { 
                    get 
                    {
                        QuickFix.Fields.DeskOrderHandlingInst val = new QuickFix.Fields.DeskOrderHandlingInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskOrderHandlingInst val) 
                { 
                    this.DeskOrderHandlingInst = val;
                }
                
                public QuickFix.Fields.DeskOrderHandlingInst Get(QuickFix.Fields.DeskOrderHandlingInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskOrderHandlingInst val) 
                { 
                    return IsSetDeskOrderHandlingInst();
                }
                
                public bool IsSetDeskOrderHandlingInst() 
                { 
                    return IsSetField(Tags.DeskOrderHandlingInst);
                }
            
            }
            public class NoAllocsGroup : Group
            {
                public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.AllocSettlCurrency, Tags.IndividualAllocID, Tags.NoNestedPartyIDs, Tags.AllocQty, 0};
            
                public NoAllocsGroup() 
                  :base( Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoAllocsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.AllocAccount AllocAccount
                { 
                    get 
                    {
                        QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocAccount val) 
                { 
                    this.AllocAccount = val;
                }
                
                public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocAccount val) 
                { 
                    return IsSetAllocAccount();
                }
                
                public bool IsSetAllocAccount() 
                { 
                    return IsSetField(Tags.AllocAccount);
                }
                public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocAcctIDSource val) 
                { 
                    this.AllocAcctIDSource = val;
                }
                
                public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) 
                { 
                    return IsSetAllocAcctIDSource();
                }
                
                public bool IsSetAllocAcctIDSource() 
                { 
                    return IsSetField(Tags.AllocAcctIDSource);
                }
                public QuickFix.Fields.AllocSettlCurrency AllocSettlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.AllocSettlCurrency val = new QuickFix.Fields.AllocSettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocSettlCurrency val) 
                { 
                    this.AllocSettlCurrency = val;
                }
                
                public QuickFix.Fields.AllocSettlCurrency Get(QuickFix.Fields.AllocSettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocSettlCurrency val) 
                { 
                    return IsSetAllocSettlCurrency();
                }
                
                public bool IsSetAllocSettlCurrency() 
                { 
                    return IsSetField(Tags.AllocSettlCurrency);
                }
                public QuickFix.Fields.IndividualAllocID IndividualAllocID
                { 
                    get 
                    {
                        QuickFix.Fields.IndividualAllocID val = new QuickFix.Fields.IndividualAllocID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IndividualAllocID val) 
                { 
                    this.IndividualAllocID = val;
                }
                
                public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IndividualAllocID val) 
                { 
                    return IsSetIndividualAllocID();
                }
                
                public bool IsSetIndividualAllocID() 
                { 
                    return IsSetField(Tags.IndividualAllocID);
                }
                public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    this.NoNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return IsSetNoNestedPartyIDs();
                }
                
                public bool IsSetNoNestedPartyIDs() 
                { 
                    return IsSetField(Tags.NoNestedPartyIDs);
                }
                public QuickFix.Fields.AllocQty AllocQty
                { 
                    get 
                    {
                        QuickFix.Fields.AllocQty val = new QuickFix.Fields.AllocQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AllocQty val) 
                { 
                    this.AllocQty = val;
                }
                
                public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AllocQty val) 
                { 
                    return IsSetAllocQty();
                }
                
                public bool IsSetAllocQty() 
                { 
                    return IsSetField(Tags.AllocQty);
                }
                            public class NoNestedPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};
                
                    public NoNestedPartyIDsGroup() 
                      :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNestedPartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.NestedPartyID NestedPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        this.NestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return IsSetNestedPartyID();
                    }
                    
                    public bool IsSetNestedPartyID() 
                    { 
                        return IsSetField(Tags.NestedPartyID);
                    }
                    public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        this.NestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return IsSetNestedPartyIDSource();
                    }
                    
                    public bool IsSetNestedPartyIDSource() 
                    { 
                        return IsSetField(Tags.NestedPartyIDSource);
                    }
                    public QuickFix.Fields.NestedPartyRole NestedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        this.NestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return IsSetNestedPartyRole();
                    }
                    
                    public bool IsSetNestedPartyRole() 
                    { 
                        return IsSetField(Tags.NestedPartyRole);
                    }
                    public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        this.NoNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        return IsSetNoNestedPartySubIDs();
                    }
                    
                    public bool IsSetNoNestedPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoNestedPartySubIDs);
                    }
                                    public class NoNestedPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};
                    
                        public NoNestedPartySubIDsGroup() 
                          :base( Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNestedPartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.NestedPartySubID NestedPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubID val = new QuickFix.Fields.NestedPartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            this.NestedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            return IsSetNestedPartySubID();
                        }
                        
                        public bool IsSetNestedPartySubID() 
                        { 
                            return IsSetField(Tags.NestedPartySubID);
                        }
                        public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            this.NestedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            return IsSetNestedPartySubIDType();
                        }
                        
                        public bool IsSetNestedPartySubIDType() 
                        { 
                            return IsSetField(Tags.NestedPartySubIDType);
                        }
                    
                    }
                }
            }
            public class NoFillsGroup : Group
            {
                public static int[] fieldOrder = {Tags.FillExecID, Tags.FillPx, Tags.FillQty, Tags.NoNested4PartyIDs, Tags.FillLiquidityInd, 0};
            
                public NoFillsGroup() 
                  :base( Tags.NoFills, Tags.FillExecID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoFillsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.FillExecID FillExecID
                { 
                    get 
                    {
                        QuickFix.Fields.FillExecID val = new QuickFix.Fields.FillExecID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillExecID val) 
                { 
                    this.FillExecID = val;
                }
                
                public QuickFix.Fields.FillExecID Get(QuickFix.Fields.FillExecID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillExecID val) 
                { 
                    return IsSetFillExecID();
                }
                
                public bool IsSetFillExecID() 
                { 
                    return IsSetField(Tags.FillExecID);
                }
                public QuickFix.Fields.FillPx FillPx
                { 
                    get 
                    {
                        QuickFix.Fields.FillPx val = new QuickFix.Fields.FillPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillPx val) 
                { 
                    this.FillPx = val;
                }
                
                public QuickFix.Fields.FillPx Get(QuickFix.Fields.FillPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillPx val) 
                { 
                    return IsSetFillPx();
                }
                
                public bool IsSetFillPx() 
                { 
                    return IsSetField(Tags.FillPx);
                }
                public QuickFix.Fields.FillQty FillQty
                { 
                    get 
                    {
                        QuickFix.Fields.FillQty val = new QuickFix.Fields.FillQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillQty val) 
                { 
                    this.FillQty = val;
                }
                
                public QuickFix.Fields.FillQty Get(QuickFix.Fields.FillQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillQty val) 
                { 
                    return IsSetFillQty();
                }
                
                public bool IsSetFillQty() 
                { 
                    return IsSetField(Tags.FillQty);
                }
                public QuickFix.Fields.NoNested4PartyIDs NoNested4PartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNested4PartyIDs val = new QuickFix.Fields.NoNested4PartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoNested4PartyIDs val) 
                { 
                    this.NoNested4PartyIDs = val;
                }
                
                public QuickFix.Fields.NoNested4PartyIDs Get(QuickFix.Fields.NoNested4PartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoNested4PartyIDs val) 
                { 
                    return IsSetNoNested4PartyIDs();
                }
                
                public bool IsSetNoNested4PartyIDs() 
                { 
                    return IsSetField(Tags.NoNested4PartyIDs);
                }
                public QuickFix.Fields.FillLiquidityInd FillLiquidityInd
                { 
                    get 
                    {
                        QuickFix.Fields.FillLiquidityInd val = new QuickFix.Fields.FillLiquidityInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FillLiquidityInd val) 
                { 
                    this.FillLiquidityInd = val;
                }
                
                public QuickFix.Fields.FillLiquidityInd Get(QuickFix.Fields.FillLiquidityInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FillLiquidityInd val) 
                { 
                    return IsSetFillLiquidityInd();
                }
                
                public bool IsSetFillLiquidityInd() 
                { 
                    return IsSetField(Tags.FillLiquidityInd);
                }
                            public class NoNested4PartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.Nested4PartyID, Tags.Nested4PartyIDSource, Tags.Nested4PartyRole, Tags.NoNested4PartySubIDs, 0};
                
                    public NoNested4PartyIDsGroup() 
                      :base( Tags.NoNested4PartyIDs, Tags.Nested4PartyID, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoNested4PartyIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.Nested4PartyID Nested4PartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested4PartyID val = new QuickFix.Fields.Nested4PartyID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested4PartyID val) 
                    { 
                        this.Nested4PartyID = val;
                    }
                    
                    public QuickFix.Fields.Nested4PartyID Get(QuickFix.Fields.Nested4PartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested4PartyID val) 
                    { 
                        return IsSetNested4PartyID();
                    }
                    
                    public bool IsSetNested4PartyID() 
                    { 
                        return IsSetField(Tags.Nested4PartyID);
                    }
                    public QuickFix.Fields.Nested4PartyIDSource Nested4PartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested4PartyIDSource val = new QuickFix.Fields.Nested4PartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested4PartyIDSource val) 
                    { 
                        this.Nested4PartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.Nested4PartyIDSource Get(QuickFix.Fields.Nested4PartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested4PartyIDSource val) 
                    { 
                        return IsSetNested4PartyIDSource();
                    }
                    
                    public bool IsSetNested4PartyIDSource() 
                    { 
                        return IsSetField(Tags.Nested4PartyIDSource);
                    }
                    public QuickFix.Fields.Nested4PartyRole Nested4PartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.Nested4PartyRole val = new QuickFix.Fields.Nested4PartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Nested4PartyRole val) 
                    { 
                        this.Nested4PartyRole = val;
                    }
                    
                    public QuickFix.Fields.Nested4PartyRole Get(QuickFix.Fields.Nested4PartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Nested4PartyRole val) 
                    { 
                        return IsSetNested4PartyRole();
                    }
                    
                    public bool IsSetNested4PartyRole() 
                    { 
                        return IsSetField(Tags.Nested4PartyRole);
                    }
                    public QuickFix.Fields.NoNested4PartySubIDs NoNested4PartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNested4PartySubIDs val = new QuickFix.Fields.NoNested4PartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNested4PartySubIDs val) 
                    { 
                        this.NoNested4PartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNested4PartySubIDs Get(QuickFix.Fields.NoNested4PartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNested4PartySubIDs val) 
                    { 
                        return IsSetNoNested4PartySubIDs();
                    }
                    
                    public bool IsSetNoNested4PartySubIDs() 
                    { 
                        return IsSetField(Tags.NoNested4PartySubIDs);
                    }
                                    public class NoNested4PartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.Nested4PartySubID, Tags.Nested4PartySubIDType, 0};
                    
                        public NoNested4PartySubIDsGroup() 
                          :base( Tags.NoNested4PartySubIDs, Tags.Nested4PartySubID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoNested4PartySubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.Nested4PartySubID Nested4PartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested4PartySubID val = new QuickFix.Fields.Nested4PartySubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested4PartySubID val) 
                        { 
                            this.Nested4PartySubID = val;
                        }
                        
                        public QuickFix.Fields.Nested4PartySubID Get(QuickFix.Fields.Nested4PartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested4PartySubID val) 
                        { 
                            return IsSetNested4PartySubID();
                        }
                        
                        public bool IsSetNested4PartySubID() 
                        { 
                            return IsSetField(Tags.Nested4PartySubID);
                        }
                        public QuickFix.Fields.Nested4PartySubIDType Nested4PartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.Nested4PartySubIDType val = new QuickFix.Fields.Nested4PartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.Nested4PartySubIDType val) 
                        { 
                            this.Nested4PartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.Nested4PartySubIDType Get(QuickFix.Fields.Nested4PartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.Nested4PartySubIDType val) 
                        { 
                            return IsSetNested4PartySubIDType();
                        }
                        
                        public bool IsSetNested4PartySubIDType() 
                        { 
                            return IsSetField(Tags.Nested4PartySubIDType);
                        }
                    
                    }
                }
            }
            public class NoRateSourcesGroup : Group
            {
                public static int[] fieldOrder = {Tags.RateSource, Tags.RateSourceType, Tags.ReferencePage, 0};
            
                public NoRateSourcesGroup() 
                  :base( Tags.NoRateSources, Tags.RateSource, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRateSourcesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RateSource RateSource
                { 
                    get 
                    {
                        QuickFix.Fields.RateSource val = new QuickFix.Fields.RateSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RateSource val) 
                { 
                    this.RateSource = val;
                }
                
                public QuickFix.Fields.RateSource Get(QuickFix.Fields.RateSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RateSource val) 
                { 
                    return IsSetRateSource();
                }
                
                public bool IsSetRateSource() 
                { 
                    return IsSetField(Tags.RateSource);
                }
                public QuickFix.Fields.RateSourceType RateSourceType
                { 
                    get 
                    {
                        QuickFix.Fields.RateSourceType val = new QuickFix.Fields.RateSourceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RateSourceType val) 
                { 
                    this.RateSourceType = val;
                }
                
                public QuickFix.Fields.RateSourceType Get(QuickFix.Fields.RateSourceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RateSourceType val) 
                { 
                    return IsSetRateSourceType();
                }
                
                public bool IsSetRateSourceType() 
                { 
                    return IsSetField(Tags.RateSourceType);
                }
                public QuickFix.Fields.ReferencePage ReferencePage
                { 
                    get 
                    {
                        QuickFix.Fields.ReferencePage val = new QuickFix.Fields.ReferencePage();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ReferencePage val) 
                { 
                    this.ReferencePage = val;
                }
                
                public QuickFix.Fields.ReferencePage Get(QuickFix.Fields.ReferencePage val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ReferencePage val) 
                { 
                    return IsSetReferencePage();
                }
                
                public bool IsSetReferencePage() 
                { 
                    return IsSetField(Tags.ReferencePage);
                }
            
            }
        }
    }
}
