using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class SecurityDefinition : Message
    {
        public const string MsgType = "d";

        public SecurityDefinition():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
