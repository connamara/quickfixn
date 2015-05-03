using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradeCaptureReportAck : Message
    {
        public const string MsgType = "AR";

        public TradeCaptureReportAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
