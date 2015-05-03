using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MassQuoteAcknowledgement : Message
    {
        public const string MsgType = "b";

        public MassQuoteAcknowledgement():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
