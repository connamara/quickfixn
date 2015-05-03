using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class QuoteStatusRequest : Message
    {
        public const string MsgType = "a";

        public QuoteStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
