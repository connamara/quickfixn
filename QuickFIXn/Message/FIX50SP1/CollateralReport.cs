using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class CollateralReport : Message
    {
        public const string MsgType = "BA";

        public CollateralReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
