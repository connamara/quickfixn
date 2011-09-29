// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class UserRequest : Message
        {
            public const string MsgType = "BE";

            public UserRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BE"));
            }

            public UserRequest(
                    QuickFix.Fields.UserRequestID aUserRequestID,
                    QuickFix.Fields.UserRequestType aUserRequestType,
                    QuickFix.Fields.Username aUsername
                ) : this()
            {
                this.userRequestID = aUserRequestID;
                this.userRequestType = aUserRequestType;
                this.username = aUsername;
            }

            public QuickFix.Fields.UserRequestID userRequestID
            { 
                get 
                {
                    QuickFix.Fields.UserRequestID val = new QuickFix.Fields.UserRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserRequestID val) 
            { 
                this.userRequestID = val;
            }
            
            public QuickFix.Fields.UserRequestID Get(QuickFix.Fields.UserRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserRequestID val) 
            { 
                return IsSetUserRequestID();
            }
            
            public bool IsSetUserRequestID() 
            { 
                return IsSetField(Tags.UserRequestID);
            }
            public QuickFix.Fields.UserRequestType userRequestType
            { 
                get 
                {
                    QuickFix.Fields.UserRequestType val = new QuickFix.Fields.UserRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserRequestType val) 
            { 
                this.userRequestType = val;
            }
            
            public QuickFix.Fields.UserRequestType Get(QuickFix.Fields.UserRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserRequestType val) 
            { 
                return IsSetUserRequestType();
            }
            
            public bool IsSetUserRequestType() 
            { 
                return IsSetField(Tags.UserRequestType);
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
            public QuickFix.Fields.NewPassword newPassword
            { 
                get 
                {
                    QuickFix.Fields.NewPassword val = new QuickFix.Fields.NewPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NewPassword val) 
            { 
                this.newPassword = val;
            }
            
            public QuickFix.Fields.NewPassword Get(QuickFix.Fields.NewPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NewPassword val) 
            { 
                return IsSetNewPassword();
            }
            
            public bool IsSetNewPassword() 
            { 
                return IsSetField(Tags.NewPassword);
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

        }
    }
}
