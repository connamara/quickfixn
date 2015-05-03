using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class PartyDetailsListReport : Message
    {
        public const string MsgType = "CG";

        public PartyDetailsListReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
