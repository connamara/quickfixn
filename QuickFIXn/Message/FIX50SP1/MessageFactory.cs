namespace QuickFix.FIX50SP1
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
                case SettlementObligationReport.MsgType: return new SettlementObligationReport();
                case DerivativeSecurityListUpdateReport.MsgType: return new DerivativeSecurityListUpdateReport();
                case TradingSessionListUpdateReport.MsgType: return new TradingSessionListUpdateReport();
                case MarketDefinitionRequest.MsgType: return new MarketDefinitionRequest();
                case MarketDefinition.MsgType: return new MarketDefinition();
                case MarketDefinitionUpdateReport.MsgType: return new MarketDefinitionUpdateReport();
                case ApplicationMessageRequest.MsgType: return new ApplicationMessageRequest();
                case ApplicationMessageRequestAck.MsgType: return new ApplicationMessageRequestAck();
                case ApplicationMessageReport.MsgType: return new ApplicationMessageReport();
                case OrderMassActionReport.MsgType: return new OrderMassActionReport();
                case OrderMassActionRequest.MsgType: return new OrderMassActionRequest();
                case UserNotification.MsgType: return new UserNotification();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
          if(QuickFix.FIX50SP1.IOI.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.IOI.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.IOI.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.IOI.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.IOI.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.IOI.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.IOI.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.IOI.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.IOI.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.IOI.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.IOI.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.IOI.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.IOI.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.IOI.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50SP1.IOI.NoIOIQualifiersGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.IOI.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.IOI.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.IOI.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.Advertisement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Advertisement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Advertisement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Advertisement.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Advertisement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Advertisement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.Advertisement.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50SP1.ExecutionReport.NoContraBrokersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ExecutionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ExecutionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ExecutionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.ExecutionReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP1.ExecutionReport.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.ExecutionReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.ExecutionReport.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.ExecutionReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.ExecutionReport.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoFills: return new QuickFix.FIX50SP1.ExecutionReport.NoFillsGroup();
					case QuickFix.Fields.Tags.NoNested4PartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoFillsGroup.NoNested4PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested4PartySubIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoFillsGroup.NoNested4PartyIDsGroup.NoNested4PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.News.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.News.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.News.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.News.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.News.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.News.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.News.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.News.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.News.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.News.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP1.News.NoLinesOfTextGroup();
              }
          }
          if(QuickFix.FIX50SP1.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.Email.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.Email.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Email.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Email.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.Email.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.Email.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Email.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.Email.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP1.Email.NoLinesOfTextGroup();
              }
          }
          if(QuickFix.FIX50SP1.NewOrderSingle.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderSingle.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderSingle.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderSingle.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderSingle.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderSingle.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderSingle.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderSingle.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.NewOrderSingle.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50SP1.NewOrderList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.NewOrderList.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.NewOrderList.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.AllocationInstruction.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationInstruction.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationInstruction.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstruction.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationInstruction.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationInstruction.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstruction.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationInstruction.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationInstruction.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP1.ListCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ListCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.ListCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.ListStatus.NoOrdersGroup();
              }
          }
          if(QuickFix.FIX50SP1.AllocationInstructionAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.DontKnowTrade.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.DontKnowTrade.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.DontKnowTrade.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.DontKnowTrade.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DontKnowTrade.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.DontKnowTrade.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.DontKnowTrade.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.QuoteRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.Quote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.Quote.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.Quote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Quote.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Quote.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Quote.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Quote.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Quote.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.Quote.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.Quote.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.Quote.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Quote.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.Quote.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.Quote.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.Quote.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.Quote.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.SettlementInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.MarketDataRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP1.MarketDataRequest.NoMDEntryTypesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.MarketDataRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MarketDataRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfSecSizes: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoOfSecSizesGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfSecSizes: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoOfSecSizesGroup();
					case QuickFix.Fields.Tags.NoStatsIndicators: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoStatsIndicatorsGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.MarketDataRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoAltMDSourceGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.QuoteCancel.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteCancel.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.QuoteStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.MassQuoteAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityDefinitionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinition.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinition.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinition.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinition.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityStatus.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatus.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradingSessionStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradingSessionStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradingSessionStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradingSessionStatus.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradingSessionStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.MassQuote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MassQuote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MassQuote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.BidRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50SP1.BidRequest.NoBidDescriptorsGroup();
					case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP1.BidRequest.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX50SP1.BidResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP1.BidResponse.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ListStrikePrice.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.RegistrationInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.RegistrationInstructions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50SP1.RegistrationInstructions.NoRegistDtlsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50SP1.RegistrationInstructions.NoDistribInstsGroup();
              }
          }
          if(QuickFix.FIX50SP1.RegistrationInstructionsResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructionsResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderMassCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderMassCancelReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoNotAffectedOrdersGroup();
              }
          }
          if(QuickFix.FIX50SP1.NewOrderCross.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderCross.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderCross.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderCross.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.NewOrderCross.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.NewOrderCross.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderCross.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderCross.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderCross.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CrossOrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityTypes.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50SP1.SecurityTypes.NoSecurityTypesGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityListRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityListRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityListRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityListRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.DerivativeSecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeEventsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeInstrumentPartiesGroup.NoDerivativeInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.DerivativeSecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeEventsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrumentPartiesGroup.NoDerivativeInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrAttribGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.NewOrderMultileg.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderMultileg.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderMultileg.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderMultileg.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderMultileg.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderMultileg.NoStrategyParametersGroup();
              }
          }
          if(QuickFix.FIX50SP1.MultilegOrderCancelReplace.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoStrategyParametersGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradeCaptureReportRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoDatesGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradeCaptureReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.TradeCaptureReport.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfLegUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup.NoOfLegUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingLegSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup.NoOfLegUnderlyingsGroup.NoUnderlyingLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.TradeCaptureReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSideTrdRegTS: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoSideTrdRegTSGroup();
					case QuickFix.Fields.Tags.NoSettlDetails: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoSettlDetailsGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP1.TradeCaptureReport.NoTrdRepIndicatorsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderMassStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.QuoteRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.RFQRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RFQRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.RFQRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.QuoteStatusReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteStatusReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteStatusReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteStatusReport.NoQuoteQualifiersGroup();
              }
          }
          if(QuickFix.FIX50SP1.QuoteResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteResponse.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteResponse.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteResponse.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.QuoteResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.QuoteResponse.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.Confirmation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.Confirmation.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.Confirmation.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.Confirmation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.Confirmation.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Confirmation.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Confirmation.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Confirmation.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Confirmation.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.Confirmation.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Confirmation.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.Confirmation.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50SP1.Confirmation.NoCapacitiesGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.Confirmation.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.Confirmation.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.Confirmation.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX50SP1.PositionMaintenanceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP1.PositionMaintenanceReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP1.RequestForPositions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RequestForPositions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.RequestForPositions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositions.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RequestForPositions.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositions.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.RequestForPositions.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RequestForPositions.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositions.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.RequestForPositions.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX50SP1.RequestForPositionsAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.PositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.PositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.PositionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.PositionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingAmounts: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup.NoUnderlyingAmountsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradeCaptureReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfLegUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup.NoOfLegUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingLegSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup.NoOfLegUnderlyingsGroup.NoUnderlyingLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSideTrdRegTS: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoSideTrdRegTSGroup();
					case QuickFix.Fields.Tags.NoSettlDetails: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoSettlDetailsGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoTrdRepIndicatorsGroup();
              }
          }
          if(QuickFix.FIX50SP1.AllocationReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationReport.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AllocationReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationReport.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.AllocationReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AllocationReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP1.AllocationReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationReportAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AllocationReportAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationReportAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AllocationReportAck.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AllocationReportAck.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.SettlementInstructionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.SettlementInstructionRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.SettlementInstructionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.AssignmentReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AssignmentReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AssignmentReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AssignmentReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AssignmentReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.AssignmentReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.AssignmentReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AssignmentReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP1.CollateralRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CollateralRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralRequest.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralRequest.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CollateralRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralRequest.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralRequest.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CollateralAssignment.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralAssignment.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralAssignment.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralAssignment.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralAssignment.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralAssignment.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralAssignment.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CollateralAssignment.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralAssignment.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralAssignment.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralAssignment.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralAssignment.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CollateralResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CollateralResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralResponse.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralResponse.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralResponse.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CollateralResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralResponse.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralResponse.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralResponse.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CollateralReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CollateralReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralReport.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CollateralReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralReport.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CollateralInquiry.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP1.CollateralInquiry.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralInquiry.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralInquiry.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiry.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralInquiry.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiry.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralInquiry.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiry.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralInquiry.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralInquiry.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralInquiry.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.CollateralInquiryAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ConfirmationRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.ConfirmationRequest.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ContraryIntentionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoExpirationGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.SecurityListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.AdjustedPositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.AllocationInstructionAlert.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ExecutionAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradingSessionList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup.NoMDFeedTypesGroup();
              }
          }
          if(QuickFix.FIX50SP1.SettlementObligationReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSettlOblig: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSettlDetails: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoSettlDetailsGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeEventsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentPartiesGroup.NoDerivativeInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrAttribGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP1.TradingSessionListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoMDFeedTypesGroup();
              }
          }
          if(QuickFix.FIX50SP1.MarketDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.MarketDefinition.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.MarketDefinition.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.MarketDefinition.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.MarketDefinition.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.MarketDefinition.NoExecInstRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.MarketDefinitionUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoExecInstRulesGroup();
              }
          }
          if(QuickFix.FIX50SP1.ApplicationMessageRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageRequest.NoApplIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ApplicationMessageRequestAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageRequestAck.NoApplIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.ApplicationMessageReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageReport.NoApplIDsGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderMassActionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP1.OrderMassActionReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassActionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderMassActionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassActionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassActionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP1.OrderMassActionReport.NoNotAffectedOrdersGroup();
              }
          }
          if(QuickFix.FIX50SP1.OrderMassActionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
            return null;
        }
    }
}
    