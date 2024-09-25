using System;
using QuickFix;
using QuickFix.Fields;
using System.Collections.Generic;
using ApplicationException = System.ApplicationException;
using Exception = System.Exception;

namespace TradeClient
{
    public class TradeClientApp : QuickFix.MessageCracker, QuickFix.IApplication
    {
        private Session? _session = null;

        // This variable is a kludge for developer test purposes.  Don't do this on a production application.
        public IInitiator? MyInitiator = null;

        #region IApplication interface overrides

        public void OnCreate(SessionID sessionId)
        {
            _session = Session.LookupSession(sessionId);
            if (_session is null)
                throw new ApplicationException("Somehow session is not found");
        }

        public void OnLogon(SessionID sessionId) { Console.WriteLine("Logon - " + sessionId); }
        public void OnLogout(SessionID sessionId) { Console.WriteLine("Logout - " + sessionId); }

        public void FromAdmin(Message message, SessionID sessionId) { }
        public void ToAdmin(Message message, SessionID sessionId) { }

        public void FromApp(Message message, SessionID sessionId)
        {
            Console.WriteLine("IN:  " + message.ConstructString());
            try
            {
                Crack(message, sessionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("==Cracker exception==");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ToApp(Message message, SessionID sessionId)
        {
            try
            {
                bool possDupFlag = false;
                if (message.Header.IsSetField(Tags.PossDupFlag))
                {
                    possDupFlag = message.Header.GetBoolean(Tags.PossDupFlag);
                }
                if (possDupFlag)
                    throw new DoNotSend();
            }
            catch (FieldNotFoundException)
            { }

            Console.WriteLine();
            Console.WriteLine("OUT: " + message.ConstructString());
        }
        #endregion


        #region MessageCracker handlers
        public void OnMessage(QuickFix.FIX44.ExecutionReport m, SessionID s)
        {
            Console.WriteLine("Received execution report");
        }

        public void OnMessage(QuickFix.FIX44.OrderCancelReject m, SessionID s)
        {
            Console.WriteLine("Received order cancel reject");
        }
        #endregion


        public void Run()
        {
            if (this.MyInitiator is null)
                throw new ApplicationException("Somehow this.MyInitiator is not set");

            while (true)
            {
                try
                {
                    char action = QueryAction();
                    if (action == '1')
                        QueryEnterOrder();
                    else if (action == '2')
                        QueryCancelOrder();
                    else if (action == '3')
                        QueryReplaceOrder();
                    else if (action == '4')
                        QueryMarketDataRequest();
                    else if (action == 'g')
                    {
                        if (this.MyInitiator.IsStopped)
                        {
                            Console.WriteLine("Restarting initiator...");
                            this.MyInitiator.Start();
                        }
                        else
                            Console.WriteLine("Already started.");
                    }
                    else if (action == 'x')
                    {
                        if (this.MyInitiator.IsStopped)
                            Console.WriteLine("Already stopped.");
                        else
                        {
                            Console.WriteLine("Stopping initiator...");
                            this.MyInitiator.Stop();
                        }
                    }
                    else if (action == 'q' || action == 'Q')
                        break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Message Not Sent: " + e.Message);
                    Console.WriteLine("StackTrace: " + e.StackTrace);
                }
            }
            Console.WriteLine("Program shutdown.");
        }

        private void SendMessage(Message m)
        {
            if (_session is not null)
                _session.Send(m);
            else
            {
                // This probably won't ever happen.
                Console.WriteLine("Can't send message: session not created.");
            }
        }

        private static string ReadCommand() {
            string? inp = Console.ReadLine();
            if (inp is null)
                throw new ApplicationException("Input no longer available");
            return inp.Trim();
        }

        private char QueryAction()
        {
            // Commands 'g' and 'x' are intentionally hidden.
            Console.Write("\n"
                + "1) Enter Order\n"
                + "2) Cancel Order\n"
                + "3) Replace Order\n"
                + "4) Market data test\n"
                + "Q) Quit\n"
                + "Action: "
            );

            HashSet<string> validActions = new HashSet<string>("1,2,3,4,q,Q,g,x".Split(','));

            string cmd = ReadCommand();
            if (cmd.Length != 1 || validActions.Contains(cmd) == false)
                throw new System.Exception("Invalid action");

            return cmd.ToCharArray()[0];
        }

        private void QueryEnterOrder()
        {
            Console.WriteLine("\nNewOrderSingle");

            QuickFix.FIX44.NewOrderSingle m = QueryNewOrderSingle44();

            if (m is not null && QueryConfirm("Send order"))
            {
                m.Header.GetString(Tags.BeginString);

                SendMessage(m);
            }
        }

        private void QueryCancelOrder()
        {
            Console.WriteLine("\nOrderCancelRequest");

            QuickFix.FIX44.OrderCancelRequest m = QueryOrderCancelRequest44();

            if (m != null && QueryConfirm("Cancel order"))
                SendMessage(m);
        }

        private void QueryReplaceOrder()
        {
            Console.WriteLine("\nCancelReplaceRequest");

            QuickFix.FIX44.OrderCancelReplaceRequest m = QueryCancelReplaceRequest44();

            if (m != null && QueryConfirm("Send replace"))
                SendMessage(m);
        }

        private void QueryMarketDataRequest()
        {
            Console.WriteLine("\nMarketDataRequest");

            QuickFix.FIX44.MarketDataRequest m = QueryMarketDataRequest44();

            if (QueryConfirm("Send market data request"))
                SendMessage(m);
        }

        private bool QueryConfirm(string query)
        {
            Console.WriteLine();
            Console.WriteLine(query + "?: ");
            string line = ReadCommand();
            return (line[0].Equals('y') || line[0].Equals('Y'));
        }

        #region Message creation functions
        private QuickFix.FIX44.NewOrderSingle QueryNewOrderSingle44()
        {
            OrdType ordType = QueryOrdType();

            QuickFix.FIX44.NewOrderSingle newOrderSingle = new QuickFix.FIX44.NewOrderSingle(
                QueryClOrdId(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                ordType);

            newOrderSingle.Set(new HandlInst('1'));
            newOrderSingle.Set(QueryOrderQty());
            newOrderSingle.Set(QueryTimeInForce());
            if (ordType.Value == OrdType.LIMIT || ordType.Value == OrdType.STOP_LIMIT)
                newOrderSingle.Set(QueryPrice());
            if (ordType.Value == OrdType.STOP || ordType.Value == OrdType.STOP_LIMIT)
                newOrderSingle.Set(QueryStopPx());

            return newOrderSingle;
        }

        private QuickFix.FIX44.OrderCancelRequest QueryOrderCancelRequest44()
        {
            QuickFix.FIX44.OrderCancelRequest orderCancelRequest = new QuickFix.FIX44.OrderCancelRequest(
                QueryOrigClOrdId(),
                QueryClOrdId(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now));

            orderCancelRequest.Set(QueryOrderQty());
            return orderCancelRequest;
        }

        private QuickFix.FIX44.OrderCancelReplaceRequest QueryCancelReplaceRequest44()
        {
            QuickFix.FIX44.OrderCancelReplaceRequest ocrr = new QuickFix.FIX44.OrderCancelReplaceRequest(
                QueryOrigClOrdId(),
                QueryClOrdId(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                QueryOrdType());

            ocrr.Set(new HandlInst('1'));
            if (QueryConfirm("New price"))
                ocrr.Set(QueryPrice());
            if (QueryConfirm("New quantity"))
                ocrr.Set(QueryOrderQty());

            return ocrr;
        }

        private QuickFix.FIX44.MarketDataRequest QueryMarketDataRequest44()
        {
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT);
            MarketDepth marketDepth = new MarketDepth(0);

            QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup marketDataEntryGroup = new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
            marketDataEntryGroup.Set(new MDEntryType(MDEntryType.BID));

            QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup symbolGroup = new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
            symbolGroup.Set(new Symbol("LNUX"));

            QuickFix.FIX44.MarketDataRequest message = new QuickFix.FIX44.MarketDataRequest(mdReqID, subType, marketDepth);
            message.AddGroup(marketDataEntryGroup);
            message.AddGroup(symbolGroup);

            return message;
        }
        #endregion

        #region field query private methods
        private ClOrdID QueryClOrdId()
        {
            Console.WriteLine();
            Console.Write("ClOrdID? ");
            return new ClOrdID(ReadCommand());
        }

        private OrigClOrdID QueryOrigClOrdId()
        {
            Console.WriteLine();
            Console.Write("OrigClOrdID? ");
            return new OrigClOrdID(ReadCommand());
        }

        private Symbol QuerySymbol()
        {
            Console.WriteLine();
            Console.Write("Symbol? ");
            return new Symbol(ReadCommand());
        }

        private Side QuerySide()
        {
            Console.WriteLine();
            Console.WriteLine("1) Buy");
            Console.WriteLine("2) Sell");
            Console.WriteLine("3) Sell Short");
            Console.WriteLine("4) Sell Short Exempt");
            Console.WriteLine("5) Cross");
            Console.WriteLine("6) Cross Short");
            Console.WriteLine("7) Cross Short Exempt");
            Console.Write("Side? ");
            string s = ReadCommand();

            char c = ' ';
            switch (s)
            {
                case "1": c = Side.BUY; break;
                case "2": c = Side.SELL; break;
                case "3": c = Side.SELL_SHORT; break;
                case "4": c = Side.SELL_SHORT_EXEMPT; break;
                case "5": c = Side.CROSS; break;
                case "6": c = Side.CROSS_SHORT; break;
                case "7": c = 'A'; break;
                default: throw new Exception("unsupported input");
            }
            return new Side(c);
        }

        private OrdType QueryOrdType()
        {
            Console.WriteLine();
            Console.WriteLine("1) Market");
            Console.WriteLine("2) Limit");
            Console.WriteLine("3) Stop");
            Console.WriteLine("4) Stop Limit");
            Console.Write("OrdType? ");
            string s = ReadCommand();

            char c = ' ';
            switch (s)
            {
                case "1": c = OrdType.MARKET; break;
                case "2": c = OrdType.LIMIT; break;
                case "3": c = OrdType.STOP; break;
                case "4": c = OrdType.STOP_LIMIT; break;
                default: throw new Exception("unsupported input");
            }
            return new OrdType(c);
        }

        private OrderQty QueryOrderQty()
        {
            Console.WriteLine();
            Console.Write("OrderQty? ");
            return new OrderQty(Convert.ToDecimal(ReadCommand()));
        }

        private TimeInForce QueryTimeInForce()
        {
            Console.WriteLine();
            Console.WriteLine("1) Day");
            Console.WriteLine("2) IOC");
            Console.WriteLine("3) OPG");
            Console.WriteLine("4) GTC");
            Console.WriteLine("5) GTX");
            Console.Write("TimeInForce? ");
            string s = ReadCommand();

            char c = ' ';
            switch (s)
            {
                case "1": c = TimeInForce.DAY; break;
                case "2": c = TimeInForce.IMMEDIATE_OR_CANCEL; break;
                case "3": c = TimeInForce.AT_THE_OPENING; break;
                case "4": c = TimeInForce.GOOD_TILL_CANCEL; break;
                case "5": c = TimeInForce.GOOD_TILL_CROSSING; break;
                default: throw new Exception("unsupported input");
            }
            return new TimeInForce(c);
        }

        private Price QueryPrice()
        {
            Console.WriteLine();
            Console.Write("Price? ");
            return new Price(Convert.ToDecimal(ReadCommand()));
        }

        private StopPx QueryStopPx()
        {
            Console.WriteLine();
            Console.Write("StopPx? ");
            return new StopPx(Convert.ToDecimal(ReadCommand()));
        }

        #endregion
    }
}
