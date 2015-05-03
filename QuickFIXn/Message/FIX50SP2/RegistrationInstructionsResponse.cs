using QuickFix.Fields;
namespace QuickFix.FIX50SP2
{
    public class RegistrationInstructionsResponse : Message
    {
        public const string MsgType = "p";

        public RegistrationInstructionsResponse():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
