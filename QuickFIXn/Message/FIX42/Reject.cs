using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class Reject : Message
    {
        public const string MsgType = "3";

        public Reject():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
