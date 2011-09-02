// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class StreamAssignmentReportACK : Message
        {
            public const string MsgType = "CE";

            public StreamAssignmentReportACK() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("CE"));
            }

            public StreamAssignmentReportACK(
                    QuickFix.Fields.StreamAsgnAckType aStreamAsgnAckType,
                    QuickFix.Fields.StreamAsgnRptID aStreamAsgnRptID
                ) : this()
            {
                this.streamAsgnAckType = aStreamAsgnAckType;
                this.streamAsgnRptID = aStreamAsgnRptID;
            }

            public QuickFix.Fields.StreamAsgnAckType streamAsgnAckType
            { 
                get 
                {
                    QuickFix.Fields.StreamAsgnAckType val = new QuickFix.Fields.StreamAsgnAckType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StreamAsgnAckType val) 
            { 
                this.streamAsgnAckType = val;
            }
            
            public QuickFix.Fields.StreamAsgnAckType get(QuickFix.Fields.StreamAsgnAckType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StreamAsgnAckType val) 
            { 
                return isSetStreamAsgnAckType();
            }
            
            public bool isSetStreamAsgnAckType() 
            { 
                return isSetField(Tags.StreamAsgnAckType);
            }
            public QuickFix.Fields.StreamAsgnRptID streamAsgnRptID
            { 
                get 
                {
                    QuickFix.Fields.StreamAsgnRptID val = new QuickFix.Fields.StreamAsgnRptID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StreamAsgnRptID val) 
            { 
                this.streamAsgnRptID = val;
            }
            
            public QuickFix.Fields.StreamAsgnRptID get(QuickFix.Fields.StreamAsgnRptID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StreamAsgnRptID val) 
            { 
                return isSetStreamAsgnRptID();
            }
            
            public bool isSetStreamAsgnRptID() 
            { 
                return isSetField(Tags.StreamAsgnRptID);
            }
            public QuickFix.Fields.StreamAsgnRejReason streamAsgnRejReason
            { 
                get 
                {
                    QuickFix.Fields.StreamAsgnRejReason val = new QuickFix.Fields.StreamAsgnRejReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StreamAsgnRejReason val) 
            { 
                this.streamAsgnRejReason = val;
            }
            
            public QuickFix.Fields.StreamAsgnRejReason get(QuickFix.Fields.StreamAsgnRejReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StreamAsgnRejReason val) 
            { 
                return isSetStreamAsgnRejReason();
            }
            
            public bool isSetStreamAsgnRejReason() 
            { 
                return isSetField(Tags.StreamAsgnRejReason);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Text val) 
            { 
                return isSetText();
            }
            
            public bool isSetText() 
            { 
                return isSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return isSetEncodedTextLen();
            }
            
            public bool isSetEncodedTextLen() 
            { 
                return isSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedText val) 
            { 
                return isSetEncodedText();
            }
            
            public bool isSetEncodedText() 
            { 
                return isSetField(Tags.EncodedText);
            }

        }
    }
}
