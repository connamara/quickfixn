
namespace QuickFix
{
    /// <summary>
    /// File log implementation
    /// </summary>
    internal class CompositeLog : ILog
    {
        private ILog[] logs_;

        public CompositeLog(ILog[] logs)
        {
            logs_ = logs;
        }   

        public void Clear()
        {
            foreach (var log in logs_)
              log.Clear();
        }

        public void OnIncoming(string msg)
        {
          foreach (var log in logs_)
            log.OnIncoming(msg);
        }

        public void OnOutgoing(string msg)
        {
          foreach (var log in logs_)
            log.OnOutgoing(msg);
        }

        public void OnEvent(string s)
        {
          foreach (var log in logs_)
            log.OnEvent(s);
        }
    }
}
