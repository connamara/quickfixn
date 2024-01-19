using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix;
using QuickFix.Fields;

namespace Executor
{
    public class Executor : QuickFix.MessageCracker, QuickFix.IApplication
    {
        static readonly decimal DEFAULT_MARKET_PRICE = 10;

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
        public void OnMessage(QuickFix.FIX40.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.Symbol;
            Side side = n.Side;
            OrdType ordType = n.OrdType;
            OrderQty orderQty = n.OrderQty;
            Price price = new Price(DEFAULT_MARKET_PRICE);
            ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX40.ExecutionReport exReport = new QuickFix.FIX40.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecTransType(ExecTransType.NEW),
                new OrdStatus(OrdStatus.FILLED),
                symbol,
                side,
                orderQty,
                new LastShares(orderQty.getValue()),
                new LastPx(price.getValue()),
                new CumQty(orderQty.getValue()),
                new AvgPx(price.getValue()));

            exReport.Set(clOrdID);

            if (n.IsSetAccount())
                exReport.SetField(n.Account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX41.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.Symbol;
            Side side = n.Side;
            OrdType ordType = n.OrdType;
            OrderQty orderQty = n.OrderQty;
            Price price = new Price(DEFAULT_MARKET_PRICE);
            ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX41.ExecutionReport exReport = new QuickFix.FIX41.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecTransType(ExecTransType.NEW),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                symbol,
                side,
                orderQty,
                new LastShares(orderQty.getValue()),
                new LastPx(price.getValue()),
                new LeavesQty(0),
                new CumQty(orderQty.getValue()),
                new AvgPx(price.getValue()));

            exReport.Set(clOrdID);

