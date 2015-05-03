using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MarketDefinitionRequest : Message
    {
        public const string MsgType = "BT";

        public MarketDefinitionRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
