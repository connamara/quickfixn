// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class ApplicationMessageRequest : Message
{
    public const string MsgType = "BW";

    public ApplicationMessageRequest() : base()
    {
        Header.SetField(new MsgType("BW"));
    }

    public ApplicationMessageRequest(
            ApplReqID aApplReqID,
            ApplReqType aApplReqType
        ) : this()
    {
        ApplReqID = aApplReqID;
        ApplReqType = aApplReqType;
    }

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
        public static int[] DefaultFieldOrder = [Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, 0};

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
    }
}
