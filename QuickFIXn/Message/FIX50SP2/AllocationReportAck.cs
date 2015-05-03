using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class AllocationReportAck : Message
    {
        public const string MsgType = "AT";

        public AllocationReportAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
