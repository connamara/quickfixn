
namespace QuickFix
{
    public class NullApplication : Application
    {
        public override void FromAdmin(Message message, SessionID sessionID)
        { }

        public override void FromApp(Message message, SessionID sessionID)
        { }
    }
}
