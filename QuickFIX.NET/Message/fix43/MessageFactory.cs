// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX43
    {
        public class MessageFactory : IMessageFactory
        {
            public Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX43.Heartbeat.MsgType: return new QuickFix.FIX43.Heartbeat();
                    case QuickFix.FIX43.Logon.MsgType: return new QuickFix.FIX43.Logon();
                    case QuickFix.FIX43.TestRequest.MsgType: return new QuickFix.FIX43.TestRequest();
                    case QuickFix.FIX43.ResendRequest.MsgType: return new QuickFix.FIX43.ResendRequest();
                    case QuickFix.FIX43.Reject.MsgType: return new QuickFix.FIX43.Reject();
                    case QuickFix.FIX43.SequenceReset.MsgType: return new QuickFix.FIX43.SequenceReset();
                    case QuickFix.FIX43.Logout.MsgType: return new QuickFix.FIX43.Logout();
                    case QuickFix.FIX43.BusinessMessageReject.MsgType: return new QuickFix.FIX43.BusinessMessageReject();
                    case QuickFix.FIX43.Advertisement.MsgType: return new QuickFix.FIX43.Advertisement();
                    case QuickFix.FIX43.IndicationOfInterest.MsgType: return new QuickFix.FIX43.IndicationOfInterest();
                    case QuickFix.FIX43.News.MsgType: return new QuickFix.FIX43.News();
                    case QuickFix.FIX43.Email.MsgType: return new QuickFix.FIX43.Email();
                    case QuickFix.FIX43.QuoteRequest.MsgType: return new QuickFix.FIX43.QuoteRequest();
                    case QuickFix.FIX43.QuoteRequestReject.MsgType: return new QuickFix.FIX43.QuoteRequestReject();
                    case QuickFix.FIX43.RFQRequest.MsgType: return new QuickFix.FIX43.RFQRequest();
                    case QuickFix.FIX43.Quote.MsgType: return new QuickFix.FIX43.Quote();
                    case QuickFix.FIX43.QuoteCancel.MsgType: return new QuickFix.FIX43.QuoteCancel();
                    case QuickFix.FIX43.QuoteStatusRequest.MsgType: return new QuickFix.FIX43.QuoteStatusRequest();
                    case QuickFix.FIX43.QuoteStatusReport.MsgType: return new QuickFix.FIX43.QuoteStatusReport();
                    case QuickFix.FIX43.MassQuote.MsgType: return new QuickFix.FIX43.MassQuote();
                    case QuickFix.FIX43.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX43.MassQuoteAcknowledgement();
                    case QuickFix.FIX43.MarketDataRequest.MsgType: return new QuickFix.FIX43.MarketDataRequest();
                    case QuickFix.FIX43.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX43.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX43.MarketDataIncrementalRefresh();
                    case QuickFix.FIX43.MarketDataRequestReject.MsgType: return new QuickFix.FIX43.MarketDataRequestReject();
                    case QuickFix.FIX43.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX43.SecurityDefinitionRequest();
                    case QuickFix.FIX43.SecurityDefinition.MsgType: return new QuickFix.FIX43.SecurityDefinition();
                    case QuickFix.FIX43.SecurityTypeRequest.MsgType: return new QuickFix.FIX43.SecurityTypeRequest();
                    case QuickFix.FIX43.SecurityTypes.MsgType: return new QuickFix.FIX43.SecurityTypes();
                    case QuickFix.FIX43.SecurityListRequest.MsgType: return new QuickFix.FIX43.SecurityListRequest();
                    case QuickFix.FIX43.SecurityList.MsgType: return new QuickFix.FIX43.SecurityList();
                    case QuickFix.FIX43.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX43.DerivativeSecurityListRequest();
                    case QuickFix.FIX43.DerivativeSecurityList.MsgType: return new QuickFix.FIX43.DerivativeSecurityList();
                    case QuickFix.FIX43.SecurityStatusRequest.MsgType: return new QuickFix.FIX43.SecurityStatusRequest();
                    case QuickFix.FIX43.SecurityStatus.MsgType: return new QuickFix.FIX43.SecurityStatus();
                    case QuickFix.FIX43.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX43.TradingSessionStatusRequest();
                    case QuickFix.FIX43.TradingSessionStatus.MsgType: return new QuickFix.FIX43.TradingSessionStatus();
                    case QuickFix.FIX43.NewOrderSingle.MsgType: return new QuickFix.FIX43.NewOrderSingle();
                    case QuickFix.FIX43.ExecutionReport.MsgType: return new QuickFix.FIX43.ExecutionReport();
                    case QuickFix.FIX43.DontKnowTrade.MsgType: return new QuickFix.FIX43.DontKnowTrade();
                    case QuickFix.FIX43.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX43.OrderCancelReplaceRequest();
                    case QuickFix.FIX43.OrderCancelRequest.MsgType: return new QuickFix.FIX43.OrderCancelRequest();
                    case QuickFix.FIX43.OrderCancelReject.MsgType: return new QuickFix.FIX43.OrderCancelReject();
                    case QuickFix.FIX43.OrderStatusRequest.MsgType: return new QuickFix.FIX43.OrderStatusRequest();
                    case QuickFix.FIX43.OrderMassCancelRequest.MsgType: return new QuickFix.FIX43.OrderMassCancelRequest();
                    case QuickFix.FIX43.OrderMassCancelReport.MsgType: return new QuickFix.FIX43.OrderMassCancelReport();
                    case QuickFix.FIX43.OrderMassStatusRequest.MsgType: return new QuickFix.FIX43.OrderMassStatusRequest();
                    case QuickFix.FIX43.NewOrderCross.MsgType: return new QuickFix.FIX43.NewOrderCross();
                    case QuickFix.FIX43.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX43.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX43.CrossOrderCancelRequest();
                    case QuickFix.FIX43.NewOrderMultileg.MsgType: return new QuickFix.FIX43.NewOrderMultileg();
                    case QuickFix.FIX43.MultilegOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest();
                    case QuickFix.FIX43.BidRequest.MsgType: return new QuickFix.FIX43.BidRequest();
                    case QuickFix.FIX43.BidResponse.MsgType: return new QuickFix.FIX43.BidResponse();
                    case QuickFix.FIX43.NewOrderList.MsgType: return new QuickFix.FIX43.NewOrderList();
                    case QuickFix.FIX43.ListStrikePrice.MsgType: return new QuickFix.FIX43.ListStrikePrice();
                    case QuickFix.FIX43.ListExecute.MsgType: return new QuickFix.FIX43.ListExecute();
                    case QuickFix.FIX43.ListCancelRequest.MsgType: return new QuickFix.FIX43.ListCancelRequest();
                    case QuickFix.FIX43.ListStatusRequest.MsgType: return new QuickFix.FIX43.ListStatusRequest();
                    case QuickFix.FIX43.ListStatus.MsgType: return new QuickFix.FIX43.ListStatus();
                    case QuickFix.FIX43.Allocation.MsgType: return new QuickFix.FIX43.Allocation();
                    case QuickFix.FIX43.AllocationACK.MsgType: return new QuickFix.FIX43.AllocationACK();
                    case QuickFix.FIX43.SettlementInstructions.MsgType: return new QuickFix.FIX43.SettlementInstructions();
                    case QuickFix.FIX43.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX43.TradeCaptureReportRequest();
                    case QuickFix.FIX43.TradeCaptureReport.MsgType: return new QuickFix.FIX43.TradeCaptureReport();
                    case QuickFix.FIX43.RegistrationInstructions.MsgType: return new QuickFix.FIX43.RegistrationInstructions();
                    case QuickFix.FIX43.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX43.RegistrationInstructionsResponse();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX43.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX43.Logon.NoMsgTypes();
                    }
                }

                if (QuickFix.FIX43.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Advertisement.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.IndicationOfInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.IndicationOfInterest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX43.IndicationOfInterest.NoIOIQualifiers();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.IndicationOfInterest.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX43.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.News.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.News.NoRelatedSym();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX43.News.LinesOfText();
                    }
                }

                if (QuickFix.FIX43.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.Email.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.Email.NoRelatedSym();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX43.Email.LinesOfText();
                    }
                }

                if (QuickFix.FIX43.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.QuoteRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX43.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX43.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.RFQRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX43.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.Quote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Quote.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteCancel.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.QuoteCancel.NoQuoteEntries();
                    }
                }

                if (QuickFix.FIX43.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteStatusRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX43.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteStatusReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteStatusReport.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MassQuote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX43.MassQuote.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX43.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX43.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX43.MarketDataRequest.NoMDEntryTypes();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.MarketDataRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.MarketDataRequest.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX43.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh.NoMDEntries();
                    }
                }

                if (QuickFix.FIX43.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX43.MarketDataIncrementalRefresh.NoMDEntries();
                    }
                }

                if (QuickFix.FIX43.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityDefinitionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityDefinitionRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX43.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityDefinition.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityDefinition.NoLegs();
                    }
                }

                if (QuickFix.FIX43.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX43.SecurityTypes.NoSecurityTypes();
                    }
                }

                if (QuickFix.FIX43.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityListRequest.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.SecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX43.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityListRequest.NoUnderlyingSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX43.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityStatusRequest.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityStatus.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderSingle.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderSingle.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderSingle.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderSingle.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderSingle.NoStipulations();
                    }
                }

                if (QuickFix.FIX43.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.ExecutionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX43.ExecutionReport.NoContraBrokers();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.ExecutionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.ExecutionReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX43.ExecutionReport.NoContAmts();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.ExecutionReport.NoLegs();
                    }
                }

                if (QuickFix.FIX43.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.DontKnowTrade.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderCancelRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderCancelRequest.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderStatusRequest.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassCancelRequest.NoUnderlyingSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX43.OrderMassCancelReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassCancelReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassCancelReport.NoUnderlyingSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderMassStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassStatusRequest.NoUnderlyingSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.NewOrderCross.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderCross.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderCross.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderCross.NoStipulations();
                    }
                }

                if (QuickFix.FIX43.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX43.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSecurityAltID();
                    }
                }

                if (QuickFix.FIX43.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderMultileg.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderMultileg.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderMultileg.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderMultileg.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.NewOrderMultileg.NoLegs();
                    }
                }

                if (QuickFix.FIX43.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX43.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX43.BidRequest.NoBidDescriptors();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX43.BidRequest.NoBidComponents();
                    }
                }

                if (QuickFix.FIX43.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX43.BidResponse.NoBidComponents();
                    }
                }

                if (QuickFix.FIX43.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.NewOrderList.NoOrders();
                    }
                }

                if (QuickFix.FIX43.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX43.ListStrikePrice.NoStrikes();
                    }
                }

                if (QuickFix.FIX43.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.ListStatus.NoOrders();
                    }
                }

                if (QuickFix.FIX43.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.Allocation.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX43.Allocation.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Allocation.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.Allocation.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.Allocation.NoAllocs();
                    }
                }

                if (QuickFix.FIX43.AllocationACK.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.AllocationACK.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX43.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.SettlementInstructions.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX43.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.TradeCaptureReportRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.TradeCaptureReportRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX43.TradeCaptureReportRequest.NoDates();
                    }
                }

                if (QuickFix.FIX43.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.TradeCaptureReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.TradeCaptureReport.NoSides();
                    }
                }

                if (QuickFix.FIX43.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.RegistrationInstructions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX43.RegistrationInstructions.NoRegistDtls();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX43.RegistrationInstructions.NoDistribInsts();
                    }
                }

                if (QuickFix.FIX43.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.RegistrationInstructionsResponse.NoPartyIDs();
                    }
                }

                return null;
            }

        }
    }
}
