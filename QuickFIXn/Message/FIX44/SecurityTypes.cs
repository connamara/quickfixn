using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class SecurityTypes : Message
    {
        public const string MsgType = "w";

        public SecurityTypes():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
