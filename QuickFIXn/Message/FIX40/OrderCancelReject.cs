using QuickFix.Fields;
namespace QuickFix.FIX40
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
