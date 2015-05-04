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
          if(QuickFix.FIX44.Logon.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX44.Logon.NoMsgTypesGroup();
              }
          }
          if(QuickFix.FIX44.Advertisement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Advertisement.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Advertisement.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Advertisement.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Advertisement.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Advertisement.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.IndicationOfInterest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.IndicationOfInterest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.IndicationOfInterest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.IndicationOfInterest.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.IndicationOfInterest.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX44.IndicationOfInterest.NoIOIQualifiersGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.IndicationOfInterest.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX44.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.News.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.News.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.News.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.News.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.News.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.News.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.News.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.News.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX44.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX44.Email.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.Email.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Email.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Email.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Email.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Email.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Email.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX44.Email.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX44.QuoteRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteRequest.NoRelatedSymGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.QuoteResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteResponse.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteResponse.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteResponse.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.QuoteRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteRequestReject.NoRelatedSymGroup.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteRequestReject.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.RFQRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.RFQRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.Quote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.Quote.NoQuoteQualifiersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Quote.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Quote.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Quote.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Quote.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Quote.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.Quote.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.Quote.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.Quote.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.QuoteCancel.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteCancel.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.QuoteStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.QuoteStatusReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.QuoteStatusReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.QuoteStatusReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.QuoteStatusReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.QuoteStatusReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX44.QuoteStatusReport.NoQuoteQualifiersGroup();
              }
          }
          if(QuickFix.FIX44.MassQuote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.MassQuote.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.MassQuoteAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.MarketDataRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MarketDataRequest.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX44.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
              }
          }
          if(QuickFix.FIX44.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.MarketDataRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX44.MarketDataRequestReject.NoAltMDSourceGroup();
              }
          }
          if(QuickFix.FIX44.SecurityDefinitionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinitionRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinitionRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityDefinitionRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.SecurityDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityDefinition.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityDefinition.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityDefinition.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.SecurityTypes.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX44.SecurityTypes.NoSecurityTypesGroup();
              }
          }
          if(QuickFix.FIX44.SecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityListRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityListRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityListRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityListRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.SecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.DerivativeSecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.DerivativeSecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DerivativeSecurityList.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.SecurityStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatusRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityStatusRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.SecurityStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.SecurityStatus.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.SecurityStatus.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.SecurityStatus.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.SecurityStatus.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.NewOrderSingle.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderSingle.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderSingle.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderSingle.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderSingle.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderSingle.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX44.ExecutionReport.NoContraBrokersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.ExecutionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.ExecutionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.ExecutionReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX44.ExecutionReport.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.ExecutionReport.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX44.DontKnowTrade.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.DontKnowTrade.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.DontKnowTrade.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.DontKnowTrade.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.OrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.OrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.OrderStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderStatusRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.OrderMassCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelRequest.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.OrderMassCancelReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX44.OrderMassCancelReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassCancelReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassCancelReport.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.OrderMassStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.OrderMassStatusRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.OrderMassStatusRequest.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.NewOrderCross.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderCross.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderCross.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.NewOrderCross.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderCross.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderCross.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.CrossOrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CrossOrderCancelRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CrossOrderCancelRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CrossOrderCancelRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.NewOrderMultileg.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderMultileg.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderMultileg.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderMultileg.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderMultileg.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderMultileg.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested3PartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoAllocsGroup.NoNested3PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested3PartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoAllocsGroup.NoNested3PartyIDsGroup.NoNested3PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoLegAllocs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.BidRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX44.BidRequest.NoBidDescriptorsGroup();
					case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidRequest.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX44.BidResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX44.BidResponse.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX44.NewOrderList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.ListStrikePrice.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.ListStrikePrice.NoStrikesGroup.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.ListStrikePrice.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ListStatus.NoOrdersGroup();
              }
          }
          if(QuickFix.FIX44.AllocationInstruction.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationInstruction.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationInstruction.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationInstruction.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.AllocationInstruction.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AllocationInstruction.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationInstruction.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.AllocationInstruction.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.AllocationInstructionAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationInstructionAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AllocationInstructionAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationInstructionAck.NoAllocsGroup();
              }
          }
          if(QuickFix.FIX44.AllocationReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.AllocationReport.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.AllocationReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AllocationReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.AllocationReport.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.AllocationReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.AllocationReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AllocationReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.AllocationReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.AllocationReport.NoAllocsGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.AllocationReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AllocationReportAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AllocationReportAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.AllocationReportAck.NoAllocsGroup();
              }
          }
          if(QuickFix.FIX44.Confirmation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.Confirmation.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.Confirmation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.Confirmation.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.Confirmation.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.Confirmation.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.Confirmation.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.Confirmation.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.Confirmation.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.Confirmation.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.Confirmation.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX44.Confirmation.NoCapacitiesGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.Confirmation.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.Confirmation.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.Confirmation.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.Confirmation.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX44.ConfirmationRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.ConfirmationRequest.NoOrdersGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.SettlementInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.SettlementInstructions.NoSettlInstGroup.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.SettlementInstructionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.SettlementInstructionRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.TradeCaptureReportRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX44.TradeCaptureReportRequest.NoInstrAttribGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.TradeCaptureReportRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX44.TradeCaptureReportRequest.NoDatesGroup();
              }
          }
          if(QuickFix.FIX44.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportRequestAck.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX44.TradeCaptureReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.TradeCaptureReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.TradeCaptureReport.NoPosAmtGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.TradeCaptureReportAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.TradeCaptureReportAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegStipulations: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegsGroup.NoLegStipulationsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.TradeCaptureReportAck.NoLegsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX44.TradeCaptureReportAck.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNested2PartyIDs: return new QuickFix.FIX44.TradeCaptureReportAck.NoAllocsGroup.NoNested2PartyIDsGroup();
					case QuickFix.Fields.Tags.NoNested2PartySubIDs: return new QuickFix.FIX44.TradeCaptureReportAck.NoAllocsGroup.NoNested2PartyIDsGroup.NoNested2PartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.RegistrationInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RegistrationInstructions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX44.RegistrationInstructions.NoDistribInstsGroup();
              }
          }
          if(QuickFix.FIX44.RegistrationInstructionsResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RegistrationInstructionsResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.PositionMaintenanceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.PositionMaintenanceRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceRequest.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.PositionMaintenanceReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionMaintenanceReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.PositionMaintenanceReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.PositionMaintenanceReport.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.PositionMaintenanceReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionMaintenanceReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX44.RequestForPositions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RequestForPositions.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositions.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.RequestForPositions.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX44.RequestForPositions.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX44.RequestForPositionsAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.RequestForPositionsAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.RequestForPositionsAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.RequestForPositionsAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
          if(QuickFix.FIX44.PositionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.PositionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.PositionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.PositionReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX44.PositionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.PositionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.PositionReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.PositionReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.PositionReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.PositionReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX44.AssignmentReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.AssignmentReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.AssignmentReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.AssignmentReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoNestedPartySubIDs: return new QuickFix.FIX44.AssignmentReport.NoPositionsGroup.NoNestedPartyIDsGroup.NoNestedPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX44.AssignmentReport.NoPosAmtGroup();
              }
          }
          if(QuickFix.FIX44.CollateralRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralRequest.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralRequest.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralRequest.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralRequest.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralRequest.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralRequest.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.CollateralAssignment.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralAssignment.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralAssignment.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralAssignment.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralAssignment.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralAssignment.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralAssignment.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralAssignment.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralAssignment.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.CollateralAssignment.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.CollateralResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralResponse.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralResponse.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralResponse.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralResponse.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralResponse.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralResponse.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralResponse.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralResponse.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX44.CollateralReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralReport.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralReport.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralReport.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralReport.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralReport.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralReport.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX44.CollateralReport.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.CollateralReport.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.CollateralInquiry.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiry.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiry.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiry.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiry.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralInquiry.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
					case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX44.CollateralInquiry.NoTrdRegTimestampsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX44.CollateralInquiry.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup();
					case QuickFix.Fields.Tags.NoSettlPartyIDs: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSettlPartySubIDs: return new QuickFix.FIX44.CollateralInquiry.NoDlvyInstGroup.NoSettlPartyIDsGroup.NoSettlPartySubIDsGroup();
              }
          }
          if(QuickFix.FIX44.NetworkStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusRequest.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX44.NetworkStatusResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX44.NetworkStatusResponse.NoCompIDsGroup();
              }
          }
          if(QuickFix.FIX44.CollateralInquiryAck.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX44.CollateralInquiryAck.NoCollInquiryQualifierGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX44.CollateralInquiryAck.NoPartyIDsGroup.NoPartySubIDsGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX44.CollateralInquiryAck.NoExecsGroup();
					case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX44.CollateralInquiryAck.NoTradesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX44.CollateralInquiryAck.NoEventsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX44.CollateralInquiryAck.NoUnderlyingsGroup.NoUnderlyingStipsGroup();
              }
          }
            return null;
        }
    }
}
    