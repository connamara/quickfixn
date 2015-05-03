using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class NewOrderList : Message
    {
        public const string MsgType = "E";

        public NewOrderList():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
