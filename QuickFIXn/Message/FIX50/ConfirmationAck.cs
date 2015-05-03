using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class ConfirmationAck : Message
    {
        public const string MsgType = "AU";

        public ConfirmationAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
