
namespace QuickFix
{
    public interface Application
    {
        void FromAdmin(Message message, SessionID sessionID);
        void FromApp(Message message, SessionID sessionID);

        void OnCreate(SessionID sessionID);
        void OnLogout(SessionID sessionID);
        void OnLogon(SessionID sessionID);
    }
}
