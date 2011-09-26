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

        public void FromAdmin(Message message, SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }

        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("IN:  " + message.ToString());
            try
            {
                Crack(message, sessionID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("==Cracker exception==");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
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
        public void OnMessage(QuickFix.FIX40.ExecutionReport m, SessionID s) { Console.WriteLine("Received execution report"); }
        public void OnMessage(QuickFix.FIX41.ExecutionReport m, SessionID s) { Console.WriteLine("Received execution report"); }
        public void OnMessage(QuickFix.FIX43.ExecutionReport m, SessionID s) { Console.WriteLine("Received execution report"); }
        public void OnMessage(QuickFix.FIX44.ExecutionReport m, SessionID s) { Console.WriteLine("Received execution report"); }
        public void OnMessage(QuickFix.FIX50.ExecutionReport m, SessionID s) { Console.WriteLine("Received execution report"); }
        public void OnMessage(QuickFix.FIX42.ExecutionReport m, SessionID s) { Console.WriteLine("Received execution report"); }

        public void OnMessage(QuickFix.FIX42.OrderCancelReject m, SessionID s) { Console.WriteLine("Received order cancel reject"); }
        public void OnMessage(QuickFix.FIX40.OrderCancelReject m, SessionID s) { Console.WriteLine("Received order cancel reject"); }
        public void OnMessage(QuickFix.FIX41.OrderCancelReject m, SessionID s) { Console.WriteLine("Received order cancel reject"); }
        public void OnMessage(QuickFix.FIX43.OrderCancelReject m, SessionID s) { Console.WriteLine("Received order cancel reject"); }
        public void OnMessage(QuickFix.FIX44.OrderCancelReject m, SessionID s) { Console.WriteLine("Received order cancel reject"); }
        public void OnMessage(QuickFix.FIX50.OrderCancelReject m, SessionID s) { Console.WriteLine("Received order cancel reject"); }
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
                case FixVersion.FIX40:
                    m = QueryNewOrderSingle40();
                    break;
                case FixVersion.FIX41:
                    m = QueryNewOrderSingle41();
                    break;
                case FixVersion.FIX42:
                    m = QueryNewOrderSingle42();
                    break;
                case FixVersion.FIX43:
                    m = QueryNewOrderSingle43();
                    break;
                case FixVersion.FIX44:
                    m = QueryNewOrderSingle44();
                    break;
                case FixVersion.FIX50:
                    m = QueryNewOrderSingle50();
                    break;
                default:
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
                case FixVersion.FIX40:
                    m = QueryOrderCancelRequest40();
                    break;
                case FixVersion.FIX41:
                    m = QueryOrderCancelRequest41();
                    break;
                case FixVersion.FIX42:
                    m = QueryOrderCancelRequest42();
                    break;
                case FixVersion.FIX43:
                    m = QueryOrderCancelRequest43();
                    break;
                case FixVersion.FIX44:
                    m = QueryOrderCancelRequest44();
                    break;
                case FixVersion.FIX50:
                    m = QueryOrderCancelRequest50();
                    break;
                default:
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
                case FixVersion.FIX40:
                    m = QueryCancelReplaceRequest40();
                    break;
                case FixVersion.FIX41:
                    m = QueryCancelReplaceRequest41();
                    break;
                case FixVersion.FIX42:
                    m = QueryCancelReplaceRequest42();
                    break;
                case FixVersion.FIX43:
                    m = QueryCancelReplaceRequest43();
                    break;
                case FixVersion.FIX44:
                    m = QueryCancelReplaceRequest44();
                    break;
                case FixVersion.FIX50:
                    m = QueryCancelReplaceRequest50();
                    break; 
                default:
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
                case FixVersion.FIX40:
                case FixVersion.FIX41:
                    Console.WriteLine("FIX 4.0 and 4.1 don't have this message type.");
                    break;
                case FixVersion.FIX42:
                    m = QueryMarketDataRequest42();
                    break;
                case FixVersion.FIX43:
                    m = QueryMarketDataRequest43();
                    break;
                case FixVersion.FIX44:
                    m = QueryMarketDataRequest44();
                    break;
                case FixVersion.FIX50:
                    m = QueryMarketDataRequest50();
                    break;
                default:
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

        #region QueryNewOrderSingleNN
        private QuickFix.FIX40.NewOrderSingle QueryNewOrderSingle40()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX40.NewOrderSingle newOrderSingle = new QuickFix.FIX40.NewOrderSingle(
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                QueryOrderQty(),
                ordType = QueryOrdType());

            newOrderSingle.set(QueryTimeInForce());
            if (ordType.getValue() == OrdType.LIMIT || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryPrice());
            if (ordType.getValue() == OrdType.STOP || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryStopPx());

            QueryHeader(newOrderSingle.Header);
            return newOrderSingle;
        }

        private QuickFix.FIX41.NewOrderSingle QueryNewOrderSingle41()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX41.NewOrderSingle newOrderSingle = new QuickFix.FIX41.NewOrderSingle(
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
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

        private QuickFix.FIX43.NewOrderSingle QueryNewOrderSingle43()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX43.NewOrderSingle newOrderSingle = new QuickFix.FIX43.NewOrderSingle(
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

        private QuickFix.FIX44.NewOrderSingle QueryNewOrderSingle44()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX44.NewOrderSingle newOrderSingle = new QuickFix.FIX44.NewOrderSingle(
                QueryClOrdID(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                ordType = QueryOrdType());

            newOrderSingle.set(new HandlInst('1'));
            newOrderSingle.set(QueryOrderQty());
            newOrderSingle.set(QueryTimeInForce());
            if (ordType.getValue() == OrdType.LIMIT || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryPrice());
            if (ordType.getValue() == OrdType.STOP || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryStopPx());

            QueryHeader(newOrderSingle.Header);
            return newOrderSingle;
        }

        private QuickFix.FIX50.NewOrderSingle QueryNewOrderSingle50()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX50.NewOrderSingle newOrderSingle = new QuickFix.FIX50.NewOrderSingle(
                QueryClOrdID(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                ordType = QueryOrdType());

            newOrderSingle.set(new HandlInst('1'));
            newOrderSingle.set(QuerySymbol());
            newOrderSingle.set(QueryOrderQty());
            newOrderSingle.set(QueryTimeInForce());
            if (ordType.getValue() == OrdType.LIMIT || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryPrice());
            if (ordType.getValue() == OrdType.STOP || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.set(QueryStopPx());

            QueryHeader(newOrderSingle.Header);
            return newOrderSingle;
        }
        #endregion

        #region QueryOrderCancelRequestNN
        private QuickFix.FIX40.OrderCancelRequest QueryOrderCancelRequest40()
        {
            QuickFix.FIX40.OrderCancelRequest orderCancelRequest = new QuickFix.FIX40.OrderCancelRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                new CxlType(CxlType.FULL_REMAINING_QUANTITY),
                QuerySymbol(),
                QuerySide(),
                QueryOrderQty());

            QueryHeader(orderCancelRequest.Header);
            return orderCancelRequest;
        }

        private QuickFix.FIX41.OrderCancelRequest QueryOrderCancelRequest41()
        {
            QuickFix.FIX41.OrderCancelRequest orderCancelRequest = new QuickFix.FIX41.OrderCancelRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySymbol(),
                QuerySide());

            orderCancelRequest.set(QueryOrderQty());
            QueryHeader(orderCancelRequest.Header);
            return orderCancelRequest;
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

        private QuickFix.FIX43.OrderCancelRequest QueryOrderCancelRequest43()
        {
            QuickFix.FIX43.OrderCancelRequest orderCancelRequest = new QuickFix.FIX43.OrderCancelRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now));

            orderCancelRequest.set(QueryOrderQty());
            QueryHeader(orderCancelRequest.Header);
            return orderCancelRequest;
        }

        private QuickFix.FIX44.OrderCancelRequest QueryOrderCancelRequest44()
        {
            QuickFix.FIX44.OrderCancelRequest orderCancelRequest = new QuickFix.FIX44.OrderCancelRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now));

            orderCancelRequest.set(QueryOrderQty());
            QueryHeader(orderCancelRequest.Header);
            return orderCancelRequest;
        }

        private QuickFix.FIX50.OrderCancelRequest QueryOrderCancelRequest50()
        {
            QuickFix.FIX50.OrderCancelRequest orderCancelRequest = new QuickFix.FIX50.OrderCancelRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySide(),
                new TransactTime(DateTime.Now));

            orderCancelRequest.set(QuerySymbol());
            orderCancelRequest.set(QueryOrderQty());
            QueryHeader(orderCancelRequest.Header);
            return orderCancelRequest;
        }
        #endregion

        #region QueryCancelReplaceRequestNN
        private QuickFix.FIX40.OrderCancelReplaceRequest QueryCancelReplaceRequest40()
        {
            QuickFix.FIX40.OrderCancelReplaceRequest ocrr = new QuickFix.FIX40.OrderCancelReplaceRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                QueryOrderQty(),
                QueryOrdType());

            if (QueryConfirm("New price"))
                ocrr.set(QueryPrice());
            if (QueryConfirm("New quantity"))
                ocrr.set(QueryOrderQty());

            QueryHeader(ocrr.Header);
            return ocrr;
        }

        private QuickFix.FIX41.OrderCancelReplaceRequest QueryCancelReplaceRequest41()
        {
            QuickFix.FIX41.OrderCancelReplaceRequest ocrr = new QuickFix.FIX41.OrderCancelReplaceRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                QueryOrdType());

            if (QueryConfirm("New price"))
                ocrr.set(QueryPrice());
            if (QueryConfirm("New quantity"))
                ocrr.set(QueryOrderQty());

            QueryHeader(ocrr.Header);
            return ocrr;
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

        private QuickFix.FIX43.OrderCancelReplaceRequest QueryCancelReplaceRequest43()
        {
            QuickFix.FIX43.OrderCancelReplaceRequest ocrr = new QuickFix.FIX43.OrderCancelReplaceRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                QueryOrdType());

            if (QueryConfirm("New price"))
                ocrr.set(QueryPrice());
            if (QueryConfirm("New quantity"))
                ocrr.set(QueryOrderQty());

            QueryHeader(ocrr.Header);
            return ocrr;
        }

        private QuickFix.FIX44.OrderCancelReplaceRequest QueryCancelReplaceRequest44()
        {
            QuickFix.FIX44.OrderCancelReplaceRequest ocrr = new QuickFix.FIX44.OrderCancelReplaceRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                QueryOrdType());

            ocrr.set(new HandlInst('1'));
            if (QueryConfirm("New price"))
                ocrr.set(QueryPrice());
            if (QueryConfirm("New quantity"))
                ocrr.set(QueryOrderQty());

            QueryHeader(ocrr.Header);
            return ocrr;
        }

        private QuickFix.FIX50.OrderCancelReplaceRequest QueryCancelReplaceRequest50()
        {
            QuickFix.FIX50.OrderCancelReplaceRequest ocrr = new QuickFix.FIX50.OrderCancelReplaceRequest(
                QueryOrigClOrdID(),
                QueryClOrdID(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                QueryOrdType());

            ocrr.set(new HandlInst('1'));
            ocrr.set(QuerySymbol());
            if (QueryConfirm("New price"))
                ocrr.set(QueryPrice());
            if (QueryConfirm("New quantity"))
                ocrr.set(QueryOrderQty());

            QueryHeader(ocrr.Header);
            return ocrr;
        }
        #endregion

        #region QueryMarketDataRequestNN
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

        private QuickFix.FIX43.MarketDataRequest QueryMarketDataRequest43()
        {
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT);
            MarketDepth marketDepth = new MarketDepth(0);

            QuickFix.FIX43.MarketDataRequest.NoMDEntryTypes marketDataEntryGroup = new QuickFix.FIX43.MarketDataRequest.NoMDEntryTypes();
            marketDataEntryGroup.set(new MDEntryType(MDEntryType.BID));

            QuickFix.FIX43.MarketDataRequest.NoRelatedSym symbolGroup = new QuickFix.FIX43.MarketDataRequest.NoRelatedSym();
            symbolGroup.set(new Symbol("LNUX"));

            QuickFix.FIX43.MarketDataRequest message = new QuickFix.FIX43.MarketDataRequest(mdReqID, subType, marketDepth);
            message.AddGroup(marketDataEntryGroup);
            message.AddGroup(symbolGroup);

            QueryHeader(message.Header);

            Console.WriteLine(message.ToString());
            return message;
        }

        private QuickFix.FIX44.MarketDataRequest QueryMarketDataRequest44()
        {
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT);
            MarketDepth marketDepth = new MarketDepth(0);

            QuickFix.FIX44.MarketDataRequest.NoMDEntryTypes marketDataEntryGroup = new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypes();
            marketDataEntryGroup.set(new MDEntryType(MDEntryType.BID));

            QuickFix.FIX44.MarketDataRequest.NoRelatedSym symbolGroup = new QuickFix.FIX44.MarketDataRequest.NoRelatedSym();
            symbolGroup.set(new Symbol("LNUX"));

            QuickFix.FIX44.MarketDataRequest message = new QuickFix.FIX44.MarketDataRequest(mdReqID, subType, marketDepth);
            message.AddGroup(marketDataEntryGroup);
            message.AddGroup(symbolGroup);

            QueryHeader(message.Header);

            Console.WriteLine(message.ToString());
            return message;
        }

        private QuickFix.FIX50.MarketDataRequest QueryMarketDataRequest50()
        {
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT);
            MarketDepth marketDepth = new MarketDepth(0);

            QuickFix.FIX50.MarketDataRequest.NoMDEntryTypes marketDataEntryGroup = new QuickFix.FIX50.MarketDataRequest.NoMDEntryTypes();
            marketDataEntryGroup.set(new MDEntryType(MDEntryType.BID));

            QuickFix.FIX50.MarketDataRequest.NoRelatedSym symbolGroup = new QuickFix.FIX50.MarketDataRequest.NoRelatedSym();
            symbolGroup.set(new Symbol("LNUX"));

            QuickFix.FIX50.MarketDataRequest message = new QuickFix.FIX50.MarketDataRequest(mdReqID, subType, marketDepth);
            message.AddGroup(marketDataEntryGroup);
            message.AddGroup(symbolGroup);

            QueryHeader(message.Header);

            Console.WriteLine(message.ToString());
            return message;
        }
        #endregion


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
