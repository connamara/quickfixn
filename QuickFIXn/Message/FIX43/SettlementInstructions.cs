using QuickFix.Fields;
namespace QuickFix.FIX43
{
    public class SettlementInstructions : Message
    {
        public const string MsgType = "T";

        public SettlementInstructions():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
