using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class OrderCancelRequest : Message
    {
        public const string MsgType = "F";

        public OrderCancelRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
