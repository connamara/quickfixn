using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradingSessionStatusRequest : Message
    {
        public const string MsgType = "g";

        public TradingSessionStatusRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
