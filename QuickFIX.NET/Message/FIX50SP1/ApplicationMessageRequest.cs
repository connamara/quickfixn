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
                this.applReqID = aApplReqID;
                this.applReqType = aApplReqType;
            }

            public QuickFix.Fields.ApplReqID applReqID
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
                this.applReqID = val;
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
            public QuickFix.Fields.ApplReqType applReqType
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
                this.applReqType = val;
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
            public QuickFix.Fields.NoApplIDs noApplIDs
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
                this.noApplIDs = val;
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
            public QuickFix.Fields.Text text
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
                this.text = val;
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
            public QuickFix.Fields.EncodedTextLen encodedTextLen
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
                this.encodedTextLen = val;
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
            public QuickFix.Fields.EncodedText encodedText
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
                this.encodedText = val;
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
            public class NoApplIDs : Group
            {
                public NoApplIDs() 
                  :base( Tags.NoApplIDs, Tags.RefApplID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplBegSeqNum, Tags.ApplEndSeqNum, 0};
                            public QuickFix.Fields.RefApplID refApplID
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
                    this.refApplID = val;
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
                public QuickFix.Fields.ApplBegSeqNum applBegSeqNum
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
                    this.applBegSeqNum = val;
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
                public QuickFix.Fields.ApplEndSeqNum applEndSeqNum
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
                    this.applEndSeqNum = val;
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
