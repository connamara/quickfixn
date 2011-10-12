
namespace QuickFix
{
    /// <summary>
    /// FIXME - right now this just works like ScreenLog, but writing to a file
    /// </summary>
    public class FileLog : Log, System.IDisposable
    {
        private object sync_ = new object();

        private System.IO.StreamWriter messageLog_;
        private System.IO.StreamWriter eventLog_;

        public FileLog(string fileLogPath)
        {
            Init(fileLogPath, "GLOBAL");
        }

        public FileLog(string fileLogPath, SessionID sessionID)
        {
            Init(fileLogPath, Prefix(sessionID));
        }   

        

        private void Init(string fileLogPath, string prefix)
        {
            if (!System.IO.Directory.Exists(fileLogPath))
                System.IO.Directory.CreateDirectory(fileLogPath);

            messageLog_ = new System.IO.StreamWriter(
                System.IO.Path.Combine(fileLogPath, prefix + ".messages.current.log"));
            eventLog_ = new System.IO.StreamWriter(
                System.IO.Path.Combine(fileLogPath, prefix + ".event.current.log"));
        }

        public static string Prefix(SessionID sessionID)
        {
            System.Text.StringBuilder prefix = new System.Text.StringBuilder(sessionID.BeginString)
                .Append('-').Append(sessionID.SenderCompID)
                .Append('-').Append(sessionID.TargetCompID);

            if(sessionID.SessionQualifier.Length!=0)
                prefix.Append('-').Append(sessionID.SessionQualifier);

            return prefix.ToString();
        }

        #region Log Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        {
            lock (sync_)
            {
                messageLog_.WriteLine("<incoming> " + msg);
                messageLog_.Flush();
            }
        }

        public void OnOutgoing(string msg)
        {
            lock (sync_)
            {
                messageLog_.WriteLine("<outgoing> " + msg);
                messageLog_.Flush();
            }
        }

        public void OnEvent(string s)
        {
            lock (sync_)
            {
                eventLog_.WriteLine("<event> " + s);
                eventLog_.Flush();
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            messageLog_.Close();
            eventLog_.Close();
        }

        #endregion
    }
}
