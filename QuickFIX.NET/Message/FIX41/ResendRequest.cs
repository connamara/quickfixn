using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class ResendRequest : Message
        {
            public ResendRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("2"));
            }

            public ResendRequest(
                    QuickFix.Fields.BeginSeqNo aBeginSeqNo,
                    QuickFix.Fields.EndSeqNo aEndSeqNo
                ) : this()
            {
                this.beginSeqNo = aBeginSeqNo;
                this.endSeqNo = aEndSeqNo;
            }

            public QuickFix.Fields.BeginSeqNo beginSeqNo
            { 
                get 
                {
                    QuickFix.Fields.BeginSeqNo val = new QuickFix.Fields.BeginSeqNo();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BeginSeqNo val) 
            { 
                this.beginSeqNo = val;
            }
            
            public QuickFix.Fields.BeginSeqNo get(QuickFix.Fields.BeginSeqNo val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BeginSeqNo val) 
            { 
                return isSetBeginSeqNo();
            }
            
            public bool isSetBeginSeqNo() 
            { 
                return isSetField(Tags.BeginSeqNo);
            }
            public QuickFix.Fields.EndSeqNo endSeqNo
            { 
                get 
                {
                    QuickFix.Fields.EndSeqNo val = new QuickFix.Fields.EndSeqNo();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EndSeqNo val) 
            { 
                this.endSeqNo = val;
            }
            
            public QuickFix.Fields.EndSeqNo get(QuickFix.Fields.EndSeqNo val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EndSeqNo val) 
            { 
                return isSetEndSeqNo();
            }
            
            public bool isSetEndSeqNo() 
            { 
                return isSetField(Tags.EndSeqNo);
            }

        }
    }
}
