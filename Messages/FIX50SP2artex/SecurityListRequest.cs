// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class SecurityListRequest : Message
        {
            public const string MsgType = "x";

            public SecurityListRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("x"));
            }

            public SecurityListRequest(
                    QuickFix.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.Fields.SecurityListRequestType aSecurityListRequestType
                ) : this()
            {
                this.SecurityReqID = aSecurityReqID;
                this.SecurityListRequestType = aSecurityListRequestType;
            }

            public QuickFix.Fields.SecurityReqID SecurityReqID
            {
                get
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityReqID val)
            {
                this.SecurityReqID = val;
            }

            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityReqID val)
            {
                return IsSetSecurityReqID();
            }

            public bool IsSetSecurityReqID()
            {
                return IsSetField(Tags.SecurityReqID);
            }

            public QuickFix.Fields.SecurityListRequestType SecurityListRequestType
            {
                get
                {
                    QuickFix.Fields.SecurityListRequestType val = new QuickFix.Fields.SecurityListRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityListRequestType val)
            {
                this.SecurityListRequestType = val;
            }

            public QuickFix.Fields.SecurityListRequestType Get(QuickFix.Fields.SecurityListRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityListRequestType val)
            {
                return IsSetSecurityListRequestType();
            }

            public bool IsSetSecurityListRequestType()
            {
                return IsSetField(Tags.SecurityListRequestType);
            }

        }
    }
}
