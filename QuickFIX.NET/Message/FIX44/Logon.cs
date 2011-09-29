// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class Logon : Message
        {
            public const string MsgType = "A";

            public Logon() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("A"));
            }

            public Logon(
                    QuickFix.Fields.EncryptMethod aEncryptMethod,
                    QuickFix.Fields.HeartBtInt aHeartBtInt
                ) : this()
            {
                this.encryptMethod = aEncryptMethod;
                this.heartBtInt = aHeartBtInt;
            }

            public QuickFix.Fields.EncryptMethod encryptMethod
            { 
                get 
                {
                    QuickFix.Fields.EncryptMethod val = new QuickFix.Fields.EncryptMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptMethod val) 
            { 
                this.encryptMethod = val;
            }
            
            public QuickFix.Fields.EncryptMethod Get(QuickFix.Fields.EncryptMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptMethod val) 
            { 
                return IsSetEncryptMethod();
            }
            
            public bool IsSetEncryptMethod() 
            { 
                return IsSetField(Tags.EncryptMethod);
            }
            public QuickFix.Fields.HeartBtInt heartBtInt
            { 
                get 
                {
                    QuickFix.Fields.HeartBtInt val = new QuickFix.Fields.HeartBtInt();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.HeartBtInt val) 
            { 
                this.heartBtInt = val;
            }
            
            public QuickFix.Fields.HeartBtInt Get(QuickFix.Fields.HeartBtInt val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.HeartBtInt val) 
            { 
                return IsSetHeartBtInt();
            }
            
            public bool IsSetHeartBtInt() 
            { 
                return IsSetField(Tags.HeartBtInt);
            }
            public QuickFix.Fields.RawDataLength rawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawDataLength val) 
            { 
                this.rawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData rawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawData val) 
            { 
                this.rawData = val;
            }
            
            public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(Tags.RawData);
            }
            public QuickFix.Fields.ResetSeqNumFlag resetSeqNumFlag
            { 
                get 
                {
                    QuickFix.Fields.ResetSeqNumFlag val = new QuickFix.Fields.ResetSeqNumFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                this.resetSeqNumFlag = val;
            }
            
            public QuickFix.Fields.ResetSeqNumFlag Get(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                return IsSetResetSeqNumFlag();
            }
            
            public bool IsSetResetSeqNumFlag() 
            { 
                return IsSetField(Tags.ResetSeqNumFlag);
            }
            public QuickFix.Fields.NextExpectedMsgSeqNum nextExpectedMsgSeqNum
            { 
                get 
                {
                    QuickFix.Fields.NextExpectedMsgSeqNum val = new QuickFix.Fields.NextExpectedMsgSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                this.nextExpectedMsgSeqNum = val;
            }
            
            public QuickFix.Fields.NextExpectedMsgSeqNum Get(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NextExpectedMsgSeqNum val) 
            { 
                return IsSetNextExpectedMsgSeqNum();
            }
            
            public bool IsSetNextExpectedMsgSeqNum() 
            { 
                return IsSetField(Tags.NextExpectedMsgSeqNum);
            }
            public QuickFix.Fields.MaxMessageSize maxMessageSize
            { 
                get 
                {
                    QuickFix.Fields.MaxMessageSize val = new QuickFix.Fields.MaxMessageSize();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MaxMessageSize val) 
            { 
                this.maxMessageSize = val;
            }
            
            public QuickFix.Fields.MaxMessageSize Get(QuickFix.Fields.MaxMessageSize val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MaxMessageSize val) 
            { 
                return IsSetMaxMessageSize();
            }
            
            public bool IsSetMaxMessageSize() 
            { 
                return IsSetField(Tags.MaxMessageSize);
            }
            public QuickFix.Fields.NoMsgTypes noMsgTypes
            { 
                get 
                {
                    QuickFix.Fields.NoMsgTypes val = new QuickFix.Fields.NoMsgTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMsgTypes val) 
            { 
                this.noMsgTypes = val;
            }
            
            public QuickFix.Fields.NoMsgTypes Get(QuickFix.Fields.NoMsgTypes val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMsgTypes val) 
            { 
                return IsSetNoMsgTypes();
            }
            
            public bool IsSetNoMsgTypes() 
            { 
                return IsSetField(Tags.NoMsgTypes);
            }
            public QuickFix.Fields.TestMessageIndicator testMessageIndicator
            { 
                get 
                {
                    QuickFix.Fields.TestMessageIndicator val = new QuickFix.Fields.TestMessageIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TestMessageIndicator val) 
            { 
                this.testMessageIndicator = val;
            }
            
            public QuickFix.Fields.TestMessageIndicator Get(QuickFix.Fields.TestMessageIndicator val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TestMessageIndicator val) 
            { 
                return IsSetTestMessageIndicator();
            }
            
            public bool IsSetTestMessageIndicator() 
            { 
                return IsSetField(Tags.TestMessageIndicator);
            }
            public QuickFix.Fields.Username username
            { 
                get 
                {
                    QuickFix.Fields.Username val = new QuickFix.Fields.Username();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Username val) 
            { 
                this.username = val;
            }
            
            public QuickFix.Fields.Username Get(QuickFix.Fields.Username val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Username val) 
            { 
                return IsSetUsername();
            }
            
            public bool IsSetUsername() 
            { 
                return IsSetField(Tags.Username);
            }
            public QuickFix.Fields.Password password
            { 
                get 
                {
                    QuickFix.Fields.Password val = new QuickFix.Fields.Password();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Password val) 
            { 
                this.password = val;
            }
            
            public QuickFix.Fields.Password Get(QuickFix.Fields.Password val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Password val) 
            { 
                return IsSetPassword();
            }
            
            public bool IsSetPassword() 
            { 
                return IsSetField(Tags.Password);
            }
            public class NoMsgTypes : Group
            {
                public NoMsgTypes() 
                  :base( Tags.NoMsgTypes, Tags.RefMsgType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RefMsgType, Tags.MsgDirection, 0};
                            public QuickFix.Fields.RefMsgType refMsgType
                { 
                    get 
                    {
                        QuickFix.Fields.RefMsgType val = new QuickFix.Fields.RefMsgType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefMsgType val) 
                { 
                    this.refMsgType = val;
                }
                
                public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefMsgType val) 
                { 
                    return IsSetRefMsgType();
                }
                
                public bool IsSetRefMsgType() 
                { 
                    return IsSetField(Tags.RefMsgType);
                }
                public QuickFix.Fields.MsgDirection msgDirection
                { 
                    get 
                    {
                        QuickFix.Fields.MsgDirection val = new QuickFix.Fields.MsgDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MsgDirection val) 
                { 
                    this.msgDirection = val;
                }
                
                public QuickFix.Fields.MsgDirection Get(QuickFix.Fields.MsgDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MsgDirection val) 
                { 
                    return IsSetMsgDirection();
                }
                
                public bool IsSetMsgDirection() 
                { 
                    return IsSetField(Tags.MsgDirection);
                }
            
            }
        }
    }
}
