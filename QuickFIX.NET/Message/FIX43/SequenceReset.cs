using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class SequenceReset : Message
        {
            public SequenceReset() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("4"));
            }

            public SequenceReset(
                    QuickFix.Fields.NewSeqNo aNewSeqNo
                ) : this()
            {
                this.newSeqNo = aNewSeqNo;
            }

            public QuickFix.Fields.GapFillFlag gapFillFlag
            { 
                get 
                {
                    QuickFix.Fields.GapFillFlag val = new QuickFix.Fields.GapFillFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.GapFillFlag val) 
            { 
                this.gapFillFlag = val;
            }
            
            public QuickFix.Fields.GapFillFlag get(QuickFix.Fields.GapFillFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.GapFillFlag val) 
            { 
                return isSetGapFillFlag();
            }
            
            public bool isSetGapFillFlag() 
            { 
                return isSetField(Tags.GapFillFlag);
            }
            public QuickFix.Fields.NewSeqNo newSeqNo
            { 
                get 
                {
                    QuickFix.Fields.NewSeqNo val = new QuickFix.Fields.NewSeqNo();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NewSeqNo val) 
            { 
                this.newSeqNo = val;
            }
            
            public QuickFix.Fields.NewSeqNo get(QuickFix.Fields.NewSeqNo val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NewSeqNo val) 
            { 
                return isSetNewSeqNo();
            }
            
            public bool isSetNewSeqNo() 
            { 
                return isSetField(Tags.NewSeqNo);
            }

        }
    }
}
