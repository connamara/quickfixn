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
                this.Header.setField(new QuickFix.Fields.MsgType("BE"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UserRequestID val) 
            { 
                this.userRequestID = val;
            }
            
            public QuickFix.Fields.UserRequestID get(QuickFix.Fields.UserRequestID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UserRequestID val) 
            { 
                return isSetUserRequestID();
            }
            
            public bool isSetUserRequestID() 
            { 
                return isSetField(Tags.UserRequestID);
            }
            public QuickFix.Fields.UserRequestType userRequestType
            { 
                get 
                {
                    QuickFix.Fields.UserRequestType val = new QuickFix.Fields.UserRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UserRequestType val) 
            { 
                this.userRequestType = val;
            }
            
            public QuickFix.Fields.UserRequestType get(QuickFix.Fields.UserRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UserRequestType val) 
            { 
                return isSetUserRequestType();
            }
            
            public bool isSetUserRequestType() 
            { 
                return isSetField(Tags.UserRequestType);
            }
            public QuickFix.Fields.Username username
            { 
                get 
                {
                    QuickFix.Fields.Username val = new QuickFix.Fields.Username();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Username val) 
            { 
                this.username = val;
            }
            
            public QuickFix.Fields.Username get(QuickFix.Fields.Username val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Username val) 
            { 
                return isSetUsername();
            }
            
            public bool isSetUsername() 
            { 
                return isSetField(Tags.Username);
            }
            public QuickFix.Fields.Password password
            { 
                get 
                {
                    QuickFix.Fields.Password val = new QuickFix.Fields.Password();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Password val) 
            { 
                this.password = val;
            }
            
            public QuickFix.Fields.Password get(QuickFix.Fields.Password val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Password val) 
            { 
                return isSetPassword();
            }
            
            public bool isSetPassword() 
            { 
                return isSetField(Tags.Password);
            }
            public QuickFix.Fields.NewPassword newPassword
            { 
                get 
                {
                    QuickFix.Fields.NewPassword val = new QuickFix.Fields.NewPassword();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NewPassword val) 
            { 
                this.newPassword = val;
            }
            
            public QuickFix.Fields.NewPassword get(QuickFix.Fields.NewPassword val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NewPassword val) 
            { 
                return isSetNewPassword();
            }
            
            public bool isSetNewPassword() 
            { 
                return isSetField(Tags.NewPassword);
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

        }
    }
}
