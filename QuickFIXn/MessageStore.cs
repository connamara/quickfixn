﻿using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Used by a Session to store and retrieve messages for resend purposes
    /// </summary>
    public interface MessageStore
    {
        /// <summary>
        /// Get messages within sequence number range (inclusive). Used for
        /// message resend requests
        /// </summary>
        /// <param name="startSeqNum">the starting message sequence number</param>
        /// <param name="endSeqNum">the ending message sequence number</param>
        /// <param name="messages">the retrieved messages (out parameter)</param>
        void Get(int startSeqNum, int endSeqNum, List<string> messages);

        /// <summary>
        /// Adds a raw fix message to the store with the give sequence number
        /// </summary>
        /// <param name="msgSeqNum">the sequence number</param>
        /// <param name="msg">the raw FIX message string</param>
        /// <returns>true if successful, false otherwise</returns>
        bool Set(int msgSeqNum, string msg);

        int GetNextSenderMsgSeqNum();
        int GetNextTargetMsgSeqNum();
        void SetNextSenderMsgSeqNum(int value);
        void SetNextTargetMsgSeqNum(int value);
        void IncrNextSenderMsgSeqNum();
        void IncrNextTargetMsgSeqNum();

        /// <summary>
        /// Get the session creation time
        /// </summary>
        /// <returns>the session creation time</returns>
        System.DateTime GetCreationTime();

        /// <summary>
        /// Reset the message store. Sequence numbers are set back to 1 and stored
        /// messages are erased. The session creation time is also set to the time of
        /// the reset
        /// </summary>
        void Reset();

        /// <summary>
        /// Refreshes session state from a shared state storage (e.g. database,
        /// file, ...). Refresh will not work for message stores without shared state
        /// (e.g. MemoryStore). These stores should log a session error, at a minimum,
        /// or throw an exception.
        /// </summary>
        void Refresh();
    }
}
