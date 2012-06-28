// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
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
                this.UserRequestID = aUserRequestID;
                this.UserRequestType = aUserRequestType;
                this.Username = aUsername;
            }

            public QuickFix.Fields.UserRequestID UserRequestID
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
                this.UserRequestID = val;
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
            public QuickFix.Fields.UserRequestType UserRequestType
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
                this.UserRequestType = val;
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
            public QuickFix.Fields.NewPassword NewPassword
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
                this.NewPassword = val;
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
            public QuickFix.Fields.EncryptedPasswordMethod EncryptedPasswordMethod
            { 
                get 
                {
                    QuickFix.Fields.EncryptedPasswordMethod val = new QuickFix.Fields.EncryptedPasswordMethod();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedPasswordMethod val) 
            { 
                this.EncryptedPasswordMethod = val;
            }
            
            public QuickFix.Fields.EncryptedPasswordMethod Get(QuickFix.Fields.EncryptedPasswordMethod val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedPasswordMethod val) 
            { 
                return IsSetEncryptedPasswordMethod();
            }
            
            public bool IsSetEncryptedPasswordMethod() 
            { 
                return IsSetField(Tags.EncryptedPasswordMethod);
            }
            public QuickFix.Fields.EncryptedPasswordLen EncryptedPasswordLen
            { 
                get 
                {
                    QuickFix.Fields.EncryptedPasswordLen val = new QuickFix.Fields.EncryptedPasswordLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedPasswordLen val) 
            { 
                this.EncryptedPasswordLen = val;
            }
            
            public QuickFix.Fields.EncryptedPasswordLen Get(QuickFix.Fields.EncryptedPasswordLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedPasswordLen val) 
            { 
                return IsSetEncryptedPasswordLen();
            }
            
            public bool IsSetEncryptedPasswordLen() 
            { 
                return IsSetField(Tags.EncryptedPasswordLen);
            }
            public QuickFix.Fields.EncryptedPassword EncryptedPassword
            { 
                get 
                {
                    QuickFix.Fields.EncryptedPassword val = new QuickFix.Fields.EncryptedPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedPassword val) 
            { 
                this.EncryptedPassword = val;
            }
            
            public QuickFix.Fields.EncryptedPassword Get(QuickFix.Fields.EncryptedPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedPassword val) 
            { 
                return IsSetEncryptedPassword();
            }
            
            public bool IsSetEncryptedPassword() 
            { 
                return IsSetField(Tags.EncryptedPassword);
            }
            public QuickFix.Fields.EncryptedNewPasswordLen EncryptedNewPasswordLen
            { 
                get 
                {
                    QuickFix.Fields.EncryptedNewPasswordLen val = new QuickFix.Fields.EncryptedNewPasswordLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedNewPasswordLen val) 
            { 
                this.EncryptedNewPasswordLen = val;
            }
            
            public QuickFix.Fields.EncryptedNewPasswordLen Get(QuickFix.Fields.EncryptedNewPasswordLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedNewPasswordLen val) 
            { 
                return IsSetEncryptedNewPasswordLen();
            }
            
            public bool IsSetEncryptedNewPasswordLen() 
            { 
                return IsSetField(Tags.EncryptedNewPasswordLen);
            }
            public QuickFix.Fields.EncryptedNewPassword EncryptedNewPassword
            { 
                get 
                {
                    QuickFix.Fields.EncryptedNewPassword val = new QuickFix.Fields.EncryptedNewPassword();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncryptedNewPassword val) 
            { 
                this.EncryptedNewPassword = val;
            }
            
            public QuickFix.Fields.EncryptedNewPassword Get(QuickFix.Fields.EncryptedNewPassword val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncryptedNewPassword val) 
            { 
                return IsSetEncryptedNewPassword();
            }
            
            public bool IsSetEncryptedNewPassword() 
            { 
                return IsSetField(Tags.EncryptedNewPassword);
            }

        }
    }
}
