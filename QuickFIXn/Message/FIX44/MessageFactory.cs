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
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX44.Logon.NoMsgTypesGroup();
                    }
                }

                if (QuickFix.FIX44.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Advertisement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Advertisement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Advertisement.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.IndicationOfInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.IndicationOfInterest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.IndicationOfInterest.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX44.IndicationOfInterest.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.IndicationOfInterest.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX44.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.News.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.News.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX44.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Email.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Email.NoLegsGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteResponse.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteResponse.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteRequestReject.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX44.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX44.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.Quote.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Quote.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Quote.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Quote.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Quote.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX44.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteStatusReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteStatusReport.NoQuoteQualifiersGroup();
                    }
                }

                if (QuickFix.FIX44.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX44.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX44.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MarketDataRequest.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX44.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX44.MarketDataRequestReject.NoAltMDSourceGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinitionRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinition.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinition.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX44.SecurityTypes.NoSecurityTypesGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityListRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityListRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX44.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FIX44.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatusRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatus.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderSingle.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderSingle.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderSingle.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderSingle.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX44.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX44.ExecutionReport.NoContraBrokersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.ExecutionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.ExecutionReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX44.ExecutionReport.NoContAmtsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.ExecutionReport.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX44.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.DontKnowTrade.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FIX44.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX44.OrderMassCancelReport.NoAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FIX44.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingStipsGroup();
                    }
                }

                if (QuickFix.FIX44.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderCross.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderCross.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderCross.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX44.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX44.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderMultileg.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderMultileg.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderMultileg.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderMultileg.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX44.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX44.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX44.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX44.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ListStatus.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX44.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationInstruction.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationInstruction.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationInstruction.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationInstruction.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX44.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstructionAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstructionAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX44.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationReport.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX44.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReportAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReportAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX44.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.Confirmation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.Confirmation.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Confirmation.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Confirmation.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.Confirmation.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Confirmation.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX44.Confirmation.NoCapacitiesGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.Confirmation.NoDlvyInstGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Confirmation.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.Confirmation.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX44.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX44.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup();
                    }
                }

                if (QuickFix.FIX44.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.TradeCaptureReportRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoDatesGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.TradeCaptureReport.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
                    }
                }

                if (QuickFix.FIX44.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.TradeCaptureReportAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX44.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX44.RegistrationInstructions.NoDistribInstsGroup();
                    }
                }

                if (QuickFix.FIX44.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX44.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup();
                    }
                }

                if (QuickFix.FIX44.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceReport.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionMaintenanceReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX44.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositions.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.RequestForPositions.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX44.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX44.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX44.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AssignmentReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.AssignmentReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX44.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralRequest.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralRequest.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralRequest.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralRequest.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX44.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralAssignment.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralAssignment.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralAssignment.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralAssignment.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralAssignment.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralAssignment.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX44.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralResponse.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralResponse.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralResponse.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralResponse.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralResponse.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX44.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralReport.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX44.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiry.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiry.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiry.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiry.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralInquiry.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralInquiry.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX44.NetworkStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusRequest.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX44.NetworkStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusResponse.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX44.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiryAck.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiryAck.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiryAck.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoLegSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup();
                    }
                }

                return null;
            }

        }
    }
}
