using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class CollateralAssignment : Message
    {
        public const string MsgType = "AY";

        public CollateralAssignment():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
