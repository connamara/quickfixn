// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class ApplicationMessageRequestAck : Message
{
    public const string MsgType = "BX";

    public ApplicationMessageRequestAck() : base()
    {
        Header.SetField(new MsgType("BX"));
    }

    public ApplicationMessageRequestAck(
            ApplResponseID aApplResponseID
        ) : this()
    {
        ApplResponseID = aApplResponseID;
    }

    public ApplResponseID ApplResponseID
    {
        get
        {
            ApplResponseID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResponseID val) { ApplResponseID = val; }
    public ApplResponseID Get(ApplResponseID val) { GetField(val); return val; }
    public bool IsSet(ApplResponseID val) { return IsSetApplResponseID(); }
    public bool IsSetApplResponseID() { return IsSetField(Tags.ApplResponseID); }

    public ApplReqID ApplReqID
    {
        get
        {
            ApplReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReqID val) { ApplReqID = val; }
    public ApplReqID Get(ApplReqID val) { GetField(val); return val; }
    public bool IsSet(ApplReqID val) { return IsSetApplReqID(); }
    public bool IsSetApplReqID() { return IsSetField(Tags.ApplReqID); }

    public ApplReqType ApplReqType
    {
        get
        {
            ApplReqType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplReqType val) { ApplReqType = val; }
    public ApplReqType Get(ApplReqType val) { GetField(val); return val; }
    public bool IsSet(ApplReqType val) { return IsSetApplReqType(); }
    public bool IsSetApplReqType() { return IsSetField(Tags.ApplReqType); }

    public ApplResponseType ApplResponseType
    {
        get
        {
            ApplResponseType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResponseType val) { ApplResponseType = val; }
    public ApplResponseType Get(ApplResponseType val) { GetField(val); return val; }
    public bool IsSet(ApplResponseType val) { return IsSetApplResponseType(); }
    public bool IsSetApplResponseType() { return IsSetField(Tags.ApplResponseType); }

    public ApplTotalMessageCount ApplTotalMessageCount
    {
        get
        {
            ApplTotalMessageCount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplTotalMessageCount val) { ApplTotalMessageCount = val; }
    public ApplTotalMessageCount Get(ApplTotalMessageCount val) { GetField(val); return val; }
    public bool IsSet(ApplTotalMessageCount val) { return IsSetApplTotalMessageCount(); }
    public bool IsSetApplTotalMessageCount() { return IsSetField(Tags.ApplTotalMessageCount); }

    public NoApplIDs NoApplIDs
    {
        get
        {
            NoApplIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoApplIDs val) { NoApplIDs = val; }
    public NoApplIDs Get(NoApplIDs val) { GetField(val); return val; }
    public bool IsSet(NoApplIDs val) { return IsSetNoApplIDs(); }
    public bool IsSetNoApplIDs() { return IsSetField(Tags.NoApplIDs); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

    public class NoApplIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, Tags.RefApplLastSeqNum, Tags.ApplResponseError, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, Tags.RefApplLastSeqNum, Tags.ApplResponseError, 0};

        public NoApplIDsGroup()
          : base(Tags.NoApplIDs, Tags.RefApplID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoApplIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RefApplID RefApplID
        {
            get
            {
                RefApplID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplID val) { RefApplID = val; }
        public RefApplID Get(RefApplID val) { GetField(val); return val; }
        public bool IsSet(RefApplID val) { return IsSetRefApplID(); }
        public bool IsSetRefApplID() { return IsSetField(Tags.RefApplID); }

        public ApplBegSeqNum ApplBegSeqNum
        {
            get
            {
                ApplBegSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplBegSeqNum val) { ApplBegSeqNum = val; }
        public ApplBegSeqNum Get(ApplBegSeqNum val) { GetField(val); return val; }
        public bool IsSet(ApplBegSeqNum val) { return IsSetApplBegSeqNum(); }
        public bool IsSetApplBegSeqNum() { return IsSetField(Tags.ApplBegSeqNum); }

        public ApplEndSeqNum ApplEndSeqNum
        {
            get
            {
                ApplEndSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplEndSeqNum val) { ApplEndSeqNum = val; }
        public ApplEndSeqNum Get(ApplEndSeqNum val) { GetField(val); return val; }
        public bool IsSet(ApplEndSeqNum val) { return IsSetApplEndSeqNum(); }
        public bool IsSetApplEndSeqNum() { return IsSetField(Tags.ApplEndSeqNum); }

        public RefApplLastSeqNum RefApplLastSeqNum
        {
            get
            {
                RefApplLastSeqNum val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefApplLastSeqNum val) { RefApplLastSeqNum = val; }
        public RefApplLastSeqNum Get(RefApplLastSeqNum val) { GetField(val); return val; }
        public bool IsSet(RefApplLastSeqNum val) { return IsSetRefApplLastSeqNum(); }
        public bool IsSetRefApplLastSeqNum() { return IsSetField(Tags.RefApplLastSeqNum); }

        public ApplResponseError ApplResponseError
        {
            get
            {
                ApplResponseError val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ApplResponseError val) { ApplResponseError = val; }
        public ApplResponseError Get(ApplResponseError val) { GetField(val); return val; }
        public bool IsSet(ApplResponseError val) { return IsSetApplResponseError(); }
        public bool IsSetApplResponseError() { return IsSetField(Tags.ApplResponseError); }
    }
}
