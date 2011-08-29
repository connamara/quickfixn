using System;
using QuickFix;

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
                }
            }
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
                QuickFix.Session.SendToTarget(m);
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
            throw new System.NotImplementedException("not done");
        }

        private QuickFix.FIX42.OrderCancelRequest QueryOrderCancelRequest42()
        {
            throw new System.NotImplementedException("not done");
        }

        private QuickFix.FIX42.OrderCancelReplaceRequest QueryCancelReplaceRequest42()
        {
            throw new System.NotImplementedException("not done");
        }

        private QuickFix.FIX42.MarketDataRequest QueryMarketDataRequest42()
        {
            throw new System.NotImplementedException("not done");
        }
    }
}
