// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX41 
    {
        public class SequenceReset : Message
        {
            public const string MsgType = "4";

            public SequenceReset() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("4"));
            }

            public SequenceReset(
                    QuickFix.Fields.NewSeqNo aNewSeqNo
                ) : this()
            {
                this.NewSeqNo = aNewSeqNo;
            }

            public QuickFix.Fields.GapFillFlag GapFillFlag
            { 
                get 
                {
                    QuickFix.Fields.GapFillFlag val = new QuickFix.Fields.GapFillFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.GapFillFlag val) 
            { 
                this.GapFillFlag = val;
            }
            
            public QuickFix.Fields.GapFillFlag Get(QuickFix.Fields.GapFillFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.GapFillFlag val) 
            { 
                return IsSetGapFillFlag();
            }
            
            public bool IsSetGapFillFlag() 
            { 
                return IsSetField(Tags.GapFillFlag);
            }
            public QuickFix.Fields.NewSeqNo NewSeqNo
            { 
                get 
                {
                    QuickFix.Fields.NewSeqNo val = new QuickFix.Fields.NewSeqNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NewSeqNo val) 
            { 
                this.NewSeqNo = val;
            }
            
            public QuickFix.Fields.NewSeqNo Get(QuickFix.Fields.NewSeqNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NewSeqNo val) 
            { 
                return IsSetNewSeqNo();
            }
            
            public bool IsSetNewSeqNo() 
            { 
                return IsSetField(Tags.NewSeqNo);
            }

        }
    }
}
