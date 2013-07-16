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
        private void OnMessage(QuickFix.FIX40.NewOrderSingle n, SessionID s)
        {
            QuickFix.FIX40.Fields.Symbol symbol = n.Symbol;
            QuickFix.FIX40.Fields.Side side = n.Side;
            QuickFix.FIX40.Fields.OrdType ordType = n.OrdType;
            QuickFix.FIX40.Fields.OrderQty orderQty = n.OrderQty;
            QuickFix.FIX40.Fields.Price price = new QuickFix.FIX40.Fields.Price(DEFAULT_MARKET_PRICE);
            QuickFix.FIX40.Fields.ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case QuickFix.FIX40.Fields.OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case QuickFix.FIX40.Fields.OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX40.ExecutionReport exReport = new QuickFix.FIX40.ExecutionReport(
                new QuickFix.FIX40.Fields.OrderID(GenOrderID()),
                new QuickFix.FIX40.Fields.ExecID(int.Parse(GenExecID())),
                new QuickFix.FIX40.Fields.ExecTransType(QuickFix.FIX40.Fields.ExecTransType.NEW),
                new QuickFix.FIX40.Fields.OrdStatus(QuickFix.FIX40.Fields.OrdStatus.FILLED),
                symbol,
                side,
                orderQty,
                new QuickFix.FIX40.Fields.LastShares(orderQty.getValue()),
                new QuickFix.FIX40.Fields.LastPx(price.getValue()),
                new QuickFix.FIX40.Fields.CumQty(orderQty.getValue()),
                new QuickFix.FIX40.Fields.AvgPx(price.getValue()));

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

        private void OnMessage(QuickFix.FIX41.NewOrderSingle n, SessionID s)
        {
            QuickFix.FIX41.Fields.Symbol symbol = n.Symbol;
            QuickFix.FIX41.Fields.Side side = n.Side;
            QuickFix.FIX41.Fields.OrdType ordType = n.OrdType;
            QuickFix.FIX41.Fields.OrderQty orderQty = n.OrderQty;
            QuickFix.FIX41.Fields.Price price = new QuickFix.FIX41.Fields.Price(DEFAULT_MARKET_PRICE);
            QuickFix.FIX41.Fields.ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case QuickFix.FIX41.Fields.OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case QuickFix.FIX41.Fields.OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX41.ExecutionReport exReport = new QuickFix.FIX41.ExecutionReport(
                new QuickFix.FIX41.Fields.OrderID(GenOrderID()),
                new QuickFix.FIX41.Fields.ExecID(GenExecID()),
                new QuickFix.FIX41.Fields.ExecTransType(QuickFix.FIX41.Fields.ExecTransType.NEW),
                new QuickFix.FIX41.Fields.ExecType(QuickFix.FIX41.Fields.ExecType.FILL),
                new QuickFix.FIX41.Fields.OrdStatus(QuickFix.FIX41.Fields.OrdStatus.FILLED),
                symbol,
                side,
                orderQty,
                new QuickFix.FIX41.Fields.LastShares(orderQty.getValue()),
                new QuickFix.FIX41.Fields.LastPx(price.getValue()),
                new QuickFix.FIX41.Fields.LeavesQty(0),
                new QuickFix.FIX41.Fields.CumQty(orderQty.getValue()),
                new QuickFix.FIX41.Fields.AvgPx(price.getValue()));

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

        private void OnMessage(QuickFix.FIX42.NewOrderSingle n, SessionID s)
        {
            QuickFix.FIX42.Fields.Symbol symbol = n.Symbol;
            QuickFix.FIX42.Fields.Side side = n.Side;
            QuickFix.FIX42.Fields.OrdType ordType = n.OrdType;
            QuickFix.FIX42.Fields.OrderQty orderQty = n.OrderQty;
            QuickFix.FIX42.Fields.ClOrdID clOrdID = n.ClOrdID;
            QuickFix.FIX42.Fields.Price price = new QuickFix.FIX42.Fields.Price(DEFAULT_MARKET_PRICE);

            switch (ordType.getValue())
            {
                case QuickFix.FIX42.Fields.OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case QuickFix.FIX42.Fields.OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX42.ExecutionReport exReport = new QuickFix.FIX42.ExecutionReport(
                new QuickFix.FIX42.Fields.OrderID(GenOrderID()),
                new QuickFix.FIX42.Fields.ExecID(GenExecID()),
                new QuickFix.FIX42.Fields.ExecTransType(QuickFix.FIX42.Fields.ExecTransType.NEW),
                new QuickFix.FIX42.Fields.ExecType(QuickFix.FIX42.Fields.ExecType.FILL),
                new QuickFix.FIX42.Fields.OrdStatus(QuickFix.FIX42.Fields.OrdStatus.FILLED),
                symbol,
                side,
                new QuickFix.FIX42.Fields.LeavesQty(0),
                new QuickFix.FIX42.Fields.CumQty(orderQty.getValue()),
                new QuickFix.FIX42.Fields.AvgPx(price.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(orderQty);
            exReport.Set(new QuickFix.FIX42.Fields.LastShares(orderQty.getValue()));
            exReport.Set(new QuickFix.FIX42.Fields.LastPx(price.getValue()));

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

        private void OnMessage(QuickFix.FIX43.NewOrderSingle n, SessionID s)
        {
            QuickFix.FIX43.Fields.Symbol symbol = n.Symbol;
            QuickFix.FIX43.Fields.Side side = n.Side;
            QuickFix.FIX43.Fields.OrdType ordType = n.OrdType;
            QuickFix.FIX43.Fields.OrderQty orderQty = n.OrderQty;
            QuickFix.FIX43.Fields.Price price = new QuickFix.FIX43.Fields.Price(DEFAULT_MARKET_PRICE);
            QuickFix.FIX43.Fields.ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case QuickFix.FIX43.Fields.OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case QuickFix.FIX43.Fields.OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX43.ExecutionReport exReport = new QuickFix.FIX43.ExecutionReport(
                new QuickFix.FIX43.Fields.OrderID(GenOrderID()),
                new QuickFix.FIX43.Fields.ExecID(GenExecID()),
                new QuickFix.FIX43.Fields.ExecType(QuickFix.FIX43.Fields.ExecType.FILL),
                new QuickFix.FIX43.Fields.OrdStatus(QuickFix.FIX43.Fields.OrdStatus.FILLED),
                symbol, // Shouldn't be here?
                side,
                new QuickFix.FIX43.Fields.LeavesQty(0),
                new QuickFix.FIX43.Fields.CumQty(orderQty.getValue()),
                new QuickFix.FIX43.Fields.AvgPx(price.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(symbol);
            exReport.Set(orderQty);
            exReport.Set(new QuickFix.FIX43.Fields.LastQty(orderQty.getValue()));
            exReport.Set(new QuickFix.FIX43.Fields.LastPx(price.getValue()));

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

        private void OnMessage(QuickFix.FIX44.NewOrderSingle n, SessionID s)
        {
            QuickFix.FIX44.Fields.Symbol symbol = n.Symbol;
            QuickFix.FIX44.Fields.Side side = n.Side;
            QuickFix.FIX44.Fields.OrdType ordType = n.OrdType;
            QuickFix.FIX44.Fields.OrderQty orderQty = n.OrderQty;
            QuickFix.FIX44.Fields.Price price = new QuickFix.FIX44.Fields.Price(DEFAULT_MARKET_PRICE);
            QuickFix.FIX44.Fields.ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case QuickFix.FIX44.Fields.OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case QuickFix.FIX44.Fields.OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX44.ExecutionReport exReport = new QuickFix.FIX44.ExecutionReport(
                new QuickFix.FIX44.Fields.OrderID(GenOrderID()),
                new QuickFix.FIX44.Fields.ExecID(GenExecID()),
                new QuickFix.FIX44.Fields.ExecType(QuickFix.FIX44.Fields.ExecType.FILL),
                new QuickFix.FIX44.Fields.OrdStatus(QuickFix.FIX44.Fields.OrdStatus.FILLED),
                symbol, //shouldn't be here?
                side,
                new QuickFix.FIX44.Fields.LeavesQty(0),
                new QuickFix.FIX44.Fields.CumQty(orderQty.getValue()),
                new QuickFix.FIX44.Fields.AvgPx(price.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(symbol);
            exReport.Set(orderQty);
            exReport.Set(new QuickFix.FIX44.Fields.LastQty(orderQty.getValue()));
            exReport.Set(new QuickFix.FIX44.Fields.LastPx(price.getValue()));

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

        private void OnMessage(QuickFix.FIX50.NewOrderSingle n, SessionID s)
        {
            QuickFix.FIX50.Fields.Symbol symbol = n.Symbol;
            QuickFix.FIX50.Fields.Side side = n.Side;
            QuickFix.FIX50.Fields.OrdType ordType = n.OrdType;
            QuickFix.FIX50.Fields.OrderQty orderQty = n.OrderQty;
            QuickFix.FIX50.Fields.Price price = new QuickFix.FIX50.Fields.Price(DEFAULT_MARKET_PRICE);
            QuickFix.FIX50.Fields.ClOrdID clOrdID = n.ClOrdID;

            switch (ordType.getValue())
            {
                case QuickFix.FIX50.Fields.OrdType.LIMIT:
                    price = n.Price;
                    if (price.Obj == 0)
                        throw new IncorrectTagValue(price.Tag);
                    break;
                case QuickFix.FIX50.Fields.OrdType.MARKET: break;
                default: throw new IncorrectTagValue(ordType.Tag);
            }

            QuickFix.FIX50.ExecutionReport exReport = new QuickFix.FIX50.ExecutionReport(
                new QuickFix.FIX50.Fields.OrderID(GenOrderID()),
                new QuickFix.FIX50.Fields.ExecID(GenExecID()),
                // Fill or Partial Fill have replaced by Trade (https://fixspec.com/FIX/5.0/Execution-Report#ExecType)
                new QuickFix.FIX50.Fields.ExecType(QuickFix.FIX50.Fields.ExecType.TRADE), 
                new QuickFix.FIX50.Fields.OrdStatus(QuickFix.FIX50.Fields.OrdStatus.FILLED),
                side,
                new QuickFix.FIX50.Fields.LeavesQty(0),
                new QuickFix.FIX50.Fields.CumQty(orderQty.getValue()));

            exReport.Set(clOrdID);
            exReport.Set(symbol);
            exReport.Set(orderQty);
            exReport.Set(new QuickFix.FIX50.Fields.LastQty(orderQty.getValue()));
            exReport.Set(new QuickFix.FIX50.Fields.LastPx(price.getValue()));
            exReport.Set(new QuickFix.FIX50.Fields.AvgPx(price.getValue()));

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

        private void OnMessage(QuickFix.FIX40.News n, SessionID s) { }
        private void OnMessage(QuickFix.FIX41.News n, SessionID s) { }
        private void OnMessage(QuickFix.FIX42.News n, SessionID s) { }
        private void OnMessage(QuickFix.FIX43.News n, SessionID s) { }
        private void OnMessage(QuickFix.FIX44.News n, SessionID s) { }
        private void OnMessage(QuickFix.FIX50.News n, SessionID s) { }

        private void OnMessage(QuickFix.FIX40.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX40.OrderCancelReject ocj = new QuickFix.FIX40.OrderCancelReject(new QuickFix.FIX40.Fields.OrderID(orderid), msg.ClOrdID);
            ocj.CxlRejReason = new QuickFix.FIX40.Fields.CxlRejReason(QuickFix.FIX40.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX41.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX41.OrderCancelReject ocj = new QuickFix.FIX41.OrderCancelReject(
                new QuickFix.FIX41.Fields.OrderID(orderid), msg.ClOrdID, msg.OrigClOrdID, new QuickFix.FIX41.Fields.OrdStatus(QuickFix.FIX41.Fields.OrdStatus.REJECTED));
            ocj.CxlRejReason = new QuickFix.FIX41.Fields.CxlRejReason(QuickFix.FIX41.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX42.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX42.OrderCancelReject ocj = new QuickFix.FIX42.OrderCancelReject(
                new QuickFix.FIX42.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX42.Fields.OrdStatus(QuickFix.FIX42.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX42.Fields.CxlRejResponseTo(QuickFix.FIX42.Fields.CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX42.Fields.CxlRejReason(QuickFix.FIX42.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX43.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX43.OrderCancelReject ocj = new QuickFix.FIX43.OrderCancelReject(
                new QuickFix.FIX43.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX43.Fields.OrdStatus(QuickFix.FIX43.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX43.Fields.CxlRejResponseTo(QuickFix.FIX43.Fields.CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX43.Fields.CxlRejReason(QuickFix.FIX43.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX44.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX44.OrderCancelReject ocj = new QuickFix.FIX44.OrderCancelReject(
                new QuickFix.FIX44.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX44.Fields.OrdStatus(QuickFix.FIX44.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX44.Fields.CxlRejResponseTo(QuickFix.FIX44.Fields.CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX44.Fields.CxlRejReason(QuickFix.FIX44.Fields.CxlRejReason.OTHER);
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

        private void OnMessage(QuickFix.FIX50.OrderCancelRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX50.OrderCancelReject ocj = new QuickFix.FIX50.OrderCancelReject(
                new QuickFix.FIX50.Fields.OrderID(orderid), 
                msg.ClOrdID, msg.OrigClOrdID, 
                new QuickFix.FIX50.Fields.OrdStatus(QuickFix.FIX50.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX50.Fields.CxlRejResponseTo(QuickFix.FIX50.Fields.CxlRejResponseTo.ORDER_CANCEL_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX50.Fields.CxlRejReason(QuickFix.FIX50.Fields.CxlRejReason.OTHER);
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



        private void OnMessage(QuickFix.FIX40.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX40.OrderCancelReject ocj = new QuickFix.FIX40.OrderCancelReject(new QuickFix.FIX40.Fields.OrderID(orderid), msg.ClOrdID);
            ocj.CxlRejReason = new QuickFix.FIX40.Fields.CxlRejReason(QuickFix.FIX40.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX41.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX41.OrderCancelReject ocj = new QuickFix.FIX41.OrderCancelReject(
                new QuickFix.FIX41.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX41.Fields.OrdStatus(QuickFix.FIX41.Fields.OrdStatus.REJECTED));
            ocj.CxlRejReason = new QuickFix.FIX41.Fields.CxlRejReason(QuickFix.FIX41.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX42.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX42.OrderCancelReject ocj = new QuickFix.FIX42.OrderCancelReject(
                new QuickFix.FIX42.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX42.Fields.OrdStatus(QuickFix.FIX42.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX42.Fields.CxlRejResponseTo(QuickFix.FIX42.Fields.CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX42.Fields.CxlRejReason(QuickFix.FIX42.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX43.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX43.OrderCancelReject ocj = new QuickFix.FIX43.OrderCancelReject(
                new QuickFix.FIX43.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX43.Fields.OrdStatus(QuickFix.FIX43.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX43.Fields.CxlRejResponseTo(QuickFix.FIX43.Fields.CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX43.Fields.CxlRejReason(QuickFix.FIX43.Fields.CxlRejReason.UNKNOWN_ORDER);
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

        private void OnMessage(QuickFix.FIX44.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX44.OrderCancelReject ocj = new QuickFix.FIX44.OrderCancelReject(
                new QuickFix.FIX44.Fields.OrderID(orderid), 
                msg.ClOrdID, 
                msg.OrigClOrdID, 
                new QuickFix.FIX44.Fields.OrdStatus(QuickFix.FIX44.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX44.Fields.CxlRejResponseTo(QuickFix.FIX44.Fields.CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX44.Fields.CxlRejReason(QuickFix.FIX44.Fields.CxlRejReason.OTHER);
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

        private void OnMessage(QuickFix.FIX50.OrderCancelReplaceRequest msg, SessionID s)
        {
            string orderid = (msg.IsSetOrderID()) ? msg.OrderID.Obj : "unknown orderID";
            QuickFix.FIX50.OrderCancelReject ocj = new QuickFix.FIX50.OrderCancelReject(
                new QuickFix.FIX50.Fields.OrderID(orderid), 
                msg.ClOrdID, msg.OrigClOrdID, 
                new QuickFix.FIX50.Fields.OrdStatus(QuickFix.FIX50.Fields.OrdStatus.REJECTED), 
                new QuickFix.FIX50.Fields.CxlRejResponseTo(QuickFix.FIX50.Fields.CxlRejResponseTo.ORDER_CANCEL_REPLACE_REQUEST));
            ocj.CxlRejReason = new QuickFix.FIX50.Fields.CxlRejReason(QuickFix.FIX50.Fields.CxlRejReason.OTHER);
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
        private void OnMessage(QuickFix.FIX42.BusinessMessageReject n, SessionID s) { }
        private void OnMessage(QuickFix.FIX43.BusinessMessageReject n, SessionID s) { }
        private void OnMessage(QuickFix.FIX44.BusinessMessageReject n, SessionID s) { }
        private void OnMessage(QuickFix.FIX50.BusinessMessageReject n, SessionID s) { }


        #endregion //MessageCracker overloads
    }
}