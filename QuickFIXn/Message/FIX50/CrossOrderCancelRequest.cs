using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class CrossOrderCancelRequest : Message
    {
        public const string MsgType = "u";

        public CrossOrderCancelRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
