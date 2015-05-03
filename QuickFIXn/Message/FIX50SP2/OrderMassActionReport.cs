using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class OrderMassActionReport : Message
    {
        public const string MsgType = "BZ";

        public OrderMassActionReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
