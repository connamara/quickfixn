// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class BusinessMessageReject : Message
        {
            public const string MsgType = "j";

            public BusinessMessageReject() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("j"));
            }

            public BusinessMessageReject(
                    QuickFix.Fields.RefMsgType aRefMsgType,
                    QuickFix.Fields.BusinessRejectReason aBusinessRejectReason
                ) : this()
            {
                this.refMsgType = aRefMsgType;
                this.businessRejectReason = aBusinessRejectReason;
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
            public QuickFix.Fields.BusinessRejectRefID businessRejectRefID
            { 
                get 
                {
                    QuickFix.Fields.BusinessRejectRefID val = new QuickFix.Fields.BusinessRejectRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BusinessRejectRefID val) 
            { 
                this.businessRejectRefID = val;
            }
            
            public QuickFix.Fields.BusinessRejectRefID get(QuickFix.Fields.BusinessRejectRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BusinessRejectRefID val) 
            { 
                return isSetBusinessRejectRefID();
            }
            
            public bool isSetBusinessRejectRefID() 
            { 
                return isSetField(Tags.BusinessRejectRefID);
            }
            public QuickFix.Fields.BusinessRejectReason businessRejectReason
            { 
                get 
                {
                    QuickFix.Fields.BusinessRejectReason val = new QuickFix.Fields.BusinessRejectReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BusinessRejectReason val) 
            { 
                this.businessRejectReason = val;
            }
            
            public QuickFix.Fields.BusinessRejectReason get(QuickFix.Fields.BusinessRejectReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BusinessRejectReason val) 
            { 
                return isSetBusinessRejectReason();
            }
            
            public bool isSetBusinessRejectReason() 
            { 
                return isSetField(Tags.BusinessRejectReason);
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
            public QuickFix.Fields.RefApplVerID refApplVerID
            { 
                get 
                {
                    QuickFix.Fields.RefApplVerID val = new QuickFix.Fields.RefApplVerID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefApplVerID val) 
            { 
                this.refApplVerID = val;
            }
            
            public QuickFix.Fields.RefApplVerID get(QuickFix.Fields.RefApplVerID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefApplVerID val) 
            { 
                return isSetRefApplVerID();
            }
            
            public bool isSetRefApplVerID() 
            { 
                return isSetField(Tags.RefApplVerID);
            }
            public QuickFix.Fields.RefApplExtID refApplExtID
            { 
                get 
                {
                    QuickFix.Fields.RefApplExtID val = new QuickFix.Fields.RefApplExtID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefApplExtID val) 
            { 
                this.refApplExtID = val;
            }
            
            public QuickFix.Fields.RefApplExtID get(QuickFix.Fields.RefApplExtID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefApplExtID val) 
            { 
                return isSetRefApplExtID();
            }
            
            public bool isSetRefApplExtID() 
            { 
                return isSetField(Tags.RefApplExtID);
            }
            public QuickFix.Fields.RefCstmApplVerID refCstmApplVerID
            { 
                get 
                {
                    QuickFix.Fields.RefCstmApplVerID val = new QuickFix.Fields.RefCstmApplVerID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RefCstmApplVerID val) 
            { 
                this.refCstmApplVerID = val;
            }
            
            public QuickFix.Fields.RefCstmApplVerID get(QuickFix.Fields.RefCstmApplVerID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RefCstmApplVerID val) 
            { 
                return isSetRefCstmApplVerID();
            }
            
            public bool isSetRefCstmApplVerID() 
            { 
                return isSetField(Tags.RefCstmApplVerID);
            }

        }
    }
}
