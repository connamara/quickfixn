
namespace QuickFix
{
    /// <summary>
    /// TODO generate this class
    /// </summary>
    namespace FixValues
    {
        public class MsgType
        {
            public const string HEARTBEAT = "0";
            public const string TEST_REQUEST = "1";
            public const string RESEND_REQUEST = "2";
            public const string REJECT = "3";
            public const string SEQUENCE_RESET = "4";
            public const string LOGOUT = "5";
            public const string LOGON = "A";
            public const string NEW_ORDER_SINGLE = "D";
        }

        public class SessionRejectReason
        {
            public const int VALUE_IS_INCORRECT = 5;
        }
    }
}
