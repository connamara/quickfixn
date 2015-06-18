using QuickFix.Fields;
namespace QuickFix.FIXT11
{
    public class Logon : Message
    {
        public const string MsgType = "A";

        public Logon():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public Logon(QuickFix.Fields.EncryptMethod aEncryptMethod,
				QuickFix.Fields.HeartBtInt aHeartBtInt,
				QuickFix.Fields.DefaultApplVerID aDefaultApplVerID)
               : this()
        {
            this.EncryptMethod = aEncryptMethod;
			this.HeartBtInt = aHeartBtInt;
			this.DefaultApplVerID = aDefaultApplVerID;
        }

        public QuickFix.Fields.EncryptMethod EncryptMethod
        {
            get
            {
                var val = new QuickFix.Fields.EncryptMethod();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.EncryptMethod val) { this.EncryptMethod = val; }

        public QuickFix.Fields.EncryptMethod Get(QuickFix.Fields.EncryptMethod val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.EncryptMethod val) { return IsSetEncryptMethod(); }

        public bool IsSetEncryptMethod() { return IsSetField(Tags.EncryptMethod); }

        public QuickFix.Fields.HeartBtInt HeartBtInt
        {
            get
            {
                var val = new QuickFix.Fields.HeartBtInt();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.HeartBtInt val) { this.HeartBtInt = val; }

        public QuickFix.Fields.HeartBtInt Get(QuickFix.Fields.HeartBtInt val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.HeartBtInt val) { return IsSetHeartBtInt(); }

        public bool IsSetHeartBtInt() { return IsSetField(Tags.HeartBtInt); }

        public QuickFix.Fields.RawDataLength RawDataLength
        {
            get
            {
                var val = new QuickFix.Fields.RawDataLength();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RawDataLength val) { this.RawDataLength = val; }

        public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RawDataLength val) { return IsSetRawDataLength(); }

        public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

        public QuickFix.Fields.RawData RawData
        {
            get
            {
                var val = new QuickFix.Fields.RawData();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RawData val) { this.RawData = val; }

        public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RawData val) { return IsSetRawData(); }

        public bool IsSetRawData() { return IsSetField(Tags.RawData); }

        public QuickFix.Fields.ResetSeqNumFlag ResetSeqNumFlag
        {
            get
            {
                var val = new QuickFix.Fields.ResetSeqNumFlag();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.ResetSeqNumFlag val) { this.ResetSeqNumFlag = val; }

        public QuickFix.Fields.ResetSeqNumFlag Get(QuickFix.Fields.ResetSeqNumFlag val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.ResetSeqNumFlag val) { return IsSetResetSeqNumFlag(); }

        public bool IsSetResetSeqNumFlag() { return IsSetField(Tags.ResetSeqNumFlag); }

        public QuickFix.Fields.NextExpectedMsgSeqNum NextExpectedMsgSeqNum
        {
            get
            {
                var val = new QuickFix.Fields.NextExpectedMsgSeqNum();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NextExpectedMsgSeqNum val) { this.NextExpectedMsgSeqNum = val; }

        public QuickFix.Fields.NextExpectedMsgSeqNum Get(QuickFix.Fields.NextExpectedMsgSeqNum val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NextExpectedMsgSeqNum val) { return IsSetNextExpectedMsgSeqNum(); }

        public bool IsSetNextExpectedMsgSeqNum() { return IsSetField(Tags.NextExpectedMsgSeqNum); }

        public QuickFix.Fields.MaxMessageSize MaxMessageSize
        {
            get
            {
                var val = new QuickFix.Fields.MaxMessageSize();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MaxMessageSize val) { this.MaxMessageSize = val; }

        public QuickFix.Fields.MaxMessageSize Get(QuickFix.Fields.MaxMessageSize val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MaxMessageSize val) { return IsSetMaxMessageSize(); }

        public bool IsSetMaxMessageSize() { return IsSetField(Tags.MaxMessageSize); }

        public QuickFix.Fields.TestMessageIndicator TestMessageIndicator
        {
            get
            {
                var val = new QuickFix.Fields.TestMessageIndicator();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.TestMessageIndicator val) { this.TestMessageIndicator = val; }

        public QuickFix.Fields.TestMessageIndicator Get(QuickFix.Fields.TestMessageIndicator val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.TestMessageIndicator val) { return IsSetTestMessageIndicator(); }

        public bool IsSetTestMessageIndicator() { return IsSetField(Tags.TestMessageIndicator); }

        public QuickFix.Fields.Username Username
        {
            get
            {
                var val = new QuickFix.Fields.Username();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Username val) { this.Username = val; }

        public QuickFix.Fields.Username Get(QuickFix.Fields.Username val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Username val) { return IsSetUsername(); }

        public bool IsSetUsername() { return IsSetField(Tags.Username); }

        public QuickFix.Fields.Password Password
        {
            get
            {
                var val = new QuickFix.Fields.Password();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Password val) { this.Password = val; }

        public QuickFix.Fields.Password Get(QuickFix.Fields.Password val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Password val) { return IsSetPassword(); }

        public bool IsSetPassword() { return IsSetField(Tags.Password); }

        public QuickFix.Fields.DefaultApplVerID DefaultApplVerID
        {
            get
            {
                var val = new QuickFix.Fields.DefaultApplVerID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.DefaultApplVerID val) { this.DefaultApplVerID = val; }

        public QuickFix.Fields.DefaultApplVerID Get(QuickFix.Fields.DefaultApplVerID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.DefaultApplVerID val) { return IsSetDefaultApplVerID(); }

        public bool IsSetDefaultApplVerID() { return IsSetField(Tags.DefaultApplVerID); }

        public QuickFix.Fields.NoMsgTypes NoMsgTypes
        {
            get
            {
                var val = new QuickFix.Fields.NoMsgTypes();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NoMsgTypes val) { this.NoMsgTypes = val; }

        public QuickFix.Fields.NoMsgTypes Get(QuickFix.Fields.NoMsgTypes val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NoMsgTypes val) { return IsSetNoMsgTypes(); }

        public bool IsSetNoMsgTypes() { return IsSetField(Tags.NoMsgTypes); }


        public class NoMsgTypesGroup : Group
        {
            public static int[] fieldOrder = {Tags.RefMsgType, Tags.MsgDirection, Tags.RefApplVerID, Tags.RefCstmApplVerID, 0};

            public NoMsgTypesGroup() : base(Tags.NoMsgTypes, Tags.RefMsgType, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoMsgTypesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
        public QuickFix.Fields.RefMsgType RefMsgType
        {
            get
            {
                var val = new QuickFix.Fields.RefMsgType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefMsgType val) { this.RefMsgType = val; }

        public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefMsgType val) { return IsSetRefMsgType(); }

        public bool IsSetRefMsgType() { return IsSetField(Tags.RefMsgType); }

        public QuickFix.Fields.MsgDirection MsgDirection
        {
            get
            {
                var val = new QuickFix.Fields.MsgDirection();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.MsgDirection val) { this.MsgDirection = val; }

        public QuickFix.Fields.MsgDirection Get(QuickFix.Fields.MsgDirection val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.MsgDirection val) { return IsSetMsgDirection(); }

        public bool IsSetMsgDirection() { return IsSetField(Tags.MsgDirection); }

        public QuickFix.Fields.RefApplVerID RefApplVerID
        {
            get
            {
                var val = new QuickFix.Fields.RefApplVerID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefApplVerID val) { this.RefApplVerID = val; }

        public QuickFix.Fields.RefApplVerID Get(QuickFix.Fields.RefApplVerID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefApplVerID val) { return IsSetRefApplVerID(); }

        public bool IsSetRefApplVerID() { return IsSetField(Tags.RefApplVerID); }

        public QuickFix.Fields.RefCstmApplVerID RefCstmApplVerID
        {
            get
            {
                var val = new QuickFix.Fields.RefCstmApplVerID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RefCstmApplVerID val) { this.RefCstmApplVerID = val; }

        public QuickFix.Fields.RefCstmApplVerID Get(QuickFix.Fields.RefCstmApplVerID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RefCstmApplVerID val) { return IsSetRefCstmApplVerID(); }

        public bool IsSetRefCstmApplVerID() { return IsSetField(Tags.RefCstmApplVerID); }


        }


    }
}


