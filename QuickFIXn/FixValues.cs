using System.Collections.Generic;

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
            public const string FIX50SP2 = "FIX.5.0SP2";
            public const string FIX50SP1 = "FIX.5.0SP1";
            public const string FIX50 = "FIX.5.0";
            public const string FIX44 = "FIX.4.4";
            public const string FIX43  = "FIX.4.3";
            public const string FIX42  = "FIX.4.2";
            public const string FIX41  = "FIX.4.1";
            public const string FIX40  = "FIX.4.0";
        }

        public class SessionRejectReason : FixValue<int>
        {
            public static SessionRejectReason INVALID_TAG_NUMBER = new SessionRejectReason(0, "Invalid tag number");
            public static SessionRejectReason REQUIRED_TAG_MISSING = new SessionRejectReason(1, "Required tag missing");
            public static SessionRejectReason TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = new SessionRejectReason(2, "Tag not defined for this message type");
            public static SessionRejectReason UNDEFINED_TAG = new SessionRejectReason(3, "Undefined Tag");
            public static SessionRejectReason TAG_SPECIFIED_WITHOUT_A_VALUE = new SessionRejectReason(4, "Tag specified without a value");
            public static SessionRejectReason VALUE_IS_INCORRECT = new SessionRejectReason(5, "Value is incorrect (out of range) for this tag");
            public static SessionRejectReason INCORRECT_DATA_FORMAT_FOR_VALUE = new SessionRejectReason(6, "Incorrect data format for value");
            public static SessionRejectReason DECRYPTION_PROBLEM = new SessionRejectReason(7, "Decryption problem");
            public static SessionRejectReason SIGNATURE_PROBLEM = new SessionRejectReason(8, "Signature proble");
            public static SessionRejectReason COMPID_PROBLEM = new SessionRejectReason(9, "CompID problem");
            public static SessionRejectReason SENDING_TIME_ACCURACY_PROBLEM = new SessionRejectReason(10, "SendingTime accuracy problem");
            public static SessionRejectReason INVALID_MSGTYPE = new SessionRejectReason(11, "Invalid MsgType");
            public static SessionRejectReason XML_VALIDATION_ERROR = new SessionRejectReason(12, "XML validation error");
            public static SessionRejectReason TAG_APPEARS_MORE_THAN_ONCE = new SessionRejectReason(13, "Tag appears more than once");
            public static SessionRejectReason TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = new SessionRejectReason(14, "Tag specified out of required order");
            public static SessionRejectReason REPEATING_GROUP_FIELDS_OUT_OF_ORDER = new SessionRejectReason(15, "Repeating group fields out of order");
            public static SessionRejectReason INCORRECT_NUM_IN_GROUP_COUNT_FOR_REPEATING_GROUP = new SessionRejectReason(16, "Incorrect NumInGroup count for repeating group");
            public static SessionRejectReason NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = new SessionRejectReason(17, "Non-data value includes field delimiter");
            public static SessionRejectReason OTHER = new SessionRejectReason(99, "Other");

            public SessionRejectReason(int value, string description)
                : base(value, description)
            { }
        }

        public class BusinessRejectReason
        {
            public static readonly Dictionary<int, string> RejText = new Dictionary<int, string>()
            {
                { Fields.BusinessRejectReason.OTHER, "Other" },
                { Fields.BusinessRejectReason.UNKNOWN_ID, "Unknown ID" },
                { Fields.BusinessRejectReason.UNKNOWN_SECURITY, "Unknown Security" },
                { Fields.BusinessRejectReason.UNKNOWN_MESSAGE_TYPE, "Unsupported Message Type" },
                { Fields.BusinessRejectReason.APPLICATION_NOT_AVAILABLE, "Application Not Available" },
                { Fields.BusinessRejectReason.CONDITIONALLY_REQUIRED_FIELD_MISSING, "Conditionally Required Field Missing" },
                { Fields.BusinessRejectReason.NOT_AUTHORIZED, "Not authorized" },
                { Fields.BusinessRejectReason.DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME, "DeliverTo Firm Not Available At This Time" }
            };

        }
    }
}
