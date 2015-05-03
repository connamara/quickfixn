using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Logon : Message
    {
        public const string MsgType = "A";

        public Logon():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
