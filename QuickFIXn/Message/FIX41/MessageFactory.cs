// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX41
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX41.Heartbeat.MsgType: return new QuickFix.FIX41.Heartbeat();
                    case QuickFix.FIX41.Logon.MsgType: return new QuickFix.FIX41.Logon();
                    case QuickFix.FIX41.TestRequest.MsgType: return new QuickFix.FIX41.TestRequest();
                    case QuickFix.FIX41.ResendRequest.MsgType: return new QuickFix.FIX41.ResendRequest();
                    case QuickFix.FIX41.Reject.MsgType: return new QuickFix.FIX41.Reject();
                    case QuickFix.FIX41.SequenceReset.MsgType: return new QuickFix.FIX41.SequenceReset();
                    case QuickFix.FIX41.Logout.MsgType: return new QuickFix.FIX41.Logout();
                    case QuickFix.FIX41.Advertisement.MsgType: return new QuickFix.FIX41.Advertisement();
                    case QuickFix.FIX41.IndicationofInterest.MsgType: return new QuickFix.FIX41.IndicationofInterest();
                    case QuickFix.FIX41.News.MsgType: return new QuickFix.FIX41.News();
                    case QuickFix.FIX41.Email.MsgType: return new QuickFix.FIX41.Email();
                    case QuickFix.FIX41.QuoteRequest.MsgType: return new QuickFix.FIX41.QuoteRequest();
                    case QuickFix.FIX41.Quote.MsgType: return new QuickFix.FIX41.Quote();
                    case QuickFix.FIX41.NewOrderSingle.MsgType: return new QuickFix.FIX41.NewOrderSingle();
                    case QuickFix.FIX41.ExecutionReport.MsgType: return new QuickFix.FIX41.ExecutionReport();
                    case QuickFix.FIX41.DontKnowTrade.MsgType: return new QuickFix.FIX41.DontKnowTrade();
                    case QuickFix.FIX41.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX41.OrderCancelReplaceRequest();
                    case QuickFix.FIX41.OrderCancelRequest.MsgType: return new QuickFix.FIX41.OrderCancelRequest();
                    case QuickFix.FIX41.OrderCancelReject.MsgType: return new QuickFix.FIX41.OrderCancelReject();
                    case QuickFix.FIX41.OrderStatusRequest.MsgType: return new QuickFix.FIX41.OrderStatusRequest();
                    case QuickFix.FIX41.Allocation.MsgType: return new QuickFix.FIX41.Allocation();
                    case QuickFix.FIX41.AllocationACK.MsgType: return new QuickFix.FIX41.AllocationACK();
                    case QuickFix.FIX41.SettlementInstructions.MsgType: return new QuickFix.FIX41.SettlementInstructions();
                    case QuickFix.FIX41.NewOrderList.MsgType: return new QuickFix.FIX41.NewOrderList();
                    case QuickFix.FIX41.ListStatus.MsgType: return new QuickFix.FIX41.ListStatus();
                    case QuickFix.FIX41.ListExecute.MsgType: return new QuickFix.FIX41.ListExecute();
                    case QuickFix.FIX41.ListCancelRequest.MsgType: return new QuickFix.FIX41.ListCancelRequest();
                    case QuickFix.FIX41.ListStatusRequest.MsgType: return new QuickFix.FIX41.ListStatusRequest();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX41.IndicationofInterest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX41.IndicationofInterest.NoIOIQualifiersGroup();
                    }
                }

                if (QuickFix.FIX41.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX41.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX41.News.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX41.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX41.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX41.Email.LinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX41.Allocation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX41.Allocation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX41.Allocation.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX41.Allocation.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX41.Allocation.NoAllocsGroup.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX41.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX41.ListStatus.NoOrdersGroup();
                    }
                }

                return null;
            }

        }
    }
}
