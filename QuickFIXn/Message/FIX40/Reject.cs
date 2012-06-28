// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX40 
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
                this.RefSeqNum = aRefSeqNum;
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
