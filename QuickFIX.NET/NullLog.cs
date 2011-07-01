
namespace QuickFix
{
    public class NullLog : Log
    {
        #region Log Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        { }

        public void OnOutgoing(string msg)
        { }

        public void OnEvent(string s)
        { }

        #endregion
    }
}
