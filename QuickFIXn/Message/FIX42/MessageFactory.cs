namespace QuickFix.FIX42
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
                case Advertisement.MsgType: return new Advertisement();
                case IndicationofInterest.MsgType: return new IndicationofInterest();
                case News.MsgType: return new News();
                case Email.MsgType: return new Email();
                case QuoteRequest.MsgType: return new QuoteRequest();
                case Quote.MsgType: return new Quote();
                case MassQuote.MsgType: return new MassQuote();
                case QuoteCancel.MsgType: return new QuoteCancel();
                case QuoteStatusRequest.MsgType: return new QuoteStatusRequest();
                case QuoteAcknowledgement.MsgType: return new QuoteAcknowledgement();
                case MarketDataRequest.MsgType: return new MarketDataRequest();
                case MarketDataSnapshotFullRefresh.MsgType: return new MarketDataSnapshotFullRefresh();
                case MarketDataIncrementalRefresh.MsgType: return new MarketDataIncrementalRefresh();
                case MarketDataRequestReject.MsgType: return new MarketDataRequestReject();
                case SecurityDefinitionRequest.MsgType: return new SecurityDefinitionRequest();
                case SecurityDefinition.MsgType: return new SecurityDefinition();
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
                case Allocation.MsgType: return new Allocation();
                case AllocationACK.MsgType: return new AllocationACK();
                case SettlementInstructions.MsgType: return new SettlementInstructions();
                case BidRequest.MsgType: return new BidRequest();
                case BidResponse.MsgType: return new BidResponse();
                case NewOrderList.MsgType: return new NewOrderList();
                case ListStrikePrice.MsgType: return new ListStrikePrice();
                case ListStatus.MsgType: return new ListStatus();
                case ListExecute.MsgType: return new ListExecute();
                case ListCancelRequest.MsgType: return new ListCancelRequest();
                case ListStatusRequest.MsgType: return new ListStatusRequest();
                case BusinessMessageReject.MsgType: return new BusinessMessageReject();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
          if(QuickFix.FIX42.Logon.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX42.Logon.NoMsgTypesGroup();
              }
          }
          if(QuickFix.FIX42.IndicationofInterest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX42.IndicationofInterest.NoIOIQualifiersGroup();
					case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.IndicationofInterest.NoRoutingIDsGroup();
              }
          }
          if(QuickFix.FIX42.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.News.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.News.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.News.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX42.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.Email.NoRoutingIDsGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.Email.NoRelatedSymGroup();
					case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.Email.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX42.QuoteRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.QuoteRequest.NoRelatedSymGroup();
              }
          }
          if(QuickFix.FIX42.MassQuote.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.MassQuote.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
              }
          }
          if(QuickFix.FIX42.QuoteCancel.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteCancel.NoQuoteEntriesGroup();
              }
          }
          if(QuickFix.FIX42.QuoteAcknowledgement.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSetsGroup();
					case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
              }
          }
          if(QuickFix.FIX42.MarketDataRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup();
					case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
              }
          }
          if(QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
              }
          }
          if(QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataIncrementalRefresh.NoMDEntriesGroup();
              }
          }
          if(QuickFix.FIX42.SecurityDefinitionRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinitionRequest.NoRelatedSymGroup();
              }
          }
          if(QuickFix.FIX42.SecurityDefinition.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinition.NoRelatedSymGroup();
              }
          }
          if(QuickFix.FIX42.NewOrderSingle.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderSingle.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX42.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX42.ExecutionReport.NoContraBrokersGroup();
              }
          }
          if(QuickFix.FIX42.OrderCancelReplaceRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX42.Allocation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.Allocation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX42.Allocation.NoExecsGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.Allocation.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42.Allocation.NoAllocsGroup.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX42.BidRequest.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX42.BidRequest.NoBidDescriptorsGroup();
					case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidRequest.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX42.BidResponse.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidResponse.NoBidComponentsGroup();
              }
          }
          if(QuickFix.FIX42.NewOrderList.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
              }
          }
          if(QuickFix.FIX42.ListStrikePrice.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX42.ListStrikePrice.NoStrikesGroup();
              }
          }
          if(QuickFix.FIX42.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.ListStatus.NoOrdersGroup();
              }
          }
            return null;
        }
    }
}
    