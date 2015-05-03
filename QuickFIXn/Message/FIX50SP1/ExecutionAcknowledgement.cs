using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ExecutionAcknowledgement : Message
    {
        public const string MsgType = "BN";

        public ExecutionAcknowledgement():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
