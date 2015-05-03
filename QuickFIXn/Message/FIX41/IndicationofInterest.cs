using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class IndicationofInterest : Message
    {
        public const string MsgType = "6";

        public IndicationofInterest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
