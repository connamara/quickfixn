// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX50SP2
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX50SP2.IOI.MsgType: return new QuickFix.FIX50SP2.IOI();
                    case QuickFix.FIX50SP2.Advertisement.MsgType: return new QuickFix.FIX50SP2.Advertisement();
                    case QuickFix.FIX50SP2.ExecutionReport.MsgType: return new QuickFix.FIX50SP2.ExecutionReport();
                    case QuickFix.FIX50SP2.OrderCancelReject.MsgType: return new QuickFix.FIX50SP2.OrderCancelReject();
                    case QuickFix.FIX50SP2.News.MsgType: return new QuickFix.FIX50SP2.News();
                    case QuickFix.FIX50SP2.Email.MsgType: return new QuickFix.FIX50SP2.Email();
                    case QuickFix.FIX50SP2.NewOrderSingle.MsgType: return new QuickFix.FIX50SP2.NewOrderSingle();
                    case QuickFix.FIX50SP2.NewOrderList.MsgType: return new QuickFix.FIX50SP2.NewOrderList();
                    case QuickFix.FIX50SP2.OrderCancelRequest.MsgType: return new QuickFix.FIX50SP2.OrderCancelRequest();
                    case QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest();
                    case QuickFix.FIX50SP2.OrderStatusRequest.MsgType: return new QuickFix.FIX50SP2.OrderStatusRequest();
                    case QuickFix.FIX50SP2.AllocationInstruction.MsgType: return new QuickFix.FIX50SP2.AllocationInstruction();
                    case QuickFix.FIX50SP2.ListCancelRequest.MsgType: return new QuickFix.FIX50SP2.ListCancelRequest();
                    case QuickFix.FIX50SP2.ListExecute.MsgType: return new QuickFix.FIX50SP2.ListExecute();
                    case QuickFix.FIX50SP2.ListStatusRequest.MsgType: return new QuickFix.FIX50SP2.ListStatusRequest();
                    case QuickFix.FIX50SP2.ListStatus.MsgType: return new QuickFix.FIX50SP2.ListStatus();
                    case QuickFix.FIX50SP2.AllocationInstructionAck.MsgType: return new QuickFix.FIX50SP2.AllocationInstructionAck();
                    case QuickFix.FIX50SP2.DontKnowTrade.MsgType: return new QuickFix.FIX50SP2.DontKnowTrade();
                    case QuickFix.FIX50SP2.QuoteRequest.MsgType: return new QuickFix.FIX50SP2.QuoteRequest();
                    case QuickFix.FIX50SP2.Quote.MsgType: return new QuickFix.FIX50SP2.Quote();
                    case QuickFix.FIX50SP2.SettlementInstructions.MsgType: return new QuickFix.FIX50SP2.SettlementInstructions();
                    case QuickFix.FIX50SP2.MarketDataRequest.MsgType: return new QuickFix.FIX50SP2.MarketDataRequest();
                    case QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh();
                    case QuickFix.FIX50SP2.MarketDataRequestReject.MsgType: return new QuickFix.FIX50SP2.MarketDataRequestReject();
                    case QuickFix.FIX50SP2.QuoteCancel.MsgType: return new QuickFix.FIX50SP2.QuoteCancel();
                    case QuickFix.FIX50SP2.QuoteStatusRequest.MsgType: return new QuickFix.FIX50SP2.QuoteStatusRequest();
                    case QuickFix.FIX50SP2.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement();
                    case QuickFix.FIX50SP2.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX50SP2.SecurityDefinitionRequest();
                    case QuickFix.FIX50SP2.SecurityDefinition.MsgType: return new QuickFix.FIX50SP2.SecurityDefinition();
                    case QuickFix.FIX50SP2.SecurityStatusRequest.MsgType: return new QuickFix.FIX50SP2.SecurityStatusRequest();
                    case QuickFix.FIX50SP2.SecurityStatus.MsgType: return new QuickFix.FIX50SP2.SecurityStatus();
                    case QuickFix.FIX50SP2.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX50SP2.TradingSessionStatusRequest();
                    case QuickFix.FIX50SP2.TradingSessionStatus.MsgType: return new QuickFix.FIX50SP2.TradingSessionStatus();
                    case QuickFix.FIX50SP2.MassQuote.MsgType: return new QuickFix.FIX50SP2.MassQuote();
                    case QuickFix.FIX50SP2.BusinessMessageReject.MsgType: return new QuickFix.FIX50SP2.BusinessMessageReject();
                    case QuickFix.FIX50SP2.BidRequest.MsgType: return new QuickFix.FIX50SP2.BidRequest();
                    case QuickFix.FIX50SP2.BidResponse.MsgType: return new QuickFix.FIX50SP2.BidResponse();
                    case QuickFix.FIX50SP2.ListStrikePrice.MsgType: return new QuickFix.FIX50SP2.ListStrikePrice();
                    case QuickFix.FIX50SP2.RegistrationInstructions.MsgType: return new QuickFix.FIX50SP2.RegistrationInstructions();
                    case QuickFix.FIX50SP2.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX50SP2.RegistrationInstructionsResponse();
                    case QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType: return new QuickFix.FIX50SP2.OrderMassCancelRequest();
                    case QuickFix.FIX50SP2.OrderMassCancelReport.MsgType: return new QuickFix.FIX50SP2.OrderMassCancelReport();
                    case QuickFix.FIX50SP2.NewOrderCross.MsgType: return new QuickFix.FIX50SP2.NewOrderCross();
                    case QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX50SP2.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX50SP2.CrossOrderCancelRequest();
                    case QuickFix.FIX50SP2.SecurityTypeRequest.MsgType: return new QuickFix.FIX50SP2.SecurityTypeRequest();
                    case QuickFix.FIX50SP2.SecurityTypes.MsgType: return new QuickFix.FIX50SP2.SecurityTypes();
                    case QuickFix.FIX50SP2.SecurityListRequest.MsgType: return new QuickFix.FIX50SP2.SecurityListRequest();
                    case QuickFix.FIX50SP2.SecurityList.MsgType: return new QuickFix.FIX50SP2.SecurityList();
                    case QuickFix.FIX50SP2.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest();
                    case QuickFix.FIX50SP2.DerivativeSecurityList.MsgType: return new QuickFix.FIX50SP2.DerivativeSecurityList();
                    case QuickFix.FIX50SP2.NewOrderMultileg.MsgType: return new QuickFix.FIX50SP2.NewOrderMultileg();
                    case QuickFix.FIX50SP2.MultilegOrderCancelReplace.MsgType: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace();
                    case QuickFix.FIX50SP2.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX50SP2.TradeCaptureReportRequest();
                    case QuickFix.FIX50SP2.TradeCaptureReport.MsgType: return new QuickFix.FIX50SP2.TradeCaptureReport();
                    case QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType: return new QuickFix.FIX50SP2.OrderMassStatusRequest();
                    case QuickFix.FIX50SP2.QuoteRequestReject.MsgType: return new QuickFix.FIX50SP2.QuoteRequestReject();
                    case QuickFix.FIX50SP2.RFQRequest.MsgType: return new QuickFix.FIX50SP2.RFQRequest();
                    case QuickFix.FIX50SP2.QuoteStatusReport.MsgType: return new QuickFix.FIX50SP2.QuoteStatusReport();
                    case QuickFix.FIX50SP2.QuoteResponse.MsgType: return new QuickFix.FIX50SP2.QuoteResponse();
                    case QuickFix.FIX50SP2.Confirmation.MsgType: return new QuickFix.FIX50SP2.Confirmation();
                    case QuickFix.FIX50SP2.PositionMaintenanceRequest.MsgType: return new QuickFix.FIX50SP2.PositionMaintenanceRequest();
                    case QuickFix.FIX50SP2.PositionMaintenanceReport.MsgType: return new QuickFix.FIX50SP2.PositionMaintenanceReport();
                    case QuickFix.FIX50SP2.RequestForPositions.MsgType: return new QuickFix.FIX50SP2.RequestForPositions();
                    case QuickFix.FIX50SP2.RequestForPositionsAck.MsgType: return new QuickFix.FIX50SP2.RequestForPositionsAck();
                    case QuickFix.FIX50SP2.PositionReport.MsgType: return new QuickFix.FIX50SP2.PositionReport();
                    case QuickFix.FIX50SP2.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck();
                    case QuickFix.FIX50SP2.TradeCaptureReportAck.MsgType: return new QuickFix.FIX50SP2.TradeCaptureReportAck();
                    case QuickFix.FIX50SP2.AllocationReport.MsgType: return new QuickFix.FIX50SP2.AllocationReport();
                    case QuickFix.FIX50SP2.AllocationReportAck.MsgType: return new QuickFix.FIX50SP2.AllocationReportAck();
                    case QuickFix.FIX50SP2.ConfirmationAck.MsgType: return new QuickFix.FIX50SP2.ConfirmationAck();
                    case QuickFix.FIX50SP2.SettlementInstructionRequest.MsgType: return new QuickFix.FIX50SP2.SettlementInstructionRequest();
                    case QuickFix.FIX50SP2.AssignmentReport.MsgType: return new QuickFix.FIX50SP2.AssignmentReport();
                    case QuickFix.FIX50SP2.CollateralRequest.MsgType: return new QuickFix.FIX50SP2.CollateralRequest();
                    case QuickFix.FIX50SP2.CollateralAssignment.MsgType: return new QuickFix.FIX50SP2.CollateralAssignment();
                    case QuickFix.FIX50SP2.CollateralResponse.MsgType: return new QuickFix.FIX50SP2.CollateralResponse();
                    case QuickFix.FIX50SP2.CollateralReport.MsgType: return new QuickFix.FIX50SP2.CollateralReport();
                    case QuickFix.FIX50SP2.CollateralInquiry.MsgType: return new QuickFix.FIX50SP2.CollateralInquiry();
                    case QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.MsgType: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest();
                    case QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.MsgType: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse();
                    case QuickFix.FIX50SP2.UserRequest.MsgType: return new QuickFix.FIX50SP2.UserRequest();
                    case QuickFix.FIX50SP2.UserResponse.MsgType: return new QuickFix.FIX50SP2.UserResponse();
                    case QuickFix.FIX50SP2.CollateralInquiryAck.MsgType: return new QuickFix.FIX50SP2.CollateralInquiryAck();
                    case QuickFix.FIX50SP2.ConfirmationRequest.MsgType: return new QuickFix.FIX50SP2.ConfirmationRequest();
                    case QuickFix.FIX50SP2.ContraryIntentionReport.MsgType: return new QuickFix.FIX50SP2.ContraryIntentionReport();
                    case QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.MsgType: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport();
                    case QuickFix.FIX50SP2.SecurityListUpdateReport.MsgType: return new QuickFix.FIX50SP2.SecurityListUpdateReport();
                    case QuickFix.FIX50SP2.AdjustedPositionReport.MsgType: return new QuickFix.FIX50SP2.AdjustedPositionReport();
                    case QuickFix.FIX50SP2.AllocationInstructionAlert.MsgType: return new QuickFix.FIX50SP2.AllocationInstructionAlert();
                    case QuickFix.FIX50SP2.ExecutionAcknowledgement.MsgType: return new QuickFix.FIX50SP2.ExecutionAcknowledgement();
                    case QuickFix.FIX50SP2.TradingSessionList.MsgType: return new QuickFix.FIX50SP2.TradingSessionList();
                    case QuickFix.FIX50SP2.TradingSessionListRequest.MsgType: return new QuickFix.FIX50SP2.TradingSessionListRequest();
                    case QuickFix.FIX50SP2.SettlementObligationReport.MsgType: return new QuickFix.FIX50SP2.SettlementObligationReport();
                    case QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.MsgType: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport();
                    case QuickFix.FIX50SP2.TradingSessionListUpdateReport.MsgType: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport();
                    case QuickFix.FIX50SP2.MarketDefinitionRequest.MsgType: return new QuickFix.FIX50SP2.MarketDefinitionRequest();
                    case QuickFix.FIX50SP2.MarketDefinition.MsgType: return new QuickFix.FIX50SP2.MarketDefinition();
                    case QuickFix.FIX50SP2.MarketDefinitionUpdateReport.MsgType: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport();
                    case QuickFix.FIX50SP2.ApplicationMessageRequest.MsgType: return new QuickFix.FIX50SP2.ApplicationMessageRequest();
                    case QuickFix.FIX50SP2.ApplicationMessageRequestAck.MsgType: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck();
                    case QuickFix.FIX50SP2.ApplicationMessageReport.MsgType: return new QuickFix.FIX50SP2.ApplicationMessageReport();
                    case QuickFix.FIX50SP2.OrderMassActionReport.MsgType: return new QuickFix.FIX50SP2.OrderMassActionReport();
                    case QuickFix.FIX50SP2.OrderMassActionRequest.MsgType: return new QuickFix.FIX50SP2.OrderMassActionRequest();
                    case QuickFix.FIX50SP2.UserNotification.MsgType: return new QuickFix.FIX50SP2.UserNotification();
                    case QuickFix.FIX50SP2.StreamAssignmentRequest.MsgType: return new QuickFix.FIX50SP2.StreamAssignmentRequest();
                    case QuickFix.FIX50SP2.StreamAssignmentReport.MsgType: return new QuickFix.FIX50SP2.StreamAssignmentReport();
                    case QuickFix.FIX50SP2.StreamAssignmentReportACK.MsgType: return new QuickFix.FIX50SP2.StreamAssignmentReportACK();
                    case QuickFix.FIX50SP2.PartyDetailsListRequest.MsgType: return new QuickFix.FIX50SP2.PartyDetailsListRequest();
                    case QuickFix.FIX50SP2.PartyDetailsListReport.MsgType: return new QuickFix.FIX50SP2.PartyDetailsListReport();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX50SP2.IOI.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.IOI.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.IOI.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.IOI.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.IOI.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.IOI.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.IOI.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.IOI.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50SP2.IOI.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.IOI.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.IOI.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Advertisement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Advertisement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Advertisement.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Advertisement.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Advertisement.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50SP2.ExecutionReport.NoContraBrokersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ExecutionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ExecutionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ExecutionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ExecutionReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.ExecutionReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP2.ExecutionReport.NoContAmtsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.ExecutionReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.ExecutionReport.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.ExecutionReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.ExecutionReport.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoFills: return new QuickFix.FIX50SP2.ExecutionReport.NoFillsGroup();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.ExecutionReport.NoRateSourcesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.News.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.News.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.News.NoLinesOfTextGroup();
                        case QuickFix.Fields.Tags.NoNewsRefIDs: return new QuickFix.FIX50SP2.News.NoNewsRefIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Email.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Email.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.Email.NoLinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderSingle.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderSingle.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderSingle.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderSingle.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderSingle.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderSingle.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderSingle.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.NewOrderSingle.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.NewOrderList.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderCancelRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderStatusRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationInstruction.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationInstruction.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstruction.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationInstruction.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationInstruction.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationInstruction.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationInstruction.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationInstruction.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.AllocationInstruction.NoRateSourcesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ListCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ListCancelRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.ListStatus.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.DontKnowTrade.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.DontKnowTrade.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.DontKnowTrade.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.DontKnowTrade.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.DontKnowTrade.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.Quote.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Quote.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Quote.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Quote.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Quote.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Quote.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.Quote.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Quote.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.Quote.NoRateSourcesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP2.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.MarketDataRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoAltMDSourceGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinition.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinition.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinition.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinition.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinition.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityStatus.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityStatus.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradingSessionStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradingSessionStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradingSessionStatus.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradingSessionStatus.NoComplexEventsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MassQuote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50SP2.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP2.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP2.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50SP2.RegistrationInstructions.NoRegistDtlsGroup();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50SP2.RegistrationInstructions.NoDistribInstsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructionsResponse.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoNotAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderCross.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderCross.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderCross.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderCross.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.NewOrderCross.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderCross.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderCross.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderCross.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50SP2.SecurityTypes.NoSecurityTypesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityListRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityListRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityListRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityListRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP2.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeEventsGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeEventsGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderMultileg.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderMultileg.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderMultileg.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderMultileg.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderMultileg.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderMultileg.NoStrategyParametersGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoStrategyParametersGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoDatesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.TradeCaptureReport.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.TradeCaptureReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoRootPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP2.TradeCaptureReport.NoTrdRepIndicatorsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RFQRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteStatusReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteStatusReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteStatusReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteStatusReport.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteResponse.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteResponse.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteResponse.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteResponse.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteResponse.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Confirmation.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.Confirmation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.Confirmation.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Confirmation.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Confirmation.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Confirmation.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Confirmation.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.Confirmation.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Confirmation.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50SP2.Confirmation.NoCapacitiesGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.Confirmation.NoDlvyInstGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.Confirmation.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.Confirmation.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP2.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP2.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RequestForPositions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositions.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RequestForPositions.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositions.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RequestForPositions.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RequestForPositions.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.RequestForPositions.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoRootPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoTrdRepIndicatorsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationReport.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationReport.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationReport.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.AllocationReport.NoRateSourcesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationReportAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationReportAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.SettlementInstructionRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AssignmentReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AssignmentReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AssignmentReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AssignmentReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AssignmentReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.AssignmentReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AssignmentReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralRequest.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralRequest.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralRequest.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralRequest.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralAssignment.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralAssignment.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralAssignment.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralAssignment.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralAssignment.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralAssignment.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralAssignment.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralAssignment.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralAssignment.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralAssignment.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralAssignment.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralResponse.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralResponse.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralResponse.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralResponse.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralResponse.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralResponse.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralResponse.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralResponse.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralReport.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralReport.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP2.CollateralInquiry.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralInquiry.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralInquiry.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiry.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralInquiry.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiry.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralInquiry.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralInquiry.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralInquiry.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralInquiry.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralInquiry.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.ConfirmationRequest.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ContraryIntentionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoExpirationGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AdjustedPositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationInstructionAlert.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ExecutionAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradingSessionList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SettlementObligationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlOblig: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup();
                    }
                }

                if (QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeEventsGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP2.TradingSessionListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.MarketDefinition.NoTickRulesGroup();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.MarketDefinition.NoLotTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.MarketDefinition.NoOrdTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.MarketDefinition.NoTimeInForceRulesGroup();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.MarketDefinition.NoExecInstRulesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoTickRulesGroup();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoLotTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoOrdTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoTimeInForceRulesGroup();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoExecInstRulesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ApplicationMessageRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoApplIDsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ApplicationMessageRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoApplIDsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.ApplicationMessageReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageReport.NoApplIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassActionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP2.OrderMassActionReport.NoAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassActionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassActionReport.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP2.OrderMassActionReport.NoNotAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassActionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoComplexEventsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoTargetPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.StreamAssignmentRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAsgnReqs: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.StreamAssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAsgnReqs: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.PartyDetailsListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyListResponseTypes: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyListResponseTypesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoRequestedPartyRoles: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoRequestedPartyRolesGroup();
                        case QuickFix.Fields.Tags.NoPartyRelationships: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyRelationshipsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.PartyDetailsListReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyList: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup();
                    }
                }

                return null;
            }

        }
    }
}
