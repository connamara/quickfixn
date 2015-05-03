using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class QuoteStatusReport : Message
    {
        public const string MsgType = "AI";

        public QuoteStatusReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
