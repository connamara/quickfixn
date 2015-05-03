using QuickFix.Fields;
namespace QuickFix.FIX50SP2
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
