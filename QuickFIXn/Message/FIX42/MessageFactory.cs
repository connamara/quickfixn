// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX42
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
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
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX42.Logon.NoMsgTypesGroup();
                    }
                }

                if (QuickFix.FIX42.IndicationofInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX42.IndicationofInterest.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.IndicationofInterest.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX42.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX42.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX42.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.MassQuote.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.QuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSetsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX42.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinitionRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinition.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX42.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX42.ExecutionReport.NoContraBrokersGroup();
                    }
                }

                if (QuickFix.FIX42.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.Allocation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX42.Allocation.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.Allocation.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42.Allocation.NoAllocsGroup.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX42.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX42.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX42.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX42.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX42.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX42.ListStrikePrice.NoStrikesGroup();
                    }
                }

                if (QuickFix.FIX42.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.ListStatus.NoOrdersGroup();
                    }
                }

                return null;
            }

        }
    }
}
