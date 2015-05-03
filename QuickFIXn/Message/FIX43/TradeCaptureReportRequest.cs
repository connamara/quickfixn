using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class TradeCaptureReportRequest : Message
    {
        public const string MsgType = "AD";

        public TradeCaptureReportRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
