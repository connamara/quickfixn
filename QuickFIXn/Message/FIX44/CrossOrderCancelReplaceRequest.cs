using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class CrossOrderCancelReplaceRequest : Message
    {
        public const string MsgType = "t";

        public CrossOrderCancelReplaceRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
