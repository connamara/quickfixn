using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class AdjustedPositionReport : Message
    {
        public const string MsgType = "BL";

        public AdjustedPositionReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
