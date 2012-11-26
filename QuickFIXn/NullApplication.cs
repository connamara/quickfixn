
namespace QuickFix
{
    /// <summary>
    /// Application implementation that does not do anything.
    /// Useful for unit testing.
    /// </summary>
    public class NullApplication : IApplication
    {
        public void FromAdmin(Message message, SessionID sessionID)
        { }

        public void FromApp(Message message, SessionID sessionID)
        { }

        public void OnCreate(SessionID sessionID) { }
        public void OnLogout(SessionID sessionID) { }
        public void OnLogon(SessionID sessionID) { }
        public void ToAdmin(Message message, SessionID sessionID) { }
        public void ToApp(Message message, SessionID sessionID) { }
    }
}
