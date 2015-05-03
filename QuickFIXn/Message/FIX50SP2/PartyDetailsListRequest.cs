using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class PartyDetailsListRequest : Message
    {
        public const string MsgType = "CF";

        public PartyDetailsListRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
