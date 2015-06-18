using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class Logon : Message
    {
        public const string MsgType = "A";

        public Logon():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public Logon(QuickFix.Fields.EncryptMethod aEncryptMethod,
				QuickFix.Fields.HeartBtInt aHeartBtInt)
               : this()
        {
            this.EncryptMethod = aEncryptMethod;
			this.HeartBtInt = aHeartBtInt;
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


    }
}
