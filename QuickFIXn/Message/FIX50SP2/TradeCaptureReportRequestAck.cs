using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradeCaptureReportRequestAck : Message
    {
        public const string MsgType = "AQ";

        public TradeCaptureReportRequestAck():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
