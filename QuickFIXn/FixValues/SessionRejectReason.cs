namespace QuickFix.FixValues;

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
