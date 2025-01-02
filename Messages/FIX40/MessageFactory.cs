// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIX40;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIX40 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIX40.Heartbeat.MsgType => new QuickFix.FIX40.Heartbeat(),
            QuickFix.FIX40.Logon.MsgType => new QuickFix.FIX40.Logon(),
            QuickFix.FIX40.TestRequest.MsgType => new QuickFix.FIX40.TestRequest(),
            QuickFix.FIX40.ResendRequest.MsgType => new QuickFix.FIX40.ResendRequest(),
            QuickFix.FIX40.Reject.MsgType => new QuickFix.FIX40.Reject(),
            QuickFix.FIX40.SequenceReset.MsgType => new QuickFix.FIX40.SequenceReset(),
            QuickFix.FIX40.Logout.MsgType => new QuickFix.FIX40.Logout(),
            QuickFix.FIX40.Advertisement.MsgType => new QuickFix.FIX40.Advertisement(),
            QuickFix.FIX40.IndicationofInterest.MsgType => new QuickFix.FIX40.IndicationofInterest(),
            QuickFix.FIX40.News.MsgType => new QuickFix.FIX40.News(),
            QuickFix.FIX40.Email.MsgType => new QuickFix.FIX40.Email(),
            QuickFix.FIX40.QuoteRequest.MsgType => new QuickFix.FIX40.QuoteRequest(),
            QuickFix.FIX40.Quote.MsgType => new QuickFix.FIX40.Quote(),
            QuickFix.FIX40.NewOrderSingle.MsgType => new QuickFix.FIX40.NewOrderSingle(),
            QuickFix.FIX40.ExecutionReport.MsgType => new QuickFix.FIX40.ExecutionReport(),
            QuickFix.FIX40.DontKnowTrade.MsgType => new QuickFix.FIX40.DontKnowTrade(),
            QuickFix.FIX40.OrderCancelReplaceRequest.MsgType => new QuickFix.FIX40.OrderCancelReplaceRequest(),
            QuickFix.FIX40.OrderCancelRequest.MsgType => new QuickFix.FIX40.OrderCancelRequest(),
            QuickFix.FIX40.OrderCancelReject.MsgType => new QuickFix.FIX40.OrderCancelReject(),
            QuickFix.FIX40.OrderStatusRequest.MsgType => new QuickFix.FIX40.OrderStatusRequest(),
            QuickFix.FIX40.Allocation.MsgType => new QuickFix.FIX40.Allocation(),
            QuickFix.FIX40.AllocationACK.MsgType => new QuickFix.FIX40.AllocationACK(),
            QuickFix.FIX40.NewOrderList.MsgType => new QuickFix.FIX40.NewOrderList(),
            QuickFix.FIX40.ListStatus.MsgType => new QuickFix.FIX40.ListStatus(),
            QuickFix.FIX40.ListExecute.MsgType => new QuickFix.FIX40.ListExecute(),
            QuickFix.FIX40.ListCancelRequest.MsgType => new QuickFix.FIX40.ListCancelRequest(),
            QuickFix.FIX40.ListStatusRequest.MsgType => new QuickFix.FIX40.ListStatusRequest(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIX40.News.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX40.News.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX40.Email.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX40.Email.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX40.ExecutionReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX40.ExecutionReport.NoMiscFeesGroup();
            }
        }

        if (QuickFix.FIX40.Allocation.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX40.Allocation.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX40.Allocation.NoExecsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX40.Allocation.NoMiscFeesGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX40.Allocation.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX40.Allocation.NoAllocsGroup.NoDlvyInstGroup();
            }
        }

        if (QuickFix.FIX40.ListStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX40.ListStatus.NoOrdersGroup();
            }
        }

        return null;
    }
}
