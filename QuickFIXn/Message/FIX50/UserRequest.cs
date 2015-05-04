using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class UserRequest : Message
    {
        public const string MsgType = "BE";

        public UserRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
        public UserRequest(QuickFix.Fields.UserRequestID aUserRequestID,
				QuickFix.Fields.UserRequestType aUserRequestType,
				QuickFix.Fields.Username aUsername)
               : this()
        {
            this.UserRequestID = aUserRequestID;
			this.UserRequestType = aUserRequestType;
			this.Username = aUsername;
        }

        public QuickFix.Fields.UserRequestID UserRequestID
        {
            get
            {
                var val = new QuickFix.Fields.UserRequestID();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UserRequestID val) { this.UserRequestID = val; }

        public QuickFix.Fields.UserRequestID Get(QuickFix.Fields.UserRequestID val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UserRequestID val) { return IsSetUserRequestID(); }

        public bool IsSetUserRequestID() { return IsSetField(Tags.UserRequestID); }

        public QuickFix.Fields.UserRequestType UserRequestType
        {
            get
            {
                var val = new QuickFix.Fields.UserRequestType();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.UserRequestType val) { this.UserRequestType = val; }

        public QuickFix.Fields.UserRequestType Get(QuickFix.Fields.UserRequestType val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.UserRequestType val) { return IsSetUserRequestType(); }

        public bool IsSetUserRequestType() { return IsSetField(Tags.UserRequestType); }

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

        public QuickFix.Fields.NewPassword NewPassword
        {
            get
            {
                var val = new QuickFix.Fields.NewPassword();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.NewPassword val) { this.NewPassword = val; }

        public QuickFix.Fields.NewPassword Get(QuickFix.Fields.NewPassword val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.NewPassword val) { return IsSetNewPassword(); }

        public bool IsSetNewPassword() { return IsSetField(Tags.NewPassword); }

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
