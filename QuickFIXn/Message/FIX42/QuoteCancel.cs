using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class QuoteCancel : Message
    {
        public const string MsgType = "Z";

        public QuoteCancel():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
