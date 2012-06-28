// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX40 
    {
        public class ResendRequest : Message
        {
            public const string MsgType = "2";

            public ResendRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("2"));
            }

            public ResendRequest(
                    QuickFix.Fields.BeginSeqNo aBeginSeqNo,
                    QuickFix.Fields.EndSeqNo aEndSeqNo
                ) : this()
            {
                this.BeginSeqNo = aBeginSeqNo;
                this.EndSeqNo = aEndSeqNo;
            }

            public QuickFix.Fields.BeginSeqNo BeginSeqNo
            { 
                get 
                {
                    QuickFix.Fields.BeginSeqNo val = new QuickFix.Fields.BeginSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BeginSeqNo val) 
            { 
                this.BeginSeqNo = val;
            }
            
            public QuickFix.Fields.BeginSeqNo Get(QuickFix.Fields.BeginSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BeginSeqNo val) 
            { 
                return IsSetBeginSeqNo();
            }
            
            public bool IsSetBeginSeqNo() 
            { 
                return IsSetField(Tags.BeginSeqNo);
            }
            public QuickFix.Fields.EndSeqNo EndSeqNo
            { 
                get 
                {
                    QuickFix.Fields.EndSeqNo val = new QuickFix.Fields.EndSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EndSeqNo val) 
            { 
                this.EndSeqNo = val;
            }
            
            public QuickFix.Fields.EndSeqNo Get(QuickFix.Fields.EndSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EndSeqNo val) 
            { 
                return IsSetEndSeqNo();
            }
            
            public bool IsSetEndSeqNo() 
            { 
                return IsSetField(Tags.EndSeqNo);
            }

        }
    }
}
