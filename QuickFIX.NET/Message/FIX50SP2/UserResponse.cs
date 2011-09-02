// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class UserResponse : Message
        {
            public const string MsgType = "BF";

            public UserResponse() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BF"));
            }

            public UserResponse(
                    QuickFix.Fields.UserRequestID aUserRequestID,
                    QuickFix.Fields.Username aUsername
                ) : this()
            {
                this.userRequestID = aUserRequestID;
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
            public QuickFix.Fields.UserStatus userStatus
            { 
                get 
                {
                    QuickFix.Fields.UserStatus val = new QuickFix.Fields.UserStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UserStatus val) 
            { 
                this.userStatus = val;
            }
            
            public QuickFix.Fields.UserStatus get(QuickFix.Fields.UserStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UserStatus val) 
            { 
                return isSetUserStatus();
            }
            
            public bool isSetUserStatus() 
            { 
                return isSetField(Tags.UserStatus);
            }
            public QuickFix.Fields.UserStatusText userStatusText
            { 
                get 
                {
                    QuickFix.Fields.UserStatusText val = new QuickFix.Fields.UserStatusText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UserStatusText val) 
            { 
                this.userStatusText = val;
            }
            
            public QuickFix.Fields.UserStatusText get(QuickFix.Fields.UserStatusText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UserStatusText val) 
            { 
                return isSetUserStatusText();
            }
            
            public bool isSetUserStatusText() 
            { 
                return isSetField(Tags.UserStatusText);
            }

        }
    }
}
