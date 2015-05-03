namespace QuickFix.FIX41
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
                case NewOrderList.MsgType: return new NewOrderList();
                case ListStatus.MsgType: return new ListStatus();
                case ListExecute.MsgType: return new ListExecute();
                case ListCancelRequest.MsgType: return new ListCancelRequest();
                case ListStatusRequest.MsgType: return new ListStatusRequest();
            }

            return new QuickFix.Message();
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
            return null;
        }
    }
}
    