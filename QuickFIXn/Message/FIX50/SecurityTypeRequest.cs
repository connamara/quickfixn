using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class SecurityTypeRequest : Message
    {
        public const string MsgType = "v";

        public SecurityTypeRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
