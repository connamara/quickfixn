// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class Logon : Message
{
    public const string MsgType = "A";

    public Logon() : base()
    {
        Header.SetField(new MsgType("A"));
    }

    public Logon(
            EncryptMethod aEncryptMethod,
            HeartBtInt aHeartBtInt
        ) : this()
    {
        EncryptMethod = aEncryptMethod;
        HeartBtInt = aHeartBtInt;
    }

    public EncryptMethod EncryptMethod
    {
        get
        {
            EncryptMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncryptMethod val) { EncryptMethod = val; }
    public EncryptMethod Get(EncryptMethod val) { GetField(val); return val; }
    public bool IsSet(EncryptMethod val) { return IsSetEncryptMethod(); }
    public bool IsSetEncryptMethod() { return IsSetField(Tags.EncryptMethod); }

    public HeartBtInt HeartBtInt
    {
        get
        {
            HeartBtInt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HeartBtInt val) { HeartBtInt = val; }
    public HeartBtInt Get(HeartBtInt val) { GetField(val); return val; }
    public bool IsSet(HeartBtInt val) { return IsSetHeartBtInt(); }
    public bool IsSetHeartBtInt() { return IsSetField(Tags.HeartBtInt); }

    public RawDataLength RawDataLength
    {
        get
        {
            RawDataLength val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawDataLength val) { RawDataLength = val; }
    public RawDataLength Get(RawDataLength val) { GetField(val); return val; }
    public bool IsSet(RawDataLength val) { return IsSetRawDataLength(); }
    public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

    public RawData RawData
    {
        get
        {
            RawData val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawData val) { RawData = val; }
    public RawData Get(RawData val) { GetField(val); return val; }
    public bool IsSet(RawData val) { return IsSetRawData(); }
    public bool IsSetRawData() { return IsSetField(Tags.RawData); }

    public ResetSeqNumFlag ResetSeqNumFlag
    {
        get
        {
            ResetSeqNumFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ResetSeqNumFlag val) { ResetSeqNumFlag = val; }
    public ResetSeqNumFlag Get(ResetSeqNumFlag val) { GetField(val); return val; }
    public bool IsSet(ResetSeqNumFlag val) { return IsSetResetSeqNumFlag(); }
    public bool IsSetResetSeqNumFlag() { return IsSetField(Tags.ResetSeqNumFlag); }

    public MaxMessageSize MaxMessageSize
    {
        get
        {
            MaxMessageSize val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MaxMessageSize val) { MaxMessageSize = val; }
    public MaxMessageSize Get(MaxMessageSize val) { GetField(val); return val; }
    public bool IsSet(MaxMessageSize val) { return IsSetMaxMessageSize(); }
    public bool IsSetMaxMessageSize() { return IsSetField(Tags.MaxMessageSize); }

    public NoMsgTypes NoMsgTypes
    {
        get
        {
            NoMsgTypes val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMsgTypes val) { NoMsgTypes = val; }
    public NoMsgTypes Get(NoMsgTypes val) { GetField(val); return val; }
    public bool IsSet(NoMsgTypes val) { return IsSetNoMsgTypes(); }
    public bool IsSetNoMsgTypes() { return IsSetField(Tags.NoMsgTypes); }

    public class NoMsgTypesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RefMsgType, Tags.MsgDirection, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RefMsgType, Tags.MsgDirection, 0};

        public NoMsgTypesGroup()
          : base(Tags.NoMsgTypes, Tags.RefMsgType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMsgTypesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RefMsgType RefMsgType
        {
            get
            {
                RefMsgType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RefMsgType val) { RefMsgType = val; }
        public RefMsgType Get(RefMsgType val) { GetField(val); return val; }
        public bool IsSet(RefMsgType val) { return IsSetRefMsgType(); }
        public bool IsSetRefMsgType() { return IsSetField(Tags.RefMsgType); }

        public MsgDirection MsgDirection
        {
            get
            {
                MsgDirection val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MsgDirection val) { MsgDirection = val; }
        public MsgDirection Get(MsgDirection val) { GetField(val); return val; }
        public bool IsSet(MsgDirection val) { return IsSetMsgDirection(); }
        public bool IsSetMsgDirection() { return IsSetField(Tags.MsgDirection); }
    }
}
