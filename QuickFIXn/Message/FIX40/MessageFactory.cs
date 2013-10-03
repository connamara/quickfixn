// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX40
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX40.Heartbeat.MsgType: return new QuickFix.FIX40.Heartbeat();
                    case QuickFix.FIX40.Logon.MsgType: return new QuickFix.FIX40.Logon();
                    case QuickFix.FIX40.TestRequest.MsgType: return new QuickFix.FIX40.TestRequest();
                    case QuickFix.FIX40.ResendRequest.MsgType: return new QuickFix.FIX40.ResendRequest();
                    case QuickFix.FIX40.Reject.MsgType: return new QuickFix.FIX40.Reject();
                    case QuickFix.FIX40.SequenceReset.MsgType: return new QuickFix.FIX40.SequenceReset();
                    case QuickFix.FIX40.Logout.MsgType: return new QuickFix.FIX40.Logout();
                    case QuickFix.FIX40.Advertisement.MsgType: return new QuickFix.FIX40.Advertisement();
                    case QuickFix.FIX40.IndicationofInterest.MsgType: return new QuickFix.FIX40.IndicationofInterest();
                    case QuickFix.FIX40.News.MsgType: return new QuickFix.FIX40.News();
                    case QuickFix.FIX40.Email.MsgType: return new QuickFix.FIX40.Email();
                    case QuickFix.FIX40.QuoteRequest.MsgType: return new QuickFix.FIX40.QuoteRequest();
                    case QuickFix.FIX40.Quote.MsgType: return new QuickFix.FIX40.Quote();
                    case QuickFix.FIX40.NewOrderSingle.MsgType: return new QuickFix.FIX40.NewOrderSingle();
                    case QuickFix.FIX40.ExecutionReport.MsgType: return new QuickFix.FIX40.ExecutionReport();
                    case QuickFix.FIX40.DontKnowTrade.MsgType: return new QuickFix.FIX40.DontKnowTrade();
                    case QuickFix.FIX40.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX40.OrderCancelReplaceRequest();
                    case QuickFix.FIX40.OrderCancelRequest.MsgType: return new QuickFix.FIX40.OrderCancelRequest();
                    case QuickFix.FIX40.OrderCancelReject.MsgType: return new QuickFix.FIX40.OrderCancelReject();
                    case QuickFix.FIX40.OrderStatusRequest.MsgType: return new QuickFix.FIX40.OrderStatusRequest();
                    case QuickFix.FIX40.Allocation.MsgType: return new QuickFix.FIX40.Allocation();
                    case QuickFix.FIX40.AllocationACK.MsgType: return new QuickFix.FIX40.AllocationACK();
                    case QuickFix.FIX40.NewOrderList.MsgType: return new QuickFix.FIX40.NewOrderList();
                    case QuickFix.FIX40.ListStatus.MsgType: return new QuickFix.FIX40.ListStatus();
                    case QuickFix.FIX40.ListExecute.MsgType: return new QuickFix.FIX40.ListExecute();
                    case QuickFix.FIX40.ListCancelRequest.MsgType: return new QuickFix.FIX40.ListCancelRequest();
                    case QuickFix.FIX40.ListStatusRequest.MsgType: return new QuickFix.FIX40.ListStatusRequest();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX40.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX40.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX40.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX40.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX40.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX40.ExecutionReport.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX40.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
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
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX40.ListStatus.NoOrdersGroup();
                    }
                }

                return null;
            }

        }
    }
}
