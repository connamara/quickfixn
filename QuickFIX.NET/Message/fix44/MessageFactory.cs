// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX44
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX44.Heartbeat.MsgType: return new QuickFix.FIX44.Heartbeat();
                    case QuickFix.FIX44.Logon.MsgType: return new QuickFix.FIX44.Logon();
                    case QuickFix.FIX44.TestRequest.MsgType: return new QuickFix.FIX44.TestRequest();
                    case QuickFix.FIX44.ResendRequest.MsgType: return new QuickFix.FIX44.ResendRequest();
                    case QuickFix.FIX44.Reject.MsgType: return new QuickFix.FIX44.Reject();
                    case QuickFix.FIX44.SequenceReset.MsgType: return new QuickFix.FIX44.SequenceReset();
                    case QuickFix.FIX44.Logout.MsgType: return new QuickFix.FIX44.Logout();
                    case QuickFix.FIX44.BusinessMessageReject.MsgType: return new QuickFix.FIX44.BusinessMessageReject();
                    case QuickFix.FIX44.UserRequest.MsgType: return new QuickFix.FIX44.UserRequest();
                    case QuickFix.FIX44.UserResponse.MsgType: return new QuickFix.FIX44.UserResponse();
                    case QuickFix.FIX44.Advertisement.MsgType: return new QuickFix.FIX44.Advertisement();
                    case QuickFix.FIX44.IndicationOfInterest.MsgType: return new QuickFix.FIX44.IndicationOfInterest();
                    case QuickFix.FIX44.News.MsgType: return new QuickFix.FIX44.News();
                    case QuickFix.FIX44.Email.MsgType: return new QuickFix.FIX44.Email();
                    case QuickFix.FIX44.QuoteRequest.MsgType: return new QuickFix.FIX44.QuoteRequest();
                    case QuickFix.FIX44.QuoteResponse.MsgType: return new QuickFix.FIX44.QuoteResponse();
                    case QuickFix.FIX44.QuoteRequestReject.MsgType: return new QuickFix.FIX44.QuoteRequestReject();
                    case QuickFix.FIX44.RFQRequest.MsgType: return new QuickFix.FIX44.RFQRequest();
                    case QuickFix.FIX44.Quote.MsgType: return new QuickFix.FIX44.Quote();
                    case QuickFix.FIX44.QuoteCancel.MsgType: return new QuickFix.FIX44.QuoteCancel();
                    case QuickFix.FIX44.QuoteStatusRequest.MsgType: return new QuickFix.FIX44.QuoteStatusRequest();
                    case QuickFix.FIX44.QuoteStatusReport.MsgType: return new QuickFix.FIX44.QuoteStatusReport();
                    case QuickFix.FIX44.MassQuote.MsgType: return new QuickFix.FIX44.MassQuote();
                    case QuickFix.FIX44.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX44.MassQuoteAcknowledgement();
                    case QuickFix.FIX44.MarketDataRequest.MsgType: return new QuickFix.FIX44.MarketDataRequest();
                    case QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX44.MarketDataIncrementalRefresh();
                    case QuickFix.FIX44.MarketDataRequestReject.MsgType: return new QuickFix.FIX44.MarketDataRequestReject();
                    case QuickFix.FIX44.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX44.SecurityDefinitionRequest();
                    case QuickFix.FIX44.SecurityDefinition.MsgType: return new QuickFix.FIX44.SecurityDefinition();
                    case QuickFix.FIX44.SecurityTypeRequest.MsgType: return new QuickFix.FIX44.SecurityTypeRequest();
                    case QuickFix.FIX44.SecurityTypes.MsgType: return new QuickFix.FIX44.SecurityTypes();
                    case QuickFix.FIX44.SecurityListRequest.MsgType: return new QuickFix.FIX44.SecurityListRequest();
                    case QuickFix.FIX44.SecurityList.MsgType: return new QuickFix.FIX44.SecurityList();
                    case QuickFix.FIX44.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX44.DerivativeSecurityListRequest();
                    case QuickFix.FIX44.DerivativeSecurityList.MsgType: return new QuickFix.FIX44.DerivativeSecurityList();
                    case QuickFix.FIX44.SecurityStatusRequest.MsgType: return new QuickFix.FIX44.SecurityStatusRequest();
                    case QuickFix.FIX44.SecurityStatus.MsgType: return new QuickFix.FIX44.SecurityStatus();
                    case QuickFix.FIX44.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX44.TradingSessionStatusRequest();
                    case QuickFix.FIX44.TradingSessionStatus.MsgType: return new QuickFix.FIX44.TradingSessionStatus();
                    case QuickFix.FIX44.NewOrderSingle.MsgType: return new QuickFix.FIX44.NewOrderSingle();
                    case QuickFix.FIX44.ExecutionReport.MsgType: return new QuickFix.FIX44.ExecutionReport();
                    case QuickFix.FIX44.DontKnowTrade.MsgType: return new QuickFix.FIX44.DontKnowTrade();
                    case QuickFix.FIX44.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX44.OrderCancelReplaceRequest();
                    case QuickFix.FIX44.OrderCancelRequest.MsgType: return new QuickFix.FIX44.OrderCancelRequest();
                    case QuickFix.FIX44.OrderCancelReject.MsgType: return new QuickFix.FIX44.OrderCancelReject();
                    case QuickFix.FIX44.OrderStatusRequest.MsgType: return new QuickFix.FIX44.OrderStatusRequest();
                    case QuickFix.FIX44.OrderMassCancelRequest.MsgType: return new QuickFix.FIX44.OrderMassCancelRequest();
                    case QuickFix.FIX44.OrderMassCancelReport.MsgType: return new QuickFix.FIX44.OrderMassCancelReport();
                    case QuickFix.FIX44.OrderMassStatusRequest.MsgType: return new QuickFix.FIX44.OrderMassStatusRequest();
                    case QuickFix.FIX44.NewOrderCross.MsgType: return new QuickFix.FIX44.NewOrderCross();
                    case QuickFix.FIX44.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX44.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX44.CrossOrderCancelRequest();
                    case QuickFix.FIX44.NewOrderMultileg.MsgType: return new QuickFix.FIX44.NewOrderMultileg();
                    case QuickFix.FIX44.MultilegOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest();
                    case QuickFix.FIX44.BidRequest.MsgType: return new QuickFix.FIX44.BidRequest();
                    case QuickFix.FIX44.BidResponse.MsgType: return new QuickFix.FIX44.BidResponse();
                    case QuickFix.FIX44.NewOrderList.MsgType: return new QuickFix.FIX44.NewOrderList();
                    case QuickFix.FIX44.ListStrikePrice.MsgType: return new QuickFix.FIX44.ListStrikePrice();
                    case QuickFix.FIX44.ListStatus.MsgType: return new QuickFix.FIX44.ListStatus();
                    case QuickFix.FIX44.ListExecute.MsgType: return new QuickFix.FIX44.ListExecute();
                    case QuickFix.FIX44.ListCancelRequest.MsgType: return new QuickFix.FIX44.ListCancelRequest();
                    case QuickFix.FIX44.ListStatusRequest.MsgType: return new QuickFix.FIX44.ListStatusRequest();
                    case QuickFix.FIX44.AllocationInstruction.MsgType: return new QuickFix.FIX44.AllocationInstruction();
                    case QuickFix.FIX44.AllocationInstructionAck.MsgType: return new QuickFix.FIX44.AllocationInstructionAck();
                    case QuickFix.FIX44.AllocationReport.MsgType: return new QuickFix.FIX44.AllocationReport();
                    case QuickFix.FIX44.AllocationReportAck.MsgType: return new QuickFix.FIX44.AllocationReportAck();
                    case QuickFix.FIX44.Confirmation.MsgType: return new QuickFix.FIX44.Confirmation();
                    case QuickFix.FIX44.ConfirmationAck.MsgType: return new QuickFix.FIX44.ConfirmationAck();
                    case QuickFix.FIX44.ConfirmationRequest.MsgType: return new QuickFix.FIX44.ConfirmationRequest();
                    case QuickFix.FIX44.SettlementInstructions.MsgType: return new QuickFix.FIX44.SettlementInstructions();
                    case QuickFix.FIX44.SettlementInstructionRequest.MsgType: return new QuickFix.FIX44.SettlementInstructionRequest();
                    case QuickFix.FIX44.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX44.TradeCaptureReportRequest();
                    case QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FIX44.TradeCaptureReportRequestAck();
                    case QuickFix.FIX44.TradeCaptureReport.MsgType: return new QuickFix.FIX44.TradeCaptureReport();
                    case QuickFix.FIX44.TradeCaptureReportAck.MsgType: return new QuickFix.FIX44.TradeCaptureReportAck();
                    case QuickFix.FIX44.RegistrationInstructions.MsgType: return new QuickFix.FIX44.RegistrationInstructions();
                    case QuickFix.FIX44.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX44.RegistrationInstructionsResponse();
                    case QuickFix.FIX44.PositionMaintenanceRequest.MsgType: return new QuickFix.FIX44.PositionMaintenanceRequest();
                    case QuickFix.FIX44.PositionMaintenanceReport.MsgType: return new QuickFix.FIX44.PositionMaintenanceReport();
                    case QuickFix.FIX44.RequestForPositions.MsgType: return new QuickFix.FIX44.RequestForPositions();
                    case QuickFix.FIX44.RequestForPositionsAck.MsgType: return new QuickFix.FIX44.RequestForPositionsAck();
                    case QuickFix.FIX44.PositionReport.MsgType: return new QuickFix.FIX44.PositionReport();
                    case QuickFix.FIX44.AssignmentReport.MsgType: return new QuickFix.FIX44.AssignmentReport();
                    case QuickFix.FIX44.CollateralRequest.MsgType: return new QuickFix.FIX44.CollateralRequest();
                    case QuickFix.FIX44.CollateralAssignment.MsgType: return new QuickFix.FIX44.CollateralAssignment();
                    case QuickFix.FIX44.CollateralResponse.MsgType: return new QuickFix.FIX44.CollateralResponse();
                    case QuickFix.FIX44.CollateralReport.MsgType: return new QuickFix.FIX44.CollateralReport();
                    case QuickFix.FIX44.CollateralInquiry.MsgType: return new QuickFix.FIX44.CollateralInquiry();
                    case QuickFix.FIX44.NetworkStatusRequest.MsgType: return new QuickFix.FIX44.NetworkStatusRequest();
                    case QuickFix.FIX44.NetworkStatusResponse.MsgType: return new QuickFix.FIX44.NetworkStatusResponse();
                    case QuickFix.FIX44.CollateralInquiryAck.MsgType: return new QuickFix.FIX44.CollateralInquiryAck();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX44.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX44.Logon.NoMsgTypes();
                    }
                }

                if (QuickFix.FIX44.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Advertisement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Advertisement.NoEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Advertisement.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Advertisement.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX44.IndicationOfInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.IndicationOfInterest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.IndicationOfInterest.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.IndicationOfInterest.NoLegs();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX44.IndicationOfInterest.NoIOIQualifiers();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.IndicationOfInterest.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX44.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.News.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.News.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.News.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.News.NoUnderlyings();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.News.LinesOfText();
                    }
                }

                if (QuickFix.FIX44.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.Email.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.Email.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Email.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Email.NoLegs();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.Email.LinesOfText();
                    }
                }

                if (QuickFix.FIX44.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX44.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteResponse.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteResponse.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteResponse.NoLegs();
                    }
                }

                if (QuickFix.FIX44.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteRequestReject.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX44.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.RFQRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX44.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.Quote.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Quote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Quote.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Quote.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Quote.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Quote.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Quote.NoLegs();
                    }
                }

                if (QuickFix.FIX44.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntries();
                    }
                }

                if (QuickFix.FIX44.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX44.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusReport.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteStatusReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusReport.NoLegs();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteStatusReport.NoQuoteQualifiers();
                    }
                }

                if (QuickFix.FIX44.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuote.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX44.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX44.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypes();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MarketDataRequest.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegs();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoMDEntries();
                    }
                }

                if (QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntries();
                    }
                }

                if (QuickFix.FIX44.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX44.MarketDataRequestReject.NoAltMDSource();
                    }
                }

                if (QuickFix.FIX44.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinitionRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX44.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinition.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinition.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinition.NoLegs();
                    }
                }

                if (QuickFix.FIX44.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX44.SecurityTypes.NoSecurityTypes();
                    }
                }

                if (QuickFix.FIX44.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityListRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityListRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityListRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX44.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.SecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX44.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingStips();
                    }
                }

                if (QuickFix.FIX44.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX44.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatusRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatusRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX44.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatus.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatus.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatus.NoLegs();
                    }
                }

                if (QuickFix.FIX44.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderSingle.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderSingle.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderSingle.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderSingle.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderSingle.NoStipulations();
                    }
                }

                if (QuickFix.FIX44.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX44.ExecutionReport.NoContraBrokers();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.ExecutionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ExecutionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.ExecutionReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX44.ExecutionReport.NoContAmts();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.ExecutionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.ExecutionReport.NoMiscFees();
                    }
                }

                if (QuickFix.FIX44.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.DontKnowTrade.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DontKnowTrade.NoLegs();
                    }
                }

                if (QuickFix.FIX44.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX44.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX44.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX44.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingStips();
                    }
                }

                if (QuickFix.FIX44.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX44.OrderMassCancelReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelReport.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingStips();
                    }
                }

                if (QuickFix.FIX44.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingStips();
                    }
                }

                if (QuickFix.FIX44.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.NewOrderCross.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderCross.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderCross.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderCross.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderCross.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderCross.NoStipulations();
                    }
                }

                if (QuickFix.FIX44.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX44.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX44.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderMultileg.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderMultileg.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderMultileg.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderMultileg.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderMultileg.NoLegs();
                    }
                }

                if (QuickFix.FIX44.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX44.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX44.BidRequest.NoBidDescriptors();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidRequest.NoBidComponents();
                    }
                }

                if (QuickFix.FIX44.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidResponse.NoBidComponents();
                    }
                }

                if (QuickFix.FIX44.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.NewOrderList.NoOrders();
                    }
                }

                if (QuickFix.FIX44.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX44.ListStrikePrice.NoStrikes();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX44.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ListStatus.NoOrders();
                    }
                }

                if (QuickFix.FIX44.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationInstruction.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationInstruction.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationInstruction.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationInstruction.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationInstruction.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationInstruction.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstruction.NoAllocs();
                    }
                }

                if (QuickFix.FIX44.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstructionAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstructionAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX44.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationReport.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationReport.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationReport.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationReport.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReport.NoAllocs();
                    }
                }

                if (QuickFix.FIX44.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReportAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReportAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX44.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.Confirmation.NoOrders();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.Confirmation.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Confirmation.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Confirmation.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.Confirmation.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Confirmation.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Confirmation.NoLegs();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX44.Confirmation.NoCapacities();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.Confirmation.NoDlvyInst();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Confirmation.NoStipulations();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.Confirmation.NoMiscFees();
                    }
                }

                if (QuickFix.FIX44.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ConfirmationRequest.NoOrders();
                    }
                }

                if (QuickFix.FIX44.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX44.SettlementInstructions.NoSettlInst();
                    }
                }

                if (QuickFix.FIX44.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.TradeCaptureReportRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoDates();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegs();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReport.NoEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.TradeCaptureReport.NoPosAmt();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReport.NoLegs();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.TradeCaptureReport.NoSides();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportAck.NoEvents();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReportAck.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.TradeCaptureReportAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX44.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtls();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX44.RegistrationInstructions.NoDistribInsts();
                    }
                }

                if (QuickFix.FIX44.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX44.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositions();
                    }
                }

                if (QuickFix.FIX44.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceReport.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionMaintenanceReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX44.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositions.NoEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositions.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositions.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.RequestForPositions.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX44.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositionsAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX44.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX44.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AssignmentReport.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AssignmentReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.AssignmentReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.AssignmentReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX44.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralRequest.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralRequest.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralRequest.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralRequest.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX44.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralAssignment.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralAssignment.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralAssignment.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralAssignment.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralAssignment.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralAssignment.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX44.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralResponse.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralResponse.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralResponse.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralResponse.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralResponse.NoStipulations();
                    }
                }

                if (QuickFix.FIX44.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralReport.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralReport.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralReport.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralReport.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX44.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiry.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiry.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiry.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiry.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralInquiry.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralInquiry.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX44.NetworkStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusRequest.NoCompIDs();
                    }
                }

                if (QuickFix.FIX44.NetworkStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusResponse.NoCompIDs();
                    }
                }

                if (QuickFix.FIX44.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiryAck.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiryAck.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiryAck.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoEvents();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoLegSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyings();
                    }
                }

                return null;
            }

        }
    }
}
