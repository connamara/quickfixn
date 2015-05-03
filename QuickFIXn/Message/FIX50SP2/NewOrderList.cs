using QuickFix.Fields;
namespace QuickFix.FIX50SP2
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
