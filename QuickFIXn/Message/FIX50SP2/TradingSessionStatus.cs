using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class TradingSessionStatus : Message
    {
        public const string MsgType = "h";

        public TradingSessionStatus():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
