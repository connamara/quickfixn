using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class AllocationInstruction : Message
    {
        public const string MsgType = "J";

        public AllocationInstruction():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
