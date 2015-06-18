namespace QuickFix.FIX50SP2
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
                case StreamAssignmentRequest.MsgType: return new StreamAssignmentRequest();
                case StreamAssignmentReport.MsgType: return new StreamAssignmentReport();
                case StreamAssignmentReportACK.MsgType: return new StreamAssignmentReportACK();
                case PartyDetailsListRequest.MsgType: return new PartyDetailsListRequest();
                case PartyDetailsListReport.MsgType: return new PartyDetailsListReport();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
          if(QuickFix.FIX50SP2.IOI.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.IOI.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.IOI.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.IOI.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.IOI.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.IOI.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.IOI.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.IOI.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.IOI.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.IOI.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.IOI.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.IOI.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.IOI.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.IOI.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.IOI.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.IOI.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.IOI.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50SP2.IOI.NoIOIQualifiersGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.IOI.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.IOI.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.IOI.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.Advertisement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Advertisement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Advertisement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Advertisement.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Advertisement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Advertisement.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.Advertisement.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.Advertisement.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Advertisement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.Advertisement.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Advertisement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50SP2.ExecutionReport.NoContraBrokersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ExecutionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ExecutionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ExecutionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ExecutionReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.ExecutionReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.ExecutionReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.ExecutionReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP2.ExecutionReport.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.ExecutionReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.ExecutionReport.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.ExecutionReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.ExecutionReport.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoFills: return new QuickFix.FIX50SP2.ExecutionReport.NoFillsGroup();
					case QuickFix.Fields.Tags.NoNested4PartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoFillsGroup.NoNested4PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested4PartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoFillsGroup.NoNested4PartyIDsGroup.NoNested4PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.ExecutionReport.NoRateSourcesGroup();
              }
          }
          if(QuickFix.FIX50SP2.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.News.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.News.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.News.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.News.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.News.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.News.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.News.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.News.NoLinesOfTextGroup();
					case QuickFix.Fields.Tags.NoNewsRefIDs: return new QuickFix.FIX50SP2.News.NoNewsRefIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.Email.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.Email.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Email.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.Email.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.Email.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Email.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Email.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.Email.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.Email.NoLinesOfTextGroup();
              }
          }
          if(QuickFix.FIX50SP2.NewOrderSingle.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderSingle.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderSingle.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderSingle.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderSingle.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderSingle.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderSingle.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.NewOrderSingle.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.NewOrderSingle.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderSingle.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderSingle.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.NewOrderSingle.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50SP2.NewOrderList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderList.NoOrdersGroup.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.NewOrderList.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.NewOrderList.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderCancelRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoTrdRegTimestampsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderStatusRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.AllocationInstruction.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationInstruction.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationInstruction.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstruction.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationInstruction.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationInstruction.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.AllocationInstruction.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.AllocationInstruction.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationInstruction.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationInstruction.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstruction.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationInstruction.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationInstruction.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.AllocationInstruction.NoRateSourcesGroup();
              }
          }
          if(QuickFix.FIX50SP2.ListCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ListCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ListCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.ListStatus.NoOrdersGroup();
              }
          }
          if(QuickFix.FIX50SP2.AllocationInstructionAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAck.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.DontKnowTrade.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.DontKnowTrade.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.DontKnowTrade.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.DontKnowTrade.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DontKnowTrade.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.DontKnowTrade.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.DontKnowTrade.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.DontKnowTrade.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DontKnowTrade.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.DontKnowTrade.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.DontKnowTrade.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.QuoteRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.QuoteRequest.NoRelatedSymGroup.NoRateSourcesGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.Quote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.Quote.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Quote.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Quote.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Quote.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Quote.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Quote.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.Quote.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.Quote.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Quote.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.Quote.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.Quote.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Quote.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.Quote.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Quote.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.Quote.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.Quote.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.Quote.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.Quote.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.Quote.NoRateSourcesGroup();
              }
          }
          if(QuickFix.FIX50SP2.SettlementInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.MarketDataRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP2.MarketDataRequest.NoMDEntryTypesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.MarketDataRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfSecSizes: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoOfSecSizesGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup.NoRateSourcesGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfSecSizes: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoOfSecSizesGroup();
					case QuickFix.Fields.Tags.NoStatsIndicators: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoStatsIndicatorsGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoRateSourcesGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.MarketDataRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoAltMDSourceGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.QuoteCancel.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.QuoteStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.MassQuoteAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.MassQuoteAcknowledgement.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityDefinitionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinitionRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinition.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinition.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinition.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityDefinition.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityDefinition.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinition.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityDefinition.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinition.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinition.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP2.SecurityDefinition.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityStatus.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityStatus.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityStatus.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityStatus.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityStatus.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityStatus.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityStatus.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradingSessionStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradingSessionStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradingSessionStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradingSessionStatus.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradingSessionStatus.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradingSessionStatus.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.TradingSessionStatus.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.TradingSessionStatus.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
              }
          }
          if(QuickFix.FIX50SP2.MassQuote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MassQuote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MassQuote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.BidRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50SP2.BidRequest.NoBidDescriptorsGroup();
					case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP2.BidRequest.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX50SP2.BidResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP2.BidResponse.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ListStrikePrice.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ListStrikePrice.NoStrikesGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.RegistrationInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.RegistrationInstructions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50SP2.RegistrationInstructions.NoRegistDtlsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50SP2.RegistrationInstructions.NoDistribInstsGroup();
              }
          }
          if(QuickFix.FIX50SP2.RegistrationInstructionsResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RegistrationInstructionsResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderMassCancelReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoNotAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.NewOrderCross.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderCross.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderCross.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderCross.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderCross.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.NewOrderCross.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.NewOrderCross.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.NewOrderCross.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.NewOrderCross.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderCross.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.NewOrderCross.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderCross.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.NewOrderCross.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoStrategyParametersGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CrossOrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.CrossOrderCancelRequest.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityTypes.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50SP2.SecurityTypes.NoSecurityTypesGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityListRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityListRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityListRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityListRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityListRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityListRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityListRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityListRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityListRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.DerivativeSecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeEventsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityListRequest.NoDerivativeInstrumentPartiesGroup.NoDerivativeInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.DerivativeSecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeEventsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrumentPartiesGroup.NoDerivativeInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoDerivativeInstrAttribGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP2.DerivativeSecurityList.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.NewOrderMultileg.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.NewOrderMultileg.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.NewOrderMultileg.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.NewOrderMultileg.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.NewOrderMultileg.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.NewOrderMultileg.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.NewOrderMultileg.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.NewOrderMultileg.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.NewOrderMultileg.NoStrategyParametersGroup();
              }
          }
          if(QuickFix.FIX50SP2.MultilegOrderCancelReplace.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP2.MultilegOrderCancelReplace.NoStrategyParametersGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradeCaptureReportRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50SP2.TradeCaptureReportRequest.NoDatesGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradeCaptureReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.TradeCaptureReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.TradeCaptureReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.TradeCaptureReport.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfLegUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup.NoOfLegUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingLegSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReport.NoLegsGroup.NoOfLegUnderlyingsGroup.NoUnderlyingLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.TradeCaptureReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSideTrdRegTS: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoSideTrdRegTSGroup();
					case QuickFix.Fields.Tags.NoSettlDetails: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoSettlDetailsGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReport.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP2.TradeCaptureReport.NoTrdRepIndicatorsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.QuoteRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.QuoteRequestReject.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.RFQRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RFQRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.RFQRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.QuoteStatusReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteStatusReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteStatusReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.QuoteStatusReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.QuoteStatusReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteStatusReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteStatusReport.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.QuoteResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP2.QuoteResponse.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.QuoteResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.QuoteResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.QuoteResponse.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.QuoteResponse.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.QuoteResponse.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.QuoteResponse.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.QuoteResponse.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.QuoteResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.QuoteResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.QuoteResponse.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.Confirmation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Confirmation.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.Confirmation.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.Confirmation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.Confirmation.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.Confirmation.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.Confirmation.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.Confirmation.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Confirmation.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.Confirmation.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.Confirmation.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.Confirmation.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.Confirmation.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.Confirmation.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.Confirmation.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.Confirmation.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50SP2.Confirmation.NoCapacitiesGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.Confirmation.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.Confirmation.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.Confirmation.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX50SP2.PositionMaintenanceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionMaintenanceRequest.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP2.PositionMaintenanceReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionMaintenanceReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP2.RequestForPositions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RequestForPositions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.RequestForPositions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositions.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RequestForPositions.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositions.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.RequestForPositions.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RequestForPositions.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.RequestForPositions.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.RequestForPositions.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RequestForPositions.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositions.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.RequestForPositions.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.RequestForPositions.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX50SP2.RequestForPositionsAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.RequestForPositionsAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.PositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.PositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.PositionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.PositionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.PositionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.PositionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.PositionReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.PositionReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.PositionReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.PositionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.PositionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingAmounts: return new QuickFix.FIX50SP2.PositionReport.NoUnderlyingsGroup.NoUnderlyingAmountsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.PositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.PositionReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportRequestAck.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradeCaptureReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOfLegUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup.NoOfLegUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingLegSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoLegsGroup.NoOfLegUnderlyingsGroup.NoUnderlyingLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSideTrdRegTS: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoSideTrdRegTSGroup();
					case QuickFix.Fields.Tags.NoSettlDetails: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoSettlDetailsGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoSidesGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoRootPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRootPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoRootPartyIDsGroup.NoRootPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP2.TradeCaptureReportAck.NoTrdRepIndicatorsGroup();
              }
          }
          if(QuickFix.FIX50SP2.AllocationReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationReport.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AllocationReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.AllocationReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.AllocationReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationReport.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AllocationReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.AllocationReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AllocationReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationReport.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoRateSources: return new QuickFix.FIX50SP2.AllocationReport.NoRateSourcesGroup();
              }
          }
          if(QuickFix.FIX50SP2.AllocationReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationReportAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AllocationReportAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationReportAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AllocationReportAck.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AllocationReportAck.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.SettlementInstructionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.SettlementInstructionRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.SettlementInstructionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.AssignmentReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AssignmentReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AssignmentReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AssignmentReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AssignmentReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.AssignmentReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.AssignmentReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AssignmentReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.AssignmentReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.AssignmentReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AssignmentReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX50SP2.CollateralRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CollateralRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralRequest.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralRequest.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CollateralRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CollateralRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CollateralRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralRequest.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralRequest.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralRequest.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CollateralAssignment.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralAssignment.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralAssignment.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralAssignment.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralAssignment.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralAssignment.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralAssignment.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CollateralAssignment.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CollateralAssignment.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralAssignment.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CollateralAssignment.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralAssignment.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralAssignment.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralAssignment.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralAssignment.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CollateralResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CollateralResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralResponse.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralResponse.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralResponse.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralResponse.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralResponse.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CollateralResponse.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CollateralResponse.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CollateralResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralResponse.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralResponse.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralResponse.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralResponse.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CollateralReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CollateralReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralReport.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CollateralReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CollateralReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CollateralReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.CollateralReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralReport.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CollateralInquiry.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP2.CollateralInquiry.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralInquiry.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralInquiry.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiry.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralInquiry.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiry.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralInquiry.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CollateralInquiry.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CollateralInquiry.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralInquiry.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiry.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP2.CollateralInquiry.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.CollateralInquiry.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.CollateralInquiry.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusRequest.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP2.NetworkCounterpartySystemStatusResponse.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.CollateralInquiryAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.CollateralInquiryAck.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ConfirmationRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.ConfirmationRequest.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ContraryIntentionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoExpirationGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ContraryIntentionReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP2.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.SecurityListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP2.SecurityListUpdateReport.NoRelatedSymGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.AdjustedPositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.AdjustedPositionReport.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
              }
          }
          if(QuickFix.FIX50SP2.AllocationInstructionAlert.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.AllocationInstructionAlert.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ExecutionAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoUnderlyingsGroup.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.ExecutionAcknowledgement.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradingSessionList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.TradingSessionList.NoTradingSessionsGroup.NoMDFeedTypesGroup();
              }
          }
          if(QuickFix.FIX50SP2.SettlementObligationReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSettlOblig: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSettlDetails: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoSettlDetailsGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX50SP2.SettlementObligationReport.NoSettlObligGroup.NoSettlDetailsGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeEventsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentPartiesGroup.NoDerivativeInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoDerivativeInstrAttribGroup();
					case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup();
					case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTradingSessionRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoTradingSessionRulesGroup.NoMDFeedTypesGroup();
					case QuickFix.Fields.Tags.NoNestedInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoNestedInstrAttribGroup();
					case QuickFix.Fields.Tags.NoStrikeRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup();
					case QuickFix.Fields.Tags.NoMaturityRules: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup.NoStrikeRulesGroup.NoMaturityRulesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX50SP2.DerivativeSecurityListUpdateReport.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX50SP2.TradingSessionListUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoExecInstRulesGroup();
					case QuickFix.Fields.Tags.NoMatchRules: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoMatchRulesGroup();
					case QuickFix.Fields.Tags.NoMDFeedTypes: return new QuickFix.FIX50SP2.TradingSessionListUpdateReport.NoTradingSessionsGroup.NoMDFeedTypesGroup();
              }
          }
          if(QuickFix.FIX50SP2.MarketDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.MarketDefinition.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.MarketDefinition.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.MarketDefinition.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.MarketDefinition.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.MarketDefinition.NoExecInstRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.MarketDefinitionUpdateReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoTickRulesGroup();
					case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoLotTypeRulesGroup();
					case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoOrdTypeRulesGroup();
					case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoTimeInForceRulesGroup();
					case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP2.MarketDefinitionUpdateReport.NoExecInstRulesGroup();
              }
          }
          if(QuickFix.FIX50SP2.ApplicationMessageRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoApplIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoApplIDsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoApplIDsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ApplicationMessageRequestAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoApplIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoApplIDsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoApplIDsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ApplicationMessageRequestAck.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.ApplicationMessageReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP2.ApplicationMessageReport.NoApplIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderMassActionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP2.OrderMassActionReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassActionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionReport.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassActionReport.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderMassActionReport.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderMassActionReport.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP2.OrderMassActionReport.NoNotAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionReport.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.OrderMassActionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUndlyInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoUndlyInstrumentPartySubIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoUndlyInstrumentPartiesGroup.NoUndlyInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTargetPartyIDs: return new QuickFix.FIX50SP2.OrderMassActionRequest.NoTargetPartyIDsGroup();
              }
          }
          if(QuickFix.FIX50SP2.StreamAssignmentRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAsgnReqs: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.StreamAssignmentRequest.NoAsgnReqsGroup.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
              }
          }
          if(QuickFix.FIX50SP2.StreamAssignmentReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAsgnReqs: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoInstrumentPartiesGroup();
					case QuickFix.Fields.Tags.NoInstrumentPartySubIDs: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoInstrumentPartiesGroup.NoInstrumentPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoComplexEvents: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoComplexEventsGroup();
					case QuickFix.Fields.Tags.NoComplexEventDates: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup();
					case QuickFix.Fields.Tags.NoComplexEventTimes: return new QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup.NoRelatedSymGroup.NoComplexEventsGroup.NoComplexEventDatesGroup.NoComplexEventTimesGroup();
              }
          }
          if(QuickFix.FIX50SP2.PartyDetailsListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyListResponseTypes: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyListResponseTypesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRequestedPartyRoles: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoRequestedPartyRolesGroup();
					case QuickFix.Fields.Tags.NoPartyRelationships: return new QuickFix.FIX50SP2.PartyDetailsListRequest.NoPartyRelationshipsGroup();
              }
          }
          if(QuickFix.FIX50SP2.PartyDetailsListReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyList: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPartyAltIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoPartyAltIDsGroup();
					case QuickFix.Fields.Tags.NoPartyAltSubIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoPartyAltIDsGroup.NoPartyAltSubIDsGroup();
					case QuickFix.Fields.Tags.NoContextPartyIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoContextPartyIDsGroup();
					case QuickFix.Fields.Tags.NoContextPartySubIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoContextPartyIDsGroup.NoContextPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRiskLimits: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRiskLimitsGroup();
					case QuickFix.Fields.Tags.NoRiskInstruments: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRiskLimitsGroup.NoRiskInstrumentsGroup();
					case QuickFix.Fields.Tags.NoRiskSecurityAltID: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRiskLimitsGroup.NoRiskInstrumentsGroup.NoRiskSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoRiskWarningLevels: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRiskLimitsGroup.NoRiskWarningLevelsGroup();
					case QuickFix.Fields.Tags.NoRelatedPartyIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedPartySubIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelatedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedPartyAltIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelatedPartyAltIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedPartyAltSubIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelatedPartyAltIDsGroup.NoRelatedPartyAltSubIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedContextPartyIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelatedContextPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedContextPartySubIDs: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelatedContextPartyIDsGroup.NoRelatedContextPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRelationshipRiskLimits: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelationshipRiskLimitsGroup();
					case QuickFix.Fields.Tags.NoRelationshipRiskInstruments: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelationshipRiskLimitsGroup.NoRelationshipRiskInstrumentsGroup();
					case QuickFix.Fields.Tags.NoRelationshipRiskSecurityAltID: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelationshipRiskLimitsGroup.NoRelationshipRiskInstrumentsGroup.NoRelationshipRiskSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoRelationshipRiskWarningLevels: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoRelationshipRiskLimitsGroup.NoRelationshipRiskWarningLevelsGroup();
					case QuickFix.Fields.Tags.NoPartyRelationships: return new QuickFix.FIX50SP2.PartyDetailsListReport.NoPartyListGroup.NoRelatedPartyIDsGroup.NoPartyRelationshipsGroup();
              }
          }
            return null;
        }
    }
}
    