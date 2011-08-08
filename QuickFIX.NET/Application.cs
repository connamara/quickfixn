
namespace QuickFix
{
    public abstract class Application
    {
        public Application()
        { }

        public abstract void FromAdmin(Message message, SessionID sessionID);
        public abstract void FromApp(Message message, SessionID sessionID);

        public virtual void OnCreate(SessionID sessionID) { }
        public virtual void OnLogout(SessionID sessionID) { }
        public virtual void OnLogon(SessionID sessionID) { }
    }
}
