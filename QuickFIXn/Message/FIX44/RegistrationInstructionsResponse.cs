using QuickFix.Fields;
namespace QuickFix.FIX44
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
