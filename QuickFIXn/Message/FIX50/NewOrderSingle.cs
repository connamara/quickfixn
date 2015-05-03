using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class NewOrderSingle : Message
    {
        public const string MsgType = "D";

        public NewOrderSingle():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
