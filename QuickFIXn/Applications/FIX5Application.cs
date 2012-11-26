
namespace QuickFix.Applications
{
    public class FIX5Application : IApplication
    {
        public void FromAdmin(Message message, SessionID sessionID)
        {
            System.Diagnostics.Debug.WriteLine("Received FIX admin message: " + message.ToString());
        }

        public void FromApp(Message message, SessionID sessionID)
        {
            System.Diagnostics.Debug.WriteLine("Received FIX app message: " + message.ToString());
        }

        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }
        public void ToApp(Message message, SessionID sessionID) { }
    }
}
