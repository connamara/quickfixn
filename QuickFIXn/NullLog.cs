
namespace QuickFix
{
    /// <summary>
    /// Log implementation that does not do anything.
    /// This is a singleton class; there's no reason to ever instantiate more than one.
    /// </summary>
    public class NullLog : ILog
    {
        private static NullLog _instance = null;

        /// <summary>
        /// Get the instance of NullLog.
        /// </summary>
        /// <returns></returns>
        public static NullLog GetInstance()
        {
            if (_instance == null)
                _instance = new NullLog(true);
            return _instance;
        }

        [System.Obsolete("Don't use this.  Use GetInstance() instead.")] // v2
        public NullLog()
        { }

        // this just here to circumvent the deprecation warning when called by GetInstance
        private NullLog(bool whatever)
        {}

        #region ILog Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        { }

        public void OnOutgoing(string msg)
        { }

        public void OnEvent(string s)
        { }

        public void Dispose()
        { }

        public void OnDebug(string s)
        { }

        #endregion


    }
}
