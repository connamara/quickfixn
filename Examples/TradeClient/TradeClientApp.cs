using System;
using QuickFix;
using QuickFix.Fields;

namespace TradeClient
{
    public class TradeClientApp : QuickFix.MessageCracker, QuickFix.Application
    {
        public enum FixVersion { FIX40, FIX41, FIX42, FIX43, FIX44, FIX50 }

        #region Application interface overrides

        public void OnCreate(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { Console.WriteLine("Logon - " + sessionID.ToString()); }
        public void OnLogout(SessionID sessionID) { Console.WriteLine("Logout - " + sessionID.ToString()); }

        public void FromAdmin(Message message, SessionID sessionID) { Console.WriteLine("FromAdmin: " + message.ToString()); }
        public void ToAdmin(Message message, SessionID sessionID) { }

        public void FromApp(Message message, SessionID sessionID)
        {
            Crack(message, sessionID);
            Console.WriteLine("FromApp: " + message.ToString());
        }

        public void ToApp(Message message, SessionID sessionID)
        {
            try
            {
                bool possDupFlag = false;
                if (message.Header.isSetField(QuickFix.Fields.Tags.PossDupFlag))
                {
                    possDupFlag = QuickFix.Fields.Converters.BoolConverter.Convert(
                        message.Header.GetField(QuickFix.Fields.Tags.PossDupFlag)); /// FIXME
                }
                if (possDupFlag)
                    throw new DoNotSend();
            }
            catch (FieldNotFoundException)
            { }

            Console.WriteLine();
            Console.WriteLine("OUT: " + message.ToString());
        }
        #endregion


        #region MessageCracker handlers
        public void OnMessage(QuickFix.FIX40.ExecutionReport m, SessionID s) { }
        public void OnMessage(QuickFix.FIX40.OrderCancelReject m, SessionID s) { }
        public void OnMessage(QuickFix.FIX41.ExecutionReport m, SessionID s) { }
        public void OnMessage(QuickFix.FIX41.OrderCancelReject m, SessionID s) { }
        public void OnMessage(QuickFix.FIX42.ExecutionReport m, SessionID s) { }
        public void OnMessage(QuickFix.FIX42.OrderCancelReject m, SessionID s) { }
        public void OnMessage(QuickFix.FIX43.ExecutionReport m, SessionID s) { }
        public void OnMessage(QuickFix.FIX43.OrderCancelReject m, SessionID s) { }
        public void OnMessage(QuickFix.FIX44.ExecutionReport m, SessionID s) { }
        public void OnMessage(QuickFix.FIX44.OrderCancelReject m, SessionID s) { }
        public void OnMessage(QuickFix.FIX50.ExecutionReport m, SessionID s) { }
        public void OnMessage(QuickFix.FIX50.OrderCancelReject m, SessionID s) { }
        #endregion


        public void Run()
        {
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
                    else if (action == '5')
                        break;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Message Not Sent: " + e.Message);
                    Console.WriteLine("StackTrace: " + e.StackTrace);
                }
            }
            Console.WriteLine("Program shutdown.");
        }

