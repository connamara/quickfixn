// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX44
    {
        public class MessageFactory : IMessageFactory
        {
            public Message Create(string beginString, string msgType)
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
                throw new System.Exception();
            }

        }
    }
}
