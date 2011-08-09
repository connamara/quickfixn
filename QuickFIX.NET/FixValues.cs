
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
        public class ApplVerID
        {
            public const string FIX27 = "0";
            public const string FIX30 = "1";
            public const string FIX40 = "2";
            public const string FIX41 = "3";
            public const string FIX42 = "4";
            public const string FIX43 = "5";
            public const string FIX44 = "6";
            public const string FIX50 = "7";
            public const string FIX50SP1 = "8";
            public const string FIX50SP2 = "9";

            public static string FromBeginString(string beginString)
            {
                if (BeginString.FIX40.Equals(beginString))
                    return ApplVerID.FIX40;
                else if (BeginString.FIX41.Equals(beginString))
                    return ApplVerID.FIX41;
                else if (BeginString.FIX42.Equals(beginString))
                    return ApplVerID.FIX42;
                else if (BeginString.FIX43.Equals(beginString))
                    return ApplVerID.FIX43;
                else if (BeginString.FIX44.Equals(beginString))
                    return ApplVerID.FIX44;
                else if (BeginString.FIX50.Equals(beginString))
                    return ApplVerID.FIX50;
                else if ("FIX.5.0SP1".Equals(beginString))
                    return ApplVerID.FIX50SP1;
                else if ("FIX.5.0SP2".Equals(beginString))
                    return ApplVerID.FIX50SP2;
                else
                    return string.Copy(beginString);
            }
        }

        public class BeginString
        {
            public const string FIXT11 = "FIXT.1.1";
            public const string FIX50  = "FIX.5.0";
            public const string FIX44  = "FIX.4.4";
            public const string FIX43  = "FIX.4.3";
            public const string FIX42  = "FIX.4.2";
            public const string FIX41  = "FIX.4.1";
            public const string FIX40  = "FIX.4.0";
        }

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
            public const string SECURITY_DEFINITION = "d";
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