        private char QueryAction()
        {
            Console.Write("\n"
                + "1) Enter Order\n"
                + "2) Cancel Order\n"
                + "3) Replace Order\n"
                + "4) Market data test\n"
                + "5) Quit\n"
                + "Action: "
            );

            string line = Console.ReadLine().Trim();
            if (line.Length != 1)
                throw new System.Exception("Invalid action");

            char val = line[0];
            switch (val)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5': break;
                default: throw new System.Exception("Invalid action");
            }
            return val;
        }

        private FixVersion QueryVersion()
        {
            Console.WriteLine();
            Console.WriteLine("1) FIX.4.0");
            Console.WriteLine("2) FIX.4.1");
            Console.WriteLine("3) FIX.4.2");
            Console.WriteLine("4) FIX.4.3");
            Console.WriteLine("5) FIX.4.4");
            Console.WriteLine("6) FIXT1.1 (FIX.5.0)");
            Console.Write("BeginString: ");

            string line = Console.ReadLine().Trim();

            switch (line)
            {
                case "1": return FixVersion.FIX40;
                case "2": return FixVersion.FIX41;
                case "3": return FixVersion.FIX42;
                case "4": return FixVersion.FIX43;
                case "5": return FixVersion.FIX44;
                case "6": return FixVersion.FIX50;
            }

            throw new System.Exception("Invalid action");
        }

        private void QueryEnterOrder()
        {
            FixVersion v = QueryVersion();
            Console.WriteLine("\nNewOrderSingle");

            Message m = null;
            switch (v)
            {
                case FixVersion.FIX42:
                    m = QueryNewOrderSingle42();
                    break;
                case FixVersion.FIX40:
                case FixVersion.FIX41:
                case FixVersion.FIX43:
                case FixVersion.FIX44:
                case FixVersion.FIX50:
                    Console.WriteLine("not supported yet for version " + v.ToString());
                    return;
            }

            if (m != null && QueryConfirm("Send order"))
            {
                m.Header.GetField(Tags.BeginString);

                QuickFix.Session.SendToTarget(m);
            }
        }

        private void QueryCancelOrder()
        {
            FixVersion v = QueryVersion();
            Console.WriteLine("\nOrderCancelRequest");

            Message m = null;
            switch (v)
            {
                case FixVersion.FIX42:
                    m = QueryOrderCancelRequest42();
                    break;
                case FixVersion.FIX40:
                case FixVersion.FIX41:
                case FixVersion.FIX43:
                case FixVersion.FIX44:
                case FixVersion.FIX50:
                    Console.WriteLine("not supported yet for version " + v.ToString());
                    return;
            }

            if (m != null && QueryConfirm("Cancel order"))
                QuickFix.Session.SendToTarget(m);
        }

        private void QueryReplaceOrder()
        {
            FixVersion v = QueryVersion();
            Console.WriteLine("\nCancelReplaceRequest");

            Message m = null;
            switch (v)
            {
                case FixVersion.FIX42:
                    m = QueryCancelReplaceRequest42();
                    break;
                case FixVersion.FIX40:
                case FixVersion.FIX41:
                case FixVersion.FIX43:
                case FixVersion.FIX44:
                case FixVersion.FIX50:
                    Console.WriteLine("not supported yet for version " + v.ToString());
                    return;
            }

            if (m != null && QueryConfirm("Send replace"))
                QuickFix.Session.SendToTarget(m);
        }

        private void QueryMarketDataRequest()
        {
            FixVersion v = QueryVersion();
            Console.WriteLine("\nMarketDataRequest");

            Message m = null;
            switch (v)
            {
                case FixVersion.FIX42:
                    m = QueryMarketDataRequest42();
                    break;
                case FixVersion.FIX40:
                case FixVersion.FIX41:
                case FixVersion.FIX43:
                case FixVersion.FIX44:
                case FixVersion.FIX50:
                    Console.WriteLine("not supported yet for version " + v.ToString());
                    return;
            }

            if (m != null && QueryConfirm("Send market data request"))
                QuickFix.Session.SendToTarget(m);
        }

        private bool QueryConfirm(string query)
        {
            Console.WriteLine();
            Console.WriteLine(query + "?: ");
            string line = Console.ReadLine().Trim();
            return (line[0].Equals('y') || line[0].Equals('Y'));
        }


        private QuickFix.FIX42.NewOrderSingle QueryNewOrderSingle42()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX42.NewOrderSingle newOrderSingle = new QuickFix.FIX42.NewOrderSingle(
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                ordType = QueryOrdType());

            newOrderSingle.set(QueryOrderQty());
            newOrderSingle.set(QueryTimeInForce());
            if (ordType.getValue() == OrdType.LIMIT || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryPrice());
            if (ordType.getValue() == OrdType.STOP || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryStopPx());

            QueryHeader(newOrderSingle.Header);
            return newOrderSingle;
        }

        private QuickFix.FIX42.OrderCancelRequest QueryOrderCancelRequest42()
        {
            QuickFix.FIX42.OrderCancelRequest orderCancelRequest = new QuickFix.FIX42.OrderCancelRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now));

            orderCancelRequest.set(QueryOrderQty());
            QueryHeader(orderCancelRequest.Header);
            return orderCancelRequest;
        }

        private QuickFix.FIX42.OrderCancelReplaceRequest QueryCancelReplaceRequest42()
        {
            QuickFix.FIX42.OrderCancelReplaceRequest ocrr = new QuickFix.FIX42.OrderCancelReplaceRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                QueryOrdType());

            if(QueryConfirm("New price"))
                ocrr.set( QueryPrice());
            if(QueryConfirm("New quantity"))
                ocrr.set(QueryOrderQty());

            QueryHeader(ocrr.Header);
            return ocrr;
        }

        private QuickFix.FIX42.MarketDataRequest QueryMarketDataRequest42()
        {
            MDReqID mdReqID = new MDReqID( "MARKETDATAID" );
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT);
            MarketDepth marketDepth = new MarketDepth(0);

            QuickFix.FIX42.MarketDataRequest.NoMDEntryTypes marketDataEntryGroup = new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypes();
            marketDataEntryGroup.set( new MDEntryType(MDEntryType.BID) );

            QuickFix.FIX42.MarketDataRequest.NoRelatedSym symbolGroup = new QuickFix.FIX42.MarketDataRequest.NoRelatedSym();
            symbolGroup.set(new Symbol("LNUX"));

            QuickFix.FIX42.MarketDataRequest message = new QuickFix.FIX42.MarketDataRequest( mdReqID, subType, marketDepth );
            message.AddGroup( marketDataEntryGroup );
            message.AddGroup( symbolGroup );

            QueryHeader( message.Header );

            Console.WriteLine(message.ToString());
            return message;
        }


        #region field query private methods
        private ClOrdID QueryClOrdID()
        {
            Console.WriteLine();
            Console.Write("ClOrdID? ");
            return new ClOrdID(Console.ReadLine().Trim());
        }

        private OrigClOrdID QueryOrigClOrdID()
        {
            Console.WriteLine();
            Console.Write("OrigClOrdID? ");
            return new OrigClOrdID(Console.ReadLine().Trim());
        }

        private Symbol QuerySymbol()
        {
            Console.WriteLine();
            Console.Write("Symbol? ");
            return new Symbol(Console.ReadLine().Trim());
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
            string s = Console.ReadLine().Trim();

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
            string s = Console.ReadLine().Trim();

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
            return new OrderQty(Convert.ToDecimal(Console.ReadLine().Trim()));
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
            string s = Console.ReadLine().Trim();

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
            return new Price(Convert.ToDecimal(Console.ReadLine().Trim()));
        }

        private StopPx QueryStopPx()
        {
            Console.WriteLine();
            Console.Write("StopPx? ");
            return new StopPx(Convert.ToDecimal(Console.ReadLine().Trim()));
        }

        private void QueryHeader(Header h)
        {
            h.setField(QuerySenderCompID());
            h.setField(QueryTargetCompID());
            if (QueryConfirm("Use a TargetSubID"))
                h.setField(QueryTargetSubID());
        }

        private SenderCompID QuerySenderCompID()
        {
            Console.WriteLine();
            Console.WriteLine("SenderCompID? ");
            return new SenderCompID(Console.ReadLine().Trim());
        }

        private TargetCompID QueryTargetCompID()
        {
            Console.WriteLine();
            Console.WriteLine("TargetCompID? ");
            return new TargetCompID(Console.ReadLine().Trim());
        }

        private TargetSubID QueryTargetSubID()
        {
            Console.WriteLine();
            Console.WriteLine("TargetSubID? ");
            return new TargetSubID(Console.ReadLine().Trim());
        }
        #endregion
    }
}
