using QuickFix.Fields;
namespace QuickFix.FIX50SP1
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
