using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class QuoteResponse : Message
    {
        public const string MsgType = "AJ";

        public QuoteResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
