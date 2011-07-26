using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Logon : Message
        {
            public Logon() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("A"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncryptMethod val) 
            { 
                this.encryptMethod = val;
            }
            
            public QuickFix.Fields.EncryptMethod get(QuickFix.Fields.EncryptMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncryptMethod val) 
            { 
                return isSetEncryptMethod();
            }
            
            public bool isSetEncryptMethod() 
            { 
                return isSetField(Tags.EncryptMethod);
            }
            public QuickFix.Fields.HeartBtInt heartBtInt
            { 
                get 
                {
                    QuickFix.Fields.HeartBtInt val = new QuickFix.Fields.HeartBtInt();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.HeartBtInt val) 
            { 
                this.heartBtInt = val;
            }
            
            public QuickFix.Fields.HeartBtInt get(QuickFix.Fields.HeartBtInt val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.HeartBtInt val) 
            { 
                return isSetHeartBtInt();
            }
            
            public bool isSetHeartBtInt() 
            { 
                return isSetField(Tags.HeartBtInt);
            }
            public QuickFix.Fields.RawDataLength rawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawDataLength val) 
            { 
                this.rawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength get(QuickFix.Fields.RawDataLength val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawDataLength val) 
            { 
                return isSetRawDataLength();
            }
            
            public bool isSetRawDataLength() 
            { 
                return isSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData rawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawData val) 
            { 
                this.rawData = val;
            }
            
            public QuickFix.Fields.RawData get(QuickFix.Fields.RawData val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawData val) 
            { 
                return isSetRawData();
            }
            
            public bool isSetRawData() 
            { 
                return isSetField(Tags.RawData);
            }
            public QuickFix.Fields.ResetSeqNumFlag resetSeqNumFlag
            { 
                get 
                {
                    QuickFix.Fields.ResetSeqNumFlag val = new QuickFix.Fields.ResetSeqNumFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                this.resetSeqNumFlag = val;
            }
            
            public QuickFix.Fields.ResetSeqNumFlag get(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ResetSeqNumFlag val) 
            { 
                return isSetResetSeqNumFlag();
            }
            
            public bool isSetResetSeqNumFlag() 
            { 
                return isSetField(Tags.ResetSeqNumFlag);
            }
            public QuickFix.Fields.MaxMessageSize maxMessageSize
            { 
                get 
                {
                    QuickFix.Fields.MaxMessageSize val = new QuickFix.Fields.MaxMessageSize();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MaxMessageSize val) 
            { 
                this.maxMessageSize = val;
            }
            
            public QuickFix.Fields.MaxMessageSize get(QuickFix.Fields.MaxMessageSize val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MaxMessageSize val) 
            { 
                return isSetMaxMessageSize();
            }
            
            public bool isSetMaxMessageSize() 
            { 
                return isSetField(Tags.MaxMessageSize);
            }
            public QuickFix.Fields.NoMsgTypes noMsgTypes
            { 
                get 
                {
                    QuickFix.Fields.NoMsgTypes val = new QuickFix.Fields.NoMsgTypes();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoMsgTypes val) 
            { 
                this.noMsgTypes = val;
            }
            
            public QuickFix.Fields.NoMsgTypes get(QuickFix.Fields.NoMsgTypes val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoMsgTypes val) 
            { 
                return isSetNoMsgTypes();
            }
            
            public bool isSetNoMsgTypes() 
            { 
                return isSetField(Tags.NoMsgTypes);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefMsgType val) 
                { 
                    this.refMsgType = val;
                }
                
                public QuickFix.Fields.RefMsgType get(QuickFix.Fields.RefMsgType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefMsgType val) 
                { 
                    return isSetRefMsgType();
                }
                
                public bool isSetRefMsgType() 
                { 
                    return isSetField(Tags.RefMsgType);
                }
                public QuickFix.Fields.MsgDirection msgDirection
                { 
                    get 
                    {
                        QuickFix.Fields.MsgDirection val = new QuickFix.Fields.MsgDirection();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MsgDirection val) 
                { 
                    this.msgDirection = val;
                }
                
                public QuickFix.Fields.MsgDirection get(QuickFix.Fields.MsgDirection val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MsgDirection val) 
                { 
                    return isSetMsgDirection();
                }
                
                public bool isSetMsgDirection() 
                { 
                    return isSetField(Tags.MsgDirection);
                }
            
            }
        }
    }
}
