
namespace QuickFix
{
    public interface Responder
    {
        bool Send(string s);
        void Disconnect();
    }
}
