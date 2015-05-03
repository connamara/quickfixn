namespace QuickFix.FIX50
{
    public class MessageFactory : IMessageFactory
    {
        public QuickFix.Message Create(string beginString, string msgType)
        {
            switch(msgType)
            {
                case IOI.MsgType: return new IOI();
                case Advertisement.MsgType: return new Advertisement();
                case ExecutionReport.MsgType: return new ExecutionReport();
                case OrderCancelReject.MsgType: return new OrderCancelReject();
                case News.MsgType: return new News();
                case Email.MsgType: return new Email();
                case NewOrderSingle.MsgType: return new NewOrderSingle();
                case NewOrderList.MsgType: return new NewOrderList();
                case OrderCancelRequest.MsgType: return new OrderCancelRequest();
                case OrderCancelReplaceRequest.MsgType: return new OrderCancelReplaceRequest();
                case OrderStatusRequest.MsgType: return new OrderStatusRequest();
                case AllocationInstruction.MsgType: return new AllocationInstruction();
                case ListCancelRequest.MsgType: return new ListCancelRequest();
                case ListExecute.MsgType: return new ListExecute();
                case ListStatusRequest.MsgType: return new ListStatusRequest();
                case ListStatus.MsgType: return new ListStatus();
                case AllocationInstructionAck.MsgType: return new AllocationInstructionAck();
                case DontKnowTrade.MsgType: return new DontKnowTrade();
                case QuoteRequest.MsgType: return new QuoteRequest();
                case Quote.MsgType: return new Quote();
                case SettlementInstructions.MsgType: return new SettlementInstructions();
                case MarketDataRequest.MsgType: return new MarketDataRequest();
                case MarketDataSnapshotFullRefresh.MsgType: return new MarketDataSnapshotFullRefresh();
                case MarketDataIncrementalRefresh.MsgType: return new MarketDataIncrementalRefresh();
                case MarketDataRequestReject.MsgType: return new MarketDataRequestReject();
                case QuoteCancel.MsgType: return new QuoteCancel();
                case QuoteStatusRequest.MsgType: return new QuoteStatusRequest();
                case MassQuoteAcknowledgement.MsgType: return new MassQuoteAcknowledgement();
                case SecurityDefinitionRequest.MsgType: return new SecurityDefinitionRequest();
                case SecurityDefinition.MsgType: return new SecurityDefinition();
                case SecurityStatusRequest.MsgType: return new SecurityStatusRequest();
                case SecurityStatus.MsgType: return new SecurityStatus();
                case TradingSessionStatusRequest.MsgType: return new TradingSessionStatusRequest();
                case TradingSessionStatus.MsgType: return new TradingSessionStatus();
                case MassQuote.MsgType: return new MassQuote();
                case BusinessMessageReject.MsgType: return new BusinessMessageReject();
                case BidRequest.MsgType: return new BidRequest();
                case BidResponse.MsgType: return new BidResponse();
                case ListStrikePrice.MsgType: return new ListStrikePrice();
                case RegistrationInstructions.MsgType: return new RegistrationInstructions();
                case RegistrationInstructionsResponse.MsgType: return new RegistrationInstructionsResponse();
                case OrderMassCancelRequest.MsgType: return new OrderMassCancelRequest();
                case OrderMassCancelReport.MsgType: return new OrderMassCancelReport();
                case NewOrderCross.MsgType: return new NewOrderCross();
                case CrossOrderCancelReplaceRequest.MsgType: return new CrossOrderCancelReplaceRequest();
                case CrossOrderCancelRequest.MsgType: return new CrossOrderCancelRequest();
                case SecurityTypeRequest.MsgType: return new SecurityTypeRequest();
                case SecurityTypes.MsgType: return new SecurityTypes();
                case SecurityListRequest.MsgType: return new SecurityListRequest();
                case SecurityList.MsgType: return new SecurityList();
                case DerivativeSecurityListRequest.MsgType: return new DerivativeSecurityListRequest();
                case DerivativeSecurityList.MsgType: return new DerivativeSecurityList();
                case NewOrderMultileg.MsgType: return new NewOrderMultileg();
                case MultilegOrderCancelReplace.MsgType: return new MultilegOrderCancelReplace();
                case TradeCaptureReportRequest.MsgType: return new TradeCaptureReportRequest();
                case TradeCaptureReport.MsgType: return new TradeCaptureReport();
                case OrderMassStatusRequest.MsgType: return new OrderMassStatusRequest();
                case QuoteRequestReject.MsgType: return new QuoteRequestReject();
                case RFQRequest.MsgType: return new RFQRequest();
                case QuoteStatusReport.MsgType: return new QuoteStatusReport();
                case QuoteResponse.MsgType: return new QuoteResponse();
                case Confirmation.MsgType: return new Confirmation();
                case PositionMaintenanceRequest.MsgType: return new PositionMaintenanceRequest();
                case PositionMaintenanceReport.MsgType: return new PositionMaintenanceReport();
                case RequestForPositions.MsgType: return new RequestForPositions();
                case RequestForPositionsAck.MsgType: return new RequestForPositionsAck();
                case PositionReport.MsgType: return new PositionReport();
                case TradeCaptureReportRequestAck.MsgType: return new TradeCaptureReportRequestAck();
                case TradeCaptureReportAck.MsgType: return new TradeCaptureReportAck();
                case AllocationReport.MsgType: return new AllocationReport();
                case AllocationReportAck.MsgType: return new AllocationReportAck();
                case ConfirmationAck.MsgType: return new ConfirmationAck();
                case SettlementInstructionRequest.MsgType: return new SettlementInstructionRequest();
                case AssignmentReport.MsgType: return new AssignmentReport();
                case CollateralRequest.MsgType: return new CollateralRequest();
                case CollateralAssignment.MsgType: return new CollateralAssignment();
                case CollateralResponse.MsgType: return new CollateralResponse();
                case CollateralReport.MsgType: return new CollateralReport();
                case CollateralInquiry.MsgType: return new CollateralInquiry();
                case NetworkCounterpartySystemStatusRequest.MsgType: return new NetworkCounterpartySystemStatusRequest();
                case NetworkCounterpartySystemStatusResponse.MsgType: return new NetworkCounterpartySystemStatusResponse();
                case UserRequest.MsgType: return new UserRequest();
                case UserResponse.MsgType: return new UserResponse();
                case CollateralInquiryAck.MsgType: return new CollateralInquiryAck();
                case ConfirmationRequest.MsgType: return new ConfirmationRequest();
                case ContraryIntentionReport.MsgType: return new ContraryIntentionReport();
                case SecurityDefinitionUpdateReport.MsgType: return new SecurityDefinitionUpdateReport();
                case SecurityListUpdateReport.MsgType: return new SecurityListUpdateReport();
                case AdjustedPositionReport.MsgType: return new AdjustedPositionReport();
                case AllocationInstructionAlert.MsgType: return new AllocationInstructionAlert();
                case ExecutionAcknowledgement.MsgType: return new ExecutionAcknowledgement();
                case TradingSessionList.MsgType: return new TradingSessionList();
                case TradingSessionListRequest.MsgType: return new TradingSessionListRequest();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
            return null;
        }
    }
}
    