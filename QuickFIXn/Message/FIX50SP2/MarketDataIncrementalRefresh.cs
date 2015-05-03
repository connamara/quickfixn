using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class MarketDataIncrementalRefresh : Message
    {
        public const string MsgType = "X";

        public MarketDataIncrementalRefresh():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
