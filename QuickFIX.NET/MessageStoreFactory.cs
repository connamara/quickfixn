
namespace QuickFix
{
    public interface MessageStoreFactory
    {
        MessageStore Create(SessionID sessionID);
    }
}
