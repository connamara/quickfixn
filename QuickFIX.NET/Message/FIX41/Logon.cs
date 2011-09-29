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

        }
    }
}
