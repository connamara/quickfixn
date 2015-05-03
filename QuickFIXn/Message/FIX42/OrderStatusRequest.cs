using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class OrderStatusRequest : Message
    {
        public const string MsgType = "H";

        public OrderStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
