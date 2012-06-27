// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class ApplicationMessageRequest : Message
        {
            public const string MsgType = "BW";

            public ApplicationMessageRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BW"));
            }

            public ApplicationMessageRequest(
                    QuickFix.Fields.ApplReqID aApplReqID,
                    QuickFix.Fields.ApplReqType aApplReqType
                ) : this()
            {
                this.ApplReqID = aApplReqID;
                this.ApplReqType = aApplReqType;
            }

            public QuickFix.Fields.ApplReqID ApplReqID
            { 
                get 
                {
                    QuickFix.Fields.ApplReqID val = new QuickFix.Fields.ApplReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplReqID val) 
            { 
                this.ApplReqID = val;
            }
            
            public QuickFix.Fields.ApplReqID Get(QuickFix.Fields.ApplReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplReqID val) 
            { 
                return IsSetApplReqID();
            }
            
            public bool IsSetApplReqID() 
            { 
                return IsSetField(Tags.ApplReqID);
            }
            public QuickFix.Fields.ApplReqType ApplReqType
            { 
                get 
                {
                    QuickFix.Fields.ApplReqType val = new QuickFix.Fields.ApplReqType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplReqType val) 
            { 
                this.ApplReqType = val;
            }
            
            public QuickFix.Fields.ApplReqType Get(QuickFix.Fields.ApplReqType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplReqType val) 
            { 
                return IsSetApplReqType();
            }
            
            public bool IsSetApplReqType() 
            { 
                return IsSetField(Tags.ApplReqType);
            }
            public QuickFix.Fields.NoApplIDs NoApplIDs
            { 
                get 
                {
                    QuickFix.Fields.NoApplIDs val = new QuickFix.Fields.NoApplIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoApplIDs val) 
            { 
                this.NoApplIDs = val;
            }
            
            public QuickFix.Fields.NoApplIDs Get(QuickFix.Fields.NoApplIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoApplIDs val) 
            { 
                return IsSetNoApplIDs();
            }
            
            public bool IsSetNoApplIDs() 
            { 
                return IsSetField(Tags.NoApplIDs);
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
            public class NoApplIDsGroup : Group
            {
                public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, 0};
            
                public NoApplIDsGroup() 
                  :base( Tags.NoApplIDs, Tags.RefApplID, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoApplIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RefApplID RefApplID
                { 
                    get 
                    {
                        QuickFix.Fields.RefApplID val = new QuickFix.Fields.RefApplID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefApplID val) 
                { 
                    this.RefApplID = val;
                }
                
                public QuickFix.Fields.RefApplID Get(QuickFix.Fields.RefApplID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefApplID val) 
                { 
                    return IsSetRefApplID();
                }
                
                public bool IsSetRefApplID() 
                { 
                    return IsSetField(Tags.RefApplID);
                }
                public QuickFix.Fields.ApplBegSeqNum ApplBegSeqNum
                { 
                    get 
                    {
                        QuickFix.Fields.ApplBegSeqNum val = new QuickFix.Fields.ApplBegSeqNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    this.ApplBegSeqNum = val;
                }
                
                public QuickFix.Fields.ApplBegSeqNum Get(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    return IsSetApplBegSeqNum();
                }
                
                public bool IsSetApplBegSeqNum() 
                { 
                    return IsSetField(Tags.ApplBegSeqNum);
                }
                public QuickFix.Fields.ApplEndSeqNum ApplEndSeqNum
                { 
                    get 
                    {
                        QuickFix.Fields.ApplEndSeqNum val = new QuickFix.Fields.ApplEndSeqNum();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    this.ApplEndSeqNum = val;
                }
                
                public QuickFix.Fields.ApplEndSeqNum Get(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    return IsSetApplEndSeqNum();
                }
                
                public bool IsSetApplEndSeqNum() 
                { 
                    return IsSetField(Tags.ApplEndSeqNum);
                }
            
            }
        }
    }
}
