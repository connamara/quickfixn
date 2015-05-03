using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class CollateralInquiry : Message
    {
        public const string MsgType = "BB";

        public CollateralInquiry():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
