using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// FIX Field Tag Values
    /// </summary>/
    public static class Tags
    {
        public const int BeginSeqNo = 7;
        public const int BeginString = 8;
        public const int BodyLength = 9;
        public const int CheckSum = 10;
        public const int EndSeqNo = 16;
        public const int MsgSeqNum = 34;
        public const int MsgType = 35;
        public const int NewSeqNo = 36;
        public const int PossDupFlag = 43;
        public const int RefSeqNum = 45;
        public const int SenderCompID = 49;
        public const int SenderSubID = 50;
        public const int SendingTime = 52;
        public const int TargetCompID = 56;
        public const int TargetSubID = 57;
        public const int Text = 58;
        public const int Signature = 89;
        public const int SecureDataLen = 90;
        public const int SignatureLength = 93;
        public const int PossResend = 97;
        public const int EncryptMethod = 98;
        public const int HeartBtInt = 108;
        public const int TestReqID = 112;
        public const int OnBehalfOfCompID = 115;
        public const int OnBehalfOfSubID = 116;
        public const int OrigSendingTime = 122;
        public const int GapFillFlag = 123;
        public const int DeliverToCompID = 128;
        public const int DeliverToSubID = 129;
        public const int ResetSeqNumFlag = 141;
        public const int SenderLocationID = 142;
        public const int TargetLocationID = 143;
        public const int OnBehalfOfLocationID = 144;
        public const int DeliverToLocationID = 145;
        public const int XmlDataLen = 212;
        public const int XmlData = 213;
        public const int MessageEncoding = 347;
        public const int LastMsgSeqNumProcessed = 369;
        public const int RefTagID = 371;
        public const int RefMsgType = 372;
        public const int SessionRejectReason = 373;
        public const int BusinessRejectReason = 380;
        public const int ApplVerID = 1128;
        public const int DefaultApplVerID = 1137;
    }
}
