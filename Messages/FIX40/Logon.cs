// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class Logon : Message
{
    public const string MsgType = "A";

    public Logon() : base()
    {
        Header.SetField(new MsgType("A"));
    }

    public Logon(
            EncryptMethod aEncryptMethod,
            HeartBtInt aHeartBtInt
        ) : this()
    {
        EncryptMethod = aEncryptMethod;
        HeartBtInt = aHeartBtInt;
    }

    public EncryptMethod EncryptMethod
    {
        get
        {
            EncryptMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncryptMethod val) { EncryptMethod = val; }
    public EncryptMethod Get(EncryptMethod val) { GetField(val); return val; }
    public bool IsSet(EncryptMethod val) { return IsSetEncryptMethod(); }
    public bool IsSetEncryptMethod() { return IsSetField(Tags.EncryptMethod); }

    public HeartBtInt HeartBtInt
    {
        get
        {
            HeartBtInt val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(HeartBtInt val) { HeartBtInt = val; }
    public HeartBtInt Get(HeartBtInt val) { GetField(val); return val; }
    public bool IsSet(HeartBtInt val) { return IsSetHeartBtInt(); }
    public bool IsSetHeartBtInt() { return IsSetField(Tags.HeartBtInt); }

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
