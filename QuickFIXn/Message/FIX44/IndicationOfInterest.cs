using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class IndicationOfInterest : Message
    {
        public const string MsgType = "6";

        public IndicationOfInterest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
