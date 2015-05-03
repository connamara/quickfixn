using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Email : Message
    {
        public const string MsgType = "C";

        public Email():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
