
namespace QuickFix
{
    public class FixValue<T>
    {
        private T value_;
        private string description_;

        public T Value { get { return value_; } }
        public string Description { get { return description_; } }

        public FixValue(T value, string description)
        {
            value_ = value;
            description_ = description;
        }

        public override bool Equals(object obj)
        {
            if ((null == obj) || (this.GetType() != obj.GetType()))
                return false;
            FixValue<T> rhs = (FixValue<T>)obj;
            return this.Value.Equals(rhs.Value);
        }

        public override int GetHashCode()
        {
            return value_.GetHashCode();
        }

        public override string ToString()
        {
            return description_;
        }
    }

    /// <summary>
    /// TODO generate this class
    /// </summary>
    namespace FixValues
    {
        public class MsgType
        {
            public const string HEARTBEAT        = "0";
            public const string TEST_REQUEST     = "1";
            public const string RESEND_REQUEST   = "2";
            public const string REJECT           = "3";
            public const string SEQUENCE_RESET   = "4";
            public const string LOGOUT           = "5";
            public const string LOGON            = "A";
            public const string NEW_ORDER_SINGLE = "D";
        }

        public class SessionRejectReason : FixValue<int>
        {
            public static SessionRejectReason INVALID_TAG_NUMBER = new SessionRejectReason(0, "Invalid tag number");
            public static SessionRejectReason VALUE_IS_INCORRECT = new SessionRejectReason(5, "Value is incorrect (out of range) for this tag");
            public static SessionRejectReason COMPID_PROBLEM     = new SessionRejectReason(9, "CompID problem");
            public static SessionRejectReason INVALID_MSGTYPE    = new SessionRejectReason(11, "Invalid MsgType");

            public SessionRejectReason(int value, string description)
                : base(value, description)
            { }
        }
    }
}
