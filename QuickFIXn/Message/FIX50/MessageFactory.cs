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
          if(QuickFix.FIX50.IOI.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.IOI.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.IOI.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.IOI.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.IOI.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.IOI.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.IOI.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.IOI.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.IOI.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.IOI.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.IOI.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.IOI.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.IOI.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.IOI.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50.IOI.NoIOIQualifiersGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.IOI.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.IOI.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.IOI.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.Advertisement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Advertisement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Advertisement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Advertisement.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.Advertisement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Advertisement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.Advertisement.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Advertisement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.Advertisement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.Advertisement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ExecutionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50.ExecutionReport.NoContraBrokersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ExecutionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ExecutionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ExecutionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.ExecutionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ExecutionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.ExecutionReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50.ExecutionReport.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.ExecutionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.ExecutionReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.ExecutionReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.ExecutionReport.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.ExecutionReport.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.News.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.News.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.News.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.News.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.News.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.News.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.News.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.News.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.News.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.News.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50.News.NoLinesOfTextGroup();
              }
          }
          if(QuickFix.FIX50.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.Email.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.Email.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Email.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Email.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.Email.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.Email.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Email.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.Email.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50.Email.NoLinesOfTextGroup();
              }
          }
          if(QuickFix.FIX50.NewOrderSingle.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderSingle.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderSingle.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderSingle.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderSingle.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderSingle.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderSingle.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderSingle.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderSingle.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderSingle.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.NewOrderSingle.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50.NewOrderList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.NewOrderList.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50.NewOrderList.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.OrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.OrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.OrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50.OrderStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.OrderStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.AllocationInstruction.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationInstruction.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationInstruction.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationInstruction.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationInstruction.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationInstruction.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.AllocationInstruction.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationInstruction.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationInstruction.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.AllocationInstruction.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstruction.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AllocationInstruction.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationInstruction.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationInstruction.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50.ListCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ListCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.ListCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.ListStatus.NoOrdersGroup();
              }
          }
          if(QuickFix.FIX50.AllocationInstructionAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstructionAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstructionAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AllocationInstructionAck.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAck.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.DontKnowTrade.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.DontKnowTrade.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.DontKnowTrade.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.DontKnowTrade.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.DontKnowTrade.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.DontKnowTrade.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.DontKnowTrade.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.QuoteRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.Quote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.Quote.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.Quote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Quote.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Quote.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Quote.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.Quote.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Quote.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.Quote.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.Quote.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.Quote.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Quote.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.Quote.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.Quote.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.Quote.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.Quote.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.SettlementInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.MarketDataRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50.MarketDataRequest.NoMDEntryTypesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.MarketDataRequest.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX50.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX50.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX50.MarketDataRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50.MarketDataRequestReject.NoAltMDSourceGroup();
              }
          }
          if(QuickFix.FIX50.QuoteCancel.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteCancel.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.QuoteStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.QuoteStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.MassQuoteAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.SecurityDefinitionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinitionRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinitionRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.SubscriptionRequestType: return new QuickFix.FIX50.SecurityDefinitionRequest.SubscriptionRequestTypeGroup();
              }
          }
          if(QuickFix.FIX50.SecurityDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinition.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinition.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinition.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityDefinition.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityDefinition.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinition.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.ClearingBusinessDate: return new QuickFix.FIX50.SecurityDefinition.ClearingBusinessDateGroup();
              }
          }
          if(QuickFix.FIX50.SecurityStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.SecurityStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityStatus.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityStatus.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityStatus.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityStatus.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityStatus.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.TradingSessionStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradingSessionStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradingSessionStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradingSessionStatus.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.TradingSessionStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.MassQuote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MassQuote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.MassQuote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.BidRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50.BidRequest.NoBidDescriptorsGroup();
					case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50.BidRequest.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX50.BidResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50.BidResponse.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX50.ListStrikePrice.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50.ListStrikePrice.NoStrikesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ListStrikePrice.NoStrikesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.RegistrationInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RegistrationInstructions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.RegistrationInstructions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50.RegistrationInstructions.NoRegistDtlsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50.RegistrationInstructions.NoDistribInstsGroup();
              }
          }
          if(QuickFix.FIX50.RegistrationInstructionsResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RegistrationInstructionsResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.OrderMassCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.OrderMassCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassCancelRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.OrderMassCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.OrderMassCancelReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50.OrderMassCancelReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassCancelReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassCancelReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassCancelReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.OrderMassCancelReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassCancelReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassCancelReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.OrderMassCancelReport.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.NewOrderCross.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderCross.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderCross.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderCross.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderCross.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderCross.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.NewOrderCross.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.NewOrderCross.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderCross.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderCross.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderCross.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.NewOrderCross.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50.NewOrderCross.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.CrossOrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CrossOrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.SecurityTypes.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50.SecurityTypes.NoSecurityTypesGroup();
              }
          }
          if(QuickFix.FIX50.SecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityListRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityListRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityListRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityListRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityListRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityListRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityListRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.SecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
              }
          }
          if(QuickFix.FIX50.DerivativeSecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.DerivativeSecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DerivativeSecurityList.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.NewOrderMultileg.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderMultileg.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.NewOrderMultileg.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderMultileg.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderMultileg.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderMultileg.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderMultileg.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderMultileg.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderMultileg.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderMultileg.NoStrategyParametersGroup();
              }
          }
          if(QuickFix.FIX50.MultilegOrderCancelReplace.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoStrategyParametersGroup();
              }
          }
          if(QuickFix.FIX50.TradeCaptureReportRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50.TradeCaptureReportRequest.NoDatesGroup();
              }
          }
          if(QuickFix.FIX50.TradeCaptureReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.TradeCaptureReport.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.TradeCaptureReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.TradeCaptureReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSideTrdRegTS: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup.NoSideTrdRegTSGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.TradeCaptureReport.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50.TradeCaptureReport.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.OrderMassStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.OrderMassStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassStatusRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.QuoteRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.RFQRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.QuoteStatusReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteStatusReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteStatusReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteStatusReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteStatusReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteStatusReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteStatusReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteStatusReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.QuoteStatusReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.QuoteStatusReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteStatusReport.NoQuoteQualifiersGroup();
              }
          }
          if(QuickFix.FIX50.QuoteResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteResponse.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.QuoteResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteResponse.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteResponse.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.QuoteResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.QuoteResponse.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.Confirmation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.Confirmation.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.Confirmation.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.Confirmation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.Confirmation.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Confirmation.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Confirmation.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Confirmation.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.Confirmation.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.Confirmation.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Confirmation.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.Confirmation.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.Confirmation.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Confirmation.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.Confirmation.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50.Confirmation.NoCapacitiesGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.Confirmation.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.Confirmation.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.Confirmation.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX50.PositionMaintenanceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionMaintenanceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.PositionMaintenanceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50.PositionMaintenanceReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionMaintenanceReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionMaintenanceReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.PositionMaintenanceReport.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionMaintenanceReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionMaintenanceReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50.RequestForPositions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RequestForPositions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.RequestForPositions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RequestForPositions.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RequestForPositions.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RequestForPositions.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.RequestForPositions.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RequestForPositions.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.RequestForPositions.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RequestForPositions.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.RequestForPositions.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX50.RequestForPositionsAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RequestForPositionsAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.RequestForPositionsAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RequestForPositionsAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RequestForPositionsAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RequestForPositionsAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.RequestForPositionsAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RequestForPositionsAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.RequestForPositionsAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.PositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.PositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.PositionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.PositionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingAmounts: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup.NoUnderlyingAmountsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.TradeCaptureReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.TradeCaptureReportAck.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSideTrdRegTS: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup.NoSideTrdRegTSGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.AllocationReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationReport.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.AllocationReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationReport.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.AllocationReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.AllocationReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AllocationReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50.AllocationReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationReportAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AllocationReportAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationReportAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AllocationReportAck.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AllocationReportAck.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.SettlementInstructionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.SettlementInstructionRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.SettlementInstructionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.AssignmentReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AssignmentReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AssignmentReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AssignmentReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AssignmentReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AssignmentReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.AssignmentReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AssignmentReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.AssignmentReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AssignmentReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.AssignmentReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AssignmentReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50.CollateralRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CollateralRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralRequest.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralRequest.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CollateralRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralRequest.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralRequest.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50.CollateralAssignment.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralAssignment.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CollateralAssignment.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralAssignment.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralAssignment.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralAssignment.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralAssignment.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralAssignment.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralAssignment.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralAssignment.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CollateralAssignment.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralAssignment.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralAssignment.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralAssignment.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralAssignment.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.CollateralResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CollateralResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralResponse.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralResponse.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralResponse.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CollateralResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralResponse.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralResponse.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralResponse.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50.CollateralReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CollateralReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralReport.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CollateralReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CollateralReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralReport.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.CollateralInquiry.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50.CollateralInquiry.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralInquiry.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralInquiry.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralInquiry.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralInquiry.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralInquiry.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralInquiry.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralInquiry.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralInquiry.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CollateralInquiry.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralInquiry.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralInquiry.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralInquiry.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX50.CollateralInquiryAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50.CollateralInquiryAck.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralInquiryAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.CollateralInquiryAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralInquiryAck.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralInquiryAck.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralInquiryAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralInquiryAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralInquiryAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralInquiryAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralInquiryAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.CollateralInquiryAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.ConfirmationRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.ConfirmationRequest.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.ContraryIntentionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ContraryIntentionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.ContraryIntentionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50.ContraryIntentionReport.NoExpirationGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ContraryIntentionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ContraryIntentionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ContraryIntentionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.ContraryIntentionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.SecurityListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50.AdjustedPositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.AdjustedPositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AdjustedPositionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AdjustedPositionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AdjustedPositionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.AllocationInstructionAlert.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationInstructionAlert.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationInstructionAlert.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationInstructionAlert.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationInstructionAlert.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationInstructionAlert.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.AllocationInstructionAlert.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationInstructionAlert.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationInstructionAlert.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50.ExecutionAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ExecutionAcknowledgement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ExecutionAcknowledgement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ExecutionAcknowledgement.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50.ExecutionAcknowledgement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.ExecutionAcknowledgement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50.ExecutionAcknowledgement.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50.TradingSessionList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.TradingSessionList.NoTradingSessionsGroup();
              }
          }
            return null;
        }
    }
}
    