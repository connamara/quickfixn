// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class UserResponse : Message
{
    public const string MsgType = "BF";

    public UserResponse() : base()
    {
        Header.SetField(new MsgType("BF"));
    }

    public UserResponse(
            UserRequestID aUserRequestID,
            Username aUsername
        ) : this()
    {
        UserRequestID = aUserRequestID;
        Username = aUsername;
    }

    public UserRequestID UserRequestID
    {
        get
        {
            UserRequestID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UserRequestID val) { UserRequestID = val; }
    public UserRequestID Get(UserRequestID val) { GetField(val); return val; }
    public bool IsSet(UserRequestID val) { return IsSetUserRequestID(); }
    public bool IsSetUserRequestID() { return IsSetField(Tags.UserRequestID); }

    public Username Username
    {
        get
        {
            Username val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Username val) { Username = val; }
    public Username Get(Username val) { GetField(val); return val; }
    public bool IsSet(Username val) { return IsSetUsername(); }
    public bool IsSetUsername() { return IsSetField(Tags.Username); }

    public UserStatus UserStatus
    {
        get
        {
            UserStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UserStatus val) { UserStatus = val; }
    public UserStatus Get(UserStatus val) { GetField(val); return val; }
    public bool IsSet(UserStatus val) { return IsSetUserStatus(); }
    public bool IsSetUserStatus() { return IsSetField(Tags.UserStatus); }

    public UserStatusText UserStatusText
    {
        get
        {
            UserStatusText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UserStatusText val) { UserStatusText = val; }
    public UserStatusText Get(UserStatusText val) { GetField(val); return val; }
    public bool IsSet(UserStatusText val) { return IsSetUserStatusText(); }
    public bool IsSetUserStatusText() { return IsSetField(Tags.UserStatusText); }
}
