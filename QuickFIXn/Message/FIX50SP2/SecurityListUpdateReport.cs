using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class SecurityListUpdateReport : Message
    {
        public const string MsgType = "BK";

        public SecurityListUpdateReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
