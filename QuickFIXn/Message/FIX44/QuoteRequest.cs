using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class QuoteRequest : Message
    {
        public const string MsgType = "R";

        public QuoteRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
