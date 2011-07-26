using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Reject : Message
        {
            public Reject() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("3"));
            }

            public Reject(
                    QuickFix.Fields.RefSeqNum aRefSeqNum
                ) : this()
            {
                this.refSeqNum = aRefSeqNum;
            }

            public QuickFix.Fields.RefSeqNum refSeqNum
            { 
                get 
                {
                    QuickFix.Fields.RefSeqNum val = new QuickFix.Fields.RefSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefSeqNum val) 
            { 
                this.refSeqNum = val;
            }
            
            public QuickFix.Fields.RefSeqNum get(QuickFix.Fields.RefSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefSeqNum val) 
            { 
                return isSetRefSeqNum();
            }
            
            public bool isSetRefSeqNum() 
            { 
                return isSetField(Tags.RefSeqNum);
            }
            public QuickFix.Fields.RefTagID refTagID
            { 
                get 
                {
                    QuickFix.Fields.RefTagID val = new QuickFix.Fields.RefTagID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefTagID val) 
            { 
                this.refTagID = val;
            }
            
            public QuickFix.Fields.RefTagID get(QuickFix.Fields.RefTagID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefTagID val) 
            { 
                return isSetRefTagID();
            }
            
            public bool isSetRefTagID() 
            { 
                return isSetField(Tags.RefTagID);
            }
            public QuickFix.Fields.RefMsgType refMsgType
            { 
                get 
                {
                    QuickFix.Fields.RefMsgType val = new QuickFix.Fields.RefMsgType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefMsgType val) 
            { 
                this.refMsgType = val;
            }
            
            public QuickFix.Fields.RefMsgType get(QuickFix.Fields.RefMsgType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefMsgType val) 
            { 
                return isSetRefMsgType();
            }
            
            public bool isSetRefMsgType() 
            { 
                return isSetField(Tags.RefMsgType);
            }
            public QuickFix.Fields.SessionRejectReason sessionRejectReason
            { 
                get 
                {
                    QuickFix.Fields.SessionRejectReason val = new QuickFix.Fields.SessionRejectReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SessionRejectReason val) 
            { 
                this.sessionRejectReason = val;
            }
            
            public QuickFix.Fields.SessionRejectReason get(QuickFix.Fields.SessionRejectReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SessionRejectReason val) 
            { 
                return isSetSessionRejectReason();
            }
            
            public bool isSetSessionRejectReason() 
            { 
                return isSetField(Tags.SessionRejectReason);
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
