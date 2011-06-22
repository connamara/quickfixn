
namespace QuickFix
{
    public interface Log
    {
        void Clear();
        void OnIncoming(string msg);
        void OnOutgoing(string msg);
        void OnEvent(string s);
    }
}
