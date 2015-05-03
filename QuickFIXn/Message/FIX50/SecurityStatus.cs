using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class SecurityStatus : Message
    {
        public const string MsgType = "f";

        public SecurityStatus():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
