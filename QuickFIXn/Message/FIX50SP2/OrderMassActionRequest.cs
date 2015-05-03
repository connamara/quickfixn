using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class OrderMassActionRequest : Message
    {
        public const string MsgType = "CA";

        public OrderMassActionRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
