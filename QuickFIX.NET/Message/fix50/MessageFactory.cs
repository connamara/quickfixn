// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX50
    {
        public class MessageFactory : IMessageFactory
        {
            public Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX50.IOI.MsgType: return new QuickFix.FIX50.IOI();
                    case QuickFix.FIX50.Advertisement.MsgType: return new QuickFix.FIX50.Advertisement();
                    case QuickFix.FIX50.ExecutionReport.MsgType: return new QuickFix.FIX50.ExecutionReport();
                    case QuickFix.FIX50.OrderCancelReject.MsgType: return new QuickFix.FIX50.OrderCancelReject();
                    case QuickFix.FIX50.News.MsgType: return new QuickFix.FIX50.News();
                    case QuickFix.FIX50.Email.MsgType: return new QuickFix.FIX50.Email();
                    case QuickFix.FIX50.NewOrderSingle.MsgType: return new QuickFix.FIX50.NewOrderSingle();
                    case QuickFix.FIX50.NewOrderList.MsgType: return new QuickFix.FIX50.NewOrderList();
                    case QuickFix.FIX50.OrderCancelRequest.MsgType: return new QuickFix.FIX50.OrderCancelRequest();
                    case QuickFix.FIX50.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50.OrderCancelReplaceRequest();
                    case QuickFix.FIX50.OrderStatusRequest.MsgType: return new QuickFix.FIX50.OrderStatusRequest();
                    case QuickFix.FIX50.AllocationInstruction.MsgType: return new QuickFix.FIX50.AllocationInstruction();
                    case QuickFix.FIX50.ListCancelRequest.MsgType: return new QuickFix.FIX50.ListCancelRequest();
                    case QuickFix.FIX50.ListExecute.MsgType: return new QuickFix.FIX50.ListExecute();
                    case QuickFix.FIX50.ListStatusRequest.MsgType: return new QuickFix.FIX50.ListStatusRequest();
                    case QuickFix.FIX50.ListStatus.MsgType: return new QuickFix.FIX50.ListStatus();
                    case QuickFix.FIX50.AllocationInstructionAck.MsgType: return new QuickFix.FIX50.AllocationInstructionAck();
                    case QuickFix.FIX50.DontKnowTrade.MsgType: return new QuickFix.FIX50.DontKnowTrade();
                    case QuickFix.FIX50.QuoteRequest.MsgType: return new QuickFix.FIX50.QuoteRequest();
                    case QuickFix.FIX50.Quote.MsgType: return new QuickFix.FIX50.Quote();
                    case QuickFix.FIX50.SettlementInstructions.MsgType: return new QuickFix.FIX50.SettlementInstructions();
                    case QuickFix.FIX50.MarketDataRequest.MsgType: return new QuickFix.FIX50.MarketDataRequest();
                    case QuickFix.FIX50.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX50.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX50.MarketDataIncrementalRefresh();
                    case QuickFix.FIX50.MarketDataRequestReject.MsgType: return new QuickFix.FIX50.MarketDataRequestReject();
                    case QuickFix.FIX50.QuoteCancel.MsgType: return new QuickFix.FIX50.QuoteCancel();
                    case QuickFix.FIX50.QuoteStatusRequest.MsgType: return new QuickFix.FIX50.QuoteStatusRequest();
                    case QuickFix.FIX50.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX50.MassQuoteAcknowledgement();
                    case QuickFix.FIX50.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX50.SecurityDefinitionRequest();
                    case QuickFix.FIX50.SecurityDefinition.MsgType: return new QuickFix.FIX50.SecurityDefinition();
                    case QuickFix.FIX50.SecurityStatusRequest.MsgType: return new QuickFix.FIX50.SecurityStatusRequest();
                    case QuickFix.FIX50.SecurityStatus.MsgType: return new QuickFix.FIX50.SecurityStatus();
                    case QuickFix.FIX50.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX50.TradingSessionStatusRequest();
                    case QuickFix.FIX50.TradingSessionStatus.MsgType: return new QuickFix.FIX50.TradingSessionStatus();
                    case QuickFix.FIX50.MassQuote.MsgType: return new QuickFix.FIX50.MassQuote();
                    case QuickFix.FIX50.BusinessMessageReject.MsgType: return new QuickFix.FIX50.BusinessMessageReject();
                    case QuickFix.FIX50.BidRequest.MsgType: return new QuickFix.FIX50.BidRequest();
                    case QuickFix.FIX50.BidResponse.MsgType: return new QuickFix.FIX50.BidResponse();
                    case QuickFix.FIX50.ListStrikePrice.MsgType: return new QuickFix.FIX50.ListStrikePrice();
                    case QuickFix.FIX50.RegistrationInstructions.MsgType: return new QuickFix.FIX50.RegistrationInstructions();
                    case QuickFix.FIX50.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX50.RegistrationInstructionsResponse();
                    case QuickFix.FIX50.OrderMassCancelRequest.MsgType: return new QuickFix.FIX50.OrderMassCancelRequest();
                    case QuickFix.FIX50.OrderMassCancelReport.MsgType: return new QuickFix.FIX50.OrderMassCancelReport();
                    case QuickFix.FIX50.NewOrderCross.MsgType: return new QuickFix.FIX50.NewOrderCross();
                    case QuickFix.FIX50.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX50.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX50.CrossOrderCancelRequest();
                    case QuickFix.FIX50.SecurityTypeRequest.MsgType: return new QuickFix.FIX50.SecurityTypeRequest();
                    case QuickFix.FIX50.SecurityTypes.MsgType: return new QuickFix.FIX50.SecurityTypes();
                    case QuickFix.FIX50.SecurityListRequest.MsgType: return new QuickFix.FIX50.SecurityListRequest();
                    case QuickFix.FIX50.SecurityList.MsgType: return new QuickFix.FIX50.SecurityList();
                    case QuickFix.FIX50.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX50.DerivativeSecurityListRequest();
                    case QuickFix.FIX50.DerivativeSecurityList.MsgType: return new QuickFix.FIX50.DerivativeSecurityList();
                    case QuickFix.FIX50.NewOrderMultileg.MsgType: return new QuickFix.FIX50.NewOrderMultileg();
                    case QuickFix.FIX50.MultilegOrderCancelReplace.MsgType: return new QuickFix.FIX50.MultilegOrderCancelReplace();
                    case QuickFix.FIX50.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX50.TradeCaptureReportRequest();
                    case QuickFix.FIX50.TradeCaptureReport.MsgType: return new QuickFix.FIX50.TradeCaptureReport();
                    case QuickFix.FIX50.OrderMassStatusRequest.MsgType: return new QuickFix.FIX50.OrderMassStatusRequest();
                    case QuickFix.FIX50.QuoteRequestReject.MsgType: return new QuickFix.FIX50.QuoteRequestReject();
                    case QuickFix.FIX50.RFQRequest.MsgType: return new QuickFix.FIX50.RFQRequest();
                    case QuickFix.FIX50.QuoteStatusReport.MsgType: return new QuickFix.FIX50.QuoteStatusReport();
                    case QuickFix.FIX50.QuoteResponse.MsgType: return new QuickFix.FIX50.QuoteResponse();
                    case QuickFix.FIX50.Confirmation.MsgType: return new QuickFix.FIX50.Confirmation();
                    case QuickFix.FIX50.PositionMaintenanceRequest.MsgType: return new QuickFix.FIX50.PositionMaintenanceRequest();
                    case QuickFix.FIX50.PositionMaintenanceReport.MsgType: return new QuickFix.FIX50.PositionMaintenanceReport();
                    case QuickFix.FIX50.RequestForPositions.MsgType: return new QuickFix.FIX50.RequestForPositions();
                    case QuickFix.FIX50.RequestForPositionsAck.MsgType: return new QuickFix.FIX50.RequestForPositionsAck();
                    case QuickFix.FIX50.PositionReport.MsgType: return new QuickFix.FIX50.PositionReport();
                    case QuickFix.FIX50.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FIX50.TradeCaptureReportRequestAck();
                    case QuickFix.FIX50.TradeCaptureReportAck.MsgType: return new QuickFix.FIX50.TradeCaptureReportAck();
                    case QuickFix.FIX50.AllocationReport.MsgType: return new QuickFix.FIX50.AllocationReport();
                    case QuickFix.FIX50.AllocationReportAck.MsgType: return new QuickFix.FIX50.AllocationReportAck();
                    case QuickFix.FIX50.ConfirmationAck.MsgType: return new QuickFix.FIX50.ConfirmationAck();
                    case QuickFix.FIX50.SettlementInstructionRequest.MsgType: return new QuickFix.FIX50.SettlementInstructionRequest();
                    case QuickFix.FIX50.AssignmentReport.MsgType: return new QuickFix.FIX50.AssignmentReport();
                    case QuickFix.FIX50.CollateralRequest.MsgType: return new QuickFix.FIX50.CollateralRequest();
                    case QuickFix.FIX50.CollateralAssignment.MsgType: return new QuickFix.FIX50.CollateralAssignment();
                    case QuickFix.FIX50.CollateralResponse.MsgType: return new QuickFix.FIX50.CollateralResponse();
                    case QuickFix.FIX50.CollateralReport.MsgType: return new QuickFix.FIX50.CollateralReport();
                    case QuickFix.FIX50.CollateralInquiry.MsgType: return new QuickFix.FIX50.CollateralInquiry();
                    case QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.MsgType: return new QuickFix.FIX50.NetworkCounterpartySystemStatusRequest();
                    case QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.MsgType: return new QuickFix.FIX50.NetworkCounterpartySystemStatusResponse();
                    case QuickFix.FIX50.UserRequest.MsgType: return new QuickFix.FIX50.UserRequest();
                    case QuickFix.FIX50.UserResponse.MsgType: return new QuickFix.FIX50.UserResponse();
                    case QuickFix.FIX50.CollateralInquiryAck.MsgType: return new QuickFix.FIX50.CollateralInquiryAck();
                    case QuickFix.FIX50.ConfirmationRequest.MsgType: return new QuickFix.FIX50.ConfirmationRequest();
                    case QuickFix.FIX50.ContraryIntentionReport.MsgType: return new QuickFix.FIX50.ContraryIntentionReport();
                    case QuickFix.FIX50.SecurityDefinitionUpdateReport.MsgType: return new QuickFix.FIX50.SecurityDefinitionUpdateReport();
                    case QuickFix.FIX50.SecurityListUpdateReport.MsgType: return new QuickFix.FIX50.SecurityListUpdateReport();
                    case QuickFix.FIX50.AdjustedPositionReport.MsgType: return new QuickFix.FIX50.AdjustedPositionReport();
                    case QuickFix.FIX50.AllocationInstructionAlert.MsgType: return new QuickFix.FIX50.AllocationInstructionAlert();
                    case QuickFix.FIX50.ExecutionAcknowledgement.MsgType: return new QuickFix.FIX50.ExecutionAcknowledgement();
                    case QuickFix.FIX50.TradingSessionList.MsgType: return new QuickFix.FIX50.TradingSessionList();
                    case QuickFix.FIX50.TradingSessionListRequest.MsgType: return new QuickFix.FIX50.TradingSessionListRequest();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                throw new System.Exception();
            }

        }
    }
}
