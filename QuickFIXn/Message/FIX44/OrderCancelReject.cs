using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class OrderCancelReject : Message
    {
        public const string MsgType = "9";

        public OrderCancelReject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
