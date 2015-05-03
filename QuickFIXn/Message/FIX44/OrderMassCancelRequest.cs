using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class OrderMassCancelRequest : Message
    {
        public const string MsgType = "q";

        public OrderMassCancelRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
