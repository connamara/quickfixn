using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QuickFix;
using QuickFix.Fields;

namespace FIXClient {
    class Client : MessageCracker, IApplication {

        private Session m_Session;   // The client FIX session.

        private double m_AvgLatency = 0;

        private double m_MaxLatency = 0;

        private Stopwatch m_Stopwatch;

        private Stopwatch m_MessageStopwatch;

        private int m_NumMsgReceived = 0;

        private Thread m_Thread;

        public Client() {
            m_Thread = new Thread(new ThreadStart(() => {
                while (true) {
                    
                    Thread.Sleep(1000);

                    Console.WriteLine("Ms per message: " + ((double)m_MessageStopwatch.ElapsedMilliseconds / (double)m_NumMsgReceived));
                } 
            }));
        }

        int m_NumOfExeReportsReceived = 0;
        HashSet<string> m_OpenOrderIds = new HashSet<string>();

        // This variable is a kludge for developer test purposes.  Don't do this on a production application.
        public IInitiator MyInitiator = null;

        public void OnCreate(SessionID sessionID) { // This method is called whenever a new session is created.
            m_Session = Session.LookupSession(sessionID);
        }

        public void OnLogon(SessionID sessionID) {
            Console.WriteLine("Logon - " + sessionID.ToString());
        }

        public void OnLogout(SessionID sessionID) {
            Console.WriteLine("Logout - " + sessionID.ToString());
        }

        public void FromAdmin(Message message, SessionID sessionID) {
        }

        public void ToAdmin(Message message, SessionID sessionID) {
        }

        public void FromApp(Message message, SessionID sessionID) {
            OnMessage(message, sessionID);
            string msgType = message.Header.GetString(Tags.MsgType);
            switch (msgType) {
                case "8":
                    OnExecutionReport((QuickFix.FIX42.ExecutionReport)message);
                    break;
            }
        }

        private void OnExecutionReport(QuickFix.FIX42.ExecutionReport executionReport) {
            lock (m_OpenOrderIds) {
                m_NumOfExeReportsReceived++;
                bool flag = m_OpenOrderIds.Remove(executionReport.OrderID.getValue());
                if (!flag) {
                    Console.WriteLine("Unexpecpted OrderID. Something must be wrong.");
                }
                if (m_OpenOrderIds.Count == 0) {
                    m_Stopwatch.Stop();
                    Console.WriteLine("\nTotal Time in ms: " + m_Stopwatch.ElapsedMilliseconds);
                    Console.WriteLine("Average Time in ms: " + (double)m_Stopwatch.ElapsedMilliseconds / (double)m_NumOfExeReportsReceived);
                    Console.WriteLine("Execution report received: " + m_NumOfExeReportsReceived);
                    m_OpenOrderIds.Clear();
                    m_NumOfExeReportsReceived = 0;
                }
            }
        }

        public void ToApp(Message message, SessionID sessionID) {
            try {
                bool possDupFlag = false;
                if (message.Header.IsSetField(QuickFix.Fields.Tags.PossDupFlag)) {
                    possDupFlag = QuickFix.Fields.Converters.BoolConverter.Convert(
                        message.Header.GetField(QuickFix.Fields.Tags.PossDupFlag)); /// FIXME
                }
                if (possDupFlag)
                    throw new DoNotSend();
            } catch (FieldNotFoundException) { }
        }

        public void OnMessage(Message msg, SessionID s) {
            m_NumMsgReceived++;
        }

        public void Run() {
            while (true) {
                try {
                    char action = QueryAction();
                    if (action == '1') {
                        QueryEnterOrder();
                    }  else if (action == '2') {
                        QueryMarketDataRequest();
                    } else if (action == 'q' || action == 'Q')
                        break;
                } catch (System.Exception e) {
                    Console.WriteLine("Message Not Sent: " + e.Message);
                    Console.WriteLine("StackTrace: " + e.StackTrace);
                }
            }
            Console.WriteLine("Program shutdown.");
        }

        private char QueryAction() {
            // Commands 'g' and 'x' are intentionally hidden.
            Console.Write("\n"
                + "1) Benchmark Order Latency\n"
                + "2) Market data test\n"
                + "Q) Quit\n"
                + "Action: "
            );

            HashSet<string> validActions = new HashSet<string>("1,2,,4,q,Q".Split(','));

            string cmd = Console.ReadLine().Trim();
            if (cmd.Length != 1 || validActions.Contains(cmd) == false)
                throw new System.Exception("Invalid action");

            return cmd.ToCharArray()[0];
        }

