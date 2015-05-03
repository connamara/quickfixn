using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class AllocationInstructionAck : Message
    {
        public const string MsgType = "P";

        public AllocationInstructionAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
