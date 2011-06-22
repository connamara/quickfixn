
namespace QuickFix
{
    public interface LogFactory
    {
        Log Create(SessionID sessionID);
    }
}
