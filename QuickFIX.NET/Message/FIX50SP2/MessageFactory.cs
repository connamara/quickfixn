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
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.IOI.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.IOI.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.IOI.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.IOI.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.IOI.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.IOI.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.IOI.NoLegs();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50SP2.IOI.NoIOIQualifiers();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.IOI.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.IOI.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Advertisement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Advertisement.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Advertisement.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Advertisement.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Advertisement.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP2.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50SP2.ExecutionReport.NoContraBrokers();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ExecutionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ExecutionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ExecutionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ExecutionReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.ExecutionReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP2.ExecutionReport.NoContAmts();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.ExecutionReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.ExecutionReport.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.ExecutionReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.ExecutionReport.NoAllocs();
                        case QuickFix.Fields.Tags.NoFills: return new QuickFix.FIX50SP2.ExecutionReport.NoFills();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.ExecutionReport.NoRateSources();
                    }
                }

                if (QuickFix.FIX50SP2.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.News.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.News.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.News.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.News.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.News.NoLinesOfText();
                        case QuickFix.Fields.Tags.NoNewsRefIDs: return new QuickFix.FIX50SP2.News.NoNewsRefIDs();
                    }
                }

                if (QuickFix.FIX50SP2.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.Email.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.Email.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Email.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Email.NoLegs();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.Email.NoLinesOfText();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderSingle.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderSingle.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderSingle.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderSingle.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderSingle.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderSingle.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderSingle.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderSingle.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.NewOrderSingle.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.NewOrderList.NoOrders();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.NewOrderList.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderCancelRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50SP2.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderStatusRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationInstruction.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationInstruction.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstruction.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationInstruction.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationInstruction.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationInstruction.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationInstruction.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationInstruction.NoPosAmt();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.AllocationInstruction.NoRateSources();
                    }
                }

                if (QuickFix.FIX50SP2.ListCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ListCancelRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.ListStatus.NoOrders();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX50SP2.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.DontKnowTrade.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.DontKnowTrade.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.DontKnowTrade.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.DontKnowTrade.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.DontKnowTrade.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.Quote.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Quote.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Quote.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Quote.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Quote.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Quote.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.Quote.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Quote.NoLegs();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.Quote.NoRateSources();
                    }
                }

                if (QuickFix.FIX50SP2.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInst();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP2.MarketDataRequest.NoMDEntryTypes();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.MarketDataRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoLegs();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntries();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntries();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoAltMDSource();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntries();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSets();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinition.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinition.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinition.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinition.NoLegs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinition.NoStipulations();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegments();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityStatus.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityStatus.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradingSessionStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradingSessionStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradingSessionStatus.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradingSessionStatus.NoComplexEvents();
                    }
                }

                if (QuickFix.FIX50SP2.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MassQuote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX50SP2.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50SP2.BidRequest.NoBidDescriptors();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP2.BidRequest.NoBidComponents();
                    }
                }

                if (QuickFix.FIX50SP2.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP2.BidResponse.NoBidComponents();
                    }
                }

                if (QuickFix.FIX50SP2.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikes();
                    }
                }

                if (QuickFix.FIX50SP2.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50SP2.RegistrationInstructions.NoRegistDtls();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50SP2.RegistrationInstructions.NoDistribInsts();
                    }
                }

                if (QuickFix.FIX50SP2.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructionsResponse.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoNotAffectedOrders();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.NewOrderCross.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderCross.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderCross.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderCross.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderCross.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.NewOrderCross.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderCross.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderCross.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderCross.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50SP2.SecurityTypes.NoSecurityTypes();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityListRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityListRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityListRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityListRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP2.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeSecurityAltID();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeEvents();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeInstrumentParties();
                    }
                }

                if (QuickFix.FIX50SP2.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeSecurityAltID();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeEvents();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrAttrib();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegments();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderMultileg.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderMultileg.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderMultileg.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderMultileg.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderMultileg.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegs();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderMultileg.NoStrategyParameters();
                    }
                }

                if (QuickFix.FIX50SP2.MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegs();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoStrategyParameters();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoDates();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.TradeCaptureReport.NoPosAmt();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegs();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.TradeCaptureReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSides();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoRootPartyIDs();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP2.TradeCaptureReport.NoTrdRepIndicators();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RFQRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteStatusReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteStatusReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteStatusReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegs();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteStatusReport.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteResponse.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteResponse.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteResponse.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteResponse.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteResponse.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Confirmation.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.Confirmation.NoOrders();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.Confirmation.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Confirmation.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Confirmation.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Confirmation.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Confirmation.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.Confirmation.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Confirmation.NoLegs();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50SP2.Confirmation.NoCapacities();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.Confirmation.NoDlvyInst();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.Confirmation.NoStipulations();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.Confirmation.NoMiscFees();
                    }
                }

                if (QuickFix.FIX50SP2.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP2.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP2.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RequestForPositions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositions.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RequestForPositions.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositions.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RequestForPositions.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RequestForPositions.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.RequestForPositions.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50SP2.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP2.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoPosAmt();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSides();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoRootPartyIDs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoTrdRepIndicators();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationReport.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationReport.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationReport.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationReport.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationReport.NoPosAmt();
                        case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.AllocationReport.NoRateSources();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationReportAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationReportAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX50SP2.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.SettlementInstructionRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AssignmentReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AssignmentReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AssignmentReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AssignmentReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AssignmentReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.AssignmentReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AssignmentReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralRequest.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralRequest.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralRequest.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralRequest.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralAssignment.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralAssignment.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralAssignment.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralAssignment.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralAssignment.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralAssignment.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralAssignment.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralAssignment.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralAssignment.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralAssignment.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralAssignment.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralResponse.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralResponse.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralResponse.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralResponse.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralResponse.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralResponse.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralResponse.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralResponse.NoStipulations();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralReport.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralReport.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralReport.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP2.CollateralInquiry.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralInquiry.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralInquiry.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiry.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralInquiry.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiry.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralInquiry.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralInquiry.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralInquiry.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralInquiry.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralInquiry.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.NoCompIDs();
                    }
                }

                if (QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.NoCompIDs();
                    }
                }

                if (QuickFix.FIX50SP2.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP2.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.ConfirmationRequest.NoOrders();
                    }
                }

                if (QuickFix.FIX50SP2.ContraryIntentionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoExpiration();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoLegs();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegments();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP2.AdjustedPositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP2.AllocationInstructionAlert.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoStipulations();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPosAmt();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocs();
                    }
                }

                if (QuickFix.FIX50SP2.ExecutionAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP2.TradingSessionList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50SP2.SettlementObligationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlOblig: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlOblig();
                    }
                }

                if (QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeSecurityAltID();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeEvents();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrAttrib();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegments();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP2.TradingSessionListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.MarketDefinition.NoTickRules();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.MarketDefinition.NoLotTypeRules();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.MarketDefinition.NoOrdTypeRules();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.MarketDefinition.NoTimeInForceRules();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.MarketDefinition.NoExecInstRules();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoTickRules();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoLotTypeRules();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoOrdTypeRules();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoTimeInForceRules();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoExecInstRules();
                    }
                }

                if (QuickFix.FIX50SP2.ApplicationMessageRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoApplIDs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.ApplicationMessageRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoApplIDs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.ApplicationMessageReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageReport.NoApplIDs();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassActionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP2.OrderMassActionReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassActionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassActionReport.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP2.OrderMassActionReport.NoNotAffectedOrders();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassActionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoComplexEvents();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoTargetPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP2.StreamAssignmentRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAsgnReqs: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqs();
                    }
                }

                if (QuickFix.FIX50SP2.StreamAssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAsgnReqs: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqs();
                    }
                }

                if (QuickFix.FIX50SP2.PartyDetailsListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyListResponseTypes: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyListResponseTypes();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoRequestedPartyRoles: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoRequestedPartyRoles();
                        case QuickFix.Fields.Tags.NoPartyRelationships: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyRelationships();
                    }
                }

                if (QuickFix.FIX50SP2.PartyDetailsListReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyList: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyList();
                    }
                }

                return null;
            }

        }
    }
}
