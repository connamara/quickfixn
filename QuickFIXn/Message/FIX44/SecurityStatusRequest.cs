using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class SecurityStatusRequest : Message
    {
        public const string MsgType = "e";

        public SecurityStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
