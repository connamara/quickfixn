using System;

namespace QuickFix
{
    /// <summary>
    /// File log implementation
    /// </summary>
    public class FileLog : ILog, System.IDisposable
    {
        private object sync_ = new object();

        private System.IO.StreamWriter messageLog_;
        private System.IO.StreamWriter eventLog_;
        private System.IO.StreamWriter debugLog_;

        private string messageLogFileName_;
        private string eventLogFileName_;
        private string debugLogFileName_;
        private bool logDebug_;

        [Obsolete("Use another constructor")]
        public FileLog(string fileLogPath)
            : this(fileLogPath, false)
        {
        }
        
        public FileLog(string fileLogPath, bool logDebug)
        {
            logDebug_ = logDebug;
            Init(fileLogPath, "GLOBAL");
        }

        [Obsolete("Use another constructor")]
        public FileLog(string fileLogPath, SessionID sessionID)
            : this(fileLogPath, sessionID, false)
        {
        }
        
        public FileLog(string fileLogPath, SessionID sessionID, bool logDebug)
        {
            logDebug_ = logDebug;
            Init(fileLogPath, Prefix(sessionID));
        }   
        

        private void Init(string fileLogPath, string prefix)
        {
            if (!System.IO.Directory.Exists(fileLogPath))
                System.IO.Directory.CreateDirectory(fileLogPath);

            messageLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".messages.current.log");
            eventLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".event.current.log");

            messageLog_ = new System.IO.StreamWriter(messageLogFileName_,true);
            eventLog_ = new System.IO.StreamWriter(eventLogFileName_,true);

            messageLog_.AutoFlush = true;
            eventLog_.AutoFlush = true;

            if (logDebug_)
            {
                debugLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".debug.current.log");
                debugLog_ = new System.IO.StreamWriter(debugLogFileName_, true);
                debugLog_.AutoFlush = true;
            }
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

                if (logDebug_)
                {
                    debugLog_.Close();
                    debugLog_ = new System.IO.StreamWriter(debugLogFileName_, false);
                    debugLog_.AutoFlush = true;
                }
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

        public void OnDebug(string s)
        {
            if (!logDebug_)
                return;
            
            lock (sync_)
            {
                debugLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + s);
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