        private void QueryLatency() {
            Console.WriteLine(string.Format("The number of received msg: {0}", m_NumMsgReceived));
            Console.WriteLine(string.Format("Max latency in milliseconds: {0}", m_MaxLatency));
            Console.WriteLine(string.Format("Average latency in milliseconds: {0}", m_AvgLatency));
            Console.WriteLine();
        }

        private void SendMessage(Message m) {
            if (m_Session != null) {
                m_Session.Send(m);
            } else {
                // This probably won't ever happen.
                Console.WriteLine("Can't send message: session not created.");
            }
        }


        private int QueryNumOfOrders() {
            int numOfOrders = 0;
            Console.Write("Num of Orders: ");
            string str = Console.ReadLine().Trim();
            int.TryParse(str, out numOfOrders);
            return numOfOrders;
        }

        private void QueryEnterOrder() {
            int numOfOrders = QueryNumOfOrders();
            Console.WriteLine("\nIssuing " + numOfOrders + " orders.");
            Queue<QuickFix.FIX42.NewOrderSingle> orders = CreateOrders(numOfOrders);

            m_OpenOrderIds.Clear();
            m_NumOfExeReportsReceived = 0;
            m_Stopwatch = Stopwatch.StartNew();
            int numOrdersSent = 0;
            while (orders.Count > 0) {
                QuickFix.FIX42.NewOrderSingle order = orders.Dequeue();
                ++numOrdersSent;
                lock (m_OpenOrderIds)
                    m_OpenOrderIds.Add(order.ClOrdID.getValue());
                SendMessage(order);

                if (numOrdersSent % 1000 == 0) {
                    Console.WriteLine("Order sent: " + numOrdersSent);
                }
            }
        }

        private Queue<QuickFix.FIX42.NewOrderSingle> CreateOrders(int n) {
            Queue<QuickFix.FIX42.NewOrderSingle> orders = new Queue<QuickFix.FIX42.NewOrderSingle>(n);
            for (int i = 0; i < n; i++) { 
                ClOrdID cloudOrderId = new ClOrdID(Guid.NewGuid().ToString());
                HandlInst handlInst = new HandlInst(HandlInst.AUTOMATED_EXECUTION_ORDER_PRIVATE_NO_BROKER_INTERVENTION);
                Symbol symbol = new Symbol("MSFT");
                Side side = new Side(Side.BUY);
                TransactTime time = new TransactTime();
                OrdType orderType = new OrdType(OrdType.LIMIT);
                QuickFix.FIX42.NewOrderSingle order = new QuickFix.FIX42.NewOrderSingle(cloudOrderId, handlInst, symbol, side, time, orderType);
                order.Account = new Account("Account");
                order.OrderQty = new OrderQty(100);
                order.ExDestination = new ExDestination("*");
                order.TimeInForce = new TimeInForce(TimeInForce.DAY);
                order.Price = new Price(50m);
                order.SecurityType = new SecurityType(SecurityType.COMMON_STOCK);
                orders.Enqueue(order);
            }
            return orders;
        }

        private void QueryMarketDataRequest() {
            Console.WriteLine("\nMarketDataRequest");

            QuickFix.FIX42.MarketDataRequest m = QueryMarketDataRequest42(QueryProductName());

            if (m != null) {
                m_MessageStopwatch = Stopwatch.StartNew();
                m_Thread.Start();
                SendMessage(m);
            }
        }

        private string QueryProductName() {
            Console.Write("Product Name: ");
            return Console.ReadLine().Trim();
        } 

        private bool QueryConfirm(string query) {
            Console.WriteLine();
            Console.WriteLine(query + "?: ");
            string line = Console.ReadLine().Trim();
            return (line[0].Equals('y') || line[0].Equals('Y'));
        }

        public QuickFix.FIX42.MarketDataRequest QueryMarketDataRequest42(string productName) {
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT_PLUS_UPDATES);
            MarketDepth marketDepth = new MarketDepth(1);

            QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup marketDataEntryGroup = new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup();
            marketDataEntryGroup.Set(new MDEntryType(MDEntryType.BID));

            QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup symbolGroup = new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
            symbolGroup.Set(new Symbol(productName));
            symbolGroup.Set(new SecurityExchange("*"));
            symbolGroup.Set(new SecurityType(SecurityType.COMMON_STOCK));

            QuickFix.FIX42.MarketDataRequest message = new QuickFix.FIX42.MarketDataRequest(mdReqID, subType, marketDepth);
            message.AddGroup(marketDataEntryGroup);
            message.AddGroup(symbolGroup);

            return message;
        }
    }
}
