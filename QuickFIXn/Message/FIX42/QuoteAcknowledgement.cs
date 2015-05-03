using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class QuoteAcknowledgement : Message
    {
        public const string MsgType = "b";

        public QuoteAcknowledgement():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
