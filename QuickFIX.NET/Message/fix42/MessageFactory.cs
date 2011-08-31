// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX42
    {
        public class MessageFactory : IMessageFactory
        {
            public Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX42.Heartbeat.MsgType: return new QuickFix.FIX42.Heartbeat();
                    case QuickFix.FIX42.Logon.MsgType: return new QuickFix.FIX42.Logon();
                    case QuickFix.FIX42.TestRequest.MsgType: return new QuickFix.FIX42.TestRequest();
                    case QuickFix.FIX42.ResendRequest.MsgType: return new QuickFix.FIX42.ResendRequest();
                    case QuickFix.FIX42.Reject.MsgType: return new QuickFix.FIX42.Reject();
                    case QuickFix.FIX42.SequenceReset.MsgType: return new QuickFix.FIX42.SequenceReset();
                    case QuickFix.FIX42.Logout.MsgType: return new QuickFix.FIX42.Logout();
                    case QuickFix.FIX42.Advertisement.MsgType: return new QuickFix.FIX42.Advertisement();
                    case QuickFix.FIX42.IndicationofInterest.MsgType: return new QuickFix.FIX42.IndicationofInterest();
                    case QuickFix.FIX42.News.MsgType: return new QuickFix.FIX42.News();
                    case QuickFix.FIX42.Email.MsgType: return new QuickFix.FIX42.Email();
                    case QuickFix.FIX42.QuoteRequest.MsgType: return new QuickFix.FIX42.QuoteRequest();
                    case QuickFix.FIX42.Quote.MsgType: return new QuickFix.FIX42.Quote();
                    case QuickFix.FIX42.MassQuote.MsgType: return new QuickFix.FIX42.MassQuote();
                    case QuickFix.FIX42.QuoteCancel.MsgType: return new QuickFix.FIX42.QuoteCancel();
                    case QuickFix.FIX42.QuoteStatusRequest.MsgType: return new QuickFix.FIX42.QuoteStatusRequest();
                    case QuickFix.FIX42.QuoteAcknowledgement.MsgType: return new QuickFix.FIX42.QuoteAcknowledgement();
                    case QuickFix.FIX42.MarketDataRequest.MsgType: return new QuickFix.FIX42.MarketDataRequest();
                    case QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX42.MarketDataIncrementalRefresh();
                    case QuickFix.FIX42.MarketDataRequestReject.MsgType: return new QuickFix.FIX42.MarketDataRequestReject();
                    case QuickFix.FIX42.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX42.SecurityDefinitionRequest();
                    case QuickFix.FIX42.SecurityDefinition.MsgType: return new QuickFix.FIX42.SecurityDefinition();
                    case QuickFix.FIX42.SecurityStatusRequest.MsgType: return new QuickFix.FIX42.SecurityStatusRequest();
                    case QuickFix.FIX42.SecurityStatus.MsgType: return new QuickFix.FIX42.SecurityStatus();
                    case QuickFix.FIX42.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX42.TradingSessionStatusRequest();
                    case QuickFix.FIX42.TradingSessionStatus.MsgType: return new QuickFix.FIX42.TradingSessionStatus();
                    case QuickFix.FIX42.NewOrderSingle.MsgType: return new QuickFix.FIX42.NewOrderSingle();
                    case QuickFix.FIX42.ExecutionReport.MsgType: return new QuickFix.FIX42.ExecutionReport();
                    case QuickFix.FIX42.DontKnowTrade.MsgType: return new QuickFix.FIX42.DontKnowTrade();
                    case QuickFix.FIX42.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX42.OrderCancelReplaceRequest();
                    case QuickFix.FIX42.OrderCancelRequest.MsgType: return new QuickFix.FIX42.OrderCancelRequest();
                    case QuickFix.FIX42.OrderCancelReject.MsgType: return new QuickFix.FIX42.OrderCancelReject();
                    case QuickFix.FIX42.OrderStatusRequest.MsgType: return new QuickFix.FIX42.OrderStatusRequest();
                    case QuickFix.FIX42.Allocation.MsgType: return new QuickFix.FIX42.Allocation();
                    case QuickFix.FIX42.AllocationACK.MsgType: return new QuickFix.FIX42.AllocationACK();
                    case QuickFix.FIX42.SettlementInstructions.MsgType: return new QuickFix.FIX42.SettlementInstructions();
                    case QuickFix.FIX42.BidRequest.MsgType: return new QuickFix.FIX42.BidRequest();
                    case QuickFix.FIX42.BidResponse.MsgType: return new QuickFix.FIX42.BidResponse();
                    case QuickFix.FIX42.NewOrderList.MsgType: return new QuickFix.FIX42.NewOrderList();
                    case QuickFix.FIX42.ListStrikePrice.MsgType: return new QuickFix.FIX42.ListStrikePrice();
                    case QuickFix.FIX42.ListStatus.MsgType: return new QuickFix.FIX42.ListStatus();
                    case QuickFix.FIX42.ListExecute.MsgType: return new QuickFix.FIX42.ListExecute();
                    case QuickFix.FIX42.ListCancelRequest.MsgType: return new QuickFix.FIX42.ListCancelRequest();
                    case QuickFix.FIX42.ListStatusRequest.MsgType: return new QuickFix.FIX42.ListStatusRequest();
                    case QuickFix.FIX42.BusinessMessageReject.MsgType: return new QuickFix.FIX42.BusinessMessageReject();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX42.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX42.Logon.NoMsgTypes();
                    }
                }

                if (QuickFix.FIX42.IndicationofInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX42.IndicationofInterest.NoIOIQualifiers();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.IndicationofInterest.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX42.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.News.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.News.NoRelatedSym();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.News.LinesOfText();
                    }
                }

                if (QuickFix.FIX42.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.Email.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.Email.NoRelatedSym();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.Email.LinesOfText();
                    }
                }

                if (QuickFix.FIX42.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.QuoteRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX42.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.MassQuote.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX42.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteCancel.NoQuoteEntries();
                    }
                }

                if (QuickFix.FIX42.QuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX42.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypes();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.MarketDataRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntries();
                    }
                }

                if (QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataIncrementalRefresh.NoMDEntries();
                    }
                }

                if (QuickFix.FIX42.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinitionRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX42.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinition.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX42.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderSingle.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderSingle.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX42.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX42.ExecutionReport.NoContraBrokers();
                    }
                }

                if (QuickFix.FIX42.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX42.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.Allocation.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX42.Allocation.NoExecs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.Allocation.NoAllocs();
                    }
                }

                if (QuickFix.FIX42.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX42.BidRequest.NoBidDescriptors();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidRequest.NoBidComponents();
                    }
                }

                if (QuickFix.FIX42.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidResponse.NoBidComponents();
                    }
                }

                if (QuickFix.FIX42.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.NewOrderList.NoOrders();
                    }
                }

                if (QuickFix.FIX42.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX42.ListStrikePrice.NoStrikes();
                    }
                }

                if (QuickFix.FIX42.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.ListStatus.NoOrders();
                    }
                }

                return null;
            }

        }
    }
}
