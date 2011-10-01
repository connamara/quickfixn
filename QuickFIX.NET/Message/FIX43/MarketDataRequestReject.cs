// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class MarketDataRequestReject : Message
        {
            public const string MsgType = "Y";

            public MarketDataRequestReject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("Y"));
            }

            public MarketDataRequestReject(
                    QuickFix.Fields.MDReqID aMDReqID
                ) : this()
            {
                this.MDReqID = aMDReqID;
            }

            public QuickFix.Fields.MDReqID MDReqID
            { 
                get 
                {
                    QuickFix.Fields.MDReqID val = new QuickFix.Fields.MDReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MDReqID val) 
            { 
                this.MDReqID = val;
            }
            
            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MDReqID val) 
            { 
                return IsSetMDReqID();
            }
            
            public bool IsSetMDReqID() 
            { 
                return IsSetField(Tags.MDReqID);
            }
            public QuickFix.Fields.MDReqRejReason MDReqRejReason
            { 
                get 
                {
                    QuickFix.Fields.MDReqRejReason val = new QuickFix.Fields.MDReqRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MDReqRejReason val) 
            { 
                this.MDReqRejReason = val;
            }
            
            public QuickFix.Fields.MDReqRejReason Get(QuickFix.Fields.MDReqRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MDReqRejReason val) 
            { 
                return IsSetMDReqRejReason();
            }
            
            public bool IsSetMDReqRejReason() 
            { 
                return IsSetField(Tags.MDReqRejReason);
            }
            public QuickFix.Fields.Text Text
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
                this.Text = val;
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
            public QuickFix.Fields.EncodedTextLen EncodedTextLen
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
                this.EncodedTextLen = val;
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
            public QuickFix.Fields.EncodedText EncodedText
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
                this.EncodedText = val;
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
