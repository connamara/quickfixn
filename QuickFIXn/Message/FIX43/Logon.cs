// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
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
                this.EncryptMethod = aEncryptMethod;
                this.HeartBtInt = aHeartBtInt;
            }

            public QuickFix.Fields.EncryptMethod EncryptMethod
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
                this.EncryptMethod = val;
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
            public QuickFix.Fields.HeartBtInt HeartBtInt
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
                this.HeartBtInt = val;
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
            public QuickFix.Fields.RawDataLength RawDataLength
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
                this.RawDataLength = val;
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
            public QuickFix.Fields.RawData RawData
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
                this.RawData = val;
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
            public QuickFix.Fields.ResetSeqNumFlag ResetSeqNumFlag
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
                this.ResetSeqNumFlag = val;
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
            public QuickFix.Fields.MaxMessageSize MaxMessageSize
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
                this.MaxMessageSize = val;
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
            public QuickFix.Fields.NoMsgTypes NoMsgTypes
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
                this.NoMsgTypes = val;
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
            public QuickFix.Fields.TestMessageIndicator TestMessageIndicator
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
                this.TestMessageIndicator = val;
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
            public QuickFix.Fields.Username Username
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
                this.Username = val;
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
            public QuickFix.Fields.Password Password
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
                this.Password = val;
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
            public class NoMsgTypesGroup : Group
            {
                public static int[] fieldOrder = {Tags.RefMsgType, Tags.MsgDirection, 0};
            
                public NoMsgTypesGroup() 
                  :base( Tags.NoMsgTypes, Tags.RefMsgType, fieldOrder)
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
                        QuickFix.Fields.RefMsgType val = new QuickFix.Fields.RefMsgType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefMsgType val) 
                { 
                    this.RefMsgType = val;
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
                public QuickFix.Fields.MsgDirection MsgDirection
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
                    this.MsgDirection = val;
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
