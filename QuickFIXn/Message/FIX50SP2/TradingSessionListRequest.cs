using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradingSessionListRequest : Message
    {
        public const string MsgType = "BI";

        public TradingSessionListRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
