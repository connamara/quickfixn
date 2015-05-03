using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class PositionMaintenanceReport : Message
    {
        public const string MsgType = "AM";

        public PositionMaintenanceReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
