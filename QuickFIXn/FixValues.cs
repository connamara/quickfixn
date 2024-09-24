using System.Collections.Generic;

namespace QuickFix
{
    public class FixValue<T> where T : notnull
    {
        private T _value;

        public T Value => _value;
        public string Description { get; }

        public FixValue(T value, string description)
        {
            _value = value;
            Description = description;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || (this.GetType() != obj.GetType()))
                return false;
            FixValue<T> rhs = (FixValue<T>)obj;
            return this.Value.Equals(rhs.Value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }

    namespace FixValues
    {
        public static class ApplVerID
        {
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
                return beginString switch
                {
                    BeginString.FIX40 => FIX40,
                    BeginString.FIX41 => FIX41,
                    BeginString.FIX42 => FIX42,
                    BeginString.FIX43 => FIX43,
                    BeginString.FIX44 => FIX44,
                    BeginString.FIX50 => FIX50,
                    BeginString.FIX50SP1 => FIX50SP1,
                    BeginString.FIX50SP2 => FIX50SP2,
                    _ => beginString
                };
            }

            public static string ToBeginString(string applVerId) {
                return applVerId switch
                {
                    FIX40 => BeginString.FIX40,
                    FIX41 => BeginString.FIX41,
                    FIX42 => BeginString.FIX42,
                    FIX43 => BeginString.FIX43,
                    FIX44 => BeginString.FIX44,
                    FIX50 => BeginString.FIX50,
                    FIX50SP1 => BeginString.FIX50SP1,
                    FIX50SP2 => BeginString.FIX50SP2,
                    _ => throw new System.ArgumentException(
                        $"ApplVerId parameter '{applVerId}' does not map to a known BeginString")
                };
            }
        }

        public static class BeginString
        {
            // The FIX5+ beginstrings aren't legitimate, but we use them internally.

            public const string FIXT11 = "FIXT.1.1";
            public const string FIX50SP2 = "FIX.5.0SP2";
            public const string FIX50SP1 = "FIX.5.0SP1";
            public const string FIX50  = "FIX.5.0";
            public const string FIX44  = "FIX.4.4";
            public const string FIX43  = "FIX.4.3";
            public const string FIX42  = "FIX.4.2";
            public const string FIX41  = "FIX.4.1";
            public const string FIX40  = "FIX.4.0";
        }

        public class SessionRejectReason : FixValue<int>
        {
            public static SessionRejectReason INVALID_TAG_NUMBER = new(0, "Invalid tag number");
            public static SessionRejectReason REQUIRED_TAG_MISSING = new(1, "Required tag missing");
            public static SessionRejectReason TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = new(2, "Tag not defined for this message type");
            public static SessionRejectReason UNDEFINED_TAG = new(3, "Undefined Tag");
            public static SessionRejectReason TAG_SPECIFIED_WITHOUT_A_VALUE = new(4, "Tag specified without a value");
            public static SessionRejectReason VALUE_IS_INCORRECT = new(5, "Value is incorrect (out of range) for this tag");
            public static SessionRejectReason INCORRECT_DATA_FORMAT_FOR_VALUE = new(6, "Incorrect data format for value");
            public static SessionRejectReason DECRYPTION_PROBLEM = new(7, "Decryption problem");
            public static SessionRejectReason SIGNATURE_PROBLEM = new(8, "Signature problem");
            public static SessionRejectReason COMPID_PROBLEM = new(9, "CompID problem");
            public static SessionRejectReason SENDING_TIME_ACCURACY_PROBLEM = new(10, "SendingTime accuracy problem");
            public static SessionRejectReason INVALID_MSGTYPE = new(11, "Invalid MsgType");
            public static SessionRejectReason XML_VALIDATION_ERROR = new(12, "XML validation error");
            public static SessionRejectReason TAG_APPEARS_MORE_THAN_ONCE = new(13, "Tag appears more than once");
            public static SessionRejectReason TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = new(14, "Tag specified out of required order");
            public static SessionRejectReason REPEATING_GROUP_FIELDS_OUT_OF_ORDER = new(15, "Repeating group fields out of order");
            public static SessionRejectReason INCORRECT_NUM_IN_GROUP_COUNT_FOR_REPEATING_GROUP = new(16, "Incorrect NumInGroup count for repeating group");
            public static SessionRejectReason NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = new(17, "Non-data value includes field delimiter");
            public static SessionRejectReason OTHER = new(99, "Other");

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
