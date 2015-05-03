using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class TradeCaptureReport : Message
    {
        public const string MsgType = "AE";

        public TradeCaptureReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
