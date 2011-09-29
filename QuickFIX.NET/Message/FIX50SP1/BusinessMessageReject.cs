// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class BusinessMessageReject : Message
        {
            public const string MsgType = "j";

            public BusinessMessageReject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("j"));
            }

            public BusinessMessageReject(
                    QuickFix.Fields.RefMsgType aRefMsgType,
                    QuickFix.Fields.BusinessRejectReason aBusinessRejectReason
                ) : this()
            {
                this.RefMsgType = aRefMsgType;
                this.BusinessRejectReason = aBusinessRejectReason;
            }

            public QuickFix.Fields.RefSeqNum RefSeqNum
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
                this.RefSeqNum = val;
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
            public QuickFix.Fields.RefMsgType RefMsgType
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
                this.RefMsgType = val;
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
            public QuickFix.Fields.BusinessRejectRefID BusinessRejectRefID
            { 
                get 
                {
                    QuickFix.Fields.BusinessRejectRefID val = new QuickFix.Fields.BusinessRejectRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BusinessRejectRefID val) 
            { 
                this.BusinessRejectRefID = val;
            }
            
            public QuickFix.Fields.BusinessRejectRefID Get(QuickFix.Fields.BusinessRejectRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BusinessRejectRefID val) 
            { 
                return IsSetBusinessRejectRefID();
            }
            
            public bool IsSetBusinessRejectRefID() 
            { 
                return IsSetField(Tags.BusinessRejectRefID);
            }
            public QuickFix.Fields.BusinessRejectReason BusinessRejectReason
            { 
                get 
                {
                    QuickFix.Fields.BusinessRejectReason val = new QuickFix.Fields.BusinessRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BusinessRejectReason val) 
            { 
                this.BusinessRejectReason = val;
            }
            
            public QuickFix.Fields.BusinessRejectReason Get(QuickFix.Fields.BusinessRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BusinessRejectReason val) 
            { 
                return IsSetBusinessRejectReason();
            }
            
            public bool IsSetBusinessRejectReason() 
            { 
                return IsSetField(Tags.BusinessRejectReason);
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
            public QuickFix.Fields.RefApplVerID RefApplVerID
            { 
                get 
                {
                    QuickFix.Fields.RefApplVerID val = new QuickFix.Fields.RefApplVerID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefApplVerID val) 
            { 
                this.RefApplVerID = val;
            }
            
            public QuickFix.Fields.RefApplVerID Get(QuickFix.Fields.RefApplVerID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefApplVerID val) 
            { 
                return IsSetRefApplVerID();
            }
            
            public bool IsSetRefApplVerID() 
            { 
                return IsSetField(Tags.RefApplVerID);
            }
            public QuickFix.Fields.RefApplExtID RefApplExtID
            { 
                get 
                {
                    QuickFix.Fields.RefApplExtID val = new QuickFix.Fields.RefApplExtID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefApplExtID val) 
            { 
                this.RefApplExtID = val;
            }
            
            public QuickFix.Fields.RefApplExtID Get(QuickFix.Fields.RefApplExtID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefApplExtID val) 
            { 
                return IsSetRefApplExtID();
            }
            
            public bool IsSetRefApplExtID() 
            { 
                return IsSetField(Tags.RefApplExtID);
            }
            public QuickFix.Fields.RefCstmApplVerID RefCstmApplVerID
            { 
                get 
                {
                    QuickFix.Fields.RefCstmApplVerID val = new QuickFix.Fields.RefCstmApplVerID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RefCstmApplVerID val) 
            { 
                this.RefCstmApplVerID = val;
            }
            
            public QuickFix.Fields.RefCstmApplVerID Get(QuickFix.Fields.RefCstmApplVerID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RefCstmApplVerID val) 
            { 
                return IsSetRefCstmApplVerID();
            }
            
            public bool IsSetRefCstmApplVerID() 
            { 
                return IsSetField(Tags.RefCstmApplVerID);
            }

        }
    }
}
