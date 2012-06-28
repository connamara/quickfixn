﻿
namespace QuickFix
{
    /// <summary>
    /// Session log for messages and events
    /// </summary>
    public interface Log
    {
        /// <summary>
        /// Clears the log and removes any persistent log data
        /// </summary>
        void Clear();

        /// <summary>
        /// Logs an incoming message
        /// </summary>
        /// <param name="msg">a raw FIX message</param>
        void OnIncoming(string msg);

        /// <summary>
        /// Logs an outgoing message
        /// </summary>
        /// <param name="msg">a raw FIX message</param>
        void OnOutgoing(string msg);

        /// <summary>
        /// Logs a session event
        /// </summary>
        /// <param name="s">event description</param>
        void OnEvent(string s);
    }
}
