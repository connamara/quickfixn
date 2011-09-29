// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class UserResponse : Message
        {
            public const string MsgType = "BF";

            public UserResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BF"));
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
            public QuickFix.Fields.UserStatus userStatus
            { 
                get 
                {
                    QuickFix.Fields.UserStatus val = new QuickFix.Fields.UserStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserStatus val) 
            { 
                this.userStatus = val;
            }
            
            public QuickFix.Fields.UserStatus Get(QuickFix.Fields.UserStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserStatus val) 
            { 
                return IsSetUserStatus();
            }
            
            public bool IsSetUserStatus() 
            { 
                return IsSetField(Tags.UserStatus);
            }
            public QuickFix.Fields.UserStatusText userStatusText
            { 
                get 
                {
                    QuickFix.Fields.UserStatusText val = new QuickFix.Fields.UserStatusText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.UserStatusText val) 
            { 
                this.userStatusText = val;
            }
            
            public QuickFix.Fields.UserStatusText Get(QuickFix.Fields.UserStatusText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.UserStatusText val) 
            { 
                return IsSetUserStatusText();
            }
            
            public bool IsSetUserStatusText() 
            { 
                return IsSetField(Tags.UserStatusText);
            }

        }
    }
}
