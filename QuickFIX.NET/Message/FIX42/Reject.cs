// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Reject : Message
        {
            public const string MsgType = "3";

            public Reject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("3"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefSeqNum val) 
            { 
                this.refSeqNum = val;
            }
            
            public QuickFix.Fields.RefSeqNum Get(QuickFix.Fields.RefSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefSeqNum val) 
            { 
                return IsSetRefSeqNum();
            }
            
            public bool IsSetRefSeqNum() 
            { 
                return IsSetField(Tags.RefSeqNum);
            }
            public QuickFix.Fields.RefTagID refTagID
            { 
                get 
                {
                    QuickFix.Fields.RefTagID val = new QuickFix.Fields.RefTagID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefTagID val) 
            { 
                this.refTagID = val;
            }
            
            public QuickFix.Fields.RefTagID Get(QuickFix.Fields.RefTagID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefTagID val) 
            { 
                return IsSetRefTagID();
            }
            
            public bool IsSetRefTagID() 
            { 
                return IsSetField(Tags.RefTagID);
            }
            public QuickFix.Fields.RefMsgType refMsgType
            { 
                get 
                {
                    QuickFix.Fields.RefMsgType val = new QuickFix.Fields.RefMsgType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefMsgType val) 
            { 
                this.refMsgType = val;
            }
            
            public QuickFix.Fields.RefMsgType Get(QuickFix.Fields.RefMsgType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefMsgType val) 
            { 
                return IsSetRefMsgType();
            }
            
            public bool IsSetRefMsgType() 
            { 
                return IsSetField(Tags.RefMsgType);
            }
            public QuickFix.Fields.SessionRejectReason sessionRejectReason
            { 
                get 
                {
                    QuickFix.Fields.SessionRejectReason val = new QuickFix.Fields.SessionRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SessionRejectReason val) 
            { 
                this.sessionRejectReason = val;
            }
            
            public QuickFix.Fields.SessionRejectReason Get(QuickFix.Fields.SessionRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SessionRejectReason val) 
            { 
                return IsSetSessionRejectReason();
            }
            
            public bool IsSetSessionRejectReason() 
            { 
                return IsSetField(Tags.SessionRejectReason);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Text val) 
            { 
                return IsSetText();
            }
            
            public bool IsSetText() 
            { 
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return IsSetEncodedTextLen();
            }
            
            public bool IsSetEncodedTextLen() 
            { 
                return IsSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedText val) 
            { 
                return IsSetEncodedText();
            }
            
            public bool IsSetEncodedText() 
            { 
                return IsSetField(Tags.EncodedText);
            }

        }
    }
}
