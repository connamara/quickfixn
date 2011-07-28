
namespace QuickFix
{
    /// <summary>
    /// FIXME - right now this just works like ScreenLog, but writing to a file
    /// </summary>
    public class FileLog : Log
    {
        private object sync_ = new object();
        private SessionID sessionID_;
        System.IO.StreamWriter file_;

        public FileLog(string fileLogPath, SessionID sessionID)
        {
            sessionID_ = sessionID;

            if (!System.IO.Directory.Exists(fileLogPath))
                System.IO.Directory.CreateDirectory(fileLogPath);

            string fname = new System.Text.StringBuilder(sessionID_.BeginString)
                .Append('-').Append(sessionID_.SenderCompID)
                .Append('-').Append(sessionID_.TargetCompID)
                .Append(".fixme.log")
                .ToString();
            fname = System.IO.Path.Combine(fileLogPath, fname);
            System.Console.WriteLine("@@@ " + fname);
            file_ = new System.IO.StreamWriter(fname);
        }

        public void Destroy()
        {
            lock (sync_)
            {
                file_.Close();
            }
        }

        #region Log Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        {
            lock (sync_)
            {
                file_.WriteLine("<incoming> " + msg);
                file_.Flush();
            }
        }

        public void OnOutgoing(string msg)
        {
            lock (sync_)
            {
                file_.WriteLine("<outgoing> " + msg);
                file_.Flush();
            }
        }

        public void OnEvent(string s)
        {
            lock (sync_)
            {
                file_.WriteLine("<event> " + s);
                file_.Flush();
            }
        }

        #endregion
    }
}
