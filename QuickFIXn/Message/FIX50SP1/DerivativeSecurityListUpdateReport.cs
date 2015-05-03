using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class DerivativeSecurityListUpdateReport : Message
    {
        public const string MsgType = "BR";

        public DerivativeSecurityListUpdateReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
