// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class StreamAssignmentReportACK : Message
{
    public const string MsgType = "CE";

    public StreamAssignmentReportACK() : base()
    {
        Header.SetField(new MsgType("CE"));
    }

    public StreamAssignmentReportACK(
            StreamAsgnAckType aStreamAsgnAckType,
            StreamAsgnRptID aStreamAsgnRptID
        ) : this()
    {
        StreamAsgnAckType = aStreamAsgnAckType;
        StreamAsgnRptID = aStreamAsgnRptID;
    }

    public StreamAsgnAckType StreamAsgnAckType
    {
        get
        {
            StreamAsgnAckType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StreamAsgnAckType val) { StreamAsgnAckType = val; }
    public StreamAsgnAckType Get(StreamAsgnAckType val) { GetField(val); return val; }
    public bool IsSet(StreamAsgnAckType val) { return IsSetStreamAsgnAckType(); }
    public bool IsSetStreamAsgnAckType() { return IsSetField(Tags.StreamAsgnAckType); }

    public StreamAsgnRptID StreamAsgnRptID
    {
        get
        {
            StreamAsgnRptID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StreamAsgnRptID val) { StreamAsgnRptID = val; }
    public StreamAsgnRptID Get(StreamAsgnRptID val) { GetField(val); return val; }
    public bool IsSet(StreamAsgnRptID val) { return IsSetStreamAsgnRptID(); }
    public bool IsSetStreamAsgnRptID() { return IsSetField(Tags.StreamAsgnRptID); }

    public StreamAsgnRejReason StreamAsgnRejReason
    {
        get
        {
            StreamAsgnRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(StreamAsgnRejReason val) { StreamAsgnRejReason = val; }
    public StreamAsgnRejReason Get(StreamAsgnRejReason val) { GetField(val); return val; }
    public bool IsSet(StreamAsgnRejReason val) { return IsSetStreamAsgnRejReason(); }
    public bool IsSetStreamAsgnRejReason() { return IsSetField(Tags.StreamAsgnRejReason); }

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
