using QuickFix.Fields;
namespace QuickFix.FIX50SP1
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
