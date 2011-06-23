using System.Collections.Generic;

namespace QuickFix
{
    public class Session
    {
        /// <summary>
        /// FIXME
        /// </summary>
        /// <param name="app"></param>
        /// <param name="storeFactory"></param>
        /// <param name="sessID"></param>
        /// <param name="dataDictProvider"></param>
        /// <param name="sessionSchedule"></param>
        /// <param name="heartBtInt"></param>
        /// <param name="logFactory"></param>
        public Session(Application app, MessageStoreFactory storeFactory, SessionID sessID, DataDictionaryProvider dataDictProvider, SessionSchedule sessionSchedule, int heartBtInt, LogFactory logFactory)
        {
        }
        
        public void SendToTarget(Message m)
        {
        }

        public void SetSenderDefaultApplVerID(string s)
        {
        }
    }
}
