// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX43;

public class ListExecute : Message
{
    public const string MsgType = "L";

    public ListExecute() : base()
    {
        Header.SetField(new MsgType("L"));
    }

    public ListExecute(
            ListID aListID,
            TransactTime aTransactTime
        ) : this()
    {
        ListID = aListID;
        TransactTime = aTransactTime;
    }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

    public ClientBidID ClientBidID
    {
        get
        {
            ClientBidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientBidID val) { ClientBidID = val; }
    public ClientBidID Get(ClientBidID val) { GetField(val); return val; }
    public bool IsSet(ClientBidID val) { return IsSetClientBidID(); }
    public bool IsSetClientBidID() { return IsSetField(Tags.ClientBidID); }

    public BidID BidID
    {
        get
        {
            BidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidID val) { BidID = val; }
    public BidID Get(BidID val) { GetField(val); return val; }
    public bool IsSet(BidID val) { return IsSetBidID(); }
    public bool IsSetBidID() { return IsSetField(Tags.BidID); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
}
