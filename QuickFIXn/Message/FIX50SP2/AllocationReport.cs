using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class AllocationReport : Message
    {
        public const string MsgType = "AS";

        public AllocationReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