            if (n.IsSetAccount())
                exReport.SetField(n.Account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX42.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.Symbol;
            Side side = n.Side;
            OrdType ordType = n.OrdType;
            OrderQty orderQty = n.OrderQty;
            ClOrdID clOrdID = n.ClOrdID;
            Price price = new Price(DEFAULT_MARKET_PRICE);

            switch (ordType.getValue())
            {
                case OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX42.ExecutionReport exReport = new QuickFix.FIX42.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecTransType(ExecTransType.NEW),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                symbol,
                side,
                new LeavesQty(0),
                new CumQty(orderQty.getValue()),
                new AvgPx(price.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(orderQty);
            exReport.Set(new LastShares(orderQty.getValue()));
            exReport.Set(new LastPx(price.getValue()));

            if (n.IsSetAccount())
                exReport.SetField(n.Account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX43.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.Symbol;
            Side side = n.Side;
            OrdType ordType = n.OrdType;
            OrderQty orderQty = n.OrderQty;
            Price price = new Price(DEFAULT_MARKET_PRICE);
            ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX43.ExecutionReport exReport = new QuickFix.FIX43.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                symbol, // Shouldn't be here?
                side,
                new LeavesQty(0),
                new CumQty(orderQty.getValue()),
                new AvgPx(price.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(symbol);
            exReport.Set(orderQty);
            exReport.Set(new LastQty(orderQty.getValue()));
            exReport.Set(new LastPx(price.getValue()));

            if (n.IsSetAccount())
                exReport.SetField(n.Account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX44.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.Symbol;
            Side side = n.Side;
            OrdType ordType = n.OrdType;
            OrderQty orderQty = n.OrderQty;
            Price price = new Price(DEFAULT_MARKET_PRICE);
            ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX44.ExecutionReport exReport = new QuickFix.FIX44.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                symbol, //shouldn't be here?
                side,
                new LeavesQty(0),
                new CumQty(orderQty.getValue()),
                new AvgPx(price.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(symbol);
            exReport.Set(orderQty);
            exReport.Set(new LastQty(orderQty.getValue()));
            exReport.Set(new LastPx(price.getValue()));

            if (n.IsSetAccount())
                exReport.SetField(n.Account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX50.NewOrderSingle n, SessionID s)
        {
            Symbol symbol = n.Symbol;
            Side side = n.Side;
            OrdType ordType = n.OrdType;
            OrderQty orderQty = n.OrderQty;
            Price price = new Price(DEFAULT_MARKET_PRICE);
            ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX50.ExecutionReport exReport = new QuickFix.FIX50.ExecutionReport(
                new OrderID(GenOrderID()),
                new ExecID(GenExecID()),
                new ExecType(ExecType.FILL),
                new OrdStatus(OrdStatus.FILLED),
                side,
                new LeavesQty(0),
                new CumQty(orderQty.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(symbol);
            exReport.Set(orderQty);
            exReport.Set(new LastQty(orderQty.getValue()));
            exReport.Set(new LastPx(price.getValue()));
            exReport.Set(new AvgPx(price.getValue()));

            if (n.IsSetAccount())
                exReport.SetField(n.Account);

            try
            {
                Session.SendToTarget(exReport, s);
            }
            catch (SessionNotFound ex)
            {
                Console.WriteLine("==session not found exception!==");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX40.News n, SessionID s) { }
        public void OnMessage(QuickFix.FIX41.News n, SessionID s) { }
        public void OnMessage(QuickFix.FIX42.News n, SessionID s) { }
        public void OnMessage(QuickFix.FIX43.News n, SessionID s) { }
        public void OnMessage(QuickFix.FIX44.News n, SessionID s) { }
        public void OnMessage(QuickFix.FIX50.News n, SessionID s) { }

        public void OnMessage(QuickFix.FIX40.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX40.OrderCancelReject ocj = new QuickFix.FIX40.OrderCancelReject(new OrderID(orderid), msg.ClOrdID);
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancels");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX41.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX41.OrderCancelReject ocj = new QuickFix.FIX41.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancels");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX42.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX42.OrderCancelReject ocj = new QuickFix.FIX42.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancels");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX43.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX43.OrderCancelReject ocj = new QuickFix.FIX43.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancels");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX44.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX44.OrderCancelReject ocj = new QuickFix.FIX44.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.OTHER);
            ocj.Text = new Text("Executor does not support order cancels");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX50.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX50.OrderCancelReject ocj = new QuickFix.FIX50.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.OTHER);
            ocj.Text = new Text("Executor does not support order cancels");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



        public void OnMessage(QuickFix.FIX40.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX40.OrderCancelReject ocj = new QuickFix.FIX40.OrderCancelReject(new OrderID(orderid), msg.ClOrdID);
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancel/replaces");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX41.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX41.OrderCancelReject ocj = new QuickFix.FIX41.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancel/replaces");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX42.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX42.OrderCancelReject ocj = new QuickFix.FIX42.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancel/replaces");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX43.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX43.OrderCancelReject ocj = new QuickFix.FIX43.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.UNKNOWN_ORDER);
            ocj.Text = new Text("Executor does not support order cancel/replaces");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX44.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX44.OrderCancelReject ocj = new QuickFix.FIX44.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.OTHER);
            ocj.Text = new Text("Executor does not support order cancel/replaces");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void OnMessage(QuickFix.FIX50.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX50.OrderCancelReject ocj = new QuickFix.FIX50.OrderCancelReject(
                new OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new OrdStatus(OrdStatus.REJECTED), new CxlRejResponseTo(CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new CxlRejReason(CxlRejReason.OTHER);
            ocj.Text = new Text("Executor does not support order cancel/replaces");

            try
            {
                Session.SendToTarget(ocj, s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }




        // FIX40-41 don't have rejects
        public void OnMessage(QuickFix.FIX42.BusinessMessageReject n, SessionID s) { }
        public void OnMessage(QuickFix.FIX43.BusinessMessageReject n, SessionID s) { }
        public void OnMessage(QuickFix.FIX44.BusinessMessageReject n, SessionID s) { }
        public void OnMessage(QuickFix.FIX50.BusinessMessageReject n, SessionID s) { }


        #endregion //MessageCracker overloads
    }
}