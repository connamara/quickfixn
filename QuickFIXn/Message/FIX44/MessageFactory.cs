namespace QuickFix.FIX44
{
    public class MessageFactory : IMessageFactory
    {
        public QuickFix.Message Create(string beginString, string msgType)
        {
            switch(msgType)
            {
                case Heartbeat.MsgType: return new Heartbeat();
                case Logon.MsgType: return new Logon();
                case TestRequest.MsgType: return new TestRequest();
                case ResendRequest.MsgType: return new ResendRequest();
                case Reject.MsgType: return new Reject();
                case SequenceReset.MsgType: return new SequenceReset();
                case Logout.MsgType: return new Logout();
                case BusinessMessageReject.MsgType: return new BusinessMessageReject();
                case UserRequest.MsgType: return new UserRequest();
                case UserResponse.MsgType: return new UserResponse();
                case Advertisement.MsgType: return new Advertisement();
                case IndicationOfInterest.MsgType: return new IndicationOfInterest();
                case News.MsgType: return new News();
                case Email.MsgType: return new Email();
                case QuoteRequest.MsgType: return new QuoteRequest();
                case QuoteResponse.MsgType: return new QuoteResponse();
                case QuoteRequestReject.MsgType: return new QuoteRequestReject();
                case RFQRequest.MsgType: return new RFQRequest();
                case Quote.MsgType: return new Quote();
                case QuoteCancel.MsgType: return new QuoteCancel();
                case QuoteStatusRequest.MsgType: return new QuoteStatusRequest();
                case QuoteStatusReport.MsgType: return new QuoteStatusReport();
                case MassQuote.MsgType: return new MassQuote();
                case MassQuoteAcknowledgement.MsgType: return new MassQuoteAcknowledgement();
                case MarketDataRequest.MsgType: return new MarketDataRequest();
                case MarketDataSnapshotFullRefresh.MsgType: return new MarketDataSnapshotFullRefresh();
                case MarketDataIncrementalRefresh.MsgType: return new MarketDataIncrementalRefresh();
                case MarketDataRequestReject.MsgType: return new MarketDataRequestReject();
                case SecurityDefinitionRequest.MsgType: return new SecurityDefinitionRequest();
                case SecurityDefinition.MsgType: return new SecurityDefinition();
                case SecurityTypeRequest.MsgType: return new SecurityTypeRequest();
                case SecurityTypes.MsgType: return new SecurityTypes();
                case SecurityListRequest.MsgType: return new SecurityListRequest();
                case SecurityList.MsgType: return new SecurityList();
                case DerivativeSecurityListRequest.MsgType: return new DerivativeSecurityListRequest();
                case DerivativeSecurityList.MsgType: return new DerivativeSecurityList();
                case SecurityStatusRequest.MsgType: return new SecurityStatusRequest();
                case SecurityStatus.MsgType: return new SecurityStatus();
                case TradingSessionStatusRequest.MsgType: return new TradingSessionStatusRequest();
                case TradingSessionStatus.MsgType: return new TradingSessionStatus();
                case NewOrderSingle.MsgType: return new NewOrderSingle();
                case ExecutionReport.MsgType: return new ExecutionReport();
                case DontKnowTrade.MsgType: return new DontKnowTrade();
                case OrderCancelReplaceRequest.MsgType: return new OrderCancelReplaceRequest();
                case OrderCancelRequest.MsgType: return new OrderCancelRequest();
                case OrderCancelReject.MsgType: return new OrderCancelReject();
                case OrderStatusRequest.MsgType: return new OrderStatusRequest();
                case OrderMassCancelRequest.MsgType: return new OrderMassCancelRequest();
                case OrderMassCancelReport.MsgType: return new OrderMassCancelReport();
                case OrderMassStatusRequest.MsgType: return new OrderMassStatusRequest();
                case NewOrderCross.MsgType: return new NewOrderCross();
                case CrossOrderCancelReplaceRequest.MsgType: return new CrossOrderCancelReplaceRequest();
                case CrossOrderCancelRequest.MsgType: return new CrossOrderCancelRequest();
                case NewOrderMultileg.MsgType: return new NewOrderMultileg();
                case MultilegOrderCancelReplaceRequest.MsgType: return new MultilegOrderCancelReplaceRequest();
                case BidRequest.MsgType: return new BidRequest();
                case BidResponse.MsgType: return new BidResponse();
                case NewOrderList.MsgType: return new NewOrderList();
                case ListStrikePrice.MsgType: return new ListStrikePrice();
                case ListStatus.MsgType: return new ListStatus();
                case ListExecute.MsgType: return new ListExecute();
                case ListCancelRequest.MsgType: return new ListCancelRequest();
                case ListStatusRequest.MsgType: return new ListStatusRequest();
                case AllocationInstruction.MsgType: return new AllocationInstruction();
                case AllocationInstructionAck.MsgType: return new AllocationInstructionAck();
                case AllocationReport.MsgType: return new AllocationReport();
                case AllocationReportAck.MsgType: return new AllocationReportAck();
                case Confirmation.MsgType: return new Confirmation();
                case ConfirmationAck.MsgType: return new ConfirmationAck();
                case ConfirmationRequest.MsgType: return new ConfirmationRequest();
                case SettlementInstructions.MsgType: return new SettlementInstructions();
                case SettlementInstructionRequest.MsgType: return new SettlementInstructionRequest();
                case TradeCaptureReportRequest.MsgType: return new TradeCaptureReportRequest();
                case TradeCaptureReportRequestAck.MsgType: return new TradeCaptureReportRequestAck();
                case TradeCaptureReport.MsgType: return new TradeCaptureReport();
                case TradeCaptureReportAck.MsgType: return new TradeCaptureReportAck();
                case RegistrationInstructions.MsgType: return new RegistrationInstructions();
                case RegistrationInstructionsResponse.MsgType: return new RegistrationInstructionsResponse();
                case PositionMaintenanceRequest.MsgType: return new PositionMaintenanceRequest();
                case PositionMaintenanceReport.MsgType: return new PositionMaintenanceReport();
                case RequestForPositions.MsgType: return new RequestForPositions();
                case RequestForPositionsAck.MsgType: return new RequestForPositionsAck();
                case PositionReport.MsgType: return new PositionReport();
                case AssignmentReport.MsgType: return new AssignmentReport();
                case CollateralRequest.MsgType: return new CollateralRequest();
                case CollateralAssignment.MsgType: return new CollateralAssignment();
                case CollateralResponse.MsgType: return new CollateralResponse();
                case CollateralReport.MsgType: return new CollateralReport();
                case CollateralInquiry.MsgType: return new CollateralInquiry();
                case NetworkStatusRequest.MsgType: return new NetworkStatusRequest();
                case NetworkStatusResponse.MsgType: return new NetworkStatusResponse();
                case CollateralInquiryAck.MsgType: return new CollateralInquiryAck();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
            return null;
        }
    }
}
    