using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class CollateralRequest : Message
    {
        public const string MsgType = "AX";

        public CollateralRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
