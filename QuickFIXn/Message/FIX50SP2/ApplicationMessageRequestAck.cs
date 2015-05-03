using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class ApplicationMessageRequestAck : Message
    {
        public const string MsgType = "BX";

        public ApplicationMessageRequestAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
