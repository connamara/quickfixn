// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class UserRequest : Message
{
    public const string MsgType = "BE";

    public UserRequest() : base()
    {
        Header.SetField(new MsgType("BE"));
    }

    public UserRequest(
            UserRequestID aUserRequestID,
            UserRequestType aUserRequestType,
            Username aUsername
        ) : this()
    {
        UserRequestID = aUserRequestID;
        UserRequestType = aUserRequestType;
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

    public UserRequestType UserRequestType
    {
        get
        {
            UserRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UserRequestType val) { UserRequestType = val; }
    public UserRequestType Get(UserRequestType val) { GetField(val); return val; }
    public bool IsSet(UserRequestType val) { return IsSetUserRequestType(); }
    public bool IsSetUserRequestType() { return IsSetField(Tags.UserRequestType); }

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

    public Password Password
    {
        get
        {
            Password val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Password val) { Password = val; }
    public Password Get(Password val) { GetField(val); return val; }
    public bool IsSet(Password val) { return IsSetPassword(); }
    public bool IsSetPassword() { return IsSetField(Tags.Password); }

    public NewPassword NewPassword
    {
        get
        {
            NewPassword val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NewPassword val) { NewPassword = val; }
    public NewPassword Get(NewPassword val) { GetField(val); return val; }
    public bool IsSet(NewPassword val) { return IsSetNewPassword(); }
    public bool IsSetNewPassword() { return IsSetField(Tags.NewPassword); }

    public RawDataLength RawDataLength
    {
        get
        {
            RawDataLength val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawDataLength val) { RawDataLength = val; }
    public RawDataLength Get(RawDataLength val) { GetField(val); return val; }
    public bool IsSet(RawDataLength val) { return IsSetRawDataLength(); }
    public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

    public RawData RawData
    {
        get
        {
            RawData val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RawData val) { RawData = val; }
    public RawData Get(RawData val) { GetField(val); return val; }
    public bool IsSet(RawData val) { return IsSetRawData(); }
    public bool IsSetRawData() { return IsSetField(Tags.RawData); }
}
