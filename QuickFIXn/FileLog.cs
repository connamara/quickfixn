
using System.Collections.Generic;
namespace QuickFix
{
    /// <summary>
    /// File log implementation
    /// </summary>
    public class FileLog : Log, System.IDisposable
    {
        private object sync_ = new object();

        private System.IO.StreamWriter messageLog_;
        private System.IO.StreamWriter eventLog_;

        private string messageLogFileName_;
        private string eventLogFileName_;

        [System.Obsolete("Use FileLog constructor with log rotation options instead")]
        public FileLog(string fileLogPath)
        {
            Init(fileLogPath, "GLOBAL", false, -1);
        }

        public FileLog(string fileLogPath, bool DoRotateLog, int RotateLogNumToKeep)
        {
            Init(fileLogPath, "GLOBAL", DoRotateLog, RotateLogNumToKeep);
        }

        public FileLog(string fileLogPath, SessionID sessionID, bool DoRotateLog, int RotateLogNumToKeep)
        {
            Init(fileLogPath, Prefix(sessionID), DoRotateLog, RotateLogNumToKeep);
        }

        private void Init(string fileLogPath, string prefix, bool DoRotateLog, int RotateLogNumToKeep)
        {
            if (!System.IO.Directory.Exists(fileLogPath))
                System.IO.Directory.CreateDirectory(fileLogPath);

            messageLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".messages.current.log");
            eventLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".event.current.log");

            if (DoRotateLog)
                RotateLog(new string[] { messageLogFileName_, eventLogFileName_ }, RotateLogNumToKeep);

            messageLog_ = new System.IO.StreamWriter(messageLogFileName_,true);
            eventLog_ = new System.IO.StreamWriter(eventLogFileName_,true);

            messageLog_.AutoFlush = true;
            eventLog_.AutoFlush = true;
        }

        /// <summary>
        /// Attempt to rotate logs. 
        /// Returns null string if successful, error string if otherwise.
        /// Doesn't use filesystem creationtime due to file tunneling.
        /// </summary>
        /// <param name="LogFileNames"></param>
        /// <param name="RotateLogNumToKeep"></param>
        /// <returns></returns>
        private static string RotateLog(string[] LogFileNames, int RotateLogNumToKeep)
        {
            try
            {
                foreach (string fn in LogFileNames)
                {
                    if (System.IO.File.Exists(fn))
                        System.IO.File.Move(fn, fn + System.DateTime.UtcNow.ToString(".MMddyyyy-HHmmssffff"));


                    System.IO.FileInfo fiLog = new System.IO.FileInfo(fn);
                    List<System.IO.FileInfo> oldLogs = new List<System.IO.FileInfo>();

                    if (RotateLogNumToKeep < 0) RotateLogNumToKeep = 0;

                    foreach (string f in System.IO.Directory.GetFiles(fiLog.DirectoryName, fiLog.Name + ".*", System.IO.SearchOption.TopDirectoryOnly))
                        oldLogs.Add(new System.IO.FileInfo(System.IO.Path.Combine(fiLog.DirectoryName, f)));

                    oldLogs.Sort((a, b) => a.LastWriteTimeUtc.CompareTo(b.LastWriteTimeUtc));

                    for (int i = 0; ((oldLogs.Count > RotateLogNumToKeep) && (i <= (oldLogs.Count - RotateLogNumToKeep) - 1)); i++)
                        oldLogs[i].Delete();

                }
            }
            catch (System.Exception e1)
            { return e1.Message; }

            return null;
        }

        public static string Prefix(SessionID sessionID)
        {
            System.Text.StringBuilder prefix = new System.Text.StringBuilder(sessionID.BeginString)
                .Append('-').Append(sessionID.SenderCompID);
            if (SessionID.IsSet(sessionID.SenderSubID))
                prefix.Append('_').Append(sessionID.SenderSubID);
            if (SessionID.IsSet(sessionID.SenderLocationID))
                prefix.Append('_').Append(sessionID.SenderLocationID);
            prefix.Append('-').Append(sessionID.TargetCompID);
            if (SessionID.IsSet(sessionID.TargetSubID))
                prefix.Append('_').Append(sessionID.TargetSubID);
            if (SessionID.IsSet(sessionID.TargetLocationID))
                prefix.Append('_').Append(sessionID.TargetLocationID);

            if(sessionID.SessionQualifier.Length!=0)
                prefix.Append('-').Append(sessionID.SessionQualifier);

            return prefix.ToString();
        }

        #region Log Members

        public void Clear()
        {
            lock (sync_)
            {
                messageLog_.Close();
                eventLog_.Close();

                messageLog_ = new System.IO.StreamWriter(messageLogFileName_, false);
                eventLog_ = new System.IO.StreamWriter(eventLogFileName_, false);

                messageLog_.AutoFlush = true;
                eventLog_.AutoFlush = true;
            }
        }

        public void OnIncoming(string msg)
        {
            lock (sync_)
            {
                messageLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            lock (sync_)
            {
                messageLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + msg);
            }
        }

        public void OnEvent(string s)
        {
            lock (sync_)
            {
                eventLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : "+ s);
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
