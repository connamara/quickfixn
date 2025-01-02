// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIX42;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIX42 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIX42.Heartbeat.MsgType => new QuickFix.FIX42.Heartbeat(),
            QuickFix.FIX42.Logon.MsgType => new QuickFix.FIX42.Logon(),
            QuickFix.FIX42.TestRequest.MsgType => new QuickFix.FIX42.TestRequest(),
            QuickFix.FIX42.ResendRequest.MsgType => new QuickFix.FIX42.ResendRequest(),
            QuickFix.FIX42.Reject.MsgType => new QuickFix.FIX42.Reject(),
            QuickFix.FIX42.SequenceReset.MsgType => new QuickFix.FIX42.SequenceReset(),
            QuickFix.FIX42.Logout.MsgType => new QuickFix.FIX42.Logout(),
            QuickFix.FIX42.Advertisement.MsgType => new QuickFix.FIX42.Advertisement(),
            QuickFix.FIX42.IndicationofInterest.MsgType => new QuickFix.FIX42.IndicationofInterest(),
            QuickFix.FIX42.News.MsgType => new QuickFix.FIX42.News(),
            QuickFix.FIX42.Email.MsgType => new QuickFix.FIX42.Email(),
            QuickFix.FIX42.QuoteRequest.MsgType => new QuickFix.FIX42.QuoteRequest(),
            QuickFix.FIX42.Quote.MsgType => new QuickFix.FIX42.Quote(),
            QuickFix.FIX42.MassQuote.MsgType => new QuickFix.FIX42.MassQuote(),
            QuickFix.FIX42.QuoteCancel.MsgType => new QuickFix.FIX42.QuoteCancel(),
            QuickFix.FIX42.QuoteStatusRequest.MsgType => new QuickFix.FIX42.QuoteStatusRequest(),
            QuickFix.FIX42.QuoteAcknowledgement.MsgType => new QuickFix.FIX42.QuoteAcknowledgement(),
            QuickFix.FIX42.MarketDataRequest.MsgType => new QuickFix.FIX42.MarketDataRequest(),
            QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType => new QuickFix.FIX42.MarketDataSnapshotFullRefresh(),
            QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType => new QuickFix.FIX42.MarketDataIncrementalRefresh(),
            QuickFix.FIX42.MarketDataRequestReject.MsgType => new QuickFix.FIX42.MarketDataRequestReject(),
            QuickFix.FIX42.SecurityDefinitionRequest.MsgType => new QuickFix.FIX42.SecurityDefinitionRequest(),
            QuickFix.FIX42.SecurityDefinition.MsgType => new QuickFix.FIX42.SecurityDefinition(),
            QuickFix.FIX42.SecurityStatusRequest.MsgType => new QuickFix.FIX42.SecurityStatusRequest(),
            QuickFix.FIX42.SecurityStatus.MsgType => new QuickFix.FIX42.SecurityStatus(),
            QuickFix.FIX42.TradingSessionStatusRequest.MsgType => new QuickFix.FIX42.TradingSessionStatusRequest(),
            QuickFix.FIX42.TradingSessionStatus.MsgType => new QuickFix.FIX42.TradingSessionStatus(),
            QuickFix.FIX42.NewOrderSingle.MsgType => new QuickFix.FIX42.NewOrderSingle(),
            QuickFix.FIX42.ExecutionReport.MsgType => new QuickFix.FIX42.ExecutionReport(),
            QuickFix.FIX42.DontKnowTrade.MsgType => new QuickFix.FIX42.DontKnowTrade(),
            QuickFix.FIX42.OrderCancelReplaceRequest.MsgType => new QuickFix.FIX42.OrderCancelReplaceRequest(),
            QuickFix.FIX42.OrderCancelRequest.MsgType => new QuickFix.FIX42.OrderCancelRequest(),
            QuickFix.FIX42.OrderCancelReject.MsgType => new QuickFix.FIX42.OrderCancelReject(),
            QuickFix.FIX42.OrderStatusRequest.MsgType => new QuickFix.FIX42.OrderStatusRequest(),
            QuickFix.FIX42.Allocation.MsgType => new QuickFix.FIX42.Allocation(),
            QuickFix.FIX42.AllocationACK.MsgType => new QuickFix.FIX42.AllocationACK(),
            QuickFix.FIX42.SettlementInstructions.MsgType => new QuickFix.FIX42.SettlementInstructions(),
            QuickFix.FIX42.BidRequest.MsgType => new QuickFix.FIX42.BidRequest(),
            QuickFix.FIX42.BidResponse.MsgType => new QuickFix.FIX42.BidResponse(),
            QuickFix.FIX42.NewOrderList.MsgType => new QuickFix.FIX42.NewOrderList(),
            QuickFix.FIX42.ListStrikePrice.MsgType => new QuickFix.FIX42.ListStrikePrice(),
            QuickFix.FIX42.ListStatus.MsgType => new QuickFix.FIX42.ListStatus(),
            QuickFix.FIX42.ListExecute.MsgType => new QuickFix.FIX42.ListExecute(),
            QuickFix.FIX42.ListCancelRequest.MsgType => new QuickFix.FIX42.ListCancelRequest(),
            QuickFix.FIX42.ListStatusRequest.MsgType => new QuickFix.FIX42.ListStatusRequest(),
            QuickFix.FIX42.BusinessMessageReject.MsgType => new QuickFix.FIX42.BusinessMessageReject(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIX42.Logon.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX42.Logon.NoMsgTypesGroup();
            }
        }

        if (QuickFix.FIX42.IndicationofInterest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX42.IndicationofInterest.NoIOIQualifiersGroup();
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.IndicationofInterest.NoRoutingIDsGroup();
            }
        }

        if (QuickFix.FIX42.News.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.News.NoRoutingIDsGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.News.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.News.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX42.Email.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX42.Email.NoRoutingIDsGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.Email.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX42.Email.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX42.QuoteRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.QuoteRequest.NoRelatedSymGroup();
            }
        }

        if (QuickFix.FIX42.MassQuote.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.MassQuote.NoQuoteSetsGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
            }
        }

        if (QuickFix.FIX42.QuoteCancel.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteCancel.NoQuoteEntriesGroup();
            }
        }

        if (QuickFix.FIX42.QuoteAcknowledgement.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSetsGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX42.QuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
            }
        }

        if (QuickFix.FIX42.MarketDataRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
            }
        }

        if (QuickFix.FIX42.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
            }
        }

        if (QuickFix.FIX42.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX42.MarketDataIncrementalRefresh.NoMDEntriesGroup();
            }
        }

        if (QuickFix.FIX42.SecurityDefinitionRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinitionRequest.NoRelatedSymGroup();
            }
        }

        if (QuickFix.FIX42.SecurityDefinition.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX42.SecurityDefinition.NoRelatedSymGroup();
            }
        }

        if (QuickFix.FIX42.NewOrderSingle.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderSingle.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup();
            }
        }

        if (QuickFix.FIX42.ExecutionReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX42.ExecutionReport.NoContraBrokersGroup();
            }
        }

        if (QuickFix.FIX42.OrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.OrderCancelReplaceRequest.NoTradingSessionsGroup();
            }
        }

        if (QuickFix.FIX42.Allocation.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.Allocation.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX42.Allocation.NoExecsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.Allocation.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX42.Allocation.NoAllocsGroup.NoMiscFeesGroup();
            }
        }

        if (QuickFix.FIX42.BidRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX42.BidRequest.NoBidDescriptorsGroup();
                case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidRequest.NoBidComponentsGroup();
            }
        }

        if (QuickFix.FIX42.BidResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX42.BidResponse.NoBidComponentsGroup();
            }
        }

        if (QuickFix.FIX42.NewOrderList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX42.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
            }
        }

        if (QuickFix.FIX42.ListStrikePrice.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX42.ListStrikePrice.NoStrikesGroup();
            }
        }

        if (QuickFix.FIX42.ListStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX42.ListStatus.NoOrdersGroup();
            }
        }

        return null;
    }
}
