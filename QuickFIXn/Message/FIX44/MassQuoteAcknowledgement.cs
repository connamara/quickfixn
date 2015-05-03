using QuickFix.Fields;
namespace QuickFix.FIX44
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
