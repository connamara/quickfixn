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
                this.Header.setField(new QuickFix.Fields.MsgType("BW"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplReqID val) 
            { 
                this.applReqID = val;
            }
            
            public QuickFix.Fields.ApplReqID get(QuickFix.Fields.ApplReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplReqID val) 
            { 
                return isSetApplReqID();
            }
            
            public bool isSetApplReqID() 
            { 
                return isSetField(Tags.ApplReqID);
            }
            public QuickFix.Fields.ApplReqType applReqType
            { 
                get 
                {
                    QuickFix.Fields.ApplReqType val = new QuickFix.Fields.ApplReqType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplReqType val) 
            { 
                this.applReqType = val;
            }
            
            public QuickFix.Fields.ApplReqType get(QuickFix.Fields.ApplReqType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplReqType val) 
            { 
                return isSetApplReqType();
            }
            
            public bool isSetApplReqType() 
            { 
                return isSetField(Tags.ApplReqType);
            }
            public QuickFix.Fields.NoApplIDs noApplIDs
            { 
                get 
                {
                    QuickFix.Fields.NoApplIDs val = new QuickFix.Fields.NoApplIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoApplIDs val) 
            { 
                this.noApplIDs = val;
            }
            
            public QuickFix.Fields.NoApplIDs get(QuickFix.Fields.NoApplIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoApplIDs val) 
            { 
                return isSetNoApplIDs();
            }
            
            public bool isSetNoApplIDs() 
            { 
                return isSetField(Tags.NoApplIDs);
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
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefApplID val) 
                { 
                    this.refApplID = val;
                }
                
                public QuickFix.Fields.RefApplID get(QuickFix.Fields.RefApplID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefApplID val) 
                { 
                    return isSetRefApplID();
                }
                
                public bool isSetRefApplID() 
                { 
                    return isSetField(Tags.RefApplID);
                }
                public QuickFix.Fields.ApplBegSeqNum applBegSeqNum
                { 
                    get 
                    {
                        QuickFix.Fields.ApplBegSeqNum val = new QuickFix.Fields.ApplBegSeqNum();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    this.applBegSeqNum = val;
                }
                
                public QuickFix.Fields.ApplBegSeqNum get(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ApplBegSeqNum val) 
                { 
                    return isSetApplBegSeqNum();
                }
                
                public bool isSetApplBegSeqNum() 
                { 
                    return isSetField(Tags.ApplBegSeqNum);
                }
                public QuickFix.Fields.ApplEndSeqNum applEndSeqNum
                { 
                    get 
                    {
                        QuickFix.Fields.ApplEndSeqNum val = new QuickFix.Fields.ApplEndSeqNum();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    this.applEndSeqNum = val;
                }
                
                public QuickFix.Fields.ApplEndSeqNum get(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ApplEndSeqNum val) 
                { 
                    return isSetApplEndSeqNum();
                }
                
                public bool isSetApplEndSeqNum() 
                { 
                    return isSetField(Tags.ApplEndSeqNum);
                }
            
            }
        }
    }
}
