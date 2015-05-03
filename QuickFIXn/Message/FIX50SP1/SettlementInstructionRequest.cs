using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class SettlementInstructionRequest : Message
    {
        public const string MsgType = "AV";

        public SettlementInstructionRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
