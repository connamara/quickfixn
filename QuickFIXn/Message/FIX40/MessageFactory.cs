namespace QuickFix.FIX40
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
          if(QuickFix.FIX40.News.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX40.News.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX40.Email.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX40.Email.LinesOfTextGroup();
              }
          }
          if(QuickFix.FIX40.ExecutionReport.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX40.ExecutionReport.NoMiscFeesGroup();
              }
          }
          if(QuickFix.FIX40.Allocation.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX40.Allocation.NoOrdersGroup();
					case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX40.Allocation.NoExecsGroup();
					case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX40.Allocation.NoMiscFeesGroup();
					case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX40.Allocation.NoAllocsGroup();
					case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX40.Allocation.NoAllocsGroup.NoDlvyInstGroup();
              }
          }
          if(QuickFix.FIX40.ListStatus.MsgType.Equals(msgType))
          {
              switch(correspondingFieldID)
              {
              case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX40.ListStatus.NoOrdersGroup();
              }
          }
            return null;
        }
    }
}
    