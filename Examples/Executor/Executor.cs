using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix;
using QuickFix.Fields;

namespace Executor
{
    public class Executor : QuickFix.MessageCracker, QuickFix.Application
    {
        int orderID = 0;
        int execID = 0;

        private string GenOrderID() { return (++orderID).ToString(); }
        private string GenExecID() { return (++execID).ToString(); }
        
        #region QuickFix.Application Methods

        public void FromApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("IN:  " + message);
            Crack(message, sessionID);
        }

        public void ToApp(Message message, SessionID sessionID)
        {
            Console.WriteLine("OUT: " + message);
        }

        public void FromAdmin(Message message, SessionID sessionID) { }
        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }
        #endregion

        #region MessageCracker overloads
        public void OnMessage(QuickFix.FIX40.NewOrderSingle n, SessionID s) { Console.WriteLine("cracked!"); }
        public void OnMessage(QuickFix.FIX41.NewOrderSingle n, SessionID s) { Console.WriteLine("cracked!"); }

        public void OnMessage(QuickFix.FIX42.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.symbol;
            Side side = new Side(n.GetField(QuickFix.Fields.Tags.Side)[0]); // TODO workaround
            OrdType ordType = new OrdType(n.GetField(QuickFix.Fields.Tags.OrdType)[0]); // TODO workaround
            OrderQty orderQty = new OrderQty(Convert.ToDecimal(n.GetField(QuickFix.Fields.Tags.OrderQty))); // TODO workaround
            Price price = new Price(Convert.ToDecimal(n.GetField(QuickFix.Fields.Tags.Price))); // TODO workaround
            ClOrdID clOrdID = n.clOrdID;

            if (ordType.getValue() != OrdType.LIMIT)
                throw new IncorrectTagValue(ordType.Tag);

            QuickFix.FIX42.ExecutionReport exReport = new QuickFix.FIX42.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecTransType(ExecTransType.NEW),
                new ExecType(ExecType.NEW),
                new OrdStatus(OrdStatus.FILLED),
                symbol,
                side,
                new LeavesQty(0),
                new CumQty(orderQty.getValue()),
                new AvgPx(price.getValue()));

            exReport.set(clOrdID);

            if (n.isSetAccount())
                exReport.setField(n.account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("==unknown exception==");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void OnMessage(QuickFix.FIX43.NewOrderSingle n, SessionID s) { Console.WriteLine("cracked!"); }
        public void OnMessage(QuickFix.FIX44.NewOrderSingle n, SessionID s) { Console.WriteLine("cracked!"); }
        public void OnMessage(QuickFix.FIX50.NewOrderSingle n, SessionID s) { Console.WriteLine("cracked!"); }
        #endregion
    }
}