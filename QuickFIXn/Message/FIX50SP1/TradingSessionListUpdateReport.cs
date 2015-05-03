using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class TradingSessionListUpdateReport : Message
    {
        public const string MsgType = "BS";

        public TradingSessionListUpdateReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
