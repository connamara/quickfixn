// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIX41;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIX41 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIX41.Heartbeat.MsgType => new QuickFix.FIX41.Heartbeat(),
            QuickFix.FIX41.Logon.MsgType => new QuickFix.FIX41.Logon(),
            QuickFix.FIX41.TestRequest.MsgType => new QuickFix.FIX41.TestRequest(),
            QuickFix.FIX41.ResendRequest.MsgType => new QuickFix.FIX41.ResendRequest(),
            QuickFix.FIX41.Reject.MsgType => new QuickFix.FIX41.Reject(),
            QuickFix.FIX41.SequenceReset.MsgType => new QuickFix.FIX41.SequenceReset(),
            QuickFix.FIX41.Logout.MsgType => new QuickFix.FIX41.Logout(),
            QuickFix.FIX41.Advertisement.MsgType => new QuickFix.FIX41.Advertisement(),
            QuickFix.FIX41.IndicationofInterest.MsgType => new QuickFix.FIX41.IndicationofInterest(),
            QuickFix.FIX41.News.MsgType => new QuickFix.FIX41.News(),
            QuickFix.FIX41.Email.MsgType => new QuickFix.FIX41.Email(),
            QuickFix.FIX41.QuoteRequest.MsgType => new QuickFix.FIX41.QuoteRequest(),
            QuickFix.FIX41.Quote.MsgType => new QuickFix.FIX41.Quote(),
            QuickFix.FIX41.NewOrderSingle.MsgType => new QuickFix.FIX41.NewOrderSingle(),
            QuickFix.FIX41.ExecutionReport.MsgType => new QuickFix.FIX41.ExecutionReport(),
            QuickFix.FIX41.DontKnowTrade.MsgType => new QuickFix.FIX41.DontKnowTrade(),
            QuickFix.FIX41.OrderCancelReplaceRequest.MsgType => new QuickFix.FIX41.OrderCancelReplaceRequest(),
            QuickFix.FIX41.OrderCancelRequest.MsgType => new QuickFix.FIX41.OrderCancelRequest(),
            QuickFix.FIX41.OrderCancelReject.MsgType => new QuickFix.FIX41.OrderCancelReject(),
            QuickFix.FIX41.OrderStatusRequest.MsgType => new QuickFix.FIX41.OrderStatusRequest(),
            QuickFix.FIX41.Allocation.MsgType => new QuickFix.FIX41.Allocation(),
            QuickFix.FIX41.AllocationACK.MsgType => new QuickFix.FIX41.AllocationACK(),
            QuickFix.FIX41.SettlementInstructions.MsgType => new QuickFix.FIX41.SettlementInstructions(),
            QuickFix.FIX41.NewOrderList.MsgType => new QuickFix.FIX41.NewOrderList(),
            QuickFix.FIX41.ListStatus.MsgType => new QuickFix.FIX41.ListStatus(),
            QuickFix.FIX41.ListExecute.MsgType => new QuickFix.FIX41.ListExecute(),
            QuickFix.FIX41.ListCancelRequest.MsgType => new QuickFix.FIX41.ListCancelRequest(),
            QuickFix.FIX41.ListStatusRequest.MsgType => new QuickFix.FIX41.ListStatusRequest(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIX41.IndicationofInterest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX41.IndicationofInterest.NoIOIQualifiersGroup();
            }
        }

        if (QuickFix.FIX41.News.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX41.News.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX41.News.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX41.Email.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX41.Email.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX41.Email.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX41.Allocation.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX41.Allocation.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX41.Allocation.NoExecsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX41.Allocation.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX41.Allocation.NoAllocsGroup.NoMiscFeesGroup();
            }
        }

        if (QuickFix.FIX41.ListStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX41.ListStatus.NoOrdersGroup();
            }
        }

        return null;
    }
}
