using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class TradingSessionList : Message
    {
        public const string MsgType = "BJ";

        public TradingSessionList():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
