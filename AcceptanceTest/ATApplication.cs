﻿using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using QuickFix;
using QuickFix.Fields;

namespace AcceptanceTest
{
    public class ATApplication : MessageCracker, IApplication
    {
        public event System.Action? StopMeEvent;

        private readonly HashSet<KeyValuePair<string, SessionID>> _clOrdIDs = new();

        public ATApplication()
        {
        }

        public void OnMessage(QuickFix.FIX40.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX41.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX42.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX42.SecurityDefinition message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        public void OnMessage(QuickFix.FIX43.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX43.SecurityDefinition message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        public void OnMessage(QuickFix.FIX44.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX44.SecurityDefinition message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        public void OnMessage(QuickFix.FIX44.QuoteRequest message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        public void OnMessage(QuickFix.FIX50.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX50.SecurityDefinition message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        public void OnMessage(QuickFix.FIX50SP1.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX50SP1.SecurityDefinition message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        public void OnMessage(QuickFix.FIX50SP2.NewOrderSingle nos, SessionID sessionId)
        {
            ProcessNOS(nos, sessionId);
        }

        public void OnMessage(QuickFix.FIX50SP2.SecurityDefinition message, SessionID sessionId)
        {
            Echo(message, sessionId);
        }

        private static void Echo(Message message, SessionID sessionId)
        {
            Message echo = new(message);
            Session.SendToTarget(echo, sessionId);
        }

        private void ProcessNOS(Message message, SessionID sessionId)
        {
            Message echo = new(message);

            bool possResend = false;
            if (message.Header.IsSetField(QuickFix.Fields.Tags.PossResend))
                possResend = message.Header.GetBoolean(QuickFix.Fields.Tags.PossResend);

            KeyValuePair<string, SessionID> pair = new(message.GetString(QuickFix.Fields.Tags.ClOrdID), sessionId);
            if (possResend && _clOrdIDs.Contains(pair))
                return;
            _clOrdIDs.Add(pair);

            Session.SendToTarget(echo, sessionId);
        }

        private void AcknowledgeXmlMessage(Message msg, SessionID sessionId) {
            string beginString = Message.ExtractBeginString(msg.ToString());
            string seqNo = msg.Header.GetString(34);

            Message response = new();
            response.Header.SetField(new BeginString(beginString));
            response.Header.SetField(new MsgType("B"));
            response.SetField(new Headline($"Successfully received 'n' message with seqNo={seqNo}"));
            response.SetField(new NoLinesOfText(0));

            Session.SendToTarget(response, sessionId);
        }

        public void OnMessage(QuickFix.FIX41.News news, SessionID sessionId) { ProcessNews(news, sessionId); }
        public void OnMessage(QuickFix.FIX42.News news, SessionID sessionId) { ProcessNews(news, sessionId); }
        public void OnMessage(QuickFix.FIX43.News news, SessionID sessionId) { ProcessNews(news, sessionId); }
        public void OnMessage(QuickFix.FIX44.News news, SessionID sessionId) { ProcessNews(news, sessionId); }
        public void OnMessage(QuickFix.FIX50.News news, SessionID sessionId) { ProcessNews(news, sessionId); }
        public void OnMessage(QuickFix.FIX50SP1.News news, SessionID sessionId) { ProcessNews(news, sessionId); }
        public void OnMessage(QuickFix.FIX50SP2.News news, SessionID sessionId) { ProcessNews(news, sessionId); }

        private void ProcessNews(Message msg, SessionID sessionId)
        {
            if (msg.IsSetField(QuickFix.Fields.Tags.Headline) && (msg.GetString(QuickFix.Fields.Tags.Headline) == "STOPME"))
            {
                if (this.StopMeEvent != null)
                    StopMeEvent();
            }
            else
                Echo(msg, sessionId);
        }

        public void OnMessage(QuickFix.FIX44.TradeCaptureReportRequest msg, SessionID sessionId)
        {
            // do nothing, just swallow it.
        }

        #region Application Methods

        public void OnCreate(SessionID sessionId)
        {
            Session? session = Session.LookupSession(sessionId);

            // Hey QF/N users, don't do this in a real app.
            session?.Reset("AT Session Reset");
        }

        public void OnLogout(SessionID sessionId)
        {
            _clOrdIDs.Clear();
        }

        public void OnLogon(SessionID sessionId)
        { }

        public void FromApp(Message message, SessionID sessionId)
        {
            try
            {
                //string msgType = message.Header.GetString(QuickFix.Fields.Tags.MsgType);
                // log_.OnEvent("Got message " + msgType);
                // System.Console.WriteLine("===got message " + msgType);

                Crack(message, sessionId);
            }
            catch (UnsupportedMessageType)
            {
                throw;
            }
            catch (System.Exception e)
            {
                Session.LookupSession(sessionId)?.Log.Log(LogLevel.Error, e,
                    "Exception during FromApp: {Error}\n while processing msg ({Message})", e, message);
            }
        }

        public void FromAdmin(Message message, SessionID sessionId) {
            if (message.Header.GetString(35) == "n")
                AcknowledgeXmlMessage(message, sessionId);
        }

        public void ToAdmin(Message message, SessionID sessionId) { }
        public void ToApp(Message message, SessionID sessionId) { }

        #endregion
    }
}
