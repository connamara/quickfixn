using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// ApplVerID Field
    /// </summary>/
    public sealed class ApplVerID : StringField
    {
        public ApplVerID()
            : base(Tags.ApplVerID) { }
        public ApplVerID(string val)
            : base(Tags.ApplVerID, val) { }

        // Field Enumerations
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
    }

    /// <summary>
    /// MsgType Field
    /// </summary>/
    public sealed class MsgType : StringField
    {
        public MsgType()
            : base(Tags.MsgType) { }
        public MsgType(string val)
            : base(Tags.MsgType, val) { }

        // Field Enumerations
        public const string HEARTBEAT = "0";
        public const string TESTREQUEST = "1";
        public const string RESENDREQUEST = "2";
        public const string REJECT = "3";
        public const string SEQUENCERESET = "4";
        public const string LOGOUT = "5";
        public const string LOGON = "A";
        public const string BUSINESSMESSAGEREJECT = "j";
        public const string TEST_REQUEST = "1";
        public const string RESEND_REQUEST = "2";
        public const string SEQUENCE_RESET = "4";
        public const string BUSINESS_MESSAGE_REJECT = "j";
    }

    /// <summary>
    /// NewSeqNo Field
    /// </summary>/
    public sealed class NewSeqNo : IntField
    {
        public NewSeqNo()
            : base(Tags.NewSeqNo) { }
        public NewSeqNo(int val)
            : base(Tags.NewSeqNo, val) { }

    }

    /// <summary>
    /// OrigSendingTime Field
    /// </summary>/
    public sealed class OrigSendingTime : DateTimeField
    {
        public OrigSendingTime()
            : base(Tags.OrigSendingTime) { }
        public OrigSendingTime(DateTime val)
            : base(Tags.OrigSendingTime, val) { }
        public OrigSendingTime(DateTime val, bool showMilliseconds)
        : base(Tags.OrigSendingTime, val, showMilliseconds) { }

    }
    /// <summary>
    /// GapFillFlag Field
    /// </summary>/
    public sealed class GapFillFlag : BooleanField
    {
        public GapFillFlag()
            : base(Tags.GapFillFlag) { }
        public GapFillFlag(Boolean val)
            : base(Tags.GapFillFlag, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean GAP_FILL_MESSAGE_MSGSEQNUM_FIELD_VALID = true;
        public const Boolean SEQUENCE_RESET_IGNORE_MSGSEQNUM = false;
    }

    /// <summary>
    /// SendingTime Field
    /// </summary>/
    public sealed class SendingTime : DateTimeField
    {
        public SendingTime()
            : base(Tags.SendingTime) { }
        public SendingTime(DateTime val)
            : base(Tags.SendingTime, val) { }
        public SendingTime(DateTime val, bool showMilliseconds)
        : base(Tags.SendingTime, val, showMilliseconds) { }

    }
    /// <summary>
    /// MsgSeqNum Field
    /// </summary>/
    public sealed class MsgSeqNum : IntField
    {
        public MsgSeqNum()
            : base(Tags.MsgSeqNum) { }
        public MsgSeqNum(int val)
            : base(Tags.MsgSeqNum, val) { }

    }
    /// <summary>
    /// RefTagID Field
    /// </summary>/
    public sealed class RefTagID : IntField
    {
        public RefTagID()
            : base(Tags.RefTagID) { }
        public RefTagID(int val)
            : base(Tags.RefTagID, val) { }

    }
    /// <summary>
    /// TestReqID Field
    /// </summary>/
    public sealed class TestReqID : StringField
    {
        public TestReqID()
            : base(Tags.TestReqID) { }
        public TestReqID(string val)
            : base(Tags.TestReqID, val) { }

    }
    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>/
    public sealed class LastMsgSeqNumProcessed : IntField
    {
        public LastMsgSeqNumProcessed()
            : base(Tags.LastMsgSeqNumProcessed) { }
        public LastMsgSeqNumProcessed(int val)
            : base(Tags.LastMsgSeqNumProcessed, val) { }

    }
    /// <summary>
    /// DefaultApplVerID Field
    /// </summary>/
    public sealed class DefaultApplVerID : StringField
    {
        public DefaultApplVerID()
            : base(Tags.DefaultApplVerID) { }
        public DefaultApplVerID(string val)
            : base(Tags.DefaultApplVerID, val) { }

    }

    /// <summary>
    /// HeartBtInt Field
    /// </summary>/
    public sealed class HeartBtInt : IntField
    {
        public HeartBtInt()
            : base(Tags.HeartBtInt) { }
        public HeartBtInt(int val)
            : base(Tags.HeartBtInt, val) { }

    }
    /// <summary>
    /// EncryptMethod Field
    /// </summary>/
    public sealed class EncryptMethod : IntField
    {
        public EncryptMethod()
            : base(Tags.EncryptMethod) { }
        public EncryptMethod(int val)
            : base(Tags.EncryptMethod, val) { }


        // Field Enumerations
        public const int NONE = 0;
        public const int PKCS_1 = 1;
        public const int DES = 2;
        public const int PKCS_3 = 3;
        public const int PGP_4 = 4;
        public const int PGP_5 = 5;
        public const int PEM = 6;
        public const int NONE_OTHER = 0;
        public const int PKCS = 1;
        public const int PKCS_DES = 3;
        public const int PGP_DES = 4;
        public const int PGP_DES_MD5 = 5;
        public const int PEM_DES_MD5 = 6;
        public const int PKCS_PROPRIETARY = 1;
        public const int PKCSDES = 3;
        public const int PGPDES = 4;
        public const int PGPDESMD5 = 5;
        public const int PEMDESMD5 = 6;
    }

    /// <summary>
    /// RefSeqNum Field
    /// </summary>/
    public sealed class RefSeqNum : IntField
    {
        public RefSeqNum()
            : base(Tags.RefSeqNum) { }
        public RefSeqNum(int val)
            : base(Tags.RefSeqNum, val) { }

    }

    /// <summary>
    /// EndSeqNo Field
    /// </summary>/
    public sealed class EndSeqNo : IntField
    {
        public EndSeqNo()
            : base(Tags.EndSeqNo) { }
        public EndSeqNo(int val)
            : base(Tags.EndSeqNo, val) { }

    }
    /// <summary>
    /// BeginSeqNo Field
    /// </summary>/
    public sealed class BeginSeqNo : IntField
    {
        public BeginSeqNo()
            : base(Tags.BeginSeqNo) { }
        public BeginSeqNo(int val)
            : base(Tags.BeginSeqNo, val) { }

    }

    /// <summary>
    /// Text Field
    /// </summary>/
    public sealed class Text : StringField
    {
        public Text()
            : base(Tags.Text) { }
        public Text(string val)
            : base(Tags.Text, val) { }

    }

    /// <summary>
    /// RefMsgType Field
    /// </summary>/
    public sealed class RefMsgType : StringField
    {
        public RefMsgType()
            : base(Tags.RefMsgType) { }
        public RefMsgType(string val)
            : base(Tags.RefMsgType, val) { }

    }


    /// <summary>
    /// PossDupFlag Field
    /// </summary>/
    public sealed class PossDupFlag : BooleanField
    {
        public PossDupFlag()
            : base(Tags.PossDupFlag) { }
        public PossDupFlag(Boolean val)
            : base(Tags.PossDupFlag, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean POSSIBLE_DUPLICATE = true;
        public const Boolean ORIGINAL_TRANSMISSION = false;
    }

    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>/
    public sealed class ResetSeqNumFlag : BooleanField
    {
        public ResetSeqNumFlag()
            : base(Tags.ResetSeqNumFlag) { }
        public ResetSeqNumFlag(Boolean val)
            : base(Tags.ResetSeqNumFlag, val) { }


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean YES_RESET_SEQUENCE_NUMBERS = true;
    }

    /// <summary>
    /// SessionRejectReason Field
    /// </summary>/
    public sealed class SessionRejectReason : IntField
    {
        public SessionRejectReason()
            : base(Tags.SessionRejectReason) { }
        public SessionRejectReason(int val)
            : base(Tags.SessionRejectReason, val) { }


        // Field Enumerations
        public const int INVALID_TAG_NUMBER = 0;
        public const int REQUIRED_TAG_MISSING = 1;
        public const int SENDINGTIME_ACCURACY_PROBLEM = 10;
        public const int INVALID_MSGTYPE = 11;
        public const int XML_VALIDATION_ERROR = 12;
        public const int TAG_APPEARS_MORE_THAN_ONCE = 13;
        public const int TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = 14;
        public const int REPEATING_GROUP_FIELDS_OUT_OF_ORDER = 15;
        public const int INCORRECT_NUMINGROUP_COUNT_FOR_REPEATING_GROUP = 16;
        public const int NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = 17;
        public const int TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = 2;
        public const int UNDEFINED_TAG = 3;
        public const int TAG_SPECIFIED_WITHOUT_A_VALUE = 4;
        public const int VALUE_IS_INCORRECT = 5;
        public const int INCORRECT_DATA_FORMAT_FOR_VALUE = 6;
        public const int DECRYPTION_PROBLEM = 7;
        public const int SIGNATURE_PROBLEM = 8;
        public const int COMPID_PROBLEM = 9;
        public const int OTHER = 99;
        public const int INVALID_UNSUPPORTED_APPLICATION_VERSION = 18;
        public const int E = 11;
    }

    /// <summary>
    /// OnBehalfOfSubID Field
    /// </summary>/
    public sealed class OnBehalfOfSubID : StringField
    {
        public OnBehalfOfSubID()
            : base(Tags.OnBehalfOfSubID) { }
        public OnBehalfOfSubID(string val)
            : base(Tags.OnBehalfOfSubID, val) { }

    }

    /// <summary>
    /// DeliverToSubID Field
    /// </summary>/
    public sealed class DeliverToSubID : StringField
    {
        public DeliverToSubID()
            : base(Tags.DeliverToSubID) { }
        public DeliverToSubID(string val)
            : base(Tags.DeliverToSubID, val) { }

    }

    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>/
    public sealed class OnBehalfOfCompID : StringField
    {
        public OnBehalfOfCompID()
            : base(Tags.OnBehalfOfCompID) { }
        public OnBehalfOfCompID(string val)
            : base(Tags.OnBehalfOfCompID, val) { }

    }

    /// <summary>
    /// DeliverToCompID Field
    /// </summary>/
    public sealed class DeliverToCompID : StringField
    {
        public DeliverToCompID()
            : base(Tags.DeliverToCompID) { }
        public DeliverToCompID(string val)
            : base(Tags.DeliverToCompID, val) { }

    }

    /// <summary>
    /// SenderLocationID Field
    /// </summary>/
    public sealed class SenderLocationID : StringField
    {
        public SenderLocationID()
            : base(Tags.SenderLocationID) { }
        public SenderLocationID(string val)
            : base(Tags.SenderLocationID, val) { }

    }


    /// <summary>
    /// TargetLocationID Field
    /// </summary>/
    public sealed class TargetLocationID : StringField
    {
        public TargetLocationID()
            : base(Tags.TargetLocationID) { }
        public TargetLocationID(string val)
            : base(Tags.TargetLocationID, val) { }

    }


    /// <summary>
    /// OnBehalfOfLocationID Field
    /// </summary>/
    public sealed class OnBehalfOfLocationID : StringField
    {
        public OnBehalfOfLocationID()
            : base(Tags.OnBehalfOfLocationID) { }
        public OnBehalfOfLocationID(string val)
            : base(Tags.OnBehalfOfLocationID, val) { }

    }

    /// <summary>
    /// SenderSubID Field
    /// </summary>/
    public sealed class SenderSubID : StringField
    {
        public SenderSubID()
            : base(Tags.SenderSubID) { }
        public SenderSubID(string val)
            : base(Tags.SenderSubID, val) { }

    }

    /// <summary>
    /// TargetCompID Field
    /// </summary>/
    public sealed class TargetCompID : StringField
    {
        public TargetCompID()
            : base(Tags.TargetCompID) { }
        public TargetCompID(string val)
            : base(Tags.TargetCompID, val) { }

    }


    /// <summary>
    /// TargetSubID Field
    /// </summary>/
    public sealed class TargetSubID : StringField
    {
        public TargetSubID()
            : base(Tags.TargetSubID) { }
        public TargetSubID(string val)
            : base(Tags.TargetSubID, val) { }

    }
    /// <summary>
    /// SenderCompID Field
    /// </summary>/
    public sealed class SenderCompID : StringField
    {
        public SenderCompID()
            : base(Tags.SenderCompID) { }
        public SenderCompID(string val)
            : base(Tags.SenderCompID, val) { }

    }

    /// <summary>
    /// DeliverToLocationID Field
    /// </summary>/
    public sealed class DeliverToLocationID : StringField
    {
        public DeliverToLocationID()
            : base(Tags.DeliverToLocationID) { }
        public DeliverToLocationID(string val)
            : base(Tags.DeliverToLocationID, val) { }

    }
    /// <summary>
    /// BeginString Field
    /// </summary>/
    public sealed class BeginString : StringField
    {
        public BeginString()
            : base(Tags.BeginString) { }
        public BeginString(string val)
            : base(Tags.BeginString, val) { }

    }


    /// <summary>
    /// BodyLength Field
    /// </summary>/
    public sealed class BodyLength : IntField
    {
        public BodyLength()
            : base(Tags.BodyLength) { }
        public BodyLength(int val)
            : base(Tags.BodyLength, val) { }

    }


    /// <summary>
    /// CheckSum Field
    /// </summary>/
    public sealed class CheckSum : StringField
    {
        public CheckSum()
            : base(Tags.CheckSum) { }
        public CheckSum(string val)
            : base(Tags.CheckSum, val) { }

    }

    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>/
    public sealed class BusinessRejectReason : IntField
    {
        public BusinessRejectReason()
            : base(Tags.BusinessRejectReason) { }
        public BusinessRejectReason(int val)
            : base(Tags.BusinessRejectReason, val) { }


        // Field Enumerations
        public const int OTHER = 0;
        public const int UNKNOWN_ID = 1;
        public const int UNKNOWN_SECURITY = 2;
        public const int UNSUPPORTED_MESSAGE_TYPE = 3;
        public const int APPLICATION_NOT_AVAILABLE = 4;
        public const int CONDITIONALLY_REQUIRED_FIELD_MISSING = 5;
        public const int NOT_AUTHORIZED = 6;
        public const int DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME = 7;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int UNKNOWN_MESSAGE_TYPE = 3;
        public const int UNKOWN_ID = 1;
    }
}
