
namespace QuickFix.Applications
{
    public class FIX4Application : Application
    {
        public FIX4Application() { }

        public override void FromAdmin(Message message, SessionID sessionID)
        {
            System.Diagnostics.Debug.WriteLine("Received FIX admin message: " + message.ToString());
        }

        public override void FromApp(Message message, SessionID sessionID)
        {
            System.Diagnostics.Debug.WriteLine("Received FIX app message: " + message.ToString());
        }
    }
}
