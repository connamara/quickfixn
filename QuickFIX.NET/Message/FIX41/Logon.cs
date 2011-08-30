// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class Logon : Message
        {
            public const string MsgType = "A";

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

        }
    }
}
