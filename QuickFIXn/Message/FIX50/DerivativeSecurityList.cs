using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class DerivativeSecurityList : Message
    {
        public const string MsgType = "AA";

        public DerivativeSecurityList():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
