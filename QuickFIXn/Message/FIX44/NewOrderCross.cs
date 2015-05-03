using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class NewOrderCross : Message
    {
        public const string MsgType = "s";

        public NewOrderCross():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
