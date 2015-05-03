using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class MarketDataSnapshotFullRefresh : Message
    {
        public const string MsgType = "W";

        public MarketDataSnapshotFullRefresh():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
