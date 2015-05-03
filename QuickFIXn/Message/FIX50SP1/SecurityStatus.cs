using QuickFix.Fields;
namespace QuickFix.FIX50SP1
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
