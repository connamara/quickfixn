namespace QuickFix.FIX43
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
                case Advertisement.MsgType: return new Advertisement();
                case IndicationOfInterest.MsgType: return new IndicationOfInterest();
                case News.MsgType: return new News();
                case Email.MsgType: return new Email();
                case QuoteRequest.MsgType: return new QuoteRequest();
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
                case ListExecute.MsgType: return new ListExecute();
                case ListCancelRequest.MsgType: return new ListCancelRequest();
                case ListStatusRequest.MsgType: return new ListStatusRequest();
                case ListStatus.MsgType: return new ListStatus();
                case Allocation.MsgType: return new Allocation();
                case AllocationACK.MsgType: return new AllocationACK();
                case SettlementInstructions.MsgType: return new SettlementInstructions();
                case TradeCaptureReportRequest.MsgType: return new TradeCaptureReportRequest();
                case TradeCaptureReport.MsgType: return new TradeCaptureReport();
                case RegistrationInstructions.MsgType: return new RegistrationInstructions();
                case RegistrationInstructionsResponse.MsgType: return new RegistrationInstructionsResponse();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
          if(QuickFix.FIX43.Logon.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX43.Logon.NoMsgTypesGroup();
              }
          }
          if(QuickFix.FIX43.Advertisement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Advertisement.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.IndicationOfInterest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.IndicationOfInterest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX43.IndicationOfInterest.NoIOIQualifiersGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.IndicationOfInterest.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX43.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.News.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.News.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX43.News.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX43.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.Email.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.Email.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX43.Email.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX43.QuoteRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.QuoteRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX43.QuoteRequestReject.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX43.RFQRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.RFQRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.Quote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.Quote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Quote.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.QuoteCancel.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteCancel.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.QuoteCancel.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.QuoteStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteStatusRequest.NoPartyIDsGroup();
              }
          }
          if(QuickFix.FIX43.QuoteStatusReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteStatusReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteStatusReport.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.MassQuote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MassQuote.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.MassQuoteAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.MarketDataRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX43.MarketDataRequest.NoMDEntryTypesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.MarketDataRequest.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.MarketDataRequest.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX43.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
              }
          }
          if(QuickFix.FIX43.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX43.MarketDataIncrementalRefresh.NoMDEntriesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.SecurityDefinitionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityDefinitionRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityDefinitionRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.SecurityDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityDefinition.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityDefinition.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.SecurityTypes.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX43.SecurityTypes.NoSecurityTypesGroup();
              }
          }
          if(QuickFix.FIX43.SecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityListRequest.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.SecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.DerivativeSecurityListRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.DerivativeSecurityList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.SecurityStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityStatusRequest.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.SecurityStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityStatus.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.NewOrderSingle.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderSingle.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderSingle.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderSingle.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderSingle.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderSingle.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX43.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.ExecutionReport.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX43.ExecutionReport.NoContraBrokersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.ExecutionReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.ExecutionReport.NoStipulationsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX43.ExecutionReport.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.ExecutionReport.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup();
              }
          }
          if(QuickFix.FIX43.DontKnowTrade.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.DontKnowTrade.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.OrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.OrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderCancelRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderCancelRequest.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.OrderStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderStatusRequest.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.OrderMassCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassCancelRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.OrderMassCancelReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX43.OrderMassCancelReport.NoAffectedOrdersGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassCancelReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.OrderMassStatusRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderMassStatusRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassStatusRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.NewOrderCross.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderCross.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderCross.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderCross.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX43.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX43.CrossOrderCancelRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.NewOrderMultileg.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderMultileg.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderMultileg.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderMultileg.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderMultileg.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.NewOrderMultileg.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
              }
          }
          if(QuickFix.FIX43.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegsGroup();
					case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoNestedPartyIDsGroup();
              }
          }
          if(QuickFix.FIX43.BidRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX43.BidRequest.NoBidDescriptorsGroup();
					case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX43.BidRequest.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX43.BidResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX43.BidResponse.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX43.NewOrderList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
              }
          }
          if(QuickFix.FIX43.ListStrikePrice.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX43.ListStrikePrice.NoStrikesGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
              }
          }
          if(QuickFix.FIX43.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.ListStatus.NoOrdersGroup();
              }
          }
          if(QuickFix.FIX43.Allocation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.Allocation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX43.Allocation.NoExecsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Allocation.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.Allocation.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.Allocation.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.Allocation.NoAllocsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX43.Allocation.NoAllocsGroup.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX43.AllocationACK.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.AllocationACK.NoPartyIDsGroup();
              }
          }
          if(QuickFix.FIX43.SettlementInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.SettlementInstructions.NoPartyIDsGroup();
              }
          }
          if(QuickFix.FIX43.TradeCaptureReportRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.TradeCaptureReportRequest.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.TradeCaptureReportRequest.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX43.TradeCaptureReportRequest.NoDatesGroup();
              }
          }
          if(QuickFix.FIX43.TradeCaptureReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.TradeCaptureReport.NoSecurityAltIDGroup();
					case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup();
					case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
					case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX43.RegistrationInstructions.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.RegistrationInstructions.NoPartyIDsGroup();
					case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX43.RegistrationInstructions.NoRegistDtlsGroup();
					case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
					case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX43.RegistrationInstructions.NoDistribInstsGroup();
              }
          }
          if(QuickFix.FIX43.RegistrationInstructionsResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.RegistrationInstructionsResponse.NoPartyIDsGroup();
              }
          }
            return null;
        }
    }
}
    