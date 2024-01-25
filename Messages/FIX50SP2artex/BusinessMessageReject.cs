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

        }
    }
}
