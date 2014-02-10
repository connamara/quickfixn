using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QuickFix;
using QuickFix.Fields;

namespace FIXServer {
    class Server : QuickFix.MessageCracker, QuickFix.IApplication {

        int orderID = 0;
        int execID = 0;

        Dictionary<string, QuotePublisher> m_ProductSubscription = new Dictionary<string, QuotePublisher>();

        private string GenOrderID() { return (++orderID).ToString(); }
        private string GenExecID() { return (++execID).ToString(); }

        public void FromAdmin(Message message, SessionID sessionID) { }
        public void OnCreate(SessionID sessionID) {
        }
        public void OnLogout(SessionID sessionID) {
            Console.WriteLine(sessionID.ToString() + "logged out");
            m_ProductSubscription.Clear();
        }
        public void OnLogon(SessionID sessionID) {
            Console.WriteLine(sessionID.ToString() + "logged on");
        }
        public void ToAdmin(Message message, SessionID sessionID) { }

        public void FromApp(Message message, SessionID sessionID) {
            string msgType = message.Header.GetString(Tags.MsgType);
            switch (msgType) { 
                case "V":
                    OnMessage(((QuickFix.FIX42.MarketDataRequest)message), sessionID);
                    break;
                case "D":
                    OnMessage(((QuickFix.FIX42.NewOrderSingle)message), sessionID);
                    break;
            }
        }

        public void ToApp(Message message, SessionID sessionID) {
            Trace.TraceInformation(message.ToString());
        }

        private void OnMessage(QuickFix.FIX42.NewOrderSingle n, SessionID s) {
            QuickFix.FIX42.ExecutionReport executionReport = new QuickFix.FIX42.ExecutionReport(new OrderID(n.ClOrdID.getValue()), new ExecID(Guid.NewGuid().ToString()), new ExecTransType(ExecTransType.NEW), new ExecType(ExecType.NEW), new OrdStatus(OrdStatus.NEW), n.Symbol, n.Side, new LeavesQty(n.OrderQty.getValue()), new CumQty(0), new AvgPx());
            Session.SendToTarget(executionReport, s);
        }

        private void OnMessage(QuickFix.FIX42.MarketDataRequest m, SessionID s) {
            QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup symbolGroup = new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
            m.GetGroup(1, symbolGroup);
            string symbolName = symbolGroup.Get(new Symbol()).getValue();
            string mdRequestId = m.MDReqID.ToString();
            if (!m_ProductSubscription.ContainsKey(symbolName)) {
                bool fullSpeed = symbolName.StartsWith("B");
                Console.WriteLine("Subscribe : " + symbolName + ". Full Speed: " + fullSpeed);
                QuotePublisher publisher = new QuotePublisher(symbolName, mdRequestId, fullSpeed, s);
                m_ProductSubscription.Add(symbolName, publisher);
            }
        }

        private class QuotePublisher {

            private bool m_Start = true;

            private QuickFix.FIX42.MarketDataSnapshotFullRefresh m_Quote;

            private void InitializeQuote(string symbolName, string marketDataRequestId) {
                m_Quote = new QuickFix.FIX42.MarketDataSnapshotFullRefresh();
                m_Quote.SetField(new MDReqID(marketDataRequestId));
                m_Quote.SetField(new SecurityExchange("*"));
                m_Quote.SetField(new TotalVolumeTraded(10000));
                m_Quote.SetField(new Symbol(symbolName));
                m_Quote.SetField(new NoMDEntries(3));

                QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup group1 = new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                group1.SetField(new MDEntryType(MDEntryType.BID));
                group1.SetField(new MDEntryPx(50m));
                group1.SetField(new MDEntrySize(100));
                m_Quote.AddGroup(group1);

                QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup group2 = new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                group2.SetField(new MDEntryType(MDEntryType.OFFER));
                group2.SetField(new MDEntryPx(50.01m));
                group2.SetField(new MDEntrySize(100));
                m_Quote.AddGroup(group2);

                QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup trade = new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                trade.SetField(new MDEntryType(MDEntryType.TRADE));
                trade.SetField(new MDEntryPx(50.01m));
                trade.SetField(new MDEntrySize(100));
                m_Quote.AddGroup(trade);
            }

            public QuotePublisher(string symbolName, string marketDataRequestId, bool fullSpeed, SessionID s) {
                InitializeQuote(symbolName, marketDataRequestId);
                Thread thread = new Thread(new ThreadStart(() => {
                    while (m_Start) {
                        Session.SendToTarget(m_Quote, s);
                        if (!fullSpeed) {
                            Thread.Sleep(100);
                        }
                    }
                }));
                thread.IsBackground = true;
                thread.Start();
            }

            public void Stop() {
                m_Start = false;
            }
        }
    }
}
